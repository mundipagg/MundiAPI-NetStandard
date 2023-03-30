
# Create Charge Request

Request for creating a new charge

## Structure

`CreateChargeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Required | Code |
| `Amount` | `int` | Required | The amount of the charge, in cents |
| `CustomerId` | `string` | Required | The customer's id |
| `Customer` | [`Models.CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Required | Customer data |
| `Payment` | [`Models.CreatePaymentRequest`](../../doc/models/create-payment-request.md) | Required | Payment data |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `DueAt` | `DateTime?` | Optional | The charge due date |
| `Antifraud` | [`Models.CreateAntifraudRequest`](../../doc/models/create-antifraud-request.md) | Required | - |
| `OrderId` | `string` | Required | Order Id |

## Example (as JSON)

```json
{
  "code": null,
  "amount": null,
  "customer_id": null,
  "customer": {
    "name": "{\n    \"name\": \"Tony Stark\"\n}",
    "email": null,
    "document": null,
    "type": null,
    "address": null,
    "metadata": null,
    "phones": null,
    "code": null
  },
  "payment": null,
  "metadata": null,
  "antifraud": null,
  "order_id": null
}
```

