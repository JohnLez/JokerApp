using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerFormsApp.Models
{
    public enum WinningPositings { JokerAndFive, Five, JokerAndFour, Four, JokerAndThree, Three, JokerAndTwo, JokerAndOne }
    public class Ticket
    {
        private static int idTracker = 0;
        public static int GetTicketId
        {
            get
            {
                int temp = idTracker;
                idTracker++;
                return temp;
            }
        }
        public int Id { get; private set; }
        public List<int> UpperNumbers { get; private set; }
        public int Joker { get; set; }

        public string NumbersPlayed 
        {
            get
            {
                string returnString = string.Empty;
                UpperNumbers.ForEach(n => returnString += $" {n}");
                return returnString;
            }
        }
        public double Winnings { get; set; }

        public WinningPositings? EarningsPlace { get; set; }

        public double Price { get; private set; }


        public Ticket(double price)
        {
            UpperNumbers = new List<int>(5);
            Id = GetTicketId;
            Winnings = 0;
            Price = price;
            EarningsPlace = null;
        }



        public void SetWinningPlace(int correctNumbersFound, bool foundJoker)
        {
            switch(correctNumbersFound)
            {
                case 1:
                    if (foundJoker)
                    {
                        this.EarningsPlace = WinningPositings.JokerAndOne;
                        Winnings = 1.5;
                    }
                    break;

                case 2:
                    if(foundJoker)
                    {
                        this.EarningsPlace = WinningPositings.JokerAndTwo;
                        Winnings = 2;
                    }
                    break;

                case 3:
                    if (foundJoker)
                    {
                        this.EarningsPlace = WinningPositings.JokerAndThree;
                        Winnings = 50;
                    }
                    else
                    {
                        this.EarningsPlace = WinningPositings.Three;
                        Winnings = 2;
                    }
                    break;

                case 4:
                    if (foundJoker)
                    {
                        this.EarningsPlace = WinningPositings.JokerAndFour;
                        Winnings = 2500;
                    }
                    else
                    {
                        this.EarningsPlace = WinningPositings.Four;
                        Winnings = 50;
                    }

                    break;

                case 5:
                    if (foundJoker)
                        this.EarningsPlace = WinningPositings.JokerAndFive;
                    else
                        this.EarningsPlace = WinningPositings.Five;
                    break;

                default:
                    this.EarningsPlace = null;
                    break;
            }
        }



        public static void ResetIdTracker()
        {
            idTracker = 0;
        }
    }
}
