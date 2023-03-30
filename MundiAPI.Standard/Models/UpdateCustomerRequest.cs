// <copyright file="UpdateCustomerRequest.cs" company="APIMatic">
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
    /// UpdateCustomerRequest.
    /// </summary>
    public class UpdateCustomerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest"/> class.
        /// </summary>
        public UpdateCustomerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="address">address.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="phones">phones.</param>
        /// <param name="code">code.</param>
        /// <param name="gender">gender.</param>
        /// <param name="documentType">document_type.</param>
        public UpdateCustomerRequest(
            string name = null,
            string email = null,
            string document = null,
            string type = null,
            Models.CreateAddressRequest address = null,
            Dictionary<string, string> metadata = null,
            Models.CreatePhonesRequest phones = null,
            string code = null,
            string gender = null,
            string documentType = null)
        {
            this.Name = name;
            this.Email = email;
            this.Document = document;
            this.Type = type;
            this.Address = address;
            this.Metadata = metadata;
            this.Phones = phones;
            this.Code = code;
            this.Gender = gender;
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Document number
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public string Document { get; set; }

        /// <summary>
        /// Person type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateAddressRequest Address { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Phones.
        /// </summary>
        [JsonProperty("phones", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePhonesRequest Phones { get; set; }

        /// <summary>
        /// Código de referência do cliente no sistema da loja. Max: 52 caracteres
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gênero do cliente
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets DocumentType.
        /// </summary>
        [JsonProperty("document_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateCustomerRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateCustomerRequest other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Phones == null && other.Phones == null) || (this.Phones?.Equals(other.Phones) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Gender == null && other.Gender == null) || (this.Gender?.Equals(other.Gender) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document == string.Empty ? "" : this.Document)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Phones = {(this.Phones == null ? "null" : this.Phones.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Gender = {(this.Gender == null ? "null" : this.Gender == string.Empty ? "" : this.Gender)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType == string.Empty ? "" : this.DocumentType)}");
        }
    }
}