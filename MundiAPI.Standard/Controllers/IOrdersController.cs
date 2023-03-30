// <copyright file="IOrdersController.cs" company="APIMatic">
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
    /// IOrdersController.
    /// </summary>
    public interface IOrdersController
    {
        /// <summary>
        /// UpdateOrderStatus EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Update Order Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Models.GetOrderResponse UpdateOrderStatus(
                string id,
                Models.UpdateOrderStatusRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateOrderStatus EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Update Order Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Task<Models.GetOrderResponse> UpdateOrderStatusAsync(
                string id,
                Models.UpdateOrderStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteAllOrderItems EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Models.GetOrderResponse DeleteAllOrderItems(
                string orderId,
                string idempotencyKey = null);

        /// <summary>
        /// DeleteAllOrderItems EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Task<Models.GetOrderResponse> DeleteAllOrderItemsAsync(
                string orderId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the metadata from an order.
        /// </summary>
        /// <param name="orderId">Required parameter: The order id.</param>
        /// <param name="request">Required parameter: Request for updating the order metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Models.GetOrderResponse UpdateOrderMetadata(
                string orderId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata from an order.
        /// </summary>
        /// <param name="orderId">Required parameter: The order id.</param>
        /// <param name="request">Required parameter: Request for updating the order metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Task<Models.GetOrderResponse> UpdateOrderMetadataAsync(
                string orderId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for order's code.</param>
        /// <param name="status">Optional parameter: Filter for order's status.</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range.</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id.</param>
        /// <returns>Returns the Models.ListOrderResponse response from the API call.</returns>
        Models.ListOrderResponse GetOrders(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null);

        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for order's code.</param>
        /// <param name="status">Optional parameter: Filter for order's status.</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range.</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListOrderResponse response from the API call.</returns>
        Task<Models.ListOrderResponse> GetOrdersAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// CreateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Order Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Models.GetOrderItemResponse CreateOrderItem(
                string orderId,
                Models.CreateOrderItemRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// CreateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Order Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Task<Models.GetOrderItemResponse> CreateOrderItemAsync(
                string orderId,
                Models.CreateOrderItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Models.GetOrderItemResponse DeleteOrderItem(
                string orderId,
                string itemId,
                string idempotencyKey = null);

        /// <summary>
        /// DeleteOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Task<Models.GetOrderItemResponse> DeleteOrderItemAsync(
                string orderId,
                string itemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets an order.
        /// </summary>
        /// <param name="orderId">Required parameter: Order id.</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Models.GetOrderResponse GetOrder(
                string orderId);

        /// <summary>
        /// Gets an order.
        /// </summary>
        /// <param name="orderId">Required parameter: Order id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Task<Models.GetOrderResponse> GetOrderAsync(
                string orderId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new Order.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Models.GetOrderResponse CreateOrder(
                Models.CreateOrderRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a new Order.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        Task<Models.GetOrderResponse> CreateOrderAsync(
                Models.CreateOrderRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Models.GetOrderItemResponse GetOrderItem(
                string orderId,
                string itemId);

        /// <summary>
        /// GetOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Task<Models.GetOrderItemResponse> GetOrderItemAsync(
                string orderId,
                string itemId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="request">Required parameter: Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Models.GetOrderItemResponse UpdateOrderItem(
                string orderId,
                string itemId,
                Models.UpdateOrderItemRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="request">Required parameter: Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        Task<Models.GetOrderItemResponse> UpdateOrderItemAsync(
                string orderId,
                string itemId,
                Models.UpdateOrderItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);
    }
}