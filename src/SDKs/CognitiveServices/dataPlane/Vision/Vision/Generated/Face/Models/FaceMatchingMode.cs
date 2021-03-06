// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FaceMatchingMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FaceMatchingMode
    {
        [EnumMember(Value = "matchPerson")]
        MatchPerson,
        [EnumMember(Value = "matchFace")]
        MatchFace
    }
    internal static class FaceMatchingModeEnumExtension
    {
        internal static string ToSerializedValue(this FaceMatchingMode? value)
        {
            return value == null ? null : ((FaceMatchingMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FaceMatchingMode value)
        {
            switch( value )
            {
                case FaceMatchingMode.MatchPerson:
                    return "matchPerson";
                case FaceMatchingMode.MatchFace:
                    return "matchFace";
            }
            return null;
        }

        internal static FaceMatchingMode? ParseFaceMatchingMode(this string value)
        {
            switch( value )
            {
                case "matchPerson":
                    return FaceMatchingMode.MatchPerson;
                case "matchFace":
                    return FaceMatchingMode.MatchFace;
            }
            return null;
        }
    }
}
