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
    public class ChargesCardResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string code;
        private string gatewayId;
        private int amount;
        private string status;
        private string currency;
        private string paymentMethod;
        private DateTime dueAt;
        private DateTime createdAt;
        private DateTime updatedAt;
        private Models.GetTransactionResponse lastTransaction;
        private Models.Invoice invoice;
        private Models.Order order;
        private Models.Customer customer;
        private Dictionary<string, string> metadata;
        private DateTime? paidAt;
        private DateTime? canceledAt;
        private int canceledAmount;
        private int paidAmount;
        private string recurrencyCycle;
        private int? interestAndFinePaid;

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
        [JsonProperty("gateway_id")]
        public string GatewayId 
        { 
            get 
            {
                return this.gatewayId; 
            } 
            set 
            {
                this.gatewayId = value;
                onPropertyChanged("GatewayId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime DueAt 
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
        [JsonProperty("last_transaction")]
        public Models.GetTransactionResponse LastTransaction 
        { 
            get 
            {
                return this.lastTransaction; 
            } 
            set 
            {
                this.lastTransaction = value;
                onPropertyChanged("LastTransaction");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoice")]
        public Models.Invoice Invoice 
        { 
            get 
            {
                return this.invoice; 
            } 
            set 
            {
                this.invoice = value;
                onPropertyChanged("Invoice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("order")]
        public Models.Order Order 
        { 
            get 
            {
                return this.order; 
            } 
            set 
            {
                this.order = value;
                onPropertyChanged("Order");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("customer")]
        public Models.Customer Customer 
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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at")]
        public DateTime? PaidAt 
        { 
            get 
            {
                return this.paidAt; 
            } 
            set 
            {
                this.paidAt = value;
                onPropertyChanged("PaidAt");
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
        /// Canceled Amount
        /// </summary>
        [JsonProperty("canceled_amount")]
        public int CanceledAmount 
        { 
            get 
            {
                return this.canceledAmount; 
            } 
            set 
            {
                this.canceledAmount = value;
                onPropertyChanged("CanceledAmount");
            }
        }

        /// <summary>
        /// Paid amount
        /// </summary>
        [JsonProperty("paid_amount")]
        public int PaidAmount 
        { 
            get 
            {
                return this.paidAmount; 
            } 
            set 
            {
                this.paidAmount = value;
                onPropertyChanged("PaidAmount");
            }
        }

        /// <summary>
        /// Defines whether the card has been used one or more times.
        /// </summary>
        [JsonProperty("recurrency_cycle")]
        public string RecurrencyCycle 
        { 
            get 
            {
                return this.recurrencyCycle; 
            } 
            set 
            {
                this.recurrencyCycle = value;
                onPropertyChanged("RecurrencyCycle");
            }
        }

        /// <summary>
        /// interest and fine paid
        /// </summary>
        [JsonProperty("interest_and_fine_paid")]
        public int? InterestAndFinePaid 
        { 
            get 
            {
                return this.interestAndFinePaid; 
            } 
            set 
            {
                this.interestAndFinePaid = value;
                onPropertyChanged("InterestAndFinePaid");
            }
        }
    }
} 