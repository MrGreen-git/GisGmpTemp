using System;
using System.Linq;

namespace GisGmp
{
    public static class ArrayObjectExtension
    {
        public static string[] ToArrayString<T>(this T[] items) where T : IConvertToString
        {
            if (items is null) return null;

            string[] array = new string[items.Length];

            foreach (var (item, index) in items.WithIndex())
                array[index] = item?.Value;

            return array;
        }

        public static T[] Add<T>(this T[] items, T item) => items.Add(new T[] { item });

        public static T[] Add<T>(this T[] items, T[] array)
        {
            T[] newArray = new T[items.Length + array.Length];

            int ind1 = 0, ind2 = 0;
            while (ind1 < items.Length) newArray[ind1] = items[ind1++];
            while (ind2 < array.Length) newArray[ind1++] = array[ind2++];

            return newArray;
        }

        public static T[] IsRequired<T>(this T[] value) where T : class
            => value ?? throw new Exception($"Параметр обязателен для заполнения, текущее значение null");

        public static T[] IsRange<T>(this T[] value, uint min, uint max) where T : class
            => value is null
                ? value
                : value.Length < min || value.Length > max
                    ? throw new Exception($"Допустимое кол-во элементов {min}..{max}, текущее кол-во {value.Length}")
                    : !value.All(x => x != null)
                           ? throw new Exception($"Элемент не может иметь значение null")
                           : value;
        
        public static T[] IsPattern<T>(this T[] items) where T : class
        {
            return items;
        }
    }
}
