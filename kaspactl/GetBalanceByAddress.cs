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
    public class GetBalanceByAddress
    {

        public class Rootobject
        {
            public Getbalancebyaddressresponse getBalanceByAddressResponse { get; set; }
        }

        public class Getbalancebyaddressresponse
        {
            public string balance { get; set; }
            public object error { get; set; }
        }
    }
}
