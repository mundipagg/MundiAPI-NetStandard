// <copyright file="CreateChargeRequest.cs" company="APIMatic">
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
    /// CreateChargeRequest.
    /// </summary>
    public class CreateChargeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest"/> class.
        /// </summary>
        public CreateChargeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="amount">amount.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="customer">customer.</param>
        /// <param name="payment">payment.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="antifraud">antifraud.</param>
        /// <param name="orderId">order_id.</param>
        /// <param name="dueAt">due_at.</param>
        public CreateChargeRequest(
            string code,
            int amount,
            string customerId,
            Models.CreateCustomerRequest customer,
            Models.CreatePaymentRequest payment,
            Dictionary<string, string> metadata,
            Models.CreateAntifraudRequest antifraud,
            string orderId,
            DateTime? dueAt = null)
        {
            this.Code = code;
            this.Amount = amount;
            this.CustomerId = customerId;
            this.Customer = customer;
            this.Payment = payment;
            this.Metadata = metadata;
            this.DueAt = dueAt;
            this.Antifraud = antifraud;
            this.OrderId = orderId;
        }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The amount of the charge, in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The customer's id
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Customer data
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer { get; set; }

        /// <summary>
        /// Payment data
        /// </summary>
        [JsonProperty("payment")]
        public Models.CreatePaymentRequest Payment { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The charge due date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueAt { get; set; }

        /// <summary>
        /// Gets or sets Antifraud.
        /// </summary>
        [JsonProperty("antifraud")]
        public Models.CreateAntifraudRequest Antifraud { get; set; }

        /// <summary>
        /// Order Id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateChargeRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateChargeRequest other &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.DueAt == null && other.DueAt == null) || (this.DueAt?.Equals(other.DueAt) == true)) &&
                ((this.Antifraud == null && other.Antifraud == null) || (this.Antifraud?.Equals(other.Antifraud) == true)) &&
                ((this.OrderId == null && other.OrderId == null) || (this.OrderId?.Equals(other.OrderId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId == string.Empty ? "" : this.CustomerId)}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"this.Antifraud = {(this.Antifraud == null ? "null" : this.Antifraud.ToString())}");
            toStringOutput.Add($"this.OrderId = {(this.OrderId == null ? "null" : this.OrderId == string.Empty ? "" : this.OrderId)}");
        }
    }
}