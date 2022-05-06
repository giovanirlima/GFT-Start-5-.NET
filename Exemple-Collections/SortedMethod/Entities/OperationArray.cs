using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedMethod.Entities
{
    public class OperationArray
    {
        public void Order(ref int[] array)
        {
            Array.Sort(array);
        }


        public void PrintOut(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void CopyLogica(int[] array, int[] copy)
        {
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
        }

        public void Copy(int[] array, int[] copy)
        {
            Array.Copy(array, copy, array.Length);
        }

        public bool Exist(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

       

    }
}
