
# Create Cancel Charge Split Rules Request

Creates a refund with split rules

## Structure

`CreateCancelChargeSplitRulesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The split rule gateway id |
| `Amount` | `int` | Required | The split rule amount |
| `Type` | `string` | Required | The amount type (flat ou percentage) |

## Example (as JSON)

```json
{
  "id": "id0",
  "Amount": 156,
  "type": "type0"
}
```

