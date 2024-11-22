using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities
{
    internal class Component
    {
        public int id {get; private set;}
        public string name { get; private set; }
        public Entity parent { get; private set; }

        public bool isDestroyed { get; private set; } = false;
        public bool isInitialized { get; private set; } = false;
        private bool isEnabled = true;
        private bool isVisible = true;

        public Component(int id, Entity parent, string name = "") 
        { 
            this.id = id;
            this.name = name;
            this.parent = parent;
            Initiate();
        }

        public void Destroy() => isDestroyed = true;
        public void Initiate() => isInitialized = true;

        private void Enable() => isEnabled = true;
        private void Disable() => isEnabled = false;

        private void setVisibility(bool visibility)
        {
            isVisible = visibility;
        }

    }
}
