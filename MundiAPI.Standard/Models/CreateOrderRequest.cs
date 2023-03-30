// <copyright file="CreateOrderRequest.cs" company="APIMatic">
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
    /// CreateOrderRequest.
    /// </summary>
    public class CreateOrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest"/> class.
        /// </summary>
        public CreateOrderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest"/> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="customer">customer.</param>
        /// <param name="payments">payments.</param>
        /// <param name="code">code.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="closed">closed.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="antifraudEnabled">antifraud_enabled.</param>
        /// <param name="ip">ip.</param>
        /// <param name="sessionId">session_id.</param>
        /// <param name="location">location.</param>
        /// <param name="device">device.</param>
        /// <param name="currency">currency.</param>
        /// <param name="antifraud">antifraud.</param>
        /// <param name="submerchant">submerchant.</param>
        public CreateOrderRequest(
            List<Models.CreateOrderItemRequest> items,
            Models.CreateCustomerRequest customer,
            List<Models.CreatePaymentRequest> payments,
            string code,
            string customerId,
            Dictionary<string, string> metadata,
            bool closed,
            Models.CreateShippingRequest shipping = null,
            bool? antifraudEnabled = null,
            string ip = null,
            string sessionId = null,
            Models.CreateLocationRequest location = null,
            Models.CreateDeviceRequest device = null,
            string currency = null,
            Models.CreateAntifraudRequest antifraud = null,
            Models.CreateSubMerchantRequest submerchant = null)
        {
            this.Items = items;
            this.Customer = customer;
            this.Payments = payments;
            this.Code = code;
            this.CustomerId = customerId;
            this.Shipping = shipping;
            this.Metadata = metadata;
            this.AntifraudEnabled = antifraudEnabled;
            this.Ip = ip;
            this.SessionId = sessionId;
            this.Location = location;
            this.Device = device;
            this.Closed = closed;
            this.Currency = currency;
            this.Antifraud = antifraud;
            this.Submerchant = submerchant;
        }

        /// <summary>
        /// Items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreateOrderItemRequest> Items { get; set; }

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer { get; set; }

        /// <summary>
        /// Payment data
        /// </summary>
        [JsonProperty("payments")]
        public List<Models.CreatePaymentRequest> Payments { get; set; }

        /// <summary>
        /// The order code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The customer id
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Shipping data
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateShippingRequest Shipping { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Defines whether the order will go through anti-fraud
        /// </summary>
        [JsonProperty("antifraud_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AntifraudEnabled { get; set; }

        /// <summary>
        /// Ip address
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// Session id
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// Request's location
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateLocationRequest Location { get; set; }

        /// <summary>
        /// Device's informations
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateDeviceRequest Device { get; set; }

        /// <summary>
        /// Gets or sets Closed.
        /// </summary>
        [JsonProperty("closed")]
        public bool Closed { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Antifraud.
        /// </summary>
        [JsonProperty("antifraud", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateAntifraudRequest Antifraud { get; set; }

        /// <summary>
        /// SubMerchant
        /// </summary>
        [JsonProperty("submerchant", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubMerchantRequest Submerchant { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrderRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateOrderRequest other &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Payments == null && other.Payments == null) || (this.Payments?.Equals(other.Payments) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.AntifraudEnabled == null && other.AntifraudEnabled == null) || (this.AntifraudEnabled?.Equals(other.AntifraudEnabled) == true)) &&
                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true)) &&
                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Device == null && other.Device == null) || (this.Device?.Equals(other.Device) == true)) &&
                this.Closed.Equals(other.Closed) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Antifraud == null && other.Antifraud == null) || (this.Antifraud?.Equals(other.Antifraud) == true)) &&
                ((this.Submerchant == null && other.Submerchant == null) || (this.Submerchant?.Equals(other.Submerchant) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Payments = {(this.Payments == null ? "null" : $"[{string.Join(", ", this.Payments)} ]")}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId == string.Empty ? "" : this.CustomerId)}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.AntifraudEnabled = {(this.AntifraudEnabled == null ? "null" : this.AntifraudEnabled.ToString())}");
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip == string.Empty ? "" : this.Ip)}");
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId == string.Empty ? "" : this.SessionId)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location.ToString())}");
            toStringOutput.Add($"this.Device = {(this.Device == null ? "null" : this.Device.ToString())}");
            toStringOutput.Add($"this.Closed = {this.Closed}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.Antifraud = {(this.Antifraud == null ? "null" : this.Antifraud.ToString())}");
            toStringOutput.Add($"this.Submerchant = {(this.Submerchant == null ? "null" : this.Submerchant.ToString())}");
        }
    }
}