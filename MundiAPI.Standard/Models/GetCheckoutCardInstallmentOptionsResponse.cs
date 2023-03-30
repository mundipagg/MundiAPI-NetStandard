// <copyright file="GetCheckoutCardInstallmentOptionsResponse.cs" company="APIMatic">
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
    /// GetCheckoutCardInstallmentOptionsResponse.
    /// </summary>
    public class GetCheckoutCardInstallmentOptionsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCardInstallmentOptionsResponse"/> class.
        /// </summary>
        public GetCheckoutCardInstallmentOptionsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCardInstallmentOptionsResponse"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="total">total.</param>
        public GetCheckoutCardInstallmentOptionsResponse(
            string number,
            int total)
        {
            this.Number = number;
            this.Total = total;
        }

        /// <summary>
        /// Número de parcelas
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Valor total da compra
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutCardInstallmentOptionsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutCardInstallmentOptionsResponse other &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number == string.Empty ? "" : this.Number)}");
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}