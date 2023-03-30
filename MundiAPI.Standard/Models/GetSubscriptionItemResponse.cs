// <copyright file="GetSubscriptionItemResponse.cs" company="APIMatic">
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
    /// GetSubscriptionItemResponse.
    /// </summary>
    public class GetSubscriptionItemResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionItemResponse"/> class.
        /// </summary>
        public GetSubscriptionItemResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionItemResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="increments">increments.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="name">name.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public GetSubscriptionItemResponse(
            string id,
            string description,
            string status,
            DateTime createdAt,
            DateTime updatedAt,
            Models.GetPricingSchemeResponse pricingScheme,
            List<Models.GetDiscountResponse> discounts,
            List<Models.GetIncrementResponse> increments,
            Models.GetSubscriptionResponse subscription,
            string name,
            int? quantity = null,
            int? cycles = null,
            DateTime? deletedAt = null)
        {
            this.Id = id;
            this.Description = description;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PricingScheme = pricingScheme;
            this.Discounts = discounts;
            this.Increments = increments;
            this.Subscription = subscription;
            this.Name = name;
            this.Quantity = quantity;
            this.Cycles = cycles;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets PricingScheme.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.GetPricingSchemeResponse PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.GetDiscountResponse> Discounts { get; set; }

        /// <summary>
        /// Gets or sets Increments.
        /// </summary>
        [JsonProperty("increments")]
        public List<Models.GetIncrementResponse> Increments { get; set; }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets Cycles.
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeletedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSubscriptionItemResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSubscriptionItemResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Increments == null && other.Increments == null) || (this.Increments?.Equals(other.Increments) == true)) &&
                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Cycles == null && other.Cycles == null) || (this.Cycles?.Equals(other.Cycles) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"this.Increments = {(this.Increments == null ? "null" : $"[{string.Join(", ", this.Increments)} ]")}");
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
        }
    }
}