using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public class Bill
    {
        public List<BillItem> bill;
        public double grand_total;
        public DateTime timestamp;
        public int bill_id;
        public Bill()
        {
            bill_id = -1;
            timestamp = DateTime.Now;
            bill = new List<BillItem>(100);
            grand_total = 0;
        }
        ~Bill() {  }

        public void addItem (BillItem item) 
        {
            bill.Add(item);
            
        }
        public void clearBill() 
        {
            bill.Clear(); 
        }
        public void finalize()
        {
            foreach (BillItem b in bill)
            {
                if (b!=null)
                grand_total += b.per * b.qty;
            }
            String query = @"Insert into Bill (timestamp, total) VALUES ('" + timestamp.ToString() + "', '" + Math.Round(grand_total, 2).ToString() + "');";
            SQLiteCommand command = new SQLiteCommand(query, Program.database_connection);
            command.ExecuteNonQuery();
            string sql = @"select last_insert_rowid();";
            SQLiteCommand comm = new SQLiteCommand(sql, Program.database_connection);
            bill_id = int.Parse(comm.ExecuteScalar().ToString());
            
            Stream stream = null;
            stream = new FileStream(@"D:\Project Bills\" + bill_id.ToString() + ".txt", FileMode.OpenOrCreate);
            using (StreamWriter file = new StreamWriter(stream))
            {
                file.WriteLine("                   KGS Billing Software");
                file.WriteLine("                     RSR Software Inc.");
                file.WriteLine("                    Silicon Valley, CA");
                file.WriteLine();
                file.WriteLine();
                file.WriteLine();
                file.WriteLine("Date & Time : " + timestamp.ToString());
                file.WriteLine();
                file.WriteLine();
                file.WriteLine("--------------------------------------------------------------------");
                file.WriteLine("| Sr. No.| Name			             |Price per one| Quantity | Total Price |");
                file.WriteLine("--------------------------------------------------------------------");
                foreach (BillItem b in bill)
                {
                    string serial = null;
                    serial = "| "+b.ItemNo.ToString();
                    serial = padString(serial, 9);
                    file.Write(serial);
                    string name = "|" + b.ItemName;
                    name = padString(name,18);
                    file.Write(name);
                    string per = " | "+ Math.Round(b.per, 2).ToString();
                    per = padString(per,14);
                    file.Write(per);
                    string quant = " | " + b.qty.ToString();
                    quant = padString(quant, 11);
                    file.Write(quant);
                    string tot = " | " + Math.Round(b.per*b.qty, 2).ToString();
                    tot = padString (tot, 15);
                    tot += "|";
                    file.Write(tot);
                    file.WriteLine();
                }
                file.WriteLine("--------------------------------------------------------------------");
                file.WriteLine("                                                     Total : " + Math.Round(grand_total, 2).ToString());
                file.WriteLine();
                file.WriteLine();
                file.WriteLine();
                file.WriteLine();
                file.WriteLine("                                               (Customer's Signature)");
                file.Close();
            }
        }
        public String padString(String str, int dash)
        {
            int length = str.Length;
            length = dash - length;
            for (int i = 0; i < length; i++)
                str += " ";
            return str;
        }
    }
}
