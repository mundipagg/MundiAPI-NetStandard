// <copyright file="BaseController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Controllers
{
    using APIMatic.Core;
    using APIMatic.Core.Response;
    using MundiAPI.Standard.Exceptions;
    using MundiAPI.Standard.Http.Client;
    using MundiAPI.Standard.Http.Request;
    using MundiAPI.Standard.Http.Response;
    using MundiAPI.Standard.Utilities;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The base class for all controller classes.
    /// </summary>
    internal class BaseController
    {
        private readonly GlobalConfiguration globalConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        internal BaseController(GlobalConfiguration config) => globalConfiguration = config;

        protected static ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException> CreateErrorCase(string reason, Func<string, HttpContext, ApiException> error, bool isErrorTemplate = false)
            => new ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>(reason, error, isErrorTemplate);

        protected ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T> CreateApiCall<T>()
            => new ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T>(
                globalConfiguration,
                compatibilityFactory,
                globalErrors: globalErrors
            );

        private static readonly CompatibilityFactory compatibilityFactory = new CompatibilityFactory();
        private static readonly Dictionary<string, ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>> globalErrors = new Dictionary<string, ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>>
        {
            { "400", CreateErrorCase("Invalid request", (reason, context) => new ErrorException(reason, context)) },
            { "401", CreateErrorCase("Invalid API key", (reason, context) => new ErrorException(reason, context)) },
            { "404", CreateErrorCase("An informed resource was not found", (reason, context) => new ErrorException(reason, context)) },
            { "412", CreateErrorCase("Business validation error", (reason, context) => new ErrorException(reason, context)) },
            { "422", CreateErrorCase("Contract validation error", (reason, context) => new ErrorException(reason, context)) },
            { "500", CreateErrorCase("Internal server error", (reason, context) => new ErrorException(reason, context)) }
        };
    }
}