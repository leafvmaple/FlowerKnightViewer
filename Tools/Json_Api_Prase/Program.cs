using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Json_Api_Prase
{
    class JTree
    {
        public string Key;
        public string Value;
        public string Class;
        public string Ext;
        public Collection<JTree> Childs;

        public JTree(string szKey, string szValue, string szClass, string szExt)
        {
            Key = szKey;
            Value = szValue;
            Class = szClass;
            Ext = szExt;
            Childs = new Collection<JTree>();
        }
    }

    class Program
    {
        static StreamWriter sWriter = null;
        static List<JTree> BFSList = new List<JTree>();
        static int unNameIndex = 0;
        static string szPreClass = null;

        public static JTree Prase(string szJson, string szKey, string szClass, string szExt)
        {

            if (szJson.StartsWith("{") && szJson.EndsWith("}"))
            {
                szJson = szJson.Substring(1, szJson.Length - 2);
                int nBracketsCount = 0;
                int nColonCount = 0;
                int nMarkCount = 0;
                int nArrayCount = 0;
                for (int i = 0; i < szJson.Length; i++)
                {
                    if (szJson[i] == '{')
                        nBracketsCount++;
                    else if (szJson[i] == '}')
                        nBracketsCount--;
                    else if (szJson[i] == ':' && nMarkCount == 0 && nBracketsCount == 0 && nArrayCount == 0)
                        nColonCount++;
                    else if (szJson[i] == '\"')
                        nMarkCount = (nMarkCount + 1) % 2;
                    else if (szJson[i] == '[')
                        nArrayCount++;
                    else if (szJson[i] == ']')
                        nArrayCount--;
                    else if (szJson[i] == ',' && nBracketsCount == 0 && nColonCount == 1 && nMarkCount == 0 && nArrayCount == 0)
                    {
                        szJson = szJson.Insert(i + 1, "&sp&");
                        nColonCount = 0;
                    }
                }
                string[] szObjArray = szJson.Split(new string[] { ",&sp&" }, StringSplitOptions.None);

                if (szKey == null) szKey = "Class" + unNameIndex++;

                JTree tree = new JTree(szKey, null, szClass, szExt);
                foreach (string szObj in szObjArray)
                    tree.Childs.Add(Prase(szObj, null, szKey, ""));
                return tree;
            }
            else if (szJson.StartsWith("[") && szJson.EndsWith("]"))
            {
                szJson = szJson.Substring(1, szJson.Length - 2);
                int nBracketsCount = 0;
                int nMarkCount = 0;
                int nArrayCount = 0;
                for (int i = 0; i < szJson.Length; i++)
                {
                    if (szJson[i] == '{')
                        nBracketsCount++;
                    else if (szJson[i] == '}')
                        nBracketsCount--;
                    else if (szJson[i] == '\"')
                        nMarkCount = (nMarkCount + 1) % 2;
                    else if (szJson[i] == '[')
                        nArrayCount++;
                    else if (szJson[i] == ']')
                        nArrayCount--;
                    else if (szJson[i] == ',' && nBracketsCount == 0 && nMarkCount == 0 && nArrayCount == 0)
                        szJson = szJson.Insert(i + 1, "&sp&");
                }
                string[] objArray = szJson.Split(new string[] { ",&sp&" }, StringSplitOptions.None);
                return Prase(objArray[0], szKey, szClass, szExt + "[]");
            }
            else
            {
                int nParam = 0;

                if (szJson.Length == 0)
                    return new JTree(szKey, "object", szClass, szExt);

                if (szJson[0] == '\"')
                {
                    nParam = szJson.IndexOf('\"', 1);
                    if (nParam == szJson.IndexOf("\":", 1))
                        return Prase(szJson.Substring(nParam + 2), szJson.Substring(1, nParam - 1), szClass, szExt);
                }
                
                if (int.TryParse(szJson, out nParam))
                    return new JTree(szKey, "long", szClass, szExt);
                return new JTree(szKey, "string", szClass, szExt);
            }
        }

        public static void DecodeBFS()
        {
            sWriter.WriteLine("using System;");
            sWriter.WriteLine("");
            sWriter.WriteLine("namespace FlowerWrapper.Models.Raw");
            sWriter.WriteLine("{");

            while (BFSList.Count > 0)
            {
                JTree node = BFSList.First();
                BFSList.RemoveAt(0);

                string szType = node.Childs.Count > 0 ? "fkapi_" + node.Key : node.Value;
                string szName = node.Key != null ? node.Key : "NoName" + unNameIndex++;

                if (szPreClass != node.Class)
                {
                    if (szPreClass != null)
                        sWriter.WriteLine("\t}");
                    sWriter.WriteLine("\tpublic class fkapi_" + node.Class);
                    sWriter.WriteLine("\t{");

                    szPreClass = node.Class;
                }

                if (szPreClass != null)
                    sWriter.WriteLine("\t\tpublic " + szType + node.Ext + " " + szName + " { get; set; }");
                else
                    sWriter.WriteLine("\t//" + szType + node.Ext + " " + szName + ";");

                szPreClass = node.Class;

                foreach (JTree child in node.Childs)
                    BFSList.Add(child);
                    
            }

            sWriter.WriteLine("\t}");
            sWriter.WriteLine("}");
        }

        static void Main(string[] args)
        {
            SearchAndDecode();
        }

        static void SearchAndDecode()
        {
            DirectoryInfo TheFolder = new DirectoryInfo(Environment.CurrentDirectory);

            //遍历文件
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {
                if (NextFile.Name.EndsWith(".api"))
                {
                    string FileName = NextFile.Name.Substring(0, NextFile.Name.Length - 4);

                    StreamReader sReader = new StreamReader(NextFile.Name, Encoding.Default);
                    FileStream fWriteStream = new FileStream("fkapi_" + FileName + ".cs", FileMode.Create);

                    sWriter = new StreamWriter(fWriteStream);

                    unNameIndex = 0;
                    szPreClass = null;

                    BFSList.Clear();

                    string szJson = sReader.ReadLine();
                    BFSList.Add(Prase(szJson, FileName, null, ""));

                    DecodeBFS();

                    sWriter.Close();
                    Console.WriteLine("解析 fkapi_" + FileName + ".cs");
                }
            }
            Console.WriteLine("按任意键结束...");
            Console.ReadKey();
        }
    }
}
