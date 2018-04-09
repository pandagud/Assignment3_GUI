using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon_Decorator
{
    public class Weapon
    {
        public int Accuracy { get => _accuracy; set => _accuracy = value; }
        public int Velocity { get => _velocity; set => _velocity = value; }
        public int Loudness { get => _loudness; set => _loudness = value; }
        public string Description { get => _description; set => _description = value; }
        public int Cost { get => _cost; set => _cost = value; }

        private int _velocity;
        private int _accuracy;
        private int _loudness;
        private string _description;
        private int _cost;

        public Weapon()
        {
            _accuracy = 1;
            _cost = 0;
            _description = "";
            _loudness = 1;
            _velocity = 1;
        }
    }
}
