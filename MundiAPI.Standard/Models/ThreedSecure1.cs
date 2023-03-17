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
    public class ThreedSecure1 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mpi;
        private string cavv;
        private string eci;
        private string transactionId;
        private string successUrl;
        private string dsTransactionId;
        private string version;

        /// <summary>
        /// The MPI Vendor (MerchantPlugin)
        /// </summary>
        [JsonProperty("mpi")]
        public string Mpi 
        { 
            get 
            {
                return this.mpi; 
            } 
            set 
            {
                this.mpi = value;
                onPropertyChanged("Mpi");
            }
        }

        /// <summary>
        /// The Cardholder Authentication Verification value
        /// </summary>
        [JsonProperty("cavv")]
        public string Cavv 
        { 
            get 
            {
                return this.cavv; 
            } 
            set 
            {
                this.cavv = value;
                onPropertyChanged("Cavv");
            }
        }

        /// <summary>
        /// The Electronic Commerce Indicator value
        /// </summary>
        [JsonProperty("eci")]
        public string Eci 
        { 
            get 
            {
                return this.eci; 
            } 
            set 
            {
                this.eci = value;
                onPropertyChanged("Eci");
            }
        }

        /// <summary>
        /// The TransactionId value (XID)
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId 
        { 
            get 
            {
                return this.transactionId; 
            } 
            set 
            {
                this.transactionId = value;
                onPropertyChanged("TransactionId");
            }
        }

        /// <summary>
        /// The success URL after the authentication
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl 
        { 
            get 
            {
                return this.successUrl; 
            } 
            set 
            {
                this.successUrl = value;
                onPropertyChanged("SuccessUrl");
            }
        }

        /// <summary>
        /// Directory Service Transaction Identifier
        /// </summary>
        [JsonProperty("ds_transaction_id")]
        public string DsTransactionId 
        { 
            get 
            {
                return this.dsTransactionId; 
            } 
            set 
            {
                this.dsTransactionId = value;
                onPropertyChanged("DsTransactionId");
            }
        }

        /// <summary>
        /// ThreeDSecure Version
        /// </summary>
        [JsonProperty("version")]
        public string Version 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("Version");
            }
        }
    }
} 