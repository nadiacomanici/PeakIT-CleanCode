﻿using PlayerStates_Begin.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStates_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoPlayer player = new VideoPlayer();
            player.PlayVideo("video.mp4");
            player.TogglePlayPause();
        }
    }
}
