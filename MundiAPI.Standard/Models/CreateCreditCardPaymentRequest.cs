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
    public class CreateCreditCardPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? installments = 1;
        private string statementDescriptor;
        private Models.CreateCardRequest card;
        private string cardId;
        private string cardToken;
        private bool? recurrence;
        private bool? capture = true;
        private bool? extendedLimitEnabled;
        private string extendedLimitCode;
        private long? merchantCategoryCode;
        private Models.CreatePaymentAuthenticationRequest authentication;
        private Models.CreateCardPaymentTokenRequest token;
        private bool? autoRecovery;

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
        /// The text that will be shown on the credit card's statement
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
        /// Credit card data
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card 
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
        /// The credit card id
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
        /// TODO: Write general description for this method
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
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence")]
        public bool? Recurrence 
        { 
            get 
            {
                return this.recurrence; 
            } 
            set 
            {
                this.recurrence = value;
                onPropertyChanged("Recurrence");
            }
        }

        /// <summary>
        /// Indicates if the operation should be only authorization or auth and capture.
        /// </summary>
        [JsonProperty("capture")]
        public bool? Capture 
        { 
            get 
            {
                return this.capture; 
            } 
            set 
            {
                this.capture = value;
                onPropertyChanged("Capture");
            }
        }

        /// <summary>
        /// Indicates whether the extended label (private label) is enabled
        /// </summary>
        [JsonProperty("extended_limit_enabled")]
        public bool? ExtendedLimitEnabled 
        { 
            get 
            {
                return this.extendedLimitEnabled; 
            } 
            set 
            {
                this.extendedLimitEnabled = value;
                onPropertyChanged("ExtendedLimitEnabled");
            }
        }

        /// <summary>
        /// Extended Limit Code
        /// </summary>
        [JsonProperty("extended_limit_code")]
        public string ExtendedLimitCode 
        { 
            get 
            {
                return this.extendedLimitCode; 
            } 
            set 
            {
                this.extendedLimitCode = value;
                onPropertyChanged("ExtendedLimitCode");
            }
        }

        /// <summary>
        /// Customer business segment code
        /// </summary>
        [JsonProperty("merchant_category_code")]
        public long? MerchantCategoryCode 
        { 
            get 
            {
                return this.merchantCategoryCode; 
            } 
            set 
            {
                this.merchantCategoryCode = value;
                onPropertyChanged("MerchantCategoryCode");
            }
        }

        /// <summary>
        /// The payment authentication request
        /// </summary>
        [JsonProperty("authentication")]
        public Models.CreatePaymentAuthenticationRequest Authentication 
        { 
            get 
            {
                return this.authentication; 
            } 
            set 
            {
                this.authentication = value;
                onPropertyChanged("Authentication");
            }
        }

        /// <summary>
        /// The Credit card payment token request
        /// </summary>
        [JsonProperty("token")]
        public Models.CreateCardPaymentTokenRequest Token 
        { 
            get 
            {
                return this.token; 
            } 
            set 
            {
                this.token = value;
                onPropertyChanged("Token");
            }
        }

        /// <summary>
        /// Indicates whether a particular payment will enter the offline retry flow
        /// </summary>
        [JsonProperty("auto_recovery")]
        public bool? AutoRecovery 
        { 
            get 
            {
                return this.autoRecovery; 
            } 
            set 
            {
                this.autoRecovery = value;
                onPropertyChanged("AutoRecovery");
            }
        }
    }
} 