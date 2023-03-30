// <copyright file="CreateCashPaymentRequest.cs" company="APIMatic">
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
    /// CreateCashPaymentRequest.
    /// </summary>
    public class CreateCashPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCashPaymentRequest"/> class.
        /// </summary>
        public CreateCashPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCashPaymentRequest"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="confirm">confirm.</param>
        public CreateCashPaymentRequest(
            string description,
            bool confirm)
        {
            this.Description = description;
            this.Confirm = confirm;
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether cash collection will be confirmed in the act of creation
        /// </summary>
        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCashPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCashPaymentRequest other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Confirm.Equals(other.Confirm);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Confirm = {this.Confirm}");
        }
    }
}