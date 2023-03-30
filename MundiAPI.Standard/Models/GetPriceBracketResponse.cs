// <copyright file="GetPriceBracketResponse.cs" company="APIMatic">
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
    /// GetPriceBracketResponse.
    /// </summary>
    public class GetPriceBracketResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPriceBracketResponse"/> class.
        /// </summary>
        public GetPriceBracketResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPriceBracketResponse"/> class.
        /// </summary>
        /// <param name="startQuantity">start_quantity.</param>
        /// <param name="price">price.</param>
        /// <param name="endQuantity">end_quantity.</param>
        /// <param name="overagePrice">overage_price.</param>
        public GetPriceBracketResponse(
            int startQuantity,
            int price,
            int? endQuantity = null,
            int? overagePrice = null)
        {
            this.StartQuantity = startQuantity;
            this.Price = price;
            this.EndQuantity = endQuantity;
            this.OveragePrice = overagePrice;
        }

        /// <summary>
        /// Gets or sets StartQuantity.
        /// </summary>
        [JsonProperty("start_quantity")]
        public int StartQuantity { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets EndQuantity.
        /// </summary>
        [JsonProperty("end_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndQuantity { get; set; }

        /// <summary>
        /// Gets or sets OveragePrice.
        /// </summary>
        [JsonProperty("overage_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? OveragePrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPriceBracketResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPriceBracketResponse other &&
                this.StartQuantity.Equals(other.StartQuantity) &&
                this.Price.Equals(other.Price) &&
                ((this.EndQuantity == null && other.EndQuantity == null) || (this.EndQuantity?.Equals(other.EndQuantity) == true)) &&
                ((this.OveragePrice == null && other.OveragePrice == null) || (this.OveragePrice?.Equals(other.OveragePrice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartQuantity = {this.StartQuantity}");
            toStringOutput.Add($"this.Price = {this.Price}");
            toStringOutput.Add($"this.EndQuantity = {(this.EndQuantity == null ? "null" : this.EndQuantity.ToString())}");
            toStringOutput.Add($"this.OveragePrice = {(this.OveragePrice == null ? "null" : this.OveragePrice.ToString())}");
        }
    }
}