
# Create Card Payment Contactless Request

The card payment contactless request

## Structure

`CreateCardPaymentContactlessRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The authentication type |
| `ApplePay` | [`Models.CreateApplePayRequest`](../../doc/models/create-apple-pay-request.md) | Optional | The ApplePay encrypted request |
| `GooglePay` | [`Models.CreateGooglePayRequest`](../../doc/models/create-google-pay-request.md) | Optional | The GooglePay encrypted request |
| `Emv` | [`Models.CreateEmvDecryptRequest`](../../doc/models/create-emv-decrypt-request.md) | Optional | The Emv encrypted request |

## Example (as JSON)

```json
{
  "type": "type0",
  "apple_pay": null,
  "google_pay": null,
  "emv": null
}
```

