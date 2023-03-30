// <copyright file="GetGatewayRecipientResponse.cs" company="APIMatic">
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
    /// GetGatewayRecipientResponse.
    /// </summary>
    public class GetGatewayRecipientResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayRecipientResponse"/> class.
        /// </summary>
        public GetGatewayRecipientResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayRecipientResponse"/> class.
        /// </summary>
        /// <param name="gateway">gateway.</param>
        /// <param name="status">status.</param>
        /// <param name="pgid">pgid.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        public GetGatewayRecipientResponse(
            string gateway,
            string status,
            string pgid,
            string createdAt,
            string updatedAt)
        {
            this.Gateway = gateway;
            this.Status = status;
            this.Pgid = pgid;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gateway name
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Status of the recipient on the gateway
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Recipient id on the gateway
        /// </summary>
        [JsonProperty("pgid")]
        public string Pgid { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetGatewayRecipientResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetGatewayRecipientResponse other &&
                ((this.Gateway == null && other.Gateway == null) || (this.Gateway?.Equals(other.Gateway) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Pgid == null && other.Pgid == null) || (this.Pgid?.Equals(other.Pgid) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Gateway = {(this.Gateway == null ? "null" : this.Gateway == string.Empty ? "" : this.Gateway)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Pgid = {(this.Pgid == null ? "null" : this.Pgid == string.Empty ? "" : this.Pgid)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt == string.Empty ? "" : this.UpdatedAt)}");
        }
    }
}