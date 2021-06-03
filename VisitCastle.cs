using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class VisitCastle : IVisitTouristAttraction  //command
    {
        private Castle c;
        int closing_hour;
        public VisitCastle(Castle _c, int _closing_hour)
        {
            c = _c;
            closing_hour = _closing_hour;
        }
        public void Visit()
        {
            c.come_in(closing_hour);
        }
    }
}
