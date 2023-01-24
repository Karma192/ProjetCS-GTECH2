using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using Object = Objects.Object;

namespace MenuPokemon
{
    internal class inventory
    {
        Object[] objects;

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
            int lenght = objects.Length +1;
            objects.SetValue(obj, lenght);
        }
    }
}