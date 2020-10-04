﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jan0660.AzurAPINetCore.Chapters
{
    public class Chapter
    {
        [JsonProperty("1")]
        public readonly Mission Mission1;
        [JsonProperty("2")]
        public readonly Mission Mission2;
        [JsonProperty("3")]
        public readonly Mission Mission3;
        [JsonProperty("4")]
        public readonly Mission Mission4;
        [JsonIgnore]
        public List<Mission> Missions
        {
            get
            {
                List<Mission> missions = new List<Mission>() { Mission1, Mission2, Mission3, Mission4 };
                return missions;
            }
        }
        [JsonProperty("names")]
        public readonly Names Names;
    }
}