// <copyright file="GetBillingAddressResponse.cs" company="APIMatic">
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
    /// GetBillingAddressResponse.
    /// </summary>
    public class GetBillingAddressResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingAddressResponse"/> class.
        /// </summary>
        public GetBillingAddressResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingAddressResponse"/> class.
        /// </summary>
        /// <param name="street">street.</param>
        /// <param name="number">number.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="neighborhood">neighborhood.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="country">country.</param>
        /// <param name="complement">complement.</param>
        /// <param name="line1">line_1.</param>
        /// <param name="line2">line_2.</param>
        public GetBillingAddressResponse(
            string street,
            string number,
            string zipCode,
            string neighborhood,
            string city,
            string state,
            string country,
            string complement,
            string line1,
            string line2)
        {
            this.Street = street;
            this.Number = number;
            this.ZipCode = zipCode;
            this.Neighborhood = neighborhood;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Complement = complement;
            this.Line1 = line1;
            this.Line2 = line2;
        }

        /// <summary>
        /// Gets or sets Street.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets ZipCode.
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets Neighborhood.
        /// </summary>
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Complement.
        /// </summary>
        [JsonProperty("complement")]
        public string Complement { get; set; }

        /// <summary>
        /// Line 1 for address
        /// </summary>
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Line 2 for address
        /// </summary>
        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetBillingAddressResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetBillingAddressResponse other &&
                ((this.Street == null && other.Street == null) || (this.Street?.Equals(other.Street) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.Neighborhood == null && other.Neighborhood == null) || (this.Neighborhood?.Equals(other.Neighborhood) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Complement == null && other.Complement == null) || (this.Complement?.Equals(other.Complement) == true)) &&
                ((this.Line1 == null && other.Line1 == null) || (this.Line1?.Equals(other.Line1) == true)) &&
                ((this.Line2 == null && other.Line2 == null) || (this.Line2?.Equals(other.Line2) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Street = {(this.Street == null ? "null" : this.Street == string.Empty ? "" : this.Street)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number == string.Empty ? "" : this.Number)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode == string.Empty ? "" : this.ZipCode)}");
            toStringOutput.Add($"this.Neighborhood = {(this.Neighborhood == null ? "null" : this.Neighborhood == string.Empty ? "" : this.Neighborhood)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City == string.Empty ? "" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country == string.Empty ? "" : this.Country)}");
            toStringOutput.Add($"this.Complement = {(this.Complement == null ? "null" : this.Complement == string.Empty ? "" : this.Complement)}");
            toStringOutput.Add($"this.Line1 = {(this.Line1 == null ? "null" : this.Line1 == string.Empty ? "" : this.Line1)}");
            toStringOutput.Add($"this.Line2 = {(this.Line2 == null ? "null" : this.Line2 == string.Empty ? "" : this.Line2)}");
        }
    }
}