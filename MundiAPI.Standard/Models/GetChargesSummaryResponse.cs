// <copyright file="GetChargesSummaryResponse.cs" company="APIMatic">
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
    /// GetChargesSummaryResponse.
    /// </summary>
    public class GetChargesSummaryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargesSummaryResponse"/> class.
        /// </summary>
        public GetChargesSummaryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargesSummaryResponse"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        public GetChargesSummaryResponse(
            int total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Gets or sets Total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetChargesSummaryResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetChargesSummaryResponse other &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}