using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i <= (source.Length - 1) / 2; i++)
            {
                if (source[i] != source[source.Length - 1 - i])
                {
                    
                    return "No";
                }
            }

            return "Yes";
            
           
            
            
            
        }
    }
}
