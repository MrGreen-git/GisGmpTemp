using System;
using System.Linq;
using System.Reflection;

namespace GisGmp
{
    static class Clone
    {
        static public void Field<T, S>(T obj, S src)
            where T : class
            where S : class
        {
            if (typeof(T) != typeof(S)) throw new Exception("Class Clone.Field: Разные типы");

            typeof(S)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .ToList()
                .ForEach(x => x.SetValue(obj, x.GetValue(src)));
        }
    }
}
