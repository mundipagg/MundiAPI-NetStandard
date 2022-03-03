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
    public class GetSubscriptionResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string code;
        private DateTime startAt;
        private string interval;
        private int intervalCount;
        private string billingType;
        private Models.GetPeriodResponse currentCycle;
        private string paymentMethod;
        private string currency;
        private int installments;
        private string status;
        private DateTime createdAt;
        private DateTime updatedAt;
        private Models.GetCustomerResponse customer;
        private Models.GetCardResponse card;
        private List<Models.GetSubscriptionItemResponse> items;
        private string statementDescriptor;
        private Dictionary<string, string> metadata;
        private Models.GetSetupResponse setup;
        private string gatewayAffiliationId;
        private DateTime? nextBillingAt;
        private int? billingDay;
        private int? minimumPrice;
        private DateTime? canceledAt;
        private List<Models.GetDiscountResponse> discounts;
        private List<Models.GetIncrementResponse> increments;
        private int? boletoDueDays;
        private Models.GetSubscriptionSplitResponse split;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime StartAt 
        { 
            get 
            {
                return this.startAt; 
            } 
            set 
            {
                this.startAt = value;
                onPropertyChanged("StartAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("interval")]
        public string Interval 
        { 
            get 
            {
                return this.interval; 
            } 
            set 
            {
                this.interval = value;
                onPropertyChanged("Interval");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("interval_count")]
        public int IntervalCount 
        { 
            get 
            {
                return this.intervalCount; 
            } 
            set 
            {
                this.intervalCount = value;
                onPropertyChanged("IntervalCount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType 
        { 
            get 
            {
                return this.billingType; 
            } 
            set 
            {
                this.billingType = value;
                onPropertyChanged("BillingType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("current_cycle")]
        public Models.GetPeriodResponse CurrentCycle 
        { 
            get 
            {
                return this.currentCycle; 
            } 
            set 
            {
                this.currentCycle = value;
                onPropertyChanged("CurrentCycle");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod 
        { 
            get 
            {
                return this.paymentMethod; 
            } 
            set 
            {
                this.paymentMethod = value;
                onPropertyChanged("PaymentMethod");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("installments")]
        public int Installments 
        { 
            get 
            {
                return this.installments; 
            } 
            set 
            {
                this.installments = value;
                onPropertyChanged("Installments");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt 
        { 
            get 
            {
                return this.updatedAt; 
            } 
            set 
            {
                this.updatedAt = value;
                onPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("card")]
        public Models.GetCardResponse Card 
        { 
            get 
            {
                return this.card; 
            } 
            set 
            {
                this.card = value;
                onPropertyChanged("Card");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetSubscriptionItemResponse> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("setup")]
        public Models.GetSetupResponse Setup 
        { 
            get 
            {
                return this.setup; 
            } 
            set 
            {
                this.setup = value;
                onPropertyChanged("Setup");
            }
        }

        /// <summary>
        /// Affiliation Code
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId 
        { 
            get 
            {
                return this.gatewayAffiliationId; 
            } 
            set 
            {
                this.gatewayAffiliationId = value;
                onPropertyChanged("GatewayAffiliationId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_billing_at")]
        public DateTime? NextBillingAt 
        { 
            get 
            {
                return this.nextBillingAt; 
            } 
            set 
            {
                this.nextBillingAt = value;
                onPropertyChanged("NextBillingAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("billing_day")]
        public int? BillingDay 
        { 
            get 
            {
                return this.billingDay; 
            } 
            set 
            {
                this.billingDay = value;
                onPropertyChanged("BillingDay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minimum_price")]
        public int? MinimumPrice 
        { 
            get 
            {
                return this.minimumPrice; 
            } 
            set 
            {
                this.minimumPrice = value;
                onPropertyChanged("MinimumPrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at")]
        public DateTime? CanceledAt 
        { 
            get 
            {
                return this.canceledAt; 
            } 
            set 
            {
                this.canceledAt = value;
                onPropertyChanged("CanceledAt");
            }
        }

        /// <summary>
        /// Subscription discounts
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.GetDiscountResponse> Discounts 
        { 
            get 
            {
                return this.discounts; 
            } 
            set 
            {
                this.discounts = value;
                onPropertyChanged("Discounts");
            }
        }

        /// <summary>
        /// Subscription increments
        /// </summary>
        [JsonProperty("increments")]
        public List<Models.GetIncrementResponse> Increments 
        { 
            get 
            {
                return this.increments; 
            } 
            set 
            {
                this.increments = value;
                onPropertyChanged("Increments");
            }
        }

        /// <summary>
        /// Days until boleto expires
        /// </summary>
        [JsonProperty("boleto_due_days")]
        public int? BoletoDueDays 
        { 
            get 
            {
                return this.boletoDueDays; 
            } 
            set 
            {
                this.boletoDueDays = value;
                onPropertyChanged("BoletoDueDays");
            }
        }

        /// <summary>
        /// Subscription's split response
        /// </summary>
        [JsonProperty("split")]
        public Models.GetSubscriptionSplitResponse Split 
        { 
            get 
            {
                return this.split; 
            } 
            set 
            {
                this.split = value;
                onPropertyChanged("Split");
            }
        }
    }
} 