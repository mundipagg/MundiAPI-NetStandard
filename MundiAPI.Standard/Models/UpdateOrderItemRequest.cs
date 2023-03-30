// <copyright file="UpdateOrderItemRequest.cs" company="APIMatic">
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
    /// UpdateOrderItemRequest.
    /// </summary>
    public class UpdateOrderItemRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderItemRequest"/> class.
        /// </summary>
        public UpdateOrderItemRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderItemRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="category">category.</param>
        public UpdateOrderItemRequest(
            int amount,
            string description,
            int quantity,
            string category)
        {
            this.Amount = amount;
            this.Description = description;
            this.Quantity = quantity;
            this.Category = category;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateOrderItemRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateOrderItemRequest other &&
                this.Amount.Equals(other.Amount) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Quantity.Equals(other.Quantity) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category == string.Empty ? "" : this.Category)}");
        }
    }
}