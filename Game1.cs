using GameEngine.Source.Tools;
using GameEngine.Source.UI.Text;
using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace GameEngine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private GameObjectContainer container;
        private RNG rng;
        private CharElementContainer text;
        GameTime gameTime;
        Dictionary<char, float> fontWidths;

        /// <summary>
        /// 
        /// </summary>

        public Game1()
        {
            
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1500;
            _graphics.PreferredBackBufferHeight = 800;

        }

        protected override void Initialize()
        {
            fontWidths = getFontWidths(Content.Load<SpriteFont>("BasicFont"));
            container = new GameObjectContainer(Content, GraphicsDevice);
            text = new CharElementContainer("Testing !wWavy!!!/ !bBouncy!/ !pPoppy!/ and !sShaky!/ effects!!", 0,
                GraphicsDevice.Viewport.Height / 2, GraphicsDevice.Viewport.Width, container, Content.Load<SpriteFont>("BasicFont"), fontWidths);
            container.Add(text);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            container.Load(Content, GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            container.Update(gameTime);
           

            // TODO: Add your update logic here

            //base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            container.Draw();
           

            // TODO: Add your drawing code here

            //base.Draw(gameTime);
        }

        // Caching each character to allow for quick dialogue width calculations
        public Dictionary<char, float> getFontWidths(SpriteFont font)
        {
            Dictionary<char, float> fontWidths = new Dictionary<char, float>();
            foreach (char character in font.Characters)
            {
                float width = font.MeasureString(character.ToString()).X;
                fontWidths.Add(character, width);
            }
            return fontWidths;
        }
    }
}