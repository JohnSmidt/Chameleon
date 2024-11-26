using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class CStamina
    {
        private int _stamina;
        private int _maxStamina;
        public int stamina
        {
            get => _stamina;
            set => _stamina = value;
        }

        public int maxStamina
        {
            get => _maxStamina;
            set => _maxStamina = value;
        }

        public CStamina(int max)
        {
            _maxStamina = max;
            _stamina = _maxStamina;
        }
    }
}
