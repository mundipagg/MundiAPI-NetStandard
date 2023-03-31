# Getting started

Mundipagg API

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (MundiAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the MundiAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Tests)

### 3. Add reference of the library project

In order to use the MundiAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` MundiAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```MundiAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

MundiAPIClient client = new MundiAPIClient(basicAuthUserName, basicAuthPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SubscriptionsController](#subscriptions_controller)
* [OrdersController](#orders_controller)
* [PlansController](#plans_controller)
* [InvoicesController](#invoices_controller)
* [CustomersController](#customers_controller)
* [ChargesController](#charges_controller)
* [RecipientsController](#recipients_controller)
* [TransfersController](#transfers_controller)
* [TokensController](#tokens_controller)
* [TransactionsController](#transactions_controller)

## <a name="subscriptions_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.SubscriptionsController") SubscriptionsController

### Get singleton instance

The singleton instance of the ``` SubscriptionsController ``` class can be accessed from the API Client.

```csharp
SubscriptionsController subscriptions = client.Subscriptions;
```

### <a name="get_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetSubscriptionItem") GetSubscriptionItem

> Get Subscription Item


```csharp
Task<Standard.Models.GetSubscriptionItemResponse> GetSubscriptionItem(string subscriptionId, string itemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";

Standard.Models.GetSubscriptionItemResponse result = await subscriptions.GetSubscriptionItem(subscriptionId, itemId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionItem") UpdateSubscriptionItem

> Updates a subscription item


```csharp
Task<Standard.Models.GetSubscriptionItemResponse> UpdateSubscriptionItem(
        string subscriptionId,
        string itemId,
        Standard.Models.SubscriptionsItemsRequest body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |
| body |  ``` Required ```  | Request for updating a subscription item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
var body = new Standard.Models.SubscriptionsItemsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionItemResponse result = await subscriptions.UpdateSubscriptionItem(subscriptionId, itemId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_increment_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetIncrementById") GetIncrementById

> GetIncrementById


```csharp
Task<Standard.Models.SubscriptionsIncrementsResponse> GetIncrementById(string subscriptionId, string incrementId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription Id |
| incrementId |  ``` Required ```  | The increment Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string incrementId = "increment_id";

Standard.Models.SubscriptionsIncrementsResponse result = await subscriptions.GetIncrementById(subscriptionId, incrementId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription_cycle_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetSubscriptionCycleById") GetSubscriptionCycleById

> GetSubscriptionCycleById


```csharp
Task<Standard.Models.SubscriptionsCyclesResponse> GetSubscriptionCycleById(string subscriptionId, string cycleId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| cycleId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string cycleId = "cycleId";

Standard.Models.SubscriptionsCyclesResponse result = await subscriptions.GetSubscriptionCycleById(subscriptionId, cycleId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_current_cycle_status"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateCurrentCycleStatus") UpdateCurrentCycleStatus

> UpdateCurrentCycleStatus


```csharp
Task UpdateCurrentCycleStatus(string subscriptionId, Standard.Models.UpdateCurrentCycleStatusRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| body |  ``` Required ```  | Request for updating the end date of the subscription current status |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.UpdateCurrentCycleStatusRequest();
string idempotencyKey = "idempotency-key";

await subscriptions.UpdateCurrentCycleStatus(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_usages"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetUsages") GetUsages

> Lists all usages from a subscription item


```csharp
Task<Standard.Models.SubscriptionsItemsUsagesResponse1> GetUsages(
        string subscriptionId,
        string itemId,
        int? page = null,
        int? size = null,
        string code = null,
        string mgroup = null,
        DateTime? usedSince = null,
        DateTime? usedUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| itemId |  ``` Required ```  | The subscription item id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Identification code in the client system |
| mgroup |  ``` Optional ```  | Identification group in the client system |
| usedSince |  ``` Optional ```  | TODO: Add a parameter description |
| usedUntil |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
int? page = 33;
int? size = 33;
string code = "code";
string mgroup = "group";
DateTime? usedSince = DateTime.Now();
DateTime? usedUntil = DateTime.Now();

Standard.Models.SubscriptionsItemsUsagesResponse1 result = await subscriptions.GetUsages(subscriptionId, itemId, page, size, code, mgroup, usedSince, usedUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_affiliation_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionAffiliationId") UpdateSubscriptionAffiliationId

> UpdateSubscriptionAffiliationId


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionAffiliationId(string subscriptionId, Standard.Models.SubscriptionsGatewayAffiliationIdRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | Request for updating a subscription affiliation id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsGatewayAffiliationIdRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionAffiliationId(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_discount"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.CreateDiscount") CreateDiscount

> Creates a discount


```csharp
Task<Standard.Models.SubscriptionsDiscountsResponse> CreateDiscount(string subscriptionId, Standard.Models.SubscriptionsDiscountsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for creating a discount |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsDiscountsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.SubscriptionsDiscountsResponse result = await subscriptions.CreateDiscount(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_usage"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.DeleteUsage") DeleteUsage

> Deletes a usage


```csharp
Task<Standard.Models.SubscriptionsItemsUsagesUsageIdResponse> DeleteUsage(
        string subscriptionId,
        string itemId,
        string usageId,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| itemId |  ``` Required ```  | The subscription item id |
| usageId |  ``` Required ```  | The usage id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
string usageId = "usage_id";
string idempotencyKey = "idempotency-key";

Standard.Models.SubscriptionsItemsUsagesUsageIdResponse result = await subscriptions.DeleteUsage(subscriptionId, itemId, usageId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_start_at"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionStartAt") UpdateSubscriptionStartAt

> Updates the start at date from a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionStartAt(string subscriptionId, Standard.Models.SubscriptionsStartAtRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| body |  ``` Required ```  | Request for updating the subscription start date |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsStartAtRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionStartAt(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionPaymentMethod") UpdateSubscriptionPaymentMethod

> Updates the payment method from a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, Standard.Models.SubscriptionsPaymentMethodRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for updating the paymentmethod from a subscription |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsPaymentMethodRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionPaymentMethod(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription_cycles"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetSubscriptionCycles") GetSubscriptionCycles

> GetSubscriptionCycles


```csharp
Task<Standard.Models.SubscriptionsCyclesResponse2> GetSubscriptionCycles(string subscriptionId, string page, string size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| page |  ``` Required ```  | Page number |
| size |  ``` Required ```  | Page size |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string page = "page";
string size = "size";

Standard.Models.SubscriptionsCyclesResponse2 result = await subscriptions.GetSubscriptionCycles(subscriptionId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_discount"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.DeleteDiscount") DeleteDiscount

> Deletes a discount


```csharp
Task<Standard.Models.SubscriptionsDiscountsResponse> DeleteDiscount(string subscriptionId, string discountId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| discountId |  ``` Required ```  | Discount Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string discountId = "discount_id";
string idempotencyKey = "idempotency-key";

Standard.Models.SubscriptionsDiscountsResponse result = await subscriptions.DeleteDiscount(subscriptionId, discountId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_increment"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.DeleteIncrement") DeleteIncrement

> Deletes a increment


```csharp
Task<Standard.Models.SubscriptionsIncrementsResponse> DeleteIncrement(string subscriptionId, string incrementId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| incrementId |  ``` Required ```  | Increment id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string incrementId = "increment_id";
string idempotencyKey = "idempotency-key";

Standard.Models.SubscriptionsIncrementsResponse result = await subscriptions.DeleteIncrement(subscriptionId, incrementId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscriptions"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetSubscriptions") GetSubscriptions

> Gets all subscriptions


```csharp
Task<Standard.Models.SubscriptionsResponse3> GetSubscriptions(
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

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for subscription's code |
| billingType |  ``` Optional ```  | Filter for subscription's billing type |
| customerId |  ``` Optional ```  | Filter for subscription's customer id |
| planId |  ``` Optional ```  | Filter for subscription's plan id |
| cardId |  ``` Optional ```  | Filter for subscription's card id |
| status |  ``` Optional ```  | Filter for subscription's status |
| nextBillingSince |  ``` Optional ```  | Filter for subscription's next billing date start range |
| nextBillingUntil |  ``` Optional ```  | Filter for subscription's next billing date end range |
| createdSince |  ``` Optional ```  | Filter for subscription's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for subscriptions creation date end range |


#### Example Usage

```csharp
int? page = 125;
int? size = 125;
string code = "code";
string billingType = "billing_type";
string customerId = "customer_id";
string planId = "plan_id";
string cardId = "card_id";
string status = "status";
DateTime? nextBillingSince = DateTime.Now();
DateTime? nextBillingUntil = DateTime.Now();
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Standard.Models.SubscriptionsResponse3 result = await subscriptions.GetSubscriptions(page, size, code, billingType, customerId, planId, cardId, status, nextBillingSince, nextBillingUntil, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_usages_details"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetUsagesDetails") GetUsagesDetails

> GetUsagesDetails


```csharp
Task<Standard.Models.GetUsagesDetailsResponse> GetUsagesDetails(
        string subscriptionId,
        string cycleId = null,
        int? size = null,
        int? page = null,
        string itemId = null,
        string mgroup = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Identifier |
| cycleId |  ``` Optional ```  | Cycle id |
| size |  ``` Optional ```  | Page size |
| page |  ``` Optional ```  | Page number |
| itemId |  ``` Optional ```  | Identificador do item |
| mgroup |  ``` Optional ```  | identificador da loja (account) de cada item |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string cycleId = "cycle_id";
int? size = 125;
int? page = 125;
string itemId = "item_id";
string mgroup = "group";

Standard.Models.GetUsagesDetailsResponse result = await subscriptions.GetUsagesDetails(subscriptionId, cycleId, size, page, itemId, mgroup);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="renew_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.RenewSubscription") RenewSubscription

> RenewSubscription


```csharp
Task<Standard.Models.SubscriptionsCyclesResponse> RenewSubscription(string subscriptionId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string idempotencyKey = "idempotency-key";

Standard.Models.SubscriptionsCyclesResponse result = await subscriptions.RenewSubscription(subscriptionId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_increments"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetIncrements") GetIncrements

> GetIncrements


```csharp
Task<Standard.Models.ListIncrementsResponse> GetIncrements(string subscriptionId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
int? page = 125;
int? size = 125;

Standard.Models.ListIncrementsResponse result = await subscriptions.GetIncrements(subscriptionId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_latest_period_end_at"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateLatestPeriodEndAt") UpdateLatestPeriodEndAt

> UpdateLatestPeriodEndAt


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateLatestPeriodEndAt(string subscriptionId, Standard.Models.SubscriptionsPeriodsLatestEndAtRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | Request for updating the end date of the current signature cycle |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsPeriodsLatestEndAtRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateLatestPeriodEndAt(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="cancel_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.CancelSubscription") CancelSubscription

> Cancels a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> CancelSubscription(string subscriptionId, string idempotencyKey = null, Standard.Models.SubscriptionsRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for cancelling a subscription |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string idempotencyKey = "idempotency-key";
var body = new Standard.Models.SubscriptionsRequest();

Standard.Models.GetSubscriptionResponse result = await subscriptions.CancelSubscription(subscriptionId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetSubscription") GetSubscription

> Gets a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> GetSubscription(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

Standard.Models.GetSubscriptionResponse result = await subscriptions.GetSubscription(subscriptionId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.CreateSubscription") CreateSubscription

> Creates a new subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> CreateSubscription(Standard.Models.SubscriptionsRequest1 body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a subscription |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Standard.Models.SubscriptionsRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.CreateSubscription(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_an_usage"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.CreateAnUsage") CreateAnUsage

> Create Usage


```csharp
Task<Standard.Models.SubscriptionsItemsUsagesResponse> CreateAnUsage(string subscriptionId, string itemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| itemId |  ``` Required ```  | Item id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
string idempotencyKey = "idempotency-key";

Standard.Models.SubscriptionsItemsUsagesResponse result = await subscriptions.CreateAnUsage(subscriptionId, itemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.CreateSubscriptionItem") CreateSubscriptionItem

> Creates a new Subscription item


```csharp
Task<Standard.Models.GetSubscriptionItemResponse> CreateSubscriptionItem(string subscriptionId, Standard.Models.SubscriptionsItemsRequest1 body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for creating a subscription item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsItemsRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionItemResponse result = await subscriptions.CreateSubscriptionItem(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription_items"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetSubscriptionItems") GetSubscriptionItems

> Get Subscription Items


```csharp
Task<Standard.Models.SubscriptionsItemsResponse3> GetSubscriptionItems(
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

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| name |  ``` Optional ```  | The item name |
| code |  ``` Optional ```  | Identification code in the client system |
| status |  ``` Optional ```  | The item statis |
| description |  ``` Optional ```  | The item description |
| createdSince |  ``` Optional ```  | Filter for item's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for item's creation date end range |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
int? page = 125;
int? size = 125;
string name = "name";
string code = "code";
string status = "status";
string description = "description";
string createdSince = "created_since";
string createdUntil = "created_until";

Standard.Models.SubscriptionsItemsResponse3 result = await subscriptions.GetSubscriptionItems(subscriptionId, page, size, name, code, status, description, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_billing_date"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionBillingDate") UpdateSubscriptionBillingDate

> Updates the billing date from a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionBillingDate(string subscriptionId, Standard.Models.SubscriptionsBillingDateRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| body |  ``` Required ```  | Request for updating the subscription billing date |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsBillingDateRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionBillingDate(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.DeleteSubscriptionItem") DeleteSubscriptionItem

> Deletes a subscription item


```csharp
Task<Standard.Models.GetSubscriptionItemResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| subscriptionItemId |  ``` Required ```  | Subscription item id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string subscriptionItemId = "subscription_item_id";
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionItemResponse result = await subscriptions.DeleteSubscriptionItem(subscriptionId, subscriptionItemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionCard") UpdateSubscriptionCard

> Updates the credit card from a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionCard(string subscriptionId, Standard.Models.SubscriptionsCardRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for updating a card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsCardRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionCard(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_discounts"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetDiscounts") GetDiscounts

> GetDiscounts


```csharp
Task<Standard.Models.ListDiscountsResponse> GetDiscounts(string subscriptionId, int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| page |  ``` Required ```  | Page number |
| size |  ``` Required ```  | Page size |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
int page = 125;
int size = 125;

Standard.Models.ListDiscountsResponse result = await subscriptions.GetDiscounts(subscriptionId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionMetadata") UpdateSubscriptionMetadata

> Updates the metadata from a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionMetadata(string subscriptionId, Standard.Models.SubscriptionsMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| body |  ``` Required ```  | Request for updating the subscrption metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsMetadataRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionMetadata(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_discount_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetDiscountById") GetDiscountById

> GetDiscountById


```csharp
Task<Standard.Models.SubscriptionsDiscountsResponse> GetDiscountById(string subscriptionId, string discountId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| discountId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string discountId = "discountId";

Standard.Models.SubscriptionsDiscountsResponse result = await subscriptions.GetDiscountById(subscriptionId, discountId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_increment"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.CreateIncrement") CreateIncrement

> Creates a increment


```csharp
Task<Standard.Models.SubscriptionsIncrementsResponse> CreateIncrement(string subscriptionId, Standard.Models.SubscriptionsIncrementsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for creating a increment |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsIncrementsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.SubscriptionsIncrementsResponse result = await subscriptions.CreateIncrement(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_minium_price"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionMiniumPrice") UpdateSubscriptionMiniumPrice

> Atualização do valor mínimo da assinatura


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, Standard.Models.SubscriptionsMinimumPriceRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| body |  ``` Required ```  | Request da requisição com o valor mínimo que será configurado |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.SubscriptionsMinimumPriceRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionMiniumPrice(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_due_days"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSubscriptionDueDays") UpdateSubscriptionDueDays

> Updates the boleto due days from a subscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSubscriptionDueDays(string subscriptionId, Standard.Models.UpdateSubscriptionDueDaysRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| body |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Standard.Models.UpdateSubscriptionDueDaysRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionDueDays(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_usage_report"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.GetUsageReport") GetUsageReport

> GetUsageReport


```csharp
Task<Standard.Models.GetUsageReportResponse> GetUsageReport(string subscriptionId, string periodId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription Id |
| periodId |  ``` Required ```  | The period Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string periodId = "period_id";

Standard.Models.GetUsageReportResponse result = await subscriptions.GetUsageReport(subscriptionId, periodId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_split_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.SubscriptionsController.UpdateSplitSubscription") UpdateSplitSubscription

> UpdateSplitSubscription


```csharp
Task<Standard.Models.GetSubscriptionResponse> UpdateSplitSubscription(string id, Standard.Models.UpdateSubscriptionSplitRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Subscription's id |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
var body = new Standard.Models.UpdateSubscriptionSplitRequest();

Standard.Models.GetSubscriptionResponse result = await subscriptions.UpdateSplitSubscription(id, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="orders_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.OrdersController") OrdersController

### Get singleton instance

The singleton instance of the ``` OrdersController ``` class can be accessed from the API Client.

```csharp
OrdersController orders = client.Orders;
```

### <a name="create_order"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.CreateOrder") CreateOrder

> Creates a new Order


```csharp
Task<Standard.Models.OrdersResponse1> CreateOrder(Standard.Models.OrdersRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating an order |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Standard.Models.OrdersRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.OrdersResponse1 result = await orders.CreateOrder(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_order"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.GetOrder") GetOrder

> Gets an order


```csharp
Task<Standard.Models.OrdersResponse1> GetOrder(string orderId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order id |


#### Example Usage

```csharp
string orderId = "order_id";

Standard.Models.OrdersResponse1 result = await orders.GetOrder(orderId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.CreateOrderItem") CreateOrderItem

> CreateOrderItem


```csharp
Task<Standard.Models.OrdersItemsResponse1> CreateOrderItem(string orderId, Standard.Models.OrdersItemsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| body |  ``` Required ```  | Order Item Model |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
var body = new Standard.Models.OrdersItemsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.OrdersItemsResponse1 result = await orders.CreateOrderItem(orderId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.UpdateOrderItem") UpdateOrderItem

> UpdateOrderItem


```csharp
Task<Standard.Models.OrdersItemsResponse1> UpdateOrderItem(
        string orderId,
        string itemId,
        Standard.Models.OrdersItemsRequest1 body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| itemId |  ``` Required ```  | Item Id |
| body |  ``` Required ```  | Item Model |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
string itemId = "itemId";
var body = new Standard.Models.OrdersItemsRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.OrdersItemsResponse1 result = await orders.UpdateOrderItem(orderId, itemId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_all_order_items"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.DeleteAllOrderItems") DeleteAllOrderItems

> DeleteAllOrderItems


```csharp
Task<Standard.Models.OrdersItemsResponse> DeleteAllOrderItems(string orderId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
string idempotencyKey = "idempotency-key";

Standard.Models.OrdersItemsResponse result = await orders.DeleteAllOrderItems(orderId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_order_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.UpdateOrderMetadata") UpdateOrderMetadata

> Updates the metadata from an order


```csharp
Task<Standard.Models.OrdersMetadataResponse> UpdateOrderMetadata(string orderId, Standard.Models.OrdersMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | The order id |
| body |  ``` Required ```  | Request for updating the order metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "order_id";
var body = new Standard.Models.OrdersMetadataRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.OrdersMetadataResponse result = await orders.UpdateOrderMetadata(orderId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_order_status"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.UpdateOrderStatus") UpdateOrderStatus

> UpdateOrderStatus


```csharp
Task<Standard.Models.OrdersClosedResponse> UpdateOrderStatus(string id, Standard.Models.UpdateOrderStatusRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Order Id |
| body |  ``` Required ```  | Update Order Model |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
var body = new Standard.Models.UpdateOrderStatusRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.OrdersClosedResponse result = await orders.UpdateOrderStatus(id, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_orders"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.GetOrders") GetOrders

> Gets all orders


```csharp
Task<Standard.Models.OrdersResponse> GetOrders(
        int? page = null,
        int? size = null,
        string code = null,
        string status = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null,
        string customerId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for order's code |
| status |  ``` Optional ```  | Filter for order's status |
| createdSince |  ``` Optional ```  | Filter for order's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for order's creation date end range |
| customerId |  ``` Optional ```  | Filter for order's customer id |


#### Example Usage

```csharp
int? page = 125;
int? size = 125;
string code = "code";
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();
string customerId = "customer_id";

Standard.Models.OrdersResponse result = await orders.GetOrders(page, size, code, status, createdSince, createdUntil, customerId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.DeleteOrderItem") DeleteOrderItem

> DeleteOrderItem


```csharp
Task<Standard.Models.OrdersItemsResponse1> DeleteOrderItem(string orderId, string itemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| itemId |  ``` Required ```  | Item Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
string itemId = "itemId";
string idempotencyKey = "idempotency-key";

Standard.Models.OrdersItemsResponse1 result = await orders.DeleteOrderItem(orderId, itemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.OrdersController.GetOrderItem") GetOrderItem

> GetOrderItem


```csharp
Task<Standard.Models.OrdersItemsResponse1> GetOrderItem(string orderId, string itemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| itemId |  ``` Required ```  | Item Id |


#### Example Usage

```csharp
string orderId = "orderId";
string itemId = "itemId";

Standard.Models.OrdersItemsResponse1 result = await orders.GetOrderItem(orderId, itemId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="plans_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.PlansController") PlansController

### Get singleton instance

The singleton instance of the ``` PlansController ``` class can be accessed from the API Client.

```csharp
PlansController plans = client.Plans;
```

### <a name="create_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.CreatePlanItem") CreatePlanItem

> Adds a new item to a plan


```csharp
Task<Standard.Models.PlansItemsResponse> CreatePlanItem(string planId, Standard.Models.PlansItemsRequest1 body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| body |  ``` Required ```  | Request for creating a plan item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
var body = new Standard.Models.PlansItemsRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.PlansItemsResponse result = await plans.CreatePlanItem(planId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_plans"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.GetPlans") GetPlans

> Gets all plans


```csharp
Task<Standard.Models.PlansResponse> GetPlans(
        int? page = null,
        int? size = null,
        string name = null,
        string status = null,
        string billingType = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| name |  ``` Optional ```  | Filter for Plan's name |
| status |  ``` Optional ```  | Filter for Plan's status |
| billingType |  ``` Optional ```  | Filter for plan's billing type |
| createdSince |  ``` Optional ```  | Filter for plan's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for plan's creation date end range |


#### Example Usage

```csharp
int? page = 125;
int? size = 125;
string name = "name";
string status = "status";
string billingType = "billing_type";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Standard.Models.PlansResponse result = await plans.GetPlans(page, size, name, status, billingType, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.GetPlan") GetPlan

> Gets a plan


```csharp
Task<Standard.Models.PlansResponse1> GetPlan(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

Standard.Models.PlansResponse1 result = await plans.GetPlan(planId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.DeletePlanItem") DeletePlanItem

> Removes an item from a plan


```csharp
Task<Standard.Models.PlansItemsResponse> DeletePlanItem(string planId, string planItemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";
string idempotencyKey = "idempotency-key";

Standard.Models.PlansItemsResponse result = await plans.DeletePlanItem(planId, planItemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.CreatePlan") CreatePlan

> Creates a new plan


```csharp
Task<Standard.Models.PlansResponse1> CreatePlan(Standard.Models.PlansRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a plan |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Standard.Models.PlansRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.PlansResponse1 result = await plans.CreatePlan(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.UpdatePlan") UpdatePlan

> Updates a plan


```csharp
Task<Standard.Models.PlansResponse1> UpdatePlan(string planId, Standard.Models.PlansRequest1 body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| body |  ``` Required ```  | Request for updating a plan |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
var body = new Standard.Models.PlansRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.PlansResponse1 result = await plans.UpdatePlan(planId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.DeletePlan") DeletePlan

> Deletes a plan


```csharp
Task<Standard.Models.PlansResponse1> DeletePlan(string planId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
string idempotencyKey = "idempotency-key";

Standard.Models.PlansResponse1 result = await plans.DeletePlan(planId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.UpdatePlanItem") UpdatePlanItem

> Updates a plan item


```csharp
Task<Standard.Models.PlansItemsResponse> UpdatePlanItem(
        string planId,
        string planItemId,
        Standard.Models.PlansItemsRequest body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |
| body |  ``` Required ```  | Request for updating the plan item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";
var body = new Standard.Models.PlansItemsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.PlansItemsResponse result = await plans.UpdatePlanItem(planId, planItemId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.GetPlanItem") GetPlanItem

> Gets a plan item


```csharp
Task<Standard.Models.PlansItemsResponse> GetPlanItem(string planId, string planItemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";

Standard.Models.PlansItemsResponse result = await plans.GetPlanItem(planId, planItemId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_plan_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.PlansController.UpdatePlanMetadata") UpdatePlanMetadata

> Updates the metadata from a plan


```csharp
Task<Standard.Models.PlansMetadataResponse> UpdatePlanMetadata(string planId, Standard.Models.PlansMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | The plan id |
| body |  ``` Required ```  | Request for updating the plan metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
var body = new Standard.Models.PlansMetadataRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.PlansMetadataResponse result = await plans.UpdatePlanMetadata(planId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="invoices_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.InvoicesController") InvoicesController

### Get singleton instance

The singleton instance of the ``` InvoicesController ``` class can be accessed from the API Client.

```csharp
InvoicesController invoices = client.Invoices;
```

### <a name="create_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.InvoicesController.CreateInvoice") CreateInvoice

> Create an Invoice


```csharp
Task<Standard.Models.SubscriptionsCyclesPayResponse> CreateInvoice(
        string subscriptionId,
        string cycleId,
        string idempotencyKey = null,
        Standard.Models.SubscriptionsCyclesPayRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| cycleId |  ``` Required ```  | Cycle Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string cycleId = "cycle_id";
string idempotencyKey = "idempotency-key";
var body = new Standard.Models.SubscriptionsCyclesPayRequest();

Standard.Models.SubscriptionsCyclesPayResponse result = await invoices.CreateInvoice(subscriptionId, cycleId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_partial_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.InvoicesController.GetPartialInvoice") GetPartialInvoice

> GetPartialInvoice


```csharp
Task<Standard.Models.SubscriptionsPartialInvoiceResponse> GetPartialInvoice(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

Standard.Models.SubscriptionsPartialInvoiceResponse result = await invoices.GetPartialInvoice(subscriptionId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="cancel_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.InvoicesController.CancelInvoice") CancelInvoice

> Cancels an invoice


```csharp
Task<Standard.Models.InvoicesResponse> CancelInvoice(string invoiceId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
string idempotencyKey = "idempotency-key";

Standard.Models.InvoicesResponse result = await invoices.CancelInvoice(invoiceId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_invoice_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.InvoicesController.UpdateInvoiceMetadata") UpdateInvoiceMetadata

> Updates the metadata from an invoice


```csharp
Task<Standard.Models.InvoicesMetadataResponse> UpdateInvoiceMetadata(string invoiceId, Standard.Models.InvoicesMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | The invoice id |
| body |  ``` Required ```  | Request for updating the invoice metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
var body = new Standard.Models.InvoicesMetadataRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.InvoicesMetadataResponse result = await invoices.UpdateInvoiceMetadata(invoiceId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_invoice_status"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.InvoicesController.UpdateInvoiceStatus") UpdateInvoiceStatus

> Updates the status from an invoice


```csharp
Task<Standard.Models.InvoicesStatusResponse> UpdateInvoiceStatus(string invoiceId, Standard.Models.UpdateCurrentCycleStatusRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice Id |
| body |  ``` Required ```  | Request for updating an invoice's status |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
var body = new Standard.Models.UpdateCurrentCycleStatusRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.InvoicesStatusResponse result = await invoices.UpdateInvoiceStatus(invoiceId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.InvoicesController.GetInvoice") GetInvoice

> Gets an invoice


```csharp
Task<Standard.Models.InvoicesResponse> GetInvoice(string invoiceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice Id |


#### Example Usage

```csharp
string invoiceId = "invoice_id";

Standard.Models.InvoicesResponse result = await invoices.GetInvoice(invoiceId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_invoices"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.InvoicesController.GetInvoices") GetInvoices

> Gets all invoices


```csharp
Task<Standard.Models.InvoicesResponse2> GetInvoices(
        int? page = null,
        int? size = null,
        string code = null,
        string customerId = null,
        string subscriptionId = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null,
        string status = null,
        DateTime? dueSince = null,
        DateTime? dueUntil = null,
        string customerDocument = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for Invoice's code |
| customerId |  ``` Optional ```  | Filter for Invoice's customer id |
| subscriptionId |  ``` Optional ```  | Filter for Invoice's subscription id |
| createdSince |  ``` Optional ```  | Filter for Invoice's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for Invoices creation date end range |
| status |  ``` Optional ```  | Filter for Invoice's status |
| dueSince |  ``` Optional ```  | Filter for Invoice's due date start range |
| dueUntil |  ``` Optional ```  | Filter for Invoice's due date end range |
| customerDocument |  ``` Optional ```  | Fillter for invoice's document |


#### Example Usage

```csharp
int? page = 83;
int? size = 83;
string code = "code";
string customerId = "customer_id";
string subscriptionId = "subscription_id";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();
string status = "status";
DateTime? dueSince = DateTime.Now();
DateTime? dueUntil = DateTime.Now();
string customerDocument = "customer_document";

Standard.Models.InvoicesResponse2 result = await invoices.GetInvoices(page, size, code, customerId, subscriptionId, createdSince, createdUntil, status, dueSince, dueUntil, customerDocument);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="customers_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.CustomersController") CustomersController

### Get singleton instance

The singleton instance of the ``` CustomersController ``` class can be accessed from the API Client.

```csharp
CustomersController customers = client.Customers;
```

### <a name="get_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetCustomer") GetCustomer

> Get a customer


```csharp
Task<Standard.Models.CustomersResponse> GetCustomer(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

Standard.Models.CustomersResponse result = await customers.GetCustomer(customerId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_access_tokens"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.DeleteAccessTokens") DeleteAccessTokens

> Delete a Customer's access tokens


```csharp
Task<Standard.Models.CustomersAccessTokensResponse1> DeleteAccessTokens(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

Standard.Models.CustomersAccessTokensResponse1 result = await customers.DeleteAccessTokens(customerId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.CreateAddress") CreateAddress

> Creates a new address for a customer


```csharp
Task<Standard.Models.CustomersAddressesResponse1> CreateAddress(string customerId, Standard.Models.CustomersAddressesRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| body |  ``` Required ```  | Request for creating an address |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new Standard.Models.CustomersAddressesRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersAddressesResponse1 result = await customers.CreateAddress(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.UpdateAddress") UpdateAddress

> Updates an address


```csharp
Task<Standard.Models.CustomersAddressesResponse1> UpdateAddress(
        string customerId,
        string addressId,
        Standard.Models.CustomersAddressesRequest1 body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |
| body |  ``` Required ```  | Request for updating an address |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";
var body = new Standard.Models.CustomersAddressesRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersAddressesResponse1 result = await customers.UpdateAddress(customerId, addressId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_cards"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetCards") GetCards

> Get all cards from a customer


```csharp
Task<Standard.Models.CustomersCardsResponse1> GetCards(string customerId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string customerId = "customer_id";
int? page = 83;
int? size = 83;

Standard.Models.CustomersCardsResponse1 result = await customers.GetCards(customerId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.CreateCustomer") CreateCustomer

> Creates a new customer


```csharp
Task<Standard.Models.CustomersResponse> CreateCustomer(Standard.Models.CustomersRequest1 body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a customer |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Standard.Models.CustomersRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersResponse result = await customers.CreateCustomer(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_customer_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.UpdateCustomerMetadata") UpdateCustomerMetadata

> Updates the metadata a customer


```csharp
Task<Standard.Models.CustomersMetadataResponse> UpdateCustomerMetadata(string customerId, Standard.Models.CustomersMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | The customer id |
| body |  ``` Required ```  | Request for updating the customer metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new Standard.Models.CustomersMetadataRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersMetadataResponse result = await customers.UpdateCustomerMetadata(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.DeleteCard") DeleteCard

> Delete a customer's card


```csharp
Task<Standard.Models.CustomersCardsResponse> DeleteCard(string customerId, string cardId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Card Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersCardsResponse result = await customers.DeleteCard(customerId, cardId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetCard") GetCard

> Get a customer's card


```csharp
Task<Standard.Models.CustomersCardsResponse> GetCard(string customerId, string cardId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| cardId |  ``` Required ```  | Card id |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";

Standard.Models.CustomersCardsResponse result = await customers.GetCard(customerId, cardId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_access_tokens"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetAccessTokens") GetAccessTokens

> Get all access tokens from a customer


```csharp
Task<Standard.Models.CustomersAccessTokensResponse1> GetAccessTokens(string customerId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string customerId = "customer_id";
int? page = 83;
int? size = 83;

Standard.Models.CustomersAccessTokensResponse1 result = await customers.GetAccessTokens(customerId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.UpdateCustomer") UpdateCustomer

> Updates a customer


```csharp
Task<Standard.Models.CustomersResponse> UpdateCustomer(string customerId, Standard.Models.CustomersRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| body |  ``` Required ```  | Request for updating a customer |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new Standard.Models.CustomersRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersResponse result = await customers.UpdateCustomer(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="renew_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.RenewCard") RenewCard

> Renew a card


```csharp
Task<Standard.Models.CustomersCardsRenewResponse> RenewCard(string customerId, string cardId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| cardId |  ``` Required ```  | Card Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersCardsRenewResponse result = await customers.RenewCard(customerId, cardId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_customers"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetCustomers") GetCustomers

> Get all Customers


```csharp
Task<Standard.Models.CustomersResponse3> GetCustomers(
        string name = null,
        string document = null,
        int? page = 1,
        int? size = 10,
        string email = null,
        string code = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | Name of the Customer |
| document |  ``` Optional ```  | Document of the Customer |
| page |  ``` Optional ```  ``` DefaultValue ```  | Current page the the search |
| size |  ``` Optional ```  ``` DefaultValue ```  | Quantity pages of the search |
| email |  ``` Optional ```  | Customer's email |
| code |  ``` Optional ```  | Customer's code |


#### Example Usage

```csharp
string name = "name";
string document = "document";
int? page = 1;
int? size = 10;
string email = "email";
string code = "Code";

Standard.Models.CustomersResponse3 result = await customers.GetCustomers(name, document, page, size, email, code);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_access_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.CreateAccessToken") CreateAccessToken

> Creates a access token for a customer


```csharp
Task<Standard.Models.CustomersAccessTokensResponse> CreateAccessToken(string customerId, Standard.Models.CustomersAccessTokensRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| body |  ``` Required ```  | Request for creating a access token |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new Standard.Models.CustomersAccessTokensRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersAccessTokensResponse result = await customers.CreateAccessToken(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_addresses"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetAddresses") GetAddresses

> Gets all adressess from a customer


```csharp
Task<Standard.Models.CustomersAddressesResponse> GetAddresses(string customerId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string customerId = "customer_id";
int? page = 83;
int? size = 83;

Standard.Models.CustomersAddressesResponse result = await customers.GetAddresses(customerId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_access_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetAccessToken") GetAccessToken

> Get a Customer's access token


```csharp
Task<Standard.Models.CustomersAccessTokensResponse> GetAccessToken(string customerId, string tokenId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| tokenId |  ``` Required ```  | Token Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string tokenId = "token_id";

Standard.Models.CustomersAccessTokensResponse result = await customers.GetAccessToken(customerId, tokenId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_access_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.DeleteAccessToken") DeleteAccessToken

> Delete a customer's access token


```csharp
Task<Standard.Models.CustomersAccessTokensResponse> DeleteAccessToken(string customerId, string tokenId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| tokenId |  ``` Required ```  | Token Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string tokenId = "token_id";
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersAccessTokensResponse result = await customers.DeleteAccessToken(customerId, tokenId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.GetAddress") GetAddress

> Get a customer's address


```csharp
Task<Standard.Models.CustomersAddressesResponse1> GetAddress(string customerId, string addressId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| addressId |  ``` Required ```  | Address Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";

Standard.Models.CustomersAddressesResponse1 result = await customers.GetAddress(customerId, addressId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.DeleteAddress") DeleteAddress

> Delete a Customer's address


```csharp
Task<Standard.Models.CustomersAddressesResponse1> DeleteAddress(string customerId, string addressId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersAddressesResponse1 result = await customers.DeleteAddress(customerId, addressId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.CreateCard") CreateCard

> Creates a new card for a customer


```csharp
Task<Standard.Models.CustomersCardsResponse> CreateCard(string customerId, Standard.Models.CustomersCardsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| body |  ``` Required ```  | Request for creating a card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new Standard.Models.CustomersCardsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersCardsResponse result = await customers.CreateCard(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.CustomersController.UpdateCard") UpdateCard

> Updates a card


```csharp
Task<Standard.Models.CustomersCardsResponse> UpdateCard(
        string customerId,
        string cardId,
        Standard.Models.CustomersCardsRequest1 body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Card id |
| body |  ``` Required ```  | Request for updating a card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
var body = new Standard.Models.CustomersCardsRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.CustomersCardsResponse result = await customers.UpdateCard(customerId, cardId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="charges_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.ChargesController") ChargesController

### Get singleton instance

The singleton instance of the ``` ChargesController ``` class can be accessed from the API Client.

```csharp
ChargesController charges = client.Charges;
```

### <a name="confirm_payment"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.ConfirmPayment") ConfirmPayment

> ConfirmPayment


```csharp
Task<Standard.Models.ChargesConfirmPaymentResponse> ConfirmPayment(string chargeId, string idempotencyKey = null, Standard.Models.CreateConfirmPaymentRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for confirm payment |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";
var body = new Standard.Models.CreateConfirmPaymentRequest();

Standard.Models.ChargesConfirmPaymentResponse result = await charges.ConfirmPayment(chargeId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charges"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.GetCharges") GetCharges

> Lists all charges


```csharp
Task<Standard.Models.ChargesResponse2> GetCharges(
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

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for charge's code |
| status |  ``` Optional ```  | Filter for charge's status |
| paymentMethod |  ``` Optional ```  | Filter for charge's payment method |
| customerId |  ``` Optional ```  | Filter for charge's customer id |
| orderId |  ``` Optional ```  | Filter for charge's order id |
| createdSince |  ``` Optional ```  | Filter for the beginning of the range for charge's creation |
| createdUntil |  ``` Optional ```  | Filter for the end of the range for charge's creation |


#### Example Usage

```csharp
int? page = 83;
int? size = 83;
string code = "code";
string status = "status";
string paymentMethod = "payment_method";
string customerId = "customer_id";
string orderId = "order_id";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Standard.Models.ChargesResponse2 result = await charges.GetCharges(page, size, code, status, paymentMethod, customerId, orderId, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_charge_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.UpdateChargeMetadata") UpdateChargeMetadata

> Updates the metadata from a charge


```csharp
Task<Standard.Models.ChargesMetadataResponse> UpdateChargeMetadata(string chargeId, Standard.Models.ChargesMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | The charge id |
| body |  ``` Required ```  | Request for updating the charge metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new Standard.Models.ChargesMetadataRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.ChargesMetadataResponse result = await charges.UpdateChargeMetadata(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_charge_due_date"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.UpdateChargeDueDate") UpdateChargeDueDate

> Updates the due date from a charge


```csharp
Task<Standard.Models.ChargesDueDateResponse> UpdateChargeDueDate(string chargeId, Standard.Models.ChargesDueDateRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge Id |
| body |  ``` Required ```  | Request for updating the due date |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new Standard.Models.ChargesDueDateRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.ChargesDueDateResponse result = await charges.UpdateChargeDueDate(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.CreateCharge") CreateCharge

> Creates a new charge


```csharp
Task<Standard.Models.ChargesResponse> CreateCharge(Standard.Models.ChargesRequest1 body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a charge |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Standard.Models.ChargesRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.ChargesResponse result = await charges.CreateCharge(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="retry_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.RetryCharge") RetryCharge

> Retries a charge


```csharp
Task<Standard.Models.ChargesRetryResponse> RetryCharge(string chargeId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";

Standard.Models.ChargesRetryResponse result = await charges.RetryCharge(chargeId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charge_transactions"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.GetChargeTransactions") GetChargeTransactions

> GetChargeTransactions


```csharp
Task<Standard.Models.ChargesTransactionsResponse> GetChargeTransactions(string chargeId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge Id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string chargeId = "charge_id";
int? page = 83;
int? size = 83;

Standard.Models.ChargesTransactionsResponse result = await charges.GetChargeTransactions(chargeId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charges_summary"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.GetChargesSummary") GetChargesSummary

> GetChargesSummary


```csharp
Task<Standard.Models.GetChargesSummaryResponse> GetChargesSummary(string status, DateTime? createdSince = null, DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| status |  ``` Required ```  | TODO: Add a parameter description |
| createdSince |  ``` Optional ```  | TODO: Add a parameter description |
| createdUntil |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Standard.Models.GetChargesSummaryResponse result = await charges.GetChargesSummary(status, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="capture_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.CaptureCharge") CaptureCharge

> Captures a charge


```csharp
Task<Standard.Models.ChargesCaptureResponse> CaptureCharge(string chargeId, string idempotencyKey = null, Standard.Models.ChargesCaptureRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for capturing a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";
var body = new Standard.Models.ChargesCaptureRequest();

Standard.Models.ChargesCaptureResponse result = await charges.CaptureCharge(chargeId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.GetCharge") GetCharge

> Get a charge from its id


```csharp
Task<Standard.Models.ChargesResponse> GetCharge(string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
string chargeId = "charge_id";

Standard.Models.ChargesResponse result = await charges.GetCharge(chargeId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="cancel_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.CancelCharge") CancelCharge

> Cancel a charge


```csharp
Task<Standard.Models.ChargesResponse> CancelCharge(string chargeId, string idempotencyKey = null, Standard.Models.ChargesRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for cancelling a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";
var body = new Standard.Models.ChargesRequest();

Standard.Models.ChargesResponse result = await charges.CancelCharge(chargeId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_charge_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.UpdateChargeCard") UpdateChargeCard

> Updates the card from a charge


```csharp
Task<Standard.Models.ChargesCardResponse> UpdateChargeCard(string chargeId, Standard.Models.ChargesCardRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| body |  ``` Required ```  | Request for updating a charge's card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new Standard.Models.ChargesCardRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.ChargesCardResponse result = await charges.UpdateChargeCard(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_charge_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.ChargesController.UpdateChargePaymentMethod") UpdateChargePaymentMethod

> Updates a charge's payment method


```csharp
Task<Standard.Models.ChargesPaymentMethodResponse> UpdateChargePaymentMethod(string chargeId, Standard.Models.ChargesPaymentMethodRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| body |  ``` Required ```  | Request for updating the payment method from a charge |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new Standard.Models.ChargesPaymentMethodRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.ChargesPaymentMethodResponse result = await charges.UpdateChargePaymentMethod(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="recipients_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.RecipientsController") RecipientsController

### Get singleton instance

The singleton instance of the ``` RecipientsController ``` class can be accessed from the API Client.

```csharp
RecipientsController recipients = client.Recipients;
```

### <a name="update_recipient_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.UpdateRecipientMetadata") UpdateRecipientMetadata

> Updates recipient metadata


```csharp
Task<Standard.Models.RecipientsMetadataResponse> UpdateRecipientMetadata(string recipientId, Standard.Models.RecipientsMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.RecipientsMetadataRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsMetadataResponse result = await recipients.UpdateRecipientMetadata(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_recipient_transfer_settings"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.UpdateRecipientTransferSettings") UpdateRecipientTransferSettings

> UpdateRecipientTransferSettings


```csharp
Task<Standard.Models.RecipientsTransferSettingsResponse> UpdateRecipientTransferSettings(string recipientId, Standard.Models.UpdateTransferSettingsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient Identificator |
| body |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.UpdateTransferSettingsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsTransferSettingsResponse result = await recipients.UpdateRecipientTransferSettings(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_recipient"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.CreateRecipient") CreateRecipient

> Creates a new recipient


```csharp
Task<Standard.Models.RecipientsResponse1> CreateRecipient(Standard.Models.RecipientsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Recipient data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Standard.Models.RecipientsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsResponse1 result = await recipients.CreateRecipient(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_withdrawals"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetWithdrawals") GetWithdrawals

> Gets a paginated list of transfers for the recipient


```csharp
Task<Standard.Models.ListWithdrawals> GetWithdrawals(
        string recipientId,
        int? page = null,
        int? size = null,
        string status = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | TODO: Add a parameter description |
| size |  ``` Optional ```  | TODO: Add a parameter description |
| status |  ``` Optional ```  | TODO: Add a parameter description |
| createdSince |  ``` Optional ```  | TODO: Add a parameter description |
| createdUntil |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
int? page = 83;
int? size = 83;
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Standard.Models.ListWithdrawals result = await recipients.GetWithdrawals(recipientId, page, size, status, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_automatic_anticipation_settings"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.UpdateAutomaticAnticipationSettings") UpdateAutomaticAnticipationSettings

> Updates recipient metadata


```csharp
Task<Standard.Models.RecipientsAutomaticAnticipationSettingsResponse> UpdateAutomaticAnticipationSettings(string recipientId, Standard.Models.UpdateAutomaticAnticipationSettingsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.UpdateAutomaticAnticipationSettingsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsAutomaticAnticipationSettingsResponse result = await recipients.UpdateAutomaticAnticipationSettings(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_recipient_by_code"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetRecipientByCode") GetRecipientByCode

> Retrieves recipient information


```csharp
Task<Standard.Models.RecipientsCodeResponse> GetRecipientByCode(string code)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| code |  ``` Required ```  | Recipient code |


#### Example Usage

```csharp
string code = "code";

Standard.Models.RecipientsCodeResponse result = await recipients.GetRecipientByCode(code);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_anticipation"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetAnticipation") GetAnticipation

> Gets an anticipation


```csharp
Task<Standard.Models.RecipientsAnticipationsResponse> GetAnticipation(string recipientId, string anticipationId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| anticipationId |  ``` Required ```  | Anticipation id |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string anticipationId = "anticipation_id";

Standard.Models.RecipientsAnticipationsResponse result = await recipients.GetAnticipation(recipientId, anticipationId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_recipient"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetRecipient") GetRecipient

> Retrieves recipient information


```csharp
Task<Standard.Models.RecipientsResponse1> GetRecipient(string recipientId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipiend id |


#### Example Usage

```csharp
string recipientId = "recipient_id";

Standard.Models.RecipientsResponse1 result = await recipients.GetRecipient(recipientId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_recipient"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.UpdateRecipient") UpdateRecipient

> Updates a recipient


```csharp
Task<Standard.Models.RecipientsResponse1> UpdateRecipient(string recipientId, Standard.Models.RecipientsRequest1 body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Recipient data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.RecipientsRequest1();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsResponse1 result = await recipients.UpdateRecipient(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_transfer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetTransfer") GetTransfer

> Gets a transfer


```csharp
Task<Standard.Models.RecipientsTransfersResponse> GetTransfer(string recipientId, string transferId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| transferId |  ``` Required ```  | Transfer id |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string transferId = "transfer_id";

Standard.Models.RecipientsTransfersResponse result = await recipients.GetTransfer(recipientId, transferId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_anticipation_limits"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetAnticipationLimits") GetAnticipationLimits

> Gets the anticipation limits for a recipient


```csharp
Task<Standard.Models.RecipientsAnticipationLimitsResponse> GetAnticipationLimits(string recipientId, string timeframe, DateTime paymentDate)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| timeframe |  ``` Required ```  | Timeframe |
| paymentDate |  ``` Required ```  | Anticipation payment date |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string timeframe = "timeframe";
DateTime paymentDate = DateTime.Now();

Standard.Models.RecipientsAnticipationLimitsResponse result = await recipients.GetAnticipationLimits(recipientId, timeframe, paymentDate);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_balance"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetBalance") GetBalance

> Get balance information for a recipient


```csharp
Task<Standard.Models.RecipientsBalanceResponse> GetBalance(string recipientId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |


#### Example Usage

```csharp
string recipientId = "recipient_id";

Standard.Models.RecipientsBalanceResponse result = await recipients.GetBalance(recipientId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_anticipation"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.CreateAnticipation") CreateAnticipation

> Creates an anticipation


```csharp
Task<Standard.Models.RecipientsAnticipationsResponse> CreateAnticipation(string recipientId, Standard.Models.RecipientsAnticipationsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Anticipation data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.RecipientsAnticipationsRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsAnticipationsResponse result = await recipients.CreateAnticipation(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_transfers"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetTransfers") GetTransfers

> Gets a paginated list of transfers for the recipient


```csharp
Task<Standard.Models.RecipientsTransfersResponse1> GetTransfers(
        string recipientId,
        int? page = null,
        int? size = null,
        string status = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| status |  ``` Optional ```  | Filter for transfer status |
| createdSince |  ``` Optional ```  | Filter for start range of transfer creation date |
| createdUntil |  ``` Optional ```  | Filter for end range of transfer creation date |


#### Example Usage

```csharp
string recipientId = "recipient_id";
int? page = 83;
int? size = 83;
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Standard.Models.RecipientsTransfersResponse1 result = await recipients.GetTransfers(recipientId, page, size, status, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_recipients"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetRecipients") GetRecipients

> Retrieves paginated recipients information


```csharp
Task<Standard.Models.RecipientsResponse> GetRecipients(int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
int? page = 83;
int? size = 83;

Standard.Models.RecipientsResponse result = await recipients.GetRecipients(page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_anticipations"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetAnticipations") GetAnticipations

> Retrieves a paginated list of anticipations from a recipient


```csharp
Task<Standard.Models.RecipientsAnticipationsResponse1> GetAnticipations(
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

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| status |  ``` Optional ```  | Filter for anticipation status |
| timeframe |  ``` Optional ```  | Filter for anticipation timeframe |
| paymentDateSince |  ``` Optional ```  | Filter for start range for anticipation payment date |
| paymentDateUntil |  ``` Optional ```  | Filter for end range for anticipation payment date |
| createdSince |  ``` Optional ```  | Filter for start range for anticipation creation date |
| createdUntil |  ``` Optional ```  | Filter for end range for anticipation creation date |


#### Example Usage

```csharp
string recipientId = "recipient_id";
int? page = 83;
int? size = 83;
string status = "status";
string timeframe = "timeframe";
DateTime? paymentDateSince = DateTime.Now();
DateTime? paymentDateUntil = DateTime.Now();
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Standard.Models.RecipientsAnticipationsResponse1 result = await recipients.GetAnticipations(recipientId, page, size, status, timeframe, paymentDateSince, paymentDateUntil, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_recipient_default_bank_account"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.UpdateRecipientDefaultBankAccount") UpdateRecipientDefaultBankAccount

> Updates the default bank account from a recipient


```csharp
Task<Standard.Models.RecipientsDefaultBankAccountResponse> UpdateRecipientDefaultBankAccount(string recipientId, Standard.Models.RecipientsDefaultBankAccountRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Bank account data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.RecipientsDefaultBankAccountRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsDefaultBankAccountResponse result = await recipients.UpdateRecipientDefaultBankAccount(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_transfer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.CreateTransfer") CreateTransfer

> Creates a transfer for a recipient


```csharp
Task<Standard.Models.RecipientsTransfersResponse> CreateTransfer(string recipientId, Standard.Models.RecipientsTransfersRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient Id |
| body |  ``` Required ```  | Transfer data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.RecipientsTransfersRequest();
string idempotencyKey = "idempotency-key";

Standard.Models.RecipientsTransfersResponse result = await recipients.CreateTransfer(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_withdraw"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.CreateWithdraw") CreateWithdraw

> CreateWithdraw


```csharp
Task<Standard.Models.GetWithdrawResponse> CreateWithdraw(string recipientId, Standard.Models.CreateWithdrawRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new Standard.Models.CreateWithdrawRequest();

Standard.Models.GetWithdrawResponse result = await recipients.CreateWithdraw(recipientId, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_withdraw_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.RecipientsController.GetWithdrawById") GetWithdrawById

> GetWithdrawById


```csharp
Task<Standard.Models.GetWithdrawResponse> GetWithdrawById(string recipientId, string withdrawalId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| withdrawalId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string withdrawalId = "withdrawal_id";

Standard.Models.GetWithdrawResponse result = await recipients.GetWithdrawById(recipientId, withdrawalId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="transfers_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.TransfersController") TransfersController

### Get singleton instance

The singleton instance of the ``` TransfersController ``` class can be accessed from the API Client.

```csharp
TransfersController transfers = client.Transfers;
```

### <a name="get_transfer_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.TransfersController.GetTransferById") GetTransferById

> GetTransferById


```csharp
Task<Standard.Models.GetTransfer> GetTransferById(string transferId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transferId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string transferId = "transfer_id";

Standard.Models.GetTransfer result = await transfers.GetTransferById(transferId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="post_create_transfer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.TransfersController.PostCreateTransfer") PostCreateTransfer

> CreateTransfer


```csharp
Task<Standard.Models.GetTransfer> PostCreateTransfer(Standard.Models.CreateTransfer body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Standard.Models.CreateTransfer();

Standard.Models.GetTransfer result = await transfers.PostCreateTransfer(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_transfers1"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.TransfersController.GetTransfers1") GetTransfers1

> Gets all transfers


```csharp
Task<Standard.Models.ListTransfers> GetTransfers1()
```

#### Example Usage

```csharp

Standard.Models.ListTransfers result = await transfers.GetTransfers1();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="tokens_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.TokensController") TokensController

### Get singleton instance

The singleton instance of the ``` TokensController ``` class can be accessed from the API Client.

```csharp
TokensController tokens = client.Tokens;
```

### <a name="create_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.TokensController.CreateToken") CreateToken

> *Tags:*  ``` Skips Authentication ``` 

> CreateToken


```csharp
Task<Standard.Models.TokensResponse> CreateToken(
        string publicKey,
        Standard.Models.TokensRequest body,
        string idempotencyKey = null,
        string appId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| publicKey |  ``` Required ```  | Public key |
| body |  ``` Required ```  | Request for creating a token |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| appId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string publicKey = "public_key";
var body = new Standard.Models.TokensRequest();
string idempotencyKey = "idempotency-key";
string appId = "appId";

Standard.Models.TokensResponse result = await tokens.CreateToken(publicKey, body, idempotencyKey, appId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.TokensController.GetToken") GetToken

> *Tags:*  ``` Skips Authentication ``` 

> Gets a token from its id


```csharp
Task<Standard.Models.TokensResponse> GetToken(string id, string publicKey, string appId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Token id |
| publicKey |  ``` Required ```  | Public key |
| appId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
string publicKey = "public_key";
string appId = "appId";

Standard.Models.TokensResponse result = await tokens.GetToken(id, publicKey, appId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="transactions_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Tests.Controllers.TransactionsController") TransactionsController

### Get singleton instance

The singleton instance of the ``` TransactionsController ``` class can be accessed from the API Client.

```csharp
TransactionsController transactions = client.Transactions;
```

### <a name="get_transaction"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Tests.Controllers.TransactionsController.GetTransaction") GetTransaction

> GetTransaction


```csharp
Task<Standard.Models.GetTransactionResponse> GetTransaction(string transactionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transactionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string transactionId = "transaction_id";

Standard.Models.GetTransactionResponse result = await transactions.GetTransaction(transactionId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)



