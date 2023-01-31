using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Object = Objects.Object;

namespace MenuPokemon
{
    public class Inventory
    {
        public List <Object> _objects = new();
        Objects.Ammunitions _amo = new();
        Objects.Grenade _grenade = new();
        
        
        public Inventory()
        {
            _objects.Add(_amo);
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