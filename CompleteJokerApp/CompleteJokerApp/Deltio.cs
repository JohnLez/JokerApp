using System;
using System.Collections.Generic;
using System.Text;

namespace CompleteJokerApp
{
    class Deltio
    {
        public int id { get; set; }
        public int[] numbers = new int[6];
        public int placed { get; set; }
        public double Winnings { get; set; }
        public DateTime TimePlayed { 
            get
            {
                return DateTime.Now;
            }
        }
        public Deltio()
        {
            numbers = GetRandomNumbers();
        }
        static int[] GetRandomNumbers()
        {
            Random selection = new Random();
            int[] RandomNumbers = new int[6];
            RandomNumbers[5] = selection.Next(1, 21);
            for (int i = 0; i < 5; i++)
            {
                RandomNumbers[i] = selection.Next(1, 46);
            }
            bool PureRandom = false;
            while (!PureRandom)
            {
                int counter = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 4; j > i; j--)
                    {
                        while (RandomNumbers[i] == RandomNumbers[j])
                        {
                            RandomNumbers[j] = selection.Next(1, 46);
                            counter++;
                        }
                    }
                }
                if (counter == 0)
                    PureRandom = true;
            }
            
            return RandomNumbers;
        }
    }
}
