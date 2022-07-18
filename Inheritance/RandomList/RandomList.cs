using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab
{
    class RandomList:List<string>
    {
        public string RandomString()
        {
            Random stranno = new Random();
            int index = stranno.Next(0, this.Count - 1);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
