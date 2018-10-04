using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main () {
            HashSet<string> ShowRoom = new HashSet<string> ();

            ShowRoom.Add ("Altima");
            ShowRoom.Add ("Jugo");
            ShowRoom.Add ("Element");
            ShowRoom.Add ("Janky");
            ShowRoom.Add ("Janky");

            // Console.WriteLine (ShowRoom.Count);

            HashSet<string> UsedLot = new HashSet<string> ();

            UsedLot.Add ("Tundra");
            UsedLot.Add ("Taurus");

            ShowRoom.UnionWith (UsedLot);

            ShowRoom.Remove ("Tundra");

            // foreach (string vehicle in ShowRoom) {
            //     Console.WriteLine ($"{vehicle}");
            // }

            HashSet<string> JunkYard = new HashSet<string> ();
            JunkYard.Add("Civic");
            JunkYard.Add("Meow");
            JunkYard.Add("Bloop");
            JunkYard.Add("Altima");
            JunkYard.Add("Jugo");

            HashSet<string> clone = new HashSet<string>(ShowRoom);
            clone.IntersectWith(JunkYard);

            // foreach (string vehicle in clone) {
            //     Console.WriteLine ($"{vehicle}");
            // }

            ShowRoom.UnionWith(JunkYard);

            // foreach (string vehicle in ShowRoom) {
            //     Console.WriteLine ($"{vehicle}");

            ShowRoom.Remove("Civic");
            ShowRoom.Remove("Altima");

            foreach (string vehicle in ShowRoom) {
                Console.WriteLine ($"{vehicle}");
            }

        }
    }
}