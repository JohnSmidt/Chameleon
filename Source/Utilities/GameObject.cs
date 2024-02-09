using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities
{
    internal interface GameObject
    {
        void Initialize();

        void Load(ContentManager Content, GraphicsDevice graphics);

        void Draw();

    }


}
