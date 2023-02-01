using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Objects
{
    public class Object
    {
        public string _name;
        public int _quantity;
        public int _maxQuantity;

        public string ShowObject()
        {
            string show = _name + " : " + _quantity.ToString();
            return show;
        }

        public virtual bool Use(int quantity)
        {
            if (_quantity >= quantity)
            {
                _quantity -= quantity;
                return true;
            } else
            {
                Console.WriteLine("You can't use that !");
                return false;
            }
        }
    }
    public class Ammunitions : Object
    {
        public Ammunitions()
        {
            _name = "Ammunitions";
            _quantity = 40;
            _maxQuantity = 40;
        }

        public override bool Use(int quantity)
        {

            return base.Use(quantity);
        }
    }

    public class Grenade : Object
    {
        public Grenade()
        {
            _name = "Grenade";
            _quantity = 10;
            _maxQuantity = 10;
        }
    }
    public class Artifice : Object
    {
        public Artifice()
        {
            _name = "Artifice";
            _quantity = 5;
            _maxQuantity = 5;
        }
    }
    public class Molotove : Object
    {
        public Molotove()
        {
            _name = "Cocktail Molotove";
            _quantity = 5;
            _maxQuantity = 5;
        }
    }
    public class IceGrenade : Object
    {
        public IceGrenade()
        {
            _name = "Ice Grenade";
            _quantity = 5;
            _maxQuantity = 5;
        }
    }
}