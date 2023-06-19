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
    public partial class InvoicesController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static InvoicesController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static InvoicesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new InvoicesController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="cycleId">Required parameter: Cycle Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <param name="body">Optional parameter: Example: </param>
        /// <return>Returns the Models.SubscriptionsCyclesPayResponse response from the API call</return>
        public Models.SubscriptionsCyclesPayResponse CreateInvoice(
                string subscriptionId,
                string cycleId,
                string idempotencyKey = null,
                Models.SubscriptionsCyclesPayRequest body = null)
        {
            Task<Models.SubscriptionsCyclesPayResponse> t = CreateInvoiceAsync(subscriptionId, cycleId, idempotencyKey, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="cycleId">Required parameter: Cycle Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <param name="body">Optional parameter: Example: </param>
        /// <return>Returns the Models.SubscriptionsCyclesPayResponse response from the API call</return>
        public async Task<Models.SubscriptionsCyclesPayResponse> CreateInvoiceAsync(
                string subscriptionId,
                string cycleId,
                string idempotencyKey = null,
                Models.SubscriptionsCyclesPayRequest body = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/subscriptions/{subscription_id}/cycles/{cycle_id}/pay");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "cycle_id", cycleId }
            });


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
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
                return APIHelper.JsonDeserialize<Models.SubscriptionsCyclesPayResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// GetPartialInvoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <return>Returns the Models.SubscriptionsPartialInvoiceResponse response from the API call</return>
        public Models.SubscriptionsPartialInvoiceResponse GetPartialInvoice(string subscriptionId)
        {
            Task<Models.SubscriptionsPartialInvoiceResponse> t = GetPartialInvoiceAsync(subscriptionId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetPartialInvoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <return>Returns the Models.SubscriptionsPartialInvoiceResponse response from the API call</return>
        public async Task<Models.SubscriptionsPartialInvoiceResponse> GetPartialInvoiceAsync(string subscriptionId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/subscriptions/{subscription_id}/partial-invoice");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId }
            });


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
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
                return APIHelper.JsonDeserialize<Models.SubscriptionsPartialInvoiceResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates the status from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <param name="body">Required parameter: Request for updating an invoice's status</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.InvoicesStatusResponse response from the API call</return>
        public Models.InvoicesStatusResponse UpdateInvoiceStatus(string invoiceId, Models.UpdateCurrentCycleStatusRequest body, string idempotencyKey = null)
        {
            Task<Models.InvoicesStatusResponse> t = UpdateInvoiceStatusAsync(invoiceId, body, idempotencyKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the status from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <param name="body">Required parameter: Request for updating an invoice's status</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.InvoicesStatusResponse response from the API call</return>
        public async Task<Models.InvoicesStatusResponse> UpdateInvoiceStatusAsync(string invoiceId, Models.UpdateCurrentCycleStatusRequest body, string idempotencyKey = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}/status");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
            });


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
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
                return APIHelper.JsonDeserialize<Models.InvoicesStatusResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns the Models.InvoicesResponse response from the API call</return>
        public Models.InvoicesResponse GetInvoice(string invoiceId)
        {
            Task<Models.InvoicesResponse> t = GetInvoiceAsync(invoiceId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns the Models.InvoicesResponse response from the API call</return>
        public async Task<Models.InvoicesResponse> GetInvoiceAsync(string invoiceId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
            });


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
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
                return APIHelper.JsonDeserialize<Models.InvoicesResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.InvoicesResponse response from the API call</return>
        public Models.InvoicesResponse CancelInvoice(string invoiceId, string idempotencyKey = null)
        {
            Task<Models.InvoicesResponse> t = CancelInvoiceAsync(invoiceId, idempotencyKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.InvoicesResponse response from the API call</return>
        public async Task<Models.InvoicesResponse> CancelInvoiceAsync(string invoiceId, string idempotencyKey = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 2.4.5" },
                { "accept", "application/json" },
                { "idempotency-key", idempotencyKey }
            };
            _headers.Add("ServiceRefererName", Configuration.ServiceRefererName);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
                return APIHelper.JsonDeserialize<Models.InvoicesResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="body">Required parameter: Request for updating the invoice metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.InvoicesMetadataResponse response from the API call</return>
        public Models.InvoicesMetadataResponse UpdateInvoiceMetadata(string invoiceId, Models.InvoicesMetadataRequest body, string idempotencyKey = null)
        {
            Task<Models.InvoicesMetadataResponse> t = UpdateInvoiceMetadataAsync(invoiceId, body, idempotencyKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="body">Required parameter: Request for updating the invoice metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.InvoicesMetadataResponse response from the API call</return>
        public async Task<Models.InvoicesMetadataResponse> UpdateInvoiceMetadataAsync(string invoiceId, Models.InvoicesMetadataRequest body, string idempotencyKey = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}/metadata");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
            });


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
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
                return APIHelper.JsonDeserialize<Models.InvoicesMetadataResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets all invoices
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range</param>
        /// <param name="customerDocument">Optional parameter: Fillter for invoice's document</param>
        /// <return>Returns the Models.InvoicesResponse2 response from the API call</return>
        public Models.InvoicesResponse2 GetInvoices(
                int? page = null,
                int? size = null,
                string code = null,
                string customerId = null,
                string subscriptionId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string status = null,
                DateTime? dueSince = null,
                DateTime? dueUntil = null,
                string customerDocument = null)
        {
            Task<Models.InvoicesResponse2> t = GetInvoicesAsync(page, size, code, customerId, subscriptionId, createdSince, createdUntil, status, dueSince, dueUntil, customerDocument);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all invoices
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range</param>
        /// <param name="customerDocument">Optional parameter: Fillter for invoice's document</param>
        /// <return>Returns the Models.InvoicesResponse2 response from the API call</return>
        public async Task<Models.InvoicesResponse2> GetInvoicesAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string customerId = null,
                string subscriptionId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string status = null,
                DateTime? dueSince = null,
                DateTime? dueUntil = null,
                string customerDocument = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "customer_id", customerId },
                { "subscription_id", subscriptionId },
                { "created_since", (createdSince.HasValue) ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_until", (createdUntil.HasValue) ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "status", status },
                { "due_since", (dueSince.HasValue) ? dueSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "due_until", (dueUntil.HasValue) ? dueUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "customer_document", customerDocument }
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
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
                return APIHelper.JsonDeserialize<Models.InvoicesResponse2>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 