using System;
using System.ComponentModel;

namespace Zeats.Legacy.EnumExtensions
{
    public static class DescriptionExtension
    {
        public static string Description(this Enum @enum)
        {
            var fieldInfo = @enum.GetType().GetField(@enum.ToString());

            var attribArray = fieldInfo.GetCustomAttributes(false);

            if (attribArray.Length == 0)
                return @enum.ToString();

            if (attribArray[0] is DescriptionAttribute attrib)
                return attrib.Description;

            return @enum.ToString();
        }

        public static string Description<T>(this T @enum)
            where T : Enum
        {
            return Description(@enum as Enum);
        }
    }
}