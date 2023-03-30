// <copyright file="GetAnticipationLimitResponse.cs" company="APIMatic">
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
    /// GetAnticipationLimitResponse.
    /// </summary>
    public class GetAnticipationLimitResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitResponse"/> class.
        /// </summary>
        public GetAnticipationLimitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="anticipationFee">anticipation_fee.</param>
        public GetAnticipationLimitResponse(
            int amount,
            int anticipationFee)
        {
            this.Amount = amount;
            this.AnticipationFee = anticipationFee;
        }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Anticipation fee
        /// </summary>
        [JsonProperty("anticipation_fee")]
        public int AnticipationFee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAnticipationLimitResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetAnticipationLimitResponse other &&
                this.Amount.Equals(other.Amount) &&
                this.AnticipationFee.Equals(other.AnticipationFee);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.AnticipationFee = {this.AnticipationFee}");
        }
    }
}