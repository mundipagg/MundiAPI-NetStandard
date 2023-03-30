// <copyright file="GetTransactionResponse.cs" company="APIMatic">
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
    /// GetTransactionResponse.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "transaction_type")]
    [JsonSubtypes.KnownSubType(typeof(GetBankTransferTransactionResponse), "bank_transfer")]
    [JsonSubtypes.KnownSubType(typeof(GetDebitCardTransactionResponse), "debit_card")]
    [JsonSubtypes.KnownSubType(typeof(GetVoucherTransactionResponse), "voucher")]
    [JsonSubtypes.KnownSubType(typeof(GetBoletoTransactionResponse), "boleto")]
    [JsonSubtypes.KnownSubType(typeof(GetCashTransactionResponse), "cash")]
    [JsonSubtypes.KnownSubType(typeof(GetSafetyPayTransactionResponse), "safetypay")]
    [JsonSubtypes.KnownSubType(typeof(GetCreditCardTransactionResponse), "credit_card")]
    [JsonSubtypes.KnownSubType(typeof(GetPrivateLabelTransactionResponse), "private_label")]
    [JsonSubtypes.KnownSubType(typeof(GetPixTransactionResponse), "pix")]
    public class GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponse"/> class.
        /// </summary>
        public GetTransactionResponse()
        {
            this.TransactionType = "transaction";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponse"/> class.
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
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public GetTransactionResponse(
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
            string transactionType = "transaction",
            DateTime? nextAttempt = null,
            Dictionary<string, string> metadata = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null)
        {
            this.GatewayId = gatewayId;
            this.Amount = amount;
            this.Status = status;
            this.Success = success;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AttemptCount = attemptCount;
            this.MaxAttempts = maxAttempts;
            this.Splits = splits;
            this.NextAttempt = nextAttempt;
            this.TransactionType = transactionType;
            this.Id = id;
            this.GatewayResponse = gatewayResponse;
            this.AntifraudResponse = antifraudResponse;
            this.Metadata = metadata;
            this.Split = split;
            this.Interest = interest;
            this.Fine = fine;
            this.MaxDaysToPayPastDue = maxDaysToPayPastDue;
        }

        /// <summary>
        /// Gateway transaction id
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Amount in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Transaction status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Indicates if the transaction ocurred successfuly
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Number of attempts tried
        /// </summary>
        [JsonProperty("attempt_count")]
        public int AttemptCount { get; set; }

        /// <summary>
        /// Max attempts
        /// </summary>
        [JsonProperty("max_attempts")]
        public int MaxAttempts { get; set; }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("splits")]
        public List<Models.GetSplitResponse> Splits { get; set; }

        /// <summary>
        /// Date and time of the next attempt
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_attempt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NextAttempt { get; set; }

        /// <summary>
        /// Gets or sets TransactionType.
        /// </summary>
        [JsonProperty("transaction_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Código da transação
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The Gateway Response
        /// </summary>
        [JsonProperty("gateway_response")]
        public Models.GetGatewayResponseResponse GatewayResponse { get; set; }

        /// <summary>
        /// Gets or sets AntifraudResponse.
        /// </summary>
        [JsonProperty("antifraud_response")]
        public Models.GetAntifraudResponse AntifraudResponse { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Split.
        /// </summary>
        [JsonProperty("split")]
        public List<Models.GetSplitResponse> Split { get; set; }

        /// <summary>
        /// Gets or sets Interest.
        /// </summary>
        [JsonProperty("interest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetInterestResponse Interest { get; set; }

        /// <summary>
        /// Gets or sets Fine.
        /// </summary>
        [JsonProperty("fine", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetFineResponse Fine { get; set; }

        /// <summary>
        /// Gets or sets MaxDaysToPayPastDue.
        /// </summary>
        [JsonProperty("max_days_to_pay_past_due", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxDaysToPayPastDue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetTransactionResponse other &&
                ((this.GatewayId == null && other.GatewayId == null) || (this.GatewayId?.Equals(other.GatewayId) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.Success.Equals(other.Success) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                this.AttemptCount.Equals(other.AttemptCount) &&
                this.MaxAttempts.Equals(other.MaxAttempts) &&
                ((this.Splits == null && other.Splits == null) || (this.Splits?.Equals(other.Splits) == true)) &&
                ((this.NextAttempt == null && other.NextAttempt == null) || (this.NextAttempt?.Equals(other.NextAttempt) == true)) &&
                ((this.TransactionType == null && other.TransactionType == null) || (this.TransactionType?.Equals(other.TransactionType) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.GatewayResponse == null && other.GatewayResponse == null) || (this.GatewayResponse?.Equals(other.GatewayResponse) == true)) &&
                ((this.AntifraudResponse == null && other.AntifraudResponse == null) || (this.AntifraudResponse?.Equals(other.AntifraudResponse) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Split == null && other.Split == null) || (this.Split?.Equals(other.Split) == true)) &&
                ((this.Interest == null && other.Interest == null) || (this.Interest?.Equals(other.Interest) == true)) &&
                ((this.Fine == null && other.Fine == null) || (this.Fine?.Equals(other.Fine) == true)) &&
                ((this.MaxDaysToPayPastDue == null && other.MaxDaysToPayPastDue == null) || (this.MaxDaysToPayPastDue?.Equals(other.MaxDaysToPayPastDue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GatewayId = {(this.GatewayId == null ? "null" : this.GatewayId == string.Empty ? "" : this.GatewayId)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.AttemptCount = {this.AttemptCount}");
            toStringOutput.Add($"this.MaxAttempts = {this.MaxAttempts}");
            toStringOutput.Add($"this.Splits = {(this.Splits == null ? "null" : $"[{string.Join(", ", this.Splits)} ]")}");
            toStringOutput.Add($"this.NextAttempt = {(this.NextAttempt == null ? "null" : this.NextAttempt.ToString())}");
            toStringOutput.Add($"this.TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType == string.Empty ? "" : this.TransactionType)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.GatewayResponse = {(this.GatewayResponse == null ? "null" : this.GatewayResponse.ToString())}");
            toStringOutput.Add($"this.AntifraudResponse = {(this.AntifraudResponse == null ? "null" : this.AntifraudResponse.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Split = {(this.Split == null ? "null" : $"[{string.Join(", ", this.Split)} ]")}");
            toStringOutput.Add($"this.Interest = {(this.Interest == null ? "null" : this.Interest.ToString())}");
            toStringOutput.Add($"this.Fine = {(this.Fine == null ? "null" : this.Fine.ToString())}");
            toStringOutput.Add($"this.MaxDaysToPayPastDue = {(this.MaxDaysToPayPastDue == null ? "null" : this.MaxDaysToPayPastDue.ToString())}");
        }
    }
}