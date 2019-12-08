using System;
using System.Collections.Generic;

namespace CompleteJokerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //estc//test2
            double prizepool = 0; //To keep track of previous draw funds
            bool run = true;      //Program loop operator
            while (run)
            {
                Console.Clear();
                int DeltiaOf51 = 0; //# of deltia that had a correct 5 + 1 numbers sequence
                int DeltiaOf50 = 0;
                int DeltiaOf41 = 0;
                int DeltiaOf40 = 0;
                double prizefor51; //# the prize each of the winners of the equivalent sequence is going to get
                double prizefor50;
                double prizefor41;
                double prizefor40;
                List<Deltio> TotalDraws = new List<Deltio>(); //List of objexts Deltio 
                Deltio WinningDELTIO = new Deltio(); //Populating the first Object , in this case the Winning numbers| can also be set later rather than now
                WinningDELTIO.id = 0; //giving the id number 0 in our property of class Deltio 
                TotalDraws.Add(WinningDELTIO); //Populating list with new item
                for (int i = 0; i < 5000000; i++) //#of Deltia to play
                {
                    TotalDraws.Add(RandomDeltio(TotalDraws)); 
                }
                for (int i = 1; i < TotalDraws.Count; i++)
                {
                    int DELTIOresult = CompareDeltia(i, TotalDraws, WinningDELTIO.numbers); // CompareDeltia return an int that depending on its value, enables the correct IFs bellow
                    if (DELTIOresult > 9)
                    {
                        if (DELTIOresult == 15)
                        {
                            TotalDraws[i].placed = 51;
                            DeltiaOf51++;
                        }
                        if (DELTIOresult == 14)
                        {
                            TotalDraws[i].placed = 41;
                            DeltiaOf41++;
                        }
                    }
                    if (DELTIOresult == 5)
                    {
                        TotalDraws[i].placed = 50;
                        DeltiaOf50++;
                    }
                    if (DELTIOresult == 4)
                    {
                        TotalDraws[i].placed = 40;
                        DeltiaOf40++;
                    }

                }

                prizepool += (TotalDraws.Count - 1) * 0.5; //Assuming each Deltio costs 0.50$
                if (DeltiaOf51 != 0)
                    prizefor51 = Math.Round(((prizepool * 80) / 100) / DeltiaOf51,MidpointRounding.ToZero);
                else
                    prizefor51 = 0;
                if (DeltiaOf50 != 0)
                    prizefor50 = Math.Round(((prizepool * 12) / 100) / DeltiaOf50,MidpointRounding.ToZero);
                else
                    prizefor50 = 0;
                if (DeltiaOf41 != 0)
                    prizefor41 = Math.Round(((prizepool * 5) / 100) / DeltiaOf41,MidpointRounding.ToZero);
                else
                    prizefor41 = 0;
                if (DeltiaOf40 != 0)
                    prizefor40 = Math.Round(((prizepool * 2) / 100) / DeltiaOf40, MidpointRounding.ToZero);
                else
                    prizefor40 = 0;

                

                foreach (Deltio RandomDeltio in TotalDraws) //Storing the winnings property of each object depending on the the placed property (this should be done inside the class itself)
                {
                    if (RandomDeltio.placed == 51)
                        RandomDeltio.Winnings = prizefor51;
                    if (RandomDeltio.placed == 50)
                        RandomDeltio.Winnings = prizefor50;
                    if (RandomDeltio.placed == 41)
                        RandomDeltio.Winnings = prizefor41;
                    if (RandomDeltio.placed == 40)
                        RandomDeltio.Winnings = prizefor40;

                }



                Console.WriteLine($"Winning Numbers are: {TotalDraws[0].numbers[0]} {TotalDraws[0].numbers[1]} {TotalDraws[0].numbers[2]} {TotalDraws[0].numbers[3]} {TotalDraws[0].numbers[4]}\nAnd Joker: {TotalDraws[0].numbers[5]}");
                Console.WriteLine($" {DeltiaOf51} People won the Joker!");
                Console.WriteLine($"Prize:  {prizepool} $");
                Console.WriteLine($" {DeltiaOf51} People achieved a 5 + 1 sequence for a prize of: {prizefor51*DeltiaOf51} $");
                Console.WriteLine($" {DeltiaOf50} People achieved a 5 + 0 sequencef or a total prize of: {prizefor50*DeltiaOf50} $");
                Console.WriteLine($" {DeltiaOf41} People achieved a 4 + 1 sequence for a total prize of: {prizefor41*DeltiaOf41} $");
                Console.WriteLine($" {DeltiaOf40} People achieved a 4 + 0 sequence for a total prize of: {prizefor40*DeltiaOf40} $");
                
                Console.WriteLine("Press 1 to see Joker Winners");
                Console.WriteLine("Press 2 to see People who achieved a 5 + 0 sequence");
                Console.WriteLine("Press 3 to see People who achieved a 4 + 1 sequence");
                Console.WriteLine("Press 4 to see People who achieved a 4 + 0 sequence");
                Console.WriteLine("Press 5 to Exit");
                Console.WriteLine("Press any other key to start a new Draw!");
                string choice = Console.ReadLine();
                switch (choice)
                {

                    case "1":
                        foreach (Deltio draw in TotalDraws)
                        {
                            PrintWinners(draw, 51);
                        }
                        break;
                    case "2":

                        foreach (Deltio draw in TotalDraws)
                        {
                            PrintWinners(draw, 50);
                        }
                        break;
                    case "3":
                        foreach (Deltio draw in TotalDraws)
                        {
                            PrintWinners(draw, 41);
                        }
                        break;
                    case "4":
                        foreach (Deltio draw in TotalDraws)
                        {
                            PrintWinners(draw, 40);
                        }
                        break;
                    case "5":
                        run = false;
                        Console.WriteLine("Bye!");
                        break;
                    default:

                        break;
                }
                prizepool -= prizefor40 + prizefor41 + prizefor50 + prizefor51;
                Math.Round(prizepool, MidpointRounding.ToZero );
                Console.ReadKey();
            }


        }
        static Deltio RandomDeltio(List<Deltio> TotalDraws)
        {
            Deltio newDeltio = new Deltio();
            newDeltio.id = TotalDraws.Count;
            return newDeltio;
        }

        static int CompareDeltia(int indexer, List<Deltio> TotalDraws, int[] WinningDeltio)
        {
            int[] CompareNumbers = TotalDraws[indexer].numbers;
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (CompareNumbers[i] == WinningDeltio[j])
                        counter++;
                }
            }
            if (CompareNumbers[5] == WinningDeltio[5])
                counter += 10;
            return counter;
        }
        static void PrintWinners(Deltio RandomDeltio, int sequence)
        {

            if (RandomDeltio.placed == sequence)
                Console.WriteLine($"Deltio ID #{RandomDeltio.id}\nNumbers Picked: {RandomDeltio.numbers[0]} {RandomDeltio.numbers[1]} {RandomDeltio.numbers[2]} {RandomDeltio.numbers[3]} {RandomDeltio.numbers[4]}\nJoker:{RandomDeltio.numbers[5]}\nWon:{RandomDeltio.Winnings} $\nDeltio Played at: {RandomDeltio.TimePlayed.ToShortTimeString()} {Environment.NewLine}");

        }
    }
}
