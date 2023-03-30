
# Update Subscription Billing Date Request

Request for updating the due date from a subscription

## Structure

`UpdateSubscriptionBillingDateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NextBillingAt` | `DateTime` | Required | The date when the next subscription billing must occur |

## Example (as JSON)

```json
{
  "next_billing_at": "2016-03-13T12:52:32.123Z"
}
```

