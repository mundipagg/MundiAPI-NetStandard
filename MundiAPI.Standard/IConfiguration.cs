// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard
{
    using System;
    using System.Net;
    using MundiAPI.Standard.Authentication;
    using MundiAPI.Standard.Models;

    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        IBasicAuthCredentials BasicAuthCredentials { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Default);
    }
}