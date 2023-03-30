
# Get Anticipation Limits Response

Anticipation limits

## Structure

`GetAnticipationLimitsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Max` | [`Models.GetAnticipationLimitResponse`](../../doc/models/get-anticipation-limit-response.md) | Required | Max limit |
| `Min` | [`Models.GetAnticipationLimitResponse`](../../doc/models/get-anticipation-limit-response.md) | Required | Min limit |

## Example (as JSON)

```json
{
  "max": {
    "amount": 140,
    "anticipation_fee": 234
  },
  "min": {
    "amount": 34,
    "anticipation_fee": 60
  }
}
```

