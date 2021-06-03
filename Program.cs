using System;

namespace C7
{
    class Program   //client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ City trip ---------------------");
            //recivers
            ArtGallery cityArtGallery = new ArtGallery();
            Castle cityCastle = new Castle();
            Museum cityMuseum = new Museum();
            ObservationTower cityObservationTower = new ObservationTower();

            //trip number 1
            Console.WriteLine("\n------------ City trip wersja 1 ------------");
            TripScheduler schedule1 = new TripScheduler();
            VisitArtGallery command1 = new VisitArtGallery(cityArtGallery, 35);
            VisitCastle command2 = new VisitCastle(cityCastle, 21);
            VisitMuseum command3 = new VisitMuseum(cityMuseum, 17);
            VisitObservationTower command4 = new VisitObservationTower(cityObservationTower, 45);

            schedule1.commands_list.Add(command1);
            schedule1.commands_list.Add(command2);
            schedule1.commands_list.Add(command3);
            schedule1.commands_list.Add(command4);
            schedule1.Trip();

            //trip number 2
            Console.WriteLine("\n------------ City trip wersja 2 ------------");
            TripScheduler schedule2 = new TripScheduler();
            VisitCastle command5 = new VisitCastle(cityCastle, 19);
            VisitMuseum command6 = new VisitMuseum(cityMuseum, 50);
            VisitArtGallery command7 = new VisitArtGallery(cityArtGallery, 11);
            VisitObservationTower command8 = new VisitObservationTower(cityObservationTower, 15);

            schedule2.commands_list.Add(command5);
            schedule2.commands_list.Add(command6);
            schedule2.commands_list.Add(command7);
            schedule2.commands_list.Add(command8);
            schedule2.Trip();

            //trip number 3
            Console.WriteLine("\n------------ City trip wersja 3 ------------");
            TripScheduler schedule3 = new TripScheduler();
            VisitObservationTower command9 = new VisitObservationTower(cityObservationTower, 25);
            VisitArtGallery command10 = new VisitArtGallery(cityArtGallery, 70);
            VisitMuseum command11 = new VisitMuseum(cityMuseum, 20);
            VisitCastle command12 = new VisitCastle(cityCastle, 17);

            schedule3.commands_list.Add(command9);
            schedule3.commands_list.Add(command10);
            schedule3.commands_list.Add(command11);
            schedule3.commands_list.Add(command12);
            schedule3.Trip();
        }
    }
}
