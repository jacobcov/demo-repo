using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MovieService.Soap.Models
{
   [Obsolete("As of Feb 12, 2019, this contract will be deprecated in Dec 2019. We recommend switching to Movie2 as soon as able.")]
   [DataContract]
   public class Movie
   {
      [DataMember]
      public string title { get; set; }

      [DataMember]
      public string genre { get; set; }

      public Movie(string t)
      {
         title = t;
         genre = "Drama";
      }
   }
}