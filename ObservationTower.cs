using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class ObservationTower  //receiver
    {
        public void watch_city(float time) {
            Console.WriteLine("Wizyta w Wieży Widokowej -> Przewidywany czas zwiedzania wynosi " + time + " minut.");
        }
    }
}
