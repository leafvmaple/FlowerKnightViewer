using System;

namespace FlowerWrapper.Models.Raw
{
    //dmm_source_rpc[] source_rpc;
    public class dmm_source_rpc
	{
		public string id { get; set; }
		public fkapi_data data { get; set; }
	}
	public class fkapi_data
	{
		public string isOwner { get; set; }
		public string isViewer { get; set; }
		public string id { get; set; }
		public string nickname { get; set; }
		public string profileUrl { get; set; }
		public string thumbnailUrl { get; set; }
		public string userType { get; set; }
		public string displayName { get; set; }
	}
}
