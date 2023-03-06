//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace TestWingman.Models
//{
//    internal class PlayerStatsOld
//    {


//        public string UserName { get; set; }
//        public string Platform { get; set; }
//        public List<Data> Datas { get; set; }

//        public Data[] Data { get; set; } // !
//    }

//    public class Data
//    {
//        [JsonPropertyName("Type")]
//        public string Type { get; set; }
//        [JsonPropertyName("attributes")]
//        public Attributes Attributes { get; set; }
//        [JsonPropertyName("metadata")]
//        public Metadata Metadata { get; set; }
//        public DateTime expiryDate { get; set; }
//        [JsonPropertyName("stats")]
//        public Stats Stats { get; set; }
//    }



//        public class Attributes
//        {
//            public string id { get; set; }
//        }

//        public class Metadata
//        {
//            public string name { get; set; }
//            public string imageUrl { get; set; }
//            public string tallImageUrl { get; set; }
//            public string bgImageUrl { get; set; }
//            public string portraitImageUrl { get; set; }

//            public string legendColor { get; set; }
//            public bool isActive { get; set; }
//        }

//    public class Stats
//    {
//        public Kills kills { get; set; }
//        public Killspermatch killsPerMatch { get; set; }
//        public Damagepermatch damagePerMatch { get; set; }
//        public Damage damage { get; set; }
//        public Matchesplayed matchesPlayed { get; set; }
//        public Droppoditemsforsquadmates droppodItemsForSquadmates { get; set; }
//        public Reviveshielddamageblocked reviveShieldDamageBlocked { get; set; }
//        public Bamboozles bamboozles { get; set; }
//        public Season7kills season7Kills { get; set; }
//        public Season11wins season11Wins { get; set; }
//        public Season11kills season11Kills { get; set; }
//    }

//    public class Kills
//    {
//        public double? rank { get; set; }
//        public double? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata1 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata1
//    {
//    }

//    public class Killspermatch
//    {
//        public object rank { get; set; }
//        public float? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata2 metadata { get; set; }
//        public float? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata2
//    {
//    }

//    public class Damagepermatch
//    {
//        public object rank { get; set; }
//        public double? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata3 metadata { get; set; }
//        public float? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata3
//    {
//    }

//    public class Damage
//    {
//        public double? rank { get; set; }
//        public double? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata4 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata4
//    {
//    }

//    public class Matchesplayed
//    {
//        public object rank { get; set; }
//        public double? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata5 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata5
//    {
//    }

//    public class Droppoditemsforsquadmates
//    {
//        public object rank { get; set; }
//        public double? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata6 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata6
//    {
//    }

//    public class Reviveshielddamageblocked
//    {
//        public object rank { get; set; }
//        public double? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata7 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata7
//    {
//    }

//    public class Bamboozles
//    {
//        public object rank { get; set; }
//        public double? percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata8 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata8
//    {
//    }

//    public class Season7kills
//    {
//        public object rank { get; set; }
//        public object percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata9 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata9
//    {
//    }

//    public class Season11wins
//    {
//        public object rank { get; set; }
//        public object percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata10 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata10
//    {
//    }

//    public class Season11kills
//    {
//        public object rank { get; set; }
//        public object percentile { get; set; }
//        public string displayName { get; set; }
//        public string displayCategory { get; set; }
//        public object category { get; set; }
//        public object description { get; set; }
//        public Metadata11 metadata { get; set; }
//        public double? value { get; set; }
//        public string displayValue { get; set; }
//        public string displayType { get; set; }
//    }

//    public class Metadata11
//    {
//    }



//}

