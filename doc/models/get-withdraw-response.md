
# Get Withdraw Response

## Structure

`GetWithdrawResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `GatewayId` | `string` | Required | - |
| `Amount` | `int` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `Metadata` | `List<string>` | Optional | - |
| `Fee` | `int?` | Optional | - |
| `FundingDate` | `DateTime?` | Optional | - |
| `FundingEstimatedDate` | `DateTime?` | Optional | - |
| `Type` | `string` | Required | - |
| `Source` | [`Models.GetWithdrawSourceResponse`](../../doc/models/get-withdraw-source-response.md) | Required | - |
| `Target` | [`Models.GetWithdrawTargetResponse`](../../doc/models/get-withdraw-target-response.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "gateway_id": "gateway_id0",
  "amount": 46,
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "metadata": null,
  "fee": null,
  "funding_date": null,
  "funding_estimated_date": null,
  "type": "type0",
  "source": {
    "source_id": "source_id8",
    "type": "type6"
  },
  "target": {
    "target_id": "target_id2",
    "type": "type8"
  }
}
```

