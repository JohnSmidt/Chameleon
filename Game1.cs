using GameEngine.Source.UI;
using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.ComponentModel;

namespace GameEngine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private GameObjectContainer container;
        private SpriteBatch _spriteBatch;
        private SpriteFont _font;
        private int _score = 0;
        private Text text;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            container = new GameObjectContainer();
            // TODO: Add your initialization logic here
            text = new Text("Hello World", GraphicsDevice.Viewport.Width / 2,
                GraphicsDevice.Viewport.Height / 2, Color.Black);
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

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            container.Draw();
           

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}