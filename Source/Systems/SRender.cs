using GameEngine.Source.Utilities;
using GameEngine.Source.Utilities.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Systems
{
    internal class SRender : Interfaces.ISystem
    {

        private SpriteBatch _spriteBatch;
        public SRender(GraphicsDevice graphics)
        {
            _spriteBatch = new SpriteBatch(graphics);            
        }

        public void Render(List<Entity> entities)
        {
            _spriteBatch.Begin();

            foreach(var entity in entities) 
            {
                var renderComponent = entity.GetComponent<C2DStaticSprite>();
                var positionComponent = entity.GetComponent<CPosition>();

                if(renderComponent != null || positionComponent != null)
                {
                    _spriteBatch.Draw(renderComponent.texture, positionComponent.position, Color.White);
                }

                _spriteBatch.End();
            }
        }

        public void Update(GameTime gametime)
        {
            throw new NotImplementedException();
        }

        public void Draw(GameTime gameTime)
        {

        }
    }
}
