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
    public class GetBlockDagInfo
    {

        public class Rootobject
        {
            public Getblockdaginforesponse getBlockDagInfoResponse { get; set; }
        }

        public class Getblockdaginforesponse
        {
            public string networkName { get; set; }
            public string blockCount { get; set; }
            public string headerCount { get; set; }
            public string[] tipHashes { get; set; }
            public float difficulty { get; set; }
            public string pastMedianTime { get; set; }
            public string[] virtualParentHashes { get; set; }
            public string pruningPointHash { get; set; }
            public string virtualDaaScore { get; set; }
            public object error { get; set; }
        }
    }
}
