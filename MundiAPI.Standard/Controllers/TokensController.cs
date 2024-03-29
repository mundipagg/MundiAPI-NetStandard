/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using MundiAPI.Standard;
using MundiAPI.Standard.Utilities;
using MundiAPI.Standard.Http.Request;
using MundiAPI.Standard.Http.Response;
using MundiAPI.Standard.Http.Client;
using MundiAPI.Standard.Exceptions;

namespace MundiAPI.Standard.Controllers
{
    public partial class TokensController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TokensController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TokensController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TokensController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// CreateToken
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="body">Required parameter: Request for creating a token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.TokensResponse response from the API call</return>
        public Models.TokensResponse CreateToken(
                string publicKey,
                Models.TokensRequest body,
                string idempotencyKey = null,
                string appId = null)
        {
            Task<Models.TokensResponse> t = CreateTokenAsync(publicKey, body, idempotencyKey, appId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// CreateToken
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="body">Required parameter: Request for creating a token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.TokensResponse response from the API call</return>
        public async Task<Models.TokensResponse> CreateTokenAsync(
                string publicKey,
                Models.TokensRequest body,
                string idempotencyKey = null,
                string appId = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tokens");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "public_key", publicKey }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "appId", appId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 2.4.5" },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
                { "idempotency-key", idempotencyKey }
            };
            _headers.Add("ServiceRefererName", Configuration.ServiceRefererName);

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorException("Invalid request", _context);

            if (_response.StatusCode == 401)
                throw new ErrorException("Invalid API key", _context);

            if (_response.StatusCode == 404)
                throw new ErrorException("An informed resource was not found", _context);

            if (_response.StatusCode == 412)
                throw new ErrorException("Business validation error", _context);

            if (_response.StatusCode == 422)
                throw new ErrorException("Contract validation error", _context);

            if (_response.StatusCode == 500)
                throw new ErrorException("Internal server error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.TokensResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.TokensResponse response from the API call</return>
        public Models.TokensResponse GetToken(string id, string publicKey, string appId = null)
        {
            Task<Models.TokensResponse> t = GetTokenAsync(id, publicKey, appId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.TokensResponse response from the API call</return>
        public async Task<Models.TokensResponse> GetTokenAsync(string id, string publicKey, string appId = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tokens/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
                { "public_key", publicKey }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "appId", appId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 2.4.5" },
                { "accept", "application/json" }
            };
            _headers.Add("ServiceRefererName", Configuration.ServiceRefererName);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorException("Invalid request", _context);

            if (_response.StatusCode == 401)
                throw new ErrorException("Invalid API key", _context);

            if (_response.StatusCode == 404)
                throw new ErrorException("An informed resource was not found", _context);

            if (_response.StatusCode == 412)
                throw new ErrorException("Business validation error", _context);

            if (_response.StatusCode == 422)
                throw new ErrorException("Contract validation error", _context);

            if (_response.StatusCode == 500)
                throw new ErrorException("Internal server error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.TokensResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 