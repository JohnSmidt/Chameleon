using GameEngine.Source.Tools;
using GameEngine.Source.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        RNG rng;
        char effect;
        bool isBold;
        bool isItalic;
        SpriteFont _font;
        Dictionary<char, float> _fontWidths;
        int width = 0;
        int testWidth = 0;


        public CharElementContainer(string text, float x, float y, float width, GameObjectContainer container, SpriteFont font, Dictionary<char,float> fontWidths, float speed = 30f) 
        {
            rng = new RNG();
            _text = text;
            _x = x;
            _y = y;
            _width = width;
            _speed = _tick = speed;
            _index = 0;
            gameTime = new GameTime();
            _container = container;
            effect = 'n';
            isItalic = false;
            isBold = false;
            _font = font;
            _fontWidths = fontWidths;
        }

        // Making a PML parser 
        public override void Initialize()
        {
            //for (int i = 0; i < _text.Length; i++)
            //{
               
            //}
        }


        public override void Update(GameTime gameTime)
        {
           
            _tick -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (_tick < 0)
            {

                _tick = _speed;
                if (_text[_index] == '<')
                {
                    switch (_text[_index + 1])
                    {
                        case '<':
                            // This is just an escaped '<'
                            break;
                        case 'i':
                            // Italics
                            isItalic = true;
                            break;
                        case 'b':
                            // Bold
                            isBold = true;
                            break;
                        case 'w':
                            // Wavy effect
                            effect = 'w';
                            break;
                        case 's':
                            // Shaky effect
                            effect = 's';
                            break;
                        case 'p':
                            // Poppy effect
                            effect = 'p';
                            break;
                        case 'n':
                            // Forced newline
                            break;
                        case 'c':
                            // Forced clear
                            break;
                        case 'l':
                            // Linefeed
                            break;
                        case 'f':
                            // Font
                            break;
                        case '/':
                            // Closing symbol
                            effect = 'n';
                            isBold = false;
                            isItalic = false;
                            
                            break;
                        default:
                            break;
                    }
                    //for(int j = i; j < _text.Length; j++)
                    //{

                    //}
                }
                switch (effect)
                {
                    case 'w':
                        WavyChar wavyChar = new WavyChar(_text[_index].ToString(), _x + (_index * 10), _y, 0, Color.White);
                        _container.Add(wavyChar);
                        break;
                    case 's':
                        CharElement shaky = new CharElement(_text[_index].ToString(), _x + (_index * 10), _y, 0, Color.White);
                        _container.Add(shaky);
                        break;
                    case 'p':
                        CharElement poppy = new CharElement(_text[_index].ToString(), _x + (_index * 10), _y, 0, Color.White);
                        _container.Add(poppy);
                        break;
                    default:
                        CharElement charElement = new CharElement(_text[_index].ToString(), _x + (_index * 10), _y, 0, Color.White);
                        _container.Add(charElement);
                        break;
                }
                width += (int)_fontWidths[_text[_index]];
                _index++;
                

                if(_index >= _text.Length)
                {
                    // Stay tidy
                    Debug.WriteLine($"Widths are: {width}, {_font.MeasureString(_text).X}");
                    _container.Remove(this);
                }

            }
        }


    }
}
