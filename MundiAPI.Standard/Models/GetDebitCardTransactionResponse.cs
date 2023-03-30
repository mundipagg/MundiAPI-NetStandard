// <copyright file="GetDebitCardTransactionResponse.cs" company="APIMatic">
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
    /// GetDebitCardTransactionResponse.
    /// </summary>
    public class GetDebitCardTransactionResponse : GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDebitCardTransactionResponse"/> class.
        /// </summary>
        public GetDebitCardTransactionResponse()
        {
            this.TransactionType = "debit_card";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDebitCardTransactionResponse"/> class.
        /// </summary>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="success">success.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="attemptCount">attempt_count.</param>
        /// <param name="maxAttempts">max_attempts.</param>
        /// <param name="splits">splits.</param>
        /// <param name="id">id.</param>
        /// <param name="gatewayResponse">gateway_response.</param>
        /// <param name="antifraudResponse">antifraud_response.</param>
        /// <param name="split">split.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="acquirerName">acquirer_name.</param>
        /// <param name="acquirerAffiliationCode">acquirer_affiliation_code.</param>
        /// <param name="acquirerTid">acquirer_tid.</param>
        /// <param name="acquirerNsu">acquirer_nsu.</param>
        /// <param name="acquirerAuthCode">acquirer_auth_code.</param>
        /// <param name="operationType">operation_type.</param>
        /// <param name="card">card.</param>
        /// <param name="acquirerMessage">acquirer_message.</param>
        /// <param name="acquirerReturnCode">acquirer_return_code.</param>
        /// <param name="mpi">mpi.</param>
        /// <param name="eci">eci.</param>
        /// <param name="authenticationType">authentication_type.</param>
        /// <param name="threedAuthenticationUrl">threed_authentication_url.</param>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public GetDebitCardTransactionResponse(
            string gatewayId,
            int amount,
            string status,
            bool success,
            DateTime createdAt,
            DateTime updatedAt,
            int attemptCount,
            int maxAttempts,
            List<Models.GetSplitResponse> splits,
            string id,
            Models.GetGatewayResponseResponse gatewayResponse,
            Models.GetAntifraudResponse antifraudResponse,
            List<Models.GetSplitResponse> split,
            string statementDescriptor,
            string acquirerName,
            string acquirerAffiliationCode,
            string acquirerTid,
            string acquirerNsu,
            string acquirerAuthCode,
            string operationType,
            Models.GetCardResponse card,
            string acquirerMessage,
            string acquirerReturnCode,
            string mpi,
            string eci,
            string authenticationType,
            string threedAuthenticationUrl,
            string transactionType = "debit_card",
            DateTime? nextAttempt = null,
            Dictionary<string, string> metadata = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null)
            : base(
                gatewayId,
                amount,
                status,
                success,
                createdAt,
                updatedAt,
                attemptCount,
                maxAttempts,
                splits,
                id,
                gatewayResponse,
                antifraudResponse,
                split,
                transactionType,
                nextAttempt,
                metadata,
                interest,
                fine,
                maxDaysToPayPastDue)
        {
            this.StatementDescriptor = statementDescriptor;
            this.AcquirerName = acquirerName;
            this.AcquirerAffiliationCode = acquirerAffiliationCode;
            this.AcquirerTid = acquirerTid;
            this.AcquirerNsu = acquirerNsu;
            this.AcquirerAuthCode = acquirerAuthCode;
            this.OperationType = operationType;
            this.Card = card;
            this.AcquirerMessage = acquirerMessage;
            this.AcquirerReturnCode = acquirerReturnCode;
            this.Mpi = mpi;
            this.Eci = eci;
            this.AuthenticationType = authenticationType;
            this.ThreedAuthenticationUrl = threedAuthenticationUrl;
        }

        /// <summary>
        /// Text that will appear on the debit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Acquirer name
        /// </summary>
        [JsonProperty("acquirer_name")]
        public string AcquirerName { get; set; }

        /// <summary>
        /// Aquirer affiliation code
        /// </summary>
        [JsonProperty("acquirer_affiliation_code")]
        public string AcquirerAffiliationCode { get; set; }

        /// <summary>
        /// Acquirer TID
        /// </summary>
        [JsonProperty("acquirer_tid")]
        public string AcquirerTid { get; set; }

        /// <summary>
        /// Acquirer NSU
        /// </summary>
        [JsonProperty("acquirer_nsu")]
        public string AcquirerNsu { get; set; }

        /// <summary>
        /// Acquirer authorization code
        /// </summary>
        [JsonProperty("acquirer_auth_code")]
        public string AcquirerAuthCode { get; set; }

        /// <summary>
        /// Operation type
        /// </summary>
        [JsonProperty("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card")]
        public Models.GetCardResponse Card { get; set; }

        /// <summary>
        /// Acquirer message
        /// </summary>
        [JsonProperty("acquirer_message")]
        public string AcquirerMessage { get; set; }

        /// <summary>
        /// Acquirer Return Code
        /// </summary>
        [JsonProperty("acquirer_return_code")]
        public string AcquirerReturnCode { get; set; }

        /// <summary>
        /// Merchant Plugin
        /// </summary>
        [JsonProperty("mpi")]
        public string Mpi { get; set; }

        /// <summary>
        /// Electronic Commerce Indicator (ECI)
        /// </summary>
        [JsonProperty("eci")]
        public string Eci { get; set; }

        /// <summary>
        /// Authentication type
        /// </summary>
        [JsonProperty("authentication_type")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// 3D-S Authentication Url
        /// </summary>
        [JsonProperty("threed_authentication_url")]
        public string ThreedAuthenticationUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetDebitCardTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetDebitCardTransactionResponse other &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.AcquirerName == null && other.AcquirerName == null) || (this.AcquirerName?.Equals(other.AcquirerName) == true)) &&
                ((this.AcquirerAffiliationCode == null && other.AcquirerAffiliationCode == null) || (this.AcquirerAffiliationCode?.Equals(other.AcquirerAffiliationCode) == true)) &&
                ((this.AcquirerTid == null && other.AcquirerTid == null) || (this.AcquirerTid?.Equals(other.AcquirerTid) == true)) &&
                ((this.AcquirerNsu == null && other.AcquirerNsu == null) || (this.AcquirerNsu?.Equals(other.AcquirerNsu) == true)) &&
                ((this.AcquirerAuthCode == null && other.AcquirerAuthCode == null) || (this.AcquirerAuthCode?.Equals(other.AcquirerAuthCode) == true)) &&
                ((this.OperationType == null && other.OperationType == null) || (this.OperationType?.Equals(other.OperationType) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.AcquirerMessage == null && other.AcquirerMessage == null) || (this.AcquirerMessage?.Equals(other.AcquirerMessage) == true)) &&
                ((this.AcquirerReturnCode == null && other.AcquirerReturnCode == null) || (this.AcquirerReturnCode?.Equals(other.AcquirerReturnCode) == true)) &&
                ((this.Mpi == null && other.Mpi == null) || (this.Mpi?.Equals(other.Mpi) == true)) &&
                ((this.Eci == null && other.Eci == null) || (this.Eci?.Equals(other.Eci) == true)) &&
                ((this.AuthenticationType == null && other.AuthenticationType == null) || (this.AuthenticationType?.Equals(other.AuthenticationType) == true)) &&
                ((this.ThreedAuthenticationUrl == null && other.ThreedAuthenticationUrl == null) || (this.ThreedAuthenticationUrl?.Equals(other.ThreedAuthenticationUrl) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.AcquirerName = {(this.AcquirerName == null ? "null" : this.AcquirerName == string.Empty ? "" : this.AcquirerName)}");
            toStringOutput.Add($"this.AcquirerAffiliationCode = {(this.AcquirerAffiliationCode == null ? "null" : this.AcquirerAffiliationCode == string.Empty ? "" : this.AcquirerAffiliationCode)}");
            toStringOutput.Add($"this.AcquirerTid = {(this.AcquirerTid == null ? "null" : this.AcquirerTid == string.Empty ? "" : this.AcquirerTid)}");
            toStringOutput.Add($"this.AcquirerNsu = {(this.AcquirerNsu == null ? "null" : this.AcquirerNsu == string.Empty ? "" : this.AcquirerNsu)}");
            toStringOutput.Add($"this.AcquirerAuthCode = {(this.AcquirerAuthCode == null ? "null" : this.AcquirerAuthCode == string.Empty ? "" : this.AcquirerAuthCode)}");
            toStringOutput.Add($"this.OperationType = {(this.OperationType == null ? "null" : this.OperationType == string.Empty ? "" : this.OperationType)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.AcquirerMessage = {(this.AcquirerMessage == null ? "null" : this.AcquirerMessage == string.Empty ? "" : this.AcquirerMessage)}");
            toStringOutput.Add($"this.AcquirerReturnCode = {(this.AcquirerReturnCode == null ? "null" : this.AcquirerReturnCode == string.Empty ? "" : this.AcquirerReturnCode)}");
            toStringOutput.Add($"this.Mpi = {(this.Mpi == null ? "null" : this.Mpi == string.Empty ? "" : this.Mpi)}");
            toStringOutput.Add($"this.Eci = {(this.Eci == null ? "null" : this.Eci == string.Empty ? "" : this.Eci)}");
            toStringOutput.Add($"this.AuthenticationType = {(this.AuthenticationType == null ? "null" : this.AuthenticationType == string.Empty ? "" : this.AuthenticationType)}");
            toStringOutput.Add($"this.ThreedAuthenticationUrl = {(this.ThreedAuthenticationUrl == null ? "null" : this.ThreedAuthenticationUrl == string.Empty ? "" : this.ThreedAuthenticationUrl)}");

            base.ToString(toStringOutput);
        }
    }
}