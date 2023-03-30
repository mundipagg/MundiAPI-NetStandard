
# Get Transfer Response

Transfer response

## Structure

`GetTransferResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Id |
| `Amount` | `int` | Required | Transfer amount |
| `Status` | `string` | Required | Transfer status |
| `CreatedAt` | `DateTime` | Required | Transfer creation date |
| `UpdatedAt` | `DateTime` | Required | Transfer last update date |
| `BankAccount` | [`Models.GetBankAccountResponse`](../../doc/models/get-bank-account-response.md) | Required | Bank account |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |

## Example (as JSON)

```json
{
  "id": "id0",
  "amount": 46,
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "bank_account": {
    "id": "id4",
    "holder_name": "holder_name0",
    "holder_type": "holder_type6",
    "bank": "bank2",
    "branch_number": "branch_number0",
    "branch_check_digit": "branch_check_digit0",
    "account_number": "account_number4",
    "account_check_digit": "account_check_digit0",
    "type": "type6",
    "status": "status6",
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
    "deleted_at": "2016-03-13T12:52:32.123Z",
    "recipient": null,
    "metadata": {
      "key0": "metadata1",
      "key1": "metadata0"
    },
    "pix_key": "pix_key2"
  },
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  }
}
```

