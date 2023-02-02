using Newtonsoft.Json;
using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Object = Objects.Object;

namespace MenuPokemon
{
    public class Inventory
    {
        List<Object> objects;

        
        public List<Object> Objects { get => objects; init => objects=value; }


        public Inventory()
        {
            objects = new List<Object>();
            // objects.Add(new Ammunitions());
            // objects.Add(new Grenade());
            // objects.Add(new Artifice());
            // objects.Add(new Molotove());
            // objects.Add(new IceGrenade());

            //foreach (var el in _objects)
            //{
            //    if(el is Ammunitions)
            //    {
            //     //   ((Ammunitions) el).
            //    }
            //    switch(el)
            //    {
            //        case Ammunitions a:
            //            break;
            //        case Grenade g: 
            //            break;
            //    }
            //}
        }

        public List<string> GetObjects()
        {
           List<string> objects = new ();

            if (Objects != null)
            {
                int i = 0;
                foreach(var obj in Objects)
                {
                    if (obj != null)
                    {
                        objects.Add(obj.ShowObject());
                        i++;
                    }
                }
            }
            return objects;
        }


        public void ShowInventory()
        {
            if (Objects != null)
            {
                int posY = 2;
                foreach (var obj in Objects)
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