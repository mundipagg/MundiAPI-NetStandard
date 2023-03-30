// <copyright file="CustomersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using MundiAPI.Standard;
    using MundiAPI.Standard.Authentication;
    using MundiAPI.Standard.Http.Client;
    using MundiAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// CustomersController.
    /// </summary>
    internal class CustomersController : BaseController, ICustomersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        internal CustomersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a access token for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating a access token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public Models.GetAccessTokenResponse CreateAccessToken(
                string customerId,
                Models.CreateAccessTokenRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateAccessTokenAsync(customerId, request, idempotencyKey));

        /// <summary>
        /// Creates a access token for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating a access token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public async Task<Models.GetAccessTokenResponse> CreateAccessTokenAsync(
                string customerId,
                Models.CreateAccessTokenRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAccessTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers/{customer_id}/access-tokens")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAccessTokenResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for updating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse UpdateCustomer(
                string customerId,
                Models.UpdateCustomerRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateCustomerAsync(customerId, request, idempotencyKey));

        /// <summary>
        /// Updates a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for updating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> UpdateCustomerAsync(
                string customerId,
                Models.UpdateCustomerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/customers/{customer_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete a Customer's access tokens.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public Models.ListAccessTokensResponse DeleteAccessTokens(
                string customerId)
            => CoreHelper.RunTask(DeleteAccessTokensAsync(customerId));

        /// <summary>
        /// Delete a Customer's access tokens.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public async Task<Models.ListAccessTokensResponse> DeleteAccessTokensAsync(
                string customerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListAccessTokensResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/access-tokens/")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListAccessTokensResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse GetCustomer(
                string customerId)
            => CoreHelper.RunTask(GetCustomerAsync(customerId));

        /// <summary>
        /// Get a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> GetCustomerAsync(
                string customerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets all adressess from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListAddressesResponse response from the API call.</returns>
        public Models.ListAddressesResponse GetAddresses(
                string customerId,
                int? page = null,
                int? size = null)
            => CoreHelper.RunTask(GetAddressesAsync(customerId, page, size));

        /// <summary>
        /// Gets all adressess from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAddressesResponse response from the API call.</returns>
        public async Task<Models.ListAddressesResponse> GetAddressesAsync(
                string customerId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListAddressesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/addresses")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListAddressesResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get a Customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public Models.GetAccessTokenResponse GetAccessToken(
                string customerId,
                string tokenId)
            => CoreHelper.RunTask(GetAccessTokenAsync(customerId, tokenId));

        /// <summary>
        /// Get a Customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public async Task<Models.GetAccessTokenResponse> GetAccessTokenAsync(
                string customerId,
                string tokenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAccessTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/access-tokens/{token_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("token_id", tokenId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAccessTokenResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get a customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse GetAddress(
                string customerId,
                string addressId)
            => CoreHelper.RunTask(GetAddressAsync(customerId, addressId));

        /// <summary>
        /// Get a customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> GetAddressAsync(
                string customerId,
                string addressId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAddressResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/addresses/{address_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("address_id", addressId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAddressResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new card for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for creating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse CreateCard(
                string customerId,
                Models.CreateCardRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateCardAsync(customerId, request, idempotencyKey));

        /// <summary>
        /// Creates a new card for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for creating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> CreateCardAsync(
                string customerId,
                Models.CreateCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers/{customer_id}/cards")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCardResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Renew a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse RenewCard(
                string customerId,
                string cardId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(RenewCardAsync(customerId, cardId, idempotencyKey));

        /// <summary>
        /// Renew a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> RenewCardAsync(
                string customerId,
                string cardId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers/{customer_id}/cards/{card_id}/renew")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("card_id", cardId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCardResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse CreateCustomer(
                Models.CreateCustomerRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateCustomerAsync(request, idempotencyKey));

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> CreateCustomerAsync(
                Models.CreateCustomerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates an address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="request">Required parameter: Request for updating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse UpdateAddress(
                string customerId,
                string addressId,
                Models.UpdateAddressRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateAddressAsync(customerId, addressId, request, idempotencyKey));

        /// <summary>
        /// Updates an address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="request">Required parameter: Request for updating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> UpdateAddressAsync(
                string customerId,
                string addressId,
                Models.UpdateAddressRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAddressResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/customers/{customer_id}/addresses/{address_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("address_id", addressId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAddressResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get all access tokens from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public Models.ListAccessTokensResponse GetAccessTokens(
                string customerId,
                int? page = null,
                int? size = null)
            => CoreHelper.RunTask(GetAccessTokensAsync(customerId, page, size));

        /// <summary>
        /// Get all access tokens from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public async Task<Models.ListAccessTokensResponse> GetAccessTokensAsync(
                string customerId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListAccessTokensResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/access-tokens")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListAccessTokensResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the metadata a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id.</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse UpdateCustomerMetadata(
                string customerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateCustomerMetadataAsync(customerId, request, idempotencyKey));

        /// <summary>
        /// Updates the metadata a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id.</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> UpdateCustomerMetadataAsync(
                string customerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/Customers/{customer_id}/metadata")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete a Customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse DeleteAddress(
                string customerId,
                string addressId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteAddressAsync(customerId, addressId, idempotencyKey));

        /// <summary>
        /// Delete a Customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> DeleteAddressAsync(
                string customerId,
                string addressId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAddressResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/customers/{customer_id}/addresses/{address_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("address_id", addressId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAddressResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse UpdateCard(
                string customerId,
                string cardId,
                Models.UpdateCardRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateCardAsync(customerId, cardId, request, idempotencyKey));

        /// <summary>
        /// Updates a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> UpdateCardAsync(
                string customerId,
                string cardId,
                Models.UpdateCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/customers/{customer_id}/cards/{card_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("card_id", cardId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCardResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete a customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public Models.GetAccessTokenResponse DeleteAccessToken(
                string customerId,
                string tokenId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteAccessTokenAsync(customerId, tokenId, idempotencyKey));

        /// <summary>
        /// Delete a customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public async Task<Models.GetAccessTokenResponse> DeleteAccessTokenAsync(
                string customerId,
                string tokenId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAccessTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/customers/{customer_id}/access-tokens/{token_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("token_id", tokenId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAccessTokenResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new address for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse CreateAddress(
                string customerId,
                Models.CreateAddressRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateAddressAsync(customerId, request, idempotencyKey));

        /// <summary>
        /// Creates a new address for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> CreateAddressAsync(
                string customerId,
                Models.CreateAddressRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAddressResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers/{customer_id}/addresses")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAddressResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse GetCard(
                string customerId,
                string cardId)
            => CoreHelper.RunTask(GetCardAsync(customerId, cardId));

        /// <summary>
        /// Get a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> GetCardAsync(
                string customerId,
                string cardId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/cards/{card_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("card_id", cardId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCardResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get all cards from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListCardsResponse response from the API call.</returns>
        public Models.ListCardsResponse GetCards(
                string customerId,
                int? page = null,
                int? size = null)
            => CoreHelper.RunTask(GetCardsAsync(customerId, page, size));

        /// <summary>
        /// Get all cards from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCardsResponse response from the API call.</returns>
        public async Task<Models.ListCardsResponse> GetCardsAsync(
                string customerId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListCardsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/cards")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListCardsResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse DeleteCard(
                string customerId,
                string cardId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteCardAsync(customerId, cardId, idempotencyKey));

        /// <summary>
        /// Delete a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> DeleteCardAsync(
                string customerId,
                string cardId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/customers/{customer_id}/cards/{card_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Template(_template => _template.Setup("card_id", cardId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetCardResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get all Customers.
        /// </summary>
        /// <param name="name">Optional parameter: Name of the Customer.</param>
        /// <param name="document">Optional parameter: Document of the Customer.</param>
        /// <param name="page">Optional parameter: Current page the the search.</param>
        /// <param name="size">Optional parameter: Quantity pages of the search.</param>
        /// <param name="email">Optional parameter: Customer's email.</param>
        /// <param name="code">Optional parameter: Customer's code.</param>
        /// <returns>Returns the Models.ListCustomersResponse response from the API call.</returns>
        public Models.ListCustomersResponse GetCustomers(
                string name = null,
                string document = null,
                int? page = 1,
                int? size = 10,
                string email = null,
                string code = null)
            => CoreHelper.RunTask(GetCustomersAsync(name, document, page, size, email, code));

        /// <summary>
        /// Get all Customers.
        /// </summary>
        /// <param name="name">Optional parameter: Name of the Customer.</param>
        /// <param name="document">Optional parameter: Document of the Customer.</param>
        /// <param name="page">Optional parameter: Current page the the search.</param>
        /// <param name="size">Optional parameter: Quantity pages of the search.</param>
        /// <param name="email">Optional parameter: Customer's email.</param>
        /// <param name="code">Optional parameter: Customer's code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCustomersResponse response from the API call.</returns>
        public async Task<Models.ListCustomersResponse> GetCustomersAsync(
                string name = null,
                string document = null,
                int? page = 1,
                int? size = 10,
                string email = null,
                string code = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListCustomersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("document", document))
                      .Query(_query => _query.Setup("page", (page != null) ? page : 1))
                      .Query(_query => _query.Setup("size", (size != null) ? size : 10))
                      .Query(_query => _query.Setup("email", email))
                      .Query(_query => _query.Setup("Code", code))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListCustomersResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}