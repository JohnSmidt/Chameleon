using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class CVelocity : Component
    {

        private float _velocity;
        public float velocity
        {
            get => _velocity;
            set => _velocity = value;
        }

        public CVelocity(int id, Entity parent, float velocity, string name = "") : base(id, parent, name)
        {

            this._velocity = velocity;
        }
    }
}
