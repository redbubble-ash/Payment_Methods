using System;
using System.Collections.Generic;
using System.Text;

namespace Payment_Methods
{
    internal class Credit_Cards : Payment_Method
    {
        private string[] name;
        private int card_number;
        private DateTime expirationDate;
        private int CVV;

        public Credit_Cards(string[] name, int card_number, DateTime expirationDate, int CVV)
        {
            this.name = name;
            this.card_number = card_number;
            this.expirationDate = expirationDate;
            this.CVV = CVV;
        }

        public override void paymentDetails()
        {
        }
    }
}