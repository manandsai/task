using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    [Serializable ]    
     public class Program
    {
        static void Main(string[] args)
        {
              Menu menu = new Menu();
              menu.MenuList();
        }
    }
}
