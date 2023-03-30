// <copyright file="CreateRecipientRequest.cs" company="APIMatic">
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
    /// CreateRecipientRequest.
    /// </summary>
    public class CreateRecipientRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipientRequest"/> class.
        /// </summary>
        public CreateRecipientRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipientRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="description">description.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="defaultBankAccount">default_bank_account.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="code">code.</param>
        /// <param name="paymentMode">payment_mode.</param>
        /// <param name="transferSettings">transfer_settings.</param>
        public CreateRecipientRequest(
            string name,
            string email,
            string description,
            string document,
            string type,
            Models.CreateBankAccountRequest defaultBankAccount,
            Dictionary<string, string> metadata,
            string code,
            string paymentMode,
            Models.CreateTransferSettingsRequest transferSettings = null)
        {
            this.Name = name;
            this.Email = email;
            this.Description = description;
            this.Document = document;
            this.Type = type;
            this.DefaultBankAccount = defaultBankAccount;
            this.Metadata = metadata;
            this.TransferSettings = transferSettings;
            this.Code = code;
            this.PaymentMode = paymentMode;
        }

        /// <summary>
        /// Recipient name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Recipient email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Recipient description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Recipient document number
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Recipient type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Bank account
        /// </summary>
        [JsonProperty("default_bank_account")]
        public Models.CreateBankAccountRequest DefaultBankAccount { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Receiver Transfer Information
        /// </summary>
        [JsonProperty("transfer_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateTransferSettingsRequest TransferSettings { get; set; }

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

            return $"CreateRecipientRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateRecipientRequest other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.DefaultBankAccount == null && other.DefaultBankAccount == null) || (this.DefaultBankAccount?.Equals(other.DefaultBankAccount) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
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
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document == string.Empty ? "" : this.Document)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.DefaultBankAccount = {(this.DefaultBankAccount == null ? "null" : this.DefaultBankAccount.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.TransferSettings = {(this.TransferSettings == null ? "null" : this.TransferSettings.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.PaymentMode = {(this.PaymentMode == null ? "null" : this.PaymentMode == string.Empty ? "" : this.PaymentMode)}");
        }
    }
}