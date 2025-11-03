using System.Collections.Generic;
using UnityEngine;

namespace br.com.Fonazo.ScriptUtil
{
    [System.Serializable]
    public class CustomDictionary<TKey, TValue>
    {
        [SerializeField]    private NewCustomDictionaryItem<TKey, TValue>[] items;

        public Dictionary<TKey, TValue> ToDictionary()
        {
            Dictionary<TKey, TValue> newDic = new Dictionary<TKey, TValue>();

            foreach (var item in items)
            {
                newDic.Add(item.key, item.value);
            }
            
            return newDic;
        }
    }
    [System.Serializable]
    public class NewCustomDictionaryItem<TKey, TItem>
    {
        public TKey key;
        public TItem value;
    }
}