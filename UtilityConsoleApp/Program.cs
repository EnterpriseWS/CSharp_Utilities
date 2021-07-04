using System;

namespace UtilityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ReverString("My God!"));
            Console.WriteLine(ReverseInteger(-123));
        }

        static string ReverString(string theString)
        {
            string rtnString = "";
            for (int idx = theString.Length-1; idx >= 0; idx--)
                rtnString += theString[idx];

            return rtnString;
        }

        static int ReverseInteger(int theInteger)
        {
            string theIntegerStr = theInteger < 0? (-(theInteger)).ToString(): theInteger.ToString();
            
            return theInteger<0? -(Convert.ToInt32(ReverString(theIntegerStr))): Convert.ToInt32(ReverString(theIntegerStr));
        }
    }
}
