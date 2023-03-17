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
    public class RecipientsRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string email;
        private string description;
        private string document;
        private string type;
        private Models.DefaultBankAccount1 defaultBankAccount;
        private Dictionary<string, string> metadata;
        private Models.GetTransferSettingsResponse transferSettings;
        private string code;
        private string paymentMode;

        /// <summary>
        /// Recipient name
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Recipient email
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Recipient description
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
        /// Recipient document number
        /// </summary>
        [JsonProperty("document")]
        public string Document 
        { 
            get 
            {
                return this.document; 
            } 
            set 
            {
                this.document = value;
                onPropertyChanged("Document");
            }
        }

        /// <summary>
        /// Recipient type
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("default_bank_account")]
        public Models.DefaultBankAccount1 DefaultBankAccount 
        { 
            get 
            {
                return this.defaultBankAccount; 
            } 
            set 
            {
                this.defaultBankAccount = value;
                onPropertyChanged("DefaultBankAccount");
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
        [JsonProperty("transfer_settings")]
        public Models.GetTransferSettingsResponse TransferSettings 
        { 
            get 
            {
                return this.transferSettings; 
            } 
            set 
            {
                this.transferSettings = value;
                onPropertyChanged("TransferSettings");
            }
        }

        /// <summary>
        /// Recipient code
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
        /// Payment mode
        /// </summary>
        [JsonProperty("payment_mode")]
        public string PaymentMode 
        { 
            get 
            {
                return this.paymentMode; 
            } 
            set 
            {
                this.paymentMode = value;
                onPropertyChanged("PaymentMode");
            }
        }
    }
} 