// <copyright file="CreateEmvDataDukptDecryptRequest.cs" company="APIMatic">
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
    /// CreateEmvDataDukptDecryptRequest.
    /// </summary>
    public class CreateEmvDataDukptDecryptRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataDukptDecryptRequest"/> class.
        /// </summary>
        public CreateEmvDataDukptDecryptRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataDukptDecryptRequest"/> class.
        /// </summary>
        /// <param name="ksn">ksn.</param>
        public CreateEmvDataDukptDecryptRequest(
            string ksn)
        {
            this.Ksn = ksn;
        }

        /// <summary>
        /// Key serial number
        /// </summary>
        [JsonProperty("ksn")]
        public string Ksn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateEmvDataDukptDecryptRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateEmvDataDukptDecryptRequest other &&
                ((this.Ksn == null && other.Ksn == null) || (this.Ksn?.Equals(other.Ksn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ksn = {(this.Ksn == null ? "null" : this.Ksn == string.Empty ? "" : this.Ksn)}");
        }
    }
}