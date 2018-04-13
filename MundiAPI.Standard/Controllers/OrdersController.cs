/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
    public partial class OrdersController: BaseController, IOrdersController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static OrdersController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static OrdersController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new OrdersController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public Models.GetOrderResponse GetOrder(string orderId)
        {
            Task<Models.GetOrderResponse> t = GetOrderAsync(orderId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public async Task<Models.GetOrderResponse> GetOrderAsync(string orderId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{order_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "order_id", orderId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public Models.GetOrderResponse CreateOrder(Models.CreateOrderRequest body)
        {
            Task<Models.GetOrderResponse> t = CreateOrderAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public async Task<Models.GetOrderResponse> CreateOrderAsync(Models.CreateOrderRequest body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public Models.GetOrderResponse UpdateOrderMetadata(string orderId, Models.UpdateMetadataRequest request)
        {
            Task<Models.GetOrderResponse> t = UpdateOrderMetadataAsync(orderId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public async Task<Models.GetOrderResponse> UpdateOrderMetadataAsync(string orderId, Models.UpdateMetadataRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Orders/{order_id}/metadata");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "order_id", orderId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for order's code</param>
        /// <param name="status">Optional parameter: Filter for order's status</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id</param>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        public Models.ListOrderResponse GetOrders(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null)
        {
            Task<Models.ListOrderResponse> t = GetOrdersAsync(page, size, code, status, createdSince, createdUntil, customerId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for order's code</param>
        /// <param name="status">Optional parameter: Filter for order's status</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id</param>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        public async Task<Models.ListOrderResponse> GetOrdersAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "status", status },
                { "created_since", (createdSince.HasValue) ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_until", (createdUntil.HasValue) ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "customer_id", customerId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ListOrderResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public Models.GetOrderItemResponse UpdateOrderItem(string orderId, string itemId, Models.UpdateOrderItemRequest request)
        {
            Task<Models.GetOrderItemResponse> t = UpdateOrderItemAsync(orderId, itemId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public async Task<Models.GetOrderItemResponse> UpdateOrderItemAsync(string orderId, string itemId, Models.UpdateOrderItemRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{orderId}/items/{itemId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "orderId", orderId },
                { "itemId", itemId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public Models.GetOrderItemResponse DeleteOrderItem(string orderId, string itemId)
        {
            Task<Models.GetOrderItemResponse> t = DeleteOrderItemAsync(orderId, itemId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public async Task<Models.GetOrderItemResponse> DeleteOrderItemAsync(string orderId, string itemId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{orderId}/items/{itemId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "orderId", orderId },
                { "itemId", itemId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public Models.GetOrderResponse DeleteAllOrderItems(string orderId)
        {
            Task<Models.GetOrderResponse> t = DeleteAllOrderItemsAsync(orderId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public async Task<Models.GetOrderResponse> DeleteAllOrderItemsAsync(string orderId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{orderId}/items");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "orderId", orderId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public Models.GetOrderItemResponse CreateOrderItem(string orderId, Models.CreateOrderItemRequest request)
        {
            Task<Models.GetOrderItemResponse> t = CreateOrderItemAsync(orderId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public async Task<Models.GetOrderItemResponse> CreateOrderItemAsync(string orderId, Models.CreateOrderItemRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{orderId}/items");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "orderId", orderId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public Models.GetOrderItemResponse GetOrderItem(string orderId, string itemId)
        {
            Task<Models.GetOrderItemResponse> t = GetOrderItemAsync(orderId, itemId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        public async Task<Models.GetOrderItemResponse> GetOrderItemAsync(string orderId, string itemId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{orderId}/items/{itemId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "orderId", orderId },
                { "itemId", itemId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public Models.GetOrderResponse UpdateOrderStatus(string id, Models.UpdateOrderStatusRequest request)
        {
            Task<Models.GetOrderResponse> t = UpdateOrderStatusAsync(id, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        public async Task<Models.GetOrderResponse> UpdateOrderStatusAsync(string id, Models.UpdateOrderStatusRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/{id}/closed");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrderResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 