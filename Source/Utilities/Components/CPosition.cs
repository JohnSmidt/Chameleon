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
        private float _x;
        private float _y;

        public float x
        {
            get => _x;
            set => _x = value;
        }

        public float y
        {
            get => _y;
            set => _y = value;
        }
        public Vector2 position
        {
            get { return _position; }
            set { _position = value; }
        }

        public CPosition(int id, Entity parent, Vector2 position, string name = ""):base(id, parent, name)
        {
            _x = position.X;
            _y = position.Y;
            _position = new Vector2(_x, _y);
        }

    }
}
