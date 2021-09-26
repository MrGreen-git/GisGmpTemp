using System;
using System.Collections.Generic;
using System.Text;

namespace GisGmp
{
    internal static class ObjectExtension
    {
        public static T IsRequired<T>(this T value) where T : class
            => value ?? throw new Exception($"Параметр обязателен для заполнения, текущее значение null");
    }
}

