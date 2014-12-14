using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Headcases.Models.ApiModels
{
    public class ScoreData
    {
        public Conditions FeatureVector { get; set; }
        public Dictionary<string, string> GlobalParameters { get; set; }
    }

    public class ScoreRequest
    {
        public string Id { get; set; }
        public ScoreData Instance { get; set; }
    }
}