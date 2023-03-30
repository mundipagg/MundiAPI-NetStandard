// <copyright file="UpdateCurrentCycleStatusRequest.cs" company="APIMatic">
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
    /// UpdateCurrentCycleStatusRequest.
    /// </summary>
    public class UpdateCurrentCycleStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrentCycleStatusRequest"/> class.
        /// </summary>
        public UpdateCurrentCycleStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrentCycleStatusRequest"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        public UpdateCurrentCycleStatusRequest(
            string status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateCurrentCycleStatusRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateCurrentCycleStatusRequest other &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}