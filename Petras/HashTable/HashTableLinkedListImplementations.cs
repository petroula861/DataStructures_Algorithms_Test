using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Petras.HashTable
{
    public class HashTableLinkedList
    {
        public LinkedList<ValueKey>[] array;

        public int count;

        public HashTableLinkedList(int count)
        {
            this.count = count;
            array = new LinkedList<ValueKey>[count];

            for (var i=0; i<array.Length; i++)
            {
                array[i]= new LinkedList<ValueKey>();
            }
        }

        public void  AddValue(string key,string value){

            var id = GetId(key);
            var valuekey = new ValueKey{Key=key,Value=value};

            array[id].AddLast(valuekey);
        }

        public string GetValue(string key)
        {
            var id=GetId(key);
            var list = array[id];

            foreach( var item in list )
            {
                if(item.Key.Equals(key))
                   return item.Value;
            }
                   throw new KeyNotFoundException("thn pathses");

        }

        public bool RemoveValue(string key)
        {
            var id = GetId(key);

            var node = array[id].First;

            while( node != null )
            {
                if (node.Value.Key.Equals(key))
                {
                    array[id].Remove(node);
                    return true;
                }

                node = node.Next;
            }


            throw new KeyNotFoundException("not found");

        }
        public int GetId(string key)
        {
            var id = Math.Abs(key.GetHashCode()) % count;
            return id;
        }

    }

    public class ValueKey
    {
        public string Key;
        public string Value;
    }

    ///////////////////same Generics
    ///

    public class HashTableLinkedListGenerics<K, V>
    {
        public LinkedList<ValueKeyGenerics<K, V>>[] array;

        public int count;

        public HashTableLinkedListGenerics(int count)
        {
            this.count = count;
            array = new LinkedList<ValueKeyGenerics<K, V>>[count];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new LinkedList<ValueKeyGenerics<K, V>>();
            }
        }

        public void AddValue(K key, V value)
        {

            var id = GetId(key);

            array[id].AddLast(new ValueKeyGenerics<K,V>(key, value));
        }

        public V GetValue(K key)
        {
            var id = GetId(key);
            var list = array[id];

            foreach (var item in list)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }
            throw new KeyNotFoundException("thn pathses");

        }

        public bool RemoveValue(K key)
        {
            var id = GetId(key);

            var node = array[id].First;

            while (node != null)
            {
                if (node.Value.Key.Equals(key))
                {
                    array[id].Remove(node);
                    return true;
                }

                node = node.Next;
            }


            throw new KeyNotFoundException("not found");

        }
        public int GetId(K key)
        {
            var id = Math.Abs(key.GetHashCode()) % count;
            return id;
        }

    }

    public class ValueKeyGenerics<K,V>
    {
        public K Key ;
        public V Value;
        public ValueKeyGenerics(K key, V value)
        {
            Key = key;
            Value = value;
        }

    }

}
