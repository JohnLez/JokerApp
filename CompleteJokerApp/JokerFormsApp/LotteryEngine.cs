using JokerFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerFormsApp
{
    internal class LotteryEngine
    {

        public Random Rng { get; private set; }
        public double PrizePool { get; private set; }

        public double MoneyDistributed { get; private set; }
        public double TotalMoneyDistributed { get; private set; }

        public List<int> WinningUpperNumers { get; private set; }
        public int WinningJokerNumber { get; private set; }


        public Ticket WinningTicket { get; private set; }
        public Stopwatch Stopwatch { get; private set; }

        public LotteryEngine()
        {
            Stopwatch = new Stopwatch();
            WinningUpperNumers = new List<int>(5);
            Rng = new Random();
            PrizePool = 0;
            MoneyDistributed = 0;
            TotalMoneyDistributed = 0;
        }

        public async Task<List<Ticket>> InitiateLottery(int ticketsNumber, double ticketPrice)
        {
            Ticket.ResetIdTracker();
            Stopwatch.Reset();
            Stopwatch.Start();

            PrizePool += ticketsNumber * ticketPrice;

            List<Ticket> lotteryTickets = new List<Ticket>();
            for (int i = 0; i < ticketsNumber; i++)
            {
                lotteryTickets.Add(await GenerateTicketAsync(ticketPrice));
            }


            WinningTicket = await GenerateTicketAsync(0);  

            foreach (var ticket in lotteryTickets)
            {
                CalculateTicketPlace(ticket, WinningTicket);
                PrizePool -= ticket.Winnings;
                MoneyDistributed += ticket.Winnings;
            }

            List<Ticket> fiveAndOneWinners = lotteryTickets.Where(t => t.EarningsPlace == WinningPositings.JokerAndFive).ToList();
            List<Ticket> fiveOnlyWinners = lotteryTickets.Where(t => t.EarningsPlace == WinningPositings.Five).ToList();

            DistributeBigWinnersPrizes(fiveAndOneWinners, fiveOnlyWinners);

            TotalMoneyDistributed += MoneyDistributed;
            Stopwatch.Stop();


            return lotteryTickets;
        }



        private async Task<Ticket> GenerateTicketAsync(double ticketPrice)
        {
            Ticket newTicket = new Ticket(ticketPrice);
            newTicket.Joker = Rng.Next(1, 21);
            while (newTicket.UpperNumbers.Count != 5)
            {
                int randomUpperNumber = Rng.Next(1, 46);
                if (!newTicket.UpperNumbers.Contains(randomUpperNumber))
                    newTicket.UpperNumbers.Add(randomUpperNumber);
            }
            return newTicket;
        }

        private void CalculateTicketPlace(Ticket lotteryTicket, Ticket winningTicket)
        {
            int correctNumbersAmount = winningTicket.UpperNumbers.Where(n => lotteryTicket.UpperNumbers.Any(tun => tun == n)).ToList().Count;
            bool foundJoker = lotteryTicket.Joker == winningTicket.Joker;
            lotteryTicket.SetWinningPlace(correctNumbersAmount, foundJoker);
        }

        private void DistributeBigWinnersPrizes(List<Ticket> fiveAndOneWinners, List<Ticket> fiveOnlyWinners)
        {
            double bigWinnersPrize = PrizePool * 92 / 100;
            double secondPlaceWinnersPrize = PrizePool * 8 / 100;

            foreach (var ticket in fiveAndOneWinners)
            {
                ticket.Winnings = bigWinnersPrize / fiveAndOneWinners.Count;
                PrizePool -= ticket.Winnings;
                MoneyDistributed += ticket.Winnings;
            }

            foreach (var ticket in fiveOnlyWinners)
            {
                ticket.Winnings = secondPlaceWinnersPrize / fiveOnlyWinners.Count;
                PrizePool -= ticket.Winnings;
                MoneyDistributed += ticket.Winnings;
            }
        }

    }
}


//private Tuple<int, List<int>> GetWinningCombo()
//{
//    int winningJoker = Rng.Next(1, 21);
//    var winningUpperNumbers = new List<int>(5);
//    while (winningUpperNumbers.Count != 5)
//    {
//        int newRandomNumber = Rng.Next(1, 46);
//        if (!winningUpperNumbers.Contains(newRandomNumber))
//            winningUpperNumbers.Add(newRandomNumber);
//    }

//    return new Tuple<int, List<int>>(winningJoker, winningUpperNumbers);
//}