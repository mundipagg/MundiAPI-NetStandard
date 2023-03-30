
# Create Order Request

Request for creating an order

## Structure

`CreateOrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<Models.CreateOrderItemRequest>`](../../doc/models/create-order-item-request.md) | Required | Items |
| `Customer` | [`Models.CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Required | Customer |
| `Payments` | [`List<Models.CreatePaymentRequest>`](../../doc/models/create-payment-request.md) | Required | Payment data |
| `Code` | `string` | Required | The order code |
| `CustomerId` | `string` | Required | The customer id |
| `Shipping` | [`Models.CreateShippingRequest`](../../doc/models/create-shipping-request.md) | Optional | Shipping data |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `AntifraudEnabled` | `bool?` | Optional | Defines whether the order will go through anti-fraud |
| `Ip` | `string` | Optional | Ip address |
| `SessionId` | `string` | Optional | Session id |
| `Location` | [`Models.CreateLocationRequest`](../../doc/models/create-location-request.md) | Optional | Request's location |
| `Device` | [`Models.CreateDeviceRequest`](../../doc/models/create-device-request.md) | Optional | Device's informations |
| `Closed` | `bool` | Required | **Default**: `true` |
| `Currency` | `string` | Optional | Currency |
| `Antifraud` | [`Models.CreateAntifraudRequest`](../../doc/models/create-antifraud-request.md) | Optional | - |
| `Submerchant` | [`Models.CreateSubMerchantRequest`](../../doc/models/create-sub-merchant-request.md) | Optional | SubMerchant |

## Example (as JSON)

```json
{
  "items": null,
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
  "payments": null,
  "code": null,
  "customer_id": null,
  "metadata": null,
  "closed": true
}
```

