using GameEngine.Source.Utilities;
using GameEngine.Source.Utilities.Components;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Systems
{
    internal class SMaster
    {
        public SMaster() { }
        public Entity entity;
        int id = 0;

        public void Initiate()
        {
            entity = new Entity(0, "test");
            CPosition position = new CPosition(1, entity, new Vector2(50,50));
            CVelocity velocity = new CVelocity(2, entity, new Vector2(2, 0));
            entity.AddComponent(typeof(CPosition), position);
            entity.AddComponent(typeof(CVelocity), velocity);
            float x = entity.GetComponent<CPosition>().position.X;
        }
        public void Update(GameTime gameTime) 
        {

        }
        public void Draw()
        {

        }
    }
}
