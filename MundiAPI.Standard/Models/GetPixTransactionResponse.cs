// <copyright file="GetPixTransactionResponse.cs" company="APIMatic">
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
    /// GetPixTransactionResponse.
    /// </summary>
    public class GetPixTransactionResponse : GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixTransactionResponse"/> class.
        /// </summary>
        public GetPixTransactionResponse()
        {
            this.TransactionType = "pix";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixTransactionResponse"/> class.
        /// </summary>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="success">success.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="attemptCount">attempt_count.</param>
        /// <param name="maxAttempts">max_attempts.</param>
        /// <param name="splits">splits.</param>
        /// <param name="id">id.</param>
        /// <param name="gatewayResponse">gateway_response.</param>
        /// <param name="antifraudResponse">antifraud_response.</param>
        /// <param name="split">split.</param>
        /// <param name="qrCode">qr_code.</param>
        /// <param name="qrCodeUrl">qr_code_url.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="additionalInformation">additional_information.</param>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        /// <param name="payer">payer.</param>
        public GetPixTransactionResponse(
            string gatewayId,
            int amount,
            string status,
            bool success,
            DateTime createdAt,
            DateTime updatedAt,
            int attemptCount,
            int maxAttempts,
            List<Models.GetSplitResponse> splits,
            string id,
            Models.GetGatewayResponseResponse gatewayResponse,
            Models.GetAntifraudResponse antifraudResponse,
            List<Models.GetSplitResponse> split,
            string qrCode,
            string qrCodeUrl,
            DateTime expiresAt,
            List<Models.PixAdditionalInformation> additionalInformation,
            string transactionType = "pix",
            DateTime? nextAttempt = null,
            Dictionary<string, string> metadata = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null,
            Models.GetPixPayerResponse payer = null)
            : base(
                gatewayId,
                amount,
                status,
                success,
                createdAt,
                updatedAt,
                attemptCount,
                maxAttempts,
                splits,
                id,
                gatewayResponse,
                antifraudResponse,
                split,
                transactionType,
                nextAttempt,
                metadata,
                interest,
                fine,
                maxDaysToPayPastDue)
        {
            this.QrCode = qrCode;
            this.QrCodeUrl = qrCodeUrl;
            this.ExpiresAt = expiresAt;
            this.AdditionalInformation = additionalInformation;
            this.Payer = payer;
        }

        /// <summary>
        /// Gets or sets QrCode.
        /// </summary>
        [JsonProperty("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// Gets or sets QrCodeUrl.
        /// </summary>
        [JsonProperty("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets AdditionalInformation.
        /// </summary>
        [JsonProperty("additional_information")]
        public List<Models.PixAdditionalInformation> AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer", NullValueHandling = NullValueHandling.Include)]
        public Models.GetPixPayerResponse Payer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPixTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPixTransactionResponse other &&
                ((this.QrCode == null && other.QrCode == null) || (this.QrCode?.Equals(other.QrCode) == true)) &&
                ((this.QrCodeUrl == null && other.QrCodeUrl == null) || (this.QrCodeUrl?.Equals(other.QrCodeUrl) == true)) &&
                this.ExpiresAt.Equals(other.ExpiresAt) &&
                ((this.AdditionalInformation == null && other.AdditionalInformation == null) || (this.AdditionalInformation?.Equals(other.AdditionalInformation) == true)) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QrCode = {(this.QrCode == null ? "null" : this.QrCode == string.Empty ? "" : this.QrCode)}");
            toStringOutput.Add($"this.QrCodeUrl = {(this.QrCodeUrl == null ? "null" : this.QrCodeUrl == string.Empty ? "" : this.QrCodeUrl)}");
            toStringOutput.Add($"this.ExpiresAt = {this.ExpiresAt}");
            toStringOutput.Add($"this.AdditionalInformation = {(this.AdditionalInformation == null ? "null" : $"[{string.Join(", ", this.AdditionalInformation)} ]")}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}