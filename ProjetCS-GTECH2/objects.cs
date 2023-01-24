using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    internal class Object
    {
        string _name;
        int _quantity;

        public string ShowObject()
        {
            string show = _name + " " + _quantity.ToString();
            return show;
        }
    }
}