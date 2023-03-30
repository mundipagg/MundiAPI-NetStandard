
# Create Anticipation Request

Request for creating an anticipation

## Structure

`CreateAnticipationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Amount requested for the anticipation |
| `Timeframe` | `string` | Required | Timeframe |
| `PaymentDate` | `DateTime` | Required | Payment date |

## Example (as JSON)

```json
{
  "amount": 46,
  "timeframe": "timeframe2",
  "payment_date": "2016-03-13T12:52:32.123Z"
}
```

