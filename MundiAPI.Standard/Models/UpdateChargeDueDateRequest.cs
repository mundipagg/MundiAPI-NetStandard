// <copyright file="UpdateChargeDueDateRequest.cs" company="APIMatic">
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
    /// UpdateChargeDueDateRequest.
    /// </summary>
    public class UpdateChargeDueDateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeDueDateRequest"/> class.
        /// </summary>
        public UpdateChargeDueDateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeDueDateRequest"/> class.
        /// </summary>
        /// <param name="dueAt">due_at.</param>
        public UpdateChargeDueDateRequest(
            DateTime? dueAt = null)
        {
            this.DueAt = dueAt;
        }

        /// <summary>
        /// The charge's new due date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateChargeDueDateRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateChargeDueDateRequest other &&
                ((this.DueAt == null && other.DueAt == null) || (this.DueAt?.Equals(other.DueAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
        }
    }
}