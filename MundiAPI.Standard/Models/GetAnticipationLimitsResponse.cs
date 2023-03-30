// <copyright file="GetAnticipationLimitsResponse.cs" company="APIMatic">
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
    /// GetAnticipationLimitsResponse.
    /// </summary>
    public class GetAnticipationLimitsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitsResponse"/> class.
        /// </summary>
        public GetAnticipationLimitsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitsResponse"/> class.
        /// </summary>
        /// <param name="max">max.</param>
        /// <param name="min">min.</param>
        public GetAnticipationLimitsResponse(
            Models.GetAnticipationLimitResponse max,
            Models.GetAnticipationLimitResponse min)
        {
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Max limit
        /// </summary>
        [JsonProperty("max")]
        public Models.GetAnticipationLimitResponse Max { get; set; }

        /// <summary>
        /// Min limit
        /// </summary>
        [JsonProperty("min")]
        public Models.GetAnticipationLimitResponse Min { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAnticipationLimitsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetAnticipationLimitsResponse other &&
                ((this.Max == null && other.Max == null) || (this.Max?.Equals(other.Max) == true)) &&
                ((this.Min == null && other.Min == null) || (this.Min?.Equals(other.Min) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Max = {(this.Max == null ? "null" : this.Max.ToString())}");
            toStringOutput.Add($"this.Min = {(this.Min == null ? "null" : this.Min.ToString())}");
        }
    }
}