// <copyright file="GetCheckoutCreditCardPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutCreditCardPaymentResponse.
    /// </summary>
    public class GetCheckoutCreditCardPaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCreditCardPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutCreditCardPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCreditCardPaymentResponse"/> class.
        /// </summary>
        /// <param name="statementDescriptor">statementDescriptor.</param>
        /// <param name="installments">installments.</param>
        /// <param name="authentication">authentication.</param>
        public GetCheckoutCreditCardPaymentResponse(
            string statementDescriptor,
            List<Models.GetCheckoutCardInstallmentOptionsResponse> installments,
            Models.GetPaymentAuthenticationResponse authentication)
        {
            this.StatementDescriptor = statementDescriptor;
            this.Installments = installments;
            this.Authentication = authentication;
        }

        /// <summary>
        /// Descrição na fatura
        /// </summary>
        [JsonProperty("statementDescriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Parcelas
        /// </summary>
        [JsonProperty("installments")]
        public List<Models.GetCheckoutCardInstallmentOptionsResponse> Installments { get; set; }

        /// <summary>
        /// Payment Authentication response
        /// </summary>
        [JsonProperty("authentication")]
        public Models.GetPaymentAuthenticationResponse Authentication { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutCreditCardPaymentResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutCreditCardPaymentResponse other &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.Authentication == null && other.Authentication == null) || (this.Authentication?.Equals(other.Authentication) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : $"[{string.Join(", ", this.Installments)} ]")}");
            toStringOutput.Add($"this.Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
        }
    }
}