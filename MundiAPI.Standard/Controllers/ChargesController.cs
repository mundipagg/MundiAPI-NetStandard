// <copyright file="ChargesController.cs" company="APIMatic">
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
    /// ChargesController.
    /// </summary>
    internal class ChargesController : BaseController, IChargesController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesController"/> class.
        /// </summary>
        internal ChargesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get a charge from its id.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse GetCharge(
                string chargeId)
            => CoreHelper.RunTask(GetChargeAsync(chargeId));

        /// <summary>
        /// Get a charge from its id.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> GetChargeAsync(
                string chargeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/charges/{charge_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("charge_id", chargeId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// ConfirmPayment EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: .</param>
        /// <param name="request">Optional parameter: Request for confirm payment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse ConfirmPayment(
                string chargeId,
                Models.CreateConfirmPaymentRequest request = null,
                string idempotencyKey = null)
            => CoreHelper.RunTask(ConfirmPaymentAsync(chargeId, request, idempotencyKey));

        /// <summary>
        /// ConfirmPayment EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: .</param>
        /// <param name="request">Optional parameter: Request for confirm payment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> ConfirmPaymentAsync(
                string chargeId,
                Models.CreateConfirmPaymentRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/charges/{charge_id}/confirm-payment")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the card from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating a charge's card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargeCard(
                string chargeId,
                Models.UpdateChargeCardRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateChargeCardAsync(chargeId, request, idempotencyKey));

        /// <summary>
        /// Updates the card from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating a charge's card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargeCardAsync(
                string chargeId,
                Models.UpdateChargeCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/charges/{charge_id}/card")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Lists all charges.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for charge's code.</param>
        /// <param name="status">Optional parameter: Filter for charge's status.</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method.</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id.</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id.</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation.</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation.</param>
        /// <returns>Returns the Models.ListChargesResponse response from the API call.</returns>
        public Models.ListChargesResponse GetCharges(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
            => CoreHelper.RunTask(GetChargesAsync(page, size, code, status, paymentMethod, customerId, orderId, createdSince, createdUntil));

        /// <summary>
        /// Lists all charges.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for charge's code.</param>
        /// <param name="status">Optional parameter: Filter for charge's status.</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method.</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id.</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id.</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation.</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListChargesResponse response from the API call.</returns>
        public async Task<Models.ListChargesResponse> GetChargesAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListChargesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/charges")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("code", code))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("payment_method", paymentMethod))
                      .Query(_query => _query.Setup("customer_id", customerId))
                      .Query(_query => _query.Setup("order_id", orderId))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListChargesResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Cancel a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse CancelCharge(
                string chargeId,
                Models.CreateCancelChargeRequest request = null,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CancelChargeAsync(chargeId, request, idempotencyKey));

        /// <summary>
        /// Cancel a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> CancelChargeAsync(
                string chargeId,
                Models.CreateCancelChargeRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/charges/{charge_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retries a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse RetryCharge(
                string chargeId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(RetryChargeAsync(chargeId, idempotencyKey));

        /// <summary>
        /// Retries a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> RetryChargeAsync(
                string chargeId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/charges/{charge_id}/retry")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates a charge's payment method.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargePaymentMethod(
                string chargeId,
                Models.UpdateChargePaymentMethodRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateChargePaymentMethodAsync(chargeId, request, idempotencyKey));

        /// <summary>
        /// Updates a charge's payment method.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargePaymentMethodAsync(
                string chargeId,
                Models.UpdateChargePaymentMethodRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/charges/{charge_id}/payment-method")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the metadata from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargeMetadata(
                string chargeId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateChargeMetadataAsync(chargeId, request, idempotencyKey));

        /// <summary>
        /// Updates the metadata from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargeMetadataAsync(
                string chargeId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/Charges/{charge_id}/metadata")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Captures a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for capturing a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse CaptureCharge(
                string chargeId,
                Models.CreateCaptureChargeRequest request = null,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CaptureChargeAsync(chargeId, request, idempotencyKey));

        /// <summary>
        /// Captures a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for capturing a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> CaptureChargeAsync(
                string chargeId,
                Models.CreateCaptureChargeRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/charges/{charge_id}/capture")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the due date from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="request">Required parameter: Request for updating the due date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargeDueDate(
                string chargeId,
                Models.UpdateChargeDueDateRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateChargeDueDateAsync(chargeId, request, idempotencyKey));

        /// <summary>
        /// Updates the due date from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="request">Required parameter: Request for updating the due date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargeDueDateAsync(
                string chargeId,
                Models.UpdateChargeDueDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/Charges/{charge_id}/due-date")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new charge.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse CreateCharge(
                Models.CreateChargeRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateChargeAsync(request, idempotencyKey));

        /// <summary>
        /// Creates a new charge.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> CreateChargeAsync(
                Models.CreateChargeRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/Charges")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargeResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetChargeTransactions EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListChargeTransactionsResponse response from the API call.</returns>
        public Models.ListChargeTransactionsResponse GetChargeTransactions(
                string chargeId,
                int? page = null,
                int? size = null)
            => CoreHelper.RunTask(GetChargeTransactionsAsync(chargeId, page, size));

        /// <summary>
        /// GetChargeTransactions EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListChargeTransactionsResponse response from the API call.</returns>
        public async Task<Models.ListChargeTransactionsResponse> GetChargeTransactionsAsync(
                string chargeId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListChargeTransactionsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/charges/{charge_id}/transactions")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("charge_id", chargeId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListChargeTransactionsResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetChargesSummary EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargesSummaryResponse response from the API call.</returns>
        public Models.GetChargesSummaryResponse GetChargesSummary(
                string status,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
            => CoreHelper.RunTask(GetChargesSummaryAsync(status, createdSince, createdUntil));

        /// <summary>
        /// GetChargesSummary EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargesSummaryResponse response from the API call.</returns>
        public async Task<Models.GetChargesSummaryResponse> GetChargesSummaryAsync(
                string status,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargesSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/charges/summary")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetChargesSummaryResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}