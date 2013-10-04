using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BillList
    {
        public List<Bill> billlist;
        public BillList() { billlist = new List<Bill>(100); }
        public void addBill (Bill bill) {billlist.Add(bill);}
    }
}
