
# Create Checkout Boleto Payment Request

## Structure

`CreateCheckoutBoletoPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `string` | Required | Bank identifier |
| `Instructions` | `string` | Required | Instructions |
| `DueAt` | `DateTime` | Required | Due date |

## Example (as JSON)

```json
{
  "bank": "bank8",
  "instructions": "instructions2",
  "due_at": "2016-03-13T12:52:32.123Z"
}
```

