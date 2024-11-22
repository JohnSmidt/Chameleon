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
    internal class ShakyChar : CharElement
    {
        private string _character;
        private float _x;
        private float _y;
        
        private Color _color;
       
        private float _shakyY;
        private float _shakyX;
        private SpriteBatch _spriteBatch;
        private SpriteFont _font;
        public ShakyChar(string character, float x, float y, int animationState, Color color) : base(character, x, y, animationState, color)
        {
            _character = character;
            _x = x;
            _y = y;
            _color = color;
        }
        public override void Update(GameTime gameTime)
        {
            _shakyY = _y + generateRandomPosition().Y;
            _shakyX = _x + generateRandomPosition().X;
        }

        public override void Draw()
        {
            _spriteBatch.Begin();
            _spriteBatch.DrawString(_font, _character, new Vector2(_shakyX, _shakyY), _color);
            _spriteBatch.End();
        }

        public override void Load(ContentManager Content, GraphicsDevice graphics)
        {
            _font = Content.Load<SpriteFont>("BasicFont");
            _spriteBatch = new SpriteBatch(graphics);
        }

        private Vector2 generateRandomPosition()
        {
            Vector2 random = new Vector2((float) new Random().Next(-1, 1), (float) new Random().Next(-1, 1));
            return random;
        }
    }
}
