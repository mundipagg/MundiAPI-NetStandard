// <copyright file="ErrorException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Exceptions
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
    using MundiAPI.Standard.Http.Client;
    using MundiAPI.Standard.Models;
    using MundiAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ErrorException.
    /// </summary>
    public class ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public new string Message { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors")]
        public object Errors { get; set; }

        /// <summary>
        /// Gets or sets Request.
        /// </summary>
        [JsonProperty("request")]
        public object Request { get; set; }
    }
}