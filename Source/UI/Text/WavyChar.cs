using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Threading.Tasks;
using GameEngine.Source.Tools;
using System.Diagnostics;


namespace GameEngine.Source.UI.Text
{
    internal class WavyChar : CharElement
    {
        private string _character;
        private float _x;
        private float _y;
        private int _animationState;
        private Color _color;
        private float _amplitude;
        private float _speed;
        private float _timer;
        private float _wavyY;
        private SpriteBatch _spriteBatch;
        private SpriteFont _font;
        public WavyChar(string character, float x, float y, int animationState, Color color) : base (character, x, y, animationState, color)
        {
            _character = character;
            _x = x;
            
            _y = y;
            _amplitude = 3.0f;
            _speed = 100.0f;
            _animationState = animationState;
            _color = color;
            _timer = 0;
        }
        public override void Update(GameTime gameTime)
        {
            _timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //Debug.WriteLine(_timer);
            _wavyY = _y + (float)( _amplitude * Math.Sin(_timer / _speed));
        }

        public override void Draw()
        {
            _spriteBatch.Begin();
            //_font.MeasureString("TEST");
            _spriteBatch.DrawString(_font, _character, new Vector2(_x, _wavyY), _color);
            _spriteBatch.End();

        }

        public override void Load(ContentManager Content, GraphicsDevice graphics)
        {
            _font = Content.Load<SpriteFont>("BasicFont");
            _spriteBatch = new SpriteBatch(graphics);
        }

    }
}
