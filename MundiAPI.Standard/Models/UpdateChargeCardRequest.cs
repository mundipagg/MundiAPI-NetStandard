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
    public class UpdateChargeCardRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool updateSubscription;
        private string cardId;
        private Models.Card1 card;
        private bool recurrence;

        /// <summary>
        /// Indicates if the subscriptions using this card must also be updated
        /// </summary>
        [JsonProperty("update_subscription")]
        public bool UpdateSubscription 
        { 
            get 
            {
                return this.updateSubscription; 
            } 
            set 
            {
                this.updateSubscription = value;
                onPropertyChanged("UpdateSubscription");
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
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence")]
        public bool Recurrence 
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
    }
} 