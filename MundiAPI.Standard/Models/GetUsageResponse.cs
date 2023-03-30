// <copyright file="GetUsageResponse.cs" company="APIMatic">
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
    /// GetUsageResponse.
    /// </summary>
    public class GetUsageResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse"/> class.
        /// </summary>
        public GetUsageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="description">description.</param>
        /// <param name="usedAt">used_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="status">status.</param>
        /// <param name="subscriptionItem">subscription_item.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="code">code.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="amount">amount.</param>
        public GetUsageResponse(
            string id,
            int quantity,
            string description,
            DateTime usedAt,
            DateTime createdAt,
            string status,
            Models.GetSubscriptionItemResponse subscriptionItem,
            DateTime? deletedAt = null,
            string code = null,
            string mGroup = null,
            int? amount = null)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Description = description;
            this.UsedAt = usedAt;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.DeletedAt = deletedAt;
            this.SubscriptionItem = subscriptionItem;
            this.Code = code;
            this.MGroup = mGroup;
            this.Amount = amount;
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Used at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("used_at")]
        public DateTime UsedAt { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Subscription item
        /// </summary>
        [JsonProperty("subscription_item")]
        public Models.GetSubscriptionItemResponse SubscriptionItem { get; set; }

        /// <summary>
        /// Identification code in the client system
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Identification group in the client system
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string MGroup { get; set; }

        /// <summary>
        /// Field used in item scheme type 'Percent'
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetUsageResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetUsageResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Quantity.Equals(other.Quantity) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.UsedAt.Equals(other.UsedAt) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.SubscriptionItem == null && other.SubscriptionItem == null) || (this.SubscriptionItem?.Equals(other.SubscriptionItem) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.UsedAt = {this.UsedAt}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.SubscriptionItem = {(this.SubscriptionItem == null ? "null" : this.SubscriptionItem.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup == string.Empty ? "" : this.MGroup)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}