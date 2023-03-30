// <copyright file="IRecipientsController.cs" company="APIMatic">
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
    /// IRecipientsController.
    /// </summary>
    public interface IRecipientsController
    {
        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse UpdateRecipientMetadata(
                string recipientId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> UpdateRecipientMetadataAsync(
                string recipientId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateRecipientTransferSettings EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse UpdateRecipientTransferSettings(
                string recipientId,
                Models.UpdateTransferSettingsRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateRecipientTransferSettings EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> UpdateRecipientTransferSettingsAsync(
                string recipientId,
                Models.UpdateTransferSettingsRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="anticipationId">Required parameter: Anticipation id.</param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        Models.GetAnticipationResponse GetAnticipation(
                string recipientId,
                string anticipationId);

        /// <summary>
        /// Gets an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="anticipationId">Required parameter: Anticipation id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        Task<Models.GetAnticipationResponse> GetAnticipationAsync(
                string recipientId,
                string anticipationId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves paginated recipients information.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListRecipientResponse response from the API call.</returns>
        Models.ListRecipientResponse GetRecipients(
                int? page = null,
                int? size = null);

        /// <summary>
        /// Retrieves paginated recipients information.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListRecipientResponse response from the API call.</returns>
        Task<Models.ListRecipientResponse> GetRecipientsAsync(
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Get balance information for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <returns>Returns the Models.GetBalanceResponse response from the API call.</returns>
        Models.GetBalanceResponse GetBalance(
                string recipientId);

        /// <summary>
        /// Get balance information for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetBalanceResponse response from the API call.</returns>
        Task<Models.GetBalanceResponse> GetBalanceAsync(
                string recipientId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a paginated list of anticipations from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for anticipation status.</param>
        /// <param name="timeframe">Optional parameter: Filter for anticipation timeframe.</param>
        /// <param name="paymentDateSince">Optional parameter: Filter for start range for anticipation payment date.</param>
        /// <param name="paymentDateUntil">Optional parameter: Filter for end range for anticipation payment date.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range for anticipation creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range for anticipation creation date.</param>
        /// <returns>Returns the Models.ListAnticipationResponse response from the API call.</returns>
        Models.ListAnticipationResponse GetAnticipations(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Retrieves a paginated list of anticipations from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for anticipation status.</param>
        /// <param name="timeframe">Optional parameter: Filter for anticipation timeframe.</param>
        /// <param name="paymentDateSince">Optional parameter: Filter for start range for anticipation payment date.</param>
        /// <param name="paymentDateUntil">Optional parameter: Filter for end range for anticipation payment date.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range for anticipation creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range for anticipation creation date.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAnticipationResponse response from the API call.</returns>
        Task<Models.ListAnticipationResponse> GetAnticipationsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Anticipation data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        Models.GetAnticipationResponse CreateAnticipation(
                string recipientId,
                Models.CreateAnticipationRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Creates an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Anticipation data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        Task<Models.GetAnticipationResponse> CreateAnticipationAsync(
                string recipientId,
                Models.CreateAnticipationRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the default bank account from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Bank account data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse UpdateRecipientDefaultBankAccount(
                string recipientId,
                Models.UpdateRecipientBankAccountRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the default bank account from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Bank account data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> UpdateRecipientDefaultBankAccountAsync(
                string recipientId,
                Models.UpdateRecipientBankAccountRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id.</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse GetRecipient(
                string recipientId);

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> GetRecipientAsync(
                string recipientId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the anticipation limits for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="timeframe">Required parameter: Timeframe.</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date.</param>
        /// <returns>Returns the Models.GetAnticipationLimitResponse response from the API call.</returns>
        Models.GetAnticipationLimitResponse GetAnticipationLimits(
                string recipientId,
                string timeframe,
                DateTime paymentDate);

        /// <summary>
        /// Gets the anticipation limits for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="timeframe">Required parameter: Timeframe.</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationLimitResponse response from the API call.</returns>
        Task<Models.GetAnticipationLimitResponse> GetAnticipationLimitsAsync(
                string recipientId,
                string timeframe,
                DateTime paymentDate,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a transfer.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="transferId">Required parameter: Transfer id.</param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        Models.GetTransferResponse GetTransfer(
                string recipientId,
                string transferId);

        /// <summary>
        /// Gets a transfer.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="transferId">Required parameter: Transfer id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        Task<Models.GetTransferResponse> GetTransferAsync(
                string recipientId,
                string transferId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for transfer status.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range of transfer creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range of transfer creation date.</param>
        /// <returns>Returns the Models.ListTransferResponse response from the API call.</returns>
        Models.ListTransferResponse GetTransfers(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for transfer status.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range of transfer creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range of transfer creation date.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListTransferResponse response from the API call.</returns>
        Task<Models.ListTransferResponse> GetTransfersAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse UpdateRecipient(
                string recipientId,
                Models.UpdateRecipientRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> UpdateRecipientAsync(
                string recipientId,
                Models.UpdateRecipientRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new recipient.
        /// </summary>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse CreateRecipient(
                Models.CreateRecipientRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a new recipient.
        /// </summary>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> CreateRecipientAsync(
                Models.CreateRecipientRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a transfer for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id.</param>
        /// <param name="request">Required parameter: Transfer data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        Models.GetTransferResponse CreateTransfer(
                string recipientId,
                Models.CreateTransferRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a transfer for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id.</param>
        /// <param name="request">Required parameter: Transfer data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        Task<Models.GetTransferResponse> CreateTransferAsync(
                string recipientId,
                Models.CreateTransferRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// CreateWithdraw EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        Models.GetWithdrawResponse CreateWithdraw(
                string recipientId,
                Models.CreateWithdrawRequest request);

        /// <summary>
        /// CreateWithdraw EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        Task<Models.GetWithdrawResponse> CreateWithdrawAsync(
                string recipientId,
                Models.CreateWithdrawRequest request,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetWithdrawById EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="withdrawalId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        Models.GetWithdrawResponse GetWithdrawById(
                string recipientId,
                string withdrawalId);

        /// <summary>
        /// GetWithdrawById EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="withdrawalId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        Task<Models.GetWithdrawResponse> GetWithdrawByIdAsync(
                string recipientId,
                string withdrawalId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: .</param>
        /// <param name="size">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListWithdrawals response from the API call.</returns>
        Models.ListWithdrawals GetWithdrawals(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: .</param>
        /// <param name="size">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListWithdrawals response from the API call.</returns>
        Task<Models.ListWithdrawals> GetWithdrawalsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse UpdateAutomaticAnticipationSettings(
                string recipientId,
                Models.UpdateAutomaticAnticipationSettingsRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> UpdateAutomaticAnticipationSettingsAsync(
                string recipientId,
                Models.UpdateAutomaticAnticipationSettingsRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="code">Required parameter: Recipient code.</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Models.GetRecipientResponse GetRecipientByCode(
                string code);

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="code">Required parameter: Recipient code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        Task<Models.GetRecipientResponse> GetRecipientByCodeAsync(
                string code,
                CancellationToken cancellationToken = default);
    }
}