// <copyright file="CreateCancelChargeSplitRulesRequest.cs" company="APIMatic">
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
    /// CreateCancelChargeSplitRulesRequest.
    /// </summary>
    public class CreateCancelChargeSplitRulesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCancelChargeSplitRulesRequest"/> class.
        /// </summary>
        public CreateCancelChargeSplitRulesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCancelChargeSplitRulesRequest"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amount">Amount.</param>
        /// <param name="type">type.</param>
        public CreateCancelChargeSplitRulesRequest(
            string id,
            int amount,
            string type)
        {
            this.Id = id;
            this.Amount = amount;
            this.Type = type;
        }

        /// <summary>
        /// The split rule gateway id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The split rule amount
        /// </summary>
        [JsonProperty("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The amount type (flat ou percentage)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCancelChargeSplitRulesRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCancelChargeSplitRulesRequest other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}