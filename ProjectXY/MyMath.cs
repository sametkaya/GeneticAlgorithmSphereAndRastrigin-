using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXY
{
    class MyMath
    {
        public static double variance(int[] a
                      )
        {

            // Compute mean (average 
            // of elements) 
            double sum = 0;

            for (int i = 0; i < a.Length; i++)
                sum += a[i];

            double mean = (double)sum /
                          (double)a.Length;

            // Compute sum squared  
            // differences with mean. 
            double sqDiff = 0;

            for (int i = 0; i < a.Length; i++)
                sqDiff += (a[i] - mean) *
                          (a[i] - mean);

            return (double)sqDiff / a.Length;
        }

        public static double standardDeviation(int[] arr)
        {
            return (double)Math.Sqrt(variance(arr));
        }

        public static double mean(List<Thing> list)
        {
            double sum = 0;
            foreach (Thing athing in list)
            {
                sum += athing.fitnessValue;
            }
            return sum / list.Count;

        }

        public static double median(List<Thing> list)//sorted
        {
            int med = list.Count / 2;

            double medi = (list[med].fitnessValue + list[med + 1].fitnessValue) / 2;

            return medi;
        }

        public static String doubleToBitString(double number)
        {
            long m = BitConverter.DoubleToInt64Bits(number); // 将 double 转成 Int64
            string str = Convert.ToString(m, 2);
            return str;
        }
        
       
        public static double bitStringToDouble(String str)
        {
            long n = Convert.ToInt64(str, 2); // 将二进制字符串转成 Int64
            double number = BitConverter.Int64BitsToDouble(n);
            return number;
        }

        public static void ReplaceAt(ref string input, int index, char newChar)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            char[] chars = input.ToCharArray();
            chars[index] = newChar;
            input= new string(chars);
        }

        public static double GenerateGaussian()
        {


            Random rand = new Random();
            double u1 = rand.NextDouble();
            double u2 = rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            double randNormal = 0 + 2 * randStdNormal;
            return randNormal;
        }

    }

    
}
