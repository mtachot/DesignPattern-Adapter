using AdapterPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            AudioPlayer player = new AudioPlayer();

            player.Play("MP3", "test1.mp3");
            player.Play("MP4", "test2.mp4");
            player.Play("VLC", "test3.vlc");
            player.Play("AVI", "test4.Avi");

            Console.ReadLine();
        }
    }
}
