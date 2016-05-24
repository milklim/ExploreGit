using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1_ExploreGit
{
    class Program
    {
        static void Main()
        {
            BSAcademy BSA2016 = new BSAcademy(2016, BSAcademy.Stages.Stage2_FirstLestures);
            BSA2016.About();

            Console.ReadKey();
        }
    }
}
