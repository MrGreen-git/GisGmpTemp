using System;
using System.Linq;

namespace GisGmp
{
    static class Validator
    {
        public static string String(ref string value, string name, bool required, uint min, uint max)
        {
            return 
                value is null 
                ? required 
                    ? throw new Exception($"{name} не может иметь значание null") 
                    : value
                : value.Length < min || value.Length > max 
                    ? throw new Exception($"{name} допустимое кол-во символов {min}..{max}, текущее кол-во {value.Length}") 
                    : value;
        }

        public static T IsNull<T>(T value, string name)
        {
            return
                value == null 
                    ? throw new Exception($"{name} не может иметь значание null") 
                    : value;
        }

        public static T[] ArrayObj<T>(T[] value, string name, bool required, int min, int max)
        {
            return 
                value is null
                ? required 
                    ? throw new Exception($"{name} не может иметь значание null") 
                    : value
                : value.Length < min || value.Length > max
                    ? throw new Exception($"{name} допустимое кол-во элементов {min}..{max}, текущее кол-во {value.Length}")
                    : !value.All(x => x != null)
                        ? throw new Exception($"{name} элемент не может иметь значение null") 
                        : value;
        }
    }
}
