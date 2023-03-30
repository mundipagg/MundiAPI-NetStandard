# Charges

```csharp
IChargesController chargesController = client.ChargesController;
```

## Class Name

`ChargesController`

## Methods

* [Get Charge](../../doc/controllers/charges.md#get-charge)
* [Confirm Payment](../../doc/controllers/charges.md#confirm-payment)
* [Update Charge Card](../../doc/controllers/charges.md#update-charge-card)
* [Get Charges](../../doc/controllers/charges.md#get-charges)
* [Cancel Charge](../../doc/controllers/charges.md#cancel-charge)
* [Retry Charge](../../doc/controllers/charges.md#retry-charge)
* [Update Charge Payment Method](../../doc/controllers/charges.md#update-charge-payment-method)
* [Update Charge Metadata](../../doc/controllers/charges.md#update-charge-metadata)
* [Capture Charge](../../doc/controllers/charges.md#capture-charge)
* [Update Charge Due Date](../../doc/controllers/charges.md#update-charge-due-date)
* [Create Charge](../../doc/controllers/charges.md#create-charge)
* [Get Charge Transactions](../../doc/controllers/charges.md#get-charge-transactions)
* [Get Charges Summary](../../doc/controllers/charges.md#get-charges-summary)


# Get Charge

Get a charge from its id

```csharp
GetChargeAsync(
    string chargeId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";

try
{
    GetChargeResponse result = await chargesController.GetChargeAsync(chargeId);
}
catch (ApiException e){};
```


# Confirm Payment

```csharp
ConfirmPaymentAsync(
    string chargeId,
    Models.CreateConfirmPaymentRequest request = null,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | - |
| `request` | [`Models.CreateConfirmPaymentRequest`](../../doc/models/create-confirm-payment-request.md) | Body, Optional | Request for confirm payment |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";

try
{
    GetChargeResponse result = await chargesController.ConfirmPaymentAsync(chargeId, null, null);
}
catch (ApiException e){};
```


# Update Charge Card

Updates the card from a charge

```csharp
UpdateChargeCardAsync(
    string chargeId,
    Models.UpdateChargeCardRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.UpdateChargeCardRequest`](../../doc/models/update-charge-card-request.md) | Body, Required | Request for updating a charge's card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
var request = new UpdateChargeCardRequest();
request.UpdateSubscription = false;
request.CardId = "card_id2";
request.Card = new CreateCardRequest();
request.Card.Number = "number2";
request.Card.HolderName = "holder_name6";
request.Card.ExpMonth = 80;
request.Card.ExpYear = 216;
request.Card.Cvv = "cvv8";
request.Card.BillingAddress = new CreateAddressRequest();
request.Card.BillingAddress.Street = "street2";
request.Card.BillingAddress.Number = "number0";
request.Card.BillingAddress.ZipCode = "zip_code6";
request.Card.BillingAddress.Neighborhood = "neighborhood8";
request.Card.BillingAddress.City = "city8";
request.Card.BillingAddress.State = "state2";
request.Card.BillingAddress.Country = "country6";
request.Card.BillingAddress.Complement = "complement2";
request.Card.BillingAddress.Metadata = new Dictionary<string, string>();
request.Card.BillingAddress.Metadata.Add("key0", "metadata1");
request.Card.BillingAddress.Line1 = "line_14";
request.Card.BillingAddress.Line2 = "line_20";
request.Card.Brand = "brand4";
request.Card.BillingAddressId = "billing_address_id6";
request.Card.Metadata = new Dictionary<string, string>();
request.Card.Metadata.Add("key0", "metadata3");
request.Card.Metadata.Add("key1", "metadata4");
request.Card.Metadata.Add("key2", "metadata5");
request.Card.Type = "credit";
request.Card.Options = new CreateCardOptionsRequest();
request.Card.Options.VerifyCard = false;
request.Card.PrivateLabel = false;
request.Card.Label = "label0";
request.Recurrence = false;

try
{
    GetChargeResponse result = await chargesController.UpdateChargeCardAsync(chargeId, request, null);
}
catch (ApiException e){};
```


# Get Charges

Lists all charges

```csharp
GetChargesAsync(
    int? page = null,
    int? size = null,
    string code = null,
    string status = null,
    string paymentMethod = null,
    string customerId = null,
    string orderId = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Filter for charge's code |
| `status` | `string` | Query, Optional | Filter for charge's status |
| `paymentMethod` | `string` | Query, Optional | Filter for charge's payment method |
| `customerId` | `string` | Query, Optional | Filter for charge's customer id |
| `orderId` | `string` | Query, Optional | Filter for charge's order id |
| `createdSince` | `DateTime?` | Query, Optional | Filter for the beginning of the range for charge's creation |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for the end of the range for charge's creation |

## Response Type

[`Task<Models.ListChargesResponse>`](../../doc/models/list-charges-response.md)

## Example Usage

```csharp
try
{
    ListChargesResponse result = await chargesController.GetChargesAsync(null, null, null, null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Cancel Charge

Cancel a charge

```csharp
CancelChargeAsync(
    string chargeId,
    Models.CreateCancelChargeRequest request = null,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.CreateCancelChargeRequest`](../../doc/models/create-cancel-charge-request.md) | Body, Optional | Request for cancelling a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";

try
{
    GetChargeResponse result = await chargesController.CancelChargeAsync(chargeId, null, null);
}
catch (ApiException e){};
```


# Retry Charge

Retries a charge

```csharp
RetryChargeAsync(
    string chargeId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";

try
{
    GetChargeResponse result = await chargesController.RetryChargeAsync(chargeId, null);
}
catch (ApiException e){};
```


# Update Charge Payment Method

Updates a charge's payment method

```csharp
UpdateChargePaymentMethodAsync(
    string chargeId,
    Models.UpdateChargePaymentMethodRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.UpdateChargePaymentMethodRequest`](../../doc/models/update-charge-payment-method-request.md) | Body, Required | Request for updating the payment method from a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
var request = new UpdateChargePaymentMethodRequest();
request.UpdateSubscription = false;
request.PaymentMethod = "payment_method4";
request.CreditCard = new CreateCreditCardPaymentRequest();
request.DebitCard = new CreateDebitCardPaymentRequest();
request.Boleto = new CreateBoletoPaymentRequest();
request.Boleto.Retries = 10;
request.Boleto.Bank = "bank4";
request.Boleto.Instructions = "instructions4";
request.Boleto.BillingAddress = new CreateAddressRequest();
request.Boleto.BillingAddress.Street = "street8";
request.Boleto.BillingAddress.Number = "number4";
request.Boleto.BillingAddress.ZipCode = "zip_code2";
request.Boleto.BillingAddress.Neighborhood = "neighborhood4";
request.Boleto.BillingAddress.City = "city2";
request.Boleto.BillingAddress.State = "state6";
request.Boleto.BillingAddress.Country = "country2";
request.Boleto.BillingAddress.Complement = "complement6";
request.Boleto.BillingAddress.Metadata = new Dictionary<string, string>();
request.Boleto.BillingAddress.Metadata.Add("key0", "metadata5");
request.Boleto.BillingAddress.Line1 = "line_18";
request.Boleto.BillingAddress.Line2 = "line_26";
request.Boleto.BillingAddressId = "billing_address_id2";
request.Boleto.DocumentNumber = "document_number0";
request.Voucher = new CreateVoucherPaymentRequest();
request.Cash = new CreateCashPaymentRequest();
request.Cash.Description = "description6";
request.Cash.Confirm = false;
request.BankTransfer = new CreateBankTransferPaymentRequest();
request.BankTransfer.Bank = "bank4";
request.BankTransfer.Retries = 204;
request.PrivateLabel = new CreatePrivateLabelPaymentRequest();

try
{
    GetChargeResponse result = await chargesController.UpdateChargePaymentMethodAsync(chargeId, request, null);
}
catch (ApiException e){};
```


# Update Charge Metadata

Updates the metadata from a charge

```csharp
UpdateChargeMetadataAsync(
    string chargeId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | The charge id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the charge metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
var request = new UpdateMetadataRequest();
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetChargeResponse result = await chargesController.UpdateChargeMetadataAsync(chargeId, request, null);
}
catch (ApiException e){};
```


# Capture Charge

Captures a charge

```csharp
CaptureChargeAsync(
    string chargeId,
    Models.CreateCaptureChargeRequest request = null,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.CreateCaptureChargeRequest`](../../doc/models/create-capture-charge-request.md) | Body, Optional | Request for capturing a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";

try
{
    GetChargeResponse result = await chargesController.CaptureChargeAsync(chargeId, null, null);
}
catch (ApiException e){};
```


# Update Charge Due Date

Updates the due date from a charge

```csharp
UpdateChargeDueDateAsync(
    string chargeId,
    Models.UpdateChargeDueDateRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge Id |
| `request` | [`Models.UpdateChargeDueDateRequest`](../../doc/models/update-charge-due-date-request.md) | Body, Required | Request for updating the due date |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
var request = new UpdateChargeDueDateRequest();

try
{
    GetChargeResponse result = await chargesController.UpdateChargeDueDateAsync(chargeId, request, null);
}
catch (ApiException e){};
```


# Create Charge

Creates a new charge

```csharp
CreateChargeAsync(
    Models.CreateChargeRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateChargeRequest`](../../doc/models/create-charge-request.md) | Body, Required | Request for creating a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
var request = new CreateChargeRequest();
request.Code = "code4";
request.Amount = 242;
request.CustomerId = "customer_id4";
request.Customer = new CreateCustomerRequest();
request.Customer.Name = "{\\n    \"name\": \"Tony Stark\"\\n}";
request.Customer.Email = "email0";
request.Customer.Document = "document0";
request.Customer.Type = "type4";
request.Customer.Address = new CreateAddressRequest();
request.Customer.Address.Street = "street2";
request.Customer.Address.Number = "number0";
request.Customer.Address.ZipCode = "zip_code6";
request.Customer.Address.Neighborhood = "neighborhood8";
request.Customer.Address.City = "city2";
request.Customer.Address.State = "state8";
request.Customer.Address.Country = "country6";
request.Customer.Address.Complement = "complement8";
request.Customer.Address.Metadata = new Dictionary<string, string>();
request.Customer.Address.Metadata.Add("key0", "metadata7");
request.Customer.Address.Metadata.Add("key1", "metadata6");
request.Customer.Address.Line1 = "line_16";
request.Customer.Address.Line2 = "line_20";
request.Customer.Metadata = new Dictionary<string, string>();
request.Customer.Metadata.Add("key0", "metadata3");
request.Customer.Metadata.Add("key1", "metadata2");
request.Customer.Metadata.Add("key2", "metadata1");
request.Customer.Phones = new CreatePhonesRequest();
request.Customer.Code = "code4";
request.Payment = new CreatePaymentRequest();
request.Payment.PaymentMethod = "payment_method2";
request.Payment.PrivateLabel = new CreatePrivateLabelPaymentRequest();
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");
request.Antifraud = new CreateAntifraudRequest();
request.Antifraud.Type = "type0";
request.Antifraud.Clearsale = new CreateClearSaleRequest();
request.Antifraud.Clearsale.CustomSla = 52;
request.OrderId = "order_id0";

try
{
    GetChargeResponse result = await chargesController.CreateChargeAsync(request, null);
}
catch (ApiException e){};
```


# Get Charge Transactions

```csharp
GetChargeTransactionsAsync(
    string chargeId,
    int? page = null,
    int? size = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge Id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListChargeTransactionsResponse>`](../../doc/models/list-charge-transactions-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";

try
{
    ListChargeTransactionsResponse result = await chargesController.GetChargeTransactionsAsync(chargeId, null, null);
}
catch (ApiException e){};
```


# Get Charges Summary

```csharp
GetChargesSummaryAsync(
    string status,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `string` | Query, Required | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.GetChargesSummaryResponse>`](../../doc/models/get-charges-summary-response.md)

## Example Usage

```csharp
string status = "status8";

try
{
    GetChargesSummaryResponse result = await chargesController.GetChargesSummaryAsync(status, null, null);
}
catch (ApiException e){};
```

