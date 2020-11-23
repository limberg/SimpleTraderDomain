using SimpleTrader.Domain.Models;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using System;
using System.Threading.Tasks;

namespace ConsoleAppTestDB
{
    class Program
    {
        static  void Main(string[] args)
        {
            var dbContext = new SimpleTraderDbContextFactory();
            var userService = new GenericDataService<User>(dbContext);
            Task.Run(() =>
            {
                User user = userService.Create(new User { UserName = "Jacinto 123" }).Result;
                Console.WriteLine(user.Id);
                Console.ReadKey();
            }).Wait();
        }

    }
}
