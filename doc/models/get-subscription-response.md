
# Get Subscription Response

## Structure

`GetSubscriptionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Code` | `string` | Required | - |
| `StartAt` | `DateTime` | Required | - |
| `Interval` | `string` | Required | - |
| `IntervalCount` | `int` | Required | - |
| `BillingType` | `string` | Required | - |
| `CurrentCycle` | [`Models.GetPeriodResponse`](../../doc/models/get-period-response.md) | Optional | - |
| `PaymentMethod` | `string` | Required | - |
| `Currency` | `string` | Required | - |
| `Installments` | `int` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Card` | [`Models.GetCardResponse`](../../doc/models/get-card-response.md) | Required | - |
| `Items` | [`List<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md) | Required | - |
| `StatementDescriptor` | `string` | Required | - |
| `Metadata` | `Dictionary<string, string>` | Required | - |
| `Setup` | [`Models.GetSetupResponse`](../../doc/models/get-setup-response.md) | Required | - |
| `GatewayAffiliationId` | `string` | Required | Affiliation Code |
| `NextBillingAt` | `DateTime?` | Optional | - |
| `BillingDay` | `int?` | Optional | - |
| `MinimumPrice` | `int?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `Discounts` | [`List<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md) | Optional | Subscription discounts |
| `Increments` | [`List<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md) | Required | Subscription increments |
| `BoletoDueDays` | `int?` | Optional | Days until boleto expires |
| `Split` | [`Models.GetSubscriptionSplitResponse`](../../doc/models/get-subscription-split-response.md) | Required | Subscription's split response |

## Example (as JSON)

```json
{
  "id": "id0",
  "code": "code8",
  "start_at": "2016-03-13T12:52:32.123Z",
  "interval": "interval2",
  "interval_count": 82,
  "billing_type": "billing_type6",
  "current_cycle": null,
  "payment_method": "payment_method0",
  "currency": "currency0",
  "installments": 250,
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "customer": null,
  "card": {
    "id": "id6",
    "last_four_digits": "last_four_digits2",
    "brand": "brand0",
    "holder_name": "holder_name2",
    "exp_month": 228,
    "exp_year": 68,
    "status": "status2",
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
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
    "customer": null,
    "metadata": {
      "key0": "metadata7"
    },
    "type": "type4",
    "holder_document": "holder_document0",
    "deleted_at": null,
    "first_six_digits": "first_six_digits6",
    "label": "label6"
  },
  "items": [
    {
      "id": "id7",
      "description": "description7",
      "status": "status1",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
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
      "discounts": [
        {
          "id": "id8",
          "value": 236.1,
          "discount_type": "discount_type6",
          "status": "status0",
          "created_at": "2016-03-13T12:52:32.123Z",
          "cycles": null,
          "deleted_at": null,
          "description": null,
          "subscription": null,
          "subscription_item": null
        },
        {
          "id": "id9",
          "value": 236.11,
          "discount_type": "discount_type7",
          "status": "status1",
          "created_at": "2016-03-13T12:52:32.123Z",
          "cycles": null,
          "deleted_at": null,
          "description": null,
          "subscription": null,
          "subscription_item": null
        },
        {
          "id": "id0",
          "value": 236.12,
          "discount_type": "discount_type8",
          "status": "status2",
          "created_at": "2016-03-13T12:52:32.123Z",
          "cycles": null,
          "deleted_at": null,
          "description": null,
          "subscription": null,
          "subscription_item": null
        }
      ],
      "increments": [
        null
      ],
      "subscription": null,
      "name": "name7",
      "quantity": null,
      "cycles": null,
      "deleted_at": null
    },
    {
      "id": "id8",
      "description": "description8",
      "status": "status0",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
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
      "discounts": [
        {
          "id": "id9",
          "value": 236.11,
          "discount_type": "discount_type7",
          "status": "status1",
          "created_at": "2016-03-13T12:52:32.123Z",
          "cycles": null,
          "deleted_at": null,
          "description": null,
          "subscription": null,
          "subscription_item": null
        }
      ],
      "increments": [
        null,
        null,
        null
      ],
      "subscription": null,
      "name": "name8",
      "quantity": null,
      "cycles": null,
      "deleted_at": null
    }
  ],
  "statement_descriptor": "statement_descriptor0",
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "setup": {
    "id": "id6",
    "description": "description4",
    "amount": 110,
    "status": "status2"
  },
  "gateway_affiliation_id": "gateway_affiliation_id4",
  "next_billing_at": null,
  "billing_day": null,
  "minimum_price": null,
  "canceled_at": null,
  "discounts": null,
  "increments": [
    {
      "id": "id7",
      "value": 124.19,
      "increment_type": "increment_type9",
      "status": "status1",
      "created_at": "2016-03-13T12:52:32.123Z",
      "cycles": null,
      "deleted_at": null,
      "description": null,
      "subscription": null,
      "subscription_item": null
    }
  ],
  "boleto_due_days": null,
  "split": {
    "enabled": false,
    "rules": [
      {
        "type": "type4",
        "amount": 246,
        "recipient": null,
        "gateway_id": "gateway_id4",
        "options": null,
        "id": "id6"
      },
      {
        "type": "type3",
        "amount": 245,
        "recipient": null,
        "gateway_id": "gateway_id3",
        "options": null,
        "id": "id7"
      }
    ]
  }
}
```

