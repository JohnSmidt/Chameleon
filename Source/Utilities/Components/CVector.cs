using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class CVector : Component
    {

        private Vector2 _vector;

        public Vector2 vector
        {
            get => _vector;
            set => _vector = value;
        }

        public CVector(int id, Entity parent, Vector2 vector, string name = "") : base(id, parent, name)
        {

            this._vector = vector;
        }
    }
}
