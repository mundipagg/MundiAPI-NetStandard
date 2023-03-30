// <copyright file="GetUsagesDetailsResponse.cs" company="APIMatic">
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
    /// GetUsagesDetailsResponse.
    /// </summary>
    public class GetUsagesDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsagesDetailsResponse"/> class.
        /// </summary>
        public GetUsagesDetailsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsagesDetailsResponse"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="usages">Usages.</param>
        /// <param name="period">Period.</param>
        /// <param name="totalDiscount">total_discount.</param>
        /// <param name="totalIncrement">total_increment.</param>
        public GetUsagesDetailsResponse(
            string subscriptionId,
            int totalAmount,
            Models.ListUsagesDetailsResponse usages,
            Models.GetPeriodResponse period = null,
            int? totalDiscount = null,
            int? totalIncrement = null)
        {
            this.SubscriptionId = subscriptionId;
            this.TotalAmount = totalAmount;
            this.Period = period;
            this.Usages = usages;
            this.TotalDiscount = totalDiscount;
            this.TotalIncrement = totalIncrement;
        }

        /// <summary>
        /// Subscription Identifier
        /// </summary>
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Current Invoice Amount
        /// </summary>
        [JsonProperty("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// Period Details
        /// </summary>
        [JsonProperty("Period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetPeriodResponse Period { get; set; }

        /// <summary>
        /// Usages Details
        /// </summary>
        [JsonProperty("Usages")]
        public Models.ListUsagesDetailsResponse Usages { get; set; }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_discount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiscount { get; set; }

        /// <summary>
        /// Total inremented value
        /// </summary>
        [JsonProperty("total_increment", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalIncrement { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetUsagesDetailsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetUsagesDetailsResponse other &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                this.TotalAmount.Equals(other.TotalAmount) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.Usages == null && other.Usages == null) || (this.Usages?.Equals(other.Usages) == true)) &&
                ((this.TotalDiscount == null && other.TotalDiscount == null) || (this.TotalDiscount?.Equals(other.TotalDiscount) == true)) &&
                ((this.TotalIncrement == null && other.TotalIncrement == null) || (this.TotalIncrement?.Equals(other.TotalIncrement) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId == string.Empty ? "" : this.SubscriptionId)}");
            toStringOutput.Add($"this.TotalAmount = {this.TotalAmount}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.Usages = {(this.Usages == null ? "null" : this.Usages.ToString())}");
            toStringOutput.Add($"this.TotalDiscount = {(this.TotalDiscount == null ? "null" : this.TotalDiscount.ToString())}");
            toStringOutput.Add($"this.TotalIncrement = {(this.TotalIncrement == null ? "null" : this.TotalIncrement.ToString())}");
        }
    }
}