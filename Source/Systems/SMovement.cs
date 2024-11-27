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
        bool isMoving = false;
        float waitingTime = 0; // Might replace this with stamina
        float deltaTime = 0;

        public void Move(GameTime gameTime, List<Entity> entities)
        {
            foreach (Entity entity in entities)
            {
                deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
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

            // If Moving, decrease the moving timer and move
            // If not moving, devrease the wait timer
            float randX = 0;
            float randY = 0;
            float normalizer = 0;

            if (isMoving && wanderingTick > 0)
            {
                wanderingTick -= deltaTime;
            }

            if(isMoving && wanderingTick <= 0)
            {
                waitingTime = 3;
                isMoving = false;
                vectorComponent.vector = new Vector2(0, 0);
            }

            if(!isMoving && waitingTime > 0)
            {
                waitingTime -= deltaTime;
            }

            if (!isMoving && waitingTime <= 0)
            {
                wanderingTick = 3;
                isMoving = true;
                randX = (float)((rng.NextDouble() * 2.0) - 1.0);
                randY = (float)((rng.NextDouble() * 2.0) - 1.0);
                normalizer = (float)Math.Sqrt(randX * randX + randY * randY);
                if (normalizer == 0)
                {
                    vectorComponent.vector = new Vector2(0, 0);
                }
                else
                {
                    vectorComponent.vector = new Vector2((randX / normalizer), (randY / normalizer));
                }
            }
        }
        public void Update(GameTime gametime)
        {
           

        }
    }
}
