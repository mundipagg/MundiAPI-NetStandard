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
    public class CreateSubscriptionRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Customer8 customer;
        private Models.Card1 card;
        private string code;
        private string paymentMethod;
        private string billingType;
        private string statementDescriptor;
        private string description;
        private string currency;
        private string interval;
        private int intervalCount;
        private Models.PricingScheme4 pricingScheme;
        private List<Models.CreateSubscriptionItemRequest> items;
        private Models.Shipping3 shipping;
        private List<Models.CreateDiscountRequest> discounts;
        private Dictionary<string, string> metadata;
        private Models.Setup1 setup;
        private string planId;
        private string customerId;
        private string cardId;
        private int? billingDay;
        private int? installments;
        private DateTime? startAt;
        private int? minimumPrice;
        private int? cycles;
        private string cardToken;
        private string gatewayAffiliationId;
        private int? quantity;
        private int? boletoDueDays;
        private List<Models.CreateIncrementRequest> increments;
        private Models.CreatePeriodRequest period;
        private Models.Submerchant submerchant;
        private Models.UpdateSubscriptionSplitRequest split;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("customer")]
        public Models.Customer8 Customer 
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
        public Models.Card1 Card 
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
        /// Subscription code
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
        /// Payment method
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
        /// Billing type
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
        /// Statement descriptor for credit card subscriptions
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
        /// Subscription description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Currency
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
        /// Interval
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
        /// Interval count
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
        [JsonProperty("pricing_scheme")]
        public Models.PricingScheme4 PricingScheme 
        { 
            get 
            {
                return this.pricingScheme; 
            } 
            set 
            {
                this.pricingScheme = value;
                onPropertyChanged("PricingScheme");
            }
        }

        /// <summary>
        /// Subscription items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreateSubscriptionItemRequest> Items 
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
        [JsonProperty("shipping")]
        public Models.Shipping3 Shipping 
        { 
            get 
            {
                return this.shipping; 
            } 
            set 
            {
                this.shipping = value;
                onPropertyChanged("Shipping");
            }
        }

        /// <summary>
        /// Discounts
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.CreateDiscountRequest> Discounts 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("setup")]
        public Models.Setup1 Setup 
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
        /// Plan id
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId 
        { 
            get 
            {
                return this.planId; 
            } 
            set 
            {
                this.planId = value;
                onPropertyChanged("PlanId");
            }
        }

        /// <summary>
        /// Customer id
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
        /// Card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId 
        { 
            get 
            {
                return this.cardId; 
            } 
            set 
            {
                this.cardId = value;
                onPropertyChanged("CardId");
            }
        }

        /// <summary>
        /// Billing day
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
        /// Number of installments
        /// </summary>
        [JsonProperty("installments")]
        public int? Installments 
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
        /// Subscription start date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime? StartAt 
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
        /// Subscription minimum price
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
        /// Number of cycles
        /// </summary>
        [JsonProperty("cycles")]
        public int? Cycles 
        { 
            get 
            {
                return this.cycles; 
            } 
            set 
            {
                this.cycles = value;
                onPropertyChanged("Cycles");
            }
        }

        /// <summary>
        /// Card token
        /// </summary>
        [JsonProperty("card_token")]
        public string CardToken 
        { 
            get 
            {
                return this.cardToken; 
            } 
            set 
            {
                this.cardToken = value;
                onPropertyChanged("CardToken");
            }
        }

        /// <summary>
        /// Gateway Affiliation code
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
        /// Quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
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
        /// Increments
        /// </summary>
        [JsonProperty("increments")]
        public List<Models.CreateIncrementRequest> Increments 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("period")]
        public Models.CreatePeriodRequest Period 
        { 
            get 
            {
                return this.period; 
            } 
            set 
            {
                this.period = value;
                onPropertyChanged("Period");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("submerchant")]
        public Models.Submerchant Submerchant 
        { 
            get 
            {
                return this.submerchant; 
            } 
            set 
            {
                this.submerchant = value;
                onPropertyChanged("Submerchant");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("split")]
        public Models.UpdateSubscriptionSplitRequest Split 
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