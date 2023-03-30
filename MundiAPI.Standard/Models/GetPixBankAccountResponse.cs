// <copyright file="GetPixBankAccountResponse.cs" company="APIMatic">
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
    /// GetPixBankAccountResponse.
    /// </summary>
    public class GetPixBankAccountResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixBankAccountResponse"/> class.
        /// </summary>
        public GetPixBankAccountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixBankAccountResponse"/> class.
        /// </summary>
        /// <param name="bankName">bank_name.</param>
        /// <param name="ispb">ispb.</param>
        /// <param name="branchCode">branch_code.</param>
        /// <param name="accountNumber">account_number.</param>
        public GetPixBankAccountResponse(
            string bankName = null,
            string ispb = null,
            string branchCode = null,
            string accountNumber = null)
        {
            this.BankName = bankName;
            this.Ispb = ispb;
            this.BranchCode = branchCode;
            this.AccountNumber = accountNumber;
        }

        /// <summary>
        /// Gets or sets BankName.
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Include)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets Ispb.
        /// </summary>
        [JsonProperty("ispb", NullValueHandling = NullValueHandling.Include)]
        public string Ispb { get; set; }

        /// <summary>
        /// Gets or sets BranchCode.
        /// </summary>
        [JsonProperty("branch_code", NullValueHandling = NullValueHandling.Include)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("account_number", NullValueHandling = NullValueHandling.Include)]
        public string AccountNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPixBankAccountResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPixBankAccountResponse other &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.Ispb == null && other.Ispb == null) || (this.Ispb?.Equals(other.Ispb) == true)) &&
                ((this.BranchCode == null && other.BranchCode == null) || (this.BranchCode?.Equals(other.BranchCode) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName == string.Empty ? "" : this.BankName)}");
            toStringOutput.Add($"this.Ispb = {(this.Ispb == null ? "null" : this.Ispb == string.Empty ? "" : this.Ispb)}");
            toStringOutput.Add($"this.BranchCode = {(this.BranchCode == null ? "null" : this.BranchCode == string.Empty ? "" : this.BranchCode)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber == string.Empty ? "" : this.AccountNumber)}");
        }
    }
}