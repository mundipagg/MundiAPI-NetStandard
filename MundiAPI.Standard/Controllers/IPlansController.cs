// <copyright file="IPlansController.cs" company="APIMatic">
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
    /// IPlansController.
    /// </summary>
    public interface IPlansController
    {
        /// <summary>
        /// Updates a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="body">Required parameter: Request for updating the plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Models.GetPlanItemResponse UpdatePlanItem(
                string planId,
                string planItemId,
                Models.UpdatePlanItemRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// Updates a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="body">Required parameter: Request for updating the plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Task<Models.GetPlanItemResponse> UpdatePlanItemAsync(
                string planId,
                string planItemId,
                Models.UpdatePlanItemRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds a new item to a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for creating a plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Models.GetPlanItemResponse CreatePlanItem(
                string planId,
                Models.CreatePlanItemRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Adds a new item to a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for creating a plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Task<Models.GetPlanItemResponse> CreatePlanItemAsync(
                string planId,
                Models.CreatePlanItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

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
        Models.ListPlansResponse GetPlans(
                int? page = null,
                int? size = null,
                string name = null,
                string status = null,
                string billingType = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

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
        Task<Models.ListPlansResponse> GetPlansAsync(
                int? page = null,
                int? size = null,
                string name = null,
                string status = null,
                string billingType = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Models.GetPlanResponse GetPlan(
                string planId);

        /// <summary>
        /// Gets a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Task<Models.GetPlanResponse> GetPlanAsync(
                string planId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for updating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Models.GetPlanResponse UpdatePlan(
                string planId,
                Models.UpdatePlanRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for updating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Task<Models.GetPlanResponse> UpdatePlanAsync(
                string planId,
                Models.UpdatePlanRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the metadata from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: The plan id.</param>
        /// <param name="request">Required parameter: Request for updating the plan metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Models.GetPlanResponse UpdatePlanMetadata(
                string planId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: The plan id.</param>
        /// <param name="request">Required parameter: Request for updating the plan metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Task<Models.GetPlanResponse> UpdatePlanMetadataAsync(
                string planId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new plan.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Models.GetPlanResponse CreatePlan(
                Models.CreatePlanRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// Creates a new plan.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Task<Models.GetPlanResponse> CreatePlanAsync(
                Models.CreatePlanRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes an item from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Models.GetPlanItemResponse DeletePlanItem(
                string planId,
                string planItemId,
                string idempotencyKey = null);

        /// <summary>
        /// Removes an item from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Task<Models.GetPlanItemResponse> DeletePlanItemAsync(
                string planId,
                string planItemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Models.GetPlanResponse DeletePlan(
                string planId,
                string idempotencyKey = null);

        /// <summary>
        /// Deletes a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        Task<Models.GetPlanResponse> DeletePlanAsync(
                string planId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Models.GetPlanItemResponse GetPlanItem(
                string planId,
                string planItemId);

        /// <summary>
        /// Gets a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        Task<Models.GetPlanItemResponse> GetPlanItemAsync(
                string planId,
                string planItemId,
                CancellationToken cancellationToken = default);
    }
}