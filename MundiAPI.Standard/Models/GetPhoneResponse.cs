// <copyright file="GetPhoneResponse.cs" company="APIMatic">
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
    /// GetPhoneResponse.
    /// </summary>
    public class GetPhoneResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneResponse"/> class.
        /// </summary>
        public GetPhoneResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneResponse"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="number">number.</param>
        /// <param name="areaCode">area_code.</param>
        public GetPhoneResponse(
            string countryCode = null,
            string number = null,
            string areaCode = null)
        {
            this.CountryCode = countryCode;
            this.Number = number;
            this.AreaCode = areaCode;
        }

        /// <summary>
        /// Gets or sets CountryCode.
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets AreaCode.
        /// </summary>
        [JsonProperty("area_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPhoneResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPhoneResponse other &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.AreaCode == null && other.AreaCode == null) || (this.AreaCode?.Equals(other.AreaCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode == string.Empty ? "" : this.CountryCode)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number == string.Empty ? "" : this.Number)}");
            toStringOutput.Add($"this.AreaCode = {(this.AreaCode == null ? "null" : this.AreaCode == string.Empty ? "" : this.AreaCode)}");
        }
    }
}