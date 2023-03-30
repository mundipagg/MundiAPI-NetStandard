
# Get Increment Response

Response object for getting a increment

## Structure

`GetIncrementResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `MValue` | `double` | Required | - |
| `IncrementType` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `Cycles` | `int?` | Optional | - |
| `DeletedAt` | `DateTime?` | Optional | - |
| `Description` | `string` | Optional | - |
| `Subscription` | [`Models.GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Optional | - |
| `SubscriptionItem` | [`Models.GetSubscriptionItemResponse`](../../doc/models/get-subscription-item-response.md) | Optional | The Subscription Item |

## Example (as JSON)

```json
{
  "id": "id0",
  "value": 251.52,
  "increment_type": "increment_type8",
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "cycles": null,
  "deleted_at": null,
  "description": null,
  "subscription": null,
  "subscription_item": null
}
```

