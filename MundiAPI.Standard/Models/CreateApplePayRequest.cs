// <copyright file="CreateApplePayRequest.cs" company="APIMatic">
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
    /// CreateApplePayRequest.
    /// </summary>
    public class CreateApplePayRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplePayRequest"/> class.
        /// </summary>
        public CreateApplePayRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplePayRequest"/> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="data">data.</param>
        /// <param name="header">header.</param>
        /// <param name="signature">signature.</param>
        /// <param name="merchantIdentifier">merchant_identifier.</param>
        public CreateApplePayRequest(
            string version,
            string data,
            Models.CreateApplePayHeaderRequest header,
            string signature,
            string merchantIdentifier)
        {
            this.Version = version;
            this.Data = data;
            this.Header = header;
            this.Signature = signature;
            this.MerchantIdentifier = merchantIdentifier;
        }

        /// <summary>
        /// The token version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// The cryptography data
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The ApplePay header request
        /// </summary>
        [JsonProperty("header")]
        public Models.CreateApplePayHeaderRequest Header { get; set; }

        /// <summary>
        /// Detached PKCS #7 signature, Base64 encoded as string
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// ApplePay Merchant identifier
        /// </summary>
        [JsonProperty("merchant_identifier")]
        public string MerchantIdentifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateApplePayRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateApplePayRequest other &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Header == null && other.Header == null) || (this.Header?.Equals(other.Header) == true)) &&
                ((this.Signature == null && other.Signature == null) || (this.Signature?.Equals(other.Signature) == true)) &&
                ((this.MerchantIdentifier == null && other.MerchantIdentifier == null) || (this.MerchantIdentifier?.Equals(other.MerchantIdentifier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data == string.Empty ? "" : this.Data)}");
            toStringOutput.Add($"this.Header = {(this.Header == null ? "null" : this.Header.ToString())}");
            toStringOutput.Add($"this.Signature = {(this.Signature == null ? "null" : this.Signature == string.Empty ? "" : this.Signature)}");
            toStringOutput.Add($"this.MerchantIdentifier = {(this.MerchantIdentifier == null ? "null" : this.MerchantIdentifier == string.Empty ? "" : this.MerchantIdentifier)}");
        }
    }
}