
# Get Discount Response

Response object for getting a discount

## Structure

`GetDiscountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `MValue` | `double` | Required | - |
| `DiscountType` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `Cycles` | `int?` | Optional | - |
| `DeletedAt` | `DateTime?` | Optional | - |
| `Description` | `string` | Optional | - |
| `Subscription` | [`Models.GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Optional | - |
| `SubscriptionItem` | [`Models.GetSubscriptionItemResponse`](../../doc/models/get-subscription-item-response.md) | Optional | The subscription item |

## Example (as JSON)

```json
{
  "id": "id0",
  "value": 251.52,
  "discount_type": "discount_type8",
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "cycles": null,
  "deleted_at": null,
  "description": null,
  "subscription": null,
  "subscription_item": null
}
```

