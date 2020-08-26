using System;

namespace CinemaApp
{
    public partial class Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public decimal Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time)
        {
            decimal ticket_price = 14.50M;
            decimal result = 0.00M;

            if (pr_person.ToLower() == "adult")
            {
                if (pr_day.ToLower() == "tuesday" || pr_quantity < 1 || pr_time >= 5)
                {
                    return result;
                }
                else
                {
                    result = (ticket_price * pr_quantity);
                    return result;
                }
            }
            else
            {
                return result;
            }
        }

        public decimal Adult_After_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time)
        {
            decimal ticket_price = 17.50M;
            decimal result = 0.00M;

            if (pr_person.ToLower() == "adult")
            {
                if (pr_day.ToLower() == "tuesday" || pr_quantity < 1 || pr_time <= 5)
                {
                    return result;
                }
                else
                {
                    result = (ticket_price * pr_quantity);
                    return result;
                }
            }
            else
            {
                return result;
            }
        }

        public decimal Adult_Tuesday(int pr_quantity, string pr_person, string pr_day)
        {
            decimal ticket_price = 13.00M;
            decimal result = 0.00M;

            if (pr_person.ToLower() == "adult" && pr_day.ToLower() == "tuesday")
            {
                if  (pr_quantity < 1)
                {
                    return result;
                }
                else
                {
                    result = (ticket_price * pr_quantity);
                    return result;
                }
            }
            else
            {
                return result;
            }
        }


        private void Cinemas_Load(object sender, EventArgs e)
        {
        }
    }
}