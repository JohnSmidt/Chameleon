using GameEngine.Source.Utilities;
using GameEngine.Source.Utilities.Components;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Systems
{
    internal class SGrid : Interfaces.ISystem
    {
        private float tick = 1;
        private List<Entity> EGridUsers;
        private List<Entity> EGrids;
        public SGrid(List<Entity> EGrids, List<Entity> EGridUsers)
        {
            this.EGrids = EGrids;
            this.EGridUsers = EGridUsers;
        }
        public void Update(GameTime gametime)
        {
            if(tick <= 0)
            {
                tick = 1;
                CheckGrid();
            }
            else
            {
                tick -= (float)gametime.ElapsedGameTime.TotalSeconds;
            }
        }

        public void CheckGrid()
        {
            foreach (Entity grid in EGrids)
            {
                CGrid gridComponent = grid.GetComponent<CGrid>();
                if (gridComponent == null) {
                    continue;
                }
                foreach (Entity user in EGridUsers)
                {
                    CPosition positionComponent = user.GetComponent<CPosition>();
                    if (positionComponent == null)
                    {
                        // This shouldnt happen. Needs an exception
                        continue;
                    }
                    if (positionComponent.position.X >= gridComponent.width / 2)
                    {
                        if(positionComponent.position.Y >= gridComponent.height / 2)
                        {
                            Debug.WriteLine("In 4th Quadrant");
                        }
                        else
                        {
                            Debug.WriteLine("In 2nd Quadrant");
                        }
                    }
                    else
                    {
                        if (positionComponent.position.Y >= gridComponent.height / 2)
                        {
                            Debug.WriteLine("In 3rd Quadrant");
                        }
                        else
                        {
                            Debug.WriteLine("In 1st Quadrant");
                        }
                    }
                }
            }
            

        }
    }
}
