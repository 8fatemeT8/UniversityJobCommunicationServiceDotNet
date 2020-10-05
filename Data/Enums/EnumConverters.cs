#nullable enable
using System;
using Microsoft.OpenApi.Extensions;

namespace UniversityJobCommunicationServiceDotNet.Data.Enums
{
    public class EnumConverters
    {
        public static T GetFromEnumName<T>(string enumName)
        {
            return (T) Enum.Parse(typeof(T), enumName, true);
        }

        public static T GetFromEnumValue<T>(int enumValue)
        {
            return Enum.GetName(typeof(T), enumValue).GetEnumFromDisplayName<T>();
        }
        
    }
}