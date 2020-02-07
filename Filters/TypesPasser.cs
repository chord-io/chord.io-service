using System;

namespace Chord.IO.Service.Filters
{
    public class TypesPasser
    {
        public TypesPasser(Type[] types)
        {
            Types = types;
        }

        public Type[] Types { get; }
    }
}