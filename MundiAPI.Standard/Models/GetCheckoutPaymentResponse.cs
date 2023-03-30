// <copyright file="GetCheckoutPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutPaymentResponse.
    /// </summary>
    public class GetCheckoutPaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="defaultPaymentMethod">default_payment_method.</param>
        /// <param name="successUrl">success_url.</param>
        /// <param name="paymentUrl">payment_url.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="acceptedPaymentMethods">accepted_payment_methods.</param>
        /// <param name="status">status.</param>
        /// <param name="skipCheckoutSuccessPage">skip_checkout_success_page.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="customerEditable">customer_editable.</param>
        /// <param name="billingaddress">billingaddress.</param>
        /// <param name="creditCard">credit_card.</param>
        /// <param name="boleto">boleto.</param>
        /// <param name="billingAddressEditable">billing_address_editable.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="shippable">shippable.</param>
        /// <param name="currency">currency.</param>
        /// <param name="acceptedBrands">accepted_brands.</param>
        /// <param name="amount">amount.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="customer">customer.</param>
        /// <param name="closedAt">closed_at.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="debitCard">debit_card.</param>
        /// <param name="bankTransfer">bank_transfer.</param>
        public GetCheckoutPaymentResponse(
            string id,
            string defaultPaymentMethod,
            string successUrl,
            string paymentUrl,
            string gatewayAffiliationId,
            List<string> acceptedPaymentMethods,
            string status,
            bool skipCheckoutSuccessPage,
            DateTime createdAt,
            DateTime updatedAt,
            bool customerEditable,
            Models.GetAddressResponse billingaddress,
            Models.GetCheckoutCreditCardPaymentResponse creditCard,
            Models.GetCheckoutBoletoPaymentResponse boleto,
            bool billingAddressEditable,
            Models.GetShippingResponse shipping,
            bool shippable,
            string currency,
            List<string> acceptedBrands,
            int? amount = null,
            DateTime? canceledAt = null,
            Models.GetCustomerResponse customer = null,
            DateTime? closedAt = null,
            DateTime? expiresAt = null,
            Models.GetCheckoutDebitCardPaymentResponse debitCard = null,
            Models.GetCheckoutBankTransferPaymentResponse bankTransfer = null)
        {
            this.Id = id;
            this.Amount = amount;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.SuccessUrl = successUrl;
            this.PaymentUrl = paymentUrl;
            this.GatewayAffiliationId = gatewayAffiliationId;
            this.AcceptedPaymentMethods = acceptedPaymentMethods;
            this.Status = status;
            this.SkipCheckoutSuccessPage = skipCheckoutSuccessPage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CanceledAt = canceledAt;
            this.CustomerEditable = customerEditable;
            this.Customer = customer;
            this.Billingaddress = billingaddress;
            this.CreditCard = creditCard;
            this.Boleto = boleto;
            this.BillingAddressEditable = billingAddressEditable;
            this.Shipping = shipping;
            this.Shippable = shippable;
            this.ClosedAt = closedAt;
            this.ExpiresAt = expiresAt;
            this.Currency = currency;
            this.DebitCard = debitCard;
            this.BankTransfer = bankTransfer;
            this.AcceptedBrands = acceptedBrands;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Valor em centavos
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Meio de pagamento padrão no checkout
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Url de redirecionamento de sucesso após o checkou
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Url para pagamento usando o checkout
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// Código da afiliação onde o pagamento será processado no gateway
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// Meios de pagamento aceitos no checkout
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods { get; set; }

        /// <summary>
        /// Status do checkout
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Pular tela de sucesso pós-pagamento?
        /// </summary>
        [JsonProperty("skip_checkout_success_page")]
        public bool SkipCheckoutSuccessPage { get; set; }

        /// <summary>
        /// Data de criação
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Data de atualização
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Data de cancelamento
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Torna o objeto customer editável
        /// </summary>
        [JsonProperty("customer_editable")]
        public bool CustomerEditable { get; set; }

        /// <summary>
        /// Dados do comprador
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCustomerResponse Customer { get; set; }

        /// <summary>
        /// Dados do endereço de cobrança
        /// </summary>
        [JsonProperty("billingaddress")]
        public Models.GetAddressResponse Billingaddress { get; set; }

        /// <summary>
        /// Configurações de cartão de crédito
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.GetCheckoutCreditCardPaymentResponse CreditCard { get; set; }

        /// <summary>
        /// Configurações de boleto
        /// </summary>
        [JsonProperty("boleto")]
        public Models.GetCheckoutBoletoPaymentResponse Boleto { get; set; }

        /// <summary>
        /// Indica se o billing address poderá ser editado
        /// </summary>
        [JsonProperty("billing_address_editable")]
        public bool BillingAddressEditable { get; set; }

        /// <summary>
        /// Configurações  de entrega
        /// </summary>
        [JsonProperty("shipping")]
        public Models.GetShippingResponse Shipping { get; set; }

        /// <summary>
        /// Indica se possui entrega
        /// </summary>
        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        /// <summary>
        /// Data de fechamento
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Data de expiração
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Moeda
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Configurações de cartão de débito
        /// </summary>
        [JsonProperty("debit_card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCheckoutDebitCardPaymentResponse DebitCard { get; set; }

        /// <summary>
        /// Bank transfer payment response
        /// </summary>
        [JsonProperty("bank_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetCheckoutBankTransferPaymentResponse BankTransfer { get; set; }

        /// <summary>
        /// Accepted Brands
        /// </summary>
        [JsonProperty("accepted_brands")]
        public List<string> AcceptedBrands { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutPaymentResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutPaymentResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.DefaultPaymentMethod == null && other.DefaultPaymentMethod == null) || (this.DefaultPaymentMethod?.Equals(other.DefaultPaymentMethod) == true)) &&
                ((this.SuccessUrl == null && other.SuccessUrl == null) || (this.SuccessUrl?.Equals(other.SuccessUrl) == true)) &&
                ((this.PaymentUrl == null && other.PaymentUrl == null) || (this.PaymentUrl?.Equals(other.PaymentUrl) == true)) &&
                ((this.GatewayAffiliationId == null && other.GatewayAffiliationId == null) || (this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true)) &&
                ((this.AcceptedPaymentMethods == null && other.AcceptedPaymentMethods == null) || (this.AcceptedPaymentMethods?.Equals(other.AcceptedPaymentMethods) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.SkipCheckoutSuccessPage.Equals(other.SkipCheckoutSuccessPage) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                this.CustomerEditable.Equals(other.CustomerEditable) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Billingaddress == null && other.Billingaddress == null) || (this.Billingaddress?.Equals(other.Billingaddress) == true)) &&
                ((this.CreditCard == null && other.CreditCard == null) || (this.CreditCard?.Equals(other.CreditCard) == true)) &&
                ((this.Boleto == null && other.Boleto == null) || (this.Boleto?.Equals(other.Boleto) == true)) &&
                this.BillingAddressEditable.Equals(other.BillingAddressEditable) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                this.Shippable.Equals(other.Shippable) &&
                ((this.ClosedAt == null && other.ClosedAt == null) || (this.ClosedAt?.Equals(other.ClosedAt) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.DebitCard == null && other.DebitCard == null) || (this.DebitCard?.Equals(other.DebitCard) == true)) &&
                ((this.BankTransfer == null && other.BankTransfer == null) || (this.BankTransfer?.Equals(other.BankTransfer) == true)) &&
                ((this.AcceptedBrands == null && other.AcceptedBrands == null) || (this.AcceptedBrands?.Equals(other.AcceptedBrands) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.DefaultPaymentMethod = {(this.DefaultPaymentMethod == null ? "null" : this.DefaultPaymentMethod == string.Empty ? "" : this.DefaultPaymentMethod)}");
            toStringOutput.Add($"this.SuccessUrl = {(this.SuccessUrl == null ? "null" : this.SuccessUrl == string.Empty ? "" : this.SuccessUrl)}");
            toStringOutput.Add($"this.PaymentUrl = {(this.PaymentUrl == null ? "null" : this.PaymentUrl == string.Empty ? "" : this.PaymentUrl)}");
            toStringOutput.Add($"this.GatewayAffiliationId = {(this.GatewayAffiliationId == null ? "null" : this.GatewayAffiliationId == string.Empty ? "" : this.GatewayAffiliationId)}");
            toStringOutput.Add($"this.AcceptedPaymentMethods = {(this.AcceptedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AcceptedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.SkipCheckoutSuccessPage = {this.SkipCheckoutSuccessPage}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"this.CustomerEditable = {this.CustomerEditable}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Billingaddress = {(this.Billingaddress == null ? "null" : this.Billingaddress.ToString())}");
            toStringOutput.Add($"this.CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"this.Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"this.BillingAddressEditable = {this.BillingAddressEditable}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"this.Shippable = {this.Shippable}");
            toStringOutput.Add($"this.ClosedAt = {(this.ClosedAt == null ? "null" : this.ClosedAt.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.DebitCard = {(this.DebitCard == null ? "null" : this.DebitCard.ToString())}");
            toStringOutput.Add($"this.BankTransfer = {(this.BankTransfer == null ? "null" : this.BankTransfer.ToString())}");
            toStringOutput.Add($"this.AcceptedBrands = {(this.AcceptedBrands == null ? "null" : $"[{string.Join(", ", this.AcceptedBrands)} ]")}");
        }
    }
}