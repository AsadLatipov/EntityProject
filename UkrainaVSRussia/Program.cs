using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EntityProject.Service.Services;

namespace EntityProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            GroupService groupService = new GroupService();
            var res = await groupService.GetAllAsync();
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Teachers)
                {
                    Console.WriteLine(item2.FirstName);
                }
            }

        }

    }
}
