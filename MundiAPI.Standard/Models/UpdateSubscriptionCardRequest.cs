// <copyright file="UpdateSubscriptionCardRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionCardRequest.
    /// </summary>
    public class UpdateSubscriptionCardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionCardRequest"/> class.
        /// </summary>
        public UpdateSubscriptionCardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionCardRequest"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="cardId">card_id.</param>
        public UpdateSubscriptionCardRequest(
            Models.CreateCardRequest card,
            string cardId)
        {
            this.Card = card;
            this.CardId = cardId;
        }

        /// <summary>
        /// Credit card data
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// Credit card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateSubscriptionCardRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateSubscriptionCardRequest other &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId == string.Empty ? "" : this.CardId)}");
        }
    }
}