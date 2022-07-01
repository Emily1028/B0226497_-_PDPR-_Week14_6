using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week14_6
{
    class Program
    {
        public static void KG(int a)
        {
            if (a > 5)
                Console.Write("網路購物重量:" + a + " 運費:"+(299+a*20));
            else
                Console.Write("網路購物重量:" + a + " 運費:" + (299 + a * 30));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week14_6");
            int kg;
            Console.Write("請輸入網路購物重量:");
            kg = int.Parse(Console.ReadLine());
            KG(kg);
            Console.ReadLine();
        }
    }
}
