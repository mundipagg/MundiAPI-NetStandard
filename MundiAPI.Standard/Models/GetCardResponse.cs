// <copyright file="GetCardResponse.cs" company="APIMatic">
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
    /// GetCardResponse.
    /// </summary>
    public class GetCardResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardResponse"/> class.
        /// </summary>
        public GetCardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="lastFourDigits">last_four_digits.</param>
        /// <param name="brand">brand.</param>
        /// <param name="holderName">holder_name.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="type">type.</param>
        /// <param name="holderDocument">holder_document.</param>
        /// <param name="firstSixDigits">first_six_digits.</param>
        /// <param name="label">label.</param>
        /// <param name="customer">customer.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public GetCardResponse(
            string id,
            string lastFourDigits,
            string brand,
            string holderName,
            int expMonth,
            int expYear,
            string status,
            DateTime createdAt,
            DateTime updatedAt,
            Models.GetBillingAddressResponse billingAddress,
            Dictionary<string, string> metadata,
            string type,
            string holderDocument,
            string firstSixDigits,
            string label,
            Models.GetCustomerResponse customer = null,
            DateTime? deletedAt = null)
        {
            this.Id = id;
            this.LastFourDigits = lastFourDigits;
            this.Brand = brand;
            this.HolderName = holderName;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.BillingAddress = billingAddress;
            this.Customer = customer;
            this.Metadata = metadata;
            this.Type = type;
            this.HolderDocument = holderDocument;
            this.DeletedAt = deletedAt;
            this.FirstSixDigits = firstSixDigits;
            this.Label = label;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets LastFourDigits.
        /// </summary>
        [JsonProperty("last_four_digits")]
        public string LastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets Brand.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets HolderName.
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        /// Gets or sets ExpMonth.
        /// </summary>
        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        /// <summary>
        /// Gets or sets ExpYear.
        /// </summary>
        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.GetBillingAddressResponse BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCustomerResponse Customer { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Card type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Document number for the card's holder
        /// </summary>
        [JsonProperty("holder_document")]
        public string HolderDocument { get; set; }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// First six digits
        /// </summary>
        [JsonProperty("first_six_digits")]
        public string FirstSixDigits { get; set; }

        /// <summary>
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCardResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCardResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.LastFourDigits == null && other.LastFourDigits == null) || (this.LastFourDigits?.Equals(other.LastFourDigits) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                this.ExpMonth.Equals(other.ExpMonth) &&
                this.ExpYear.Equals(other.ExpYear) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.HolderDocument == null && other.HolderDocument == null) || (this.HolderDocument?.Equals(other.HolderDocument) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.FirstSixDigits == null && other.FirstSixDigits == null) || (this.FirstSixDigits?.Equals(other.FirstSixDigits) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.LastFourDigits = {(this.LastFourDigits == null ? "null" : this.LastFourDigits == string.Empty ? "" : this.LastFourDigits)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand == string.Empty ? "" : this.Brand)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.ExpMonth = {this.ExpMonth}");
            toStringOutput.Add($"this.ExpYear = {this.ExpYear}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.HolderDocument = {(this.HolderDocument == null ? "null" : this.HolderDocument == string.Empty ? "" : this.HolderDocument)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.FirstSixDigits = {(this.FirstSixDigits == null ? "null" : this.FirstSixDigits == string.Empty ? "" : this.FirstSixDigits)}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label == string.Empty ? "" : this.Label)}");
        }
    }
}