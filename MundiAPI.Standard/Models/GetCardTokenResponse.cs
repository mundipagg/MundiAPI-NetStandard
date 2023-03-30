// <copyright file="GetCardTokenResponse.cs" company="APIMatic">
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
    /// GetCardTokenResponse.
    /// </summary>
    public class GetCardTokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardTokenResponse"/> class.
        /// </summary>
        public GetCardTokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardTokenResponse"/> class.
        /// </summary>
        /// <param name="lastFourDigits">last_four_digits.</param>
        /// <param name="holderName">holder_name.</param>
        /// <param name="holderDocument">holder_document.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="brand">brand.</param>
        /// <param name="type">type.</param>
        /// <param name="label">label.</param>
        public GetCardTokenResponse(
            string lastFourDigits,
            string holderName,
            string holderDocument,
            string expMonth,
            string expYear,
            string brand,
            string type,
            string label)
        {
            this.LastFourDigits = lastFourDigits;
            this.HolderName = holderName;
            this.HolderDocument = holderDocument;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Brand = brand;
            this.Type = type;
            this.Label = label;
        }

        /// <summary>
        /// Gets or sets LastFourDigits.
        /// </summary>
        [JsonProperty("last_four_digits")]
        public string LastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets HolderName.
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        /// Gets or sets HolderDocument.
        /// </summary>
        [JsonProperty("holder_document")]
        public string HolderDocument { get; set; }

        /// <summary>
        /// Gets or sets ExpMonth.
        /// </summary>
        [JsonProperty("exp_month")]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Gets or sets ExpYear.
        /// </summary>
        [JsonProperty("exp_year")]
        public string ExpYear { get; set; }

        /// <summary>
        /// Gets or sets Brand.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

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

            return $"GetCardTokenResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCardTokenResponse other &&
                ((this.LastFourDigits == null && other.LastFourDigits == null) || (this.LastFourDigits?.Equals(other.LastFourDigits) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.HolderDocument == null && other.HolderDocument == null) || (this.HolderDocument?.Equals(other.HolderDocument) == true)) &&
                ((this.ExpMonth == null && other.ExpMonth == null) || (this.ExpMonth?.Equals(other.ExpMonth) == true)) &&
                ((this.ExpYear == null && other.ExpYear == null) || (this.ExpYear?.Equals(other.ExpYear) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastFourDigits = {(this.LastFourDigits == null ? "null" : this.LastFourDigits == string.Empty ? "" : this.LastFourDigits)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.HolderDocument = {(this.HolderDocument == null ? "null" : this.HolderDocument == string.Empty ? "" : this.HolderDocument)}");
            toStringOutput.Add($"this.ExpMonth = {(this.ExpMonth == null ? "null" : this.ExpMonth == string.Empty ? "" : this.ExpMonth)}");
            toStringOutput.Add($"this.ExpYear = {(this.ExpYear == null ? "null" : this.ExpYear == string.Empty ? "" : this.ExpYear)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand == string.Empty ? "" : this.Brand)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label == string.Empty ? "" : this.Label)}");
        }
    }
}