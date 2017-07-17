using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVLC(string fileName);
        void PlayMP4(string fileName);
    }
}
