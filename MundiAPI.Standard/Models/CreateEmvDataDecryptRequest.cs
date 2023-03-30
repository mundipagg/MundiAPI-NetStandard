// <copyright file="CreateEmvDataDecryptRequest.cs" company="APIMatic">
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
    /// CreateEmvDataDecryptRequest.
    /// </summary>
    public class CreateEmvDataDecryptRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataDecryptRequest"/> class.
        /// </summary>
        public CreateEmvDataDecryptRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataDecryptRequest"/> class.
        /// </summary>
        /// <param name="cipher">cipher.</param>
        /// <param name="tags">tags.</param>
        /// <param name="dukpt">dukpt.</param>
        public CreateEmvDataDecryptRequest(
            string cipher,
            List<Models.CreateEmvDataTlvDecryptRequest> tags,
            Models.CreateEmvDataDukptDecryptRequest dukpt = null)
        {
            this.Cipher = cipher;
            this.Dukpt = dukpt;
            this.Tags = tags;
        }

        /// <summary>
        /// Emv Decrypt cipher type
        /// </summary>
        [JsonProperty("cipher")]
        public string Cipher { get; set; }

        /// <summary>
        /// Dukpt data request
        /// </summary>
        [JsonProperty("dukpt", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateEmvDataDukptDecryptRequest Dukpt { get; set; }

        /// <summary>
        /// Encrypted tags list
        /// </summary>
        [JsonProperty("tags")]
        public List<Models.CreateEmvDataTlvDecryptRequest> Tags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateEmvDataDecryptRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateEmvDataDecryptRequest other &&
                ((this.Cipher == null && other.Cipher == null) || (this.Cipher?.Equals(other.Cipher) == true)) &&
                ((this.Dukpt == null && other.Dukpt == null) || (this.Dukpt?.Equals(other.Dukpt) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cipher = {(this.Cipher == null ? "null" : this.Cipher == string.Empty ? "" : this.Cipher)}");
            toStringOutput.Add($"this.Dukpt = {(this.Dukpt == null ? "null" : this.Dukpt.ToString())}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
        }
    }
}