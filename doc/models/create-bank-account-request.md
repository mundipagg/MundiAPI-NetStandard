
# Create Bank Account Request

Request for creating a bank account

## Structure

`CreateBankAccountRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HolderName` | `string` | Required | Bank account holder name |
| `HolderType` | `string` | Required | Bank account holder type |
| `HolderDocument` | `string` | Required | Bank account holder document |
| `Bank` | `string` | Required | Bank |
| `BranchNumber` | `string` | Required | Branch number |
| `BranchCheckDigit` | `string` | Required | Branch check digit |
| `AccountNumber` | `string` | Required | Account number |
| `AccountCheckDigit` | `string` | Required | Account check digit |
| `Type` | `string` | Required | Bank account type |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `PixKey` | `string` | Required | Pix key |

## Example (as JSON)

```json
{
  "holder_name": "holder_name4",
  "holder_type": "holder_type2",
  "holder_document": "holder_document6",
  "bank": "bank8",
  "branch_number": "branch_number6",
  "branch_check_digit": "branch_check_digit4",
  "account_number": "account_number0",
  "account_check_digit": "account_check_digit6",
  "type": "type0",
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "pix_key": "pix_key6"
}
```

