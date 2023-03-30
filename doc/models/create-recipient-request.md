
# Create Recipient Request

Request for creating a recipient

## Structure

`CreateRecipientRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Recipient name |
| `Email` | `string` | Required | Recipient email |
| `Description` | `string` | Required | Recipient description |
| `Document` | `string` | Required | Recipient document number |
| `Type` | `string` | Required | Recipient type |
| `DefaultBankAccount` | [`Models.CreateBankAccountRequest`](../../doc/models/create-bank-account-request.md) | Required | Bank account |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `TransferSettings` | [`Models.CreateTransferSettingsRequest`](../../doc/models/create-transfer-settings-request.md) | Optional | Receiver Transfer Information |
| `Code` | `string` | Required | Recipient code |
| `PaymentMode` | `string` | Required | Payment mode<br>**Default**: `"bank_transfer"` |

## Example (as JSON)

```json
{
  "name": null,
  "email": null,
  "description": null,
  "document": null,
  "type": null,
  "default_bank_account": null,
  "metadata": null,
  "code": null,
  "payment_mode": "bank_transfer"
}
```

