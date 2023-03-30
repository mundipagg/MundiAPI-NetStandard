// <copyright file="GetCheckoutBoletoPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutBoletoPaymentResponse.
    /// </summary>
    public class GetCheckoutBoletoPaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBoletoPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutBoletoPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBoletoPaymentResponse"/> class.
        /// </summary>
        /// <param name="dueAt">due_at.</param>
        /// <param name="instructions">instructions.</param>
        public GetCheckoutBoletoPaymentResponse(
            DateTime dueAt,
            string instructions)
        {
            this.DueAt = dueAt;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Data de vencimento do boleto
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime DueAt { get; set; }

        /// <summary>
        /// Instruções do boleto
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutBoletoPaymentResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutBoletoPaymentResponse other &&
                this.DueAt.Equals(other.DueAt) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DueAt = {this.DueAt}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions == string.Empty ? "" : this.Instructions)}");
        }
    }
}