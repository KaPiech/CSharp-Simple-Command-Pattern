using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class Castle    //receiver
    {
        public void come_in(int closing_hour) {
            Console.WriteLine("Wizyta w Starym Zamku -> Czynny do godziny " + closing_hour + ":00");
        }
    }
}
