// <copyright file="GetGatewayResponseResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using MundiAPI.Standard;
    using MundiAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// GetGatewayResponseResponse.
    /// </summary>
    public class GetGatewayResponseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayResponseResponse"/> class.
        /// </summary>
        public GetGatewayResponseResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayResponseResponse"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="errors">errors.</param>
        public GetGatewayResponseResponse(
            string code,
            List<Models.GetGatewayErrorResponse> errors)
        {
            this.Code = code;
            this.Errors = errors;
        }

        /// <summary>
        /// The error code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The gateway response errors list
        /// </summary>
        [JsonProperty("errors")]
        public List<Models.GetGatewayErrorResponse> Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetGatewayResponseResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetGatewayResponseResponse other &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
        }
    }
}