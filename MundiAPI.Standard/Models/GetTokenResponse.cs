// <copyright file="GetTokenResponse.cs" company="APIMatic">
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
    /// GetTokenResponse.
    /// </summary>
    public class GetTokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenResponse"/> class.
        /// </summary>
        public GetTokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="card">card.</param>
        public GetTokenResponse(
            string id,
            string type,
            DateTime createdAt,
            string expiresAt,
            Models.GetCardTokenResponse card)
        {
            this.Id = id;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Card = card;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets Card.
        /// </summary>
        [JsonProperty("card")]
        public Models.GetCardTokenResponse Card { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTokenResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetTokenResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt == string.Empty ? "" : this.ExpiresAt)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
        }
    }
}