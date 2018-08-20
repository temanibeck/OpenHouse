using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOpenHouse071618
{
    static class UI
    {
        public static bool UserAnswersYes(string question)
        {
            // TODO: improve this method and make it cleaner

            Console.WriteLine(question);

            string response = Console.ReadLine().ToUpper();

            if (response == "Y" || response == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
