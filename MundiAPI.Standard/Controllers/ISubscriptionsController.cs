// <copyright file="ISubscriptionsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using MundiAPI.Standard;
    using MundiAPI.Standard.Http.Client;
    using MundiAPI.Standard.Http.Request;
    using MundiAPI.Standard.Http.Response;
    using MundiAPI.Standard.Utilities;

    /// <summary>
    /// ISubscriptionsController.
    /// </summary>
    public interface ISubscriptionsController
    {
        /// <summary>
        /// Creates a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a discount.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        Models.GetDiscountResponse CreateDiscount(
                string subscriptionId,
                Models.CreateDiscountRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a discount.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        Task<Models.GetDiscountResponse> CreateDiscountAsync(
                string subscriptionId,
                Models.CreateDiscountRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Subscription Item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Models.GetSubscriptionItemResponse GetSubscriptionItem(
                string subscriptionId,
                string itemId);

        /// <summary>
        /// Get Subscription Item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Task<Models.GetSubscriptionItemResponse> GetSubscriptionItemAsync(
                string subscriptionId,
                string itemId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="usageId">Required parameter: The usage id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        Models.GetUsageResponse DeleteUsage(
                string subscriptionId,
                string itemId,
                string usageId,
                string idempotencyKey = null);

        /// <summary>
        /// Deletes a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="usageId">Required parameter: The usage id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        Task<Models.GetUsageResponse> DeleteUsageAsync(
                string subscriptionId,
                string itemId,
                string usageId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancels a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse CancelSubscription(
                string subscriptionId,
                Models.CreateCancelSubscriptionRequest request = null,
                string idempotencyKey = null);

        /// <summary>
        /// Cancels a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> CancelSubscriptionAsync(
                string subscriptionId,
                Models.CreateCancelSubscriptionRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="incrementId">Required parameter: Increment id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        Models.GetIncrementResponse DeleteIncrement(
                string subscriptionId,
                string incrementId,
                string idempotencyKey = null);

        /// <summary>
        /// Deletes a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="incrementId">Required parameter: Increment id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        Task<Models.GetIncrementResponse> DeleteIncrementAsync(
                string subscriptionId,
                string incrementId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetSubscriptionCycleById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="cycleId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        Models.GetPeriodResponse GetSubscriptionCycleById(
                string subscriptionId,
                string cycleId);

        /// <summary>
        /// GetSubscriptionCycleById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="cycleId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        Task<Models.GetPeriodResponse> GetSubscriptionCycleByIdAsync(
                string subscriptionId,
                string cycleId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the start at date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionStartAt(
                string subscriptionId,
                Models.UpdateSubscriptionStartAtRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the start at date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionStartAtAsync(
                string subscriptionId,
                Models.UpdateSubscriptionStartAtRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the payment method from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionPaymentMethod(
                string subscriptionId,
                Models.UpdateSubscriptionPaymentMethodRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the payment method from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethodAsync(
                string subscriptionId,
                Models.UpdateSubscriptionPaymentMethodRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateCurrentCycleStatus EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request for updating the end date of the subscription current status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        void UpdateCurrentCycleStatus(
                string subscriptionId,
                Models.UpdateCurrentCycleStatusRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateCurrentCycleStatus EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request for updating the end date of the subscription current status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        Task UpdateCurrentCycleStatusAsync(
                string subscriptionId,
                Models.UpdateCurrentCycleStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse CreateSubscription(
                Models.CreateSubscriptionRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> CreateSubscriptionAsync(
                Models.CreateSubscriptionRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

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
        Models.GetUsagesDetailsResponse GetUsagesDetails(
                string subscriptionId,
                string cycleId = null,
                int? size = null,
                int? page = null,
                string itemId = null,
                string mGroup = null);

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
        Task<Models.GetUsagesDetailsResponse> GetUsagesDetailsAsync(
                string subscriptionId,
                string cycleId = null,
                int? size = null,
                int? page = null,
                string itemId = null,
                string mGroup = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// RenewSubscription EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        Models.GetPeriodResponse RenewSubscription(
                string subscriptionId,
                string idempotencyKey = null);

        /// <summary>
        /// RenewSubscription EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        Task<Models.GetPeriodResponse> RenewSubscriptionAsync(
                string subscriptionId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for updating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Models.GetSubscriptionItemResponse UpdateSubscriptionItem(
                string subscriptionId,
                string itemId,
                Models.UpdateSubscriptionItemRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// Updates a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for updating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Task<Models.GetSubscriptionItemResponse> UpdateSubscriptionItemAsync(
                string subscriptionId,
                string itemId,
                Models.UpdateSubscriptionItemRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        Models.GetUsageResponse CreateAnUsage(
                string subscriptionId,
                string itemId,
                string idempotencyKey = null);

        /// <summary>
        /// Create Usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        Task<Models.GetUsageResponse> CreateAnUsageAsync(
                string subscriptionId,
                string itemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetIncrementById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="incrementId">Required parameter: The increment Id.</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        Models.GetIncrementResponse GetIncrementById(
                string subscriptionId,
                string incrementId);

        /// <summary>
        /// GetIncrementById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="incrementId">Required parameter: The increment Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        Task<Models.GetIncrementResponse> GetIncrementByIdAsync(
                string subscriptionId,
                string incrementId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="discountId">Required parameter: Discount Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        Models.GetDiscountResponse DeleteDiscount(
                string subscriptionId,
                string discountId,
                string idempotencyKey = null);

        /// <summary>
        /// Deletes a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="discountId">Required parameter: Discount Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        Task<Models.GetDiscountResponse> DeleteDiscountAsync(
                string subscriptionId,
                string discountId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetIncrements EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListIncrementsResponse response from the API call.</returns>
        Models.ListIncrementsResponse GetIncrements(
                string subscriptionId,
                int? page = null,
                int? size = null);

        /// <summary>
        /// GetIncrements EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListIncrementsResponse response from the API call.</returns>
        Task<Models.ListIncrementsResponse> GetIncrementsAsync(
                string subscriptionId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for creating a usage.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        Models.GetUsageResponse CreateUsage(
                string subscriptionId,
                string itemId,
                Models.CreateUsageRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for creating a usage.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        Task<Models.GetUsageResponse> CreateUsageAsync(
                string subscriptionId,
                string itemId,
                Models.CreateUsageRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new Subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Models.GetSubscriptionItemResponse CreateSubscriptionItem(
                string subscriptionId,
                Models.CreateSubscriptionItemRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a new Subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Task<Models.GetSubscriptionItemResponse> CreateSubscriptionItemAsync(
                string subscriptionId,
                Models.CreateSubscriptionItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

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
        Models.ListUsagesResponse GetUsages(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mGroup = null,
                DateTime? usedSince = null,
                DateTime? usedUntil = null);

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
        Task<Models.ListUsagesResponse> GetUsagesAsync(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mGroup = null,
                DateTime? usedSince = null,
                DateTime? usedUntil = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the billing date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionBillingDate(
                string subscriptionId,
                Models.UpdateSubscriptionBillingDateRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the billing date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionBillingDateAsync(
                string subscriptionId,
                Models.UpdateSubscriptionBillingDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateLatestPeriodEndAt EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateLatestPeriodEndAt(
                string subscriptionId,
                Models.UpdateCurrentCycleEndDateRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateLatestPeriodEndAt EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateLatestPeriodEndAtAsync(
                string subscriptionId,
                Models.UpdateCurrentCycleEndDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetSubscriptionCycles EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <returns>Returns the Models.ListCyclesResponse response from the API call.</returns>
        Models.ListCyclesResponse GetSubscriptionCycles(
                string subscriptionId,
                string page,
                string size);

        /// <summary>
        /// GetSubscriptionCycles EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCyclesResponse response from the API call.</returns>
        Task<Models.ListCyclesResponse> GetSubscriptionCyclesAsync(
                string subscriptionId,
                string page,
                string size,
                CancellationToken cancellationToken = default);

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
        Models.ListSubscriptionsResponse GetSubscriptions(
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
                DateTime? createdUntil = null);

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
        Task<Models.ListSubscriptionsResponse> GetSubscriptionsAsync(
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
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetDiscountById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="discountId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        Models.GetDiscountResponse GetDiscountById(
                string subscriptionId,
                string discountId);

        /// <summary>
        /// GetDiscountById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="discountId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        Task<Models.GetDiscountResponse> GetDiscountByIdAsync(
                string subscriptionId,
                string discountId,
                CancellationToken cancellationToken = default);

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
        Models.ListSubscriptionItemsResponse GetSubscriptionItems(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null);

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
        Task<Models.ListSubscriptionItemsResponse> GetSubscriptionItemsAsync(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Atualização do valor mínimo da assinatura.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionMiniumPrice(
                string subscriptionId,
                Models.UpdateSubscriptionMinimumPriceRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Atualização do valor mínimo da assinatura.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionMiniumPriceAsync(
                string subscriptionId,
                Models.UpdateSubscriptionMinimumPriceRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse GetSubscription(
                string subscriptionId);

        /// <summary>
        /// Gets a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> GetSubscriptionAsync(
                string subscriptionId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateSubscriptionAffiliationId EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionAffiliationId(
                string subscriptionId,
                Models.UpdateSubscriptionAffiliationIdRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateSubscriptionAffiliationId EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionAffiliationIdAsync(
                string subscriptionId,
                Models.UpdateSubscriptionAffiliationIdRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Models.GetSubscriptionItemResponse DeleteSubscriptionItem(
                string subscriptionId,
                string subscriptionItemId,
                string idempotencyKey = null);

        /// <summary>
        /// Deletes a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        Task<Models.GetSubscriptionItemResponse> DeleteSubscriptionItemAsync(
                string subscriptionId,
                string subscriptionItemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the credit card from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionCard(
                string subscriptionId,
                Models.UpdateSubscriptionCardRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the credit card from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionCardAsync(
                string subscriptionId,
                Models.UpdateSubscriptionCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the metadata from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionMetadata(
                string subscriptionId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionMetadataAsync(
                string subscriptionId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the boleto due days from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSubscriptionDueDays(
                string subscriptionId,
                Models.UpdateSubscriptionDueDaysRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the boleto due days from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionDueDaysAsync(
                string subscriptionId,
                Models.UpdateSubscriptionDueDaysRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetDiscounts EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <returns>Returns the Models.ListDiscountsResponse response from the API call.</returns>
        Models.ListDiscountsResponse GetDiscounts(
                string subscriptionId,
                int page,
                int size);

        /// <summary>
        /// GetDiscounts EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListDiscountsResponse response from the API call.</returns>
        Task<Models.ListDiscountsResponse> GetDiscountsAsync(
                string subscriptionId,
                int page,
                int size,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a increment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        Models.GetIncrementResponse CreateIncrement(
                string subscriptionId,
                Models.CreateIncrementRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a increment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        Task<Models.GetIncrementResponse> CreateIncrementAsync(
                string subscriptionId,
                Models.CreateIncrementRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetUsageReport EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="periodId">Required parameter: The period Id.</param>
        /// <returns>Returns the Models.GetUsageReportResponse response from the API call.</returns>
        Models.GetUsageReportResponse GetUsageReport(
                string subscriptionId,
                string periodId);

        /// <summary>
        /// GetUsageReport EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="periodId">Required parameter: The period Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageReportResponse response from the API call.</returns>
        Task<Models.GetUsageReportResponse> GetUsageReportAsync(
                string subscriptionId,
                string periodId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateSplitSubscription EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Subscription's id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Models.GetSubscriptionResponse UpdateSplitSubscription(
                string id,
                Models.UpdateSubscriptionSplitRequest request);

        /// <summary>
        /// UpdateSplitSubscription EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Subscription's id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        Task<Models.GetSubscriptionResponse> UpdateSplitSubscriptionAsync(
                string id,
                Models.UpdateSubscriptionSplitRequest request,
                CancellationToken cancellationToken = default);
    }
}