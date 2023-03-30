// <copyright file="GetCheckoutPaymentSettingsResponse.cs" company="APIMatic">
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
    /// GetCheckoutPaymentSettingsResponse.
    /// </summary>
    public class GetCheckoutPaymentSettingsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentSettingsResponse"/> class.
        /// </summary>
        public GetCheckoutPaymentSettingsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentSettingsResponse"/> class.
        /// </summary>
        /// <param name="successUrl">success_url.</param>
        /// <param name="paymentUrl">payment_url.</param>
        /// <param name="acceptedPaymentMethods">accepted_payment_methods.</param>
        /// <param name="status">status.</param>
        /// <param name="customer">customer.</param>
        /// <param name="amount">amount.</param>
        /// <param name="defaultPaymentMethod">default_payment_method.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        public GetCheckoutPaymentSettingsResponse(
            string successUrl,
            string paymentUrl,
            List<string> acceptedPaymentMethods,
            string status,
            Models.GetCustomerResponse customer = null,
            int? amount = null,
            string defaultPaymentMethod = null,
            string gatewayAffiliationId = null)
        {
            this.SuccessUrl = successUrl;
            this.PaymentUrl = paymentUrl;
            this.AcceptedPaymentMethods = acceptedPaymentMethods;
            this.Status = status;
            this.Customer = customer;
            this.Amount = amount;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.GatewayAffiliationId = gatewayAffiliationId;
        }

        /// <summary>
        /// Success Url
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Payment Url
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// Accepted Payment Methods
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCustomerResponse Customer { get; set; }

        /// <summary>
        /// Payment amount
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Default Payment Method
        /// </summary>
        [JsonProperty("default_payment_method", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Gateway Affiliation Id
        /// </summary>
        [JsonProperty("gateway_affiliation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayAffiliationId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutPaymentSettingsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutPaymentSettingsResponse other &&
                ((this.SuccessUrl == null && other.SuccessUrl == null) || (this.SuccessUrl?.Equals(other.SuccessUrl) == true)) &&
                ((this.PaymentUrl == null && other.PaymentUrl == null) || (this.PaymentUrl?.Equals(other.PaymentUrl) == true)) &&
                ((this.AcceptedPaymentMethods == null && other.AcceptedPaymentMethods == null) || (this.AcceptedPaymentMethods?.Equals(other.AcceptedPaymentMethods) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.DefaultPaymentMethod == null && other.DefaultPaymentMethod == null) || (this.DefaultPaymentMethod?.Equals(other.DefaultPaymentMethod) == true)) &&
                ((this.GatewayAffiliationId == null && other.GatewayAffiliationId == null) || (this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SuccessUrl = {(this.SuccessUrl == null ? "null" : this.SuccessUrl == string.Empty ? "" : this.SuccessUrl)}");
            toStringOutput.Add($"this.PaymentUrl = {(this.PaymentUrl == null ? "null" : this.PaymentUrl == string.Empty ? "" : this.PaymentUrl)}");
            toStringOutput.Add($"this.AcceptedPaymentMethods = {(this.AcceptedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AcceptedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.DefaultPaymentMethod = {(this.DefaultPaymentMethod == null ? "null" : this.DefaultPaymentMethod == string.Empty ? "" : this.DefaultPaymentMethod)}");
            toStringOutput.Add($"this.GatewayAffiliationId = {(this.GatewayAffiliationId == null ? "null" : this.GatewayAffiliationId == string.Empty ? "" : this.GatewayAffiliationId)}");
        }
    }
}