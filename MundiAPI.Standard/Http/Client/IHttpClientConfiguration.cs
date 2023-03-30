// <copyright file="IHttpClientConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Http.Client
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using APIMatic.Core.Http.Configuration;

    /// <summary>
    /// Represents the current state of the Http Client.
    /// </summary>
    public interface IHttpClientConfiguration : ICoreHttpClientConfiguration { }
}
