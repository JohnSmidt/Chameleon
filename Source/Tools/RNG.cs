using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace GameEngine.Source.Tools
{
    internal class RNG : Random
    {
       
        public RNG()
        {
            
        }

        // Returns a weighted 'yes' or 'no'
        public bool binary(float weight)
        {
            if (weight > 100 || weight < 0)
                throw new ArgumentException("weight must be an adequate percentage");
            return (Next(10001) < (weight * 100));
        }

        public float percentage()
        {
            return Next(0, 10001) / 100f;
        }

        public Color color()
        {
            Byte[] b = new Byte[3];
            NextBytes(b);
            return new Color(b[0], b[1], b[2]);
        }

        public T pickFromArray<T>(T[] array)
        {
            return array[Next(0, array.Length)];
        }

        public T pickFromList<T>(List<T> list)
        {
            return list[Next(0, list.Count)];
        }

    }
}
