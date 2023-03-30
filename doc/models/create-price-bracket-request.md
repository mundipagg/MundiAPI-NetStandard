
# Create Price Bracket Request

Request for creating a price bracket

## Structure

`CreatePriceBracketRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartQuantity` | `int` | Required | Start quantity |
| `Price` | `int` | Required | Price |
| `EndQuantity` | `int?` | Optional | End quantity |
| `OveragePrice` | `int?` | Optional | Overage price |

## Example (as JSON)

```json
{
  "start_quantity": 46,
  "price": 16,
  "end_quantity": null,
  "overage_price": null
}
```

