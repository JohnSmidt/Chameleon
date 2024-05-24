using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Source.Tools;

namespace GameEngine.Source.UI.Text
{
    internal class Dialogue : GameObject
    {
        // Structured Text, Is shown in a dialogue box
        // text is dynamic. It can move, change color, and do whatever is needed in the game

        private RNG rng;
        private int x;
        private int y;
        private string text;
        private Color color;

        private SpriteBatch spriteBatch;
        private SpriteFont font;
        public Dialogue(
            GraphicsDeviceManager graphics,
            SpriteBatch spriteBatch,
            string[] text
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
