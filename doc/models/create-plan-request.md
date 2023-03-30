
# Create Plan Request

Request for creating a plan

## Structure

`CreatePlanRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Plan's name |
| `Description` | `string` | Required | Description |
| `StatementDescriptor` | `string` | Required | Text that will be printed on the credit card's statement |
| `Items` | [`List<Models.CreatePlanItemRequest>`](../../doc/models/create-plan-item-request.md) | Required | Plan items |
| `Shippable` | `bool` | Required | Indicates if the plan is shippable |
| `PaymentMethods` | `List<string>` | Required | Allowed payment methods for the plan |
| `Installments` | `List<int>` | Required | Number of installments |
| `Currency` | `string` | Required | Currency |
| `Interval` | `string` | Required | Interval |
| `IntervalCount` | `int` | Required | Interval counts between two charges. For instance, if the interval is 'month' and count is 2, the customer will be charged once every two months. |
| `BillingDays` | `List<int>` | Required | Allowed billings days for the subscription, in case the plan type is 'exact_day' |
| `BillingType` | `string` | Required | Billing type |
| `PricingScheme` | [`Models.CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Plan's pricing scheme |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `MinimumPrice` | `int?` | Optional | Minimum price that will be charged |
| `Cycles` | `int?` | Optional | Number of cycles |
| `Quantity` | `int?` | Optional | Quantity |
| `TrialPeriodDays` | `int?` | Optional | Trial period, where the customer will not be charged. |

## Example (as JSON)

```json
{
  "name": "name0",
  "description": "description0",
  "statement_descriptor": "statement_descriptor0",
  "items": [
    {
      "name": "name7",
      "pricing_scheme": {
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
        "price": null,
        "minimum_price": null,
        "percentage": null
      },
      "id": "id7",
      "description": "description7",
      "cycles": null,
      "quantity": null
    },
    {
      "name": "name8",
      "pricing_scheme": {
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
        "price": null,
        "minimum_price": null,
        "percentage": null
      },
      "id": "id8",
      "description": "description8",
      "cycles": null,
      "quantity": null
    }
  ],
  "shippable": false,
  "payment_methods": [
    "payment_methods5",
    "payment_methods6"
  ],
  "installments": [
    119,
    120,
    121
  ],
  "currency": "currency0",
  "interval": "interval2",
  "interval_count": 82,
  "billing_days": [
    143,
    144,
    145
  ],
  "billing_type": "billing_type6",
  "pricing_scheme": {
    "scheme_type": "scheme_type8",
    "price_brackets": [
      {
        "start_quantity": 119,
        "price": 57,
        "end_quantity": null,
        "overage_price": null
      },
      {
        "start_quantity": 120,
        "price": 58,
        "end_quantity": null,
        "overage_price": null
      },
      {
        "start_quantity": 121,
        "price": 59,
        "end_quantity": null,
        "overage_price": null
      }
    ],
    "price": null,
    "minimum_price": null,
    "percentage": null
  },
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "minimum_price": null,
  "cycles": null,
  "quantity": null,
  "trial_period_days": null
}
```

