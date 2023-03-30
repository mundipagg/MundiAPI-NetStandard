
# Update Plan Request

Request for updating a plan

## Structure

`UpdatePlanRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Plan's name |
| `Description` | `string` | Required | Description |
| `Installments` | `List<int>` | Required | Number os installments |
| `StatementDescriptor` | `string` | Required | Text that will be shown on the credit card's statement |
| `Currency` | `string` | Required | Currency |
| `Interval` | `string` | Required | Interval |
| `IntervalCount` | `int` | Required | Interval count |
| `PaymentMethods` | `List<string>` | Required | Payment methods accepted by the plan |
| `BillingType` | `string` | Required | Billing type |
| `Status` | `string` | Required | Plan status |
| `Shippable` | `bool` | Required | Indicates if the plan is shippable |
| `BillingDays` | `List<int>` | Required | Billing days accepted by the plan |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `MinimumPrice` | `int?` | Optional | Minimum price |
| `TrialPeriodDays` | `int?` | Optional | Number of trial period in days, where the customer will not be charged |

## Example (as JSON)

```json
{
  "name": "name0",
  "description": "description0",
  "installments": [
    119,
    120,
    121
  ],
  "statement_descriptor": "statement_descriptor0",
  "currency": "currency0",
  "interval": "interval2",
  "interval_count": 82,
  "payment_methods": [
    "payment_methods5",
    "payment_methods6"
  ],
  "billing_type": "billing_type6",
  "status": "status8",
  "shippable": false,
  "billing_days": [
    143,
    144,
    145
  ],
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "minimum_price": null,
  "trial_period_days": null
}
```

