using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// 
    /// </summary>
    public class RefundIdType : IConvertToString
    {
        protected RefundIdType() { }

        public string Value { get; }

        readonly string[] patterns = { }; // TODO [regex] "\d{8}((0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])\d{4})\d{9}"

        public RefundIdType(string uir)
        {
            if (uir is null) throw new Exception($"{nameof(RefundIdType)} не может иметь значение null");

            foreach (var pattern in patterns)
                if (!Regex.IsMatch(uir, pattern)) throw new Exception($"{nameof(RefundIdType)} не соответствует шаблону {pattern}");

            Value = uir;
        }

        public override string ToString() => Value;

        public static implicit operator RefundIdType(string uir) => new RefundIdType(uir);

        public static implicit operator string(RefundIdType uir) => uir?.Value;
    }
}
