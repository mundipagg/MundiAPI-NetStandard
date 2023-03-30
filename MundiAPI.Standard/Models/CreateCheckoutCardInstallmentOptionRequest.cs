// <copyright file="CreateCheckoutCardInstallmentOptionRequest.cs" company="APIMatic">
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
    /// CreateCheckoutCardInstallmentOptionRequest.
    /// </summary>
    public class CreateCheckoutCardInstallmentOptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutCardInstallmentOptionRequest"/> class.
        /// </summary>
        public CreateCheckoutCardInstallmentOptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutCardInstallmentOptionRequest"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="total">total.</param>
        public CreateCheckoutCardInstallmentOptionRequest(
            int number,
            int total)
        {
            this.Number = number;
            this.Total = total;
        }

        /// <summary>
        /// Installment quantity
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCheckoutCardInstallmentOptionRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCheckoutCardInstallmentOptionRequest other &&
                this.Number.Equals(other.Number) &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Number = {this.Number}");
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}