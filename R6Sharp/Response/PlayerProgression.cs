﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace R6Sharp.Response
{
    public class PlayerProgressionFetch
    {
        [JsonPropertyName("player_profiles")]
        public List<PlayerProgression> PlayerProgressions { get; set; }
    }

    public class PlayerProgression
    {
        [JsonPropertyName("xp")]
        public int XP { get; set; }

        [JsonPropertyName("profile_id")]
        public Guid ProfileId { get; set; }

        [JsonPropertyName("lootbox_probability")]
        public int LootboxProbability { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        public Uri ProfileIcon { get; set; }
    }
}