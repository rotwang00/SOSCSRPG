using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Rotwang";
            CurrentPlayer.Gold = 1_000_000;

        }
    }
}
