
# Get Pricing Scheme Response

Response object for getting a pricing scheme

## Structure

`GetPricingSchemeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Price` | `int` | Required | - |
| `SchemeType` | `string` | Required | - |
| `PriceBrackets` | [`List<Models.GetPriceBracketResponse>`](../../doc/models/get-price-bracket-response.md) | Required | - |
| `MinimumPrice` | `int?` | Optional | - |
| `Percentage` | `double?` | Optional | percentual value used in pricing_scheme Percent |

## Example (as JSON)

```json
{
  "price": 16,
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
  "minimum_price": null,
  "percentage": null
}
```

