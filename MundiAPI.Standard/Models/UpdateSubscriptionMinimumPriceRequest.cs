// <copyright file="UpdateSubscriptionMinimumPriceRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionMinimumPriceRequest.
    /// </summary>
    public class UpdateSubscriptionMinimumPriceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionMinimumPriceRequest"/> class.
        /// </summary>
        public UpdateSubscriptionMinimumPriceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionMinimumPriceRequest"/> class.
        /// </summary>
        /// <param name="minimumPrice">minimum_price.</param>
        public UpdateSubscriptionMinimumPriceRequest(
            int? minimumPrice = null)
        {
            this.MinimumPrice = minimumPrice;
        }

        /// <summary>
        /// Valor mínimo da assinatura
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateSubscriptionMinimumPriceRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateSubscriptionMinimumPriceRequest other &&
                ((this.MinimumPrice == null && other.MinimumPrice == null) || (this.MinimumPrice?.Equals(other.MinimumPrice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
        }
    }
}