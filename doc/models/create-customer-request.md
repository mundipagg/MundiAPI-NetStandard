
# Create Customer Request

Request for creating a new customer

## Structure

`CreateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name |
| `Email` | `string` | Required | Email |
| `Document` | `string` | Required | Document number. Only numbers, no special characters. |
| `Type` | `string` | Required | Person type. Can be either 'individual' or 'company' |
| `Address` | [`Models.CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | The customer's address |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Phones` | [`Models.CreatePhonesRequest`](../../doc/models/create-phones-request.md) | Required | - |
| `Code` | `string` | Required | Customer code |
| `Gender` | `string` | Optional | Customer Gender |
| `DocumentType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "name": "{\n    \"name\": \"Tony Stark\"\n}",
  "email": null,
  "document": null,
  "type": null,
  "address": null,
  "metadata": null,
  "phones": null,
  "code": null
}
```

