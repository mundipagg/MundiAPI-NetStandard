
# Get Split Response

Split response

## Structure

`GetSplitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | Type |
| `Amount` | `int` | Required | Amount |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `GatewayId` | `string` | Required | The split rule gateway id |
| `Options` | [`Models.GetSplitOptionsResponse`](../../doc/models/get-split-options-response.md) | Optional | - |
| `Id` | `string` | Required | - |

## Example (as JSON)

```json
{
  "type": "type0",
  "amount": 46,
  "recipient": null,
  "gateway_id": "gateway_id0",
  "options": null,
  "id": "id0"
}
```

