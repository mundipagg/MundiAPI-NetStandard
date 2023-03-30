
# Create Plan Item Request

Request for creating a plan item

## Structure

`CreatePlanItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Item name |
| `PricingScheme` | [`Models.CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Item's pricing scheme |
| `Id` | `string` | Required | Item's id |
| `Description` | `string` | Required | Item's description |
| `Cycles` | `int?` | Optional | Number of cycles where the item will be charged |
| `Quantity` | `int?` | Optional | Quantity |

## Example (as JSON)

```json
{
  "name": "name0",
  "pricing_scheme": {
    "scheme_type": "scheme_type8",
    "price_brackets": [
      {
        "start_quantity": 119,
        "price": 57,
        "end_quantity": null,
        "overage_price": null
      },
      {
        "start_quantity": 120,
        "price": 58,
        "end_quantity": null,
        "overage_price": null
      },
      {
        "start_quantity": 121,
        "price": 59,
        "end_quantity": null,
        "overage_price": null
      }
    ],
    "price": null,
    "minimum_price": null,
    "percentage": null
  },
  "id": "id0",
  "description": "description0",
  "cycles": null,
  "quantity": null
}
```

