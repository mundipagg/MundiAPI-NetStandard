// <copyright file="GetPeriodResponse.cs" company="APIMatic">
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
    /// GetPeriodResponse.
    /// </summary>
    public class GetPeriodResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPeriodResponse"/> class.
        /// </summary>
        public GetPeriodResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPeriodResponse"/> class.
        /// </summary>
        /// <param name="startAt">start_at.</param>
        /// <param name="endAt">end_at.</param>
        /// <param name="id">id.</param>
        /// <param name="billingAt">billing_at.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="status">status.</param>
        /// <param name="duration">duration.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="cycle">cycle.</param>
        public GetPeriodResponse(
            DateTime startAt,
            DateTime endAt,
            string id,
            DateTime billingAt,
            Models.GetSubscriptionResponse subscription,
            string status,
            int duration,
            string createdAt,
            string updatedAt,
            int cycle)
        {
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Id = id;
            this.BillingAt = billingAt;
            this.Subscription = subscription;
            this.Status = status;
            this.Duration = duration;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Cycle = cycle;
        }

        /// <summary>
        /// Gets or sets StartAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime StartAt { get; set; }

        /// <summary>
        /// Gets or sets EndAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_at")]
        public DateTime EndAt { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets BillingAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_at")]
        public DateTime BillingAt { get; set; }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Duration.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Cycle.
        /// </summary>
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPeriodResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPeriodResponse other &&
                this.StartAt.Equals(other.StartAt) &&
                this.EndAt.Equals(other.EndAt) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.BillingAt.Equals(other.BillingAt) &&
                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.Duration.Equals(other.Duration) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                this.Cycle.Equals(other.Cycle);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartAt = {this.StartAt}");
            toStringOutput.Add($"this.EndAt = {this.EndAt}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.BillingAt = {this.BillingAt}");
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Duration = {this.Duration}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt == string.Empty ? "" : this.UpdatedAt)}");
            toStringOutput.Add($"this.Cycle = {this.Cycle}");
        }
    }
}