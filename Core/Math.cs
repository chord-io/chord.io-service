
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chord.IO.Service.Core
{
    public static class Math {
            public static Int16 Steps (IReadOnlyList<Int16> source, Int16 value) 
        {
            return source
                .Where(x => x >= value)
                .Min();
        }
            public static Int32 Steps (IReadOnlyList<Int32> source, Int32 value) 
        {
            return source
                .Where(x => x >= value)
                .Min();
        }
            public static Int64 Steps (IReadOnlyList<Int64> source, Int64 value) 
        {
            return source
                .Where(x => x >= value)
                .Min();
        }
            public static UInt16 Steps (IReadOnlyList<UInt16> source, UInt16 value) 
        {
            return source
                .Where(x => x >= value)
                .Min();
        }
            public static UInt32 Steps (IReadOnlyList<UInt32> source, UInt32 value) 
        {
            return source
                .Where(x => x >= value)
                .Min();
        }
            public static UInt64 Steps (IReadOnlyList<UInt64> source, UInt64 value) 
        {
            return source
                .Where(x => x >= value)
                .Min();
        }
    }
}