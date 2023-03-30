// <copyright file="CreateTokenRequest.cs" company="APIMatic">
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
    /// CreateTokenRequest.
    /// </summary>
    public class CreateTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenRequest"/> class.
        /// </summary>
        public CreateTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="card">card.</param>
        public CreateTokenRequest(
            string type,
            Models.CreateCardTokenRequest card)
        {
            this.Type = type;
            this.Card = card;
        }

        /// <summary>
        /// Token type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardTokenRequest Card { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateTokenRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateTokenRequest other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
        }
    }
}