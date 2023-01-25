using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Object = Objects.Object;

namespace MenuPokemon
{
    public class Inventory
    {
        Object[] objects;
        Objects.Ammunitions amo = new();

        Inventory()
        {
            AddToInventory(amo);
        }

        public void ShowInventory()
        {
            if (objects != null)
            {
                foreach (var obj in objects)
                {
                    Console.WriteLine(obj.ShowObject());
                }
            }
        }

        public void AddToInventory(Object obj)
        {
            int index = objects.Length;
            objects[index] = obj;
        }
    }
}