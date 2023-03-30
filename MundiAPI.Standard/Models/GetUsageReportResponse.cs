// <copyright file="GetUsageReportResponse.cs" company="APIMatic">
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
    /// GetUsageReportResponse.
    /// </summary>
    public class GetUsageReportResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageReportResponse"/> class.
        /// </summary>
        public GetUsageReportResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageReportResponse"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="usageReportUrl">usage_report_url.</param>
        /// <param name="groupedReportUrl">grouped_report_url.</param>
        public GetUsageReportResponse(
            string url,
            string usageReportUrl,
            string groupedReportUrl)
        {
            this.Url = url;
            this.UsageReportUrl = usageReportUrl;
            this.GroupedReportUrl = groupedReportUrl;
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets UsageReportUrl.
        /// </summary>
        [JsonProperty("usage_report_url")]
        public string UsageReportUrl { get; set; }

        /// <summary>
        /// Gets or sets GroupedReportUrl.
        /// </summary>
        [JsonProperty("grouped_report_url")]
        public string GroupedReportUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetUsageReportResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetUsageReportResponse other &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.UsageReportUrl == null && other.UsageReportUrl == null) || (this.UsageReportUrl?.Equals(other.UsageReportUrl) == true)) &&
                ((this.GroupedReportUrl == null && other.GroupedReportUrl == null) || (this.GroupedReportUrl?.Equals(other.GroupedReportUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.UsageReportUrl = {(this.UsageReportUrl == null ? "null" : this.UsageReportUrl == string.Empty ? "" : this.UsageReportUrl)}");
            toStringOutput.Add($"this.GroupedReportUrl = {(this.GroupedReportUrl == null ? "null" : this.GroupedReportUrl == string.Empty ? "" : this.GroupedReportUrl)}");
        }
    }
}