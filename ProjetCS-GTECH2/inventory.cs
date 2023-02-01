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
        [JsonIgnore] List<Object> objects = new();

        [JsonInclude] public Objects.Ammunitions _amo = new();
        [JsonInclude] public Objects.Grenade _grenade = new();
        [JsonInclude] public Objects.Artifice _artifice = new();
        [JsonInclude] public Objects.Molotove _molotove = new();
        [JsonInclude] public Objects.IceGrenade _iceGrenade = new();

        [JsonIgnore]
        public List<Object> Objects { get => objects;}

        public Inventory()
        {
            Objects.Add(_amo);
            Objects.Add(_grenade);
            Objects.Add(_artifice);
            Objects.Add(_molotove);
            Objects.Add(_iceGrenade);

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