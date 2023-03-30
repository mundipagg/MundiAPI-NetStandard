// <copyright file="CreatePixPaymentRequest.cs" company="APIMatic">
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
    /// CreatePixPaymentRequest.
    /// </summary>
    public class CreatePixPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePixPaymentRequest"/> class.
        /// </summary>
        public CreatePixPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePixPaymentRequest"/> class.
        /// </summary>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="expiresIn">expires_in.</param>
        /// <param name="additionalInformation">additional_information.</param>
        public CreatePixPaymentRequest(
            DateTime? expiresAt = null,
            int? expiresIn = null,
            List<Models.PixAdditionalInformation> additionalInformation = null)
        {
            this.ExpiresAt = expiresAt;
            this.ExpiresIn = expiresIn;
            this.AdditionalInformation = additionalInformation;
        }

        /// <summary>
        /// Datetime when pix payment will expire
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Seconds until pix payment expires
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Pix additional information
        /// </summary>
        [JsonProperty("additional_information", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PixAdditionalInformation> AdditionalInformation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatePixPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreatePixPaymentRequest other &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.ExpiresIn == null && other.ExpiresIn == null) || (this.ExpiresIn?.Equals(other.ExpiresIn) == true)) &&
                ((this.AdditionalInformation == null && other.AdditionalInformation == null) || (this.AdditionalInformation?.Equals(other.AdditionalInformation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.ExpiresIn = {(this.ExpiresIn == null ? "null" : this.ExpiresIn.ToString())}");
            toStringOutput.Add($"this.AdditionalInformation = {(this.AdditionalInformation == null ? "null" : $"[{string.Join(", ", this.AdditionalInformation)} ]")}");
        }
    }
}