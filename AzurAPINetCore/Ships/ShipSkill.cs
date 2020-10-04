﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Jan0660.AzurAPINetCore.Ships
{
    public class ShipSkill
    {
        [JsonProperty("icon")]
        public readonly string Icon;
        [JsonProperty("names")]
        public readonly Names Names;
        [JsonProperty("description")]
        public readonly string Description;
        [JsonProperty("color")]
        public readonly string Color;
    }
}
