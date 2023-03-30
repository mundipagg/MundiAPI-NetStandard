// <copyright file="UpdateCardRequest.cs" company="APIMatic">
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
    /// UpdateCardRequest.
    /// </summary>
    public class UpdateCardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardRequest"/> class.
        /// </summary>
        public UpdateCardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardRequest"/> class.
        /// </summary>
        /// <param name="holderName">holder_name.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="billingAddressId">billing_address_id.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="label">label.</param>
        public UpdateCardRequest(
            string holderName,
            int expMonth,
            int expYear,
            string billingAddressId,
            Models.CreateAddressRequest billingAddress,
            Dictionary<string, string> metadata,
            string label)
        {
            this.HolderName = holderName;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.BillingAddressId = billingAddressId;
            this.BillingAddress = billingAddress;
            this.Metadata = metadata;
            this.Label = label;
        }

        /// <summary>
        /// Holder name
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        /// Expiration month
        /// </summary>
        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        /// <summary>
        /// Expiration year
        /// </summary>
        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        /// <summary>
        /// Id of the address to be used as billing address
        /// </summary>
        [JsonProperty("billing_address_id")]
        public string BillingAddressId { get; set; }

        /// <summary>
        /// Billing address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateCardRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateCardRequest other &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                this.ExpMonth.Equals(other.ExpMonth) &&
                this.ExpYear.Equals(other.ExpYear) &&
                ((this.BillingAddressId == null && other.BillingAddressId == null) || (this.BillingAddressId?.Equals(other.BillingAddressId) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.ExpMonth = {this.ExpMonth}");
            toStringOutput.Add($"this.ExpYear = {this.ExpYear}");
            toStringOutput.Add($"this.BillingAddressId = {(this.BillingAddressId == null ? "null" : this.BillingAddressId == string.Empty ? "" : this.BillingAddressId)}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label == string.Empty ? "" : this.Label)}");
        }
    }
}