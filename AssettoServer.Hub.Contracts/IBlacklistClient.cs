﻿using System.Runtime.Serialization;
using System.ServiceModel;
using ProtoBuf.Grpc;

namespace AssettoServer.Hub.Contracts;

[DataContract]
public class BlacklistSubscriptionResponse
{
    [DataMember(Order = 1)]
    public IReadOnlyList<ulong> Entries { get; set; } = new List<ulong>();
}

[DataContract]
public class BlacklistAddRequest
{
    [DataMember(Order = 1)]
    public ulong Guid { get; set; }
}

[ServiceContract]
public interface IBlacklistClient
{
    [OperationContract]
    IAsyncEnumerable<BlacklistSubscriptionResponse> SubscribeAsync(CallContext context = default);

    [OperationContract]
    Task AddAsync(BlacklistAddRequest request, CallContext context = default);
}
