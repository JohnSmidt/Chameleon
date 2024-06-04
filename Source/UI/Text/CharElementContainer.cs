using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Source.UI.Text
{
    // Need to think about this being a game object or not. I dont think so, but putting this here
    // just so I can think about it later
    internal class CharElementContainer : GameObject
    {
        string _text;
        float _x;
        float _y;
        float _width;
        float _speed;
        float _tick;
        int _index;
        GameTime gameTime;
        GameObjectContainer _container;

        public CharElementContainer(string text, float x, float y, float width, GameObjectContainer container, float speed = 3000f) 
        {
            _text = text;
            _x = x;
            _y = y;
            _width = width;
            _speed = _tick = speed;
            _index = 0;
            gameTime = new GameTime();
            _container = container;
        }

        public override void Update(GameTime gameTime)
        {
            _tick -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //Debug.WriteLine((float)gameTime.TotalGameTime.TotalMilliseconds);
            //Debug.WriteLine(_tick);
            if (_tick < 0)
            {
                _tick = _speed;
                Debug.WriteLine(_text[_index].ToString());
                CharElement charElement = new CharElement(_text[_index].ToString(), _x, _y, 0, Color.Black);
                _index++;
                _container.Add(charElement);

            }
        }


    }
}
