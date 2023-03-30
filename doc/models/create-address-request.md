
# Create Address Request

Request for creating a new Address

## Structure

`CreateAddressRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Required | Street |
| `Number` | `string` | Required | Number |
| `ZipCode` | `string` | Required | The zip code containing only numbers. No special characters or spaces. |
| `Neighborhood` | `string` | Required | Neighborhood |
| `City` | `string` | Required | City |
| `State` | `string` | Required | State |
| `Country` | `string` | Required | Country. Must be entered using ISO 3166-1 alpha-2 format. See https://pt.wikipedia.org/wiki/ISO_3166-1_alfa-2 |
| `Complement` | `string` | Required | Complement |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
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
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "line_1": "line_16",
  "line_2": "line_28"
}
```

