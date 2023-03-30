// <copyright file="UpdateAddressRequest.cs" company="APIMatic">
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
    /// UpdateAddressRequest.
    /// </summary>
    public class UpdateAddressRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAddressRequest"/> class.
        /// </summary>
        public UpdateAddressRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAddressRequest"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="complement">complement.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="line2">line_2.</param>
        public UpdateAddressRequest(
            string number,
            string complement,
            Dictionary<string, string> metadata,
            string line2)
        {
            this.Number = number;
            this.Complement = complement;
            this.Metadata = metadata;
            this.Line2 = line2;
        }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Complement
        /// </summary>
        [JsonProperty("complement")]
        public string Complement { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Line 2 for address
        /// </summary>
        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateAddressRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateAddressRequest other &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Complement == null && other.Complement == null) || (this.Complement?.Equals(other.Complement) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Line2 == null && other.Line2 == null) || (this.Line2?.Equals(other.Line2) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number == string.Empty ? "" : this.Number)}");
            toStringOutput.Add($"this.Complement = {(this.Complement == null ? "null" : this.Complement == string.Empty ? "" : this.Complement)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Line2 = {(this.Line2 == null ? "null" : this.Line2 == string.Empty ? "" : this.Line2)}");
        }
    }
}