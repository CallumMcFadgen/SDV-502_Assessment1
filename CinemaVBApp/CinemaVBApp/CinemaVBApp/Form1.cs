using System;

namespace CinemaVBApp
{
    public partial class Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public decimal Adult_Before_5(int quantity, string person, string day, decimal time)
        {
            decimal total_price = 14.5M;
            return total_price;
        }

        public decimal Adult_After_5(int quantity, string person, string day, int time)
        {
            var total_price = default(decimal);
            return total_price;
        }

        private void Cinemas_Load(object sender, EventArgs e)
        {
        }
    }
}