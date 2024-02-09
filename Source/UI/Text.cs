using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.UI
{
    // Raw Text, can be implemented anywhere
    internal class Text : GameObject
    {
        private int x;
        private int y;
        private string text;
        private Color color;

        private SpriteBatch spriteBatch;
        private SpriteFont font;
        public Text (  
            //GraphicsDeviceManager graphics, 
            String text,
            int x,
            int y,
            Color color
        ) 
        {
            this.x = x;
            this.y = y;
            this.text = text;
            this.color = color;
        }
        public void Draw()
        {
            this.spriteBatch.Begin();
            this.spriteBatch.DrawString(this.font, this.text, new Vector2(this.x, this.y), this.color);
            this.spriteBatch.End();
        }

        public void Initialize()
        {
           
        }

        public void Load(ContentManager Content, GraphicsDevice graphics)
        {
            this.font = Content.Load<SpriteFont>("BasicFont");
            this.spriteBatch = new SpriteBatch(graphics);
        }
    }

    // Structured Text, Is shown in a dialogue box
    internal class Dialogue : GameObject
    {
        public Dialogue(
            GraphicsDeviceManager graphics,
            SpriteBatch spriteBatch,
            String[] text
        )
        {

        }
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Load(ContentManager Content, GraphicsDevice graphics)
        {
            throw new NotImplementedException();
        }
    }

    internal class DialogueOption : GameObject
    {
        public DialogueOption(
            GraphicsDeviceManager graphics,
            SpriteBatch spriteBatch,
            String[] text
        )
        {

        }
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Load(ContentManager Content, GraphicsDevice graphics)
        {
            throw new NotImplementedException();
        }
    }


}
