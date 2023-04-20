using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Xml.Linq;

namespace CodeHomeWork_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                context.Database.EnsureCreated();
            }
        }
    }
}