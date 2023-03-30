// <copyright file="CreateSubscriptionRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionRequest.
    /// </summary>
    public class CreateSubscriptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        public CreateSubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="card">card.</param>
        /// <param name="code">code.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="billingType">billing_type.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="description">description.</param>
        /// <param name="currency">currency.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalCount">interval_count.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="items">items.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="setup">setup.</param>
        /// <param name="increments">increments.</param>
        /// <param name="planId">plan_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="billingDay">billing_day.</param>
        /// <param name="installments">installments.</param>
        /// <param name="startAt">start_at.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="cardToken">card_token.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="boletoDueDays">boleto_due_days.</param>
        /// <param name="period">period.</param>
        /// <param name="submerchant">submerchant.</param>
        /// <param name="split">split.</param>
        public CreateSubscriptionRequest(
            Models.CreateCustomerRequest customer,
            Models.CreateCardRequest card,
            string code,
            string paymentMethod,
            string billingType,
            string statementDescriptor,
            string description,
            string currency,
            string interval,
            int intervalCount,
            Models.CreatePricingSchemeRequest pricingScheme,
            List<Models.CreateSubscriptionItemRequest> items,
            Models.CreateShippingRequest shipping,
            List<Models.CreateDiscountRequest> discounts,
            Dictionary<string, string> metadata,
            Models.CreateSetupRequest setup,
            List<Models.CreateIncrementRequest> increments,
            string planId = null,
            string customerId = null,
            string cardId = null,
            int? billingDay = null,
            int? installments = null,
            DateTime? startAt = null,
            int? minimumPrice = null,
            int? cycles = null,
            string cardToken = null,
            string gatewayAffiliationId = null,
            int? quantity = null,
            int? boletoDueDays = null,
            Models.CreatePeriodRequest period = null,
            Models.CreateSubMerchantRequest submerchant = null,
            Models.CreateSubscriptionSplitRequest split = null)
        {
            this.Customer = customer;
            this.Card = card;
            this.Code = code;
            this.PaymentMethod = paymentMethod;
            this.BillingType = billingType;
            this.StatementDescriptor = statementDescriptor;
            this.Description = description;
            this.Currency = currency;
            this.Interval = interval;
            this.IntervalCount = intervalCount;
            this.PricingScheme = pricingScheme;
            this.Items = items;
            this.Shipping = shipping;
            this.Discounts = discounts;
            this.Metadata = metadata;
            this.Setup = setup;
            this.PlanId = planId;
            this.CustomerId = customerId;
            this.CardId = cardId;
            this.BillingDay = billingDay;
            this.Installments = installments;
            this.StartAt = startAt;
            this.MinimumPrice = minimumPrice;
            this.Cycles = cycles;
            this.CardToken = cardToken;
            this.GatewayAffiliationId = gatewayAffiliationId;
            this.Quantity = quantity;
            this.BoletoDueDays = boletoDueDays;
            this.Increments = increments;
            this.Period = period;
            this.Submerchant = submerchant;
            this.Split = split;
        }

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer { get; set; }

        /// <summary>
        /// Card
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// Subscription code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType { get; set; }

        /// <summary>
        /// Statement descriptor for credit card subscriptions
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Subscription description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Interval count
        /// </summary>
        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; }

        /// <summary>
        /// Subscription pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.CreatePricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        /// Subscription items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreateSubscriptionItemRequest> Items { get; set; }

        /// <summary>
        /// Shipping
        /// </summary>
        [JsonProperty("shipping")]
        public Models.CreateShippingRequest Shipping { get; set; }

        /// <summary>
        /// Discounts
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.CreateDiscountRequest> Discounts { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Setup data
        /// </summary>
        [JsonProperty("setup")]
        public Models.CreateSetupRequest Setup { get; set; }

        /// <summary>
        /// Plan id
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// Customer id
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Card id
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// Billing day
        /// </summary>
        [JsonProperty("billing_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingDay { get; set; }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public int? Installments { get; set; }

        /// <summary>
        /// Subscription start date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Subscription minimum price
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <summary>
        /// Number of cycles
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Card token
        /// </summary>
        [JsonProperty("card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CardToken { get; set; }

        /// <summary>
        /// Gateway Affiliation code
        /// </summary>
        [JsonProperty("gateway_affiliation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Days until boleto expires
        /// </summary>
        [JsonProperty("boleto_due_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? BoletoDueDays { get; set; }

        /// <summary>
        /// Increments
        /// </summary>
        [JsonProperty("increments")]
        public List<Models.CreateIncrementRequest> Increments { get; set; }

        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePeriodRequest Period { get; set; }

        /// <summary>
        /// SubMerchant
        /// </summary>
        [JsonProperty("submerchant", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubMerchantRequest Submerchant { get; set; }

        /// <summary>
        /// Subscription's split
        /// </summary>
        [JsonProperty("split", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubscriptionSplitRequest Split { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSubscriptionRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateSubscriptionRequest other &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.BillingType == null && other.BillingType == null) || (this.BillingType?.Equals(other.BillingType) == true)) &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                this.IntervalCount.Equals(other.IntervalCount) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Setup == null && other.Setup == null) || (this.Setup?.Equals(other.Setup) == true)) &&
                ((this.PlanId == null && other.PlanId == null) || (this.PlanId?.Equals(other.PlanId) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.BillingDay == null && other.BillingDay == null) || (this.BillingDay?.Equals(other.BillingDay) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.StartAt == null && other.StartAt == null) || (this.StartAt?.Equals(other.StartAt) == true)) &&
                ((this.MinimumPrice == null && other.MinimumPrice == null) || (this.MinimumPrice?.Equals(other.MinimumPrice) == true)) &&
                ((this.Cycles == null && other.Cycles == null) || (this.Cycles?.Equals(other.Cycles) == true)) &&
                ((this.CardToken == null && other.CardToken == null) || (this.CardToken?.Equals(other.CardToken) == true)) &&
                ((this.GatewayAffiliationId == null && other.GatewayAffiliationId == null) || (this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.BoletoDueDays == null && other.BoletoDueDays == null) || (this.BoletoDueDays?.Equals(other.BoletoDueDays) == true)) &&
                ((this.Increments == null && other.Increments == null) || (this.Increments?.Equals(other.Increments) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.Submerchant == null && other.Submerchant == null) || (this.Submerchant?.Equals(other.Submerchant) == true)) &&
                ((this.Split == null && other.Split == null) || (this.Split?.Equals(other.Split) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.BillingType = {(this.BillingType == null ? "null" : this.BillingType == string.Empty ? "" : this.BillingType)}");
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval == string.Empty ? "" : this.Interval)}");
            toStringOutput.Add($"this.IntervalCount = {this.IntervalCount}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Setup = {(this.Setup == null ? "null" : this.Setup.ToString())}");
            toStringOutput.Add($"this.PlanId = {(this.PlanId == null ? "null" : this.PlanId == string.Empty ? "" : this.PlanId)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId == string.Empty ? "" : this.CustomerId)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId == string.Empty ? "" : this.CardId)}");
            toStringOutput.Add($"this.BillingDay = {(this.BillingDay == null ? "null" : this.BillingDay.ToString())}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"this.StartAt = {(this.StartAt == null ? "null" : this.StartAt.ToString())}");
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"this.Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"this.CardToken = {(this.CardToken == null ? "null" : this.CardToken == string.Empty ? "" : this.CardToken)}");
            toStringOutput.Add($"this.GatewayAffiliationId = {(this.GatewayAffiliationId == null ? "null" : this.GatewayAffiliationId == string.Empty ? "" : this.GatewayAffiliationId)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.BoletoDueDays = {(this.BoletoDueDays == null ? "null" : this.BoletoDueDays.ToString())}");
            toStringOutput.Add($"this.Increments = {(this.Increments == null ? "null" : $"[{string.Join(", ", this.Increments)} ]")}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.Submerchant = {(this.Submerchant == null ? "null" : this.Submerchant.ToString())}");
            toStringOutput.Add($"this.Split = {(this.Split == null ? "null" : this.Split.ToString())}");
        }
    }
}