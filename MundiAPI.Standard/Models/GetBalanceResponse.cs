// <copyright file="GetBalanceResponse.cs" company="APIMatic">
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
    /// GetBalanceResponse.
    /// </summary>
    public class GetBalanceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceResponse"/> class.
        /// </summary>
        public GetBalanceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceResponse"/> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="availableAmount">available_amount.</param>
        /// <param name="waitingFundsAmount">waiting_funds_amount.</param>
        /// <param name="transferredAmount">transferred_amount.</param>
        /// <param name="recipient">recipient.</param>
        public GetBalanceResponse(
            string currency,
            long availableAmount,
            long waitingFundsAmount,
            long transferredAmount,
            Models.GetRecipientResponse recipient = null)
        {
            this.Currency = currency;
            this.AvailableAmount = availableAmount;
            this.Recipient = recipient;
            this.WaitingFundsAmount = waitingFundsAmount;
            this.TransferredAmount = transferredAmount;
        }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Amount available for transferring
        /// </summary>
        [JsonProperty("available_amount")]
        public long AvailableAmount { get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetRecipientResponse Recipient { get; set; }

        /// <summary>
        /// Gets or sets WaitingFundsAmount.
        /// </summary>
        [JsonProperty("waiting_funds_amount")]
        public long WaitingFundsAmount { get; set; }

        /// <summary>
        /// Gets or sets TransferredAmount.
        /// </summary>
        [JsonProperty("transferred_amount")]
        public long TransferredAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetBalanceResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetBalanceResponse other &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                this.AvailableAmount.Equals(other.AvailableAmount) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                this.WaitingFundsAmount.Equals(other.WaitingFundsAmount) &&
                this.TransferredAmount.Equals(other.TransferredAmount);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.AvailableAmount = {this.AvailableAmount}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"this.WaitingFundsAmount = {this.WaitingFundsAmount}");
            toStringOutput.Add($"this.TransferredAmount = {this.TransferredAmount}");
        }
    }
}