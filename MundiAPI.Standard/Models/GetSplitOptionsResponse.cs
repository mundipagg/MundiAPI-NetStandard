// <copyright file="GetSplitOptionsResponse.cs" company="APIMatic">
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
    /// GetSplitOptionsResponse.
    /// </summary>
    public class GetSplitOptionsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitOptionsResponse"/> class.
        /// </summary>
        public GetSplitOptionsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitOptionsResponse"/> class.
        /// </summary>
        /// <param name="liable">liable.</param>
        /// <param name="chargeProcessingFee">charge_processing_fee.</param>
        /// <param name="chargeRemainderFee">charge_remainder_fee.</param>
        public GetSplitOptionsResponse(
            bool liable,
            bool chargeProcessingFee,
            string chargeRemainderFee)
        {
            this.Liable = liable;
            this.ChargeProcessingFee = chargeProcessingFee;
            this.ChargeRemainderFee = chargeRemainderFee;
        }

        /// <summary>
        /// Gets or sets Liable.
        /// </summary>
        [JsonProperty("liable")]
        public bool Liable { get; set; }

        /// <summary>
        /// Gets or sets ChargeProcessingFee.
        /// </summary>
        [JsonProperty("charge_processing_fee")]
        public bool ChargeProcessingFee { get; set; }

        /// <summary>
        /// Gets or sets ChargeRemainderFee.
        /// </summary>
        [JsonProperty("charge_remainder_fee")]
        public string ChargeRemainderFee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSplitOptionsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSplitOptionsResponse other &&
                this.Liable.Equals(other.Liable) &&
                this.ChargeProcessingFee.Equals(other.ChargeProcessingFee) &&
                ((this.ChargeRemainderFee == null && other.ChargeRemainderFee == null) || (this.ChargeRemainderFee?.Equals(other.ChargeRemainderFee) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Liable = {this.Liable}");
            toStringOutput.Add($"this.ChargeProcessingFee = {this.ChargeProcessingFee}");
            toStringOutput.Add($"this.ChargeRemainderFee = {(this.ChargeRemainderFee == null ? "null" : this.ChargeRemainderFee == string.Empty ? "" : this.ChargeRemainderFee)}");
        }
    }
}