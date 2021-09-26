using System;
using System.Collections.Generic;
using System.Text;

namespace GisGmp
{
    internal static class StringExtension
    {            
        public static string IsLength(this string value, uint min, uint max)
            => value is null
                ? value
                : value.Length < min || value.Length > max              
                    ? throw new Exception($"Допустимое кол-во символов {min}..{max}, текущее кол-во {value.Length}")
                    : value;

        public static string IsPattern(this string value, string pattern)
            => value;
    }  
}
