// <copyright file="CreateSubscriptionItemRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionItemRequest.
    /// </summary>
    public class CreateSubscriptionItemRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionItemRequest"/> class.
        /// </summary>
        public CreateSubscriptionItemRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionItemRequest"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="id">id.</param>
        /// <param name="planItemId">plan_item_id.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="name">name.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        public CreateSubscriptionItemRequest(
            string description,
            Models.CreatePricingSchemeRequest pricingScheme,
            string id,
            string planItemId,
            List<Models.CreateDiscountRequest> discounts,
            string name,
            int? cycles = null,
            int? quantity = null,
            int? minimumPrice = null)
        {
            this.Description = description;
            this.PricingScheme = pricingScheme;
            this.Id = id;
            this.PlanItemId = planItemId;
            this.Discounts = discounts;
            this.Name = name;
            this.Cycles = cycles;
            this.Quantity = quantity;
            this.MinimumPrice = minimumPrice;
        }

        /// <summary>
        /// Item description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.CreatePricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        /// Item id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Plan item id
        /// </summary>
        [JsonProperty("plan_item_id")]
        public string PlanItemId { get; set; }

        /// <summary>
        /// Discounts for the item
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.CreateDiscountRequest> Discounts { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of cycles which the item will be charged
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Quantity of items
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

            return $"CreateSubscriptionItemRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateSubscriptionItemRequest other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.PlanItemId == null && other.PlanItemId == null) || (this.PlanItemId?.Equals(other.PlanItemId) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
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
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.PlanItemId = {(this.PlanItemId == null ? "null" : this.PlanItemId == string.Empty ? "" : this.PlanItemId)}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
        }
    }
}