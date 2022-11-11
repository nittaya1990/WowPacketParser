﻿using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("quest_template_locale")]
    public sealed record LocalesQuest : IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("locale", true)]
        public string Locale = ClientLocale.PacketLocaleString;

        [DBFieldName("LogTitle")]
        public string LogTitle;

        [DBFieldName("LogDescription")]
        public string LogDescription;

        [DBFieldName("QuestDescription")]
        public string QuestDescription;

        [DBFieldName("AreaDescription")]
        public string AreaDescription;

        [DBFieldName("PortraitGiverText")]
        public string PortraitGiverText;

        [DBFieldName("PortraitGiverName")]
        public string PortraitGiverName;

        [DBFieldName("PortraitTurnInText")]
        public string PortraitTurnInText;

        [DBFieldName("PortraitTurnInName")]
        public string PortraitTurnInName;

        [DBFieldName("QuestCompletionLog")]
        public string QuestCompletionLog;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
