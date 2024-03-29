﻿using GameEngine.Source.Tools;
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

namespace GameEngine.Source.UI
{
    // Raw Text, can be implemented anywhere
    internal class Text : GameObject
    {
        private RNG rng;
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
            this.rng = new RNG ();
            this.x = x;
            this.y = y;
            this.text = text;
            this.color = color;
        }
        public override void Draw()
        {
            this.spriteBatch.Begin();
            this.spriteBatch.DrawString(this.font, this.text, new Vector2(this.x, this.y), rng.color());
            this.spriteBatch.End();
        }

        public override void Initialize()
        {
           
        }

        public override void Load(ContentManager Content, GraphicsDevice graphics)
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

    internal class DialogueOption : GameObject
    {
        public DialogueOption(
            GraphicsDeviceManager graphics,
            SpriteBatch spriteBatch,
            String[] text
        )
        {

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
