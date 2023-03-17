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
    public class ListChargeTransactionsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.GetTransactionResponse> data;
        private Models.Paging paging;

        /// <summary>
        /// The charge transactions objects
        /// </summary>
        [JsonProperty("data")]
        public List<Models.GetTransactionResponse> Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paging")]
        public Models.Paging Paging 
        { 
            get 
            {
                return this.paging; 
            } 
            set 
            {
                this.paging = value;
                onPropertyChanged("Paging");
            }
        }
    }
} 