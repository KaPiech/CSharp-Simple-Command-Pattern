using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class VisitArtGallery : IVisitTouristAttraction  //command
    {
        private ArtGallery g;
        float price;
        public VisitArtGallery(ArtGallery _g, float _price)
        {
            g = _g;
            price = _price;
        }
        public void Visit()
        {
            g.buy_ticket(price);
        }
    }
}
