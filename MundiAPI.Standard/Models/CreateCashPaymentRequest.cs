/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
    public class CreateCashPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string description;
        private bool confirm;

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
        /// Indicates whether cash collection will be confirmed in the act of creation
        /// </summary>
        [JsonProperty("confirm")]
        public bool Confirm 
        { 
            get 
            {
                return this.confirm; 
            } 
            set 
            {
                this.confirm = value;
                onPropertyChanged("Confirm");
            }
        }
    }
} 