using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1_ExploreGit
{
    class BSAcademy
    {
        private int year;
        private int CurrentStage { get; set; }
        private string info = "Binary Studio Academy (BSA) is an educational project aimed at bridging the knowledge gap between University curriculum and skills requirements for junior positions in IT companies.";

        public int Year
        {
            get { return year; }
            private set
            {
                if (value <= DateTime.Now.Year && value >= 2011)
                    year = value;
                else
                    throw new ArgumentException("The value of Year is not correct.");
            }
        }

        public enum Stages
        {
            Stage0_Registration = 1,
            Stage1_OnlineTest,
            Stage2_FirstLestures,
            Stage3_Studing,
            Stage4_Finish
        }

        public BSAcademy() : this(DateTime.Now.Year) { }
        public BSAcademy(int year, Stages st = Stages.Stage0_Registration)
        {
            this.Year = year;
            this.CurrentStage = (int)st;
        }

        public void About()
        {
            Console.WriteLine("About BSA:\n " + info);
        }
    }


}
