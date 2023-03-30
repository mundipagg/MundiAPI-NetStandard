// <copyright file="UpdateChargeCardRequest.cs" company="APIMatic">
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
    /// UpdateChargeCardRequest.
    /// </summary>
    public class UpdateChargeCardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeCardRequest"/> class.
        /// </summary>
        public UpdateChargeCardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeCardRequest"/> class.
        /// </summary>
        /// <param name="updateSubscription">update_subscription.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="card">card.</param>
        /// <param name="recurrence">recurrence.</param>
        public UpdateChargeCardRequest(
            bool updateSubscription,
            string cardId,
            Models.CreateCardRequest card,
            bool recurrence)
        {
            this.UpdateSubscription = updateSubscription;
            this.CardId = cardId;
            this.Card = card;
            this.Recurrence = recurrence;
        }

        /// <summary>
        /// Indicates if the subscriptions using this card must also be updated
        /// </summary>
        [JsonProperty("update_subscription")]
        public bool UpdateSubscription { get; set; }

        /// <summary>
        /// Card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence")]
        public bool Recurrence { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateChargeCardRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UpdateChargeCardRequest other &&
                this.UpdateSubscription.Equals(other.UpdateSubscription) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                this.Recurrence.Equals(other.Recurrence);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UpdateSubscription = {this.UpdateSubscription}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId == string.Empty ? "" : this.CardId)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Recurrence = {this.Recurrence}");
        }
    }
}