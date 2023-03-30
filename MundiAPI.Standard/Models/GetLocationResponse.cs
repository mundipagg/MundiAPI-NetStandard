// <copyright file="GetLocationResponse.cs" company="APIMatic">
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
    /// GetLocationResponse.
    /// </summary>
    public class GetLocationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLocationResponse"/> class.
        /// </summary>
        public GetLocationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLocationResponse"/> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public GetLocationResponse(
            string latitude,
            string longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetLocationResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetLocationResponse other &&
                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude == string.Empty ? "" : this.Latitude)}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude == string.Empty ? "" : this.Longitude)}");
        }
    }
}