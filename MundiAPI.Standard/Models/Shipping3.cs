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
    public class Shipping3 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int amount;
        private string description;
        private string recipientName;
        private string recipientPhone;
        private string addressId;
        private Models.Address1 address;
        private DateTime? maxDeliveryDate;
        private DateTime? estimatedDeliveryDate;
        private string type;

        /// <summary>
        /// Shipping amount
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
        /// Description
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
        /// Recipient name
        /// </summary>
        [JsonProperty("recipient_name")]
        public string RecipientName 
        { 
            get 
            {
                return this.recipientName; 
            } 
            set 
            {
                this.recipientName = value;
                onPropertyChanged("RecipientName");
            }
        }

        /// <summary>
        /// Recipient phone number
        /// </summary>
        [JsonProperty("recipient_phone")]
        public string RecipientPhone 
        { 
            get 
            {
                return this.recipientPhone; 
            } 
            set 
            {
                this.recipientPhone = value;
                onPropertyChanged("RecipientPhone");
            }
        }

        /// <summary>
        /// The id of the address that will be used for shipping
        /// </summary>
        [JsonProperty("address_id")]
        public string AddressId 
        { 
            get 
            {
                return this.addressId; 
            } 
            set 
            {
                this.addressId = value;
                onPropertyChanged("AddressId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("address")]
        public Models.Address1 Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Data máxima de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("max_delivery_date")]
        public DateTime? MaxDeliveryDate 
        { 
            get 
            {
                return this.maxDeliveryDate; 
            } 
            set 
            {
                this.maxDeliveryDate = value;
                onPropertyChanged("MaxDeliveryDate");
            }
        }

        /// <summary>
        /// Prazo estimado de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("estimated_delivery_date")]
        public DateTime? EstimatedDeliveryDate 
        { 
            get 
            {
                return this.estimatedDeliveryDate; 
            } 
            set 
            {
                this.estimatedDeliveryDate = value;
                onPropertyChanged("EstimatedDeliveryDate");
            }
        }

        /// <summary>
        /// Shipping type
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
    }
} 