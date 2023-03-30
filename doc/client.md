
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthUserName` | `string` | The username to use with basic authentication |
| `BasicAuthPassword` | `string` | The password to use with basic authentication |

The API client can be initialized as follows:

```csharp
MundiAPI.Standard.MundiAPIClient client = new MundiAPI.Standard.MundiAPIClient.Builder()
    .BasicAuthCredentials("BasicAuthUserName", "BasicAuthPassword")
    .Build();
```

## MundiAPIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| CustomersController | Gets CustomersController controller. |
| ChargesController | Gets ChargesController controller. |
| RecipientsController | Gets RecipientsController controller. |
| SubscriptionsController | Gets SubscriptionsController controller. |
| InvoicesController | Gets InvoicesController controller. |
| OrdersController | Gets OrdersController controller. |
| TokensController | Gets TokensController controller. |
| PlansController | Gets PlansController controller. |
| TransactionsController | Gets TransactionsController controller. |
| TransfersController | Gets TransfersController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the MundiAPIClient using the values provided for the builder. | `Builder` |

## MundiAPIClient Builder Class

Class to build instances of MundiAPIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |

