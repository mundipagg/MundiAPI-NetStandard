// <copyright file="CreateSubMerchantRequest.cs" company="APIMatic">
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
    /// CreateSubMerchantRequest.
    /// </summary>
    public class CreateSubMerchantRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubMerchantRequest"/> class.
        /// </summary>
        public CreateSubMerchantRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubMerchantRequest"/> class.
        /// </summary>
        /// <param name="paymentFacilitatorCode">payment_facilitator_code.</param>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="merchantCategoryCode">merchant_category_code.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="phone">phone.</param>
        /// <param name="address">address.</param>
        public CreateSubMerchantRequest(
            string paymentFacilitatorCode,
            string code,
            string name,
            string merchantCategoryCode,
            string document,
            string type,
            Models.CreatePhoneRequest phone,
            Models.CreateAddressRequest address)
        {
            this.PaymentFacilitatorCode = paymentFacilitatorCode;
            this.Code = code;
            this.Name = name;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.Document = document;
            this.Type = type;
            this.Phone = phone;
            this.Address = address;
        }

        /// <summary>
        /// Payment Facilitator Code
        /// </summary>
        [JsonProperty("payment_facilitator_code")]
        public string PaymentFacilitatorCode { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Merchant Category Code
        /// </summary>
        [JsonProperty("merchant_category_code")]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Document number. Only numbers, no special characters.
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Document type. Can be either 'individual' or 'company'
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [JsonProperty("phone")]
        public Models.CreatePhoneRequest Phone { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateAddressRequest Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSubMerchantRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateSubMerchantRequest other &&
                ((this.PaymentFacilitatorCode == null && other.PaymentFacilitatorCode == null) || (this.PaymentFacilitatorCode?.Equals(other.PaymentFacilitatorCode) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MerchantCategoryCode == null && other.MerchantCategoryCode == null) || (this.MerchantCategoryCode?.Equals(other.MerchantCategoryCode) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentFacilitatorCode = {(this.PaymentFacilitatorCode == null ? "null" : this.PaymentFacilitatorCode == string.Empty ? "" : this.PaymentFacilitatorCode)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.MerchantCategoryCode = {(this.MerchantCategoryCode == null ? "null" : this.MerchantCategoryCode == string.Empty ? "" : this.MerchantCategoryCode)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document == string.Empty ? "" : this.Document)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
        }
    }
}