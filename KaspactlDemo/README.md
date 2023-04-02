
kaspactl usage demo
===============

Donate address:
kaspa:qpje7d7x4w0hme7yzxtvas0qmj5h946p3vpxhag56wqwrkamfshxq4ev0kczz

Implementation in C#
----------------------------

kaspactl usage
----------

        AddPeer [Address] [IsPermanent]
        GetConnectedPeerInfo
        GetPeerAddresses
        GetCurrentNetwork
        GetInfo
        GetBlock [Hash] [IncludeTransactions]
        GetBlocks [LowHash] [IncludeBlocks] [IncludeTransactions]
        GetHeaders [StartHash] [Limit] [IsAscending]
        GetBlockCount
        GetBlockDagInfo
        GetSelectedTipHash
        GetVirtualSelectedParentBlueScore
        GetVirtualSelectedParentChainFromBlock [StartHash] [IncludeAcceptedTransactionIds]
        ResolveFinalityConflict [FinalityBlockHash]
        EstimateNetworkHashesPerSecond [WindowSize] [StartHash]
        GetBlockTemplate [PayAddress] [ExtraData]
        SubmitBlock [Block] [AllowNonDAABlocks]
        GetMempoolEntry [TxId] [IncludeOrphanPool] [FilterTransactionPool]
        GetMempoolEntries [IncludeOrphanPool] [FilterTransactionPool]
        GetMempoolEntriesByAddresses [Addresses] [IncludeOrphanPool] [FilterTransactionPool]
        SubmitTransaction [Transaction] [AllowOrphan]
        GetUtxosByAddresses [Addresses]
        GetBalanceByAddress [Address]
        GetCoinSupply
        Ban [Ip]
        Unban [Ip]

enjoy it.