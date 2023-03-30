
# Create Subscription Request

Request for creating a subcription

## Structure

`CreateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`Models.CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Required | Customer |
| `Card` | [`Models.CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Card |
| `Code` | `string` | Required | Subscription code |
| `PaymentMethod` | `string` | Required | Payment method |
| `BillingType` | `string` | Required | Billing type |
| `StatementDescriptor` | `string` | Required | Statement descriptor for credit card subscriptions |
| `Description` | `string` | Required | Subscription description |
| `Currency` | `string` | Required | Currency |
| `Interval` | `string` | Required | Interval |
| `IntervalCount` | `int` | Required | Interval count |
| `PricingScheme` | [`Models.CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Subscription pricing scheme |
| `Items` | [`List<Models.CreateSubscriptionItemRequest>`](../../doc/models/create-subscription-item-request.md) | Required | Subscription items |
| `Shipping` | [`Models.CreateShippingRequest`](../../doc/models/create-shipping-request.md) | Required | Shipping |
| `Discounts` | [`List<Models.CreateDiscountRequest>`](../../doc/models/create-discount-request.md) | Required | Discounts |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Setup` | [`Models.CreateSetupRequest`](../../doc/models/create-setup-request.md) | Required | Setup data |
| `PlanId` | `string` | Optional | Plan id |
| `CustomerId` | `string` | Optional | Customer id |
| `CardId` | `string` | Optional | Card id |
| `BillingDay` | `int?` | Optional | Billing day |
| `Installments` | `int?` | Optional | Number of installments |
| `StartAt` | `DateTime?` | Optional | Subscription start date |
| `MinimumPrice` | `int?` | Optional | Subscription minimum price |
| `Cycles` | `int?` | Optional | Number of cycles |
| `CardToken` | `string` | Optional | Card token |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation code |
| `Quantity` | `int?` | Optional | Quantity |
| `BoletoDueDays` | `int?` | Optional | Days until boleto expires |
| `Increments` | [`List<Models.CreateIncrementRequest>`](../../doc/models/create-increment-request.md) | Required | Increments |
| `Period` | [`Models.CreatePeriodRequest`](../../doc/models/create-period-request.md) | Optional | - |
| `Submerchant` | [`Models.CreateSubMerchantRequest`](../../doc/models/create-sub-merchant-request.md) | Optional | SubMerchant |
| `Split` | [`Models.CreateSubscriptionSplitRequest`](../../doc/models/create-subscription-split-request.md) | Optional | Subscription's split |

## Example (as JSON)

```json
{
  "customer": {
    "name": "{\n    \"name\": \"Tony Stark\"\n}",
    "email": null,
    "document": null,
    "type": null,
    "address": null,
    "metadata": null,
    "phones": null,
    "code": null
  },
  "card": {
    "number": null,
    "holder_name": null,
    "exp_month": null,
    "exp_year": null,
    "cvv": null,
    "billing_address": null,
    "brand": null,
    "billing_address_id": null,
    "metadata": null,
    "type": "credit",
    "options": null,
    "private_label": null,
    "label": null
  },
  "code": null,
  "payment_method": null,
  "billing_type": null,
  "statement_descriptor": null,
  "description": null,
  "currency": null,
  "interval": null,
  "interval_count": null,
  "pricing_scheme": null,
  "items": null,
  "shipping": null,
  "discounts": null,
  "metadata": null,
  "setup": null,
  "increments": null
}
```

