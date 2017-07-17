using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Classes
{
    public class MP4Player : IAdvancedMediaPlayer
    {
        public void PlayVLC(string fileName)
        {
        }

        public void PlayMP4(string fileName)
        {
            Console.WriteLine(String.Format("Playing MP4 file : {0}", fileName));
        }
    }
}
