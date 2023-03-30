// <copyright file="GetOrderItemResponse.cs" company="APIMatic">
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
    /// GetOrderItemResponse.
    /// </summary>
    public class GetOrderItemResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderItemResponse"/> class.
        /// </summary>
        public GetOrderItemResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderItemResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="category">category.</param>
        /// <param name="code">code.</param>
        public GetOrderItemResponse(
            string id,
            int amount,
            string description,
            int quantity,
            string category,
            string code)
        {
            this.Id = id;
            this.Amount = amount;
            this.Description = description;
            this.Quantity = quantity;
            this.Category = category;
            this.Code = code;
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

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
        /// Category
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetOrderItemResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetOrderItemResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Quantity.Equals(other.Quantity) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category == string.Empty ? "" : this.Category)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
        }
    }
}