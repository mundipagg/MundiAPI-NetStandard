// <copyright file="MundiAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using MundiAPI.Standard.Authentication;
    using MundiAPI.Standard.Controllers;
    using MundiAPI.Standard.Http.Client;
    using MundiAPI.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class MundiAPIClient : IMundiAPIClient
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.mundipagg.com/core/v1" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "MundiSDK - DotNet 2.4.0";
        private readonly BasicAuthManager basicAuthManager;
        private readonly Lazy<ICustomersController> customers;
        private readonly Lazy<IChargesController> charges;
        private readonly Lazy<IRecipientsController> recipients;
        private readonly Lazy<ISubscriptionsController> subscriptions;
        private readonly Lazy<IInvoicesController> invoices;
        private readonly Lazy<IOrdersController> orders;
        private readonly Lazy<ITokensController> tokens;
        private readonly Lazy<IPlansController> plans;
        private readonly Lazy<ITransactionsController> transactions;
        private readonly Lazy<ITransfersController> transfers;

        private MundiAPIClient(
            Environment environment,
            string basicAuthUserName,
            string basicAuthPassword,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.HttpClientConfiguration = httpClientConfiguration;
            basicAuthManager = new BasicAuthManager(basicAuthUserName, basicAuthPassword);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", basicAuthManager}
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();


            this.customers = new Lazy<ICustomersController>(
                () => new CustomersController(globalConfiguration));
            this.charges = new Lazy<IChargesController>(
                () => new ChargesController(globalConfiguration));
            this.recipients = new Lazy<IRecipientsController>(
                () => new RecipientsController(globalConfiguration));
            this.subscriptions = new Lazy<ISubscriptionsController>(
                () => new SubscriptionsController(globalConfiguration));
            this.invoices = new Lazy<IInvoicesController>(
                () => new InvoicesController(globalConfiguration));
            this.orders = new Lazy<IOrdersController>(
                () => new OrdersController(globalConfiguration));
            this.tokens = new Lazy<ITokensController>(
                () => new TokensController(globalConfiguration));
            this.plans = new Lazy<IPlansController>(
                () => new PlansController(globalConfiguration));
            this.transactions = new Lazy<ITransactionsController>(
                () => new TransactionsController(globalConfiguration));
            this.transfers = new Lazy<ITransfersController>(
                () => new TransfersController(globalConfiguration));
        }

        /// <summary>
        /// Gets CustomersController controller.
        /// </summary>
        public ICustomersController CustomersController => this.customers.Value;

        /// <summary>
        /// Gets ChargesController controller.
        /// </summary>
        public IChargesController ChargesController => this.charges.Value;

        /// <summary>
        /// Gets RecipientsController controller.
        /// </summary>
        public IRecipientsController RecipientsController => this.recipients.Value;

        /// <summary>
        /// Gets SubscriptionsController controller.
        /// </summary>
        public ISubscriptionsController SubscriptionsController => this.subscriptions.Value;

        /// <summary>
        /// Gets InvoicesController controller.
        /// </summary>
        public IInvoicesController InvoicesController => this.invoices.Value;

        /// <summary>
        /// Gets OrdersController controller.
        /// </summary>
        public IOrdersController OrdersController => this.orders.Value;

        /// <summary>
        /// Gets TokensController controller.
        /// </summary>
        public ITokensController TokensController => this.tokens.Value;

        /// <summary>
        /// Gets PlansController controller.
        /// </summary>
        public IPlansController PlansController => this.plans.Value;

        /// <summary>
        /// Gets TransactionsController controller.
        /// </summary>
        public ITransactionsController TransactionsController => this.transactions.Value;

        /// <summary>
        /// Gets TransfersController controller.
        /// </summary>
        public ITransfersController TransfersController => this.transfers.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }


        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials => this.basicAuthManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the MundiAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .BasicAuthCredentials(basicAuthManager.BasicAuthUserName, basicAuthManager.BasicAuthPassword)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> MundiAPIClient.</returns>
        internal static MundiAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("MUNDI_API_STANDARD_ENVIRONMENT");
            string basicAuthUserName = System.Environment.GetEnvironmentVariable("MUNDI_API_STANDARD_BASIC_AUTH_USER_NAME");
            string basicAuthPassword = System.Environment.GetEnvironmentVariable("MUNDI_API_STANDARD_BASIC_AUTH_PASSWORD");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (basicAuthUserName != null && basicAuthPassword != null)
            {
                builder.BasicAuthCredentials(basicAuthUserName, basicAuthPassword);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = MundiAPI.Standard.Environment.Production;
            private string basicAuthUserName = "";
            private string basicAuthPassword = "";
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthUserName">BasicAuthUserName.</param>
            /// <param name="basicAuthPassword">BasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(string basicAuthUserName, string basicAuthPassword)
            {
                this.basicAuthUserName = basicAuthUserName ?? throw new ArgumentNullException(nameof(basicAuthUserName));
                this.basicAuthPassword = basicAuthPassword ?? throw new ArgumentNullException(nameof(basicAuthPassword));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Creates an object of the MundiAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>MundiAPIClient.</returns>
            public MundiAPIClient Build()
            {

                return new MundiAPIClient(
                    environment,
                    basicAuthUserName,
                    basicAuthPassword,
                    httpClientConfig.Build());
            }
        }
    }
}
