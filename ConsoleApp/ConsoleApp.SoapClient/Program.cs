using System;

namespace ConsoleApp.SoapClient
{
   static class Program
   {
      static void Main(string[] args)
      {
         Display();
         Console.ReadLine();
      }

      static async void Display()
      {
         foreach (var mov in await MovieClient.GetAll())
         {
            Console.WriteLine(mov.title + "  " + mov.genre);
         }
      }
   }
}
