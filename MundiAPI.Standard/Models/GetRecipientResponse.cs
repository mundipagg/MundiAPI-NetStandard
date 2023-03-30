// <copyright file="GetRecipientResponse.cs" company="APIMatic">
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
    /// GetRecipientResponse.
    /// </summary>
    public class GetRecipientResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecipientResponse"/> class.
        /// </summary>
        public GetRecipientResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecipientResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="defaultBankAccount">default_bank_account.</param>
        /// <param name="gatewayRecipients">gateway_recipients.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="code">code.</param>
        /// <param name="paymentMode">payment_mode.</param>
        /// <param name="automaticAnticipationSettings">automatic_anticipation_settings.</param>
        /// <param name="transferSettings">transfer_settings.</param>
        public GetRecipientResponse(
            string id,
            string name,
            string email,
            string document,
            string description,
            string type,
            string status,
            DateTime createdAt,
            DateTime updatedAt,
            DateTime deletedAt,
            Models.GetBankAccountResponse defaultBankAccount,
            List<Models.GetGatewayRecipientResponse> gatewayRecipients,
            Dictionary<string, string> metadata,
            string code,
            string paymentMode,
            Models.GetAutomaticAnticipationResponse automaticAnticipationSettings = null,
            Models.GetTransferSettingsResponse transferSettings = null)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Document = document;
            this.Description = description;
            this.Type = type;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
            this.DefaultBankAccount = defaultBankAccount;
            this.GatewayRecipients = gatewayRecipients;
            this.Metadata = metadata;
            this.AutomaticAnticipationSettings = automaticAnticipationSettings;
            this.TransferSettings = transferSettings;
            this.Code = code;
            this.PaymentMode = paymentMode;
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Document
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Deletion date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTime DeletedAt { get; set; }

        /// <summary>
        /// Default bank account
        /// </summary>
        [JsonProperty("default_bank_account")]
        public Models.GetBankAccountResponse DefaultBankAccount { get; set; }

        /// <summary>
        /// Info about the recipient on the gateway
        /// </summary>
        [JsonProperty("gateway_recipients")]
        public List<Models.GetGatewayRecipientResponse> GatewayRecipients { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets AutomaticAnticipationSettings.
        /// </summary>
        [JsonProperty("automatic_anticipation_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetAutomaticAnticipationResponse AutomaticAnticipationSettings { get; set; }

        /// <summary>
        /// Gets or sets TransferSettings.
        /// </summary>
        [JsonProperty("transfer_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetTransferSettingsResponse TransferSettings { get; set; }

        /// <summary>
        /// Recipient code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("payment_mode")]
        public string PaymentMode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetRecipientResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetRecipientResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                this.DeletedAt.Equals(other.DeletedAt) &&
                ((this.DefaultBankAccount == null && other.DefaultBankAccount == null) || (this.DefaultBankAccount?.Equals(other.DefaultBankAccount) == true)) &&
                ((this.GatewayRecipients == null && other.GatewayRecipients == null) || (this.GatewayRecipients?.Equals(other.GatewayRecipients) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.AutomaticAnticipationSettings == null && other.AutomaticAnticipationSettings == null) || (this.AutomaticAnticipationSettings?.Equals(other.AutomaticAnticipationSettings) == true)) &&
                ((this.TransferSettings == null && other.TransferSettings == null) || (this.TransferSettings?.Equals(other.TransferSettings) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.PaymentMode == null && other.PaymentMode == null) || (this.PaymentMode?.Equals(other.PaymentMode) == true));
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
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document == string.Empty ? "" : this.Document)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.DeletedAt = {this.DeletedAt}");
            toStringOutput.Add($"this.DefaultBankAccount = {(this.DefaultBankAccount == null ? "null" : this.DefaultBankAccount.ToString())}");
            toStringOutput.Add($"this.GatewayRecipients = {(this.GatewayRecipients == null ? "null" : $"[{string.Join(", ", this.GatewayRecipients)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.AutomaticAnticipationSettings = {(this.AutomaticAnticipationSettings == null ? "null" : this.AutomaticAnticipationSettings.ToString())}");
            toStringOutput.Add($"this.TransferSettings = {(this.TransferSettings == null ? "null" : this.TransferSettings.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.PaymentMode = {(this.PaymentMode == null ? "null" : this.PaymentMode == string.Empty ? "" : this.PaymentMode)}");
        }
    }
}