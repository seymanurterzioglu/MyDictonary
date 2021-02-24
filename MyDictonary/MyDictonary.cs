using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictonary<TKey, TValue>
    {
        //List olarak tutulması dizi olarak tutulmasında daha iyi

        List<TKey> keys;
        List<TValue> values;
        public MyDictonary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public void Add(TKey key,TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public void Control(TKey arakey)
        {
            //indexof ile gelen arakey in keys deki yerini (index ini) buluyoruz.ve values listinin bu index deki degerini yazdırıyoruz.
            Console.WriteLine(keys.IndexOf(arakey) + ".Key's Value= "+values[keys.IndexOf(arakey)]);
        }

    }
}
