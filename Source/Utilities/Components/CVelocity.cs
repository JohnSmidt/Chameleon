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

        private Vector2 _velocity;

        public Vector2 velocity
        {
            get => _velocity;
            set => _velocity = value;
        }

        public CVelocity(int id, Entity parent, Vector2 velocity, string name = "") : base(id, parent, name)
        {
            this._velocity = velocity;
        }
    }
}
