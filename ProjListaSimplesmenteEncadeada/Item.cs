using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaSimplesmenteEncadeada
{
    internal class Item
    {
        public int Value { get; set; }

        public Item NextValue { get; set; }

        public Item(int newValue)
        {
            this.Value = newValue;
            this.NextValue = null;
        }

        public override string ToString()
        {
            return $"Valor: {Value}\n";
        }
    }
}
