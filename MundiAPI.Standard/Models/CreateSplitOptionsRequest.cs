// <copyright file="CreateSplitOptionsRequest.cs" company="APIMatic">
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
    /// CreateSplitOptionsRequest.
    /// </summary>
    public class CreateSplitOptionsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSplitOptionsRequest"/> class.
        /// </summary>
        public CreateSplitOptionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSplitOptionsRequest"/> class.
        /// </summary>
        /// <param name="liable">liable.</param>
        /// <param name="chargeProcessingFee">charge_processing_fee.</param>
        /// <param name="chargeRemainderFee">charge_remainder_fee.</param>
        public CreateSplitOptionsRequest(
            bool? liable = null,
            bool? chargeProcessingFee = null,
            bool? chargeRemainderFee = null)
        {
            this.Liable = liable;
            this.ChargeProcessingFee = chargeProcessingFee;
            this.ChargeRemainderFee = chargeRemainderFee;
        }

        /// <summary>
        /// Liable options
        /// </summary>
        [JsonProperty("liable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Liable { get; set; }

        /// <summary>
        /// Charge processing fee
        /// </summary>
        [JsonProperty("charge_processing_fee", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChargeProcessingFee { get; set; }

        /// <summary>
        /// Gets or sets ChargeRemainderFee.
        /// </summary>
        [JsonProperty("charge_remainder_fee", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChargeRemainderFee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSplitOptionsRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateSplitOptionsRequest other &&
                ((this.Liable == null && other.Liable == null) || (this.Liable?.Equals(other.Liable) == true)) &&
                ((this.ChargeProcessingFee == null && other.ChargeProcessingFee == null) || (this.ChargeProcessingFee?.Equals(other.ChargeProcessingFee) == true)) &&
                ((this.ChargeRemainderFee == null && other.ChargeRemainderFee == null) || (this.ChargeRemainderFee?.Equals(other.ChargeRemainderFee) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Liable = {(this.Liable == null ? "null" : this.Liable.ToString())}");
            toStringOutput.Add($"this.ChargeProcessingFee = {(this.ChargeProcessingFee == null ? "null" : this.ChargeProcessingFee.ToString())}");
            toStringOutput.Add($"this.ChargeRemainderFee = {(this.ChargeRemainderFee == null ? "null" : this.ChargeRemainderFee.ToString())}");
        }
    }
}