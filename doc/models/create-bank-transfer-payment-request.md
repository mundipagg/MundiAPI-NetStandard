
# Create Bank Transfer Payment Request

Request for creating a bank transfer payment

## Structure

`CreateBankTransferPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `string` | Required | Bank |
| `Retries` | `int` | Required | Number of retries |

## Example (as JSON)

```json
{
  "bank": "bank8",
  "retries": 230
}
```

