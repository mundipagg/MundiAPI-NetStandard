// <copyright file="CreateCheckoutBoletoPaymentRequest.cs" company="APIMatic">
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
    /// CreateCheckoutBoletoPaymentRequest.
    /// </summary>
    public class CreateCheckoutBoletoPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutBoletoPaymentRequest"/> class.
        /// </summary>
        public CreateCheckoutBoletoPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutBoletoPaymentRequest"/> class.
        /// </summary>
        /// <param name="bank">bank.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="dueAt">due_at.</param>
        public CreateCheckoutBoletoPaymentRequest(
            string bank,
            string instructions,
            DateTime dueAt)
        {
            this.Bank = bank;
            this.Instructions = instructions;
            this.DueAt = dueAt;
        }

        /// <summary>
        /// Bank identifier
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// Instructions
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// Due date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime DueAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCheckoutBoletoPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCheckoutBoletoPaymentRequest other &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true)) &&
                this.DueAt.Equals(other.DueAt);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank == string.Empty ? "" : this.Bank)}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions == string.Empty ? "" : this.Instructions)}");
            toStringOutput.Add($"this.DueAt = {this.DueAt}");
        }
    }
}