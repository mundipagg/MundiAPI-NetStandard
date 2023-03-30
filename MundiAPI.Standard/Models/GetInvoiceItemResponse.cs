// <copyright file="GetInvoiceItemResponse.cs" company="APIMatic">
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
    /// GetInvoiceItemResponse.
    /// </summary>
    public class GetInvoiceItemResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceItemResponse"/> class.
        /// </summary>
        public GetInvoiceItemResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceItemResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="priceBracket">price_bracket.</param>
        /// <param name="subscriptionItemId">subscription_item_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="name">name.</param>
        public GetInvoiceItemResponse(
            int amount,
            string description,
            Models.GetPricingSchemeResponse pricingScheme,
            Models.GetPriceBracketResponse priceBracket,
            string subscriptionItemId,
            int? quantity = null,
            string name = null)
        {
            this.Amount = amount;
            this.Description = description;
            this.PricingScheme = pricingScheme;
            this.PriceBracket = priceBracket;
            this.Quantity = quantity;
            this.Name = name;
            this.SubscriptionItemId = subscriptionItemId;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets PricingScheme.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.GetPricingSchemeResponse PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets PriceBracket.
        /// </summary>
        [JsonProperty("price_bracket")]
        public Models.GetPriceBracketResponse PriceBracket { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Subscription Item Id
        /// </summary>
        [JsonProperty("subscription_item_id")]
        public string SubscriptionItemId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetInvoiceItemResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetInvoiceItemResponse other &&
                this.Amount.Equals(other.Amount) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.PriceBracket == null && other.PriceBracket == null) || (this.PriceBracket?.Equals(other.PriceBracket) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.SubscriptionItemId == null && other.SubscriptionItemId == null) || (this.SubscriptionItemId?.Equals(other.SubscriptionItemId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.PriceBracket = {(this.PriceBracket == null ? "null" : this.PriceBracket.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.SubscriptionItemId = {(this.SubscriptionItemId == null ? "null" : this.SubscriptionItemId == string.Empty ? "" : this.SubscriptionItemId)}");
        }
    }
}