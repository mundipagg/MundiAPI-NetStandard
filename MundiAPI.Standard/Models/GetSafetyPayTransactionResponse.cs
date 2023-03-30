// <copyright file="GetSafetyPayTransactionResponse.cs" company="APIMatic">
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
    /// GetSafetyPayTransactionResponse.
    /// </summary>
    public class GetSafetyPayTransactionResponse : GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSafetyPayTransactionResponse"/> class.
        /// </summary>
        public GetSafetyPayTransactionResponse()
        {
            this.TransactionType = "safetypay";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSafetyPayTransactionResponse"/> class.
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
        /// <param name="url">url.</param>
        /// <param name="bankTid">bank_tid.</param>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        /// <param name="paidAt">paid_at.</param>
        /// <param name="paidAmount">paid_amount.</param>
        public GetSafetyPayTransactionResponse(
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
            string url,
            string bankTid,
            string transactionType = "safetypay",
            DateTime? nextAttempt = null,
            Dictionary<string, string> metadata = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null,
            DateTime? paidAt = null,
            int? paidAmount = null)
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
            this.Url = url;
            this.BankTid = bankTid;
            this.PaidAt = paidAt;
            this.PaidAmount = paidAmount;
        }

        /// <summary>
        /// Payment url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Transaction identifier on bank
        /// </summary>
        [JsonProperty("bank_tid")]
        public string BankTid { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// Paid amount
        /// </summary>
        [JsonProperty("paid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaidAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSafetyPayTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSafetyPayTransactionResponse other &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.BankTid == null && other.BankTid == null) || (this.BankTid?.Equals(other.BankTid) == true)) &&
                ((this.PaidAt == null && other.PaidAt == null) || (this.PaidAt?.Equals(other.PaidAt) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.BankTid = {(this.BankTid == null ? "null" : this.BankTid == string.Empty ? "" : this.BankTid)}");
            toStringOutput.Add($"this.PaidAt = {(this.PaidAt == null ? "null" : this.PaidAt.ToString())}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}