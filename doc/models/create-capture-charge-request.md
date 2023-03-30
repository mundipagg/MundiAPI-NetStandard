
# Create Capture Charge Request

Request for capturing a charge

## Structure

`CreateCaptureChargeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Required | Code for the charge. Sending this field will update the code send on the charge and order creation. |
| `Amount` | `int?` | Optional | The amount that will be captured |
| `Split` | [`List<Models.CreateSplitRequest>`](../../doc/models/create-split-request.md) | Optional | Splits |
| `OperationReference` | `string` | Required | - |

## Example (as JSON)

```json
{
  "code": "code8",
  "amount": null,
  "split": null,
  "operation_reference": "operation_reference0"
}
```

