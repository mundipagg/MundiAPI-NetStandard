// <copyright file="GetTransferTargetResponse.cs" company="APIMatic">
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
    /// GetTransferTargetResponse.
    /// </summary>
    public class GetTransferTargetResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferTargetResponse"/> class.
        /// </summary>
        public GetTransferTargetResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferTargetResponse"/> class.
        /// </summary>
        /// <param name="targetId">target_id.</param>
        /// <param name="type">type.</param>
        public GetTransferTargetResponse(
            string targetId,
            string type)
        {
            this.TargetId = targetId;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets TargetId.
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTransferTargetResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetTransferTargetResponse other &&
                ((this.TargetId == null && other.TargetId == null) || (this.TargetId?.Equals(other.TargetId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TargetId = {(this.TargetId == null ? "null" : this.TargetId == string.Empty ? "" : this.TargetId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}