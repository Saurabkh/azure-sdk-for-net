// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for InMageV2RpRecoveryPointType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InMageV2RpRecoveryPointType
    {
        [EnumMember(Value = "Latest")]
        Latest,
        [EnumMember(Value = "LatestApplicationConsistent")]
        LatestApplicationConsistent,
        [EnumMember(Value = "LatestCrashConsistent")]
        LatestCrashConsistent,
        [EnumMember(Value = "LatestProcessed")]
        LatestProcessed
    }
    internal static class InMageV2RpRecoveryPointTypeEnumExtension
    {
        internal static string ToSerializedValue(this InMageV2RpRecoveryPointType? value)  =>
            value == null ? null : ((InMageV2RpRecoveryPointType)value).ToSerializedValue();

        internal static string ToSerializedValue(this InMageV2RpRecoveryPointType value)
        {
            switch( value )
            {
                case InMageV2RpRecoveryPointType.Latest:
                    return "Latest";
                case InMageV2RpRecoveryPointType.LatestApplicationConsistent:
                    return "LatestApplicationConsistent";
                case InMageV2RpRecoveryPointType.LatestCrashConsistent:
                    return "LatestCrashConsistent";
                case InMageV2RpRecoveryPointType.LatestProcessed:
                    return "LatestProcessed";
            }
            return null;
        }

        internal static InMageV2RpRecoveryPointType? ParseInMageV2RpRecoveryPointType(this string value)
        {
            switch( value )
            {
                case "Latest":
                    return InMageV2RpRecoveryPointType.Latest;
                case "LatestApplicationConsistent":
                    return InMageV2RpRecoveryPointType.LatestApplicationConsistent;
                case "LatestCrashConsistent":
                    return InMageV2RpRecoveryPointType.LatestCrashConsistent;
                case "LatestProcessed":
                    return InMageV2RpRecoveryPointType.LatestProcessed;
            }
            return null;
        }
    }
}
