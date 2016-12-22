using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
class shortContainer : IEnumerable<short>
{
    private short[] shorts = new short[] { 8,9,0};
    public IEnumerator GetEnumerator()
    {
        return new ShortContainerEnumerator(this);
    }

    IEnumerator<short> IEnumerable<short>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public class ShortContainerEnumerator : IEnumerator<short>
    {
        public ShortContainerEnumerator(shortContainer Container)
        {
            myContainer = Container; 
        }
        shortContainer myContainer;
        int position = -1;
        public bool MoveNext()
        {
            position++;
            return (position<myContainer.shorts.Length);
        }
        public short Current
        {
            get
            {
                return myContainer.shorts[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return  Current; 
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
        }
    }
}
class program
{
    static void Main()
    {
        shortContainer myShortContainer = new shortContainer();
        foreach (short s in myShortContainer)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}