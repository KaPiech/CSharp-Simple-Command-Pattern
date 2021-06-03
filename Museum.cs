using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class Museum    //receiver
    {
        public void buy_ticket(float price) {
            Console.WriteLine("Wizyta w Muzeum -> cena biletu wstepu: " + price + "[zl]");
        }
    }
}
