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
using Unity.Services.Multiplay.Http;



namespace Unity.Services.Multiplay.Models
{
    /// <summary>
    /// PayloadTokenResponseBody model
    /// </summary>
    [Preserve]
    [DataContract(Name = "PayloadTokenResponseBody")]
    internal class PayloadTokenResponseBody
    {
        /// <summary>
        /// Creates an instance of PayloadTokenResponseBody.
        /// </summary>
        /// <param name="token">JWT Token string associated to payload requests</param>
        /// <param name="error">Internal multiplay error occurred retrieving the JWT</param>
        [Preserve]
        public PayloadTokenResponseBody(string token, string error)
        {
            Token = token;
            Error = error;
        }

        /// <summary>
        /// JWT Token string associated to payload requests
        /// </summary>
        [Preserve]
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public string Token{ get; }
        
        /// <summary>
        /// Internal multiplay error occurred retrieving the JWT
        /// </summary>
        [Preserve]
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error{ get; }
    
        /// <summary>
        /// Formats a PayloadTokenResponseBody into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Token != null)
            {
                serializedModel += "token," + Token + ",";
            }
            if (Error != null)
            {
                serializedModel += "error," + Error;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a PayloadTokenResponseBody as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Token != null)
            {
                var tokenStringValue = Token.ToString();
                dictionary.Add("token", tokenStringValue);
            }
            
            if (Error != null)
            {
                var errorStringValue = Error.ToString();
                dictionary.Add("error", errorStringValue);
            }
            
            return dictionary;
        }
    }
}
