using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.UI.Text
{
    // This is an individual character. It can move freely for animation purposes
    internal class CharElement : GameObject
    {
        private char _character;
        private float _x;
        private float _y;
        private int _animationState;

        //public delegate void animation(float x, float y);
        public CharElement(char character, float x, float y, int animationState)
        {
            _character = character;
            _x = x;
            _y = y;
            _animationState = animationState;

            switch (animationState)
            {
                case 0:

                break;
            }

        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void Load(ContentManager Content, GraphicsDevice graphics)
        {
            throw new NotImplementedException();
        }
    }
}
