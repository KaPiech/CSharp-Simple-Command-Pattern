using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class VisitMuseum : IVisitTouristAttraction  //command
    {
        private Museum m;
        float price;
        public VisitMuseum(Museum _m, float _price)
        {
            m = _m;
            price = _price;
        }
        public void Visit()
        {
            m.buy_ticket(price);
        }
    }
}
