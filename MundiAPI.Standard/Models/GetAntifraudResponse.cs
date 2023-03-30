// <copyright file="GetAntifraudResponse.cs" company="APIMatic">
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
    /// GetAntifraudResponse.
    /// </summary>
    public class GetAntifraudResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAntifraudResponse"/> class.
        /// </summary>
        public GetAntifraudResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAntifraudResponse"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="returnCode">return_code.</param>
        /// <param name="returnMessage">return_message.</param>
        /// <param name="providerName">provider_name.</param>
        /// <param name="score">score.</param>
        public GetAntifraudResponse(
            string status,
            string returnCode,
            string returnMessage,
            string providerName,
            string score)
        {
            this.Status = status;
            this.ReturnCode = returnCode;
            this.ReturnMessage = returnMessage;
            this.ProviderName = providerName;
            this.Score = score;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets ReturnCode.
        /// </summary>
        [JsonProperty("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// Gets or sets ReturnMessage.
        /// </summary>
        [JsonProperty("return_message")]
        public string ReturnMessage { get; set; }

        /// <summary>
        /// Gets or sets ProviderName.
        /// </summary>
        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or sets Score.
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAntifraudResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetAntifraudResponse other &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.ReturnCode == null && other.ReturnCode == null) || (this.ReturnCode?.Equals(other.ReturnCode) == true)) &&
                ((this.ReturnMessage == null && other.ReturnMessage == null) || (this.ReturnMessage?.Equals(other.ReturnMessage) == true)) &&
                ((this.ProviderName == null && other.ProviderName == null) || (this.ProviderName?.Equals(other.ProviderName) == true)) &&
                ((this.Score == null && other.Score == null) || (this.Score?.Equals(other.Score) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.ReturnCode = {(this.ReturnCode == null ? "null" : this.ReturnCode == string.Empty ? "" : this.ReturnCode)}");
            toStringOutput.Add($"this.ReturnMessage = {(this.ReturnMessage == null ? "null" : this.ReturnMessage == string.Empty ? "" : this.ReturnMessage)}");
            toStringOutput.Add($"this.ProviderName = {(this.ProviderName == null ? "null" : this.ProviderName == string.Empty ? "" : this.ProviderName)}");
            toStringOutput.Add($"this.Score = {(this.Score == null ? "null" : this.Score == string.Empty ? "" : this.Score)}");
        }
    }
}