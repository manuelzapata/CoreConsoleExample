using System;
using System.Runtime.Serialization;

namespace CoreConsoleExample.Model {

    [DataContract(Name = "results")]
    public class Film {

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "episode_id")]
        public int EpisodeNumber { get; set; }

    }

}