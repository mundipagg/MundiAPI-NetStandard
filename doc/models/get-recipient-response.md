
# Get Recipient Response

Recipient response

## Structure

`GetRecipientResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Id |
| `Name` | `string` | Required | Name |
| `Email` | `string` | Required | Email |
| `Document` | `string` | Required | Document |
| `Description` | `string` | Required | Description |
| `Type` | `string` | Required | Type |
| `Status` | `string` | Required | Status |
| `CreatedAt` | `DateTime` | Required | Creation date |
| `UpdatedAt` | `DateTime` | Required | Last update date |
| `DeletedAt` | `DateTime` | Required | Deletion date |
| `DefaultBankAccount` | [`Models.GetBankAccountResponse`](../../doc/models/get-bank-account-response.md) | Required | Default bank account |
| `GatewayRecipients` | [`List<Models.GetGatewayRecipientResponse>`](../../doc/models/get-gateway-recipient-response.md) | Required | Info about the recipient on the gateway |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `AutomaticAnticipationSettings` | [`Models.GetAutomaticAnticipationResponse`](../../doc/models/get-automatic-anticipation-response.md) | Optional | - |
| `TransferSettings` | [`Models.GetTransferSettingsResponse`](../../doc/models/get-transfer-settings-response.md) | Optional | - |
| `Code` | `string` | Required | Recipient code |
| `PaymentMode` | `string` | Required | Payment mode<br>**Default**: `"bank_transfer"` |

## Example (as JSON)

```json
{
  "id": null,
  "name": null,
  "email": null,
  "document": null,
  "description": null,
  "type": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "deleted_at": null,
  "default_bank_account": null,
  "gateway_recipients": null,
  "metadata": null,
  "code": null,
  "payment_mode": "bank_transfer"
}
```

