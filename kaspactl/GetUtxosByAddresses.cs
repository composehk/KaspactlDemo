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
    public class GetUtxosByAddresses
    {
        public class Rootobject
        {
            public Getutxosbyaddressesresponse getUtxosByAddressesResponse { get; set; }
        }

        public class Getutxosbyaddressesresponse
        {
            public Entry[] entries { get; set; }
            public object error { get; set; }
        }

        public class Entry
        {
            public string address { get; set; }
            public Outpoint outpoint { get; set; }
            public Utxoentry utxoEntry { get; set; }
        }

        public class Outpoint
        {
            public string transactionId { get; set; }
            public int index { get; set; }
        }

        public class Utxoentry
        {
            public string amount { get; set; }
            public Scriptpublickey scriptPublicKey { get; set; }
            public string blockDaaScore { get; set; }
            public bool isCoinbase { get; set; }
        }

        public class Scriptpublickey
        {
            public int version { get; set; }
            public string scriptPublicKey { get; set; }
        }
    }
}
