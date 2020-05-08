using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long cnt = 0;

            while (start + (1000000) > DateTime.Now.Ticks)
            {
                cnt++;
            }

            Console.WriteLine(cnt);


        string[] array = { "오렌지", "두리아", "배", "딸기", "포도", "용과" };
        foreach(string item in array){
                Console.WriteLine(item);
        }



        }



    }
}
