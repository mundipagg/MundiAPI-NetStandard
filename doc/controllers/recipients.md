# Recipients

```csharp
IRecipientsController recipientsController = client.RecipientsController;
```

## Class Name

`RecipientsController`

## Methods

* [Update Recipient Metadata](../../doc/controllers/recipients.md#update-recipient-metadata)
* [Update Recipient Transfer Settings](../../doc/controllers/recipients.md#update-recipient-transfer-settings)
* [Get Anticipation](../../doc/controllers/recipients.md#get-anticipation)
* [Get Recipients](../../doc/controllers/recipients.md#get-recipients)
* [Get Balance](../../doc/controllers/recipients.md#get-balance)
* [Get Anticipations](../../doc/controllers/recipients.md#get-anticipations)
* [Create Anticipation](../../doc/controllers/recipients.md#create-anticipation)
* [Update Recipient Default Bank Account](../../doc/controllers/recipients.md#update-recipient-default-bank-account)
* [Get Recipient](../../doc/controllers/recipients.md#get-recipient)
* [Get Anticipation Limits](../../doc/controllers/recipients.md#get-anticipation-limits)
* [Get Transfer](../../doc/controllers/recipients.md#get-transfer)
* [Get Transfers](../../doc/controllers/recipients.md#get-transfers)
* [Update Recipient](../../doc/controllers/recipients.md#update-recipient)
* [Create Recipient](../../doc/controllers/recipients.md#create-recipient)
* [Create Transfer](../../doc/controllers/recipients.md#create-transfer)
* [Create Withdraw](../../doc/controllers/recipients.md#create-withdraw)
* [Get Withdraw by Id](../../doc/controllers/recipients.md#get-withdraw-by-id)
* [Get Withdrawals](../../doc/controllers/recipients.md#get-withdrawals)
* [Update Automatic Anticipation Settings](../../doc/controllers/recipients.md#update-automatic-anticipation-settings)
* [Get Recipient by Code](../../doc/controllers/recipients.md#get-recipient-by-code)


# Update Recipient Metadata

Updates recipient metadata

```csharp
UpdateRecipientMetadataAsync(
    string recipientId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new UpdateMetadataRequest();
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientMetadataAsync(recipientId, request, null);
}
catch (ApiException e){};
```


# Update Recipient Transfer Settings

```csharp
UpdateRecipientTransferSettingsAsync(
    string recipientId,
    Models.UpdateTransferSettingsRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient Identificator |
| `request` | [`Models.UpdateTransferSettingsRequest`](../../doc/models/update-transfer-settings-request.md) | Body, Required | - |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new UpdateTransferSettingsRequest();
request.TransferEnabled = "transfer_enabled2";
request.TransferInterval = "transfer_interval6";
request.TransferDay = "transfer_day6";

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientTransferSettingsAsync(recipientId, request, null);
}
catch (ApiException e){};
```


# Get Anticipation

Gets an anticipation

```csharp
GetAnticipationAsync(
    string recipientId,
    string anticipationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `anticipationId` | `string` | Template, Required | Anticipation id |

## Response Type

[`Task<Models.GetAnticipationResponse>`](../../doc/models/get-anticipation-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string anticipationId = "anticipation_id0";

try
{
    GetAnticipationResponse result = await recipientsController.GetAnticipationAsync(recipientId, anticipationId);
}
catch (ApiException e){};
```


# Get Recipients

Retrieves paginated recipients information

```csharp
GetRecipientsAsync(
    int? page = null,
    int? size = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListRecipientResponse>`](../../doc/models/list-recipient-response.md)

## Example Usage

```csharp
try
{
    ListRecipientResponse result = await recipientsController.GetRecipientsAsync(null, null);
}
catch (ApiException e){};
```


# Get Balance

Get balance information for a recipient

```csharp
GetBalanceAsync(
    string recipientId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |

## Response Type

[`Task<Models.GetBalanceResponse>`](../../doc/models/get-balance-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";

try
{
    GetBalanceResponse result = await recipientsController.GetBalanceAsync(recipientId);
}
catch (ApiException e){};
```


# Get Anticipations

Retrieves a paginated list of anticipations from a recipient

```csharp
GetAnticipationsAsync(
    string recipientId,
    int? page = null,
    int? size = null,
    string status = null,
    string timeframe = null,
    DateTime? paymentDateSince = null,
    DateTime? paymentDateUntil = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `status` | `string` | Query, Optional | Filter for anticipation status |
| `timeframe` | `string` | Query, Optional | Filter for anticipation timeframe |
| `paymentDateSince` | `DateTime?` | Query, Optional | Filter for start range for anticipation payment date |
| `paymentDateUntil` | `DateTime?` | Query, Optional | Filter for end range for anticipation payment date |
| `createdSince` | `DateTime?` | Query, Optional | Filter for start range for anticipation creation date |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for end range for anticipation creation date |

## Response Type

[`Task<Models.ListAnticipationResponse>`](../../doc/models/list-anticipation-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";

try
{
    ListAnticipationResponse result = await recipientsController.GetAnticipationsAsync(recipientId, null, null, null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Create Anticipation

Creates an anticipation

```csharp
CreateAnticipationAsync(
    string recipientId,
    Models.CreateAnticipationRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.CreateAnticipationRequest`](../../doc/models/create-anticipation-request.md) | Body, Required | Anticipation data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetAnticipationResponse>`](../../doc/models/get-anticipation-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new CreateAnticipationRequest();
request.Amount = 242;
request.Timeframe = "timeframe8";
request.PaymentDate = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    GetAnticipationResponse result = await recipientsController.CreateAnticipationAsync(recipientId, request, null);
}
catch (ApiException e){};
```


# Update Recipient Default Bank Account

Updates the default bank account from a recipient

```csharp
UpdateRecipientDefaultBankAccountAsync(
    string recipientId,
    Models.UpdateRecipientBankAccountRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateRecipientBankAccountRequest`](../../doc/models/update-recipient-bank-account-request.md) | Body, Required | Bank account data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new UpdateRecipientBankAccountRequest();
request.BankAccount = new CreateBankAccountRequest();
request.BankAccount.HolderName = "holder_name6";
request.BankAccount.HolderType = "holder_type2";
request.BankAccount.HolderDocument = "holder_document4";
request.BankAccount.Bank = "bank8";
request.BankAccount.BranchNumber = "branch_number6";
request.BankAccount.BranchCheckDigit = "branch_check_digit6";
request.BankAccount.AccountNumber = "account_number0";
request.BankAccount.AccountCheckDigit = "account_check_digit6";
request.BankAccount.Type = "type0";
request.BankAccount.Metadata = new Dictionary<string, string>();
request.BankAccount.Metadata.Add("key0", "metadata9");
request.BankAccount.Metadata.Add("key1", "metadata8");
request.BankAccount.PixKey = "pix_key4";
request.PaymentMode = "bank_transfer";

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientDefaultBankAccountAsync(recipientId, request, null);
}
catch (ApiException e){};
```


# Get Recipient

Retrieves recipient information

```csharp
GetRecipientAsync(
    string recipientId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipiend id |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";

try
{
    GetRecipientResponse result = await recipientsController.GetRecipientAsync(recipientId);
}
catch (ApiException e){};
```


# Get Anticipation Limits

Gets the anticipation limits for a recipient

```csharp
GetAnticipationLimitsAsync(
    string recipientId,
    string timeframe,
    DateTime paymentDate)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `timeframe` | `string` | Query, Required | Timeframe |
| `paymentDate` | `DateTime` | Query, Required | Anticipation payment date |

## Response Type

[`Task<Models.GetAnticipationLimitResponse>`](../../doc/models/get-anticipation-limit-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string timeframe = "timeframe2";
DateTime paymentDate = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    GetAnticipationLimitResponse result = await recipientsController.GetAnticipationLimitsAsync(recipientId, timeframe, paymentDate);
}
catch (ApiException e){};
```


# Get Transfer

Gets a transfer

```csharp
GetTransferAsync(
    string recipientId,
    string transferId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `transferId` | `string` | Template, Required | Transfer id |

## Response Type

[`Task<Models.GetTransferResponse>`](../../doc/models/get-transfer-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string transferId = "transfer_id6";

try
{
    GetTransferResponse result = await recipientsController.GetTransferAsync(recipientId, transferId);
}
catch (ApiException e){};
```


# Get Transfers

Gets a paginated list of transfers for the recipient

```csharp
GetTransfersAsync(
    string recipientId,
    int? page = null,
    int? size = null,
    string status = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `status` | `string` | Query, Optional | Filter for transfer status |
| `createdSince` | `DateTime?` | Query, Optional | Filter for start range of transfer creation date |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for end range of transfer creation date |

## Response Type

[`Task<Models.ListTransferResponse>`](../../doc/models/list-transfer-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";

try
{
    ListTransferResponse result = await recipientsController.GetTransfersAsync(recipientId, null, null, null, null, null);
}
catch (ApiException e){};
```


# Update Recipient

Updates a recipient

```csharp
UpdateRecipientAsync(
    string recipientId,
    Models.UpdateRecipientRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateRecipientRequest`](../../doc/models/update-recipient-request.md) | Body, Required | Recipient data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new UpdateRecipientRequest();
request.Name = "name6";
request.Email = "email0";
request.Description = "description6";
request.Type = "type4";
request.Status = "status8";
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientAsync(recipientId, request, null);
}
catch (ApiException e){};
```


# Create Recipient

Creates a new recipient

```csharp
CreateRecipientAsync(
    Models.CreateRecipientRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateRecipientRequest`](../../doc/models/create-recipient-request.md) | Body, Required | Recipient data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
var request = new CreateRecipientRequest();
request.Name = "name6";
request.Email = "email0";
request.Description = "description6";
request.Document = "document0";
request.Type = "type4";
request.DefaultBankAccount = new CreateBankAccountRequest();
request.DefaultBankAccount.HolderName = "holder_name0";
request.DefaultBankAccount.HolderType = "holder_type6";
request.DefaultBankAccount.HolderDocument = "holder_document8";
request.DefaultBankAccount.Bank = "bank2";
request.DefaultBankAccount.BranchNumber = "branch_number0";
request.DefaultBankAccount.BranchCheckDigit = "branch_check_digit0";
request.DefaultBankAccount.AccountNumber = "account_number4";
request.DefaultBankAccount.AccountCheckDigit = "account_check_digit0";
request.DefaultBankAccount.Type = "type4";
request.DefaultBankAccount.Metadata = new Dictionary<string, string>();
request.DefaultBankAccount.Metadata.Add("key0", "metadata5");
request.DefaultBankAccount.PixKey = "pix_key8";
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");
request.Code = "code4";
request.PaymentMode = "bank_transfer";

try
{
    GetRecipientResponse result = await recipientsController.CreateRecipientAsync(request, null);
}
catch (ApiException e){};
```


# Create Transfer

Creates a transfer for a recipient

```csharp
CreateTransferAsync(
    string recipientId,
    Models.CreateTransferRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient Id |
| `request` | [`Models.CreateTransferRequest`](../../doc/models/create-transfer-request.md) | Body, Required | Transfer data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetTransferResponse>`](../../doc/models/get-transfer-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new CreateTransferRequest();
request.Amount = 242;
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetTransferResponse result = await recipientsController.CreateTransferAsync(recipientId, request, null);
}
catch (ApiException e){};
```


# Create Withdraw

```csharp
CreateWithdrawAsync(
    string recipientId,
    Models.CreateWithdrawRequest request)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `request` | [`Models.CreateWithdrawRequest`](../../doc/models/create-withdraw-request.md) | Body, Required | - |

## Response Type

[`Task<Models.GetWithdrawResponse>`](../../doc/models/get-withdraw-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new CreateWithdrawRequest();
request.Amount = 242;

try
{
    GetWithdrawResponse result = await recipientsController.CreateWithdrawAsync(recipientId, request);
}
catch (ApiException e){};
```


# Get Withdraw by Id

```csharp
GetWithdrawByIdAsync(
    string recipientId,
    string withdrawalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `withdrawalId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.GetWithdrawResponse>`](../../doc/models/get-withdraw-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string withdrawalId = "withdrawal_id2";

try
{
    GetWithdrawResponse result = await recipientsController.GetWithdrawByIdAsync(recipientId, withdrawalId);
}
catch (ApiException e){};
```


# Get Withdrawals

Gets a paginated list of transfers for the recipient

```csharp
GetWithdrawalsAsync(
    string recipientId,
    int? page = null,
    int? size = null,
    string status = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `page` | `int?` | Query, Optional | - |
| `size` | `int?` | Query, Optional | - |
| `status` | `string` | Query, Optional | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ListWithdrawals>`](../../doc/models/list-withdrawals.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";

try
{
    ListWithdrawals result = await recipientsController.GetWithdrawalsAsync(recipientId, null, null, null, null, null);
}
catch (ApiException e){};
```


# Update Automatic Anticipation Settings

Updates recipient metadata

```csharp
UpdateAutomaticAnticipationSettingsAsync(
    string recipientId,
    Models.UpdateAutomaticAnticipationSettingsRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateAutomaticAnticipationSettingsRequest`](../../doc/models/update-automatic-anticipation-settings-request.md) | Body, Required | Metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
var request = new UpdateAutomaticAnticipationSettingsRequest();

try
{
    GetRecipientResponse result = await recipientsController.UpdateAutomaticAnticipationSettingsAsync(recipientId, request, null);
}
catch (ApiException e){};
```


# Get Recipient by Code

Retrieves recipient information

```csharp
GetRecipientByCodeAsync(
    string code)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `code` | `string` | Template, Required | Recipient code |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string code = "code8";

try
{
    GetRecipientResponse result = await recipientsController.GetRecipientByCodeAsync(code);
}
catch (ApiException e){};
```

