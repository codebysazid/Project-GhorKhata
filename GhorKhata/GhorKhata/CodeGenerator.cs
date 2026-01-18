using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhorKhata
{
    internal class CodeGenerator
    {
        private static Random random = new Random();

        public static string SixDigitCode()
        {
            int number = random.Next(0, 1000);
            return number.ToString("D3");
        }
    }
}
