using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.StringsManipulations
{
    class ManpulateString
    {
        public void StringManipulation()
        {
            int[][] JaggedArray = new int[3][];
            JaggedArray[0] = new int[] {8,9,10 };
            JaggedArray[2] = new int[] {5,7};
            JaggedArray[2] = new int[] {4,5,8};

            foreach (var array in JaggedArray)
            {
                Console.WriteLine(JaggedArray);
            }
        }
    }
}
