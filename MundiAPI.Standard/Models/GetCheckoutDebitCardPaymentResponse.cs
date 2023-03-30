// <copyright file="GetCheckoutDebitCardPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutDebitCardPaymentResponse.
    /// </summary>
    public class GetCheckoutDebitCardPaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutDebitCardPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutDebitCardPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutDebitCardPaymentResponse"/> class.
        /// </summary>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="authentication">authentication.</param>
        public GetCheckoutDebitCardPaymentResponse(
            string statementDescriptor,
            Models.GetPaymentAuthenticationResponse authentication)
        {
            this.StatementDescriptor = statementDescriptor;
            this.Authentication = authentication;
        }

        /// <summary>
        /// Descrição na fatura
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Payment Authentication response object data
        /// </summary>
        [JsonProperty("authentication")]
        public Models.GetPaymentAuthenticationResponse Authentication { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutDebitCardPaymentResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutDebitCardPaymentResponse other &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Authentication == null && other.Authentication == null) || (this.Authentication?.Equals(other.Authentication) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
        }
    }
}