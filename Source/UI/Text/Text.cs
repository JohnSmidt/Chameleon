using GameEngine.Source.Tools;
using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.UI.Text
{
    // Raw Text, can be implemented anywhere
    // This text is static, and cannot move. It is just used for basic UI.
    internal class Text : GameObject
    {
        private RNG rng;
        private int x;
        private int y;
        private string text;
        private Color color;

        private SpriteBatch spriteBatch;
        private SpriteFont font;
        public Text(
            //GraphicsDeviceManager graphics, 
            string text,
            int x,
            int y,
            Color color
        )
        {
            rng = new RNG();
            this.x = x;
            this.y = y;
            this.text = text;
            this.color = color;
        }
        public override void Draw()
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, text, new Vector2(x, y), rng.color());
            spriteBatch.End();
        }

        public override void Initialize()
        {

        }

        public override void Load(ContentManager Content, GraphicsDevice graphics)
        {
            font = Content.Load<SpriteFont>("BasicFont");
            spriteBatch = new SpriteBatch(graphics);
        }
    }



}
