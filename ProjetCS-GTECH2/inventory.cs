using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Object = Objects.Object;

namespace MenuPokemon
{
    public class Inventory
    {
        Object[] _objects = new Object[3];
        Objects.Ammunitions _amo = new();
        public Inventory()
        {
            _objects[0] = _amo;
        }

        public string[] GetObjects()
        {
            string[] objects = new string[4];
            if (_objects != null)
            {
                int i = 0;
                foreach(var obj in _objects)
                {
                    if (obj != null)
                    {
                        objects[i] = obj.ShowObject();
                        i++;
                    }
                }
            }
            return objects;
        }


        public void ShowInventory()
        {
            if (_objects != null)
            {
                int posY = 2;
                foreach (var obj in _objects)
                {
                    posY += 2;
                    if (obj != null)
                    {
                        Console.SetCursorPosition(2, posY);
                        Console.WriteLine(obj.ShowObject());
                    }
                }
            }
        }
    }
}