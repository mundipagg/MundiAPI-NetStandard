
# Get Card Response

Response object for getting a credit card

## Structure

`GetCardResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `LastFourDigits` | `string` | Required | - |
| `Brand` | `string` | Required | - |
| `HolderName` | `string` | Required | - |
| `ExpMonth` | `int` | Required | - |
| `ExpYear` | `int` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `BillingAddress` | [`Models.GetBillingAddressResponse`](../../doc/models/get-billing-address-response.md) | Required | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Required | - |
| `Type` | `string` | Required | Card type |
| `HolderDocument` | `string` | Required | Document number for the card's holder |
| `DeletedAt` | `DateTime?` | Optional | - |
| `FirstSixDigits` | `string` | Required | First six digits |
| `Label` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "last_four_digits": "last_four_digits6",
  "brand": "brand4",
  "holder_name": "holder_name4",
  "exp_month": 42,
  "exp_year": 254,
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "billing_address": {
    "street": "street8",
    "number": "number4",
    "zip_code": "zip_code2",
    "neighborhood": "neighborhood4",
    "city": "city2",
    "state": "state6",
    "country": "country2",
    "complement": "complement6",
    "line_1": "line_18",
    "line_2": "line_26"
  },
  "customer": null,
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "type": "type0",
  "holder_document": "holder_document6",
  "deleted_at": null,
  "first_six_digits": "first_six_digits0",
  "label": "label0"
}
```

