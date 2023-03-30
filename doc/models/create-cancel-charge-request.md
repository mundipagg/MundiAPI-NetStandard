
# Create Cancel Charge Request

Request for canceling a charge.

## Structure

`CreateCancelChargeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | The amount that will be canceled. |
| `SplitRules` | [`List<Models.CreateCancelChargeSplitRulesRequest>`](../../doc/models/create-cancel-charge-split-rules-request.md) | Optional | The split rules request |
| `Split` | [`List<Models.CreateSplitRequest>`](../../doc/models/create-split-request.md) | Optional | Splits |
| `OperationReference` | `string` | Required | - |

## Example (as JSON)

```json
{
  "amount": null,
  "split_rules": null,
  "split": null,
  "operation_reference": "operation_reference0"
}
```

