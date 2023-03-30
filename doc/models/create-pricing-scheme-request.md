
# Create Pricing Scheme Request

Request for creating a pricing scheme

## Structure

`CreatePricingSchemeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SchemeType` | `string` | Required | Scheme type |
| `PriceBrackets` | [`List<Models.CreatePriceBracketRequest>`](../../doc/models/create-price-bracket-request.md) | Required | Price brackets |
| `Price` | `int?` | Optional | Price |
| `MinimumPrice` | `int?` | Optional | Minimum price |
| `Percentage` | `double?` | Optional | percentual value used in pricing_scheme Percent |

## Example (as JSON)

```json
{
  "scheme_type": "scheme_type0",
  "price_brackets": [
    {
      "start_quantity": 193,
      "price": 125,
      "end_quantity": null,
      "overage_price": null
    },
    {
      "start_quantity": 194,
      "price": 124,
      "end_quantity": null,
      "overage_price": null
    },
    {
      "start_quantity": 195,
      "price": 123,
      "end_quantity": null,
      "overage_price": null
    }
  ],
  "price": null,
  "minimum_price": null,
  "percentage": null
}
```

