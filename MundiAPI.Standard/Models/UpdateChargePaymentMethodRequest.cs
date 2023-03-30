// <copyright file="UpdateChargePaymentMethodRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using MundiAPI.Standard;
    using MundiAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UpdateChargePaymentMethodRequest.
    /// </summary>
    public class UpdateChargePaymentMethodRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargePaymentMethodRequest"/> class.
        /// </summary>
        public UpdateChargePaymentMethodRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargePaymentMethodRequest"/> class.
        /// </summary>
        /// <param name="updateSubscription">update_subscription.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="creditCard">credit_card.</param>
        /// <param name="debitCard">debit_card.</param>
        /// <param name="boleto">boleto.</param>
        /// <param name="voucher">voucher.</param>
        /// <param name="cash">cash.</param>
        /// <param name="bankTransfer">bank_transfer.</param>
        /// <param name="privateLabel">private_label.</param>
        public UpdateChargePaymentMethodRequest(
            bool updateSubscription,
            string paymentMethod,
            Models.CreateCreditCardPaymentRequest creditCard,
            Models.CreateDebitCardPaymentRequest debitCard,
            Models.CreateBoletoPaymentRequest boleto,
            Models.CreateVoucherPaymentRequest voucher,
            Models.CreateCashPaymentRequest cash,
            Models.CreateBankTransferPaymentRequest bankTransfer,
            Models.CreatePrivateLabelPaymentRequest privateLabel)
        {
            this.UpdateSubscription = updateSubscription;
            this.PaymentMethod = paymentMethod;
            this.CreditCard = creditCard;
            this.DebitCard = debitCard;
            this.Boleto = boleto;
            this.Voucher = voucher;
            this.Cash = cash;
            this.BankTransfer = bankTransfer;
            this.PrivateLabel = privateLabel;
        }

        /// <summary>
        /// Indicates if the payment method from the subscription must also be updated
        /// </summary>
        [JsonProperty("update_subscription")]
        public bool UpdateSubscription { get; set; }

        /// <summary>
        /// The new payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Credit card data
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCreditCardPaymentRequest CreditCard { get; set; }

        /// <summary>
        /// Debit card data
        /// </summary>
        [JsonProperty("debit_card")]
        public Models.CreateDebitCardPaymentRequest DebitCard { get; set; }

        /// <summary>
        /// Boleto data
        /// </summary>
        [JsonProperty("boleto")]
        public Models.CreateBoletoPaymentRequest Boleto { get; set; }

        /// <summary>
        /// Voucher data
        /// </summary>
        [JsonProperty("voucher")]
        public Models.CreateVoucherPaymentRequest Voucher { get; set; }

        /// <summary>
        /// Cash data
        /// </summary>
        [JsonProperty("cash")]
        public Models.CreateCashPaymentRequest Cash { get; set; }

        /// <summary>
        /// Bank Transfer data
        /// </summary>
        [JsonProperty("bank_transfer")]
        public Models.CreateBankTransferPaymentRequest BankTransfer { get; set; }

        /// <summary>
        /// Gets or sets PrivateLabel.
        /// </summary>
        [JsonProperty("private_label")]
        public Models.CreatePrivateLabelPaymentRequest PrivateLabel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateChargePaymentMethodRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is UpdateChargePaymentMethodRequest other &&
                this.UpdateSubscription.Equals(other.UpdateSubscription) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.CreditCard == null && other.CreditCard == null) || (this.CreditCard?.Equals(other.CreditCard) == true)) &&
                ((this.DebitCard == null && other.DebitCard == null) || (this.DebitCard?.Equals(other.DebitCard) == true)) &&
                ((this.Boleto == null && other.Boleto == null) || (this.Boleto?.Equals(other.Boleto) == true)) &&
                ((this.Voucher == null && other.Voucher == null) || (this.Voucher?.Equals(other.Voucher) == true)) &&
                ((this.Cash == null && other.Cash == null) || (this.Cash?.Equals(other.Cash) == true)) &&
                ((this.BankTransfer == null && other.BankTransfer == null) || (this.BankTransfer?.Equals(other.BankTransfer) == true)) &&
                ((this.PrivateLabel == null && other.PrivateLabel == null) || (this.PrivateLabel?.Equals(other.PrivateLabel) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UpdateSubscription = {this.UpdateSubscription}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"this.DebitCard = {(this.DebitCard == null ? "null" : this.DebitCard.ToString())}");
            toStringOutput.Add($"this.Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"this.Voucher = {(this.Voucher == null ? "null" : this.Voucher.ToString())}");
            toStringOutput.Add($"this.Cash = {(this.Cash == null ? "null" : this.Cash.ToString())}");
            toStringOutput.Add($"this.BankTransfer = {(this.BankTransfer == null ? "null" : this.BankTransfer.ToString())}");
            toStringOutput.Add($"this.PrivateLabel = {(this.PrivateLabel == null ? "null" : this.PrivateLabel.ToString())}");
        }
    }
}