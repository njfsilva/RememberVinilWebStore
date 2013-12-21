using System;

namespace BackOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputs = LastFmHelper.GetArtistTopTracks("Eminem");

            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }

            Console.WriteLine(GeocodingHelper.GetDistanceBetweenPlaces("rua jose cardoso pires 22 rio tinto PT", "travessa da boavista 22 rio tinto PT"));

            Console.ReadLine();
            // Filipe
        }
    }
}
