// <copyright file="CreateDebitCardPaymentRequest.cs" company="APIMatic">
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
    /// CreateDebitCardPaymentRequest.
    /// </summary>
    public class CreateDebitCardPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDebitCardPaymentRequest"/> class.
        /// </summary>
        public CreateDebitCardPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDebitCardPaymentRequest"/> class.
        /// </summary>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="card">card.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="cardToken">card_token.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="token">token.</param>
        /// <param name="recurrencyCycle">recurrency_cycle.</param>
        public CreateDebitCardPaymentRequest(
            string statementDescriptor = null,
            Models.CreateCardRequest card = null,
            string cardId = null,
            string cardToken = null,
            bool? recurrence = null,
            Models.CreatePaymentAuthenticationRequest authentication = null,
            Models.CreateCardPaymentContactlessRequest token = null,
            string recurrencyCycle = null)
        {
            this.StatementDescriptor = statementDescriptor;
            this.Card = card;
            this.CardId = cardId;
            this.CardToken = cardToken;
            this.Recurrence = recurrence;
            this.Authentication = authentication;
            this.Token = token;
            this.RecurrencyCycle = recurrencyCycle;
        }

        /// <summary>
        /// The text that will be shown on the debit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Debit card data
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// The debit card id
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// The debit card token
        /// </summary>
        [JsonProperty("card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CardToken { get; set; }

        /// <summary>
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurrence { get; set; }

        /// <summary>
        /// The payment authentication request
        /// </summary>
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePaymentAuthenticationRequest Authentication { get; set; }

        /// <summary>
        /// The Debit card payment token request
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardPaymentContactlessRequest Token { get; set; }

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

            return $"CreateDebitCardPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateDebitCardPaymentRequest other &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardToken == null && other.CardToken == null) || (this.CardToken?.Equals(other.CardToken) == true)) &&
                ((this.Recurrence == null && other.Recurrence == null) || (this.Recurrence?.Equals(other.Recurrence) == true)) &&
                ((this.Authentication == null && other.Authentication == null) || (this.Authentication?.Equals(other.Authentication) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.RecurrencyCycle == null && other.RecurrencyCycle == null) || (this.RecurrencyCycle?.Equals(other.RecurrencyCycle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId == string.Empty ? "" : this.CardId)}");
            toStringOutput.Add($"this.CardToken = {(this.CardToken == null ? "null" : this.CardToken == string.Empty ? "" : this.CardToken)}");
            toStringOutput.Add($"this.Recurrence = {(this.Recurrence == null ? "null" : this.Recurrence.ToString())}");
            toStringOutput.Add($"this.Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token.ToString())}");
            toStringOutput.Add($"this.RecurrencyCycle = {(this.RecurrencyCycle == null ? "null" : this.RecurrencyCycle == string.Empty ? "" : this.RecurrencyCycle)}");
        }
    }
}