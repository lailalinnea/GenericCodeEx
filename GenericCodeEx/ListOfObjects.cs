using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCodeEx
{
    class ListOfObjects<T>
    {
        private T[] theList;              //den lista som alla element lagras i 
        private int noOfElements = 10;    //i variabeln bestämms det att det ska finnas 10platser i listan
        private int nextIndex;            //ser till att objectet läggs i rätt element

        /// <summary>
        /// konstruktorn skapar list of objects
        /// </summary>
        public ListOfObjects()
        {
            theList = new T[noOfElements];
            nextIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void AddObject(T obj)
        {
            if (nextIndex >= theList.Length)
            {
                Console.WriteLine("Array length exceeded");
                return;
            }
            theList[nextIndex] = obj;
            nextIndex++;
        }


        public T GetObject(int index)
        {
            if (index >= theList.Length)
            {
                Console.WriteLine("Array index too high");
                return default(T);
            }
            return theList[index];
        }
    }
}
