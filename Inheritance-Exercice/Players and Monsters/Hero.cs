using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_excc
{
    public class Hero
    {
        public Hero(string username, int level)
        {

        }
        public string Username { get; set; }
        public int Level { get; set; }
        public override string ToString() => $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
    }
}
