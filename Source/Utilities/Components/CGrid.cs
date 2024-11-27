using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.Utilities.Components
{
    internal class CGrid : Component
    {
        private float _width;
        public float width
        {
            get { return _width; }
        }
        private float _height;
        public float height
        {
            get { return _height; }
        }
        private int _cellsX;
        public int cellsX
        {
            get { return _cellsX; }
        }
        private int _cellsY;
        public int cellsY
        {
            get { return _cellsY; }
        }
        private float[,] _grid;
        public CGrid(int id, Entity parent, float width, float height, int cellsX, int cellsY, string name= "") : base(id, parent, name)
        {
            _width = width;
            _height = height;
            _cellsX = cellsX;
            _cellsY = cellsY;

            _grid = new float[cellsX, cellsY];
        }

    }
}
