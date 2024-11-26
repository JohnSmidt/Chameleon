using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class CMovementState : Component
    {
        public enum States
        {
            Idle,
            Wandering,
            Following,
            Foraging,
            Threat, //Threat Detected
            SD, //Search and destroy
            Fighting,
            Defending
        }

        private States _currentState;

        public States CurrentState
        {
            get => _currentState;
            set => _currentState = value;

        }

        public CMovementState(int id, Entity parent, string name = "") : base(id, parent, name)
        {
            _currentState = States.Wandering;
        }
    }
}
