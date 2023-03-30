
# Create Apple Pay Request

The ApplePay Token Payment Request

## Structure

`CreateApplePayRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Required | The token version |
| `Data` | `string` | Required | The cryptography data |
| `Header` | [`Models.CreateApplePayHeaderRequest`](../../doc/models/create-apple-pay-header-request.md) | Required | The ApplePay header request |
| `Signature` | `string` | Required | Detached PKCS #7 signature, Base64 encoded as string |
| `MerchantIdentifier` | `string` | Required | ApplePay Merchant identifier |

## Example (as JSON)

```json
{
  "version": "version4",
  "data": "data0",
  "header": {
    "public_key_hash": null,
    "ephemeral_public_key": "ephemeral_public_key6",
    "transaction_id": null
  },
  "signature": "signature8",
  "merchant_identifier": "merchant_identifier4"
}
```

