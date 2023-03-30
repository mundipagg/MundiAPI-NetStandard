// <copyright file="CreateClearSaleRequest.cs" company="APIMatic">
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
    /// CreateClearSaleRequest.
    /// </summary>
    public class CreateClearSaleRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClearSaleRequest"/> class.
        /// </summary>
        public CreateClearSaleRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClearSaleRequest"/> class.
        /// </summary>
        /// <param name="customSla">custom_sla.</param>
        public CreateClearSaleRequest(
            int customSla)
        {
            this.CustomSla = customSla;
        }

        /// <summary>
        /// Gets or sets CustomSla.
        /// </summary>
        [JsonProperty("custom_sla")]
        public int CustomSla { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateClearSaleRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateClearSaleRequest other &&
                this.CustomSla.Equals(other.CustomSla);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CustomSla = {this.CustomSla}");
        }
    }
}