using System.Threading.Tasks;
using Statiq.Web;
using Statiq.App;

namespace MyBlog
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
        await Bootstrapper.Factory.CreateWeb(args).RunAsync();

    }
}
