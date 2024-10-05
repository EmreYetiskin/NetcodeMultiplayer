//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http;

//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Models
{
    /// <summary>
    /// MultiplayBuildsSyncStatus enum.
    /// </summary>
    /// <value>CCD Bucket Synchronisation Status: * `PENDING`: Source bucket synchronisation is pending * `SYNCING`: Source bucket synchronisation is in progress * `SYNCED`: The source bucket has been synchronised * `FAILED`: Source bucket synchronisation has failed </value>
    
    [Preserve]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum MultiplayBuildsSyncStatus
    {
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING = 1,

        /// <summary>
        /// Enum SYNCING for value: SYNCING
        /// </summary>
        [EnumMember(Value = "SYNCING")]
        SYNCING = 2,

        /// <summary>
        /// Enum SYNCED for value: SYNCED
        /// </summary>
        [EnumMember(Value = "SYNCED")]
        SYNCED = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4

    }
}



