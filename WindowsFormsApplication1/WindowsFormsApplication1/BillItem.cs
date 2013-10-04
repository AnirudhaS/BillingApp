using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BillItem
    {
        public int ItemNo;
        public String ItemName;
        public double per;
        public int qty;
        public BillItem(int no, String it, double p, int q)
        {
            ItemNo = no;
            ItemName = it;
            per = p;
            qty = q;
        }
    }
}
