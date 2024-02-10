using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities
{
    internal class GameObject
    {
        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }

        public virtual void Load(ContentManager Content, GraphicsDevice graphics)
        {
            throw new NotImplementedException();
        }

        public virtual void Draw()
        { 
            throw new NotImplementedException();
        }

    }


}
