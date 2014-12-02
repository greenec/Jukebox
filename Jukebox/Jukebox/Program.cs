using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Media;

namespace Jukebox
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer centuries = new SoundPlayer();
            centuries.SoundLocation = @"C:\Users\Connor\Documents\GitHub\Jukebox\Songs\Fall Out Boy - Centuries.wav";

            SoundPlayer church = new SoundPlayer();
            church.SoundLocation = @"C:\Users\Connor\Documents\GitHub\Jukebox\Songs\Hozier - Take Me To Church.wav";

            SoundPlayer animals = new SoundPlayer();
            animals.SoundLocation = @"C:\Users\Connor\Documents\GitHub\Jukebox\Songs\Maroon 5 - Animals.wav";

            SoundPlayer space = new SoundPlayer();
            space.SoundLocation = @"C:\Users\Connor\Documents\GitHub\Jukebox\Songs\Taylor Swift - Blank Space.wav";

            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.WriteLine("Enter song name, artist, or chorus:");
                string str = Console.ReadLine();

                if (str.ToLower().IndexOf("fall out boy") >= 0 ||
                    str.ToLower().IndexOf("centuries") >= 0 ||
                    str.ToLower().IndexOf("remember") >= 0)
                {
                    Console.WriteLine("Now playing Centuries - by Fall Out Boy");
                    centuries.Play();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    centuries.Stop();
                }

                if (str.ToLower().IndexOf("church") >= 0 ||
                    str.ToLower().IndexOf("hozier") >= 0)
                {
                    Console.WriteLine("Now playing Take Me To Church - by Hozier");
                    church.Play();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    church.Stop();
                }

                if (str.ToLower().IndexOf("maroon 5") >= 0 ||
                    str.ToLower().IndexOf("tonight") >= 0 ||
                    str.ToLower().IndexOf("preying") >= 0 ||
                    str.ToLower().IndexOf("animals") >= 0)
                {
                    Console.WriteLine("Now playing Animals - by Maroon 5");
                    animals.Play();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    animals.Stop();
                }

                if (str.ToLower().IndexOf("taylor swift") >= 0 ||
                    str.ToLower().IndexOf("forever") >= 0 ||
                    str.ToLower().IndexOf("insane") >= 0 ||
                    str.ToLower().IndexOf("breathless") >= 0 ||
                    str.ToLower().IndexOf("blank") >= 0 ||
                    str.ToLower().IndexOf("space") >= 0)
                {
                    space.Play();
                    Console.WriteLine("Now playing Blank Space - by Taylor Swift");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    space.Stop();
                }
            }
        }
    }
}