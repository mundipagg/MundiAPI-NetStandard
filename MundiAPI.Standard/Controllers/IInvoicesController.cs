// <copyright file="IInvoicesController.cs" company="APIMatic">
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
    /// IInvoicesController.
    /// </summary>
    public interface IInvoicesController
    {
        /// <summary>
        /// Create an Invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cycleId">Required parameter: Cycle Id.</param>
        /// <param name="request">Optional parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Models.GetInvoiceResponse CreateInvoice(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null);

        /// <summary>
        /// Create an Invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cycleId">Required parameter: Cycle Id.</param>
        /// <param name="request">Optional parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Task<Models.GetInvoiceResponse> CreateInvoiceAsync(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetPartialInvoice EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Models.GetInvoiceResponse GetPartialInvoice(
                string subscriptionId);

        /// <summary>
        /// GetPartialInvoice EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Task<Models.GetInvoiceResponse> GetPartialInvoiceAsync(
                string subscriptionId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the status from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Models.GetInvoiceResponse UpdateInvoiceStatus(
                string invoiceId,
                Models.UpdateInvoiceStatusRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the status from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Task<Models.GetInvoiceResponse> UpdateInvoiceStatusAsync(
                string invoiceId,
                Models.UpdateInvoiceStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Models.GetInvoiceResponse GetInvoice(
                string invoiceId);

        /// <summary>
        /// Gets an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Task<Models.GetInvoiceResponse> GetInvoiceAsync(
                string invoiceId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the metadata from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id.</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Models.GetInvoiceResponse UpdateInvoiceMetadata(
                string invoiceId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id.</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Task<Models.GetInvoiceResponse> UpdateInvoiceMetadataAsync(
                string invoiceId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

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
        Models.ListInvoicesResponse GetInvoices(
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
                string customerDocument = null);

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
        Task<Models.ListInvoicesResponse> GetInvoicesAsync(
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
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancels an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Models.GetInvoiceResponse CancelInvoice(
                string invoiceId,
                string idempotencyKey = null);

        /// <summary>
        /// Cancels an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        Task<Models.GetInvoiceResponse> CancelInvoiceAsync(
                string invoiceId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);
    }
}