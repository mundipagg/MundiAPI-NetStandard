# Orders

```csharp
IOrdersController ordersController = client.OrdersController;
```

## Class Name

`OrdersController`

## Methods

* [Update Order Status](../../doc/controllers/orders.md#update-order-status)
* [Delete All Order Items](../../doc/controllers/orders.md#delete-all-order-items)
* [Update Order Metadata](../../doc/controllers/orders.md#update-order-metadata)
* [Get Orders](../../doc/controllers/orders.md#get-orders)
* [Create Order Item](../../doc/controllers/orders.md#create-order-item)
* [Delete Order Item](../../doc/controllers/orders.md#delete-order-item)
* [Get Order](../../doc/controllers/orders.md#get-order)
* [Create Order](../../doc/controllers/orders.md#create-order)
* [Get Order Item](../../doc/controllers/orders.md#get-order-item)
* [Update Order Item](../../doc/controllers/orders.md#update-order-item)


# Update Order Status

```csharp
UpdateOrderStatusAsync(
    string id,
    Models.UpdateOrderStatusRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Order Id |
| `request` | [`Models.UpdateOrderStatusRequest`](../../doc/models/update-order-status-request.md) | Body, Required | Update Order Model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string id = "id0";
var request = new UpdateOrderStatusRequest();
request.Status = "status8";

try
{
    GetOrderResponse result = await ordersController.UpdateOrderStatusAsync(id, request, null);
}
catch (ApiException e){};
```


# Delete All Order Items

```csharp
DeleteAllOrderItemsAsync(
    string orderId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string orderId = "orderId2";

try
{
    GetOrderResponse result = await ordersController.DeleteAllOrderItemsAsync(orderId, null);
}
catch (ApiException e){};
```


# Update Order Metadata

Updates the metadata from an order

```csharp
UpdateOrderMetadataAsync(
    string orderId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | The order id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the order metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string orderId = "order_id6";
var request = new UpdateMetadataRequest();
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetOrderResponse result = await ordersController.UpdateOrderMetadataAsync(orderId, request, null);
}
catch (ApiException e){};
```


# Get Orders

Gets all orders

```csharp
GetOrdersAsync(
    int? page = null,
    int? size = null,
    string code = null,
    string status = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null,
    string customerId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Filter for order's code |
| `status` | `string` | Query, Optional | Filter for order's status |
| `createdSince` | `DateTime?` | Query, Optional | Filter for order's creation date start range |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for order's creation date end range |
| `customerId` | `string` | Query, Optional | Filter for order's customer id |

## Response Type

[`Task<Models.ListOrderResponse>`](../../doc/models/list-order-response.md)

## Example Usage

```csharp
try
{
    ListOrderResponse result = await ordersController.GetOrdersAsync(null, null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Create Order Item

```csharp
CreateOrderItemAsync(
    string orderId,
    Models.CreateOrderItemRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `request` | [`Models.CreateOrderItemRequest`](../../doc/models/create-order-item-request.md) | Body, Required | Order Item Model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
var request = new CreateOrderItemRequest();
request.Amount = 242;
request.Description = "description6";
request.Quantity = 100;
request.Category = "category4";

try
{
    GetOrderItemResponse result = await ordersController.CreateOrderItemAsync(orderId, request, null);
}
catch (ApiException e){};
```


# Delete Order Item

```csharp
DeleteOrderItemAsync(
    string orderId,
    string itemId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `itemId` | `string` | Template, Required | Item Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
string itemId = "itemId8";

try
{
    GetOrderItemResponse result = await ordersController.DeleteOrderItemAsync(orderId, itemId, null);
}
catch (ApiException e){};
```


# Get Order

Gets an order

```csharp
GetOrderAsync(
    string orderId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order id |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string orderId = "order_id6";

try
{
    GetOrderResponse result = await ordersController.GetOrderAsync(orderId);
}
catch (ApiException e){};
```


# Create Order

Creates a new Order

```csharp
CreateOrderAsync(
    Models.CreateOrderRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CreateOrderRequest`](../../doc/models/create-order-request.md) | Body, Required | Request for creating an order |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
var body = new CreateOrderRequest();
body.Items = new List<CreateOrderItemRequest>();

var bodyItems0 = new CreateOrderItemRequest();
bodyItems0.Amount = 101;
bodyItems0.Description = "description3";
bodyItems0.Quantity = 215;
bodyItems0.Category = "category1";
body.Items.Add(bodyItems0);

var bodyItems1 = new CreateOrderItemRequest();
bodyItems1.Amount = 102;
bodyItems1.Description = "description4";
bodyItems1.Quantity = 216;
bodyItems1.Category = "category2";
body.Items.Add(bodyItems1);

var bodyItems2 = new CreateOrderItemRequest();
bodyItems2.Amount = 103;
bodyItems2.Description = "description5";
bodyItems2.Quantity = 217;
bodyItems2.Category = "category3";
body.Items.Add(bodyItems2);

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
body.Payments = new List<CreatePaymentRequest>();

var bodyPayments0 = new CreatePaymentRequest();
bodyPayments0.PaymentMethod = "payment_method0";
bodyPayments0.PrivateLabel = new CreatePrivateLabelPaymentRequest();
body.Payments.Add(bodyPayments0);

var bodyPayments1 = new CreatePaymentRequest();
bodyPayments1.PaymentMethod = "payment_method9";
bodyPayments1.PrivateLabel = new CreatePrivateLabelPaymentRequest();
body.Payments.Add(bodyPayments1);

body.Code = "code4";
body.CustomerId = "customer_id4";
body.Metadata = new Dictionary<string, string>();
body.Metadata.Add("key0", "metadata7");
body.Metadata.Add("key1", "metadata8");
body.Closed = true;

try
{
    GetOrderResponse result = await ordersController.CreateOrderAsync(body, null);
}
catch (ApiException e){};
```


# Get Order Item

```csharp
GetOrderItemAsync(
    string orderId,
    string itemId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `itemId` | `string` | Template, Required | Item Id |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
string itemId = "itemId8";

try
{
    GetOrderItemResponse result = await ordersController.GetOrderItemAsync(orderId, itemId);
}
catch (ApiException e){};
```


# Update Order Item

```csharp
UpdateOrderItemAsync(
    string orderId,
    string itemId,
    Models.UpdateOrderItemRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `itemId` | `string` | Template, Required | Item Id |
| `request` | [`Models.UpdateOrderItemRequest`](../../doc/models/update-order-item-request.md) | Body, Required | Item Model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
string itemId = "itemId8";
var request = new UpdateOrderItemRequest();
request.Amount = 242;
request.Description = "description6";
request.Quantity = 100;
request.Category = "category4";

try
{
    GetOrderItemResponse result = await ordersController.UpdateOrderItemAsync(orderId, itemId, request, null);
}
catch (ApiException e){};
```

