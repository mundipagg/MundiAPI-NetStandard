// <copyright file="CreateEmvDecryptRequest.cs" company="APIMatic">
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
    /// CreateEmvDecryptRequest.
    /// </summary>
    public class CreateEmvDecryptRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDecryptRequest"/> class.
        /// </summary>
        public CreateEmvDecryptRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDecryptRequest"/> class.
        /// </summary>
        /// <param name="iccData">icc_data.</param>
        /// <param name="cardSequenceNumber">card_sequence_number.</param>
        /// <param name="data">data.</param>
        /// <param name="poi">poi.</param>
        public CreateEmvDecryptRequest(
            string iccData,
            string cardSequenceNumber,
            Models.CreateEmvDataDecryptRequest data,
            Models.CreateCardPaymentContactlessPOIRequest poi = null)
        {
            this.IccData = iccData;
            this.CardSequenceNumber = cardSequenceNumber;
            this.Data = data;
            this.Poi = poi;
        }

        /// <summary>
        /// Gets or sets IccData.
        /// </summary>
        [JsonProperty("icc_data")]
        public string IccData { get; set; }

        /// <summary>
        /// Gets or sets CardSequenceNumber.
        /// </summary>
        [JsonProperty("card_sequence_number")]
        public string CardSequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.CreateEmvDataDecryptRequest Data { get; set; }

        /// <summary>
        /// Gets or sets Poi.
        /// </summary>
        [JsonProperty("poi", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardPaymentContactlessPOIRequest Poi { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateEmvDecryptRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateEmvDecryptRequest other &&
                ((this.IccData == null && other.IccData == null) || (this.IccData?.Equals(other.IccData) == true)) &&
                ((this.CardSequenceNumber == null && other.CardSequenceNumber == null) || (this.CardSequenceNumber?.Equals(other.CardSequenceNumber) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Poi == null && other.Poi == null) || (this.Poi?.Equals(other.Poi) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IccData = {(this.IccData == null ? "null" : this.IccData == string.Empty ? "" : this.IccData)}");
            toStringOutput.Add($"this.CardSequenceNumber = {(this.CardSequenceNumber == null ? "null" : this.CardSequenceNumber == string.Empty ? "" : this.CardSequenceNumber)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.Poi = {(this.Poi == null ? "null" : this.Poi.ToString())}");
        }
    }
}