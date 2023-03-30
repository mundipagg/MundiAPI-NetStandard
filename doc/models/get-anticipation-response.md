
# Get Anticipation Response

Anticipation

## Structure

`GetAnticipationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Id |
| `RequestedAmount` | `int` | Required | Requested amount |
| `ApprovedAmount` | `int` | Required | Approved amount |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `Pgid` | `string` | Required | Anticipation id on the gateway |
| `CreatedAt` | `DateTime` | Required | Creation date |
| `UpdatedAt` | `DateTime` | Required | Last update date |
| `PaymentDate` | `DateTime` | Required | Payment date |
| `Status` | `string` | Required | Status |
| `Timeframe` | `string` | Required | Timeframe |

## Example (as JSON)

```json
{
  "id": "id0",
  "requested_amount": 246,
  "approved_amount": 212,
  "recipient": null,
  "pgid": "pgid4",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "payment_date": "2016-03-13T12:52:32.123Z",
  "status": "status8",
  "timeframe": "timeframe2"
}
```

