// <copyright file="RecipientsController.cs" company="APIMatic">
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
    /// RecipientsController.
    /// </summary>
    internal class RecipientsController : BaseController, IRecipientsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientsController"/> class.
        /// </summary>
        internal RecipientsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipientMetadata(
                string recipientId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateRecipientMetadataAsync(recipientId, request, idempotencyKey));

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientMetadataAsync(
                string recipientId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/recipients/{recipient_id}/metadata")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// UpdateRecipientTransferSettings EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipientTransferSettings(
                string recipientId,
                Models.UpdateTransferSettingsRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateRecipientTransferSettingsAsync(recipientId, request, idempotencyKey));

        /// <summary>
        /// UpdateRecipientTransferSettings EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientTransferSettingsAsync(
                string recipientId,
                Models.UpdateTransferSettingsRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/recipients/{recipient_id}/transfer-settings")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="anticipationId">Required parameter: Anticipation id.</param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public Models.GetAnticipationResponse GetAnticipation(
                string recipientId,
                string anticipationId)
            => CoreHelper.RunTask(GetAnticipationAsync(recipientId, anticipationId));

        /// <summary>
        /// Gets an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="anticipationId">Required parameter: Anticipation id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public async Task<Models.GetAnticipationResponse> GetAnticipationAsync(
                string recipientId,
                string anticipationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAnticipationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/anticipations/{anticipation_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Template(_template => _template.Setup("anticipation_id", anticipationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAnticipationResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieves paginated recipients information.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListRecipientResponse response from the API call.</returns>
        public Models.ListRecipientResponse GetRecipients(
                int? page = null,
                int? size = null)
            => CoreHelper.RunTask(GetRecipientsAsync(page, size));

        /// <summary>
        /// Retrieves paginated recipients information.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListRecipientResponse response from the API call.</returns>
        public async Task<Models.ListRecipientResponse> GetRecipientsAsync(
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get balance information for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <returns>Returns the Models.GetBalanceResponse response from the API call.</returns>
        public Models.GetBalanceResponse GetBalance(
                string recipientId)
            => CoreHelper.RunTask(GetBalanceAsync(recipientId));

        /// <summary>
        /// Get balance information for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetBalanceResponse response from the API call.</returns>
        public async Task<Models.GetBalanceResponse> GetBalanceAsync(
                string recipientId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetBalanceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/balance")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetBalanceResponse>(_response)))
              .ExecuteAsync(cancellationToken);

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
        public Models.ListAnticipationResponse GetAnticipations(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
            => CoreHelper.RunTask(GetAnticipationsAsync(recipientId, page, size, status, timeframe, paymentDateSince, paymentDateUntil, createdSince, createdUntil));

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
        public async Task<Models.ListAnticipationResponse> GetAnticipationsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListAnticipationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/anticipations")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("timeframe", timeframe))
                      .Query(_query => _query.Setup("payment_date_since", paymentDateSince.HasValue ? paymentDateSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("payment_date_until", paymentDateUntil.HasValue ? paymentDateUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListAnticipationResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Anticipation data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public Models.GetAnticipationResponse CreateAnticipation(
                string recipientId,
                Models.CreateAnticipationRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateAnticipationAsync(recipientId, request, idempotencyKey));

        /// <summary>
        /// Creates an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Anticipation data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public async Task<Models.GetAnticipationResponse> CreateAnticipationAsync(
                string recipientId,
                Models.CreateAnticipationRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAnticipationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/recipients/{recipient_id}/anticipations")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAnticipationResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the default bank account from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Bank account data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipientDefaultBankAccount(
                string recipientId,
                Models.UpdateRecipientBankAccountRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateRecipientDefaultBankAccountAsync(recipientId, request, idempotencyKey));

        /// <summary>
        /// Updates the default bank account from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Bank account data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientDefaultBankAccountAsync(
                string recipientId,
                Models.UpdateRecipientBankAccountRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/recipients/{recipient_id}/default-bank-account")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id.</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse GetRecipient(
                string recipientId)
            => CoreHelper.RunTask(GetRecipientAsync(recipientId));

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> GetRecipientAsync(
                string recipientId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets the anticipation limits for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="timeframe">Required parameter: Timeframe.</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date.</param>
        /// <returns>Returns the Models.GetAnticipationLimitResponse response from the API call.</returns>
        public Models.GetAnticipationLimitResponse GetAnticipationLimits(
                string recipientId,
                string timeframe,
                DateTime paymentDate)
            => CoreHelper.RunTask(GetAnticipationLimitsAsync(recipientId, timeframe, paymentDate));

        /// <summary>
        /// Gets the anticipation limits for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="timeframe">Required parameter: Timeframe.</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationLimitResponse response from the API call.</returns>
        public async Task<Models.GetAnticipationLimitResponse> GetAnticipationLimitsAsync(
                string recipientId,
                string timeframe,
                DateTime paymentDate,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAnticipationLimitResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/anticipation_limits")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Query(_query => _query.Setup("timeframe", timeframe))
                      .Query(_query => _query.Setup("payment_date", paymentDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetAnticipationLimitResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets a transfer.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="transferId">Required parameter: Transfer id.</param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public Models.GetTransferResponse GetTransfer(
                string recipientId,
                string transferId)
            => CoreHelper.RunTask(GetTransferAsync(recipientId, transferId));

        /// <summary>
        /// Gets a transfer.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="transferId">Required parameter: Transfer id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public async Task<Models.GetTransferResponse> GetTransferAsync(
                string recipientId,
                string transferId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTransferResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/transfers/{transfer_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Template(_template => _template.Setup("transfer_id", transferId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetTransferResponse>(_response)))
              .ExecuteAsync(cancellationToken);

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
        public Models.ListTransferResponse GetTransfers(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
            => CoreHelper.RunTask(GetTransfersAsync(recipientId, page, size, status, createdSince, createdUntil));

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
        public async Task<Models.ListTransferResponse> GetTransfersAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListTransferResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/transfers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListTransferResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipient(
                string recipientId,
                Models.UpdateRecipientRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateRecipientAsync(recipientId, request, idempotencyKey));

        /// <summary>
        /// Updates a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientAsync(
                string recipientId,
                Models.UpdateRecipientRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/recipients/{recipient_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new recipient.
        /// </summary>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse CreateRecipient(
                Models.CreateRecipientRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateRecipientAsync(request, idempotencyKey));

        /// <summary>
        /// Creates a new recipient.
        /// </summary>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> CreateRecipientAsync(
                Models.CreateRecipientRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/recipients")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a transfer for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id.</param>
        /// <param name="request">Required parameter: Transfer data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public Models.GetTransferResponse CreateTransfer(
                string recipientId,
                Models.CreateTransferRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateTransferAsync(recipientId, request, idempotencyKey));

        /// <summary>
        /// Creates a transfer for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id.</param>
        /// <param name="request">Required parameter: Transfer data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public async Task<Models.GetTransferResponse> CreateTransferAsync(
                string recipientId,
                Models.CreateTransferRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTransferResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/recipients/{recipient_id}/transfers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetTransferResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// CreateWithdraw EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public Models.GetWithdrawResponse CreateWithdraw(
                string recipientId,
                Models.CreateWithdrawRequest request)
            => CoreHelper.RunTask(CreateWithdrawAsync(recipientId, request));

        /// <summary>
        /// CreateWithdraw EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public async Task<Models.GetWithdrawResponse> CreateWithdrawAsync(
                string recipientId,
                Models.CreateWithdrawRequest request,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetWithdrawResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/recipients/{recipient_id}/withdrawals")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetWithdrawResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetWithdrawById EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="withdrawalId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public Models.GetWithdrawResponse GetWithdrawById(
                string recipientId,
                string withdrawalId)
            => CoreHelper.RunTask(GetWithdrawByIdAsync(recipientId, withdrawalId));

        /// <summary>
        /// GetWithdrawById EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="withdrawalId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public async Task<Models.GetWithdrawResponse> GetWithdrawByIdAsync(
                string recipientId,
                string withdrawalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetWithdrawResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/withdrawals/{withdrawal_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Template(_template => _template.Setup("withdrawal_id", withdrawalId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetWithdrawResponse>(_response)))
              .ExecuteAsync(cancellationToken);

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
        public Models.ListWithdrawals GetWithdrawals(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
            => CoreHelper.RunTask(GetWithdrawalsAsync(recipientId, page, size, status, createdSince, createdUntil));

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
        public async Task<Models.ListWithdrawals> GetWithdrawalsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListWithdrawals>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/{recipient_id}/withdrawals")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListWithdrawals>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateAutomaticAnticipationSettings(
                string recipientId,
                Models.UpdateAutomaticAnticipationSettingsRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateAutomaticAnticipationSettingsAsync(recipientId, request, idempotencyKey));

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateAutomaticAnticipationSettingsAsync(
                string recipientId,
                Models.UpdateAutomaticAnticipationSettingsRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/recipients/{recipient_id}/automatic-anticipation-settings")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("recipient_id", recipientId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="code">Required parameter: Recipient code.</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse GetRecipientByCode(
                string code)
            => CoreHelper.RunTask(GetRecipientByCodeAsync(code));

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="code">Required parameter: Recipient code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> GetRecipientByCodeAsync(
                string code,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRecipientResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recipients/code/{code}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("code", code))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}