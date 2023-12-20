using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomework
{
    internal class MyDictionary<X,Y>
    {
        X[] keys, temp1;
        Y[] values, temp2;
        public MyDictionary()
        {

            keys = new X[0];
            values = new Y[0];

        }
        public void Add(X key, Y value)
        {
            X[] temp1 = keys; Y[] temp2 = values;
            keys = new X[keys.Length + 1];
            values = new Y[values.Length + 1];
            for (int i = 0; i < temp1.Length; i++)
            {
                keys[i] = temp1[i];
                values[i] = temp2[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int _Length { get { return keys.Length; } }
        public X[] _Keys { get { return keys; } }
        public Y[] _Values { get { return values; } }
    }
}
