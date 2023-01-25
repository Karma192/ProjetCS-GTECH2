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

        public string ShowObject()
        {
            string show = _name + " : " + _quantity.ToString();
            return show;
        }

        public bool Use(int quantity)
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
        Ammunitions()
        {
            _name = "Ammunitions";
            _quantity = 0;
        }
    }
}