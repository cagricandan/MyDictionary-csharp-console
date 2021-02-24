using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{

    class MyDictionary<TKey,TValue>
    {
        TKey[] _Key;
        TValue[] _Value;
        TKey[] tempKey;
        TValue[] tempValue;
        public MyDictionary()
        {
            _Key = new TKey[0];
            _Value = new TValue[0];
        }

        public void Add(TKey key , TValue value)
        {


            tempKey = _Key;
            tempValue = _Value;
            _Key = new TKey[_Key.Length + 1];
            _Value = new TValue[_Value.Length + 1];

            for (int i = 0; i <tempKey.Length; i++)
            {
                _Key[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                _Value[i] = tempValue[i];
            }

            _Key[_Key.Length - 1] = key;
            _Value[_Value.Length - 1] = value;

        }

        

        public int Count
        {
            get { return _Key.Length; }
        }

        public void ToList()
        {
            for (int i = 0; i < _Key.Length; i++)
            {
                Console.WriteLine(i+1 +". : "+_Key[i] +" = " +_Value[i]);
            }
        
        
        }


    }
}
