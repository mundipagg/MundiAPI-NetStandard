// <copyright file="GetCashTransactionResponse.cs" company="APIMatic">
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
    /// GetCashTransactionResponse.
    /// </summary>
    public class GetCashTransactionResponse : GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCashTransactionResponse"/> class.
        /// </summary>
        public GetCashTransactionResponse()
        {
            this.TransactionType = "cash";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCashTransactionResponse"/> class.
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
        /// <param name="description">description.</param>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public GetCashTransactionResponse(
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
            string description,
            string transactionType = "cash",
            DateTime? nextAttempt = null,
            Dictionary<string, string> metadata = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null)
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
            this.Description = description;
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCashTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCashTransactionResponse other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");

            base.ToString(toStringOutput);
        }
    }
}