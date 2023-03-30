
# Create Google Pay Request

The GooglePay Token Payment Request

## Structure

`CreateGooglePayRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Required | The token version |
| `Data` | `string` | Required | The cryptography data |
| `Header` | [`Models.CreateGooglePayHeaderRequest`](../../doc/models/create-google-pay-header-request.md) | Required | The GooglePay header request |
| `Signature` | `string` | Required | Detached PKCS #7 signature, Base64 encoded as string |
| `MerchantIdentifier` | `string` | Required | GooglePay Merchant identifier |

## Example (as JSON)

```json
{
  "version": "version4",
  "data": "data0",
  "header": {
    "ephemeral_public_key": "ephemeral_public_key6"
  },
  "signature": "signature8",
  "merchant_identifier": "merchant_identifier4"
}
```

