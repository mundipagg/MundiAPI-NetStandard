// <copyright file="CreateAccessTokenRequest.cs" company="APIMatic">
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
    /// CreateAccessTokenRequest.
    /// </summary>
    public class CreateAccessTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessTokenRequest"/> class.
        /// </summary>
        public CreateAccessTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessTokenRequest"/> class.
        /// </summary>
        /// <param name="expiresIn">expires_in.</param>
        public CreateAccessTokenRequest(
            int? expiresIn = null)
        {
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Minutes to expire the token
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateAccessTokenRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateAccessTokenRequest other &&
                ((this.ExpiresIn == null && other.ExpiresIn == null) || (this.ExpiresIn?.Equals(other.ExpiresIn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExpiresIn = {(this.ExpiresIn == null ? "null" : this.ExpiresIn.ToString())}");
        }
    }
}