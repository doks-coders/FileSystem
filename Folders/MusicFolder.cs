using FileSystemLayer.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLayer.Folders
{
    internal class MusicFolder:AbstractionLevel
    {
        public override string directoryName()
        {
            return "Music Folder";
        }
    }
}
