// <copyright file="CreateCardPaymentContactlessRequest.cs" company="APIMatic">
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
    /// CreateCardPaymentContactlessRequest.
    /// </summary>
    public class CreateCardPaymentContactlessRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardPaymentContactlessRequest"/> class.
        /// </summary>
        public CreateCardPaymentContactlessRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardPaymentContactlessRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="applePay">apple_pay.</param>
        /// <param name="googlePay">google_pay.</param>
        /// <param name="emv">emv.</param>
        public CreateCardPaymentContactlessRequest(
            string type,
            Models.CreateApplePayRequest applePay = null,
            Models.CreateGooglePayRequest googlePay = null,
            Models.CreateEmvDecryptRequest emv = null)
        {
            this.Type = type;
            this.ApplePay = applePay;
            this.GooglePay = googlePay;
            this.Emv = emv;
        }

        /// <summary>
        /// The authentication type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ApplePay encrypted request
        /// </summary>
        [JsonProperty("apple_pay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateApplePayRequest ApplePay { get; set; }

        /// <summary>
        /// The GooglePay encrypted request
        /// </summary>
        [JsonProperty("google_pay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateGooglePayRequest GooglePay { get; set; }

        /// <summary>
        /// The Emv encrypted request
        /// </summary>
        [JsonProperty("emv", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateEmvDecryptRequest Emv { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCardPaymentContactlessRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCardPaymentContactlessRequest other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.ApplePay == null && other.ApplePay == null) || (this.ApplePay?.Equals(other.ApplePay) == true)) &&
                ((this.GooglePay == null && other.GooglePay == null) || (this.GooglePay?.Equals(other.GooglePay) == true)) &&
                ((this.Emv == null && other.Emv == null) || (this.Emv?.Equals(other.Emv) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.ApplePay = {(this.ApplePay == null ? "null" : this.ApplePay.ToString())}");
            toStringOutput.Add($"this.GooglePay = {(this.GooglePay == null ? "null" : this.GooglePay.ToString())}");
            toStringOutput.Add($"this.Emv = {(this.Emv == null ? "null" : this.Emv.ToString())}");
        }
    }
}