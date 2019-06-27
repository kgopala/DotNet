using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class Class55Lists
    {
        List<ListCLass> listObj = new List<ListCLass>();

        public void Listpractice()
        {
            foreach (var item in listObj)
            {
                listObj.Add(new ListCLass() {numbers = 3, names = "Hello" });
            }

            foreach (var x in listObj)
            {
                listObj.ForEach(Console.WriteLine);
            }                    
        }
    }

    class ListCLass
    {
       public int numbers { get; set; }
       public string names { get; set; }
       public List<int> listNumbers = new List<int>();    
    }
}
