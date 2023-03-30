// <copyright file="CreateUsageRequest.cs" company="APIMatic">
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
    /// CreateUsageRequest.
    /// </summary>
    public class CreateUsageRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUsageRequest"/> class.
        /// </summary>
        public CreateUsageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUsageRequest"/> class.
        /// </summary>
        /// <param name="quantity">quantity.</param>
        /// <param name="description">description.</param>
        /// <param name="usedAt">used_at.</param>
        /// <param name="code">code.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="amount">amount.</param>
        public CreateUsageRequest(
            int quantity,
            string description,
            DateTime usedAt,
            string code = null,
            string mGroup = null,
            int? amount = null)
        {
            this.Quantity = quantity;
            this.Description = description;
            this.UsedAt = usedAt;
            this.Code = code;
            this.MGroup = mGroup;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets UsedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("used_at")]
        public DateTime UsedAt { get; set; }

        /// <summary>
        /// Identification code in the client system
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// identification group in the client system
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string MGroup { get; set; }

        /// <summary>
        /// Field used in item scheme type 'Percent'
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateUsageRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateUsageRequest other &&
                this.Quantity.Equals(other.Quantity) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.UsedAt.Equals(other.UsedAt) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.UsedAt = {this.UsedAt}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup == string.Empty ? "" : this.MGroup)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}