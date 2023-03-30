// <copyright file="UpdateSubscriptionItemRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionItemRequest.
    /// </summary>
    public class UpdateSubscriptionItemRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionItemRequest"/> class.
        /// </summary>
        public UpdateSubscriptionItemRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionItemRequest"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="status">status.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="name">name.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        public UpdateSubscriptionItemRequest(
            string description,
            string status,
            Models.UpdatePricingSchemeRequest pricingScheme,
            string name,
            int? cycles = null,
            int? quantity = null,
            int? minimumPrice = null)
        {
            this.Description = description;
            this.Status = status;
            this.PricingScheme = pricingScheme;
            this.Name = name;
            this.Cycles = cycles;
            this.Quantity = quantity;
            this.MinimumPrice = minimumPrice;
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.UpdatePricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of cycles that the item will be charged
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateSubscriptionItemRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateSubscriptionItemRequest other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Cycles == null && other.Cycles == null) || (this.Cycles?.Equals(other.Cycles) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.MinimumPrice == null && other.MinimumPrice == null) || (this.MinimumPrice?.Equals(other.MinimumPrice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
        }
    }
}