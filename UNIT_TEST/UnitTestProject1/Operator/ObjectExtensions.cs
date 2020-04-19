using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectExtension
{
    public static class ObjectExtensions
    {
        public static IEnumerable<object> MakeEnumerable(this object value)
        {
            if (value is Array array) return array.Cast<object>();

            if (value is IEnumerable<object> objects) return objects;

            throw new ArgumentException("Argument is not enumerable");
        }

        public static bool EqualTo(this object value, object other)
        {

            if (value.IsString() || other.IsString())
                return Convert.ToString(value).Equals(Convert.ToString(other));

            if (value.IsNumeric() && other.IsNumeric())
                return Convert.ToDouble(value).Equals(Convert.ToDouble(other));

            if (value.IsNull()) return other == null;

            return value.Equals(other);
        }

        public static bool IsNumeric(this object value)
        {
            return (value is byte || value is sbyte || value is short || value is ushort || value is int || value is uint ||
                value is long || value is ulong || value is float || value is double || value is decimal);
        }

        public static bool IsBoolean(this object value)
        {
            if (value is bool)
                return true;
            return false;
        }

        public static bool IsString(this object value)
        {
            return (value is string);
        }


        public static bool IsNull(this object value)
        {
            return (value == null);
        }

        public static object GetJValue(this object value)
        {
            if (value is JValue jValue)
                return jValue.Value;
            if (value == null)
                return string.Empty;

            return value;
        }

        public static bool IsValidJson(this object json)
        {
            try
            {
                return JToken.Parse(Convert.ToString(json)) != null;
            }
            catch
            {
                return false;
            }
        }

        public static List<JProperty> GetJProperties(this object json)
        {
            JObject lookUpJObject = JObject.Parse(Convert.ToString(json));
            if (lookUpJObject != null)
            {
                var listChildrens = lookUpJObject.Children<JProperty>().ToList();
                if (listChildrens is List<JProperty> jProperty)
                    return jProperty;
            }

            throw new ArgumentException($"Null or invalid json: '{json}', expected valid 'json'. ");
        }

    }
}
