using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Classes
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advanceMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (String.Compare(audioType.ToUpper(), "VLC") == 0)
                advanceMusicPlayer = new VlcPlayer();
            else if (String.Compare(audioType.ToUpper(), "MP4") == 0)
                advanceMusicPlayer = new MP4Player();
        }

        public void Play(string audioType, string fileName)
        {
            if (String.Compare(audioType.ToUpper(), "VLC") == 0)
                advanceMusicPlayer.PlayVLC(fileName);
            else if (String.Compare(audioType.ToUpper(), "MP4") == 0)
                advanceMusicPlayer.PlayMP4(fileName);
        }
    }
}
