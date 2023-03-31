/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using MundiAPI.Standard.Controllers;
using MundiAPI.Standard.Http.Client;
using MundiAPI.Standard.Utilities;

namespace MundiAPI.Standard
{
    public partial class MundiAPIClient
    {

        /// <summary>
        /// Singleton access to Subscriptions controller
        /// </summary>
        public SubscriptionsController Subscriptions
        {
            get
            {
                return SubscriptionsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Orders controller
        /// </summary>
        public OrdersController Orders
        {
            get
            {
                return OrdersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Plans controller
        /// </summary>
        public PlansController Plans
        {
            get
            {
                return PlansController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Invoices controller
        /// </summary>
        public InvoicesController Invoices
        {
            get
            {
                return InvoicesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Customers controller
        /// </summary>
        public CustomersController Customers
        {
            get
            {
                return CustomersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Charges controller
        /// </summary>
        public ChargesController Charges
        {
            get
            {
                return ChargesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Recipients controller
        /// </summary>
        public RecipientsController Recipients
        {
            get
            {
                return RecipientsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Transfers controller
        /// </summary>
        public TransfersController Transfers
        {
            get
            {
                return TransfersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Tokens controller
        /// </summary>
        public TokensController Tokens
        {
            get
            {
                return TokensController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Transactions controller
        /// </summary>
        public TransactionsController Transactions
        {
            get
            {
                return TransactionsController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public MundiAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public MundiAPIClient(string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
        #endregion
    }
}