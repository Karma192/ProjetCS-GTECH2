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