using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3 {
    public class ElementContainer<T> : IEnumerable<T> {
        private List<T> innerList = new List<T>();
        public IEnumerator<T> GetEnumerator() {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
        public void Add(T element) {
            throw new NotImplementedException();
        }

        public class ElementEnumerator<T> : IEnumerator<T> {
            public T Current {
                get {
                    throw new NotImplementedException();
                }
            }

            object IEnumerator.Current {
                get {
                    throw new NotImplementedException();
                }
            }

            public void Dispose() {
                //这个方法不用写
            }

            public bool MoveNext() {
                throw new NotImplementedException();
            }

            public void Reset() {
                throw new NotImplementedException();
            }
        }
    }
}
