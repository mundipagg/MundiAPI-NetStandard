
# Get Transaction Response

Generic response object for getting a transaction.

## Structure

`GetTransactionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GatewayId` | `string` | Required | Gateway transaction id |
| `Amount` | `int` | Required | Amount in cents |
| `Status` | `string` | Required | Transaction status |
| `Success` | `bool` | Required | Indicates if the transaction ocurred successfuly |
| `CreatedAt` | `DateTime` | Required | Creation date |
| `UpdatedAt` | `DateTime` | Required | Last update date |
| `AttemptCount` | `int` | Required | Number of attempts tried |
| `MaxAttempts` | `int` | Required | Max attempts |
| `Splits` | [`List<Models.GetSplitResponse>`](../../doc/models/get-split-response.md) | Required | Splits |
| `NextAttempt` | `DateTime?` | Optional | Date and time of the next attempt |
| `TransactionType` | `string` | Optional | - |
| `Id` | `string` | Required | Código da transação |
| `GatewayResponse` | [`Models.GetGatewayResponseResponse`](../../doc/models/get-gateway-response-response.md) | Required | The Gateway Response |
| `AntifraudResponse` | [`Models.GetAntifraudResponse`](../../doc/models/get-antifraud-response.md) | Required | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Split` | [`List<Models.GetSplitResponse>`](../../doc/models/get-split-response.md) | Required | - |
| `Interest` | [`Models.GetInterestResponse`](../../doc/models/get-interest-response.md) | Optional | - |
| `Fine` | [`Models.GetFineResponse`](../../doc/models/get-fine-response.md) | Optional | - |
| `MaxDaysToPayPastDue` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "gateway_id": "gateway_id0",
  "amount": 46,
  "status": "status8",
  "success": false,
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "attempt_count": 70,
  "max_attempts": 174,
  "splits": [
    {
      "type": "type4",
      "amount": 62,
      "recipient": null,
      "gateway_id": "gateway_id4",
      "options": null,
      "id": "id6"
    },
    {
      "type": "type3",
      "amount": 63,
      "recipient": null,
      "gateway_id": "gateway_id3",
      "options": null,
      "id": "id7"
    }
  ],
  "next_attempt": null,
  "transaction_type": "transaction",
  "id": "id0",
  "gateway_response": {
    "code": "code6",
    "errors": [
      {
        "message": "message3"
      },
      {
        "message": "message4"
      },
      {
        "message": "message5"
      }
    ]
  },
  "antifraud_response": {
    "status": "status0",
    "return_code": "return_code8",
    "return_message": "return_message4",
    "provider_name": "provider_name4",
    "score": "score8"
  },
  "metadata": null,
  "split": [
    {
      "type": "type6",
      "amount": 28,
      "recipient": null,
      "gateway_id": "gateway_id6",
      "options": null,
      "id": "id4"
    },
    {
      "type": "type5",
      "amount": 27,
      "recipient": null,
      "gateway_id": "gateway_id5",
      "options": null,
      "id": "id5"
    },
    {
      "type": "type4",
      "amount": 26,
      "recipient": null,
      "gateway_id": "gateway_id4",
      "options": null,
      "id": "id6"
    }
  ],
  "interest": null,
  "fine": null,
  "max_days_to_pay_past_due": null
}
```

