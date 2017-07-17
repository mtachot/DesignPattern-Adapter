using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Classes
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (String.Compare(audioType.ToUpper(), "MP3") == 0)
                Console.WriteLine(String.Format("Playing MP3 file : {0}", fileName));
            else if (String.Compare(audioType.ToUpper(), "VLC") == 0 || String.Compare(audioType.ToUpper(), "MP4") == 0)
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
                Console.WriteLine(String.Format("Invalid media : {0} format not supported", audioType));
        }
    }
}
