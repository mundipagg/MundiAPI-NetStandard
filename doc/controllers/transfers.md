# Transfers

```csharp
ITransfersController transfersController = client.TransfersController;
```

## Class Name

`TransfersController`

## Methods

* [Create Transfer](../../doc/controllers/transfers.md#create-transfer)
* [Get Transfer by Id](../../doc/controllers/transfers.md#get-transfer-by-id)
* [Get Transfers](../../doc/controllers/transfers.md#get-transfers)


# Create Transfer

```csharp
CreateTransferAsync(
    Models.CreateTransfer request)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateTransfer`](../../doc/models/create-transfer.md) | Body, Required | - |

## Response Type

[`Task<Models.GetTransfer>`](../../doc/models/get-transfer.md)

## Example Usage

```csharp
var request = new CreateTransfer();
request.Amount = 242;
request.SourceId = "source_id0";
request.TargetId = "target_id6";

try
{
    GetTransfer result = await transfersController.CreateTransferAsync(request);
}
catch (ApiException e){};
```


# Get Transfer by Id

```csharp
GetTransferByIdAsync(
    string transferId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transferId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.GetTransfer>`](../../doc/models/get-transfer.md)

## Example Usage

```csharp
string transferId = "transfer_id6";

try
{
    GetTransfer result = await transfersController.GetTransferByIdAsync(transferId);
}
catch (ApiException e){};
```


# Get Transfers

Gets all transfers

```csharp
GetTransfersAsync()
```

## Response Type

[`Task<Models.ListTransfers>`](../../doc/models/list-transfers.md)

## Example Usage

```csharp
try
{
    ListTransfers result = await transfersController.GetTransfersAsync();
}
catch (ApiException e){};
```

