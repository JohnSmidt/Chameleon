using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class CPosition : Component
    {
        private Vector2 _position;
        public Vector2 position 
        {
            get => _position;
            set => _position = value;
        }

        public CPosition(int id, Entity parent, Vector2 position, string name = ""):base(id, parent, name)
        {
            _position = position;
        }

    }
}
