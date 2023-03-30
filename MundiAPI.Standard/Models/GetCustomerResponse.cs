// <copyright file="GetCustomerResponse.cs" company="APIMatic">
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
    /// GetCustomerResponse.
    /// </summary>
    public class GetCustomerResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerResponse"/> class.
        /// </summary>
        public GetCustomerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="delinquent">delinquent.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="fbAccessToken">fb_access_token.</param>
        /// <param name="address">address.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="phones">phones.</param>
        /// <param name="code">code.</param>
        /// <param name="documentType">document_type.</param>
        /// <param name="fbId">fb_id.</param>
        public GetCustomerResponse(
            string id,
            string name,
            string email,
            bool delinquent,
            DateTime createdAt,
            DateTime updatedAt,
            string document,
            string type,
            string fbAccessToken,
            Models.GetAddressResponse address,
            Dictionary<string, string> metadata,
            Models.GetPhonesResponse phones,
            string code,
            string documentType,
            long? fbId = null)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Delinquent = delinquent;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Document = document;
            this.Type = type;
            this.FbAccessToken = fbAccessToken;
            this.Address = address;
            this.Metadata = metadata;
            this.Phones = phones;
            this.FbId = fbId;
            this.Code = code;
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Delinquent.
        /// </summary>
        [JsonProperty("delinquent")]
        public bool Delinquent { get; set; }

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
        /// Gets or sets Document.
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets FbAccessToken.
        /// </summary>
        [JsonProperty("fb_access_token")]
        public string FbAccessToken { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public Models.GetAddressResponse Address { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Phones.
        /// </summary>
        [JsonProperty("phones")]
        public Models.GetPhonesResponse Phones { get; set; }

        /// <summary>
        /// Gets or sets FbId.
        /// </summary>
        [JsonProperty("fb_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? FbId { get; set; }

        /// <summary>
        /// Código de referência do cliente no sistema da loja. Max: 52 caracteres
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets DocumentType.
        /// </summary>
        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCustomerResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCustomerResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                this.Delinquent.Equals(other.Delinquent) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.FbAccessToken == null && other.FbAccessToken == null) || (this.FbAccessToken?.Equals(other.FbAccessToken) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Phones == null && other.Phones == null) || (this.Phones?.Equals(other.Phones) == true)) &&
                ((this.FbId == null && other.FbId == null) || (this.FbId?.Equals(other.FbId) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Delinquent = {this.Delinquent}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document == string.Empty ? "" : this.Document)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.FbAccessToken = {(this.FbAccessToken == null ? "null" : this.FbAccessToken == string.Empty ? "" : this.FbAccessToken)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Phones = {(this.Phones == null ? "null" : this.Phones.ToString())}");
            toStringOutput.Add($"this.FbId = {(this.FbId == null ? "null" : this.FbId.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType == string.Empty ? "" : this.DocumentType)}");
        }
    }
}