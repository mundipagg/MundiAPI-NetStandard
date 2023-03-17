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
    public class Cycle : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime startAt;
        private DateTime endAt;
        private string id;
        private DateTime billingAt;
        private Models.GetSubscriptionResponse subscription;
        private string status;
        private int duration;
        private string createdAt;
        private string updatedAt;
        private int cycle;

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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_at")]
        public DateTime EndAt 
        { 
            get 
            {
                return this.endAt; 
            } 
            set 
            {
                this.endAt = value;
                onPropertyChanged("EndAt");
            }
        }

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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_at")]
        public DateTime BillingAt 
        { 
            get 
            {
                return this.billingAt; 
            } 
            set 
            {
                this.billingAt = value;
                onPropertyChanged("BillingAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription 
        { 
            get 
            {
                return this.subscription; 
            } 
            set 
            {
                this.subscription = value;
                onPropertyChanged("Subscription");
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
        [JsonProperty("duration")]
        public int Duration 
        { 
            get 
            {
                return this.duration; 
            } 
            set 
            {
                this.duration = value;
                onPropertyChanged("Duration");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt 
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
        [JsonProperty("updated_at")]
        public string UpdatedAt 
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
        [JsonProperty("cycle")]
        public int CycleProp 
        { 
            get 
            {
                return this.cycle; 
            } 
            set 
            {
                this.cycle = value;
                onPropertyChanged("CycleProp");
            }
        }
    }
} 