# Getting started

Mundipagg API

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (MundiAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the MundiAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard)

### 3. Add reference of the library project

In order to use the MundiAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` MundiAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```MundiAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard)

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
* [TokensController](#tokens_controller)
* [SellersController](#sellers_controller)

## <a name="subscriptions_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.SubscriptionsController") SubscriptionsController

### Get singleton instance

The singleton instance of the ``` SubscriptionsController ``` class can be accessed from the API Client.

```csharp
ISubscriptionsController subscriptions = client.Subscriptions;
```

### <a name="get_increment_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetIncrementById") GetIncrementById

> TODO: Add a method description


```csharp
Task<Models.GetIncrementResponse> GetIncrementById(string subscriptionId, string incrementId)
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

Models.GetIncrementResponse result = await subscriptions.GetIncrementById(subscriptionId, incrementId);

```


### <a name="update_subscription_start_at"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionStartAt") UpdateSubscriptionStartAt

> Updates the start at date from a subscription


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionStartAt(string subscriptionId, Models.UpdateSubscriptionStartDateRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| request |  ``` Required ```  | Request for updating the subscription start date |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.UpdateSubscriptionStartDateRequest();

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionStartAt(subscriptionId, request);

```


### <a name="update_subscription_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionCard") UpdateSubscriptionCard

> Updates the credit card from a subscription


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionCard(string subscriptionId, Models.UpdateSubscriptionCardRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| request |  ``` Required ```  | Request for updating a card |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.UpdateSubscriptionCardRequest();

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionCard(subscriptionId, request);

```


### <a name="update_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionItem") UpdateSubscriptionItem

> Updates a subscription item


```csharp
Task<Models.GetSubscriptionItemResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, Models.UpdateSubscriptionItemRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |
| body |  ``` Required ```  | Request for updating a subscription item |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
var body = new Models.UpdateSubscriptionItemRequest();

Models.GetSubscriptionItemResponse result = await subscriptions.UpdateSubscriptionItem(subscriptionId, itemId, body);

```


### <a name="create_usage"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.CreateUsage") CreateUsage

> Creates a usage


```csharp
Task<Models.GetUsageResponse> CreateUsage(string subscriptionId, string itemId, Models.CreateUsageRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |
| body |  ``` Required ```  | Request for creating a usage |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
var body = new Models.CreateUsageRequest();

Models.GetUsageResponse result = await subscriptions.CreateUsage(subscriptionId, itemId, body);

```


### <a name="get_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetSubscription") GetSubscription

> Gets a subscription


```csharp
Task<Models.GetSubscriptionResponse> GetSubscription(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

Models.GetSubscriptionResponse result = await subscriptions.GetSubscription(subscriptionId);

```


### <a name="update_subscription_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionPaymentMethod") UpdateSubscriptionPaymentMethod

> Updates the payment method from a subscription


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, Models.UpdateSubscriptionPaymentMethodRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| request |  ``` Required ```  | Request for updating the paymentmethod from a subscription |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.UpdateSubscriptionPaymentMethodRequest();

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionPaymentMethod(subscriptionId, request);

```


### <a name="create_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.CreateSubscription") CreateSubscription

> Creates a new subscription


```csharp
Task<Models.GetSubscriptionResponse> CreateSubscription(Models.CreateSubscriptionRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a subscription |


#### Example Usage

```csharp
var body = new Models.CreateSubscriptionRequest();

Models.GetSubscriptionResponse result = await subscriptions.CreateSubscription(body);

```


### <a name="create_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.CreateSubscriptionItem") CreateSubscriptionItem

> Creates a new Subscription item


```csharp
Task<Models.GetSubscriptionItemResponse> CreateSubscriptionItem(string subscriptionId, Models.CreateSubscriptionItemRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| request |  ``` Required ```  | Request for creating a subscription item |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.CreateSubscriptionItemRequest();

Models.GetSubscriptionItemResponse result = await subscriptions.CreateSubscriptionItem(subscriptionId, request);

```


### <a name="create_discount"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.CreateDiscount") CreateDiscount

> Creates a discount


```csharp
Task<Models.GetDiscountResponse> CreateDiscount(string subscriptionId, Models.CreateDiscountRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| request |  ``` Required ```  | Request for creating a discount |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.CreateDiscountRequest();

Models.GetDiscountResponse result = await subscriptions.CreateDiscount(subscriptionId, request);

```


### <a name="get_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetSubscriptionItem") GetSubscriptionItem

> Get Subscription Item


```csharp
Task<Models.GetSubscriptionItemResponse> GetSubscriptionItem(string subscriptionId, string itemId)
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

Models.GetSubscriptionItemResponse result = await subscriptions.GetSubscriptionItem(subscriptionId, itemId);

```


### <a name="update_subscription_affiliation_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionAffiliationId") UpdateSubscriptionAffiliationId

> TODO: Add a method description


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionAffiliationId(string subscriptionId, Models.UpdateSubscriptionAffiliationIdRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | TODO: Add a parameter description |
| request |  ``` Required ```  | Request for updating a subscription affiliation id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.UpdateSubscriptionAffiliationIdRequest();

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionAffiliationId(subscriptionId, request);

```


### <a name="create_an_usage"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.CreateAnUsage") CreateAnUsage

> Create Usage


```csharp
Task<Models.GetUsageResponse> CreateAnUsage(string subscriptionId, string itemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| itemId |  ``` Required ```  | Item id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";

Models.GetUsageResponse result = await subscriptions.CreateAnUsage(subscriptionId, itemId);

```


### <a name="get_subscriptions"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetSubscriptions") GetSubscriptions

> Gets all subscriptions


```csharp
Task<Models.ListSubscriptionsResponse> GetSubscriptions(
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
int? page = 193;
int? size = 193;
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

Models.ListSubscriptionsResponse result = await subscriptions.GetSubscriptions(page, size, code, billingType, customerId, planId, cardId, status, nextBillingSince, nextBillingUntil, createdSince, createdUntil);

```


### <a name="update_subscription_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionMetadata") UpdateSubscriptionMetadata

> Updates the metadata from a subscription


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionMetadata(string subscriptionId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| request |  ``` Required ```  | Request for updating the subscrption metadata |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.UpdateMetadataRequest();

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionMetadata(subscriptionId, request);

```


### <a name="delete_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.DeleteSubscriptionItem") DeleteSubscriptionItem

> Deletes a subscription item


```csharp
Task<Models.GetSubscriptionItemResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| subscriptionItemId |  ``` Required ```  | Subscription item id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string subscriptionItemId = "subscription_item_id";

Models.GetSubscriptionItemResponse result = await subscriptions.DeleteSubscriptionItem(subscriptionId, subscriptionItemId);

```


### <a name="delete_usage"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.DeleteUsage") DeleteUsage

> Deletes a usage


```csharp
Task<Models.GetUsageResponse> DeleteUsage(string subscriptionId, string itemId, string usageId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| itemId |  ``` Required ```  | The subscription item id |
| usageId |  ``` Required ```  | The usage id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
string usageId = "usage_id";

Models.GetUsageResponse result = await subscriptions.DeleteUsage(subscriptionId, itemId, usageId);

```


### <a name="delete_discount"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.DeleteDiscount") DeleteDiscount

> Deletes a discount


```csharp
Task<Models.GetDiscountResponse> DeleteDiscount(string subscriptionId, string discountId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| discountId |  ``` Required ```  | Discount Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string discountId = "discount_id";

Models.GetDiscountResponse result = await subscriptions.DeleteDiscount(subscriptionId, discountId);

```


### <a name="cancel_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.CancelSubscription") CancelSubscription

> Cancels a subscription


```csharp
Task<Models.GetSubscriptionResponse> CancelSubscription(string subscriptionId, Models.CreateCancelSubscriptionRequest request = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| request |  ``` Optional ```  | Request for cancelling a subscription |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.CreateCancelSubscriptionRequest();

Models.GetSubscriptionResponse result = await subscriptions.CancelSubscription(subscriptionId, request);

```


### <a name="get_discount_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetDiscountById") GetDiscountById

> TODO: Add a method description


```csharp
Task<Models.GetDiscountResponse> GetDiscountById(string subscriptionId, string discountId)
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

Models.GetDiscountResponse result = await subscriptions.GetDiscountById(subscriptionId, discountId);

```


### <a name="get_discounts"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetDiscounts") GetDiscounts

> TODO: Add a method description


```csharp
Task<Models.ListDiscountsResponse> GetDiscounts(string subscriptionId, int page, int size)
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
int page = 193;
int size = 193;

Models.ListDiscountsResponse result = await subscriptions.GetDiscounts(subscriptionId, page, size);

```


### <a name="create_increment"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.CreateIncrement") CreateIncrement

> Creates a increment


```csharp
Task<Models.GetIncrementResponse> CreateIncrement(string subscriptionId, Models.CreateIncrementRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| request |  ``` Required ```  | Request for creating a increment |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.CreateIncrementRequest();

Models.GetIncrementResponse result = await subscriptions.CreateIncrement(subscriptionId, request);

```


### <a name="get_increments"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetIncrements") GetIncrements

> TODO: Add a method description


```csharp
Task<Models.ListIncrementsResponse> GetIncrements(string subscriptionId, int? page = null, int? size = null)
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
int? page = 193;
int? size = 193;

Models.ListIncrementsResponse result = await subscriptions.GetIncrements(subscriptionId, page, size);

```


### <a name="delete_increment"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.DeleteIncrement") DeleteIncrement

> Deletes a increment


```csharp
Task<Models.GetIncrementResponse> DeleteIncrement(string subscriptionId, string incrementId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| incrementId |  ``` Required ```  | Increment id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string incrementId = "increment_id";

Models.GetIncrementResponse result = await subscriptions.DeleteIncrement(subscriptionId, incrementId);

```


### <a name="get_usages_details"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetUsagesDetails") GetUsagesDetails

> TODO: Add a method description


```csharp
Task<Models.GetUsagesDetailsResponse> GetUsagesDetails(
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
int? size = 193;
int? page = 193;
string itemId = "item_id";
string mgroup = "group";

Models.GetUsagesDetailsResponse result = await subscriptions.GetUsagesDetails(subscriptionId, cycleId, size, page, itemId, mgroup);

```


### <a name="get_usages"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetUsages") GetUsages

> Lists all usages from a subscription item


```csharp
Task<Models.ListUsagesResponse> GetUsages(
        string subscriptionId,
        string itemId,
        int? page = null,
        int? size = null,
        string code = null,
        string mgroup = null)
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


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
int? page = 193;
int? size = 193;
string code = "code";
string mgroup = "group";

Models.ListUsagesResponse result = await subscriptions.GetUsages(subscriptionId, itemId, page, size, code, mgroup);

```


### <a name="get_subscription_items"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.GetSubscriptionItems") GetSubscriptionItems

> Get Subscription Items


```csharp
Task<Models.ListSubscriptionItemsResponse> GetSubscriptionItems(
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
int? page = 193;
int? size = 193;
string name = "name";
string code = "code";
string status = "status";
string description = "description";
string createdSince = "created_since";
string createdUntil = "created_until";

Models.ListSubscriptionItemsResponse result = await subscriptions.GetSubscriptionItems(subscriptionId, page, size, name, code, status, description, createdSince, createdUntil);

```


### <a name="update_subscription_due_days"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionDueDays") UpdateSubscriptionDueDays

> Updates the boleto due days from a subscription


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionDueDays(string subscriptionId, Models.UpdateSubscriptionDueDaysRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.UpdateSubscriptionDueDaysRequest();

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionDueDays(subscriptionId, request);

```


### <a name="update_subscription_minium_price"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SubscriptionsController.UpdateSubscriptionMiniumPrice") UpdateSubscriptionMiniumPrice

> Atualização do valor mínimo da assinatura


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, Models.UpdateSubscriptionMinimumPriceRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| request |  ``` Required ```  | Request da requisição com o valor mínimo que será configurado |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var request = new Models.UpdateSubscriptionMinimumPriceRequest();

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionMiniumPrice(subscriptionId, request);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="orders_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.OrdersController") OrdersController

### Get singleton instance

The singleton instance of the ``` OrdersController ``` class can be accessed from the API Client.

```csharp
IOrdersController orders = client.Orders;
```

### <a name="get_order"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.GetOrder") GetOrder

> Gets an order


```csharp
Task<Models.GetOrderResponse> GetOrder(string orderId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order id |


#### Example Usage

```csharp
string orderId = "order_id";

Models.GetOrderResponse result = await orders.GetOrder(orderId);

```


### <a name="create_order"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.CreateOrder") CreateOrder

> Creates a new Order


```csharp
Task<Models.GetOrderResponse> CreateOrder(Models.CreateOrderRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating an order |


#### Example Usage

```csharp
var body = new Models.CreateOrderRequest();

Models.GetOrderResponse result = await orders.CreateOrder(body);

```


### <a name="get_orders"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.GetOrders") GetOrders

> Gets all orders


```csharp
Task<Models.ListOrderResponse> GetOrders(
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
int? page = 193;
int? size = 193;
string code = "code";
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();
string customerId = "customer_id";

Models.ListOrderResponse result = await orders.GetOrders(page, size, code, status, createdSince, createdUntil, customerId);

```


### <a name="update_order_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.UpdateOrderMetadata") UpdateOrderMetadata

> Updates the metadata from an order


```csharp
Task<Models.GetOrderResponse> UpdateOrderMetadata(string orderId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | The order id |
| request |  ``` Required ```  | Request for updating the order metadata |


#### Example Usage

```csharp
string orderId = "order_id";
var request = new Models.UpdateMetadataRequest();

Models.GetOrderResponse result = await orders.UpdateOrderMetadata(orderId, request);

```


### <a name="delete_all_order_items"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.DeleteAllOrderItems") DeleteAllOrderItems

> TODO: Add a method description


```csharp
Task<Models.GetOrderResponse> DeleteAllOrderItems(string orderId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |


#### Example Usage

```csharp
string orderId = "orderId";

Models.GetOrderResponse result = await orders.DeleteAllOrderItems(orderId);

```


### <a name="update_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.UpdateOrderItem") UpdateOrderItem

> TODO: Add a method description


```csharp
Task<Models.GetOrderItemResponse> UpdateOrderItem(string orderId, string itemId, Models.UpdateOrderItemRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| itemId |  ``` Required ```  | Item Id |
| request |  ``` Required ```  | Item Model |


#### Example Usage

```csharp
string orderId = "orderId";
string itemId = "itemId";
var request = new Models.UpdateOrderItemRequest();

Models.GetOrderItemResponse result = await orders.UpdateOrderItem(orderId, itemId, request);

```


### <a name="delete_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.DeleteOrderItem") DeleteOrderItem

> TODO: Add a method description


```csharp
Task<Models.GetOrderItemResponse> DeleteOrderItem(string orderId, string itemId)
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

Models.GetOrderItemResponse result = await orders.DeleteOrderItem(orderId, itemId);

```


### <a name="create_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.CreateOrderItem") CreateOrderItem

> TODO: Add a method description


```csharp
Task<Models.GetOrderItemResponse> CreateOrderItem(string orderId, Models.CreateOrderItemRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| request |  ``` Required ```  | Order Item Model |


#### Example Usage

```csharp
string orderId = "orderId";
var request = new Models.CreateOrderItemRequest();

Models.GetOrderItemResponse result = await orders.CreateOrderItem(orderId, request);

```


### <a name="get_order_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.GetOrderItem") GetOrderItem

> TODO: Add a method description


```csharp
Task<Models.GetOrderItemResponse> GetOrderItem(string orderId, string itemId)
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

Models.GetOrderItemResponse result = await orders.GetOrderItem(orderId, itemId);

```


### <a name="update_order_status"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.OrdersController.UpdateOrderStatus") UpdateOrderStatus

> TODO: Add a method description


```csharp
Task<Models.GetOrderResponse> UpdateOrderStatus(string id, Models.UpdateOrderStatusRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Order Id |
| request |  ``` Required ```  | Update Order Model |


#### Example Usage

```csharp
string id = "id";
var request = new Models.UpdateOrderStatusRequest();

Models.GetOrderResponse result = await orders.UpdateOrderStatus(id, request);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="plans_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.PlansController") PlansController

### Get singleton instance

The singleton instance of the ``` PlansController ``` class can be accessed from the API Client.

```csharp
IPlansController plans = client.Plans;
```

### <a name="create_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.CreatePlanItem") CreatePlanItem

> Adds a new item to a plan


```csharp
Task<Models.GetPlanItemResponse> CreatePlanItem(string planId, Models.CreatePlanItemRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| request |  ``` Required ```  | Request for creating a plan item |


#### Example Usage

```csharp
string planId = "plan_id";
var request = new Models.CreatePlanItemRequest();

Models.GetPlanItemResponse result = await plans.CreatePlanItem(planId, request);

```


### <a name="update_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.UpdatePlanItem") UpdatePlanItem

> Updates a plan item


```csharp
Task<Models.GetPlanItemResponse> UpdatePlanItem(string planId, string planItemId, Models.UpdatePlanItemRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |
| body |  ``` Required ```  | Request for updating the plan item |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";
var body = new Models.UpdatePlanItemRequest();

Models.GetPlanItemResponse result = await plans.UpdatePlanItem(planId, planItemId, body);

```


### <a name="get_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.GetPlan") GetPlan

> Gets a plan


```csharp
Task<Models.GetPlanResponse> GetPlan(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

Models.GetPlanResponse result = await plans.GetPlan(planId);

```


### <a name="delete_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.DeletePlan") DeletePlan

> Deletes a plan


```csharp
Task<Models.GetPlanResponse> DeletePlan(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

Models.GetPlanResponse result = await plans.DeletePlan(planId);

```


### <a name="update_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.UpdatePlan") UpdatePlan

> Updates a plan


```csharp
Task<Models.GetPlanResponse> UpdatePlan(string planId, Models.UpdatePlanRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| request |  ``` Required ```  | Request for updating a plan |


#### Example Usage

```csharp
string planId = "plan_id";
var request = new Models.UpdatePlanRequest();

Models.GetPlanResponse result = await plans.UpdatePlan(planId, request);

```


### <a name="create_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.CreatePlan") CreatePlan

> Creates a new plan


```csharp
Task<Models.GetPlanResponse> CreatePlan(Models.CreatePlanRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a plan |


#### Example Usage

```csharp
var body = new Models.CreatePlanRequest();

Models.GetPlanResponse result = await plans.CreatePlan(body);

```


### <a name="get_plans"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.GetPlans") GetPlans

> Gets all plans


```csharp
Task<Models.ListPlansResponse> GetPlans(
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
int? page = 193;
int? size = 193;
string name = "name";
string status = "status";
string billingType = "billing_type";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Models.ListPlansResponse result = await plans.GetPlans(page, size, name, status, billingType, createdSince, createdUntil);

```


### <a name="update_plan_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.UpdatePlanMetadata") UpdatePlanMetadata

> Updates the metadata from a plan


```csharp
Task<Models.GetPlanResponse> UpdatePlanMetadata(string planId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | The plan id |
| request |  ``` Required ```  | Request for updating the plan metadata |


#### Example Usage

```csharp
string planId = "plan_id";
var request = new Models.UpdateMetadataRequest();

Models.GetPlanResponse result = await plans.UpdatePlanMetadata(planId, request);

```


### <a name="get_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.GetPlanItem") GetPlanItem

> Gets a plan item


```csharp
Task<Models.GetPlanItemResponse> GetPlanItem(string planId, string planItemId)
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

Models.GetPlanItemResponse result = await plans.GetPlanItem(planId, planItemId);

```


### <a name="delete_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.PlansController.DeletePlanItem") DeletePlanItem

> Removes an item from a plan


```csharp
Task<Models.GetPlanItemResponse> DeletePlanItem(string planId, string planItemId)
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

Models.GetPlanItemResponse result = await plans.DeletePlanItem(planId, planItemId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="invoices_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.InvoicesController") InvoicesController

### Get singleton instance

The singleton instance of the ``` InvoicesController ``` class can be accessed from the API Client.

```csharp
IInvoicesController invoices = client.Invoices;
```

### <a name="cancel_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.InvoicesController.CancelInvoice") CancelInvoice

> Cancels an invoice


```csharp
Task<Models.GetInvoiceResponse> CancelInvoice(string invoiceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice id |


#### Example Usage

```csharp
string invoiceId = "invoice_id";

Models.GetInvoiceResponse result = await invoices.CancelInvoice(invoiceId);

```


### <a name="get_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.InvoicesController.GetInvoice") GetInvoice

> Gets an invoice


```csharp
Task<Models.GetInvoiceResponse> GetInvoice(string invoiceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice Id |


#### Example Usage

```csharp
string invoiceId = "invoice_id";

Models.GetInvoiceResponse result = await invoices.GetInvoice(invoiceId);

```


### <a name="create_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.InvoicesController.CreateInvoice") CreateInvoice

> Create an Invoice


```csharp
Task<Models.GetInvoiceResponse> CreateInvoice(string subscriptionId, string cycleId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| cycleId |  ``` Required ```  | Cycle Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string cycleId = "cycle_id";

Models.GetInvoiceResponse result = await invoices.CreateInvoice(subscriptionId, cycleId);

```


### <a name="update_invoice_status"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.InvoicesController.UpdateInvoiceStatus") UpdateInvoiceStatus

> Updates the status from an invoice


```csharp
Task<Models.GetInvoiceResponse> UpdateInvoiceStatus(string invoiceId, Models.UpdateInvoiceStatusRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice Id |
| request |  ``` Required ```  | Request for updating an invoice's status |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
var request = new Models.UpdateInvoiceStatusRequest();

Models.GetInvoiceResponse result = await invoices.UpdateInvoiceStatus(invoiceId, request);

```


### <a name="get_invoices"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.InvoicesController.GetInvoices") GetInvoices

> Gets all invoices


```csharp
Task<Models.ListInvoicesResponse> GetInvoices(
        int? page = null,
        int? size = null,
        string code = null,
        string customerId = null,
        string subscriptionId = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null,
        string status = null,
        DateTime? dueSince = null,
        DateTime? dueUntil = null)
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


#### Example Usage

```csharp
int? page = 30;
int? size = 30;
string code = "code";
string customerId = "customer_id";
string subscriptionId = "subscription_id";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();
string status = "status";
DateTime? dueSince = DateTime.Now();
DateTime? dueUntil = DateTime.Now();

Models.ListInvoicesResponse result = await invoices.GetInvoices(page, size, code, customerId, subscriptionId, createdSince, createdUntil, status, dueSince, dueUntil);

```


### <a name="update_invoice_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.InvoicesController.UpdateInvoiceMetadata") UpdateInvoiceMetadata

> Updates the metadata from an invoice


```csharp
Task<Models.GetInvoiceResponse> UpdateInvoiceMetadata(string invoiceId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | The invoice id |
| request |  ``` Required ```  | Request for updating the invoice metadata |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
var request = new Models.UpdateMetadataRequest();

Models.GetInvoiceResponse result = await invoices.UpdateInvoiceMetadata(invoiceId, request);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="customers_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.CustomersController") CustomersController

### Get singleton instance

The singleton instance of the ``` CustomersController ``` class can be accessed from the API Client.

```csharp
ICustomersController customers = client.Customers;
```

### <a name="update_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.UpdateCard") UpdateCard

> Updates a card


```csharp
Task<Models.GetCardResponse> UpdateCard(string customerId, string cardId, Models.UpdateCardRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Card id |
| request |  ``` Required ```  | Request for updating a card |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
var request = new Models.UpdateCardRequest();

Models.GetCardResponse result = await customers.UpdateCard(customerId, cardId, request);

```


### <a name="update_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.UpdateAddress") UpdateAddress

> Updates an address


```csharp
Task<Models.GetAddressResponse> UpdateAddress(string customerId, string addressId, Models.UpdateAddressRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |
| request |  ``` Required ```  | Request for updating an address |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";
var request = new Models.UpdateAddressRequest();

Models.GetAddressResponse result = await customers.UpdateAddress(customerId, addressId, request);

```


### <a name="create_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.CreateCustomer") CreateCustomer

> Creates a new customer


```csharp
Task<Models.GetCustomerResponse> CreateCustomer(Models.CreateCustomerRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request for creating a customer |


#### Example Usage

```csharp
var request = new Models.CreateCustomerRequest();

Models.GetCustomerResponse result = await customers.CreateCustomer(request);

```


### <a name="get_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetCustomer") GetCustomer

> Get a customer


```csharp
Task<Models.GetCustomerResponse> GetCustomer(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

Models.GetCustomerResponse result = await customers.GetCustomer(customerId);

```


### <a name="get_access_tokens"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetAccessTokens") GetAccessTokens

> Get all access tokens from a customer


```csharp
Task<Models.ListAccessTokensResponse> GetAccessTokens(string customerId, int? page = null, int? size = null)
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
int? page = 30;
int? size = 30;

Models.ListAccessTokensResponse result = await customers.GetAccessTokens(customerId, page, size);

```


### <a name="get_addresses"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetAddresses") GetAddresses

> Gets all adressess from a customer


```csharp
Task<Models.ListAddressesResponse> GetAddresses(string customerId, int? page = null, int? size = null)
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
int? page = 30;
int? size = 30;

Models.ListAddressesResponse result = await customers.GetAddresses(customerId, page, size);

```


### <a name="get_cards"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetCards") GetCards

> Get all cards from a customer


```csharp
Task<Models.ListCardsResponse> GetCards(string customerId, int? page = null, int? size = null)
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
int? page = 30;
int? size = 30;

Models.ListCardsResponse result = await customers.GetCards(customerId, page, size);

```


### <a name="delete_access_tokens"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.DeleteAccessTokens") DeleteAccessTokens

> Delete a Customer's access tokens


```csharp
Task<Models.ListAccessTokensResponse> DeleteAccessTokens(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

Models.ListAccessTokensResponse result = await customers.DeleteAccessTokens(customerId);

```


### <a name="get_access_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetAccessToken") GetAccessToken

> Get a Customer's access token


```csharp
Task<Models.GetAccessTokenResponse> GetAccessToken(string customerId, string tokenId)
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

Models.GetAccessTokenResponse result = await customers.GetAccessToken(customerId, tokenId);

```


### <a name="create_access_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.CreateAccessToken") CreateAccessToken

> Creates a access token for a customer


```csharp
Task<Models.GetAccessTokenResponse> CreateAccessToken(string customerId, Models.CreateAccessTokenRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| request |  ``` Required ```  | Request for creating a access token |


#### Example Usage

```csharp
string customerId = "customer_id";
var request = new Models.CreateAccessTokenRequest();

Models.GetAccessTokenResponse result = await customers.CreateAccessToken(customerId, request);

```


### <a name="delete_access_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.DeleteAccessToken") DeleteAccessToken

> Delete a customer's access token


```csharp
Task<Models.GetAccessTokenResponse> DeleteAccessToken(string customerId, string tokenId)
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

Models.GetAccessTokenResponse result = await customers.DeleteAccessToken(customerId, tokenId);

```


### <a name="update_customer_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.UpdateCustomerMetadata") UpdateCustomerMetadata

> Updates the metadata a customer


```csharp
Task<Models.GetCustomerResponse> UpdateCustomerMetadata(string customerId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | The customer id |
| request |  ``` Required ```  | Request for updating the customer metadata |


#### Example Usage

```csharp
string customerId = "customer_id";
var request = new Models.UpdateMetadataRequest();

Models.GetCustomerResponse result = await customers.UpdateCustomerMetadata(customerId, request);

```


### <a name="update_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.UpdateCustomer") UpdateCustomer

> Updates a customer


```csharp
Task<Models.GetCustomerResponse> UpdateCustomer(string customerId, Models.UpdateCustomerRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| request |  ``` Required ```  | Request for updating a customer |


#### Example Usage

```csharp
string customerId = "customer_id";
var request = new Models.UpdateCustomerRequest();

Models.GetCustomerResponse result = await customers.UpdateCustomer(customerId, request);

```


### <a name="get_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetAddress") GetAddress

> Get a customer's address


```csharp
Task<Models.GetAddressResponse> GetAddress(string customerId, string addressId)
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

Models.GetAddressResponse result = await customers.GetAddress(customerId, addressId);

```


### <a name="delete_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.DeleteAddress") DeleteAddress

> Delete a Customer's address


```csharp
Task<Models.GetAddressResponse> DeleteAddress(string customerId, string addressId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";

Models.GetAddressResponse result = await customers.DeleteAddress(customerId, addressId);

```


### <a name="delete_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.DeleteCard") DeleteCard

> Delete a customer's card


```csharp
Task<Models.GetCardResponse> DeleteCard(string customerId, string cardId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Card Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";

Models.GetCardResponse result = await customers.DeleteCard(customerId, cardId);

```


### <a name="create_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.CreateAddress") CreateAddress

> Creates a new address for a customer


```csharp
Task<Models.GetAddressResponse> CreateAddress(string customerId, Models.CreateAddressRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| request |  ``` Required ```  | Request for creating an address |


#### Example Usage

```csharp
string customerId = "customer_id";
var request = new Models.CreateAddressRequest();

Models.GetAddressResponse result = await customers.CreateAddress(customerId, request);

```


### <a name="get_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetCard") GetCard

> Get a customer's card


```csharp
Task<Models.GetCardResponse> GetCard(string customerId, string cardId)
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

Models.GetCardResponse result = await customers.GetCard(customerId, cardId);

```


### <a name="create_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.CreateCard") CreateCard

> Creates a new card for a customer


```csharp
Task<Models.GetCardResponse> CreateCard(string customerId, Models.CreateCardRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| request |  ``` Required ```  | Request for creating a card |


#### Example Usage

```csharp
string customerId = "customer_id";
var request = new Models.CreateCardRequest();

Models.GetCardResponse result = await customers.CreateCard(customerId, request);

```


### <a name="get_customers"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.GetCustomers") GetCustomers

> Get all Customers


```csharp
Task<Models.ListCustomersResponse> GetCustomers(
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

Models.ListCustomersResponse result = await customers.GetCustomers(name, document, page, size, email, code);

```


### <a name="renew_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.CustomersController.RenewCard") RenewCard

> Renew a card


```csharp
Task<Models.GetCardResponse> RenewCard(string customerId, string cardId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| cardId |  ``` Required ```  | Card Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";

Models.GetCardResponse result = await customers.RenewCard(customerId, cardId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="charges_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.ChargesController") ChargesController

### Get singleton instance

The singleton instance of the ``` ChargesController ``` class can be accessed from the API Client.

```csharp
IChargesController charges = client.Charges;
```

### <a name="update_charge_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.UpdateChargeCard") UpdateChargeCard

> Updates the card from a charge


```csharp
Task<Models.GetChargeResponse> UpdateChargeCard(string chargeId, Models.UpdateChargeCardRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| request |  ``` Required ```  | Request for updating a charge's card |


#### Example Usage

```csharp
string chargeId = "charge_id";
var request = new Models.UpdateChargeCardRequest();

Models.GetChargeResponse result = await charges.UpdateChargeCard(chargeId, request);

```


### <a name="update_charge_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.UpdateChargePaymentMethod") UpdateChargePaymentMethod

> Updates a charge's payment method


```csharp
Task<Models.GetChargeResponse> UpdateChargePaymentMethod(string chargeId, Models.UpdateChargePaymentMethodRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| request |  ``` Required ```  | Request for updating the payment method from a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
var request = new Models.UpdateChargePaymentMethodRequest();

Models.GetChargeResponse result = await charges.UpdateChargePaymentMethod(chargeId, request);

```


### <a name="create_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.CreateCharge") CreateCharge

> Creates a new charge


```csharp
Task<Models.GetChargeResponse> CreateCharge(Models.CreateChargeRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request for creating a charge |


#### Example Usage

```csharp
var request = new Models.CreateChargeRequest();

Models.GetChargeResponse result = await charges.CreateCharge(request);

```


### <a name="get_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.GetCharge") GetCharge

> Get a charge from its id


```csharp
Task<Models.GetChargeResponse> GetCharge(string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
string chargeId = "charge_id";

Models.GetChargeResponse result = await charges.GetCharge(chargeId);

```


### <a name="retry_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.RetryCharge") RetryCharge

> Retries a charge


```csharp
Task<Models.GetChargeResponse> RetryCharge(string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
string chargeId = "charge_id";

Models.GetChargeResponse result = await charges.RetryCharge(chargeId);

```


### <a name="get_charges"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.GetCharges") GetCharges

> Lists all charges


```csharp
Task<Models.ListChargesResponse> GetCharges(
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
int? page = 30;
int? size = 30;
string code = "code";
string status = "status";
string paymentMethod = "payment_method";
string customerId = "customer_id";
string orderId = "order_id";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Models.ListChargesResponse result = await charges.GetCharges(page, size, code, status, paymentMethod, customerId, orderId, createdSince, createdUntil);

```


### <a name="update_charge_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.UpdateChargeMetadata") UpdateChargeMetadata

> Updates the metadata from a charge


```csharp
Task<Models.GetChargeResponse> UpdateChargeMetadata(string chargeId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | The charge id |
| request |  ``` Required ```  | Request for updating the charge metadata |


#### Example Usage

```csharp
string chargeId = "charge_id";
var request = new Models.UpdateMetadataRequest();

Models.GetChargeResponse result = await charges.UpdateChargeMetadata(chargeId, request);

```


### <a name="cancel_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.CancelCharge") CancelCharge

> Cancel a charge


```csharp
Task<Models.GetChargeResponse> CancelCharge(string chargeId, Models.CreateCancelChargeRequest request = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| request |  ``` Optional ```  | Request for cancelling a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
var request = new Models.CreateCancelChargeRequest();

Models.GetChargeResponse result = await charges.CancelCharge(chargeId, request);

```


### <a name="capture_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.CaptureCharge") CaptureCharge

> Captures a charge


```csharp
Task<Models.GetChargeResponse> CaptureCharge(string chargeId, Models.CreateCaptureChargeRequest request = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| request |  ``` Optional ```  | Request for capturing a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
var request = new Models.CreateCaptureChargeRequest();

Models.GetChargeResponse result = await charges.CaptureCharge(chargeId, request);

```


### <a name="update_charge_due_date"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.UpdateChargeDueDate") UpdateChargeDueDate

> Updates the due date from a charge


```csharp
Task<Models.GetChargeResponse> UpdateChargeDueDate(string chargeId, Models.UpdateChargeDueDateRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge Id |
| request |  ``` Required ```  | Request for updating the due date |


#### Example Usage

```csharp
string chargeId = "charge_id";
var request = new Models.UpdateChargeDueDateRequest();

Models.GetChargeResponse result = await charges.UpdateChargeDueDate(chargeId, request);

```


### <a name="confirm_payment"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.ChargesController.ConfirmPayment") ConfirmPayment

> TODO: Add a method description


```csharp
Task<Models.GetChargeResponse> ConfirmPayment(string chargeId, Models.CreateConfirmPaymentRequest request = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | TODO: Add a parameter description |
| request |  ``` Optional ```  | Request for confirm payment |


#### Example Usage

```csharp
string chargeId = "charge_id";
var request = new Models.CreateConfirmPaymentRequest();

Models.GetChargeResponse result = await charges.ConfirmPayment(chargeId, request);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="recipients_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.RecipientsController") RecipientsController

### Get singleton instance

The singleton instance of the ``` RecipientsController ``` class can be accessed from the API Client.

```csharp
IRecipientsController recipients = client.Recipients;
```

### <a name="update_recipient_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.UpdateRecipientMetadata") UpdateRecipientMetadata

> Updates recipient metadata


```csharp
Task<Models.GetRecipientResponse> UpdateRecipientMetadata(string recipientId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| request |  ``` Required ```  | Metadata |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var request = new Models.UpdateMetadataRequest();

Models.GetRecipientResponse result = await recipients.UpdateRecipientMetadata(recipientId, request);

```


### <a name="get_transfer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetTransfer") GetTransfer

> Gets a transfer


```csharp
Task<Models.GetTransferResponse> GetTransfer(string recipientId, string transferId)
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

Models.GetTransferResponse result = await recipients.GetTransfer(recipientId, transferId);

```


### <a name="get_transfers"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetTransfers") GetTransfers

> Gets a paginated list of transfers for the recipient


```csharp
Task<Models.ListTransferResponse> GetTransfers(
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
int? page = 30;
int? size = 30;
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Models.ListTransferResponse result = await recipients.GetTransfers(recipientId, page, size, status, createdSince, createdUntil);

```


### <a name="create_anticipation"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.CreateAnticipation") CreateAnticipation

> Creates an anticipation


```csharp
Task<Models.GetAnticipationResponse> CreateAnticipation(string recipientId, Models.CreateAnticipationRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| request |  ``` Required ```  | Anticipation data |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var request = new Models.CreateAnticipationRequest();

Models.GetAnticipationResponse result = await recipients.CreateAnticipation(recipientId, request);

```


### <a name="get_anticipation"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetAnticipation") GetAnticipation

> Gets an anticipation


```csharp
Task<Models.GetAnticipationResponse> GetAnticipation(string recipientId, string anticipationId)
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

Models.GetAnticipationResponse result = await recipients.GetAnticipation(recipientId, anticipationId);

```


### <a name="get_anticipation_limits"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetAnticipationLimits") GetAnticipationLimits

> Gets the anticipation limits for a recipient


```csharp
Task<Models.GetAnticipationLimitResponse> GetAnticipationLimits(string recipientId, string timeframe, DateTime paymentDate)
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

Models.GetAnticipationLimitResponse result = await recipients.GetAnticipationLimits(recipientId, timeframe, paymentDate);

```


### <a name="get_anticipations"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetAnticipations") GetAnticipations

> Retrieves a paginated list of anticipations from a recipient


```csharp
Task<Models.ListAnticipationResponse> GetAnticipations(
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
int? page = 243;
int? size = 243;
string status = "status";
string timeframe = "timeframe";
DateTime? paymentDateSince = DateTime.Now();
DateTime? paymentDateUntil = DateTime.Now();
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Models.ListAnticipationResponse result = await recipients.GetAnticipations(recipientId, page, size, status, timeframe, paymentDateSince, paymentDateUntil, createdSince, createdUntil);

```


### <a name="update_recipient"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.UpdateRecipient") UpdateRecipient

> Updates a recipient


```csharp
Task<Models.GetRecipientResponse> UpdateRecipient(string recipientId, Models.UpdateRecipientRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| request |  ``` Required ```  | Recipient data |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var request = new Models.UpdateRecipientRequest();

Models.GetRecipientResponse result = await recipients.UpdateRecipient(recipientId, request);

```


### <a name="update_recipient_default_bank_account"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.UpdateRecipientDefaultBankAccount") UpdateRecipientDefaultBankAccount

> Updates the default bank account from a recipient


```csharp
Task<Models.GetRecipientResponse> UpdateRecipientDefaultBankAccount(string recipientId, Models.UpdateRecipientBankAccountRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| request |  ``` Required ```  | Bank account data |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var request = new Models.UpdateRecipientBankAccountRequest();

Models.GetRecipientResponse result = await recipients.UpdateRecipientDefaultBankAccount(recipientId, request);

```


### <a name="get_recipient"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetRecipient") GetRecipient

> Retrieves recipient information


```csharp
Task<Models.GetRecipientResponse> GetRecipient(string recipientId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipiend id |


#### Example Usage

```csharp
string recipientId = "recipient_id";

Models.GetRecipientResponse result = await recipients.GetRecipient(recipientId);

```


### <a name="get_recipients"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetRecipients") GetRecipients

> Retrieves paginated recipients information


```csharp
Task<Models.ListRecipientResponse> GetRecipients(int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
int? page = 243;
int? size = 243;

Models.ListRecipientResponse result = await recipients.GetRecipients(page, size);

```


### <a name="get_balance"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.GetBalance") GetBalance

> Get balance information for a recipient


```csharp
Task<Models.GetBalanceResponse> GetBalance(string recipientId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |


#### Example Usage

```csharp
string recipientId = "recipient_id";

Models.GetBalanceResponse result = await recipients.GetBalance(recipientId);

```


### <a name="create_transfer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.CreateTransfer") CreateTransfer

> Creates a transfer for a recipient


```csharp
Task<Models.GetTransferResponse> CreateTransfer(string recipientId, Models.CreateTransferRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient Id |
| request |  ``` Required ```  | Transfer data |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var request = new Models.CreateTransferRequest();

Models.GetTransferResponse result = await recipients.CreateTransfer(recipientId, request);

```


### <a name="create_recipient"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.CreateRecipient") CreateRecipient

> Creates a new recipient


```csharp
Task<Models.GetRecipientResponse> CreateRecipient(Models.CreateRecipientRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Recipient data |


#### Example Usage

```csharp
var request = new Models.CreateRecipientRequest();

Models.GetRecipientResponse result = await recipients.CreateRecipient(request);

```


### <a name="update_recipient_transfer_settings"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.RecipientsController.UpdateRecipientTransferSettings") UpdateRecipientTransferSettings

> TODO: Add a method description


```csharp
Task<Models.GetRecipientResponse> UpdateRecipientTransferSettings(string recipientId, Models.UpdateTransferSettingsRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient Identificator |
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var request = new Models.UpdateTransferSettingsRequest();

Models.GetRecipientResponse result = await recipients.UpdateRecipientTransferSettings(recipientId, request);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="tokens_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.TokensController") TokensController

### Get singleton instance

The singleton instance of the ``` TokensController ``` class can be accessed from the API Client.

```csharp
ITokensController tokens = client.Tokens;
```

### <a name="get_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.TokensController.GetToken") GetToken

> *Tags:*  ``` Skips Authentication ``` 

> Gets a token from its id


```csharp
Task<Models.GetTokenResponse> GetToken(string id, string publicKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Token id |
| publicKey |  ``` Required ```  | Public key |


#### Example Usage

```csharp
string id = "id";
string publicKey = "public_key";

Models.GetTokenResponse result = await tokens.GetToken(id, publicKey);

```


### <a name="create_token"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.TokensController.CreateToken") CreateToken

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add a method description


```csharp
Task<Models.GetTokenResponse> CreateToken(string publicKey, Models.CreateTokenRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| publicKey |  ``` Required ```  | Public key |
| request |  ``` Required ```  | Request for creating a token |


#### Example Usage

```csharp
string publicKey = "public_key";
var request = new Models.CreateTokenRequest();

Models.GetTokenResponse result = await tokens.CreateToken(publicKey, request);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sellers_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.Standard.Controllers.SellersController") SellersController

### Get singleton instance

The singleton instance of the ``` SellersController ``` class can be accessed from the API Client.

```csharp
ISellersController sellers = client.Sellers;
```

### <a name="get_seller_by_id"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SellersController.GetSellerById") GetSellerById

> TODO: Add a method description


```csharp
Task<Models.GetSellerResponse> GetSellerById(string id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Seller Id |


#### Example Usage

```csharp
string id = "id";

Models.GetSellerResponse result = await sellers.GetSellerById(id);

```


### <a name="delete_seller"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SellersController.DeleteSeller") DeleteSeller

> TODO: Add a method description


```csharp
Task<Models.GetSellerResponse> DeleteSeller(string sellerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sellerId |  ``` Required ```  | Seller Id |


#### Example Usage

```csharp
string sellerId = "sellerId";

Models.GetSellerResponse result = await sellers.DeleteSeller(sellerId);

```


### <a name="create_seller"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SellersController.CreateSeller") CreateSeller

> TODO: Add a method description


```csharp
Task<Models.GetSellerResponse> CreateSeller(Models.CreateSellerRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Seller Model |


#### Example Usage

```csharp
var request = new Models.CreateSellerRequest();

Models.GetSellerResponse result = await sellers.CreateSeller(request);

```


### <a name="get_sellers"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SellersController.GetSellers") GetSellers

> TODO: Add a method description


```csharp
Task<Models.ListSellerResponse> GetSellers(
        int? page = null,
        int? size = null,
        string name = null,
        string document = null,
        string code = null,
        string status = null,
        string type = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| name |  ``` Optional ```  | TODO: Add a parameter description |
| document |  ``` Optional ```  | TODO: Add a parameter description |
| code |  ``` Optional ```  | TODO: Add a parameter description |
| status |  ``` Optional ```  | TODO: Add a parameter description |
| type |  ``` Optional ```  | TODO: Add a parameter description |
| createdSince |  ``` Optional ```  | TODO: Add a parameter description |
| createdUntil |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int? page = 243;
int? size = 243;
string name = "name";
string document = "document";
string code = "code";
string status = "status";
string type = "type";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

Models.ListSellerResponse result = await sellers.GetSellers(page, size, name, document, code, status, type, createdSince, createdUntil);

```


### <a name="update_seller"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SellersController.UpdateSeller") UpdateSeller

> TODO: Add a method description


```csharp
Task<Models.GetSellerResponse> UpdateSeller(string id, Models.UpdateSellerRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | TODO: Add a parameter description |
| request |  ``` Required ```  | Update Seller model |


#### Example Usage

```csharp
string id = "id";
var request = new Models.UpdateSellerRequest();

Models.GetSellerResponse result = await sellers.UpdateSeller(id, request);

```


### <a name="update_seller_metadata"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.Standard.Controllers.SellersController.UpdateSellerMetadata") UpdateSellerMetadata

> TODO: Add a method description


```csharp
Task<Models.GetSellerResponse> UpdateSellerMetadata(string sellerId, Models.UpdateMetadataRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sellerId |  ``` Required ```  | Seller Id |
| request |  ``` Required ```  | Request for updating the charge metadata |


#### Example Usage

```csharp
string sellerId = "seller_id";
var request = new Models.UpdateMetadataRequest();

Models.GetSellerResponse result = await sellers.UpdateSellerMetadata(sellerId, request);

```


[Back to List of Controllers](#list_of_controllers)



