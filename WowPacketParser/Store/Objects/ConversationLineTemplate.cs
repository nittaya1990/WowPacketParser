﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("conversation_line_template")]
    public sealed class ConversationLineTemplate : IDataModel
    {
        [DBFieldName("Id", true)]
        public uint? Id;

        [DBFieldName("StartTime", TargetedDatabase.Zero, TargetedDatabase.Shadowlands)]
        public uint? StartTime;

        [DBFieldName("UiCameraID")]
        public uint? UiCameraID;

        [DBFieldName("ActorIdx")]
        public byte? ActorIdx;

        [DBFieldName("Flags")]
        public byte? Flags;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
