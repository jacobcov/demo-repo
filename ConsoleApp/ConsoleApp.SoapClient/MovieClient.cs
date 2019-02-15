using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReference;

namespace ConsoleApp.SoapClient
{
   public class MovieClient
   {
      private static MovieTitleClient _mtc = new MovieTitleClient();

      public async static Task<List<Movie>> GetAll()
      {
         var movs = await _mtc.GetAllAsync();
         return movs.ToList();
         return (await _mtc.GetAllAsync()).ToList();
         return _mtc.GetAllAsync().GetAwaiter().GetResult().ToList();
      }
   }
}
