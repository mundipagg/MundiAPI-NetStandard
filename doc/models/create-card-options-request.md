
# Create Card Options Request

Options for creating the card

## Structure

`CreateCardOptionsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VerifyCard` | `bool` | Required | Indicates if the card should be verified before creation. If true, executes an authorization before saving the card. |

## Example (as JSON)

```json
{
  "verify_card": false
}
```

