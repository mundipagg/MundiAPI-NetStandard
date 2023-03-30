// <copyright file="InvoicesController.cs" company="APIMatic">
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
    /// InvoicesController.
    /// </summary>
    internal class InvoicesController : BaseController, IInvoicesController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesController"/> class.
        /// </summary>
        internal InvoicesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create an Invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cycleId">Required parameter: Cycle Id.</param>
        /// <param name="request">Optional parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse CreateInvoice(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateInvoiceAsync(subscriptionId, cycleId, request, idempotencyKey));

        /// <summary>
        /// Create an Invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cycleId">Required parameter: Cycle Id.</param>
        /// <param name="request">Optional parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> CreateInvoiceAsync(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetInvoiceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/cycles/{cycle_id}/pay")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("cycle_id", cycleId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetPartialInvoice EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse GetPartialInvoice(
                string subscriptionId)
            => CoreHelper.RunTask(GetPartialInvoiceAsync(subscriptionId));

        /// <summary>
        /// GetPartialInvoice EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> GetPartialInvoiceAsync(
                string subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetInvoiceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/partial-invoice")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the status from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse UpdateInvoiceStatus(
                string invoiceId,
                Models.UpdateInvoiceStatusRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateInvoiceStatusAsync(invoiceId, request, idempotencyKey));

        /// <summary>
        /// Updates the status from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> UpdateInvoiceStatusAsync(
                string invoiceId,
                Models.UpdateInvoiceStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetInvoiceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/invoices/{invoice_id}/status")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("invoice_id", invoiceId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse GetInvoice(
                string invoiceId)
            => CoreHelper.RunTask(GetInvoiceAsync(invoiceId));

        /// <summary>
        /// Gets an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> GetInvoiceAsync(
                string invoiceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetInvoiceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/invoices/{invoice_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("invoice_id", invoiceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the metadata from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id.</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse UpdateInvoiceMetadata(
                string invoiceId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateInvoiceMetadataAsync(invoiceId, request, idempotencyKey));

        /// <summary>
        /// Updates the metadata from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id.</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> UpdateInvoiceMetadataAsync(
                string invoiceId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetInvoiceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/invoices/{invoice_id}/metadata")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("invoice_id", invoiceId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets all invoices.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code.</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id.</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id.</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range.</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status.</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range.</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range.</param>
        /// <param name="customerDocument">Optional parameter: Fillter for invoice's document.</param>
        /// <returns>Returns the Models.ListInvoicesResponse response from the API call.</returns>
        public Models.ListInvoicesResponse GetInvoices(
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
            => CoreHelper.RunTask(GetInvoicesAsync(page, size, code, customerId, subscriptionId, createdSince, createdUntil, status, dueSince, dueUntil, customerDocument));

        /// <summary>
        /// Gets all invoices.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code.</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id.</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id.</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range.</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status.</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range.</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range.</param>
        /// <param name="customerDocument">Optional parameter: Fillter for invoice's document.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListInvoicesResponse response from the API call.</returns>
        public async Task<Models.ListInvoicesResponse> GetInvoicesAsync(
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
                string customerDocument = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListInvoicesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/invoices")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("code", code))
                      .Query(_query => _query.Setup("customer_id", customerId))
                      .Query(_query => _query.Setup("subscription_id", subscriptionId))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("due_since", dueSince.HasValue ? dueSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("due_until", dueUntil.HasValue ? dueUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("customer_document", customerDocument))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListInvoicesResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Cancels an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse CancelInvoice(
                string invoiceId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CancelInvoiceAsync(invoiceId, idempotencyKey));

        /// <summary>
        /// Cancels an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> CancelInvoiceAsync(
                string invoiceId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetInvoiceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/invoices/{invoice_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("invoice_id", invoiceId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}