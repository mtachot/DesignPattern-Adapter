using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Classes
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVLC(string fileName)
        {
            Console.WriteLine(String.Format("Playing VLC file : {0}", fileName));
        }

        public void PlayMP4(string fileName)
        {
        }
    }
}
