// <copyright file="ListCyclesResponse.cs" company="APIMatic">
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
    /// ListCyclesResponse.
    /// </summary>
    public class ListCyclesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCyclesResponse"/> class.
        /// </summary>
        public ListCyclesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCyclesResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="paging">paging.</param>
        public ListCyclesResponse(
            List<Models.GetPeriodResponse> data = null,
            Models.PagingResponse paging = null)
        {
            this.Data = data;
            this.Paging = paging;
        }

        /// <summary>
        /// The subscription cycles objects
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GetPeriodResponse> Data { get; set; }

        /// <summary>
        /// Paging object
        /// </summary>
        [JsonProperty("paging", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingResponse Paging { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListCyclesResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is ListCyclesResponse other &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Paging == null && other.Paging == null) || (this.Paging?.Equals(other.Paging) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Paging = {(this.Paging == null ? "null" : this.Paging.ToString())}");
        }
    }
}