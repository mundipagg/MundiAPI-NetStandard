// <copyright file="IMundiAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard
{
    using System;
    using MundiAPI.Standard.Controllers;

    /// <summary>
    /// IMundiAPIClient.
    /// </summary>
    public interface IMundiAPIClient : IConfiguration
    {
        /// <summary>
        /// Gets instance for ICustomersController.
        /// </summary>
        ICustomersController CustomersController { get; }

        /// <summary>
        /// Gets instance for IChargesController.
        /// </summary>
        IChargesController ChargesController { get; }

        /// <summary>
        /// Gets instance for IRecipientsController.
        /// </summary>
        IRecipientsController RecipientsController { get; }

        /// <summary>
        /// Gets instance for ISubscriptionsController.
        /// </summary>
        ISubscriptionsController SubscriptionsController { get; }

        /// <summary>
        /// Gets instance for IInvoicesController.
        /// </summary>
        IInvoicesController InvoicesController { get; }

        /// <summary>
        /// Gets instance for IOrdersController.
        /// </summary>
        IOrdersController OrdersController { get; }

        /// <summary>
        /// Gets instance for ITokensController.
        /// </summary>
        ITokensController TokensController { get; }

        /// <summary>
        /// Gets instance for IPlansController.
        /// </summary>
        IPlansController PlansController { get; }

        /// <summary>
        /// Gets instance for ITransactionsController.
        /// </summary>
        ITransactionsController TransactionsController { get; }

        /// <summary>
        /// Gets instance for ITransfersController.
        /// </summary>
        ITransfersController TransfersController { get; }
    }
}