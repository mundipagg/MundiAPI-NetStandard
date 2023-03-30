
# Get Billing Address Response

Response object for getting a billing address

## Structure

`GetBillingAddressResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Required | - |
| `Number` | `string` | Required | - |
| `ZipCode` | `string` | Required | - |
| `Neighborhood` | `string` | Required | - |
| `City` | `string` | Required | - |
| `State` | `string` | Required | - |
| `Country` | `string` | Required | - |
| `Complement` | `string` | Required | - |
| `Line1` | `string` | Required | Line 1 for address |
| `Line2` | `string` | Required | Line 2 for address |

## Example (as JSON)

```json
{
  "street": "street0",
  "number": "number2",
  "zip_code": "zip_code4",
  "neighborhood": "neighborhood6",
  "city": "city0",
  "state": "state4",
  "country": "country4",
  "complement": "complement4",
  "line_1": "line_16",
  "line_2": "line_28"
}
```

