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
        [JsonInclude]
        Objects.Ammunitions _amo = new();
        [JsonInclude]
        Objects.Grenade _grenade = new();
        [JsonInclude]
        Objects.Artifice _artifice= new();
        [JsonInclude]
        Objects.Molotove _molotove= new();
        [JsonInclude]
        Objects.IceGrenade _iceGrenade= new();
        
        
        public Inventory()
        {
            _objects.Add(_amo);
            _objects.Add(_grenade);
            _objects.Add(_artifice);
            _objects.Add(_molotove);
            _objects.Add(_iceGrenade);
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