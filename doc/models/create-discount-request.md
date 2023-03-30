
# Create Discount Request

Request for creating a new discount

## Structure

`CreateDiscountRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `double` | Required | The discount value |
| `DiscountType` | `string` | Required | Discount type. Can be either flat or percentage. |
| `ItemId` | `string` | Required | The item where the discount will be applied |
| `Cycles` | `int?` | Optional | Number of cycles that the discount will be applied |
| `Description` | `string` | Optional | Description |

## Example (as JSON)

```json
{
  "value": 251.52,
  "discount_type": "discount_type8",
  "item_id": "item_id0",
  "cycles": null,
  "description": null
}
```

