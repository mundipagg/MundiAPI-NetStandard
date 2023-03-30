// <copyright file="CreateVoucherPaymentRequest.cs" company="APIMatic">
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
    /// CreateVoucherPaymentRequest.
    /// </summary>
    public class CreateVoucherPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoucherPaymentRequest"/> class.
        /// </summary>
        public CreateVoucherPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoucherPaymentRequest"/> class.
        /// </summary>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="cardToken">card_token.</param>
        /// <param name="card">Card.</param>
        /// <param name="recurrencyCycle">recurrency_cycle.</param>
        public CreateVoucherPaymentRequest(
            string statementDescriptor = null,
            string cardId = null,
            string cardToken = null,
            Models.CreateCardRequest card = null,
            string recurrencyCycle = null)
        {
            this.StatementDescriptor = statementDescriptor;
            this.CardId = cardId;
            this.CardToken = cardToken;
            this.Card = card;
            this.RecurrencyCycle = recurrencyCycle;
        }

        /// <summary>
        /// The text that will be shown on the voucher's statement
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Card id
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// Card token
        /// </summary>
        [JsonProperty("card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CardToken { get; set; }

        /// <summary>
        /// Card info
        /// </summary>
        [JsonProperty("Card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// Defines whether the card has been used one or more times.
        /// </summary>
        [JsonProperty("recurrency_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurrencyCycle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateVoucherPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateVoucherPaymentRequest other &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardToken == null && other.CardToken == null) || (this.CardToken?.Equals(other.CardToken) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.RecurrencyCycle == null && other.RecurrencyCycle == null) || (this.RecurrencyCycle?.Equals(other.RecurrencyCycle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId == string.Empty ? "" : this.CardId)}");
            toStringOutput.Add($"this.CardToken = {(this.CardToken == null ? "null" : this.CardToken == string.Empty ? "" : this.CardToken)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.RecurrencyCycle = {(this.RecurrencyCycle == null ? "null" : this.RecurrencyCycle == string.Empty ? "" : this.RecurrencyCycle)}");
        }
    }
}