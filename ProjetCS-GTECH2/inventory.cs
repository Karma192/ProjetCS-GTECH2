using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using Object = Objects.Object;

namespace MenuPokemon
{
    public class Inventory
    {
        [JsonInclude]
        public List <Object> _objects = new();
        
        public Inventory()
        {
            _objects.Add(new Objects.Ammunitions());
            _objects.Add(new Objects.Grenade());
            _objects.Add(new Objects.Artifice());
            _objects.Add(new Objects.Molotove());
            _objects.Add(new Objects.IceGrenade());

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

            if (_objects != null)
            {
                int i = 0;
                foreach(var obj in _objects)
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