
# Get Charge Response

Response object for getting a charge

## Structure

`GetChargeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Code` | `string` | Required | - |
| `GatewayId` | `string` | Required | - |
| `Amount` | `int` | Required | - |
| `Status` | `string` | Required | - |
| `Currency` | `string` | Required | - |
| `PaymentMethod` | `string` | Required | - |
| `DueAt` | `DateTime` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `LastTransaction` | [`Models.GetTransactionResponse`](../../doc/models/get-transaction-response.md) | Optional | - |
| `Invoice` | [`Models.GetInvoiceResponse`](../../doc/models/get-invoice-response.md) | Optional | - |
| `Order` | [`Models.GetOrderResponse`](../../doc/models/get-order-response.md) | Optional | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Required | - |
| `PaidAt` | `DateTime?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `CanceledAmount` | `int` | Required | Canceled Amount |
| `PaidAmount` | `int` | Required | Paid amount |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |
| `InterestAndFinePaid` | `int?` | Optional | interest and fine paid |

## Example (as JSON)

```json
{
  "id": "id0",
  "code": "code8",
  "gateway_id": "gateway_id0",
  "amount": 46,
  "status": "status8",
  "currency": "currency0",
  "payment_method": "payment_method0",
  "due_at": "2016-03-13T12:52:32.123Z",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "last_transaction": null,
  "invoice": null,
  "order": null,
  "customer": null,
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "paid_at": null,
  "canceled_at": null,
  "canceled_amount": 64,
  "paid_amount": 210,
  "recurrency_cycle": null,
  "interest_and_fine_paid": null
}
```

