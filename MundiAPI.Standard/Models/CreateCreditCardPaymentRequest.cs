// <copyright file="CreateCreditCardPaymentRequest.cs" company="APIMatic">
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
    /// CreateCreditCardPaymentRequest.
    /// </summary>
    public class CreateCreditCardPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardPaymentRequest"/> class.
        /// </summary>
        public CreateCreditCardPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardPaymentRequest"/> class.
        /// </summary>
        /// <param name="installments">installments.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="card">card.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="cardToken">card_token.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="capture">capture.</param>
        /// <param name="extendedLimitEnabled">extended_limit_enabled.</param>
        /// <param name="extendedLimitCode">extended_limit_code.</param>
        /// <param name="merchantCategoryCode">merchant_category_code.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="contactless">contactless.</param>
        /// <param name="autoRecovery">auto_recovery.</param>
        /// <param name="operationType">operation_type.</param>
        /// <param name="recurrencyCycle">recurrency_cycle.</param>
        public CreateCreditCardPaymentRequest(
            int? installments = 1,
            string statementDescriptor = null,
            Models.CreateCardRequest card = null,
            string cardId = null,
            string cardToken = null,
            bool? recurrence = null,
            bool? capture = true,
            bool? extendedLimitEnabled = null,
            string extendedLimitCode = null,
            long? merchantCategoryCode = null,
            Models.CreatePaymentAuthenticationRequest authentication = null,
            Models.CreateCardPaymentContactlessRequest contactless = null,
            bool? autoRecovery = null,
            string operationType = null,
            string recurrencyCycle = null)
        {
            this.Installments = installments;
            this.StatementDescriptor = statementDescriptor;
            this.Card = card;
            this.CardId = cardId;
            this.CardToken = cardToken;
            this.Recurrence = recurrence;
            this.Capture = capture;
            this.ExtendedLimitEnabled = extendedLimitEnabled;
            this.ExtendedLimitCode = extendedLimitCode;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.Authentication = authentication;
            this.Contactless = contactless;
            this.AutoRecovery = autoRecovery;
            this.OperationType = operationType;
            this.RecurrencyCycle = recurrencyCycle;
        }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public int? Installments { get; set; }

        /// <summary>
        /// The text that will be shown on the credit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Credit card data
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// The credit card id
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// Gets or sets CardToken.
        /// </summary>
        [JsonProperty("card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CardToken { get; set; }

        /// <summary>
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurrence { get; set; }

        /// <summary>
        /// Indicates if the operation should be only authorization or auth and capture.
        /// </summary>
        [JsonProperty("capture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Capture { get; set; }

        /// <summary>
        /// Indicates whether the extended label (private label) is enabled
        /// </summary>
        [JsonProperty("extended_limit_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExtendedLimitEnabled { get; set; }

        /// <summary>
        /// Extended Limit Code
        /// </summary>
        [JsonProperty("extended_limit_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendedLimitCode { get; set; }

        /// <summary>
        /// Customer business segment code
        /// </summary>
        [JsonProperty("merchant_category_code", NullValueHandling = NullValueHandling.Ignore)]
        public long? MerchantCategoryCode { get; set; }

        /// <summary>
        /// The payment authentication request
        /// </summary>
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePaymentAuthenticationRequest Authentication { get; set; }

        /// <summary>
        /// The Credit card payment contactless request
        /// </summary>
        [JsonProperty("contactless", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardPaymentContactlessRequest Contactless { get; set; }

        /// <summary>
        /// Indicates whether a particular payment will enter the offline retry flow
        /// </summary>
        [JsonProperty("auto_recovery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRecovery { get; set; }

        /// <summary>
        /// AuthOnly, AuthAndCapture, PreAuth
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

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

            return $"CreateCreditCardPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCreditCardPaymentRequest other &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardToken == null && other.CardToken == null) || (this.CardToken?.Equals(other.CardToken) == true)) &&
                ((this.Recurrence == null && other.Recurrence == null) || (this.Recurrence?.Equals(other.Recurrence) == true)) &&
                ((this.Capture == null && other.Capture == null) || (this.Capture?.Equals(other.Capture) == true)) &&
                ((this.ExtendedLimitEnabled == null && other.ExtendedLimitEnabled == null) || (this.ExtendedLimitEnabled?.Equals(other.ExtendedLimitEnabled) == true)) &&
                ((this.ExtendedLimitCode == null && other.ExtendedLimitCode == null) || (this.ExtendedLimitCode?.Equals(other.ExtendedLimitCode) == true)) &&
                ((this.MerchantCategoryCode == null && other.MerchantCategoryCode == null) || (this.MerchantCategoryCode?.Equals(other.MerchantCategoryCode) == true)) &&
                ((this.Authentication == null && other.Authentication == null) || (this.Authentication?.Equals(other.Authentication) == true)) &&
                ((this.Contactless == null && other.Contactless == null) || (this.Contactless?.Equals(other.Contactless) == true)) &&
                ((this.AutoRecovery == null && other.AutoRecovery == null) || (this.AutoRecovery?.Equals(other.AutoRecovery) == true)) &&
                ((this.OperationType == null && other.OperationType == null) || (this.OperationType?.Equals(other.OperationType) == true)) &&
                ((this.RecurrencyCycle == null && other.RecurrencyCycle == null) || (this.RecurrencyCycle?.Equals(other.RecurrencyCycle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId == string.Empty ? "" : this.CardId)}");
            toStringOutput.Add($"this.CardToken = {(this.CardToken == null ? "null" : this.CardToken == string.Empty ? "" : this.CardToken)}");
            toStringOutput.Add($"this.Recurrence = {(this.Recurrence == null ? "null" : this.Recurrence.ToString())}");
            toStringOutput.Add($"this.Capture = {(this.Capture == null ? "null" : this.Capture.ToString())}");
            toStringOutput.Add($"this.ExtendedLimitEnabled = {(this.ExtendedLimitEnabled == null ? "null" : this.ExtendedLimitEnabled.ToString())}");
            toStringOutput.Add($"this.ExtendedLimitCode = {(this.ExtendedLimitCode == null ? "null" : this.ExtendedLimitCode == string.Empty ? "" : this.ExtendedLimitCode)}");
            toStringOutput.Add($"this.MerchantCategoryCode = {(this.MerchantCategoryCode == null ? "null" : this.MerchantCategoryCode.ToString())}");
            toStringOutput.Add($"this.Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
            toStringOutput.Add($"this.Contactless = {(this.Contactless == null ? "null" : this.Contactless.ToString())}");
            toStringOutput.Add($"this.AutoRecovery = {(this.AutoRecovery == null ? "null" : this.AutoRecovery.ToString())}");
            toStringOutput.Add($"this.OperationType = {(this.OperationType == null ? "null" : this.OperationType == string.Empty ? "" : this.OperationType)}");
            toStringOutput.Add($"this.RecurrencyCycle = {(this.RecurrencyCycle == null ? "null" : this.RecurrencyCycle == string.Empty ? "" : this.RecurrencyCycle)}");
        }
    }
}