// <copyright file="GetInterestResponse.cs" company="APIMatic">
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
    /// GetInterestResponse.
    /// </summary>
    public class GetInterestResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInterestResponse"/> class.
        /// </summary>
        public GetInterestResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInterestResponse"/> class.
        /// </summary>
        /// <param name="days">days.</param>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        public GetInterestResponse(
            int days,
            string type,
            int amount)
        {
            this.Days = days;
            this.Type = type;
            this.Amount = amount;
        }

        /// <summary>
        /// Days
        /// </summary>
        [JsonProperty("days")]
        public int Days { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetInterestResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetInterestResponse other &&
                this.Days.Equals(other.Days) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Amount.Equals(other.Amount);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Days = {this.Days}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
        }
    }
}