# Subscriptions

```csharp
ISubscriptionsController subscriptionsController = client.SubscriptionsController;
```

## Class Name

`SubscriptionsController`

## Methods

* [Create Discount](../../doc/controllers/subscriptions.md#create-discount)
* [Get Subscription Item](../../doc/controllers/subscriptions.md#get-subscription-item)
* [Delete Usage](../../doc/controllers/subscriptions.md#delete-usage)
* [Cancel Subscription](../../doc/controllers/subscriptions.md#cancel-subscription)
* [Delete Increment](../../doc/controllers/subscriptions.md#delete-increment)
* [Get Subscription Cycle by Id](../../doc/controllers/subscriptions.md#get-subscription-cycle-by-id)
* [Update Subscription Start At](../../doc/controllers/subscriptions.md#update-subscription-start-at)
* [Update Subscription Payment Method](../../doc/controllers/subscriptions.md#update-subscription-payment-method)
* [Update Current Cycle Status](../../doc/controllers/subscriptions.md#update-current-cycle-status)
* [Create Subscription](../../doc/controllers/subscriptions.md#create-subscription)
* [Get Usages Details](../../doc/controllers/subscriptions.md#get-usages-details)
* [Renew Subscription](../../doc/controllers/subscriptions.md#renew-subscription)
* [Update Subscription Item](../../doc/controllers/subscriptions.md#update-subscription-item)
* [Create an Usage](../../doc/controllers/subscriptions.md#create-an-usage)
* [Get Increment by Id](../../doc/controllers/subscriptions.md#get-increment-by-id)
* [Delete Discount](../../doc/controllers/subscriptions.md#delete-discount)
* [Get Increments](../../doc/controllers/subscriptions.md#get-increments)
* [Create Usage](../../doc/controllers/subscriptions.md#create-usage)
* [Create Subscription Item](../../doc/controllers/subscriptions.md#create-subscription-item)
* [Get Usages](../../doc/controllers/subscriptions.md#get-usages)
* [Update Subscription Billing Date](../../doc/controllers/subscriptions.md#update-subscription-billing-date)
* [Update Latest Period End At](../../doc/controllers/subscriptions.md#update-latest-period-end-at)
* [Get Subscription Cycles](../../doc/controllers/subscriptions.md#get-subscription-cycles)
* [Get Subscriptions](../../doc/controllers/subscriptions.md#get-subscriptions)
* [Get Discount by Id](../../doc/controllers/subscriptions.md#get-discount-by-id)
* [Get Subscription Items](../../doc/controllers/subscriptions.md#get-subscription-items)
* [Update Subscription Minium Price](../../doc/controllers/subscriptions.md#update-subscription-minium-price)
* [Get Subscription](../../doc/controllers/subscriptions.md#get-subscription)
* [Update Subscription Affiliation Id](../../doc/controllers/subscriptions.md#update-subscription-affiliation-id)
* [Delete Subscription Item](../../doc/controllers/subscriptions.md#delete-subscription-item)
* [Update Subscription Card](../../doc/controllers/subscriptions.md#update-subscription-card)
* [Update Subscription Metadata](../../doc/controllers/subscriptions.md#update-subscription-metadata)
* [Update Subscription Due Days](../../doc/controllers/subscriptions.md#update-subscription-due-days)
* [Get Discounts](../../doc/controllers/subscriptions.md#get-discounts)
* [Create Increment](../../doc/controllers/subscriptions.md#create-increment)
* [Get Usage Report](../../doc/controllers/subscriptions.md#get-usage-report)
* [Update Split Subscription](../../doc/controllers/subscriptions.md#update-split-subscription)


# Create Discount

Creates a discount

```csharp
CreateDiscountAsync(
    string subscriptionId,
    Models.CreateDiscountRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`Models.CreateDiscountRequest`](../../doc/models/create-discount-request.md) | Body, Required | Request for creating a discount |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new CreateDiscountRequest();
request.MValue = 185.28;
request.DiscountType = "discount_type4";
request.ItemId = "item_id6";

try
{
    GetDiscountResponse result = await subscriptionsController.CreateDiscountAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Get Subscription Item

Get Subscription Item

```csharp
GetSubscriptionItemAsync(
    string subscriptionId,
    string itemId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `itemId` | `string` | Template, Required | Item id |

## Response Type

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";

try
{
    GetSubscriptionItemResponse result = await subscriptionsController.GetSubscriptionItemAsync(subscriptionId, itemId);
}
catch (ApiException e){};
```


# Delete Usage

Deletes a usage

```csharp
DeleteUsageAsync(
    string subscriptionId,
    string itemId,
    string usageId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `itemId` | `string` | Template, Required | The subscription item id |
| `usageId` | `string` | Template, Required | The usage id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetUsageResponse>`](../../doc/models/get-usage-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
string usageId = "usage_id0";

try
{
    GetUsageResponse result = await subscriptionsController.DeleteUsageAsync(subscriptionId, itemId, usageId, null);
}
catch (ApiException e){};
```


# Cancel Subscription

Cancels a subscription

```csharp
CancelSubscriptionAsync(
    string subscriptionId,
    Models.CreateCancelSubscriptionRequest request = null,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`Models.CreateCancelSubscriptionRequest`](../../doc/models/create-cancel-subscription-request.md) | Body, Optional | Request for cancelling a subscription |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new CreateCancelSubscriptionRequest();
request.CancelPendingInvoices = true;

try
{
    GetSubscriptionResponse result = await subscriptionsController.CancelSubscriptionAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Delete Increment

Deletes a increment

```csharp
DeleteIncrementAsync(
    string subscriptionId,
    string incrementId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `incrementId` | `string` | Template, Required | Increment id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string incrementId = "increment_id8";

try
{
    GetIncrementResponse result = await subscriptionsController.DeleteIncrementAsync(subscriptionId, incrementId, null);
}
catch (ApiException e){};
```


# Get Subscription Cycle by Id

```csharp
GetSubscriptionCycleByIdAsync(
    string subscriptionId,
    string cycleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `cycleId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.GetPeriodResponse>`](../../doc/models/get-period-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string cycleId = "cycleId0";

try
{
    GetPeriodResponse result = await subscriptionsController.GetSubscriptionCycleByIdAsync(subscriptionId, cycleId);
}
catch (ApiException e){};
```


# Update Subscription Start At

Updates the start at date from a subscription

```csharp
UpdateSubscriptionStartAtAsync(
    string subscriptionId,
    Models.UpdateSubscriptionStartAtRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `request` | [`Models.UpdateSubscriptionStartAtRequest`](../../doc/models/update-subscription-start-at-request.md) | Body, Required | Request for updating the subscription start date |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateSubscriptionStartAtRequest();
request.StartAt = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionStartAtAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Update Subscription Payment Method

Updates the payment method from a subscription

```csharp
UpdateSubscriptionPaymentMethodAsync(
    string subscriptionId,
    Models.UpdateSubscriptionPaymentMethodRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`Models.UpdateSubscriptionPaymentMethodRequest`](../../doc/models/update-subscription-payment-method-request.md) | Body, Required | Request for updating the paymentmethod from a subscription |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateSubscriptionPaymentMethodRequest();
request.PaymentMethod = "payment_method4";
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

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionPaymentMethodAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Update Current Cycle Status

```csharp
UpdateCurrentCycleStatusAsync(
    string subscriptionId,
    Models.UpdateCurrentCycleStatusRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `request` | [`Models.UpdateCurrentCycleStatusRequest`](../../doc/models/update-current-cycle-status-request.md) | Body, Required | Request for updating the end date of the subscription current status |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateCurrentCycleStatusRequest();
request.Status = "status8";

try
{
    await subscriptionsController.UpdateCurrentCycleStatusAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Create Subscription

Creates a new subscription

```csharp
CreateSubscriptionAsync(
    Models.CreateSubscriptionRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CreateSubscriptionRequest`](../../doc/models/create-subscription-request.md) | Body, Required | Request for creating a subscription |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
var body = new CreateSubscriptionRequest();
body.Customer = new CreateCustomerRequest();
body.Customer.Name = "{\\n    \"name\": \"Tony Stark\"\\n}";
body.Customer.Email = "email2";
body.Customer.Document = "document2";
body.Customer.Type = "type6";
body.Customer.Address = new CreateAddressRequest();
body.Customer.Address.Street = "street0";
body.Customer.Address.Number = "number8";
body.Customer.Address.ZipCode = "zip_code4";
body.Customer.Address.Neighborhood = "neighborhood6";
body.Customer.Address.City = "city0";
body.Customer.Address.State = "state6";
body.Customer.Address.Country = "country4";
body.Customer.Address.Complement = "complement6";
body.Customer.Address.Metadata = new Dictionary<string, string>();
body.Customer.Address.Metadata.Add("key0", "metadata7");
body.Customer.Address.Metadata.Add("key1", "metadata6");
body.Customer.Address.Line1 = "line_16";
body.Customer.Address.Line2 = "line_28";
body.Customer.Metadata = new Dictionary<string, string>();
body.Customer.Metadata.Add("key0", "metadata9");
body.Customer.Metadata.Add("key1", "metadata0");
body.Customer.Phones = new CreatePhonesRequest();
body.Customer.Code = "code2";
body.Card = new CreateCardRequest();
body.Card.Number = "number2";
body.Card.HolderName = "holder_name6";
body.Card.ExpMonth = 60;
body.Card.ExpYear = 236;
body.Card.Cvv = "cvv8";
body.Card.BillingAddress = new CreateAddressRequest();
body.Card.BillingAddress.Street = "street8";
body.Card.BillingAddress.Number = "number4";
body.Card.BillingAddress.ZipCode = "zip_code2";
body.Card.BillingAddress.Neighborhood = "neighborhood4";
body.Card.BillingAddress.City = "city2";
body.Card.BillingAddress.State = "state6";
body.Card.BillingAddress.Country = "country2";
body.Card.BillingAddress.Complement = "complement6";
body.Card.BillingAddress.Metadata = new Dictionary<string, string>();
body.Card.BillingAddress.Metadata.Add("key0", "metadata5");
body.Card.BillingAddress.Metadata.Add("key1", "metadata6");
body.Card.BillingAddress.Metadata.Add("key2", "metadata7");
body.Card.BillingAddress.Line1 = "line_18";
body.Card.BillingAddress.Line2 = "line_26";
body.Card.Brand = "brand4";
body.Card.BillingAddressId = "billing_address_id6";
body.Card.Metadata = new Dictionary<string, string>();
body.Card.Metadata.Add("key0", "metadata3");
body.Card.Metadata.Add("key1", "metadata4");
body.Card.Type = "credit";
body.Card.Options = new CreateCardOptionsRequest();
body.Card.Options.VerifyCard = false;
body.Card.PrivateLabel = false;
body.Card.Label = "label0";
body.Code = "code4";
body.PaymentMethod = "payment_method4";
body.BillingType = "billing_type0";
body.StatementDescriptor = "statement_descriptor6";
body.Description = "description4";
body.Currency = "currency6";
body.Interval = "interval6";
body.IntervalCount = 170;
body.PricingScheme = new CreatePricingSchemeRequest();
body.PricingScheme.SchemeType = "scheme_type2";
body.PricingScheme.PriceBrackets = new List<CreatePriceBracketRequest>();

var bodyPricingSchemePriceBrackets0 = new CreatePriceBracketRequest();
bodyPricingSchemePriceBrackets0.StartQuantity = 31;
bodyPricingSchemePriceBrackets0.Price = 225;
body.PricingScheme.PriceBrackets.Add(bodyPricingSchemePriceBrackets0);

var bodyPricingSchemePriceBrackets1 = new CreatePriceBracketRequest();
bodyPricingSchemePriceBrackets1.StartQuantity = 32;
bodyPricingSchemePriceBrackets1.Price = 226;
body.PricingScheme.PriceBrackets.Add(bodyPricingSchemePriceBrackets1);

body.Items = new List<CreateSubscriptionItemRequest>();

var bodyItems0 = new CreateSubscriptionItemRequest();
bodyItems0.Description = "description3";
bodyItems0.PricingScheme = new CreatePricingSchemeRequest();
bodyItems0.PricingScheme.SchemeType = "scheme_type5";
bodyItems0.PricingScheme.PriceBrackets = new List<CreatePriceBracketRequest>();

var bodyItems0PricingSchemePriceBrackets0 = new CreatePriceBracketRequest();
bodyItems0PricingSchemePriceBrackets0.StartQuantity = 228;
bodyItems0PricingSchemePriceBrackets0.Price = 90;
bodyItems0.PricingScheme.PriceBrackets.Add(bodyItems0PricingSchemePriceBrackets0);

var bodyItems0PricingSchemePriceBrackets1 = new CreatePriceBracketRequest();
bodyItems0PricingSchemePriceBrackets1.StartQuantity = 229;
bodyItems0PricingSchemePriceBrackets1.Price = 89;
bodyItems0.PricingScheme.PriceBrackets.Add(bodyItems0PricingSchemePriceBrackets1);

bodyItems0.Id = "id3";
bodyItems0.PlanItemId = "plan_item_id3";
bodyItems0.Discounts = new List<CreateDiscountRequest>();

var bodyItems0Discounts0 = new CreateDiscountRequest();
bodyItems0Discounts0.MValue = 65.46;
bodyItems0Discounts0.DiscountType = "discount_type2";
bodyItems0Discounts0.ItemId = "item_id4";
bodyItems0.Discounts.Add(bodyItems0Discounts0);

bodyItems0.Name = "name3";
body.Items.Add(bodyItems0);

var bodyItems1 = new CreateSubscriptionItemRequest();
bodyItems1.Description = "description4";
bodyItems1.PricingScheme = new CreatePricingSchemeRequest();
bodyItems1.PricingScheme.SchemeType = "scheme_type4";
bodyItems1.PricingScheme.PriceBrackets = new List<CreatePriceBracketRequest>();

var bodyItems1PricingSchemePriceBrackets0 = new CreatePriceBracketRequest();
bodyItems1PricingSchemePriceBrackets0.StartQuantity = 227;
bodyItems1PricingSchemePriceBrackets0.Price = 91;
bodyItems1.PricingScheme.PriceBrackets.Add(bodyItems1PricingSchemePriceBrackets0);

bodyItems1.Id = "id4";
bodyItems1.PlanItemId = "plan_item_id4";
bodyItems1.Discounts = new List<CreateDiscountRequest>();

var bodyItems1Discounts0 = new CreateDiscountRequest();
bodyItems1Discounts0.MValue = 65.47;
bodyItems1Discounts0.DiscountType = "discount_type3";
bodyItems1Discounts0.ItemId = "item_id5";
bodyItems1.Discounts.Add(bodyItems1Discounts0);

var bodyItems1Discounts1 = new CreateDiscountRequest();
bodyItems1Discounts1.MValue = 65.48;
bodyItems1Discounts1.DiscountType = "discount_type4";
bodyItems1Discounts1.ItemId = "item_id6";
bodyItems1.Discounts.Add(bodyItems1Discounts1);

bodyItems1.Name = "name4";
body.Items.Add(bodyItems1);

var bodyItems2 = new CreateSubscriptionItemRequest();
bodyItems2.Description = "description5";
bodyItems2.PricingScheme = new CreatePricingSchemeRequest();
bodyItems2.PricingScheme.SchemeType = "scheme_type3";
bodyItems2.PricingScheme.PriceBrackets = new List<CreatePriceBracketRequest>();

var bodyItems2PricingSchemePriceBrackets0 = new CreatePriceBracketRequest();
bodyItems2PricingSchemePriceBrackets0.StartQuantity = 226;
bodyItems2PricingSchemePriceBrackets0.Price = 92;
bodyItems2.PricingScheme.PriceBrackets.Add(bodyItems2PricingSchemePriceBrackets0);

var bodyItems2PricingSchemePriceBrackets1 = new CreatePriceBracketRequest();
bodyItems2PricingSchemePriceBrackets1.StartQuantity = 227;
bodyItems2PricingSchemePriceBrackets1.Price = 91;
bodyItems2.PricingScheme.PriceBrackets.Add(bodyItems2PricingSchemePriceBrackets1);

var bodyItems2PricingSchemePriceBrackets2 = new CreatePriceBracketRequest();
bodyItems2PricingSchemePriceBrackets2.StartQuantity = 228;
bodyItems2PricingSchemePriceBrackets2.Price = 90;
bodyItems2.PricingScheme.PriceBrackets.Add(bodyItems2PricingSchemePriceBrackets2);

bodyItems2.Id = "id5";
bodyItems2.PlanItemId = "plan_item_id5";
bodyItems2.Discounts = new List<CreateDiscountRequest>();

var bodyItems2Discounts0 = new CreateDiscountRequest();
bodyItems2Discounts0.MValue = 65.48;
bodyItems2Discounts0.DiscountType = "discount_type4";
bodyItems2Discounts0.ItemId = "item_id6";
bodyItems2.Discounts.Add(bodyItems2Discounts0);

var bodyItems2Discounts1 = new CreateDiscountRequest();
bodyItems2Discounts1.MValue = 65.49;
bodyItems2Discounts1.DiscountType = "discount_type5";
bodyItems2Discounts1.ItemId = "item_id7";
bodyItems2.Discounts.Add(bodyItems2Discounts1);

var bodyItems2Discounts2 = new CreateDiscountRequest();
bodyItems2Discounts2.MValue = 65.5;
bodyItems2Discounts2.DiscountType = "discount_type6";
bodyItems2Discounts2.ItemId = "item_id8";
bodyItems2.Discounts.Add(bodyItems2Discounts2);

bodyItems2.Name = "name5";
body.Items.Add(bodyItems2);

body.Shipping = new CreateShippingRequest();
body.Shipping.Amount = 140;
body.Shipping.Description = "description0";
body.Shipping.RecipientName = "recipient_name8";
body.Shipping.RecipientPhone = "recipient_phone2";
body.Shipping.AddressId = "address_id0";
body.Shipping.Address = new CreateAddressRequest();
body.Shipping.Address.Street = "street6";
body.Shipping.Address.Number = "number4";
body.Shipping.Address.ZipCode = "zip_code0";
body.Shipping.Address.Neighborhood = "neighborhood2";
body.Shipping.Address.City = "city6";
body.Shipping.Address.State = "state2";
body.Shipping.Address.Country = "country0";
body.Shipping.Address.Complement = "complement2";
body.Shipping.Address.Metadata = new Dictionary<string, string>();
body.Shipping.Address.Metadata.Add("key0", "metadata3");
body.Shipping.Address.Metadata.Add("key1", "metadata2");
body.Shipping.Address.Line1 = "line_10";
body.Shipping.Address.Line2 = "line_24";
body.Shipping.Type = "type0";
body.Discounts = new List<CreateDiscountRequest>();

var bodyDiscounts0 = new CreateDiscountRequest();
bodyDiscounts0.MValue = 95.59;
bodyDiscounts0.DiscountType = "discount_type5";
bodyDiscounts0.ItemId = "item_id7";
body.Discounts.Add(bodyDiscounts0);

body.Metadata = new Dictionary<string, string>();
body.Metadata.Add("key0", "metadata7");
body.Metadata.Add("key1", "metadata8");
body.Setup = new CreateSetupRequest();
body.Setup.Amount = 150;
body.Setup.Description = "description0";
body.Setup.Payment = new CreatePaymentRequest();
body.Setup.Payment.PaymentMethod = "payment_method4";
body.Setup.Payment.PrivateLabel = new CreatePrivateLabelPaymentRequest();
body.Increments = new List<CreateIncrementRequest>();

var bodyIncrements0 = new CreateIncrementRequest();
bodyIncrements0.MValue = 38.83;
bodyIncrements0.IncrementType = "increment_type3";
bodyIncrements0.ItemId = "item_id9";
body.Increments.Add(bodyIncrements0);

var bodyIncrements1 = new CreateIncrementRequest();
bodyIncrements1.MValue = 38.84;
bodyIncrements1.IncrementType = "increment_type4";
bodyIncrements1.ItemId = "item_id8";
body.Increments.Add(bodyIncrements1);

var bodyIncrements2 = new CreateIncrementRequest();
bodyIncrements2.MValue = 38.85;
bodyIncrements2.IncrementType = "increment_type5";
bodyIncrements2.ItemId = "item_id7";
body.Increments.Add(bodyIncrements2);


try
{
    GetSubscriptionResponse result = await subscriptionsController.CreateSubscriptionAsync(body, null);
}
catch (ApiException e){};
```


# Get Usages Details

```csharp
GetUsagesDetailsAsync(
    string subscriptionId,
    string cycleId = null,
    int? size = null,
    int? page = null,
    string itemId = null,
    string mGroup = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Identifier |
| `cycleId` | `string` | Query, Optional | Cycle id |
| `size` | `int?` | Query, Optional | Page size |
| `page` | `int?` | Query, Optional | Page number |
| `itemId` | `string` | Query, Optional | Identificador do item |
| `mGroup` | `string` | Query, Optional | identificador da loja (account) de cada item |

## Response Type

[`Task<Models.GetUsagesDetailsResponse>`](../../doc/models/get-usages-details-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";

try
{
    GetUsagesDetailsResponse result = await subscriptionsController.GetUsagesDetailsAsync(subscriptionId, null, null, null, null, null);
}
catch (ApiException e){};
```


# Renew Subscription

```csharp
RenewSubscriptionAsync(
    string subscriptionId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | - |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPeriodResponse>`](../../doc/models/get-period-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";

try
{
    GetPeriodResponse result = await subscriptionsController.RenewSubscriptionAsync(subscriptionId, null);
}
catch (ApiException e){};
```


# Update Subscription Item

Updates a subscription item

```csharp
UpdateSubscriptionItemAsync(
    string subscriptionId,
    string itemId,
    Models.UpdateSubscriptionItemRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `itemId` | `string` | Template, Required | Item id |
| `body` | [`Models.UpdateSubscriptionItemRequest`](../../doc/models/update-subscription-item-request.md) | Body, Required | Request for updating a subscription item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
var body = new UpdateSubscriptionItemRequest();
body.Description = "description4";
body.Status = "status2";
body.PricingScheme = new UpdatePricingSchemeRequest();
body.PricingScheme.SchemeType = "scheme_type2";
body.PricingScheme.PriceBrackets = new List<UpdatePriceBracketRequest>();

var bodyPricingSchemePriceBrackets0 = new UpdatePriceBracketRequest();
bodyPricingSchemePriceBrackets0.StartQuantity = 31;
bodyPricingSchemePriceBrackets0.Price = 225;
body.PricingScheme.PriceBrackets.Add(bodyPricingSchemePriceBrackets0);

var bodyPricingSchemePriceBrackets1 = new UpdatePriceBracketRequest();
bodyPricingSchemePriceBrackets1.StartQuantity = 32;
bodyPricingSchemePriceBrackets1.Price = 226;
body.PricingScheme.PriceBrackets.Add(bodyPricingSchemePriceBrackets1);

body.Name = "name6";

try
{
    GetSubscriptionItemResponse result = await subscriptionsController.UpdateSubscriptionItemAsync(subscriptionId, itemId, body, null);
}
catch (ApiException e){};
```


# Create an Usage

Create Usage

```csharp
CreateAnUsageAsync(
    string subscriptionId,
    string itemId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `itemId` | `string` | Template, Required | Item id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetUsageResponse>`](../../doc/models/get-usage-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";

try
{
    GetUsageResponse result = await subscriptionsController.CreateAnUsageAsync(subscriptionId, itemId, null);
}
catch (ApiException e){};
```


# Get Increment by Id

```csharp
GetIncrementByIdAsync(
    string subscriptionId,
    string incrementId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription Id |
| `incrementId` | `string` | Template, Required | The increment Id |

## Response Type

[`Task<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string incrementId = "increment_id8";

try
{
    GetIncrementResponse result = await subscriptionsController.GetIncrementByIdAsync(subscriptionId, incrementId);
}
catch (ApiException e){};
```


# Delete Discount

Deletes a discount

```csharp
DeleteDiscountAsync(
    string subscriptionId,
    string discountId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `discountId` | `string` | Template, Required | Discount Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string discountId = "discount_id8";

try
{
    GetDiscountResponse result = await subscriptionsController.DeleteDiscountAsync(subscriptionId, discountId, null);
}
catch (ApiException e){};
```


# Get Increments

```csharp
GetIncrementsAsync(
    string subscriptionId,
    int? page = null,
    int? size = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListIncrementsResponse>`](../../doc/models/list-increments-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";

try
{
    ListIncrementsResponse result = await subscriptionsController.GetIncrementsAsync(subscriptionId, null, null);
}
catch (ApiException e){};
```


# Create Usage

Creates a usage

```csharp
CreateUsageAsync(
    string subscriptionId,
    string itemId,
    Models.CreateUsageRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `itemId` | `string` | Template, Required | Item id |
| `body` | [`Models.CreateUsageRequest`](../../doc/models/create-usage-request.md) | Body, Required | Request for creating a usage |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetUsageResponse>`](../../doc/models/get-usage-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
var body = new CreateUsageRequest();
body.Quantity = 156;
body.Description = "description4";
body.UsedAt = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    GetUsageResponse result = await subscriptionsController.CreateUsageAsync(subscriptionId, itemId, body, null);
}
catch (ApiException e){};
```


# Create Subscription Item

Creates a new Subscription item

```csharp
CreateSubscriptionItemAsync(
    string subscriptionId,
    Models.CreateSubscriptionItemRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`Models.CreateSubscriptionItemRequest`](../../doc/models/create-subscription-item-request.md) | Body, Required | Request for creating a subscription item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new CreateSubscriptionItemRequest();
request.Description = "description6";
request.PricingScheme = new CreatePricingSchemeRequest();
request.PricingScheme.SchemeType = "scheme_type2";
request.PricingScheme.PriceBrackets = new List<CreatePriceBracketRequest>();

var requestPricingSchemePriceBrackets0 = new CreatePriceBracketRequest();
requestPricingSchemePriceBrackets0.StartQuantity = 87;
requestPricingSchemePriceBrackets0.Price = 231;
request.PricingScheme.PriceBrackets.Add(requestPricingSchemePriceBrackets0);

request.Id = "id6";
request.PlanItemId = "plan_item_id6";
request.Discounts = new List<CreateDiscountRequest>();

var requestDiscounts0 = new CreateDiscountRequest();
requestDiscounts0.MValue = 199.99;
requestDiscounts0.DiscountType = "discount_type5";
requestDiscounts0.ItemId = "item_id7";
request.Discounts.Add(requestDiscounts0);

var requestDiscounts1 = new CreateDiscountRequest();
requestDiscounts1.MValue = 200;
requestDiscounts1.DiscountType = "discount_type6";
requestDiscounts1.ItemId = "item_id8";
request.Discounts.Add(requestDiscounts1);

request.Name = "name6";

try
{
    GetSubscriptionItemResponse result = await subscriptionsController.CreateSubscriptionItemAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Get Usages

Lists all usages from a subscription item

```csharp
GetUsagesAsync(
    string subscriptionId,
    string itemId,
    int? page = null,
    int? size = null,
    string code = null,
    string mGroup = null,
    DateTime? usedSince = null,
    DateTime? usedUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `itemId` | `string` | Template, Required | The subscription item id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Identification code in the client system |
| `mGroup` | `string` | Query, Optional | Identification group in the client system |
| `usedSince` | `DateTime?` | Query, Optional | - |
| `usedUntil` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ListUsagesResponse>`](../../doc/models/list-usages-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";

try
{
    ListUsagesResponse result = await subscriptionsController.GetUsagesAsync(subscriptionId, itemId, null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Update Subscription Billing Date

Updates the billing date from a subscription

```csharp
UpdateSubscriptionBillingDateAsync(
    string subscriptionId,
    Models.UpdateSubscriptionBillingDateRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `request` | [`Models.UpdateSubscriptionBillingDateRequest`](../../doc/models/update-subscription-billing-date-request.md) | Body, Required | Request for updating the subscription billing date |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateSubscriptionBillingDateRequest();
request.NextBillingAt = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionBillingDateAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Update Latest Period End At

```csharp
UpdateLatestPeriodEndAtAsync(
    string subscriptionId,
    Models.UpdateCurrentCycleEndDateRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | - |
| `request` | [`Models.UpdateCurrentCycleEndDateRequest`](../../doc/models/update-current-cycle-end-date-request.md) | Body, Required | Request for updating the end date of the current signature cycle |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateCurrentCycleEndDateRequest();

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateLatestPeriodEndAtAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Get Subscription Cycles

```csharp
GetSubscriptionCyclesAsync(
    string subscriptionId,
    string page,
    string size)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `page` | `string` | Query, Required | Page number |
| `size` | `string` | Query, Required | Page size |

## Response Type

[`Task<Models.ListCyclesResponse>`](../../doc/models/list-cycles-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string page = "page8";
string size = "size0";

try
{
    ListCyclesResponse result = await subscriptionsController.GetSubscriptionCyclesAsync(subscriptionId, page, size);
}
catch (ApiException e){};
```


# Get Subscriptions

Gets all subscriptions

```csharp
GetSubscriptionsAsync(
    int? page = null,
    int? size = null,
    string code = null,
    string billingType = null,
    string customerId = null,
    string planId = null,
    string cardId = null,
    string status = null,
    DateTime? nextBillingSince = null,
    DateTime? nextBillingUntil = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Filter for subscription's code |
| `billingType` | `string` | Query, Optional | Filter for subscription's billing type |
| `customerId` | `string` | Query, Optional | Filter for subscription's customer id |
| `planId` | `string` | Query, Optional | Filter for subscription's plan id |
| `cardId` | `string` | Query, Optional | Filter for subscription's card id |
| `status` | `string` | Query, Optional | Filter for subscription's status |
| `nextBillingSince` | `DateTime?` | Query, Optional | Filter for subscription's next billing date start range |
| `nextBillingUntil` | `DateTime?` | Query, Optional | Filter for subscription's next billing date end range |
| `createdSince` | `DateTime?` | Query, Optional | Filter for subscription's creation date start range |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for subscriptions creation date end range |

## Response Type

[`Task<Models.ListSubscriptionsResponse>`](../../doc/models/list-subscriptions-response.md)

## Example Usage

```csharp
try
{
    ListSubscriptionsResponse result = await subscriptionsController.GetSubscriptionsAsync(null, null, null, null, null, null, null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Get Discount by Id

```csharp
GetDiscountByIdAsync(
    string subscriptionId,
    string discountId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `discountId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string discountId = "discountId0";

try
{
    GetDiscountResponse result = await subscriptionsController.GetDiscountByIdAsync(subscriptionId, discountId);
}
catch (ApiException e){};
```


# Get Subscription Items

Get Subscription Items

```csharp
GetSubscriptionItemsAsync(
    string subscriptionId,
    int? page = null,
    int? size = null,
    string name = null,
    string code = null,
    string status = null,
    string description = null,
    string createdSince = null,
    string createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `name` | `string` | Query, Optional | The item name |
| `code` | `string` | Query, Optional | Identification code in the client system |
| `status` | `string` | Query, Optional | The item statis |
| `description` | `string` | Query, Optional | The item description |
| `createdSince` | `string` | Query, Optional | Filter for item's creation date start range |
| `createdUntil` | `string` | Query, Optional | Filter for item's creation date end range |

## Response Type

[`Task<Models.ListSubscriptionItemsResponse>`](../../doc/models/list-subscription-items-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";

try
{
    ListSubscriptionItemsResponse result = await subscriptionsController.GetSubscriptionItemsAsync(subscriptionId, null, null, null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Update Subscription Minium Price

Atualização do valor mínimo da assinatura

```csharp
UpdateSubscriptionMiniumPriceAsync(
    string subscriptionId,
    Models.UpdateSubscriptionMinimumPriceRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `request` | [`Models.UpdateSubscriptionMinimumPriceRequest`](../../doc/models/update-subscription-minimum-price-request.md) | Body, Required | Request da requisição com o valor mínimo que será configurado |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateSubscriptionMinimumPriceRequest();

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionMiniumPriceAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Get Subscription

Gets a subscription

```csharp
GetSubscriptionAsync(
    string subscriptionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";

try
{
    GetSubscriptionResponse result = await subscriptionsController.GetSubscriptionAsync(subscriptionId);
}
catch (ApiException e){};
```


# Update Subscription Affiliation Id

```csharp
UpdateSubscriptionAffiliationIdAsync(
    string subscriptionId,
    Models.UpdateSubscriptionAffiliationIdRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | - |
| `request` | [`Models.UpdateSubscriptionAffiliationIdRequest`](../../doc/models/update-subscription-affiliation-id-request.md) | Body, Required | Request for updating a subscription affiliation id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateSubscriptionAffiliationIdRequest();
request.GatewayAffiliationId = "gateway_affiliation_id2";

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionAffiliationIdAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Delete Subscription Item

Deletes a subscription item

```csharp
DeleteSubscriptionItemAsync(
    string subscriptionId,
    string subscriptionItemId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `subscriptionItemId` | `string` | Template, Required | Subscription item id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string subscriptionItemId = "subscription_item_id4";

try
{
    GetSubscriptionItemResponse result = await subscriptionsController.DeleteSubscriptionItemAsync(subscriptionId, subscriptionItemId, null);
}
catch (ApiException e){};
```


# Update Subscription Card

Updates the credit card from a subscription

```csharp
UpdateSubscriptionCardAsync(
    string subscriptionId,
    Models.UpdateSubscriptionCardRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`Models.UpdateSubscriptionCardRequest`](../../doc/models/update-subscription-card-request.md) | Body, Required | Request for updating a card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateSubscriptionCardRequest();
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
request.CardId = "card_id2";

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionCardAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Update Subscription Metadata

Updates the metadata from a subscription

```csharp
UpdateSubscriptionMetadataAsync(
    string subscriptionId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the subscrption metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateMetadataRequest();
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionMetadataAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Update Subscription Due Days

Updates the boleto due days from a subscription

```csharp
UpdateSubscriptionDueDaysAsync(
    string subscriptionId,
    Models.UpdateSubscriptionDueDaysRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `request` | [`Models.UpdateSubscriptionDueDaysRequest`](../../doc/models/update-subscription-due-days-request.md) | Body, Required | - |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new UpdateSubscriptionDueDaysRequest();
request.BoletoDueDays = 226;

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionDueDaysAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Get Discounts

```csharp
GetDiscountsAsync(
    string subscriptionId,
    int page,
    int size)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `page` | `int` | Query, Required | Page number |
| `size` | `int` | Query, Required | Page size |

## Response Type

[`Task<Models.ListDiscountsResponse>`](../../doc/models/list-discounts-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
int page = 30;
int size = 18;

try
{
    ListDiscountsResponse result = await subscriptionsController.GetDiscountsAsync(subscriptionId, page, size);
}
catch (ApiException e){};
```


# Create Increment

Creates a increment

```csharp
CreateIncrementAsync(
    string subscriptionId,
    Models.CreateIncrementRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`Models.CreateIncrementRequest`](../../doc/models/create-increment-request.md) | Body, Required | Request for creating a increment |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
var request = new CreateIncrementRequest();
request.MValue = 185.28;
request.IncrementType = "increment_type8";
request.ItemId = "item_id6";

try
{
    GetIncrementResponse result = await subscriptionsController.CreateIncrementAsync(subscriptionId, request, null);
}
catch (ApiException e){};
```


# Get Usage Report

```csharp
GetUsageReportAsync(
    string subscriptionId,
    string periodId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription Id |
| `periodId` | `string` | Template, Required | The period Id |

## Response Type

[`Task<Models.GetUsageReportResponse>`](../../doc/models/get-usage-report-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string periodId = "period_id0";

try
{
    GetUsageReportResponse result = await subscriptionsController.GetUsageReportAsync(subscriptionId, periodId);
}
catch (ApiException e){};
```


# Update Split Subscription

```csharp
UpdateSplitSubscriptionAsync(
    string id,
    Models.UpdateSubscriptionSplitRequest request)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Subscription's id |
| `request` | [`Models.UpdateSubscriptionSplitRequest`](../../doc/models/update-subscription-split-request.md) | Body, Required | - |

## Response Type

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string id = "id0";
var request = new UpdateSubscriptionSplitRequest();
request.Enabled = false;
request.Rules = new List<CreateSplitRequest>();

var requestRules0 = new CreateSplitRequest();
requestRules0.Type = "type6";
requestRules0.Amount = 222;
requestRules0.RecipientId = "recipient_id6";
request.Rules.Add(requestRules0);

var requestRules1 = new CreateSplitRequest();
requestRules1.Type = "type5";
requestRules1.Amount = 223;
requestRules1.RecipientId = "recipient_id5";
request.Rules.Add(requestRules1);

var requestRules2 = new CreateSplitRequest();
requestRules2.Type = "type4";
requestRules2.Amount = 224;
requestRules2.RecipientId = "recipient_id4";
request.Rules.Add(requestRules2);


try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSplitSubscriptionAsync(id, request);
}
catch (ApiException e){};
```

