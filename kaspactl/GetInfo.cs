using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaspactl
{
    /// <summary>
    /// A .NET usage implementation of the kaspactl
    /// kaspactl rpc reference located here: https://github.com/kaspanet/docs
    /// Made by kaspa:qpje7d7x4w0hme7yzxtvas0qmj5h946p3vpxhag56wqwrkamfshxq4ev0kczz
    /// </summary>
    public class GetInfo
    {
        public class Rootobject
        {
            public Getinforesponse getInfoResponse { get; set; }
        }

        public class Getinforesponse
        {
            public string p2pId { get; set; }
            public string mempoolSize { get; set; }
            public string serverVersion { get; set; }
            public bool isUtxoIndexed { get; set; }
            public bool isSynced { get; set; }
            public object error { get; set; }
        }
    }
}
