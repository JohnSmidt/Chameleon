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
        // Used in the container to be able to find said object
        private int _ID;
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

        public virtual void setID(int ID)
        {
            _ID = ID;
        }

        public virtual int getID()
        {
            return _ID;
        }

    }


}
