// <copyright file="PagingResponse.cs" company="APIMatic">
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
    /// PagingResponse.
    /// </summary>
    public class PagingResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingResponse"/> class.
        /// </summary>
        public PagingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingResponse"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="previous">previous.</param>
        /// <param name="next">next.</param>
        public PagingResponse(
            int total,
            string previous,
            string next)
        {
            this.Total = total;
            this.Previous = previous;
            this.Next = next;
        }

        /// <summary>
        /// Total number of pages
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Previous page
        /// </summary>
        [JsonProperty("previous")]
        public string Previous { get; set; }

        /// <summary>
        /// Next page
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PagingResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is PagingResponse other &&
                this.Total.Equals(other.Total) &&
                ((this.Previous == null && other.Previous == null) || (this.Previous?.Equals(other.Previous) == true)) &&
                ((this.Next == null && other.Next == null) || (this.Next?.Equals(other.Next) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"this.Previous = {(this.Previous == null ? "null" : this.Previous == string.Empty ? "" : this.Previous)}");
            toStringOutput.Add($"this.Next = {(this.Next == null ? "null" : this.Next == string.Empty ? "" : this.Next)}");
        }
    }
}