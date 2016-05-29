using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.Models
{
    public enum Mode
    {
        /// <summary>
        /// 美少女花骑士已经启动。
        /// </summary>
        NotStarted,

        /// <summary>
        /// 美少女花骑士还没有启动。
        /// </summary>
        Started,

        /// <summary>
        /// 美少女花骑士已经启动、出击中。
        /// </summary>
        InSortie,
    }
}
