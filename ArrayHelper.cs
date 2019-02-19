using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            bool symetric = true;

            for (int i = 0; i <= (source.Length - 1) / 2; i++)
            {
                if (source[i] != source[source.Length - 1 - i])
                {
                    symetric = false;
                    return "No";
                }
                
            }
            
            return "Yes";
            
           
            
            
            
        }
    }
}
