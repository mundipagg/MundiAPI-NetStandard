// <copyright file="CreateBankAccountRequest.cs" company="APIMatic">
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
    /// CreateBankAccountRequest.
    /// </summary>
    public class CreateBankAccountRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBankAccountRequest"/> class.
        /// </summary>
        public CreateBankAccountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBankAccountRequest"/> class.
        /// </summary>
        /// <param name="holderName">holder_name.</param>
        /// <param name="holderType">holder_type.</param>
        /// <param name="holderDocument">holder_document.</param>
        /// <param name="bank">bank.</param>
        /// <param name="branchNumber">branch_number.</param>
        /// <param name="branchCheckDigit">branch_check_digit.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountCheckDigit">account_check_digit.</param>
        /// <param name="type">type.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="pixKey">pix_key.</param>
        public CreateBankAccountRequest(
            string holderName,
            string holderType,
            string holderDocument,
            string bank,
            string branchNumber,
            string branchCheckDigit,
            string accountNumber,
            string accountCheckDigit,
            string type,
            Dictionary<string, string> metadata,
            string pixKey)
        {
            this.HolderName = holderName;
            this.HolderType = holderType;
            this.HolderDocument = holderDocument;
            this.Bank = bank;
            this.BranchNumber = branchNumber;
            this.BranchCheckDigit = branchCheckDigit;
            this.AccountNumber = accountNumber;
            this.AccountCheckDigit = accountCheckDigit;
            this.Type = type;
            this.Metadata = metadata;
            this.PixKey = pixKey;
        }

        /// <summary>
        /// Bank account holder name
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        /// Bank account holder type
        /// </summary>
        [JsonProperty("holder_type")]
        public string HolderType { get; set; }

        /// <summary>
        /// Bank account holder document
        /// </summary>
        [JsonProperty("holder_document")]
        public string HolderDocument { get; set; }

        /// <summary>
        /// Bank
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// Branch number
        /// </summary>
        [JsonProperty("branch_number")]
        public string BranchNumber { get; set; }

        /// <summary>
        /// Branch check digit
        /// </summary>
        [JsonProperty("branch_check_digit")]
        public string BranchCheckDigit { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account check digit
        /// </summary>
        [JsonProperty("account_check_digit")]
        public string AccountCheckDigit { get; set; }

        /// <summary>
        /// Bank account type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Pix key
        /// </summary>
        [JsonProperty("pix_key")]
        public string PixKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateBankAccountRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateBankAccountRequest other &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.HolderType == null && other.HolderType == null) || (this.HolderType?.Equals(other.HolderType) == true)) &&
                ((this.HolderDocument == null && other.HolderDocument == null) || (this.HolderDocument?.Equals(other.HolderDocument) == true)) &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.BranchNumber == null && other.BranchNumber == null) || (this.BranchNumber?.Equals(other.BranchNumber) == true)) &&
                ((this.BranchCheckDigit == null && other.BranchCheckDigit == null) || (this.BranchCheckDigit?.Equals(other.BranchCheckDigit) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountCheckDigit == null && other.AccountCheckDigit == null) || (this.AccountCheckDigit?.Equals(other.AccountCheckDigit) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.PixKey == null && other.PixKey == null) || (this.PixKey?.Equals(other.PixKey) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.HolderType = {(this.HolderType == null ? "null" : this.HolderType == string.Empty ? "" : this.HolderType)}");
            toStringOutput.Add($"this.HolderDocument = {(this.HolderDocument == null ? "null" : this.HolderDocument == string.Empty ? "" : this.HolderDocument)}");
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank == string.Empty ? "" : this.Bank)}");
            toStringOutput.Add($"this.BranchNumber = {(this.BranchNumber == null ? "null" : this.BranchNumber == string.Empty ? "" : this.BranchNumber)}");
            toStringOutput.Add($"this.BranchCheckDigit = {(this.BranchCheckDigit == null ? "null" : this.BranchCheckDigit == string.Empty ? "" : this.BranchCheckDigit)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber == string.Empty ? "" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountCheckDigit = {(this.AccountCheckDigit == null ? "null" : this.AccountCheckDigit == string.Empty ? "" : this.AccountCheckDigit)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.PixKey = {(this.PixKey == null ? "null" : this.PixKey == string.Empty ? "" : this.PixKey)}");
        }
    }
}