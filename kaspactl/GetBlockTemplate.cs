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
    public class GetBlockTemplate
    {

        public class Rootobject
        {
            public Getblocktemplateresponse getBlockTemplateResponse { get; set; }
        }

        public class Getblocktemplateresponse
        {
            public Block block { get; set; }
            public bool isSynced { get; set; }
            public object error { get; set; }
        }

        public class Block
        {
            public Header header { get; set; }
            public Transaction[] transactions { get; set; }
            public object verboseData { get; set; }
        }

        public class Header
        {
            public int version { get; set; }
            public Parent[] parents { get; set; }
            public string hashMerkleRoot { get; set; }
            public string acceptedIdMerkleRoot { get; set; }
            public string utxoCommitment { get; set; }
            public string timestamp { get; set; }
            public int bits { get; set; }
            public string nonce { get; set; }
            public string daaScore { get; set; }
            public string blueWork { get; set; }
            public string pruningPoint { get; set; }
            public string blueScore { get; set; }
        }

        public class Parent
        {
            public string[] parentHashes { get; set; }
        }

        public class Transaction
        {
            public int version { get; set; }
            public Input[] inputs { get; set; }
            public Output[] outputs { get; set; }
            public string lockTime { get; set; }
            public string subnetworkId { get; set; }
            public string gas { get; set; }
            public string payload { get; set; }
            public object verboseData { get; set; }
        }

        public class Input
        {
            public Previousoutpoint previousOutpoint { get; set; }
            public string signatureScript { get; set; }
            public string sequence { get; set; }
            public int sigOpCount { get; set; }
            public object verboseData { get; set; }
        }

        public class Previousoutpoint
        {
            public string transactionId { get; set; }
            public int index { get; set; }
        }

        public class Output
        {
            public string amount { get; set; }
            public Scriptpublickey scriptPublicKey { get; set; }
            public object verboseData { get; set; }
        }

        public class Scriptpublickey
        {
            public int version { get; set; }
            public string scriptPublicKey { get; set; }
        }
    }
}
