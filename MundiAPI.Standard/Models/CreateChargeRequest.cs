/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.Standard;
using MundiAPI.Standard.Utilities;


namespace MundiAPI.Standard.Models
{
    public class CreateChargeRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string code;
        private int amount;
        private string customerId;
        private Models.CreateCustomerRequest customer;
        private Models.CreatePaymentRequest payment;
        private Dictionary<string, string> metadata;
        private DateTime? dueAt;
        private Models.CreateAntifraudRequest antifraud;
        private string orderId;

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// The amount of the charge, in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// The customer's id
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId 
        { 
            get 
            {
                return this.customerId; 
            } 
            set 
            {
                this.customerId = value;
                onPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Customer data
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer 
        { 
            get 
            {
                return this.customer; 
            } 
            set 
            {
                this.customer = value;
                onPropertyChanged("Customer");
            }
        }

        /// <summary>
        /// Payment data
        /// </summary>
        [JsonProperty("payment")]
        public Models.CreatePaymentRequest Payment 
        { 
            get 
            {
                return this.payment; 
            } 
            set 
            {
                this.payment = value;
                onPropertyChanged("Payment");
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// The charge due date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime? DueAt 
        { 
            get 
            {
                return this.dueAt; 
            } 
            set 
            {
                this.dueAt = value;
                onPropertyChanged("DueAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antifraud")]
        public Models.CreateAntifraudRequest Antifraud 
        { 
            get 
            {
                return this.antifraud; 
            } 
            set 
            {
                this.antifraud = value;
                onPropertyChanged("Antifraud");
            }
        }

        /// <summary>
        /// Order Id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId 
        { 
            get 
            {
                return this.orderId; 
            } 
            set 
            {
                this.orderId = value;
                onPropertyChanged("OrderId");
            }
        }
    }
} 