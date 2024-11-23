using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class C2DStaticSprite :Component
    {
        public Texture2D texture;
        public C2DStaticSprite(int id, Entity parent, Texture2D texture, string name = "") : base(id, parent, name) 
        {
            this.texture = texture;
        }
    }
}
