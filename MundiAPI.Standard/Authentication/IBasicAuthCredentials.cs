// <copyright file="IBasicAuthCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Authentication
{
    using System;

    public interface IBasicAuthCredentials
    {
        /// <summary>
        /// Gets string value for basicAuthUserName.
        /// </summary>
        string BasicAuthUserName { get; }

        /// <summary>
        /// Gets string value for basicAuthPassword.
        /// </summary>
        string BasicAuthPassword { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="basicAuthUserName"> The string value for credentials.</param>
        /// <param name="basicAuthPassword"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string basicAuthUserName, string basicAuthPassword);
    }
}