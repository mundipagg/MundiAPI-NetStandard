# Transactions

```csharp
ITransactionsController transactionsController = client.TransactionsController;
```

## Class Name

`TransactionsController`


# Get Transaction

```csharp
GetTransactionAsync(
    string transactionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.GetTransactionResponse>`](../../doc/models/get-transaction-response.md)

## Example Usage

```csharp
string transactionId = "transaction_id8";

try
{
    GetTransactionResponse result = await transactionsController.GetTransactionAsync(transactionId);
}
catch (ApiException e){};
```

