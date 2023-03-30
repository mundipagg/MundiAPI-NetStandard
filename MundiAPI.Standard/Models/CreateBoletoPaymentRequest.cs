// <copyright file="CreateBoletoPaymentRequest.cs" company="APIMatic">
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
    /// CreateBoletoPaymentRequest.
    /// </summary>
    public class CreateBoletoPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBoletoPaymentRequest"/> class.
        /// </summary>
        public CreateBoletoPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBoletoPaymentRequest"/> class.
        /// </summary>
        /// <param name="retries">retries.</param>
        /// <param name="bank">bank.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="billingAddressId">billing_address_id.</param>
        /// <param name="documentNumber">document_number.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="nossoNumero">nosso_numero.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public CreateBoletoPaymentRequest(
            int retries,
            string bank,
            string instructions,
            Models.CreateAddressRequest billingAddress,
            string billingAddressId,
            string documentNumber,
            DateTime? dueAt = null,
            string nossoNumero = null,
            Models.CreateInterestRequest interest = null,
            Models.CreateFineRequest fine = null,
            int? maxDaysToPayPastDue = null)
        {
            this.Retries = retries;
            this.Bank = bank;
            this.Instructions = instructions;
            this.DueAt = dueAt;
            this.BillingAddress = billingAddress;
            this.BillingAddressId = billingAddressId;
            this.NossoNumero = nossoNumero;
            this.DocumentNumber = documentNumber;
            this.Interest = interest;
            this.Fine = fine;
            this.MaxDaysToPayPastDue = maxDaysToPayPastDue;
        }

        /// <summary>
        /// Number of retries
        /// </summary>
        [JsonProperty("retries")]
        public int Retries { get; set; }

        /// <summary>
        /// The bank code, containing three characters. The available codes are on the API specification
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// The instructions field that will be printed on the boleto.
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// Boleto due date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueAt { get; set; }

        /// <summary>
        /// Card's billing address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress { get; set; }

        /// <summary>
        /// The address id for the billing address
        /// </summary>
        [JsonProperty("billing_address_id")]
        public string BillingAddressId { get; set; }

        /// <summary>
        /// Customer identification number with the bank
        /// </summary>
        [JsonProperty("nosso_numero", NullValueHandling = NullValueHandling.Ignore)]
        public string NossoNumero { get; set; }

        /// <summary>
        /// Boleto identification
        /// </summary>
        [JsonProperty("document_number")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets Interest.
        /// </summary>
        [JsonProperty("interest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInterestRequest Interest { get; set; }

        /// <summary>
        /// Gets or sets Fine.
        /// </summary>
        [JsonProperty("fine", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateFineRequest Fine { get; set; }

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

            return $"CreateBoletoPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateBoletoPaymentRequest other &&
                this.Retries.Equals(other.Retries) &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true)) &&
                ((this.DueAt == null && other.DueAt == null) || (this.DueAt?.Equals(other.DueAt) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BillingAddressId == null && other.BillingAddressId == null) || (this.BillingAddressId?.Equals(other.BillingAddressId) == true)) &&
                ((this.NossoNumero == null && other.NossoNumero == null) || (this.NossoNumero?.Equals(other.NossoNumero) == true)) &&
                ((this.DocumentNumber == null && other.DocumentNumber == null) || (this.DocumentNumber?.Equals(other.DocumentNumber) == true)) &&
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
            toStringOutput.Add($"this.Retries = {this.Retries}");
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank == string.Empty ? "" : this.Bank)}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions == string.Empty ? "" : this.Instructions)}");
            toStringOutput.Add($"this.DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.BillingAddressId = {(this.BillingAddressId == null ? "null" : this.BillingAddressId == string.Empty ? "" : this.BillingAddressId)}");
            toStringOutput.Add($"this.NossoNumero = {(this.NossoNumero == null ? "null" : this.NossoNumero == string.Empty ? "" : this.NossoNumero)}");
            toStringOutput.Add($"this.DocumentNumber = {(this.DocumentNumber == null ? "null" : this.DocumentNumber == string.Empty ? "" : this.DocumentNumber)}");
            toStringOutput.Add($"this.Interest = {(this.Interest == null ? "null" : this.Interest.ToString())}");
            toStringOutput.Add($"this.Fine = {(this.Fine == null ? "null" : this.Fine.ToString())}");
            toStringOutput.Add($"this.MaxDaysToPayPastDue = {(this.MaxDaysToPayPastDue == null ? "null" : this.MaxDaysToPayPastDue.ToString())}");
        }
    }
}