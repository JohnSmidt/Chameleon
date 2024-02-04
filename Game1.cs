using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace GameEngine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        //private Texture2D _line;
        //private float _angleOfLine;
        private SpriteFont _font;
        private int _score = 0;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //_line = new Texture2D(_graphics.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            //_line.SetData(new[] { Color.White });
            //_angleOfLine = (float)(1 * Math.PI);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _font = Content.Load<SpriteFont>("BasicFont");
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
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
            _spriteBatch.Begin();

            _spriteBatch.DrawString(_font, "Score", new Vector2(100, 100), Color.Black);

            _spriteBatch.End();
            //_spriteBatch.Begin();
            //_spriteBatch.Draw(_line, new Rectangle(_graphics.GraphicsDevice.Viewport.Width / 2, _graphics.GraphicsDevice.Viewport.Height / 2, 200, 1), null, Color.White, _angleOfLine, new Vector2(0, 0), SpriteEffects.None, 0);
            //_spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}