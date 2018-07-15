using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Image_to_CAD.Image;

namespace Image_to_CAD
{

    class Worker
    {
        BlackWhite blackWhite;
        Settings settings;
        public Worker(string path, Settings settings_)
        {
            settings = settings_;
        }
    }
}
