using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities
{

    /// <summary>
    /// Entities are a kind of hollow shell that holds a number of components that defines what the entity is. A kind of container class. Other than organization, 
    /// Entities dont really do much else. Components hold the majority of the data, while systems provide behavior. It needs to be easy to search for components
    /// within an entity, since systems will be searching for components every loop
    /// </summary>
    internal class Entity
    {
        public int id; // Each Entity should still have an Id for a number of debugging reasons

        public string name; // More organization for the sake of the dev

        public bool isDestroyed { get; private set; } = false;
        public bool isEnabled = true;
        public bool isVisible = true;

        private Dictionary<Type, Component> _componentDictionary; // Learn what type is
        public List<Component> _componentList { get; private set; } 

        public Entity(int id, string name)
        {
            this.id = id;
            this.name = name;
            _componentDictionary = new Dictionary<Type, Component>();
            _componentList = new List<Component>();
        }

        #region Components

        public Component AddComponent(Type type, Component component)
        {
            _componentDictionary.Add(type, component);
            _componentList.Add(component);

            return component;
        }

        public T AddComponent<T>(T component) where T : Component =>
            (T)AddComponent(typeof(T), component);

        public Component RemoveComponent(Type type)
        {
            if (_componentDictionary.TryGetValue(type, out Component component))
            {
                component.Destroy();
                _componentDictionary.Remove(type);
                _componentList.Remove(component);
                return component;
            }
            return null;
        }

        public Component RemoveComponent<T>() where T : Component =>
           RemoveComponent(typeof(T));

        public Component FindComponent(Type type)
        {
           return _componentDictionary[type];
        }

        public T? GetComponent<T>() where T : Component => (T)_componentDictionary[typeof(T)];

        public Component GetComponent(Type type) =>
            _componentDictionary[type];

        public bool HasComponent(Type type)
        {
            return _componentDictionary.ContainsKey(type);
        }

        #endregion Components

        public void Destroy() => isDestroyed = true;
    }
}
