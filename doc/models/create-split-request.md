
# Create Split Request

Split

## Structure

`CreateSplitRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | Split type |
| `Amount` | `int` | Required | Amount |
| `RecipientId` | `string` | Required | Recipient id |
| `Options` | [`Models.CreateSplitOptionsRequest`](../../doc/models/create-split-options-request.md) | Optional | The split options request |

## Example (as JSON)

```json
{
  "type": "type0",
  "amount": 46,
  "recipient_id": "recipient_id0",
  "options": null
}
```

