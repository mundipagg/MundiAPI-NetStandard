// <copyright file="GetAnticipationResponse.cs" company="APIMatic">
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
    /// GetAnticipationResponse.
    /// </summary>
    public class GetAnticipationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationResponse"/> class.
        /// </summary>
        public GetAnticipationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="requestedAmount">requested_amount.</param>
        /// <param name="approvedAmount">approved_amount.</param>
        /// <param name="pgid">pgid.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="paymentDate">payment_date.</param>
        /// <param name="status">status.</param>
        /// <param name="timeframe">timeframe.</param>
        /// <param name="recipient">recipient.</param>
        public GetAnticipationResponse(
            string id,
            int requestedAmount,
            int approvedAmount,
            string pgid,
            DateTime createdAt,
            DateTime updatedAt,
            DateTime paymentDate,
            string status,
            string timeframe,
            Models.GetRecipientResponse recipient = null)
        {
            this.Id = id;
            this.RequestedAmount = requestedAmount;
            this.ApprovedAmount = approvedAmount;
            this.Recipient = recipient;
            this.Pgid = pgid;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PaymentDate = paymentDate;
            this.Status = status;
            this.Timeframe = timeframe;
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Requested amount
        /// </summary>
        [JsonProperty("requested_amount")]
        public int RequestedAmount { get; set; }

        /// <summary>
        /// Approved amount
        /// </summary>
        [JsonProperty("approved_amount")]
        public int ApprovedAmount { get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetRecipientResponse Recipient { get; set; }

        /// <summary>
        /// Anticipation id on the gateway
        /// </summary>
        [JsonProperty("pgid")]
        public string Pgid { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date")]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timeframe
        /// </summary>
        [JsonProperty("timeframe")]
        public string Timeframe { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAnticipationResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetAnticipationResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.RequestedAmount.Equals(other.RequestedAmount) &&
                this.ApprovedAmount.Equals(other.ApprovedAmount) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.Pgid == null && other.Pgid == null) || (this.Pgid?.Equals(other.Pgid) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                this.PaymentDate.Equals(other.PaymentDate) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Timeframe == null && other.Timeframe == null) || (this.Timeframe?.Equals(other.Timeframe) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.RequestedAmount = {this.RequestedAmount}");
            toStringOutput.Add($"this.ApprovedAmount = {this.ApprovedAmount}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"this.Pgid = {(this.Pgid == null ? "null" : this.Pgid == string.Empty ? "" : this.Pgid)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.PaymentDate = {this.PaymentDate}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Timeframe = {(this.Timeframe == null ? "null" : this.Timeframe == string.Empty ? "" : this.Timeframe)}");
        }
    }
}