
# Get Address Response

Response object for getting an Address

## Structure

`GetAddressResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Street` | `string` | Required | - |
| `Number` | `string` | Required | - |
| `Complement` | `string` | Required | - |
| `ZipCode` | `string` | Required | - |
| `Neighborhood` | `string` | Required | - |
| `City` | `string` | Required | - |
| `State` | `string` | Required | - |
| `Country` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Required | - |
| `Line1` | `string` | Required | Line 1 for address |
| `Line2` | `string` | Required | Line 2 for address |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "street": "street0",
  "number": "number2",
  "complement": "complement4",
  "zip_code": "zip_code4",
  "neighborhood": "neighborhood6",
  "city": "city0",
  "state": "state4",
  "country": "country4",
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "customer": null,
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "line_1": "line_16",
  "line_2": "line_28",
  "deleted_at": null
}
```

