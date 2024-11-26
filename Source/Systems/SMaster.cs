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
        private GraphicsDevice _graphics;
        private SMovement _movement;

        public SMaster(ContentManager Content, GameTime gametime, GraphicsDevice graphics) 
        {
            this.Content = Content;
            this.gameTime = gametime;
            this._graphics = graphics;
            systems = new List<Interfaces.ISystem>();
            this._entities = new List<Entity>();
        }
        public Entity entity;
        int id = 0;

        public void Initiate()
        {
            Texture2D texture = Content.Load<Texture2D>("placeholder");


            entity = new Entity(0, "test");
            CPosition position = new CPosition(1, entity, new Vector2(500,500));
            CVelocity velocity = new CVelocity(2, entity, 50);
            CVector vector = new CVector(2, entity, new Vector2(0, 0));
            C2DStaticSprite sprite = new C2DStaticSprite(3, entity, texture);
            CMovementState movementState = new CMovementState(4, entity);
            entity.AddComponent(typeof(CPosition), position);
            entity.AddComponent(typeof(CVelocity), velocity);
            entity.AddComponent(typeof(CVector), vector);
            entity.AddComponent(typeof(C2DStaticSprite), sprite);
            entity.AddComponent(typeof(CMovementState), movementState);

            _entities.Add(entity);

            _render = new SRender(_graphics);
            _movement = new SMovement();
        }

        public void RegisterSystem(ISystem system)
        {
            systems.Add(system);
        }

        public void Update(GameTime gameTime)
        {
            // Movement
            _movement.Move(gameTime, _entities);
        }

        public void Draw()
        {
            _render.Render(_entities);
        }
    }
}
