// <copyright file="BasicAuthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using MundiAPI.Standard.Http.Request;
    using APIMatic.Core.Authentication;

    /// <summary>
    /// BasicAuthManager Class.
    /// </summary>
    internal class BasicAuthManager : AuthManager, IBasicAuthCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IrisBasicAuthManager"/> class.
        /// </summary>
        /// <param name="username"> Username.</param>
        /// <param name="password"> Password.</param>
        public BasicAuthManager(string username, string password)
        {
            this.BasicAuthUserName = username;
            this.BasicAuthPassword = password;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("Authorization", GetBasicAuthHeader())));
        }

        /// <summary>
        /// Gets string value for basicAuthUserName.
        /// </summary>
        public string BasicAuthUserName { get; }

        /// <summary>
        /// Gets string value for basicAuthPassword.
        /// </summary>
        public string BasicAuthPassword { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="basicAuthUserName"> The string value for credentials.</param>
        /// <param name="basicAuthPassword"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string basicAuthUserName, string basicAuthPassword)
        {
            return basicAuthUserName.Equals(this.BasicAuthUserName)
                    && basicAuthPassword.Equals(this.BasicAuthPassword);
        }

        private string GetBasicAuthHeader()
        {
            string authCredentials = this.BasicAuthUserName + ":" + this.BasicAuthPassword;
            byte[] data = Encoding.ASCII.GetBytes(authCredentials);
            return "Basic " + Convert.ToBase64String(data);
        }
    }
}