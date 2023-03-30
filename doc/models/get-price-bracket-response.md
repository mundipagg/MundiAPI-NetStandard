
# Get Price Bracket Response

Response object for getting a price bracket

## Structure

`GetPriceBracketResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartQuantity` | `int` | Required | - |
| `Price` | `int` | Required | - |
| `EndQuantity` | `int?` | Optional | - |
| `OveragePrice` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "start_quantity": 46,
  "price": 16,
  "end_quantity": null,
  "overage_price": null
}
```

