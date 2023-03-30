// <copyright file="GetOrderResponse.cs" company="APIMatic">
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
    /// GetOrderResponse.
    /// </summary>
    public class GetOrderResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponse"/> class.
        /// </summary>
        public GetOrderResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="currency">currency.</param>
        /// <param name="items">items.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="charges">charges.</param>
        /// <param name="invoiceUrl">invoice_url.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="closed">closed.</param>
        /// <param name="customer">customer.</param>
        /// <param name="checkouts">checkouts.</param>
        /// <param name="ip">ip.</param>
        /// <param name="sessionId">session_id.</param>
        /// <param name="location">location.</param>
        /// <param name="device">device.</param>
        public GetOrderResponse(
            string id,
            string code,
            string currency,
            List<Models.GetOrderItemResponse> items,
            string status,
            DateTime createdAt,
            DateTime updatedAt,
            List<Models.GetChargeResponse> charges,
            string invoiceUrl,
            Models.GetShippingResponse shipping,
            Dictionary<string, string> metadata,
            bool closed,
            Models.GetCustomerResponse customer = null,
            List<Models.GetCheckoutPaymentResponse> checkouts = null,
            string ip = null,
            string sessionId = null,
            Models.GetLocationResponse location = null,
            Models.GetDeviceResponse device = null)
        {
            this.Id = id;
            this.Code = code;
            this.Currency = currency;
            this.Items = items;
            this.Customer = customer;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Charges = charges;
            this.InvoiceUrl = invoiceUrl;
            this.Shipping = shipping;
            this.Metadata = metadata;
            this.Checkouts = checkouts;
            this.Ip = ip;
            this.SessionId = sessionId;
            this.Location = location;
            this.Device = device;
            this.Closed = closed;
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
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetOrderItemResponse> Items { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCustomerResponse Customer { get; set; }

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
        /// Gets or sets Charges.
        /// </summary>
        [JsonProperty("charges")]
        public List<Models.GetChargeResponse> Charges { get; set; }

        /// <summary>
        /// Gets or sets InvoiceUrl.
        /// </summary>
        [JsonProperty("invoice_url")]
        public string InvoiceUrl { get; set; }

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
        /// Checkout Payment Settings Response
        /// </summary>
        [JsonProperty("checkouts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GetCheckoutPaymentResponse> Checkouts { get; set; }

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
        /// Location
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetLocationResponse Location { get; set; }

        /// <summary>
        /// Device's informations
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetDeviceResponse Device { get; set; }

        /// <summary>
        /// Indicates whether the order is closed
        /// </summary>
        [JsonProperty("closed")]
        public bool Closed { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetOrderResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetOrderResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.Charges == null && other.Charges == null) || (this.Charges?.Equals(other.Charges) == true)) &&
                ((this.InvoiceUrl == null && other.InvoiceUrl == null) || (this.InvoiceUrl?.Equals(other.InvoiceUrl) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Checkouts == null && other.Checkouts == null) || (this.Checkouts?.Equals(other.Checkouts) == true)) &&
                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true)) &&
                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Device == null && other.Device == null) || (this.Device?.Equals(other.Device) == true)) &&
                this.Closed.Equals(other.Closed);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.Charges = {(this.Charges == null ? "null" : $"[{string.Join(", ", this.Charges)} ]")}");
            toStringOutput.Add($"this.InvoiceUrl = {(this.InvoiceUrl == null ? "null" : this.InvoiceUrl == string.Empty ? "" : this.InvoiceUrl)}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Checkouts = {(this.Checkouts == null ? "null" : $"[{string.Join(", ", this.Checkouts)} ]")}");
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip == string.Empty ? "" : this.Ip)}");
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId == string.Empty ? "" : this.SessionId)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location.ToString())}");
            toStringOutput.Add($"this.Device = {(this.Device == null ? "null" : this.Device.ToString())}");
            toStringOutput.Add($"this.Closed = {this.Closed}");
        }
    }
}