// <copyright file="GetPhonesResponse.cs" company="APIMatic">
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
    /// GetPhonesResponse.
    /// </summary>
    public class GetPhonesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhonesResponse"/> class.
        /// </summary>
        public GetPhonesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhonesResponse"/> class.
        /// </summary>
        /// <param name="homePhone">home_phone.</param>
        /// <param name="mobilePhone">mobile_phone.</param>
        public GetPhonesResponse(
            Models.GetPhoneResponse homePhone,
            Models.GetPhoneResponse mobilePhone)
        {
            this.HomePhone = homePhone;
            this.MobilePhone = mobilePhone;
        }

        /// <summary>
        /// Gets or sets HomePhone.
        /// </summary>
        [JsonProperty("home_phone")]
        public Models.GetPhoneResponse HomePhone { get; set; }

        /// <summary>
        /// Gets or sets MobilePhone.
        /// </summary>
        [JsonProperty("mobile_phone")]
        public Models.GetPhoneResponse MobilePhone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPhonesResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPhonesResponse other &&
                ((this.HomePhone == null && other.HomePhone == null) || (this.HomePhone?.Equals(other.HomePhone) == true)) &&
                ((this.MobilePhone == null && other.MobilePhone == null) || (this.MobilePhone?.Equals(other.MobilePhone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HomePhone = {(this.HomePhone == null ? "null" : this.HomePhone.ToString())}");
            toStringOutput.Add($"this.MobilePhone = {(this.MobilePhone == null ? "null" : this.MobilePhone.ToString())}");
        }
    }
}