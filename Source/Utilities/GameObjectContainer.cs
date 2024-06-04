using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities
{
    internal class GameObjectContainer
    {
        private LinkedList<LinkedListNode<GameObject>> _container;
        private int _gameObjectID = 0;
        public GameObjectContainer()
        {
            _container = new LinkedList<LinkedListNode<GameObject>>();
        }

        public void Draw()
        {
            // Run through each object, and call its draw function
            // TODO: Remove this when engine is more worked out
            if (_container.Count > 0)
            {
                for (LinkedListNode<GameObject> node = _container.First(); node != null; node = node.Next)
                {
                    GameObject gameObject = node.Value;
                    gameObject.Draw();
                }
            }
        }

        public void Update(GameTime gameTime)
        {
            // Run through each object, and call its draw function
            // TODO: Remove this when engine is more worked out
            if (_container.Count > 0)
            {
                for (LinkedListNode<GameObject> node = _container.First(); node != null; node = node.Next)
                {
                    GameObject gameObject = node.Value;
                    gameObject.Update(gameTime);
                }
            }
        }

        public void Initialize()
        {
            // Run through each object, and call its init function
            // TODO: Remove this when engine is more worked out
            if (_container.Count > 0)
            {
                for (LinkedListNode<GameObject> node = _container.First(); node != null; node = node.Next)
                {
                    GameObject gameObject = node.Value;
                    gameObject.Initialize();
                }
            }
        }

        public void Load(ContentManager Content, GraphicsDevice graphics)
        {
            // Run through each object, and call its load function
            // TODO: Remove this when engine is more worked out
            if(_container.Count > 0)
            {
                for (LinkedListNode<GameObject> node = _container.First(); node != null; node = node.Next)
                {
                    GameObject gameObject = node.Value;
                    gameObject.Load(Content, graphics);
                }
            }
           
        }

        public void Add(GameObject item)
        {
            _gameObjectID++;
            item.setID(_gameObjectID);
            LinkedListNode<GameObject> node = new LinkedListNode<GameObject>(item);
            _container.AddLast(node);
        }
        public void Add(GameObject item, int id)
        {
            LinkedListNode<GameObject> node = new LinkedListNode<GameObject>(item);
            _container.AddLast(node);
        }

        public GameObject Find(int ID)
        {
            LinkedListNode<GameObject> node = _container.First();
            while (node != null)
            {
                LinkedListNode<GameObject> nextNode = node.Next;
                if (node.Value.getID() == ID)
                {
                    return node.Value;
                }
                node = nextNode;
            }
            return null;
        }

        public GameObject Find(GameObject gameObject)
        {
            LinkedListNode<GameObject> node = _container.First();
            while (node != null)
            {
                LinkedListNode<GameObject> nextNode = node.Next;
                if (node.Value == gameObject)
                {
                    return node.Value;
                }
                node = nextNode;
            }
            return null;
        }

        // Each gameObject is assigned an ID upon entering the container. We can find and remove the gameObject based on this ID
        public void Remove(int ID) 
        {
            LinkedListNode<GameObject> node = _container.First();
            while (node != null)
            {
                LinkedListNode<GameObject> nextNode = node.Next;
                if (node.Value.getID() == ID)
                {
                    _container.Remove(node);
                }
                node = nextNode;
            }
        }

        public void Remove(GameObject gameObject)
        {
            LinkedListNode<GameObject> node = _container.First();
            while (node != null)
            {
                LinkedListNode<GameObject> nextNode = node.Next;
                if (node.Value == gameObject)
                {
                    _container.Remove(node);
                }
                node = nextNode;
            }
        }
        public void RemoveAll() 
        { 
            _container.Clear();
        }
    }
}
