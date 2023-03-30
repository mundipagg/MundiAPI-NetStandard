// <copyright file="PlansController.cs" company="APIMatic">
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
    /// PlansController.
    /// </summary>
    internal class PlansController : BaseController, IPlansController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlansController"/> class.
        /// </summary>
        internal PlansController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Updates a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="body">Required parameter: Request for updating the plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse UpdatePlanItem(
                string planId,
                string planItemId,
                Models.UpdatePlanItemRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdatePlanItemAsync(planId, planItemId, body, idempotencyKey));

        /// <summary>
        /// Updates a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="body">Required parameter: Request for updating the plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> UpdatePlanItemAsync(
                string planId,
                string planItemId,
                Models.UpdatePlanItemRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/plans/{plan_id}/items/{plan_item_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("plan_id", planId))
                      .Template(_template => _template.Setup("plan_item_id", planItemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Adds a new item to a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for creating a plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse CreatePlanItem(
                string planId,
                Models.CreatePlanItemRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreatePlanItemAsync(planId, request, idempotencyKey));

        /// <summary>
        /// Adds a new item to a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for creating a plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> CreatePlanItemAsync(
                string planId,
                Models.CreatePlanItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/plans/{plan_id}/items")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("plan_id", planId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets all plans.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: Filter for Plan's name.</param>
        /// <param name="status">Optional parameter: Filter for Plan's status.</param>
        /// <param name="billingType">Optional parameter: Filter for plan's billing type.</param>
        /// <param name="createdSince">Optional parameter: Filter for plan's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for plan's creation date end range.</param>
        /// <returns>Returns the Models.ListPlansResponse response from the API call.</returns>
        public Models.ListPlansResponse GetPlans(
                int? page = null,
                int? size = null,
                string name = null,
                string status = null,
                string billingType = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
            => CoreHelper.RunTask(GetPlansAsync(page, size, name, status, billingType, createdSince, createdUntil));

        /// <summary>
        /// Gets all plans.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: Filter for Plan's name.</param>
        /// <param name="status">Optional parameter: Filter for Plan's status.</param>
        /// <param name="billingType">Optional parameter: Filter for plan's billing type.</param>
        /// <param name="createdSince">Optional parameter: Filter for plan's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for plan's creation date end range.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListPlansResponse response from the API call.</returns>
        public async Task<Models.ListPlansResponse> GetPlansAsync(
                int? page = null,
                int? size = null,
                string name = null,
                string status = null,
                string billingType = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListPlansResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/plans")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("billing_type", billingType))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListPlansResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse GetPlan(
                string planId)
            => CoreHelper.RunTask(GetPlanAsync(planId));

        /// <summary>
        /// Gets a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> GetPlanAsync(
                string planId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/plans/{plan_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("plan_id", planId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for updating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse UpdatePlan(
                string planId,
                Models.UpdatePlanRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdatePlanAsync(planId, request, idempotencyKey));

        /// <summary>
        /// Updates a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for updating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> UpdatePlanAsync(
                string planId,
                Models.UpdatePlanRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/plans/{plan_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("plan_id", planId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the metadata from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: The plan id.</param>
        /// <param name="request">Required parameter: Request for updating the plan metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse UpdatePlanMetadata(
                string planId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdatePlanMetadataAsync(planId, request, idempotencyKey));

        /// <summary>
        /// Updates the metadata from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: The plan id.</param>
        /// <param name="request">Required parameter: Request for updating the plan metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> UpdatePlanMetadataAsync(
                string planId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/Plans/{plan_id}/metadata")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("plan_id", planId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates a new plan.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse CreatePlan(
                Models.CreatePlanRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreatePlanAsync(body, idempotencyKey));

        /// <summary>
        /// Creates a new plan.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> CreatePlanAsync(
                Models.CreatePlanRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/plans")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Removes an item from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse DeletePlanItem(
                string planId,
                string planItemId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeletePlanItemAsync(planId, planItemId, idempotencyKey));

        /// <summary>
        /// Removes an item from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> DeletePlanItemAsync(
                string planId,
                string planItemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/plans/{plan_id}/items/{plan_item_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("plan_id", planId))
                      .Template(_template => _template.Setup("plan_item_id", planItemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Deletes a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse DeletePlan(
                string planId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeletePlanAsync(planId, idempotencyKey));

        /// <summary>
        /// Deletes a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> DeletePlanAsync(
                string planId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/plans/{plan_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("plan_id", planId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse GetPlanItem(
                string planId,
                string planItemId)
            => CoreHelper.RunTask(GetPlanItemAsync(planId, planItemId));

        /// <summary>
        /// Gets a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> GetPlanItemAsync(
                string planId,
                string planItemId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPlanItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/plans/{plan_id}/items/{plan_item_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("plan_id", planId))
                      .Template(_template => _template.Setup("plan_item_id", planItemId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}