// <copyright file="GetSubscriptionResponse.cs" company="APIMatic">
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
    /// GetSubscriptionResponse.
    /// </summary>
    public class GetSubscriptionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse"/> class.
        /// </summary>
        public GetSubscriptionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="startAt">start_at.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalCount">interval_count.</param>
        /// <param name="billingType">billing_type.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="currency">currency.</param>
        /// <param name="installments">installments.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="card">card.</param>
        /// <param name="items">items.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="setup">setup.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="increments">increments.</param>
        /// <param name="split">split.</param>
        /// <param name="currentCycle">current_cycle.</param>
        /// <param name="customer">customer.</param>
        /// <param name="nextBillingAt">next_billing_at.</param>
        /// <param name="billingDay">billing_day.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="boletoDueDays">boleto_due_days.</param>
        public GetSubscriptionResponse(
            string id,
            string code,
            DateTime startAt,
            string interval,
            int intervalCount,
            string billingType,
            string paymentMethod,
            string currency,
            int installments,
            string status,
            DateTime createdAt,
            DateTime updatedAt,
            Models.GetCardResponse card,
            List<Models.GetSubscriptionItemResponse> items,
            string statementDescriptor,
            Dictionary<string, string> metadata,
            Models.GetSetupResponse setup,
            string gatewayAffiliationId,
            List<Models.GetIncrementResponse> increments,
            Models.GetSubscriptionSplitResponse split,
            Models.GetPeriodResponse currentCycle = null,
            Models.GetCustomerResponse customer = null,
            DateTime? nextBillingAt = null,
            int? billingDay = null,
            int? minimumPrice = null,
            DateTime? canceledAt = null,
            List<Models.GetDiscountResponse> discounts = null,
            int? boletoDueDays = null)
        {
            this.Id = id;
            this.Code = code;
            this.StartAt = startAt;
            this.Interval = interval;
            this.IntervalCount = intervalCount;
            this.BillingType = billingType;
            this.CurrentCycle = currentCycle;
            this.PaymentMethod = paymentMethod;
            this.Currency = currency;
            this.Installments = installments;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Customer = customer;
            this.Card = card;
            this.Items = items;
            this.StatementDescriptor = statementDescriptor;
            this.Metadata = metadata;
            this.Setup = setup;
            this.GatewayAffiliationId = gatewayAffiliationId;
            this.NextBillingAt = nextBillingAt;
            this.BillingDay = billingDay;
            this.MinimumPrice = minimumPrice;
            this.CanceledAt = canceledAt;
            this.Discounts = discounts;
            this.Increments = increments;
            this.BoletoDueDays = boletoDueDays;
            this.Split = split;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets StartAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime StartAt { get; set; }

        /// <summary>
        /// Gets or sets Interval.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Gets or sets IntervalCount.
        /// </summary>
        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; }

        /// <summary>
        /// Gets or sets BillingType.
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType { get; set; }

        /// <summary>
        /// Gets or sets CurrentCycle.
        /// </summary>
        [JsonProperty("current_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetPeriodResponse CurrentCycle { get; set; }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Installments.
        /// </summary>
        [JsonProperty("installments")]
        public int Installments { get; set; }

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
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCustomerResponse Customer { get; set; }

        /// <summary>
        /// Gets or sets Card.
        /// </summary>
        [JsonProperty("card")]
        public Models.GetCardResponse Card { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetSubscriptionItemResponse> Items { get; set; }

        /// <summary>
        /// Gets or sets StatementDescriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Setup.
        /// </summary>
        [JsonProperty("setup")]
        public Models.GetSetupResponse Setup { get; set; }

        /// <summary>
        /// Affiliation Code
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// Gets or sets NextBillingAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NextBillingAt { get; set; }

        /// <summary>
        /// Gets or sets BillingDay.
        /// </summary>
        [JsonProperty("billing_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingDay { get; set; }

        /// <summary>
        /// Gets or sets MinimumPrice.
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <summary>
        /// Gets or sets CanceledAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Subscription discounts
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GetDiscountResponse> Discounts { get; set; }

        /// <summary>
        /// Subscription increments
        /// </summary>
        [JsonProperty("increments")]
        public List<Models.GetIncrementResponse> Increments { get; set; }

        /// <summary>
        /// Days until boleto expires
        /// </summary>
        [JsonProperty("boleto_due_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? BoletoDueDays { get; set; }

        /// <summary>
        /// Subscription's split response
        /// </summary>
        [JsonProperty("split")]
        public Models.GetSubscriptionSplitResponse Split { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSubscriptionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSubscriptionResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                this.StartAt.Equals(other.StartAt) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                this.IntervalCount.Equals(other.IntervalCount) &&
                ((this.BillingType == null && other.BillingType == null) || (this.BillingType?.Equals(other.BillingType) == true)) &&
                ((this.CurrentCycle == null && other.CurrentCycle == null) || (this.CurrentCycle?.Equals(other.CurrentCycle) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                this.Installments.Equals(other.Installments) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Setup == null && other.Setup == null) || (this.Setup?.Equals(other.Setup) == true)) &&
                ((this.GatewayAffiliationId == null && other.GatewayAffiliationId == null) || (this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true)) &&
                ((this.NextBillingAt == null && other.NextBillingAt == null) || (this.NextBillingAt?.Equals(other.NextBillingAt) == true)) &&
                ((this.BillingDay == null && other.BillingDay == null) || (this.BillingDay?.Equals(other.BillingDay) == true)) &&
                ((this.MinimumPrice == null && other.MinimumPrice == null) || (this.MinimumPrice?.Equals(other.MinimumPrice) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Increments == null && other.Increments == null) || (this.Increments?.Equals(other.Increments) == true)) &&
                ((this.BoletoDueDays == null && other.BoletoDueDays == null) || (this.BoletoDueDays?.Equals(other.BoletoDueDays) == true)) &&
                ((this.Split == null && other.Split == null) || (this.Split?.Equals(other.Split) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.StartAt = {this.StartAt}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval == string.Empty ? "" : this.Interval)}");
            toStringOutput.Add($"this.IntervalCount = {this.IntervalCount}");
            toStringOutput.Add($"this.BillingType = {(this.BillingType == null ? "null" : this.BillingType == string.Empty ? "" : this.BillingType)}");
            toStringOutput.Add($"this.CurrentCycle = {(this.CurrentCycle == null ? "null" : this.CurrentCycle.ToString())}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.Installments = {this.Installments}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Setup = {(this.Setup == null ? "null" : this.Setup.ToString())}");
            toStringOutput.Add($"this.GatewayAffiliationId = {(this.GatewayAffiliationId == null ? "null" : this.GatewayAffiliationId == string.Empty ? "" : this.GatewayAffiliationId)}");
            toStringOutput.Add($"this.NextBillingAt = {(this.NextBillingAt == null ? "null" : this.NextBillingAt.ToString())}");
            toStringOutput.Add($"this.BillingDay = {(this.BillingDay == null ? "null" : this.BillingDay.ToString())}");
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"this.Increments = {(this.Increments == null ? "null" : $"[{string.Join(", ", this.Increments)} ]")}");
            toStringOutput.Add($"this.BoletoDueDays = {(this.BoletoDueDays == null ? "null" : this.BoletoDueDays.ToString())}");
            toStringOutput.Add($"this.Split = {(this.Split == null ? "null" : this.Split.ToString())}");
        }
    }
}