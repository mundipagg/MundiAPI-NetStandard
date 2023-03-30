
# Create Checkout Payment Request

Checkout payment request

## Structure

`CreateCheckoutPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcceptedPaymentMethods` | `List<string>` | Required | Accepted Payment Methods |
| `AcceptedMultiPaymentMethods` | `object` | Required | Accepted Multi Payment Methods |
| `SuccessUrl` | `string` | Required | Success url |
| `DefaultPaymentMethod` | `string` | Optional | Default payment method |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation Id |
| `CreditCard` | [`Models.CreateCheckoutCreditCardPaymentRequest`](../../doc/models/create-checkout-credit-card-payment-request.md) | Optional | Credit Card payment request |
| `DebitCard` | [`Models.CreateCheckoutDebitCardPaymentRequest`](../../doc/models/create-checkout-debit-card-payment-request.md) | Optional | Debit Card payment request |
| `Boleto` | [`Models.CreateCheckoutBoletoPaymentRequest`](../../doc/models/create-checkout-boleto-payment-request.md) | Optional | Boleto payment request |
| `CustomerEditable` | `bool?` | Optional | Customer is editable? |
| `ExpiresIn` | `int?` | Optional | Time in minutes for expiration |
| `SkipCheckoutSuccessPage` | `bool` | Required | Skip postpay success screen? |
| `BillingAddressEditable` | `bool` | Required | Billing Address is editable? |
| `BillingAddress` | [`Models.CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Billing Address |
| `BankTransfer` | [`Models.CreateCheckoutBankTransferRequest`](../../doc/models/create-checkout-bank-transfer-request.md) | Required | Bank Transfer payment request |
| `AcceptedBrands` | `List<string>` | Required | Accepted Brands |

## Example (as JSON)

```json
{
  "accepted_payment_methods": [
    "accepted_payment_methods3",
    "accepted_payment_methods4",
    "accepted_payment_methods5"
  ],
  "accepted_multi_payment_methods": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "success_url": "success_url2",
  "default_payment_method": null,
  "gateway_affiliation_id": null,
  "credit_card": null,
  "debit_card": null,
  "boleto": null,
  "customer_editable": null,
  "expires_in": null,
  "skip_checkout_success_page": false,
  "billing_address_editable": false,
  "billing_address": {
    "street": "street8",
    "number": "number4",
    "zip_code": "zip_code2",
    "neighborhood": "neighborhood4",
    "city": "city2",
    "state": "state6",
    "country": "country2",
    "complement": "complement6",
    "metadata": {
      "key0": "metadata5",
      "key1": "metadata6"
    },
    "line_1": "line_18",
    "line_2": "line_26"
  },
  "bank_transfer": {
    "bank": [
      "bank9",
      "bank0"
    ],
    "retries": 236
  },
  "accepted_brands": [
    "accepted_brands8",
    "accepted_brands9"
  ]
}
```

