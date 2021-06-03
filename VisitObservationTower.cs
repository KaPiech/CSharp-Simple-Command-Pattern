using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class VisitObservationTower : IVisitTouristAttraction  //command
    {
        private ObservationTower o;
        float time;
        public VisitObservationTower(ObservationTower _o, float _time)
        {
            o = _o;
            time = _time;
        }
        public void Visit()
        {
            o.watch_city(time);
        }
    }
}

