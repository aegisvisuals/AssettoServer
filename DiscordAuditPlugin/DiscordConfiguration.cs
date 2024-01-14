﻿using JetBrains.Annotations;
using YamlDotNet.Serialization;

namespace DiscordAuditPlugin;

[UsedImplicitly(ImplicitUseKindFlags.Assign, ImplicitUseTargetFlags.WithMembers)]
public class DiscordConfiguration
{
    [YamlMember(Description = "Avatar picture URL")]
    public string? PictureUrl { get; init; }
    [YamlMember(Description = "Discord webhook URL for kick/ban events")]
    public string? AuditUrl { get; init; }
    [YamlMember(Description = "Discord webhook URL for chat messages")]
    public string? ChatUrl { get; init; }
    [YamlMember(Description = "Set this to true if the Discord username of the bot should be the AC server name")]
    public bool ChatMessageIncludeServerName { get; init; } = false;
    [YamlMember(Description = "Optional list of SteamIDs whose chat messages should not be forwarded to Discord")]
    public List<ulong>? ChatIgnoreGuids { get; init; } = [];
}
