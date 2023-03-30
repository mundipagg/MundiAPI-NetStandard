// <copyright file="UpdateAutomaticAnticipationSettingsRequest.cs" company="APIMatic">
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
    /// UpdateAutomaticAnticipationSettingsRequest.
    /// </summary>
    public class UpdateAutomaticAnticipationSettingsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutomaticAnticipationSettingsRequest"/> class.
        /// </summary>
        public UpdateAutomaticAnticipationSettingsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutomaticAnticipationSettingsRequest"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="type">type.</param>
        /// <param name="volumePercentage">volume_percentage.</param>
        /// <param name="delay">delay.</param>
        /// <param name="days">days.</param>
        public UpdateAutomaticAnticipationSettingsRequest(
            bool? enabled = null,
            string type = null,
            int? volumePercentage = null,
            int? delay = null,
            int? days = null)
        {
            this.Enabled = enabled;
            this.Type = type;
            this.VolumePercentage = volumePercentage;
            this.Delay = delay;
            this.Days = days;
        }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets VolumePercentage.
        /// </summary>
        [JsonProperty("volume_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumePercentage { get; set; }

        /// <summary>
        /// Gets or sets Delay.
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }

        /// <summary>
        /// Gets or sets Days.
        /// </summary>
        [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
        public int? Days { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateAutomaticAnticipationSettingsRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateAutomaticAnticipationSettingsRequest other &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.VolumePercentage == null && other.VolumePercentage == null) || (this.VolumePercentage?.Equals(other.VolumePercentage) == true)) &&
                ((this.Delay == null && other.Delay == null) || (this.Delay?.Equals(other.Delay) == true)) &&
                ((this.Days == null && other.Days == null) || (this.Days?.Equals(other.Days) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.VolumePercentage = {(this.VolumePercentage == null ? "null" : this.VolumePercentage.ToString())}");
            toStringOutput.Add($"this.Delay = {(this.Delay == null ? "null" : this.Delay.ToString())}");
            toStringOutput.Add($"this.Days = {(this.Days == null ? "null" : this.Days.ToString())}");
        }
    }
}