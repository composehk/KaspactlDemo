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
    public class GetVirtualSelectedParentChainFromBlock
    {

        public class Rootobject
        {
            public Getvirtualselectedparentchainfromblockresponse getVirtualSelectedParentChainFromBlockResponse { get; set; }
        }

        public class Getvirtualselectedparentchainfromblockresponse
        {
            public object[] removedChainBlockHashes { get; set; }
            public string[] addedChainBlockHashes { get; set; }
            public Acceptedtransactionid[] acceptedTransactionIds { get; set; }
            public object error { get; set; }
        }

        public class Acceptedtransactionid
        {
            public string acceptingBlockHash { get; set; }
            public string[] acceptedTransactionIds { get; set; }
        }

    }
}
