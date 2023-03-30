// <copyright file="GetInvoiceResponse.cs" company="APIMatic">
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
    /// GetInvoiceResponse.
    /// </summary>
    public class GetInvoiceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse"/> class.
        /// </summary>
        public GetInvoiceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="url">url.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="items">items.</param>
        /// <param name="charge">charge.</param>
        /// <param name="installments">installments.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="customer">customer.</param>
        /// <param name="cycle">cycle.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="billingAt">billing_at.</param>
        /// <param name="seenAt">seen_at.</param>
        /// <param name="totalDiscount">total_discount.</param>
        /// <param name="totalIncrement">total_increment.</param>
        public GetInvoiceResponse(
            string id,
            string code,
            string url,
            int amount,
            string status,
            string paymentMethod,
            DateTime createdAt,
            List<Models.GetInvoiceItemResponse> items,
            Models.GetChargeResponse charge,
            int installments,
            Models.GetBillingAddressResponse billingAddress,
            Models.GetSubscriptionResponse subscription,
            Models.GetShippingResponse shipping,
            Dictionary<string, string> metadata,
            string subscriptionId,
            Models.GetCustomerResponse customer = null,
            Models.GetPeriodResponse cycle = null,
            DateTime? dueAt = null,
            DateTime? canceledAt = null,
            DateTime? billingAt = null,
            DateTime? seenAt = null,
            int? totalDiscount = null,
            int? totalIncrement = null)
        {
            this.Id = id;
            this.Code = code;
            this.Url = url;
            this.Amount = amount;
            this.Status = status;
            this.PaymentMethod = paymentMethod;
            this.CreatedAt = createdAt;
            this.Items = items;
            this.Customer = customer;
            this.Charge = charge;
            this.Installments = installments;
            this.BillingAddress = billingAddress;
            this.Subscription = subscription;
            this.Cycle = cycle;
            this.Shipping = shipping;
            this.Metadata = metadata;
            this.DueAt = dueAt;
            this.CanceledAt = canceledAt;
            this.BillingAt = billingAt;
            this.SeenAt = seenAt;
            this.TotalDiscount = totalDiscount;
            this.TotalIncrement = totalIncrement;
            this.SubscriptionId = subscriptionId;
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
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetInvoiceItemResponse> Items { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCustomerResponse Customer { get; set; }

        /// <summary>
        /// Gets or sets Charge.
        /// </summary>
        [JsonProperty("charge")]
        public Models.GetChargeResponse Charge { get; set; }

        /// <summary>
        /// Gets or sets Installments.
        /// </summary>
        [JsonProperty("installments")]
        public int Installments { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.GetBillingAddressResponse BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription { get; set; }

        /// <summary>
        /// Gets or sets Cycle.
        /// </summary>
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetPeriodResponse Cycle { get; set; }

        /// <summary>
        /// Gets or sets Shipping.
        /// </summary>
        [JsonProperty("shipping")]
        public Models.GetShippingResponse Shipping { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets DueAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueAt { get; set; }

        /// <summary>
        /// Gets or sets CanceledAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Gets or sets BillingAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BillingAt { get; set; }

        /// <summary>
        /// Gets or sets SeenAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("seen_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SeenAt { get; set; }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_discount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiscount { get; set; }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_increment", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalIncrement { get; set; }

        /// <summary>
        /// Subscription Id
        /// </summary>
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetInvoiceResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetInvoiceResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Charge == null && other.Charge == null) || (this.Charge?.Equals(other.Charge) == true)) &&
                this.Installments.Equals(other.Installments) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true)) &&
                ((this.Cycle == null && other.Cycle == null) || (this.Cycle?.Equals(other.Cycle) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.DueAt == null && other.DueAt == null) || (this.DueAt?.Equals(other.DueAt) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.BillingAt == null && other.BillingAt == null) || (this.BillingAt?.Equals(other.BillingAt) == true)) &&
                ((this.SeenAt == null && other.SeenAt == null) || (this.SeenAt?.Equals(other.SeenAt) == true)) &&
                ((this.TotalDiscount == null && other.TotalDiscount == null) || (this.TotalDiscount?.Equals(other.TotalDiscount) == true)) &&
                ((this.TotalIncrement == null && other.TotalIncrement == null) || (this.TotalIncrement?.Equals(other.TotalIncrement) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Charge = {(this.Charge == null ? "null" : this.Charge.ToString())}");
            toStringOutput.Add($"this.Installments = {this.Installments}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"this.Cycle = {(this.Cycle == null ? "null" : this.Cycle.ToString())}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"this.BillingAt = {(this.BillingAt == null ? "null" : this.BillingAt.ToString())}");
            toStringOutput.Add($"this.SeenAt = {(this.SeenAt == null ? "null" : this.SeenAt.ToString())}");
            toStringOutput.Add($"this.TotalDiscount = {(this.TotalDiscount == null ? "null" : this.TotalDiscount.ToString())}");
            toStringOutput.Add($"this.TotalIncrement = {(this.TotalIncrement == null ? "null" : this.TotalIncrement.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId == string.Empty ? "" : this.SubscriptionId)}");
        }
    }
}