
# Get Gateway Recipient Response

Information about the recipient on the gateway

## Structure

`GetGatewayRecipientResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Gateway` | `string` | Required | Gateway name |
| `Status` | `string` | Required | Status of the recipient on the gateway |
| `Pgid` | `string` | Required | Recipient id on the gateway |
| `CreatedAt` | `string` | Required | Creation date |
| `UpdatedAt` | `string` | Required | Last update date |

## Example (as JSON)

```json
{
  "gateway": "gateway0",
  "status": "status8",
  "pgid": "pgid4",
  "created_at": "created_at2",
  "updated_at": "updated_at4"
}
```

