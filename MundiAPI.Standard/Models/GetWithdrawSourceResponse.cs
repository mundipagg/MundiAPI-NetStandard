// <copyright file="GetWithdrawSourceResponse.cs" company="APIMatic">
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
    /// GetWithdrawSourceResponse.
    /// </summary>
    public class GetWithdrawSourceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawSourceResponse"/> class.
        /// </summary>
        public GetWithdrawSourceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawSourceResponse"/> class.
        /// </summary>
        /// <param name="sourceId">source_id.</param>
        /// <param name="type">type.</param>
        public GetWithdrawSourceResponse(
            string sourceId,
            string type)
        {
            this.SourceId = sourceId;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets SourceId.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

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

            return $"GetWithdrawSourceResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetWithdrawSourceResponse other &&
                ((this.SourceId == null && other.SourceId == null) || (this.SourceId?.Equals(other.SourceId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SourceId = {(this.SourceId == null ? "null" : this.SourceId == string.Empty ? "" : this.SourceId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}