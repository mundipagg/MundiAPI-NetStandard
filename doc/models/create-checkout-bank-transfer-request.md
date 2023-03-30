
# Create Checkout Bank Transfer Request

Checkout bank transfer payment request

## Structure

`CreateCheckoutBankTransferRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `List<string>` | Required | Bank |
| `Retries` | `int` | Required | Number of retries for processing |

## Example (as JSON)

```json
{
  "bank": [
    "bank7"
  ],
  "retries": 230
}
```

