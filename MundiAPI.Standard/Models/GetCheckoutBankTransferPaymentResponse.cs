// <copyright file="GetCheckoutBankTransferPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutBankTransferPaymentResponse.
    /// </summary>
    public class GetCheckoutBankTransferPaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBankTransferPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutBankTransferPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBankTransferPaymentResponse"/> class.
        /// </summary>
        /// <param name="bank">bank.</param>
        public GetCheckoutBankTransferPaymentResponse(
            List<string> bank)
        {
            this.Bank = bank;
        }

        /// <summary>
        /// bank list response
        /// </summary>
        [JsonProperty("bank")]
        public List<string> Bank { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutBankTransferPaymentResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutBankTransferPaymentResponse other &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : $"[{string.Join(", ", this.Bank)} ]")}");
        }
    }
}