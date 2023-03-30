// <copyright file="CreateCancelChargeRequest.cs" company="APIMatic">
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
    /// CreateCancelChargeRequest.
    /// </summary>
    public class CreateCancelChargeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCancelChargeRequest"/> class.
        /// </summary>
        public CreateCancelChargeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCancelChargeRequest"/> class.
        /// </summary>
        /// <param name="operationReference">operation_reference.</param>
        /// <param name="amount">amount.</param>
        /// <param name="splitRules">split_rules.</param>
        /// <param name="split">split.</param>
        public CreateCancelChargeRequest(
            string operationReference,
            int? amount = null,
            List<Models.CreateCancelChargeSplitRulesRequest> splitRules = null,
            List<Models.CreateSplitRequest> split = null)
        {
            this.Amount = amount;
            this.SplitRules = splitRules;
            this.Split = split;
            this.OperationReference = operationReference;
        }

        /// <summary>
        /// The amount that will be canceled.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// The split rules request
        /// </summary>
        [JsonProperty("split_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateCancelChargeSplitRulesRequest> SplitRules { get; set; }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("split", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateSplitRequest> Split { get; set; }

        /// <summary>
        /// Gets or sets OperationReference.
        /// </summary>
        [JsonProperty("operation_reference")]
        public string OperationReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCancelChargeRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateCancelChargeRequest other &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.SplitRules == null && other.SplitRules == null) || (this.SplitRules?.Equals(other.SplitRules) == true)) &&
                ((this.Split == null && other.Split == null) || (this.Split?.Equals(other.Split) == true)) &&
                ((this.OperationReference == null && other.OperationReference == null) || (this.OperationReference?.Equals(other.OperationReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.SplitRules = {(this.SplitRules == null ? "null" : $"[{string.Join(", ", this.SplitRules)} ]")}");
            toStringOutput.Add($"this.Split = {(this.Split == null ? "null" : $"[{string.Join(", ", this.Split)} ]")}");
            toStringOutput.Add($"this.OperationReference = {(this.OperationReference == null ? "null" : this.OperationReference == string.Empty ? "" : this.OperationReference)}");
        }
    }
}