
# Update Customer Request

Request for updating a customer

## Structure

`UpdateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name |
| `Email` | `string` | Optional | Email |
| `Document` | `string` | Optional | Document number |
| `Type` | `string` | Optional | Person type |
| `Address` | [`Models.CreateAddressRequest`](../../doc/models/create-address-request.md) | Optional | Address |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `Phones` | [`Models.CreatePhonesRequest`](../../doc/models/create-phones-request.md) | Optional | - |
| `Code` | `string` | Optional | Código de referência do cliente no sistema da loja. Max: 52 caracteres |
| `Gender` | `string` | Optional | Gênero do cliente |
| `DocumentType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "email": null,
  "document": null,
  "type": null,
  "address": null,
  "metadata": null,
  "phones": null,
  "code": null,
  "gender": null,
  "document_type": null
}
```

