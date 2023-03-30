// <copyright file="CreateCardTokenRequest.cs" company="APIMatic">
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
    /// CreateCardTokenRequest.
    /// </summary>
    public class CreateCardTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardTokenRequest"/> class.
        /// </summary>
        public CreateCardTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardTokenRequest"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="holderName">holder_name.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="cvv">cvv.</param>
        /// <param name="brand">brand.</param>
        /// <param name="label">label.</param>
        public CreateCardTokenRequest(
            string number,
            string holderName,
            int expMonth,
            int expYear,
            string cvv,
            string brand,
            string label)
        {
            this.Number = number;
            this.HolderName = holderName;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Cvv = cvv;
            this.Brand = brand;
            this.Label = label;
        }

        /// <summary>
        /// Credit card number
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Holder name, as written on the card
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        /// The expiration month
        /// </summary>
        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        /// <summary>
        /// The expiration year, that can be informed with 2 or 4 digits
        /// </summary>
        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        /// <summary>
        /// The card's security code
        /// </summary>
        [JsonProperty("cvv")]
        public string Cvv { get; set; }

        /// <summary>
        /// Card brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCardTokenRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCardTokenRequest other &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                this.ExpMonth.Equals(other.ExpMonth) &&
                this.ExpYear.Equals(other.ExpYear) &&
                ((this.Cvv == null && other.Cvv == null) || (this.Cvv?.Equals(other.Cvv) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number == string.Empty ? "" : this.Number)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.ExpMonth = {this.ExpMonth}");
            toStringOutput.Add($"this.ExpYear = {this.ExpYear}");
            toStringOutput.Add($"this.Cvv = {(this.Cvv == null ? "null" : this.Cvv == string.Empty ? "" : this.Cvv)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand == string.Empty ? "" : this.Brand)}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label == string.Empty ? "" : this.Label)}");
        }
    }
}