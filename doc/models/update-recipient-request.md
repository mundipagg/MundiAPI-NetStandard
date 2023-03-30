
# Update Recipient Request

Request for updating a Recipient

## Structure

`UpdateRecipientRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name |
| `Email` | `string` | Required | Email |
| `Description` | `string` | Required | Description |
| `Type` | `string` | Required | Type |
| `Status` | `string` | Required | Status |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |

## Example (as JSON)

```json
{
  "name": "name0",
  "email": "email6",
  "description": "description0",
  "type": "type0",
  "status": "status8",
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  }
}
```

