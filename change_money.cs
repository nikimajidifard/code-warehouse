using System;
namespace qu3
{
    class Program
    {
        public static long MinCoins(long value)
        {
           
           long total = 0; 
           if(value >= 10)
            {
                long cten =value/10; 
                total = cten + total;
                value = value%10; 
            }
            if(value >=5 && value<10)
            {
                long cfive = value/5; 
                total = cfive + total;
                value = value%5; 
            }
            if(value >= 1 && value<=5)
            {
                long cone = value; 
                total = cone + total ;
                value = value%1; 
            }
            return total; 
           
        }
        static void Main(string[] args)
        {
            long val = long.Parse(Console.ReadLine());
           Console.WriteLine(MinCoins(val));
        }
    }
}
