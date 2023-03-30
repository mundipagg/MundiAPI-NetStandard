// <copyright file="SubscriptionsController.cs" company="APIMatic">
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
    /// SubscriptionsController.
    /// </summary>
    internal class SubscriptionsController : BaseController, ISubscriptionsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsController"/> class.
        /// </summary>
        internal SubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a discount.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public Models.GetDiscountResponse CreateDiscount(
                string subscriptionId,
                Models.CreateDiscountRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateDiscountAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Creates a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a discount.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public async Task<Models.GetDiscountResponse> CreateDiscountAsync(
                string subscriptionId,
                Models.CreateDiscountRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetDiscountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/discounts")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetDiscountResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get Subscription Item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse GetSubscriptionItem(
                string subscriptionId,
                string itemId)
            => CoreHelper.RunTask(GetSubscriptionItemAsync(subscriptionId, itemId));

        /// <summary>
        /// Get Subscription Item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> GetSubscriptionItemAsync(
                string subscriptionId,
                string itemId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/items/{item_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("item_id", itemId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Deletes a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="usageId">Required parameter: The usage id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public Models.GetUsageResponse DeleteUsage(
                string subscriptionId,
                string itemId,
                string usageId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteUsageAsync(subscriptionId, itemId, usageId, idempotencyKey));

        /// <summary>
        /// Deletes a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="usageId">Required parameter: The usage id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public async Task<Models.GetUsageResponse> DeleteUsageAsync(
                string subscriptionId,
                string itemId,
                string usageId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetUsageResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/items/{item_id}/usages/{usage_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("item_id", itemId))
                      .Template(_template => _template.Setup("usage_id", usageId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetUsageResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Cancels a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse CancelSubscription(
                string subscriptionId,
                Models.CreateCancelSubscriptionRequest request = null,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CancelSubscriptionAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Cancels a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> CancelSubscriptionAsync(
                string subscriptionId,
                Models.CreateCancelSubscriptionRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Deletes a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="incrementId">Required parameter: Increment id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public Models.GetIncrementResponse DeleteIncrement(
                string subscriptionId,
                string incrementId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteIncrementAsync(subscriptionId, incrementId, idempotencyKey));

        /// <summary>
        /// Deletes a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="incrementId">Required parameter: Increment id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public async Task<Models.GetIncrementResponse> DeleteIncrementAsync(
                string subscriptionId,
                string incrementId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetIncrementResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/increments/{increment_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("increment_id", incrementId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetIncrementResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetSubscriptionCycleById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="cycleId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public Models.GetPeriodResponse GetSubscriptionCycleById(
                string subscriptionId,
                string cycleId)
            => CoreHelper.RunTask(GetSubscriptionCycleByIdAsync(subscriptionId, cycleId));

        /// <summary>
        /// GetSubscriptionCycleById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="cycleId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public async Task<Models.GetPeriodResponse> GetSubscriptionCycleByIdAsync(
                string subscriptionId,
                string cycleId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPeriodResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/cycles/{cycleId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("cycleId", cycleId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPeriodResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the start at date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionStartAt(
                string subscriptionId,
                Models.UpdateSubscriptionStartAtRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionStartAtAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Updates the start at date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionStartAtAsync(
                string subscriptionId,
                Models.UpdateSubscriptionStartAtRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/start-at")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the payment method from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionPaymentMethod(
                string subscriptionId,
                Models.UpdateSubscriptionPaymentMethodRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionPaymentMethodAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Updates the payment method from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethodAsync(
                string subscriptionId,
                Models.UpdateSubscriptionPaymentMethodRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/payment-method")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// UpdateCurrentCycleStatus EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request for updating the end date of the subscription current status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        public void UpdateCurrentCycleStatus(
                string subscriptionId,
                Models.UpdateCurrentCycleStatusRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunVoidTask(UpdateCurrentCycleStatusAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// UpdateCurrentCycleStatus EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request for updating the end date of the subscription current status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdateCurrentCycleStatusAsync(
                string subscriptionId,
                Models.UpdateCurrentCycleStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/cycle-status")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse CreateSubscription(
                Models.CreateSubscriptionRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateSubscriptionAsync(body, idempotencyKey));

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> CreateSubscriptionAsync(
                Models.CreateSubscriptionRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetUsagesDetails EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Identifier.</param>
        /// <param name="cycleId">Optional parameter: Cycle id.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="itemId">Optional parameter: Identificador do item.</param>
        /// <param name="mGroup">Optional parameter: identificador da loja (account) de cada item.</param>
        /// <returns>Returns the Models.GetUsagesDetailsResponse response from the API call.</returns>
        public Models.GetUsagesDetailsResponse GetUsagesDetails(
                string subscriptionId,
                string cycleId = null,
                int? size = null,
                int? page = null,
                string itemId = null,
                string mGroup = null)
            => CoreHelper.RunTask(GetUsagesDetailsAsync(subscriptionId, cycleId, size, page, itemId, mGroup));

        /// <summary>
        /// GetUsagesDetails EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Identifier.</param>
        /// <param name="cycleId">Optional parameter: Cycle id.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="itemId">Optional parameter: Identificador do item.</param>
        /// <param name="mGroup">Optional parameter: identificador da loja (account) de cada item.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsagesDetailsResponse response from the API call.</returns>
        public async Task<Models.GetUsagesDetailsResponse> GetUsagesDetailsAsync(
                string subscriptionId,
                string cycleId = null,
                int? size = null,
                int? page = null,
                string itemId = null,
                string mGroup = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetUsagesDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/usages-details/")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Query(_query => _query.Setup("cycle_id", cycleId))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("item_id", itemId))
                      .Query(_query => _query.Setup("group", mGroup))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetUsagesDetailsResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// RenewSubscription EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public Models.GetPeriodResponse RenewSubscription(
                string subscriptionId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(RenewSubscriptionAsync(subscriptionId, idempotencyKey));

        /// <summary>
        /// RenewSubscription EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public async Task<Models.GetPeriodResponse> RenewSubscriptionAsync(
                string subscriptionId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPeriodResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/cycles")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPeriodResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for updating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse UpdateSubscriptionItem(
                string subscriptionId,
                string itemId,
                Models.UpdateSubscriptionItemRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionItemAsync(subscriptionId, itemId, body, idempotencyKey));

        /// <summary>
        /// Updates a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for updating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> UpdateSubscriptionItemAsync(
                string subscriptionId,
                string itemId,
                Models.UpdateSubscriptionItemRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/items/{item_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("item_id", itemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create Usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public Models.GetUsageResponse CreateAnUsage(
                string subscriptionId,
                string itemId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateAnUsageAsync(subscriptionId, itemId, idempotencyKey));

        /// <summary>
        /// Create Usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public async Task<Models.GetUsageResponse> CreateAnUsageAsync(
                string subscriptionId,
                string itemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetUsageResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/items/{item_id}/usages")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("item_id", itemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetUsageResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetIncrementById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="incrementId">Required parameter: The increment Id.</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public Models.GetIncrementResponse GetIncrementById(
                string subscriptionId,
                string incrementId)
            => CoreHelper.RunTask(GetIncrementByIdAsync(subscriptionId, incrementId));

        /// <summary>
        /// GetIncrementById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="incrementId">Required parameter: The increment Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public async Task<Models.GetIncrementResponse> GetIncrementByIdAsync(
                string subscriptionId,
                string incrementId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetIncrementResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/increments/{increment_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("increment_id", incrementId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetIncrementResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Deletes a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="discountId">Required parameter: Discount Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public Models.GetDiscountResponse DeleteDiscount(
                string subscriptionId,
                string discountId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteDiscountAsync(subscriptionId, discountId, idempotencyKey));

        /// <summary>
        /// Deletes a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="discountId">Required parameter: Discount Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public async Task<Models.GetDiscountResponse> DeleteDiscountAsync(
                string subscriptionId,
                string discountId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetDiscountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/discounts/{discount_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("discount_id", discountId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetDiscountResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetIncrements EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListIncrementsResponse response from the API call.</returns>
        public Models.ListIncrementsResponse GetIncrements(
                string subscriptionId,
                int? page = null,
                int? size = null)
            => CoreHelper.RunTask(GetIncrementsAsync(subscriptionId, page, size));

        /// <summary>
        /// GetIncrements EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListIncrementsResponse response from the API call.</returns>
        public async Task<Models.ListIncrementsResponse> GetIncrementsAsync(
                string subscriptionId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListIncrementsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/increments/")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListIncrementsResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for creating a usage.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public Models.GetUsageResponse CreateUsage(
                string subscriptionId,
                string itemId,
                Models.CreateUsageRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateUsageAsync(subscriptionId, itemId, body, idempotencyKey));

        /// <summary>
        /// Creates a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for creating a usage.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public async Task<Models.GetUsageResponse> CreateUsageAsync(
                string subscriptionId,
                string itemId,
                Models.CreateUsageRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetUsageResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/items/{item_id}/usages")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("item_id", itemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetUsageResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new Subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse CreateSubscriptionItem(
                string subscriptionId,
                Models.CreateSubscriptionItemRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateSubscriptionItemAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Creates a new Subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> CreateSubscriptionItemAsync(
                string subscriptionId,
                Models.CreateSubscriptionItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/items")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Lists all usages from a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="mGroup">Optional parameter: Identification group in the client system.</param>
        /// <param name="usedSince">Optional parameter: Example: .</param>
        /// <param name="usedUntil">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListUsagesResponse response from the API call.</returns>
        public Models.ListUsagesResponse GetUsages(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mGroup = null,
                DateTime? usedSince = null,
                DateTime? usedUntil = null)
            => CoreHelper.RunTask(GetUsagesAsync(subscriptionId, itemId, page, size, code, mGroup, usedSince, usedUntil));

        /// <summary>
        /// Lists all usages from a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="mGroup">Optional parameter: Identification group in the client system.</param>
        /// <param name="usedSince">Optional parameter: Example: .</param>
        /// <param name="usedUntil">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListUsagesResponse response from the API call.</returns>
        public async Task<Models.ListUsagesResponse> GetUsagesAsync(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mGroup = null,
                DateTime? usedSince = null,
                DateTime? usedUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListUsagesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/items/{item_id}/usages")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("item_id", itemId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("code", code))
                      .Query(_query => _query.Setup("group", mGroup))
                      .Query(_query => _query.Setup("used_since", usedSince.HasValue ? usedSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("used_until", usedUntil.HasValue ? usedUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListUsagesResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the billing date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionBillingDate(
                string subscriptionId,
                Models.UpdateSubscriptionBillingDateRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionBillingDateAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Updates the billing date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionBillingDateAsync(
                string subscriptionId,
                Models.UpdateSubscriptionBillingDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/billing-date")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// UpdateLatestPeriodEndAt EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateLatestPeriodEndAt(
                string subscriptionId,
                Models.UpdateCurrentCycleEndDateRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateLatestPeriodEndAtAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// UpdateLatestPeriodEndAt EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateLatestPeriodEndAtAsync(
                string subscriptionId,
                Models.UpdateCurrentCycleEndDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/periods/latest/end-at")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetSubscriptionCycles EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <returns>Returns the Models.ListCyclesResponse response from the API call.</returns>
        public Models.ListCyclesResponse GetSubscriptionCycles(
                string subscriptionId,
                string page,
                string size)
            => CoreHelper.RunTask(GetSubscriptionCyclesAsync(subscriptionId, page, size));

        /// <summary>
        /// GetSubscriptionCycles EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCyclesResponse response from the API call.</returns>
        public async Task<Models.ListCyclesResponse> GetSubscriptionCyclesAsync(
                string subscriptionId,
                string page,
                string size,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListCyclesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/cycles")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListCyclesResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets all subscriptions.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for subscription's code.</param>
        /// <param name="billingType">Optional parameter: Filter for subscription's billing type.</param>
        /// <param name="customerId">Optional parameter: Filter for subscription's customer id.</param>
        /// <param name="planId">Optional parameter: Filter for subscription's plan id.</param>
        /// <param name="cardId">Optional parameter: Filter for subscription's card id.</param>
        /// <param name="status">Optional parameter: Filter for subscription's status.</param>
        /// <param name="nextBillingSince">Optional parameter: Filter for subscription's next billing date start range.</param>
        /// <param name="nextBillingUntil">Optional parameter: Filter for subscription's next billing date end range.</param>
        /// <param name="createdSince">Optional parameter: Filter for subscription's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for subscriptions creation date end range.</param>
        /// <returns>Returns the Models.ListSubscriptionsResponse response from the API call.</returns>
        public Models.ListSubscriptionsResponse GetSubscriptions(
                int? page = null,
                int? size = null,
                string code = null,
                string billingType = null,
                string customerId = null,
                string planId = null,
                string cardId = null,
                string status = null,
                DateTime? nextBillingSince = null,
                DateTime? nextBillingUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
            => CoreHelper.RunTask(GetSubscriptionsAsync(page, size, code, billingType, customerId, planId, cardId, status, nextBillingSince, nextBillingUntil, createdSince, createdUntil));

        /// <summary>
        /// Gets all subscriptions.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for subscription's code.</param>
        /// <param name="billingType">Optional parameter: Filter for subscription's billing type.</param>
        /// <param name="customerId">Optional parameter: Filter for subscription's customer id.</param>
        /// <param name="planId">Optional parameter: Filter for subscription's plan id.</param>
        /// <param name="cardId">Optional parameter: Filter for subscription's card id.</param>
        /// <param name="status">Optional parameter: Filter for subscription's status.</param>
        /// <param name="nextBillingSince">Optional parameter: Filter for subscription's next billing date start range.</param>
        /// <param name="nextBillingUntil">Optional parameter: Filter for subscription's next billing date end range.</param>
        /// <param name="createdSince">Optional parameter: Filter for subscription's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for subscriptions creation date end range.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSubscriptionsResponse response from the API call.</returns>
        public async Task<Models.ListSubscriptionsResponse> GetSubscriptionsAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string billingType = null,
                string customerId = null,
                string planId = null,
                string cardId = null,
                string status = null,
                DateTime? nextBillingSince = null,
                DateTime? nextBillingUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSubscriptionsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("code", code))
                      .Query(_query => _query.Setup("billing_type", billingType))
                      .Query(_query => _query.Setup("customer_id", customerId))
                      .Query(_query => _query.Setup("plan_id", planId))
                      .Query(_query => _query.Setup("card_id", cardId))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("next_billing_since", nextBillingSince.HasValue ? nextBillingSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("next_billing_until", nextBillingUntil.HasValue ? nextBillingUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListSubscriptionsResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetDiscountById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="discountId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public Models.GetDiscountResponse GetDiscountById(
                string subscriptionId,
                string discountId)
            => CoreHelper.RunTask(GetDiscountByIdAsync(subscriptionId, discountId));

        /// <summary>
        /// GetDiscountById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="discountId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public async Task<Models.GetDiscountResponse> GetDiscountByIdAsync(
                string subscriptionId,
                string discountId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetDiscountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/discounts/{discountId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("discountId", discountId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetDiscountResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get Subscription Items.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: The item name.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="status">Optional parameter: The item statis.</param>
        /// <param name="description">Optional parameter: The item description.</param>
        /// <param name="createdSince">Optional parameter: Filter for item's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for item's creation date end range.</param>
        /// <returns>Returns the Models.ListSubscriptionItemsResponse response from the API call.</returns>
        public Models.ListSubscriptionItemsResponse GetSubscriptionItems(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null)
            => CoreHelper.RunTask(GetSubscriptionItemsAsync(subscriptionId, page, size, name, code, status, description, createdSince, createdUntil));

        /// <summary>
        /// Get Subscription Items.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: The item name.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="status">Optional parameter: The item statis.</param>
        /// <param name="description">Optional parameter: The item description.</param>
        /// <param name="createdSince">Optional parameter: Filter for item's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for item's creation date end range.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSubscriptionItemsResponse response from the API call.</returns>
        public async Task<Models.ListSubscriptionItemsResponse> GetSubscriptionItemsAsync(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSubscriptionItemsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/items")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("code", code))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("description", description))
                      .Query(_query => _query.Setup("created_since", createdSince))
                      .Query(_query => _query.Setup("created_until", createdUntil))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListSubscriptionItemsResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Atualização do valor mínimo da assinatura.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionMiniumPrice(
                string subscriptionId,
                Models.UpdateSubscriptionMinimumPriceRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionMiniumPriceAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Atualização do valor mínimo da assinatura.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionMiniumPriceAsync(
                string subscriptionId,
                Models.UpdateSubscriptionMinimumPriceRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/minimum_price")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse GetSubscription(
                string subscriptionId)
            => CoreHelper.RunTask(GetSubscriptionAsync(subscriptionId));

        /// <summary>
        /// Gets a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> GetSubscriptionAsync(
                string subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// UpdateSubscriptionAffiliationId EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionAffiliationId(
                string subscriptionId,
                Models.UpdateSubscriptionAffiliationIdRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionAffiliationIdAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// UpdateSubscriptionAffiliationId EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionAffiliationIdAsync(
                string subscriptionId,
                Models.UpdateSubscriptionAffiliationIdRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/gateway-affiliation-id")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Deletes a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse DeleteSubscriptionItem(
                string subscriptionId,
                string subscriptionItemId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteSubscriptionItemAsync(subscriptionId, subscriptionItemId, idempotencyKey));

        /// <summary>
        /// Deletes a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> DeleteSubscriptionItemAsync(
                string subscriptionId,
                string subscriptionItemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/items/{subscription_item_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("subscription_item_id", subscriptionItemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the credit card from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionCard(
                string subscriptionId,
                Models.UpdateSubscriptionCardRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionCardAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Updates the credit card from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionCardAsync(
                string subscriptionId,
                Models.UpdateSubscriptionCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/card")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the metadata from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionMetadata(
                string subscriptionId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionMetadataAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Updates the metadata from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionMetadataAsync(
                string subscriptionId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/Subscriptions/{subscription_id}/metadata")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the boleto due days from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionDueDays(
                string subscriptionId,
                Models.UpdateSubscriptionDueDaysRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionDueDaysAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Updates the boleto due days from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionDueDaysAsync(
                string subscriptionId,
                Models.UpdateSubscriptionDueDaysRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{subscription_id}/boleto-due-days")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetDiscounts EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <returns>Returns the Models.ListDiscountsResponse response from the API call.</returns>
        public Models.ListDiscountsResponse GetDiscounts(
                string subscriptionId,
                int page,
                int size)
            => CoreHelper.RunTask(GetDiscountsAsync(subscriptionId, page, size));

        /// <summary>
        /// GetDiscounts EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListDiscountsResponse response from the API call.</returns>
        public async Task<Models.ListDiscountsResponse> GetDiscountsAsync(
                string subscriptionId,
                int page,
                int size,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListDiscountsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/discounts/")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListDiscountsResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a increment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public Models.GetIncrementResponse CreateIncrement(
                string subscriptionId,
                Models.CreateIncrementRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateIncrementAsync(subscriptionId, request, idempotencyKey));

        /// <summary>
        /// Creates a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a increment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public async Task<Models.GetIncrementResponse> CreateIncrementAsync(
                string subscriptionId,
                Models.CreateIncrementRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetIncrementResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/increments")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetIncrementResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetUsageReport EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="periodId">Required parameter: The period Id.</param>
        /// <returns>Returns the Models.GetUsageReportResponse response from the API call.</returns>
        public Models.GetUsageReportResponse GetUsageReport(
                string subscriptionId,
                string periodId)
            => CoreHelper.RunTask(GetUsageReportAsync(subscriptionId, periodId));

        /// <summary>
        /// GetUsageReport EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="periodId">Required parameter: The period Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageReportResponse response from the API call.</returns>
        public async Task<Models.GetUsageReportResponse> GetUsageReportAsync(
                string subscriptionId,
                string periodId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetUsageReportResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/periods/{period_id}/usages/report")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("period_id", periodId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetUsageReportResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// UpdateSplitSubscription EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Subscription's id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSplitSubscription(
                string id,
                Models.UpdateSubscriptionSplitRequest request)
            => CoreHelper.RunTask(UpdateSplitSubscriptionAsync(id, request));

        /// <summary>
        /// UpdateSplitSubscription EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Subscription's id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSplitSubscriptionAsync(
                string id,
                Models.UpdateSubscriptionSplitRequest request,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetSubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/subscriptions/{id}/split")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}