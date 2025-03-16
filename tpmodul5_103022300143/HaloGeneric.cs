using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpmodul5_103022300143
{
    public class HaloGeneric
    {
        public static void sapaUser<T>(T user)
        {
            Console.WriteLine($"halo user {user}");
        }
    }
}
