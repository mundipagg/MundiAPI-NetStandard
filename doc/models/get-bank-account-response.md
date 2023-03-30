
# Get Bank Account Response

Response object to bank account

## Structure

`GetBankAccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Id |
| `HolderName` | `string` | Required | Holder name |
| `HolderType` | `string` | Required | Holder type |
| `Bank` | `string` | Required | Bank |
| `BranchNumber` | `string` | Required | Branch number |
| `BranchCheckDigit` | `string` | Required | Branch check digit |
| `AccountNumber` | `string` | Required | Account number |
| `AccountCheckDigit` | `string` | Required | Account check digit |
| `Type` | `string` | Required | Bank account type |
| `Status` | `string` | Required | Bank account status |
| `CreatedAt` | `DateTime` | Required | Creation date |
| `UpdatedAt` | `DateTime` | Required | Last update date |
| `DeletedAt` | `DateTime` | Required | Deletion date |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `PixKey` | `string` | Required | Pix Key |

## Example (as JSON)

```json
{
  "id": "id0",
  "holder_name": "holder_name4",
  "holder_type": "holder_type2",
  "bank": "bank8",
  "branch_number": "branch_number6",
  "branch_check_digit": "branch_check_digit4",
  "account_number": "account_number0",
  "account_check_digit": "account_check_digit6",
  "type": "type0",
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "deleted_at": "2016-03-13T12:52:32.123Z",
  "recipient": null,
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "pix_key": "pix_key6"
}
```

