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
    public class GetConnectedPeerInfo
    {

        public class Rootobject
        {
            public Getconnectedpeerinforesponse getConnectedPeerInfoResponse { get; set; }
        }

        public class Getconnectedpeerinforesponse
        {
            public Info[] infos { get; set; }
            public object error { get; set; }
        }

        public class Info
        {
            public string id { get; set; }
            public string address { get; set; }
            public string lastPingDuration { get; set; }
            public bool isOutbound { get; set; }
            public string timeOffset { get; set; }
            public string userAgent { get; set; }
            public int advertisedProtocolVersion { get; set; }
            public string timeConnected { get; set; }
            public bool isIbdPeer { get; set; }
        }
    }
}
