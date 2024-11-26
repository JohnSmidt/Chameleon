using GameEngine.Source.Tools;
using GameEngine.Source.Utilities;
using GameEngine.Source.Utilities.Components;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static GameEngine.Source.Utilities.Components.CMovementState;

namespace GameEngine.Source.Systems
{
    internal class SMovement : Interfaces.ISystem
    {
        Random rng = new Random();
        float wanderingTick = 0;
        float deltaTime = 0;

        public void Move(GameTime gameTime, List<Entity> entities)
        {
            foreach (Entity entity in entities)
            {
                deltaTime = (float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond;
                CPosition positionComponent = entity.GetComponent<CPosition>();
                CVector vectorComponent = entity.GetComponent<CVector>();
                CMovementState movementState = entity.GetComponent<CMovementState>();
                CVelocity velocityComponent = entity.GetComponent<CVelocity>();

                if (positionComponent != null && vectorComponent != null && movementState != null && velocityComponent != null)
                {
                    
                    switch (movementState.CurrentState) 
                    {
                        case States.Wandering:
                            Wander(vectorComponent);
                        break;
                        default:
                        break;
                    }
                    float x = positionComponent.position.X + ((vectorComponent.vector.X * velocityComponent.velocity) * deltaTime);
                    float y = positionComponent.position.Y + ((vectorComponent.vector.Y * velocityComponent.velocity) * deltaTime);
                    positionComponent.position = new Vector2(x, y);
                }
            }
        }

        public void Wander(CVector vectorComponent)
        {
            if (wanderingTick <= 0)
            {
                wanderingTick = 3;
                float randX = (float)((rng.NextDouble() * 2.0) - 1.0);
                float randY = (float)((rng.NextDouble() * 2.0) - 1.0);
                float normalizer = (float)Math.Sqrt(randX * randX + randY * randY);
                if (normalizer == 0)
                {
                    vectorComponent.vector = new Vector2(0, 0);
                }
                else
                {
                    vectorComponent.vector = new Vector2((randX / normalizer), (randY / normalizer));
                }
            }
            else
            {
                wanderingTick -= deltaTime;
            }
           
        }
        public void Update(GameTime gametime)
        {
           

        }
    }
}
