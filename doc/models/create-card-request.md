
# Create Card Request

Card data

## Structure

`CreateCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Number` | `string` | Required | Credit card number |
| `HolderName` | `string` | Required | Holder name, as written on the card |
| `ExpMonth` | `int` | Required | The expiration month |
| `ExpYear` | `int` | Required | The expiration year, that can be informed with 2 or 4 digits |
| `Cvv` | `string` | Required | The card's security code |
| `BillingAddress` | [`Models.CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Card's billing address |
| `Brand` | `string` | Required | Card brand |
| `BillingAddressId` | `string` | Required | The address id for the billing address |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Type` | `string` | Required | Card type<br>**Default**: `"credit"` |
| `Options` | [`Models.CreateCardOptionsRequest`](../../doc/models/create-card-options-request.md) | Required | Options for creating the card |
| `HolderDocument` | `string` | Optional | Document number for the card's holder |
| `PrivateLabel` | `bool` | Required | Indicates whether it is a private label card |
| `Label` | `string` | Required | - |
| `Id` | `string` | Optional | Identifier |
| `Token` | `string` | Optional | token identifier |

## Example (as JSON)

```json
{
  "number": null,
  "holder_name": null,
  "exp_month": null,
  "exp_year": null,
  "cvv": null,
  "billing_address": null,
  "brand": null,
  "billing_address_id": null,
  "metadata": null,
  "type": "credit",
  "options": null,
  "private_label": null,
  "label": null
}
```

