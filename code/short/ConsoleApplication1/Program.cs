using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class IntContainer : IEnumerable
{
    private short[] ints = new short[] { 8,9,0};
    public IEnumerator GetEnumerator()
    {
        return new IntContainerEnum(this);
    }
    public class IntContainerEnum : IEnumerator
    {
        public IntContainerEnum(IntContainer Container)
        {
            myContainer = Container;
        }
        IntContainer myContainer;
        int position = -1;
        public object Current
        {
            get
            {
                return myContainer.ints[position];
            }
        }
        public bool MoveNext()
        {
            position++;
            return position < myContainer.ints.Length;
        }
        public void Reset()
        {
            position = -1;
        }
    }
}
class program
{
    static void Main()
    {
        IntContainer myIntContainer = new IntContainer();
        foreach (short s in myIntContainer)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}