using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CoreConsoleExample.Model {

    [DataContract(Name = "result")]
    public class Result<T> {

        [DataMember(Name = "results")]
        public List<T> Results { get; set; }

    }

}