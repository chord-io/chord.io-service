using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Chord.IO.Service.Extensions
{
    public static class DictionaryExtension
    {
        public static IReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this Dictionary<TKey, TValue> source)
        {
            return new ReadOnlyDictionary<TKey, TValue>(source);
        }
    }
}
