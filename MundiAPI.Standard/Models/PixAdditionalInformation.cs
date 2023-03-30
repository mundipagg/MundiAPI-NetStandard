// <copyright file="PixAdditionalInformation.cs" company="APIMatic">
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
    /// PixAdditionalInformation.
    /// </summary>
    public class PixAdditionalInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixAdditionalInformation"/> class.
        /// </summary>
        public PixAdditionalInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PixAdditionalInformation"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="mValue">Value.</param>
        public PixAdditionalInformation(
            string name,
            string mValue)
        {
            this.Name = name;
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("Value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PixAdditionalInformation : ({string.Join(", ", toStringOutput)})";
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

            return obj is PixAdditionalInformation other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
        }
    }
}