using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Interfaces
{
    internal interface ISystem
    {
        void Update(GameTime gametime);
    }
}
