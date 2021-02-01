using System;
using System.Xml.Serialization;

namespace NX.Framework
{
    public static class EnumExtensions
    {
        public static string GetXmlEnumValue(this Enum value) => value.
            GetType().
            GetField(value.ToString()).
            GetCustomAttributes(typeof(XmlEnumAttribute), false) is XmlEnumAttribute[] xmlEnumAttribute &&
                                xmlEnumAttribute.Length > 0 ? xmlEnumAttribute[0].Name : null;
    }
}
