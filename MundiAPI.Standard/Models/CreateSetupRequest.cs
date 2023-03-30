// <copyright file="CreateSetupRequest.cs" company="APIMatic">
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
    /// CreateSetupRequest.
    /// </summary>
    public class CreateSetupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupRequest"/> class.
        /// </summary>
        public CreateSetupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="payment">payment.</param>
        public CreateSetupRequest(
            int amount,
            string description,
            Models.CreatePaymentRequest payment)
        {
            this.Amount = amount;
            this.Description = description;
            this.Payment = payment;
        }

        /// <summary>
        /// Setup amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Payment data
        /// </summary>
        [JsonProperty("payment")]
        public Models.CreatePaymentRequest Payment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSetupRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateSetupRequest other &&
                this.Amount.Equals(other.Amount) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
        }
    }
}