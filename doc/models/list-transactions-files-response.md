
# List Transactions Files Response

Response object for listing of transactions files

## Structure

`ListTransactionsFilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.GetTransactionReportFileResponse>`](../../doc/models/get-transaction-report-file-response.md) | Required | - |
| `Paging` | [`Models.PagingResponse`](../../doc/models/paging-response.md) | Required | Paging object |

## Example (as JSON)

```json
{
  "data": [
    {
      "name": "name5",
      "date": "2016-03-13T12:52:32.123Z"
    },
    {
      "name": "name6",
      "date": "2016-03-13T12:52:32.123Z"
    }
  ],
  "paging": {
    "total": 6,
    "previous": "previous2",
    "next": "next8"
  }
}
```

