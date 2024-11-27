using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class CGridUser : Component
    {
        CGridUser(int id, Entity parent, string name = "") : base(id, parent, name)
        {
            // I think this component will require a CPosition component. 
        }
    }
}
