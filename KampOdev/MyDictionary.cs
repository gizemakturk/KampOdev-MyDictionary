using System;
using System.Collections.Generic;
using System.Text;
//Gizem Aktürk
//04.03.2021
namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempkeys = keys;
            TValue[] tempvalues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
            }
            keys[keys.Length - 1] = key;
            for (int i = 0; i < tempvalues.Length; i++)
            {
                values[i] = tempvalues[i];
            }
            values[values.Length - 1] = value;
        }
    }
}
