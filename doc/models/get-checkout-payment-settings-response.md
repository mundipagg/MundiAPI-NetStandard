
# Get Checkout Payment Settings Response

Checkout Payment Settings Response

## Structure

`GetCheckoutPaymentSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuccessUrl` | `string` | Required | Success Url |
| `PaymentUrl` | `string` | Required | Payment Url |
| `AcceptedPaymentMethods` | `List<string>` | Required | Accepted Payment Methods |
| `Status` | `string` | Required | Status |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | Customer |
| `Amount` | `int?` | Optional | Payment amount |
| `DefaultPaymentMethod` | `string` | Optional | Default Payment Method |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation Id |

## Example (as JSON)

```json
{
  "success_url": "success_url2",
  "payment_url": "payment_url6",
  "accepted_payment_methods": [
    "accepted_payment_methods3",
    "accepted_payment_methods4",
    "accepted_payment_methods5"
  ],
  "status": "status8",
  "customer": null,
  "amount": null,
  "default_payment_method": null,
  "gateway_affiliation_id": null
}
```

