// <copyright file="CreateCheckoutDebitCardPaymentRequest.cs" company="APIMatic">
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
    /// CreateCheckoutDebitCardPaymentRequest.
    /// </summary>
    public class CreateCheckoutDebitCardPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutDebitCardPaymentRequest"/> class.
        /// </summary>
        public CreateCheckoutDebitCardPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutDebitCardPaymentRequest"/> class.
        /// </summary>
        /// <param name="authentication">authentication.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        public CreateCheckoutDebitCardPaymentRequest(
            Models.CreatePaymentAuthenticationRequest authentication,
            string statementDescriptor = null)
        {
            this.StatementDescriptor = statementDescriptor;
            this.Authentication = authentication;
        }

        /// <summary>
        /// Card invoice text descriptor
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Creates payment authentication
        /// </summary>
        [JsonProperty("authentication")]
        public Models.CreatePaymentAuthenticationRequest Authentication { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCheckoutDebitCardPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCheckoutDebitCardPaymentRequest other &&
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