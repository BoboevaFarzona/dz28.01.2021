using System;

namespace dz28._01._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] el = new string[] { "Фарзона", "Алия", "Нилуфар", "Насиба", "Фируза" };
            int[] el2 = new int[] { 1, 2, 3, 4, 5 };
            double[] el3 = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            float[] el4 = new float[] { 1, 2, 3, 4, 5 };
            decimal[] el5 = new decimal[] { 1, 2, 3, 4, 5 };



            string ab = ArrayHelper.Pop(ref el);
            Console.WriteLine(ab);
            float ij = ArrayHelper.Pop(ref el4);
            Console.WriteLine(ij);
            int ae = ArrayHelper.Pop(ref el2);
            Console.WriteLine(ae);
            decimal aj = ArrayHelper.Pop(ref el5);
            Console.WriteLine(aj);
            double gh = ArrayHelper.Pop(ref el3);
            Console.WriteLine(gh);


            int ac = ArrayHelper.Push(ref el, "4");
            Console.WriteLine(ac);
            float ad = ArrayHelper.Push(ref el2, 2);
            Console.WriteLine(ad);
            double fg = ArrayHelper.Push(ref el3, 2.2);
            Console.WriteLine(fg);
            int hi = ArrayHelper.Push(ref el4, 1);
            Console.WriteLine(hi);
            decimal ai = ArrayHelper.Push(ref el5, 4);
            Console.WriteLine(ai);



            string de = ArrayHelper.Shift(ref el);
            Console.WriteLine(de);
            int af = ArrayHelper.Shift(ref el2);
            Console.WriteLine(af);
            double ah = ArrayHelper.Shift(ref el3);
            Console.WriteLine(ah);
            float kl = ArrayHelper.Shift(ref el4);
            Console.WriteLine(kl);
            decimal al = ArrayHelper.Shift(ref el5);
            Console.WriteLine(al);


            int cd = ArrayHelper.UnShift(ref el, "2");
            Console.WriteLine(cd);
            decimal ag = ArrayHelper.UnShift(ref el3, 1.1);
            Console.WriteLine(ag);
            int ef = ArrayHelper.UnShift(ref el2, 1);
            Console.WriteLine(ef);
            float jk = ArrayHelper.UnShift(ref el4, 2);
            Console.WriteLine(jk);
            int ak = ArrayHelper.UnShift(ref el5, 4);
            Console.WriteLine(ak);

        }
    }
    class ArrayHelper
    {
        public static string Pop(ref string[] arr)
        {
            string el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static float Pop(ref float[] arr)
        {
            float el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static double Pop(ref double[] arr)
        {
            double el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static int Pop(ref int[] arr)
        {
            int el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static decimal Pop(ref decimal[] arr)
        {
            decimal el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static int Push(ref string[] arr, string ele)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = ele;
            return arr.Length;
        }
        public static int Push(ref int[] arr, int el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = el;
            return arr.Length;
        }
        public static int Push(ref double[] arr, double el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = el;
            return arr.Length;
        }
        public static int Push(ref float[] arr, float el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = el;
            return arr.Length;
        }
        public static int Push(ref decimal[] arr, decimal el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = el;
            return arr.Length;
        }
        public static string Shift(ref string[] arr)
        {
            string[] newArr = new string[arr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
            string returnEl = arr[0];
            arr = newArr;
            return returnEl;
        }
        public static int Shift(ref int[] arr)
        {
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
            int returnEl = arr[0];
            arr = newArr;
            return returnEl;
        }
        public static float Shift(ref float[] arr)
        {
            float[] newArr = new float[arr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
            float returnEl = arr[0];
            arr = newArr;
            return returnEl;
        }
        public static double Shift(ref double[] arr)
        {
            double[] newArr = new double[arr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
            double returnEl = arr[0];
            arr = newArr;
            return returnEl;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            decimal[] newArr = new decimal[arr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
            decimal returnEl = arr[0];
            arr = newArr;
            return returnEl;
        }
        public static int UnShift(ref string[] arr, string el)
        {
            string[] newArr = new string[arr.Length + 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[0] = el;
            arr = newArr;
            return arr.Length;
        }
        public static int UnShift(ref int[] arr, int el)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[0] = el;
            arr = newArr;
            return arr.Length;
        }
        public static int UnShift(ref float[] arr, float el)
        {
            float[] newArr = new float[arr.Length + 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[0] = el;
            arr = newArr;
            return arr.Length;
        }
        public static int UnShift(ref double[] arr, double el)
        {
            double[] newArr = new double[arr.Length + 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[0] = el;
            arr = newArr;
            return arr.Length;
        }
        public static int UnShift(ref decimal[] arr, decimal el)
        {
            decimal[] newArr = new decimal[arr.Length + 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[0] = el;
            arr = newArr;
            return arr.Length;
        }
    }

}
