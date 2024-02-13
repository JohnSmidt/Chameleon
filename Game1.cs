using GameEngine.Source.Tools;
using GameEngine.Source.UI;
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
        private Text text;/// <summary>
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
            rng = new RNG();
            container = new GameObjectContainer();
            // TODO: Add your initialization logic here
            text = new Text("Hello World", GraphicsDevice.Viewport.Width / 2,
                GraphicsDevice.Viewport.Height / 2, rng.color());
            container.Add(text);

            for (int i = 0; i < 10; i++)
            {
                    Debug.WriteLine(rng.percentage());
            }

            int[] temp = new int[10] {1,2,3,4,5,6,7,8,9,10};

            Debug.WriteLine(rng.pickFromArray(temp));
               

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