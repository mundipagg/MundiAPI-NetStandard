// <copyright file="CreateIncrementRequest.cs" company="APIMatic">
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
    /// CreateIncrementRequest.
    /// </summary>
    public class CreateIncrementRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIncrementRequest"/> class.
        /// </summary>
        public CreateIncrementRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIncrementRequest"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="incrementType">increment_type.</param>
        /// <param name="itemId">item_id.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="description">description.</param>
        public CreateIncrementRequest(
            double mValue,
            string incrementType,
            string itemId,
            int? cycles = null,
            string description = null)
        {
            this.MValue = mValue;
            this.IncrementType = incrementType;
            this.ItemId = itemId;
            this.Cycles = cycles;
            this.Description = description;
        }

        /// <summary>
        /// The increment value
        /// </summary>
        [JsonProperty("value")]
        public double MValue { get; set; }

        /// <summary>
        /// Increment type. Can be either flat or percentage.
        /// </summary>
        [JsonProperty("increment_type")]
        public string IncrementType { get; set; }

        /// <summary>
        /// The item where the increment will be applied
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Number of cycles that the increment will be applied
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateIncrementRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateIncrementRequest other &&
                this.MValue.Equals(other.MValue) &&
                ((this.IncrementType == null && other.IncrementType == null) || (this.IncrementType?.Equals(other.IncrementType) == true)) &&
                ((this.ItemId == null && other.ItemId == null) || (this.ItemId?.Equals(other.ItemId) == true)) &&
                ((this.Cycles == null && other.Cycles == null) || (this.Cycles?.Equals(other.Cycles) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {this.MValue}");
            toStringOutput.Add($"this.IncrementType = {(this.IncrementType == null ? "null" : this.IncrementType == string.Empty ? "" : this.IncrementType)}");
            toStringOutput.Add($"this.ItemId = {(this.ItemId == null ? "null" : this.ItemId == string.Empty ? "" : this.ItemId)}");
            toStringOutput.Add($"this.Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
        }
    }
}