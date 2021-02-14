using JokerFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokerFormsApp
{
    public partial class MainForm : Form
    {

        private LotteryEngine lotteryEngine;
        public MainForm()
        {
            InitializeComponent(); 
            lotteryEngine = new LotteryEngine();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            rtxtBoxDescription.Text = "\t\t\t\tThis application intends to simulate the famous Joker lottery game along with tracking of all the tickets - prizes - and consecutive prize pool";

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;


            int ticketsNumber = int.Parse(txtTicketsNumber.Text);

            var tickets = lotteryEngine.InitiateLottery(ticketsNumber, 2).Result; ;

            txtSyncTime.Text = $"{lotteryEngine.Stopwatch.ElapsedMilliseconds} ms";

            var winners = tickets.Where(t => t.EarningsPlace == WinningPositings.JokerAndFive).ToList();
            var winners50 = tickets.Where(t => t.EarningsPlace == WinningPositings.Five).ToList();
            var winners41 = tickets.Where(t => t.EarningsPlace == WinningPositings.JokerAndFour).ToList();
            var winners40 = tickets.Where(t => t.EarningsPlace == WinningPositings.Four).ToList();
            var winners31 = tickets.Where(t => t.EarningsPlace == WinningPositings.JokerAndThree).ToList();
            var winners30 = tickets.Where(t => t.EarningsPlace == WinningPositings.Three).ToList();
            var winners21 = tickets.Where(t => t.EarningsPlace == WinningPositings.JokerAndTwo).ToList();
            var winners11 = tickets.Where(t => t.EarningsPlace == WinningPositings.JokerAndOne).ToList();

            dataGridWinningTicket.DataSource = new List<Ticket>() { lotteryEngine.WinningTicket };

            datagridWinners.DataSource = winners;
            dataGridFive.DataSource = winners50;
            dataGridFourAndOne.DataSource = winners41;
            datagridFour.DataSource = winners40;
            dataGridThreeAndOne.DataSource = winners31;
            dataGridThree.DataSource = winners30;
            dataGridTwoAndOne.DataSource = winners21;
            dataGridOneAndOne.DataSource = winners11;

            txtPrizePool.Text = $"{lotteryEngine.PrizePool.ToString($"{0:n}")} €";
            txtMoneyDistributed.Text = $"{lotteryEngine.MoneyDistributed.ToString($"{0:n}")} €";
            txtTotalMoneyDistributed.Text = $"{lotteryEngine.TotalMoneyDistributed.ToString($"{0:n}")} €";
        }

        private bool ValidateInput()
        {
            bool numberInserted = int.TryParse(txtTicketsNumber.Text, out int ticketsNumber);

            if (!numberInserted)
            {
                MessageBox.Show("Please enter an integer", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ticketsNumber == 0)
            {
                MessageBox.Show("Value cannot be 0", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return numberInserted;
        }


    }
}
