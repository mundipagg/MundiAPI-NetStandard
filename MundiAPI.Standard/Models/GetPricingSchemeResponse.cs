// <copyright file="GetPricingSchemeResponse.cs" company="APIMatic">
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
    /// GetPricingSchemeResponse.
    /// </summary>
    public class GetPricingSchemeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingSchemeResponse"/> class.
        /// </summary>
        public GetPricingSchemeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingSchemeResponse"/> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="schemeType">scheme_type.</param>
        /// <param name="priceBrackets">price_brackets.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="percentage">percentage.</param>
        public GetPricingSchemeResponse(
            int price,
            string schemeType,
            List<Models.GetPriceBracketResponse> priceBrackets,
            int? minimumPrice = null,
            double? percentage = null)
        {
            this.Price = price;
            this.SchemeType = schemeType;
            this.PriceBrackets = priceBrackets;
            this.MinimumPrice = minimumPrice;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets SchemeType.
        /// </summary>
        [JsonProperty("scheme_type")]
        public string SchemeType { get; set; }

        /// <summary>
        /// Gets or sets PriceBrackets.
        /// </summary>
        [JsonProperty("price_brackets")]
        public List<Models.GetPriceBracketResponse> PriceBrackets { get; set; }

        /// <summary>
        /// Gets or sets MinimumPrice.
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <summary>
        /// percentual value used in pricing_scheme Percent
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPricingSchemeResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPricingSchemeResponse other &&
                this.Price.Equals(other.Price) &&
                ((this.SchemeType == null && other.SchemeType == null) || (this.SchemeType?.Equals(other.SchemeType) == true)) &&
                ((this.PriceBrackets == null && other.PriceBrackets == null) || (this.PriceBrackets?.Equals(other.PriceBrackets) == true)) &&
                ((this.MinimumPrice == null && other.MinimumPrice == null) || (this.MinimumPrice?.Equals(other.MinimumPrice) == true)) &&
                ((this.Percentage == null && other.Percentage == null) || (this.Percentage?.Equals(other.Percentage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Price = {this.Price}");
            toStringOutput.Add($"this.SchemeType = {(this.SchemeType == null ? "null" : this.SchemeType == string.Empty ? "" : this.SchemeType)}");
            toStringOutput.Add($"this.PriceBrackets = {(this.PriceBrackets == null ? "null" : $"[{string.Join(", ", this.PriceBrackets)} ]")}");
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"this.Percentage = {(this.Percentage == null ? "null" : this.Percentage.ToString())}");
        }
    }
}