
# Create Checkout Credit Card Payment Request

Checkout card payment request

## Structure

`CreateCheckoutCreditCardPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Card invoice text descriptor |
| `Installments` | [`List<Models.CreateCheckoutCardInstallmentOptionRequest>`](../../doc/models/create-checkout-card-installment-option-request.md) | Optional | Payment installment options |
| `Authentication` | [`Models.CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Optional | Creates payment authentication |
| `Capture` | `bool?` | Optional | Authorize and capture? |

## Example (as JSON)

```json
{
  "statement_descriptor": null,
  "installments": null,
  "authentication": null,
  "capture": null
}
```

