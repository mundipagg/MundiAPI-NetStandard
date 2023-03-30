// <copyright file="GetShippingResponse.cs" company="APIMatic">
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
    /// GetShippingResponse.
    /// </summary>
    public class GetShippingResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetShippingResponse"/> class.
        /// </summary>
        public GetShippingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShippingResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="recipientName">recipient_name.</param>
        /// <param name="recipientPhone">recipient_phone.</param>
        /// <param name="address">address.</param>
        /// <param name="type">type.</param>
        /// <param name="maxDeliveryDate">max_delivery_date.</param>
        /// <param name="estimatedDeliveryDate">estimated_delivery_date.</param>
        public GetShippingResponse(
            int amount,
            string description,
            string recipientName,
            string recipientPhone,
            Models.GetAddressResponse address,
            string type,
            DateTime? maxDeliveryDate = null,
            DateTime? estimatedDeliveryDate = null)
        {
            this.Amount = amount;
            this.Description = description;
            this.RecipientName = recipientName;
            this.RecipientPhone = recipientPhone;
            this.Address = address;
            this.MaxDeliveryDate = maxDeliveryDate;
            this.EstimatedDeliveryDate = estimatedDeliveryDate;
            this.Type = type;
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
        /// Gets or sets RecipientName.
        /// </summary>
        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or sets RecipientPhone.
        /// </summary>
        [JsonProperty("recipient_phone")]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public Models.GetAddressResponse Address { get; set; }

        /// <summary>
        /// Data máxima de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("max_delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MaxDeliveryDate { get; set; }

        /// <summary>
        /// Prazo estimado de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("estimated_delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Shipping Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetShippingResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetShippingResponse other &&
                this.Amount.Equals(other.Amount) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.RecipientName == null && other.RecipientName == null) || (this.RecipientName?.Equals(other.RecipientName) == true)) &&
                ((this.RecipientPhone == null && other.RecipientPhone == null) || (this.RecipientPhone?.Equals(other.RecipientPhone) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.MaxDeliveryDate == null && other.MaxDeliveryDate == null) || (this.MaxDeliveryDate?.Equals(other.MaxDeliveryDate) == true)) &&
                ((this.EstimatedDeliveryDate == null && other.EstimatedDeliveryDate == null) || (this.EstimatedDeliveryDate?.Equals(other.EstimatedDeliveryDate) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.RecipientName = {(this.RecipientName == null ? "null" : this.RecipientName == string.Empty ? "" : this.RecipientName)}");
            toStringOutput.Add($"this.RecipientPhone = {(this.RecipientPhone == null ? "null" : this.RecipientPhone == string.Empty ? "" : this.RecipientPhone)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.MaxDeliveryDate = {(this.MaxDeliveryDate == null ? "null" : this.MaxDeliveryDate.ToString())}");
            toStringOutput.Add($"this.EstimatedDeliveryDate = {(this.EstimatedDeliveryDate == null ? "null" : this.EstimatedDeliveryDate.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}