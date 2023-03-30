// <copyright file="GetChargeResponse.cs" company="APIMatic">
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
    /// GetChargeResponse.
    /// </summary>
    public class GetChargeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargeResponse"/> class.
        /// </summary>
        public GetChargeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargeResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="currency">currency.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="canceledAmount">canceled_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="lastTransaction">last_transaction.</param>
        /// <param name="invoice">invoice.</param>
        /// <param name="order">order.</param>
        /// <param name="customer">customer.</param>
        /// <param name="paidAt">paid_at.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="recurrencyCycle">recurrency_cycle.</param>
        /// <param name="interestAndFinePaid">interest_and_fine_paid.</param>
        public GetChargeResponse(
            string id,
            string code,
            string gatewayId,
            int amount,
            string status,
            string currency,
            string paymentMethod,
            DateTime dueAt,
            DateTime createdAt,
            DateTime updatedAt,
            Dictionary<string, string> metadata,
            int canceledAmount,
            int paidAmount,
            Models.GetTransactionResponse lastTransaction = null,
            Models.GetInvoiceResponse invoice = null,
            Models.GetOrderResponse order = null,
            Models.GetCustomerResponse customer = null,
            DateTime? paidAt = null,
            DateTime? canceledAt = null,
            string recurrencyCycle = null,
            int? interestAndFinePaid = null)
        {
            this.Id = id;
            this.Code = code;
            this.GatewayId = gatewayId;
            this.Amount = amount;
            this.Status = status;
            this.Currency = currency;
            this.PaymentMethod = paymentMethod;
            this.DueAt = dueAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastTransaction = lastTransaction;
            this.Invoice = invoice;
            this.Order = order;
            this.Customer = customer;
            this.Metadata = metadata;
            this.PaidAt = paidAt;
            this.CanceledAt = canceledAt;
            this.CanceledAmount = canceledAmount;
            this.PaidAmount = paidAmount;
            this.RecurrencyCycle = recurrencyCycle;
            this.InterestAndFinePaid = interestAndFinePaid;
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
        /// Gets or sets GatewayId.
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId { get; set; }

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
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets DueAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime DueAt { get; set; }

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
        /// Gets or sets LastTransaction.
        /// </summary>
        [JsonProperty("last_transaction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetTransactionResponse LastTransaction { get; set; }

        /// <summary>
        /// Gets or sets Invoice.
        /// </summary>
        [JsonProperty("invoice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetInvoiceResponse Invoice { get; set; }

        /// <summary>
        /// Gets or sets Order.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetOrderResponse Order { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCustomerResponse Customer { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets PaidAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// Gets or sets CanceledAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Canceled Amount
        /// </summary>
        [JsonProperty("canceled_amount")]
        public int CanceledAmount { get; set; }

        /// <summary>
        /// Paid amount
        /// </summary>
        [JsonProperty("paid_amount")]
        public int PaidAmount { get; set; }

        /// <summary>
        /// Defines whether the card has been used one or more times.
        /// </summary>
        [JsonProperty("recurrency_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurrencyCycle { get; set; }

        /// <summary>
        /// interest and fine paid
        /// </summary>
        [JsonProperty("interest_and_fine_paid", NullValueHandling = NullValueHandling.Ignore)]
        public int? InterestAndFinePaid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetChargeResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetChargeResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.GatewayId == null && other.GatewayId == null) || (this.GatewayId?.Equals(other.GatewayId) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                this.DueAt.Equals(other.DueAt) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.LastTransaction == null && other.LastTransaction == null) || (this.LastTransaction?.Equals(other.LastTransaction) == true)) &&
                ((this.Invoice == null && other.Invoice == null) || (this.Invoice?.Equals(other.Invoice) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.PaidAt == null && other.PaidAt == null) || (this.PaidAt?.Equals(other.PaidAt) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                this.CanceledAmount.Equals(other.CanceledAmount) &&
                this.PaidAmount.Equals(other.PaidAmount) &&
                ((this.RecurrencyCycle == null && other.RecurrencyCycle == null) || (this.RecurrencyCycle?.Equals(other.RecurrencyCycle) == true)) &&
                ((this.InterestAndFinePaid == null && other.InterestAndFinePaid == null) || (this.InterestAndFinePaid?.Equals(other.InterestAndFinePaid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.GatewayId = {(this.GatewayId == null ? "null" : this.GatewayId == string.Empty ? "" : this.GatewayId)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.DueAt = {this.DueAt}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.LastTransaction = {(this.LastTransaction == null ? "null" : this.LastTransaction.ToString())}");
            toStringOutput.Add($"this.Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.PaidAt = {(this.PaidAt == null ? "null" : this.PaidAt.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"this.CanceledAmount = {this.CanceledAmount}");
            toStringOutput.Add($"this.PaidAmount = {this.PaidAmount}");
            toStringOutput.Add($"this.RecurrencyCycle = {(this.RecurrencyCycle == null ? "null" : this.RecurrencyCycle == string.Empty ? "" : this.RecurrencyCycle)}");
            toStringOutput.Add($"this.InterestAndFinePaid = {(this.InterestAndFinePaid == null ? "null" : this.InterestAndFinePaid.ToString())}");
        }
    }
}