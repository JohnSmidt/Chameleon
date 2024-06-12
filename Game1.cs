using GameEngine.Source.Tools;
using GameEngine.Source.UI.Text;
using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
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

        /// <summary>
        /// 
        /// </summary>

        public Game1()
        {
            
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            
            container = new GameObjectContainer(Content, GraphicsDevice);
            text = new CharElementContainer("Testing <w>Wavy</> <p>Poppy</> and <s>Shaky</> effects", 0,
                GraphicsDevice.Viewport.Height / 2, 200.0f, container);
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
            GraphicsDevice.Clear(Color.CornflowerBlue);
            container.Draw();
           

            // TODO: Add your drawing code here

            //base.Draw(gameTime);
        }
    }
}