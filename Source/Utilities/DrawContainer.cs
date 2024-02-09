using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities
{
    internal class DrawContainer
    {
        private LinkedList<LinkedListNode<GameObject>> _container;
        DrawContainer()
        {
            _container = new LinkedList<LinkedListNode<GameObject>>();
        }

        public void Draw()
        {
            // Run through each object, and call its draw function
            for(LinkedListNode<GameObject> node = _container.First(); node != null; node = node.Next)
            {
                GameObject gameObject = node.Value;
                gameObject.Draw();
            }
        }

        public void Add(GameObject item)
        {
            LinkedListNode<GameObject> node = new LinkedListNode<GameObject>(item);
            _container.AddLast(node);
        }
        public void Add(GameObject item, int id)
        {
            LinkedListNode<GameObject> node = new LinkedListNode<GameObject>(item);
            _container.AddLast(node);
        }
        // No clue how im going to implement this...
        public void Remove(int ID) 
        { 
        
        }
        public void RemoveAll() 
        { 
        
        }
    }
}
