using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
public class IntContainer : IEnumerable
{
    private short[] ints;
    public IEnumerator GetEnumerator()
    {
        return new IntContainerEnum(this);
    }
    public class IntContainerEnum : IEnumerator
    {
        public IntContainerEnum(IntContainer Container)
        {
            myIntContainer = Container;
        }
        IntContainer myIntContainer;
            int position = -1;
        public object Current
        {
            get
            {
                return myIntContainer.ints[position];
            }
        }
        public bool MoveNext()
        {
            position++;
            return (position<myIntContainer.ints.Length);
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
        short[] ints = new short[] { 8, 9, 0 };
        IntContainer myContainers = new IntContainer();
        foreach (short s in myContainers)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}