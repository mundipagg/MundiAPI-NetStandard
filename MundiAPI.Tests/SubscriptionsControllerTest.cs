/*
 * MundiAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using MundiAPI.Standard;
using MundiAPI.Standard.Utilities; 
using MundiAPI.Standard.Http.Client;
using MundiAPI.Standard.Http.Response;
using MundiAPI.Tests.Helpers;
using NUnit.Framework;
using MundiAPI.Standard;
using MundiAPI.Standard.Controllers;
using MundiAPI.Standard.Exceptions;

namespace MundiAPI.Tests
{
    [TestFixture]
    public class SubscriptionsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static SubscriptionsController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Subscriptions;
        }

        /// <summary>
        /// Gets all subscriptions 
        /// </summary>
        [Test]
        public async Task TestTestGetSubscriptions() 
        {
            // Parameters for the API call
            int? page = null;
            int? size = null;
            string code = null;
            string billingType = null;
            string customerId = null;
            string planId = null;
            string cardId = null;
            string status = null;
            DateTime? nextBillingSince = null;
            DateTime? nextBillingUntil = null;
            DateTime? createdSince = null;
            DateTime? createdUntil = null;

            // Perform API call
            Standard.Models.SubscriptionsResponse3 result = null;

            try
            {
                result = await controller.GetSubscriptionsAsync(page, size, code, billingType, customerId, planId, cardId, status, nextBillingSince, nextBillingUntil, createdSince, createdUntil);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}