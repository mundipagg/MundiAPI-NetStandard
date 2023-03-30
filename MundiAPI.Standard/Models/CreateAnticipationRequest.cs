// <copyright file="CreateAnticipationRequest.cs" company="APIMatic">
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
    /// CreateAnticipationRequest.
    /// </summary>
    public class CreateAnticipationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnticipationRequest"/> class.
        /// </summary>
        public CreateAnticipationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnticipationRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="timeframe">timeframe.</param>
        /// <param name="paymentDate">payment_date.</param>
        public CreateAnticipationRequest(
            int amount,
            string timeframe,
            DateTime paymentDate)
        {
            this.Amount = amount;
            this.Timeframe = timeframe;
            this.PaymentDate = paymentDate;
        }

        /// <summary>
        /// Amount requested for the anticipation
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Timeframe
        /// </summary>
        [JsonProperty("timeframe")]
        public string Timeframe { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date")]
        public DateTime PaymentDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateAnticipationRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateAnticipationRequest other &&
                this.Amount.Equals(other.Amount) &&
                ((this.Timeframe == null && other.Timeframe == null) || (this.Timeframe?.Equals(other.Timeframe) == true)) &&
                this.PaymentDate.Equals(other.PaymentDate);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Timeframe = {(this.Timeframe == null ? "null" : this.Timeframe == string.Empty ? "" : this.Timeframe)}");
            toStringOutput.Add($"this.PaymentDate = {this.PaymentDate}");
        }
    }
}