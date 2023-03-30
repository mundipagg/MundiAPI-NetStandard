// <copyright file="UpdateCurrentCycleEndDateRequest.cs" company="APIMatic">
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
    /// UpdateCurrentCycleEndDateRequest.
    /// </summary>
    public class UpdateCurrentCycleEndDateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrentCycleEndDateRequest"/> class.
        /// </summary>
        public UpdateCurrentCycleEndDateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrentCycleEndDateRequest"/> class.
        /// </summary>
        /// <param name="endAt">end_at.</param>
        public UpdateCurrentCycleEndDateRequest(
            DateTime? endAt = null)
        {
            this.EndAt = endAt;
        }

        /// <summary>
        /// Current cycle end date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateCurrentCycleEndDateRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateCurrentCycleEndDateRequest other &&
                ((this.EndAt == null && other.EndAt == null) || (this.EndAt?.Equals(other.EndAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EndAt = {(this.EndAt == null ? "null" : this.EndAt.ToString())}");
        }
    }
}