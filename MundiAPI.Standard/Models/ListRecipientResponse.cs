// <copyright file="ListRecipientResponse.cs" company="APIMatic">
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
    /// ListRecipientResponse.
    /// </summary>
    public class ListRecipientResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRecipientResponse"/> class.
        /// </summary>
        public ListRecipientResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRecipientResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="paging">paging.</param>
        public ListRecipientResponse(
            List<Models.GetRecipientResponse> data,
            Models.PagingResponse paging)
        {
            this.Data = data;
            this.Paging = paging;
        }

        /// <summary>
        /// Recipients
        /// </summary>
        [JsonProperty("data")]
        public List<Models.GetRecipientResponse> Data { get; set; }

        /// <summary>
        /// Paging
        /// </summary>
        [JsonProperty("paging")]
        public Models.PagingResponse Paging { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListRecipientResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is ListRecipientResponse other &&
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