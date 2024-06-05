using GameEngine.Source.Tools;
using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameEngine.Source.UI.Text
{
    // This is an individual character. It can move freely for animation purposes
    internal class CharElement : GameObject
    {
        private string _character;
        private float _x;
        private float _y;
        private int _animationState;
        private Color _color;

        private SpriteBatch _spriteBatch;
        private SpriteFont _font;

        //public delegate void animation(float x, float y);
        public CharElement(string character, float x, float y, int animationState, Color color)
        {
            _character = character;
            _x = x;
            _y = y;
            _animationState = animationState;
            _color = color;

           
        }

        public override void Draw()
        {
            _spriteBatch.Begin();
            _spriteBatch.DrawString(_font, _character, new Vector2(_x, _y), _color);
            _spriteBatch.End();
            
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void Load(ContentManager Content, GraphicsDevice graphics)
        {
            _font = Content.Load<SpriteFont>("BasicFont");
            _spriteBatch = new SpriteBatch(graphics);
        }
    }
}
