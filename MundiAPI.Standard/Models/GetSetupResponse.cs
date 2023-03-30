// <copyright file="GetSetupResponse.cs" company="APIMatic">
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
    /// GetSetupResponse.
    /// </summary>
    public class GetSetupResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSetupResponse"/> class.
        /// </summary>
        public GetSetupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSetupResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        public GetSetupResponse(
            string id,
            string description,
            int amount,
            string status)
        {
            this.Id = id;
            this.Description = description;
            this.Amount = amount;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSetupResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSetupResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}