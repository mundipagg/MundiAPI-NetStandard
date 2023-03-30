
# Get Access Token Response

Response object for getting a access token

## Structure

`GetAccessTokenResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Code` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "code": "code8",
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "customer": null
}
```

