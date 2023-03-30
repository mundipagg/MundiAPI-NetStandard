// <copyright file="GetThreeDSecureResponse.cs" company="APIMatic">
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
    /// GetThreeDSecureResponse.
    /// </summary>
    public class GetThreeDSecureResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetThreeDSecureResponse"/> class.
        /// </summary>
        public GetThreeDSecureResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetThreeDSecureResponse"/> class.
        /// </summary>
        /// <param name="mpi">mpi.</param>
        /// <param name="eci">eci.</param>
        /// <param name="cavv">cavv.</param>
        /// <param name="transactionId">transaction_Id.</param>
        /// <param name="successUrl">success_url.</param>
        public GetThreeDSecureResponse(
            string mpi,
            string eci,
            string cavv,
            string transactionId,
            string successUrl)
        {
            this.Mpi = mpi;
            this.Eci = eci;
            this.Cavv = cavv;
            this.TransactionId = transactionId;
            this.SuccessUrl = successUrl;
        }

        /// <summary>
        /// MPI Vendor
        /// </summary>
        [JsonProperty("mpi")]
        public string Mpi { get; set; }

        /// <summary>
        /// Electronic Commerce Indicator (ECI) (Opcional)
        /// </summary>
        [JsonProperty("eci")]
        public string Eci { get; set; }

        /// <summary>
        /// Online payment cryptogram, definido pelo 3-D Secure.
        /// </summary>
        [JsonProperty("cavv")]
        public string Cavv { get; set; }

        /// <summary>
        /// Identificador da transação (XID)
        /// </summary>
        [JsonProperty("transaction_Id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Url de redirecionamento de sucessso
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetThreeDSecureResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetThreeDSecureResponse other &&
                ((this.Mpi == null && other.Mpi == null) || (this.Mpi?.Equals(other.Mpi) == true)) &&
                ((this.Eci == null && other.Eci == null) || (this.Eci?.Equals(other.Eci) == true)) &&
                ((this.Cavv == null && other.Cavv == null) || (this.Cavv?.Equals(other.Cavv) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.SuccessUrl == null && other.SuccessUrl == null) || (this.SuccessUrl?.Equals(other.SuccessUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mpi = {(this.Mpi == null ? "null" : this.Mpi == string.Empty ? "" : this.Mpi)}");
            toStringOutput.Add($"this.Eci = {(this.Eci == null ? "null" : this.Eci == string.Empty ? "" : this.Eci)}");
            toStringOutput.Add($"this.Cavv = {(this.Cavv == null ? "null" : this.Cavv == string.Empty ? "" : this.Cavv)}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId == string.Empty ? "" : this.TransactionId)}");
            toStringOutput.Add($"this.SuccessUrl = {(this.SuccessUrl == null ? "null" : this.SuccessUrl == string.Empty ? "" : this.SuccessUrl)}");
        }
    }
}