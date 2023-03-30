// <copyright file="GetTransferSettingsResponse.cs" company="APIMatic">
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
    /// GetTransferSettingsResponse.
    /// </summary>
    public class GetTransferSettingsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferSettingsResponse"/> class.
        /// </summary>
        public GetTransferSettingsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferSettingsResponse"/> class.
        /// </summary>
        /// <param name="transferEnabled">transfer_enabled.</param>
        /// <param name="transferInterval">transfer_interval.</param>
        /// <param name="transferDay">transfer_day.</param>
        public GetTransferSettingsResponse(
            bool transferEnabled,
            string transferInterval,
            int transferDay)
        {
            this.TransferEnabled = transferEnabled;
            this.TransferInterval = transferInterval;
            this.TransferDay = transferDay;
        }

        /// <summary>
        /// Gets or sets TransferEnabled.
        /// </summary>
        [JsonProperty("transfer_enabled")]
        public bool TransferEnabled { get; set; }

        /// <summary>
        /// Gets or sets TransferInterval.
        /// </summary>
        [JsonProperty("transfer_interval")]
        public string TransferInterval { get; set; }

        /// <summary>
        /// Gets or sets TransferDay.
        /// </summary>
        [JsonProperty("transfer_day")]
        public int TransferDay { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTransferSettingsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetTransferSettingsResponse other &&
                this.TransferEnabled.Equals(other.TransferEnabled) &&
                ((this.TransferInterval == null && other.TransferInterval == null) || (this.TransferInterval?.Equals(other.TransferInterval) == true)) &&
                this.TransferDay.Equals(other.TransferDay);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransferEnabled = {this.TransferEnabled}");
            toStringOutput.Add($"this.TransferInterval = {(this.TransferInterval == null ? "null" : this.TransferInterval == string.Empty ? "" : this.TransferInterval)}");
            toStringOutput.Add($"this.TransferDay = {this.TransferDay}");
        }
    }
}