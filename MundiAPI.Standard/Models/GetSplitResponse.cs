// <copyright file="GetSplitResponse.cs" company="APIMatic">
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
    /// GetSplitResponse.
    /// </summary>
    public class GetSplitResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitResponse"/> class.
        /// </summary>
        public GetSplitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitResponse"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="id">id.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="options">options.</param>
        public GetSplitResponse(
            string type,
            int amount,
            string gatewayId,
            string id,
            Models.GetRecipientResponse recipient = null,
            Models.GetSplitOptionsResponse options = null)
        {
            this.Type = type;
            this.Amount = amount;
            this.Recipient = recipient;
            this.GatewayId = gatewayId;
            this.Options = options;
            this.Id = id;
        }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetRecipientResponse Recipient { get; set; }

        /// <summary>
        /// The split rule gateway id
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetSplitOptionsResponse Options { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSplitResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSplitResponse other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.GatewayId == null && other.GatewayId == null) || (this.GatewayId?.Equals(other.GatewayId) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"this.GatewayId = {(this.GatewayId == null ? "null" : this.GatewayId == string.Empty ? "" : this.GatewayId)}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
        }
    }
}