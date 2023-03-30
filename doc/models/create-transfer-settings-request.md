
# Create Transfer Settings Request

Informações de transferência do recebedor

## Structure

`CreateTransferSettingsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransferEnabled` | `bool` | Required | - |
| `TransferInterval` | `string` | Required | - |
| `TransferDay` | `int` | Required | - |

## Example (as JSON)

```json
{
  "transfer_enabled": false,
  "transfer_interval": "transfer_interval0",
  "transfer_day": 18
}
```

