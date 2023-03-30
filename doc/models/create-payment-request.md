
# Create Payment Request

Payment data

## Structure

`CreatePaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentMethod` | `string` | Required | Payment method |
| `CreditCard` | [`Models.CreateCreditCardPaymentRequest`](../../doc/models/create-credit-card-payment-request.md) | Optional | Settings for credit card payment |
| `DebitCard` | [`Models.CreateDebitCardPaymentRequest`](../../doc/models/create-debit-card-payment-request.md) | Optional | Settings for debit card payment |
| `Boleto` | [`Models.CreateBoletoPaymentRequest`](../../doc/models/create-boleto-payment-request.md) | Optional | Settings for boleto payment |
| `Currency` | `string` | Optional | Currency. Must be informed using 3 characters |
| `Voucher` | [`Models.CreateVoucherPaymentRequest`](../../doc/models/create-voucher-payment-request.md) | Optional | Settings for voucher payment |
| `Split` | [`List<Models.CreateSplitRequest>`](../../doc/models/create-split-request.md) | Optional | Splits |
| `BankTransfer` | [`Models.CreateBankTransferPaymentRequest`](../../doc/models/create-bank-transfer-payment-request.md) | Optional | Settings for bank transfer payment |
| `GatewayAffiliationId` | `string` | Optional | Gateway affiliation code |
| `Amount` | `int?` | Optional | The amount of the payment, in cents |
| `Checkout` | [`Models.CreateCheckoutPaymentRequest`](../../doc/models/create-checkout-payment-request.md) | Optional | Settings for checkout payment |
| `CustomerId` | `string` | Optional | Customer Id |
| `Customer` | [`Models.CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Optional | Customer |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `Cash` | [`Models.CreateCashPaymentRequest`](../../doc/models/create-cash-payment-request.md) | Optional | Settings for cash payment |
| `PrivateLabel` | [`Models.CreatePrivateLabelPaymentRequest`](../../doc/models/create-private-label-payment-request.md) | Required | Settings for private label payment |
| `Pix` | [`Models.CreatePixPaymentRequest`](../../doc/models/create-pix-payment-request.md) | Optional | Settings for pix payment |

## Example (as JSON)

```json
{
  "payment_method": "payment_method0",
  "credit_card": null,
  "debit_card": null,
  "boleto": null,
  "currency": null,
  "voucher": null,
  "split": null,
  "bank_transfer": null,
  "gateway_affiliation_id": null,
  "amount": null,
  "checkout": null,
  "customer_id": null,
  "customer": null,
  "metadata": null,
  "cash": null,
  "private_label": {
    "installments": null,
    "statement_descriptor": null,
    "card": null,
    "card_id": null,
    "card_token": null,
    "recurrence": null,
    "capture": null,
    "extended_limit_enabled": null,
    "extended_limit_code": null,
    "recurrency_cycle": null
  },
  "pix": null
}
```

