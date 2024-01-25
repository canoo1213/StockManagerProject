using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asıl_proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //başlangıç ,bitiş ve artış miktarı alınan sayıları yazdırma
            Console.WriteLine("başlangıç sayısını seçiniz:");
            int baslangic = int.Parse(Console.ReadLine());

            Console.WriteLine("bitiş sayısını seçiniz:");
            int bitis = int.Parse(Console.ReadLine());

            Console.WriteLine("artış miktarını seçiniz:");
            int artis = int.Parse(Console.ReadLine());

            for (int a = baslangic; a <= bitis; a += artis) { Console.WriteLine(a); }


        }
    }
}

