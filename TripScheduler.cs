using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class TripScheduler //invoker
    {
        public List<IVisitTouristAttraction> commands_list; 
        
        public TripScheduler()
        {
            commands_list = new List<IVisitTouristAttraction>();
        }
        
        public void Trip() {
            foreach(IVisitTouristAttraction command in commands_list)
            {
                command.Visit();
            }
        }
    }
}
