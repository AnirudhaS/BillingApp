using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    public class ProductItem
    {
        public int id;
        public double price;
        public string name;
        public int stock;
        public ProductItem (int i, double p, string n, int st) {
            id = i;
            price = p;
            name = n;
            stock = st;
        }
    }
}
