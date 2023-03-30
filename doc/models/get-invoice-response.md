
# Get Invoice Response

Response object for getting an invoice

## Structure

`GetInvoiceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Code` | `string` | Required | - |
| `Url` | `string` | Required | - |
| `Amount` | `int` | Required | - |
| `Status` | `string` | Required | - |
| `PaymentMethod` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `Items` | [`List<Models.GetInvoiceItemResponse>`](../../doc/models/get-invoice-item-response.md) | Required | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Charge` | [`Models.GetChargeResponse`](../../doc/models/get-charge-response.md) | Required | - |
| `Installments` | `int` | Required | - |
| `BillingAddress` | [`Models.GetBillingAddressResponse`](../../doc/models/get-billing-address-response.md) | Required | - |
| `Subscription` | [`Models.GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Required | - |
| `Cycle` | [`Models.GetPeriodResponse`](../../doc/models/get-period-response.md) | Optional | - |
| `Shipping` | [`Models.GetShippingResponse`](../../doc/models/get-shipping-response.md) | Required | - |
| `Metadata` | `Dictionary<string, string>` | Required | - |
| `DueAt` | `DateTime?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `BillingAt` | `DateTime?` | Optional | - |
| `SeenAt` | `DateTime?` | Optional | - |
| `TotalDiscount` | `int?` | Optional | Total discounted value |
| `TotalIncrement` | `int?` | Optional | Total discounted value |
| `SubscriptionId` | `string` | Required | Subscription Id |

## Example (as JSON)

```json
{
  "id": "id0",
  "code": "code8",
  "url": "url4",
  "amount": 46,
  "status": "status8",
  "payment_method": "payment_method0",
  "created_at": "2016-03-13T12:52:32.123Z",
  "items": [
    {
      "amount": 13,
      "description": "description7",
      "pricing_scheme": {
        "price": 149,
        "scheme_type": "scheme_type1",
        "price_brackets": [
          {
            "start_quantity": 60,
            "price": 2,
            "end_quantity": null,
            "overage_price": null
          },
          {
            "start_quantity": 61,
            "price": 1,
            "end_quantity": null,
            "overage_price": null
          },
          {
            "start_quantity": 62,
            "price": 0,
            "end_quantity": null,
            "overage_price": null
          }
        ],
        "minimum_price": null,
        "percentage": null
      },
      "price_bracket": {
        "start_quantity": 243,
        "price": 75,
        "end_quantity": null,
        "overage_price": null
      },
      "quantity": null,
      "name": null,
      "subscription_item_id": "subscription_item_id1"
    },
    {
      "amount": 14,
      "description": "description8",
      "pricing_scheme": {
        "price": 150,
        "scheme_type": "scheme_type0",
        "price_brackets": [
          {
            "start_quantity": 59,
            "price": 3,
            "end_quantity": null,
            "overage_price": null
          },
          {
            "start_quantity": 60,
            "price": 2,
            "end_quantity": null,
            "overage_price": null
          }
        ],
        "minimum_price": null,
        "percentage": null
      },
      "price_bracket": {
        "start_quantity": 244,
        "price": 74,
        "end_quantity": null,
        "overage_price": null
      },
      "quantity": null,
      "name": null,
      "subscription_item_id": "subscription_item_id2"
    }
  ],
  "customer": null,
  "charge": {
    "id": "id8",
    "code": "code6",
    "gateway_id": "gateway_id2",
    "amount": 80,
    "status": "status0",
    "currency": "currency8",
    "payment_method": "payment_method8",
    "due_at": "2016-03-13T12:52:32.123Z",
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
    "last_transaction": null,
    "invoice": null,
    "order": null,
    "customer": null,
    "metadata": {
      "key0": "metadata5",
      "key1": "metadata4"
    },
    "paid_at": null,
    "canceled_at": null,
    "canceled_amount": 190,
    "paid_amount": 172,
    "recurrency_cycle": null,
    "interest_and_fine_paid": null
  },
  "installments": 250,
  "billing_address": {
    "street": "street8",
    "number": "number4",
    "zip_code": "zip_code2",
    "neighborhood": "neighborhood4",
    "city": "city2",
    "state": "state6",
    "country": "country2",
    "complement": "complement6",
    "line_1": "line_18",
    "line_2": "line_26"
  },
  "subscription": {
    "id": "id4",
    "code": "code2",
    "start_at": "2016-03-13T12:52:32.123Z",
    "interval": "interval2",
    "interval_count": 234,
    "billing_type": "billing_type8",
    "current_cycle": null,
    "payment_method": "payment_method4",
    "currency": "currency4",
    "installments": 146,
    "status": "status6",
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
    "customer": null,
    "card": {
      "id": "id8",
      "last_four_digits": "last_four_digits4",
      "brand": "brand2",
      "holder_name": "holder_name4",
      "exp_month": 216,
      "exp_year": 80,
      "status": "status0",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
      "billing_address": {
        "street": "street0",
        "number": "number2",
        "zip_code": "zip_code4",
        "neighborhood": "neighborhood6",
        "city": "city0",
        "state": "state4",
        "country": "country4",
        "complement": "complement4",
        "line_1": "line_16",
        "line_2": "line_28"
      },
      "customer": null,
      "metadata": {
        "key0": "metadata5",
        "key1": "metadata4"
      },
      "type": "type2",
      "holder_document": "holder_document2",
      "deleted_at": null,
      "first_six_digits": "first_six_digits8",
      "label": "label8"
    },
    "items": [
      null,
      null
    ],
    "statement_descriptor": "statement_descriptor4",
    "metadata": {
      "key0": "metadata1",
      "key1": "metadata0",
      "key2": "metadata9"
    },
    "setup": {
      "id": "id8",
      "description": "description8",
      "amount": 170,
      "status": "status0"
    },
    "gateway_affiliation_id": "gateway_affiliation_id0",
    "next_billing_at": null,
    "billing_day": null,
    "minimum_price": null,
    "canceled_at": null,
    "discounts": null,
    "increments": [
      null
    ],
    "boleto_due_days": null,
    "split": {
      "enabled": false,
      "rules": [
        null,
        null
      ]
    }
  },
  "cycle": null,
  "shipping": {
    "amount": 52,
    "description": "description6",
    "recipient_name": "recipient_name2",
    "recipient_phone": "recipient_phone6",
    "address": {
      "id": "id0",
      "street": "street0",
      "number": "number8",
      "complement": "complement6",
      "zip_code": "zip_code4",
      "neighborhood": "neighborhood6",
      "city": "city0",
      "state": "state6",
      "country": "country4",
      "status": "status2",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
      "customer": null,
      "metadata": {
        "key0": "metadata7"
      },
      "line_1": "line_14",
      "line_2": "line_28",
      "deleted_at": null
    },
    "max_delivery_date": null,
    "estimated_delivery_date": null,
    "type": "type6"
  },
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "due_at": null,
  "canceled_at": null,
  "billing_at": null,
  "seen_at": null,
  "total_discount": null,
  "total_increment": null,
  "subscription_id": "subscription_id0"
}
```

