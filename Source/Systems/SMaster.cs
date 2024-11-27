using GameEngine.Source.Interfaces;
using GameEngine.Source.Utilities;
using GameEngine.Source.Utilities.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace GameEngine.Source.Systems
{
    internal class SMaster
    {
        private List<Interfaces.ISystem> systems;
        private ContentManager Content;
        private GameTime gameTime;
        private SRender _render;
        private List<Entity> _entities;
        private List<Entity> _antEntities;
        private GraphicsDevice _graphics;
        private SMovement _movement;
        private SGrid _grid;
        private List<Entity> _gridEntities;

        public SMaster(ContentManager Content, GameTime gametime, GraphicsDevice graphics) 
        {
            this.Content = Content;
            this.gameTime = gametime;
            this._graphics = graphics;
            systems = new List<Interfaces.ISystem>();
            this._entities = new List<Entity>();
            this._antEntities = new List<Entity>();
            this._gridEntities = new List<Entity>();
        }
        public Entity ant;
        public Entity grid;
        int id = 0;

        public void Initiate()
        {
            Texture2D texture = Content.Load<Texture2D>("placeholder");

            grid = new Entity(5, "grid");
           
            CGrid gridComponent = new CGrid(6, grid, _graphics.Viewport.Width, _graphics.Viewport.Height, 2, 2);
            grid.AddComponent(gridComponent);
            _gridEntities.Add(grid);
            //addAnt();
            ant = new Entity(0, "ant");
            _antEntities.Add(ant);

            CPosition position = new CPosition(1, ant, new Vector2(500,500));
            CVelocity velocity = new CVelocity(2, ant, 50);
            CVector vector = new CVector(2, ant, new Vector2(0, 0));
            C2DStaticSprite sprite = new C2DStaticSprite(3, ant, texture);
            CMovementState movementState = new CMovementState(4, ant);
            ant.AddComponent(typeof(CPosition), position);
            ant.AddComponent(typeof(CVelocity), velocity);
            ant.AddComponent(typeof(CVector), vector);
            ant.AddComponent(typeof(C2DStaticSprite), sprite);
            ant.AddComponent(typeof(CMovementState), movementState);

            _entities.Add(ant);
           // _entities.Add(grid);

            _render = new SRender(_graphics);
            RegisterSystem(_render);
            _movement = new SMovement();
            RegisterSystem(_movement);
            _grid = new SGrid(_gridEntities, _antEntities);
            RegisterSystem(_grid);
        }

        //addAnt();

        public void RegisterSystem(ISystem system)
        {
            systems.Add(system);
        }

        public void Update(GameTime gameTime)
        {
            // Movement
            _movement.Move(gameTime, _entities);
            _grid.Update(gameTime);
        }

        public void Draw()
        {
            _render.Render(_entities);
        }
    }
}
