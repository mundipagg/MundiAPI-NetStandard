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
    public class Boleto1 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int retries;
        private string bank;
        private string instructions;
        private DateTime? dueAt;
        private Models.BillingAddress1 billingAddress;
        private string billingAddressId;
        private string nossoNumero;
        private string documentNumber;
        private Models.Interest interest;
        private Models.Fine fine;
        private int? maxDaysToPayPastDue;

        /// <summary>
        /// Number of retries
        /// </summary>
        [JsonProperty("retries")]
        public int Retries 
        { 
            get 
            {
                return this.retries; 
            } 
            set 
            {
                this.retries = value;
                onPropertyChanged("Retries");
            }
        }

        /// <summary>
        /// The bank code, containing three characters. The available codes are on the API specification
        /// </summary>
        [JsonProperty("bank")]
        public string Bank 
        { 
            get 
            {
                return this.bank; 
            } 
            set 
            {
                this.bank = value;
                onPropertyChanged("Bank");
            }
        }

        /// <summary>
        /// The instructions field that will be printed on the boleto.
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions 
        { 
            get 
            {
                return this.instructions; 
            } 
            set 
            {
                this.instructions = value;
                onPropertyChanged("Instructions");
            }
        }

        /// <summary>
        /// Boleto due date
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
        [JsonProperty("billing_address")]
        public Models.BillingAddress1 BillingAddress 
        { 
            get 
            {
                return this.billingAddress; 
            } 
            set 
            {
                this.billingAddress = value;
                onPropertyChanged("BillingAddress");
            }
        }

        /// <summary>
        /// The address id for the billing address
        /// </summary>
        [JsonProperty("billing_address_id")]
        public string BillingAddressId 
        { 
            get 
            {
                return this.billingAddressId; 
            } 
            set 
            {
                this.billingAddressId = value;
                onPropertyChanged("BillingAddressId");
            }
        }

        /// <summary>
        /// Customer identification number with the bank
        /// </summary>
        [JsonProperty("nosso_numero")]
        public string NossoNumero 
        { 
            get 
            {
                return this.nossoNumero; 
            } 
            set 
            {
                this.nossoNumero = value;
                onPropertyChanged("NossoNumero");
            }
        }

        /// <summary>
        /// Boleto identification
        /// </summary>
        [JsonProperty("document_number")]
        public string DocumentNumber 
        { 
            get 
            {
                return this.documentNumber; 
            } 
            set 
            {
                this.documentNumber = value;
                onPropertyChanged("DocumentNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("interest")]
        public Models.Interest Interest 
        { 
            get 
            {
                return this.interest; 
            } 
            set 
            {
                this.interest = value;
                onPropertyChanged("Interest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fine")]
        public Models.Fine Fine 
        { 
            get 
            {
                return this.fine; 
            } 
            set 
            {
                this.fine = value;
                onPropertyChanged("Fine");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("max_days_to_pay_past_due")]
        public int? MaxDaysToPayPastDue 
        { 
            get 
            {
                return this.maxDaysToPayPastDue; 
            } 
            set 
            {
                this.maxDaysToPayPastDue = value;
                onPropertyChanged("MaxDaysToPayPastDue");
            }
        }
    }
} 