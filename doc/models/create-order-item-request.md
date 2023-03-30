
# Create Order Item Request

Request for creating an order item

## Structure

`CreateOrderItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Amount |
| `Description` | `string` | Required | Description |
| `Quantity` | `int` | Required | Quantity |
| `Category` | `string` | Required | Category |
| `Code` | `string` | Optional | The item code passed by the client |

## Example (as JSON)

```json
{
  "amount": 46,
  "description": "description0",
  "quantity": 68,
  "category": "category2",
  "code": null
}
```

