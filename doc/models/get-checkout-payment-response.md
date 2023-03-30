
# Get Checkout Payment Response

Resposta das configurações de pagamento do checkout

## Structure

`GetCheckoutPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Amount` | `int?` | Optional | Valor em centavos |
| `DefaultPaymentMethod` | `string` | Required | Meio de pagamento padrão no checkout |
| `SuccessUrl` | `string` | Required | Url de redirecionamento de sucesso após o checkou |
| `PaymentUrl` | `string` | Required | Url para pagamento usando o checkout |
| `GatewayAffiliationId` | `string` | Required | Código da afiliação onde o pagamento será processado no gateway |
| `AcceptedPaymentMethods` | `List<string>` | Required | Meios de pagamento aceitos no checkout |
| `Status` | `string` | Required | Status do checkout |
| `SkipCheckoutSuccessPage` | `bool` | Required | Pular tela de sucesso pós-pagamento? |
| `CreatedAt` | `DateTime` | Required | Data de criação |
| `UpdatedAt` | `DateTime` | Required | Data de atualização |
| `CanceledAt` | `DateTime?` | Optional | Data de cancelamento |
| `CustomerEditable` | `bool` | Required | Torna o objeto customer editável |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | Dados do comprador |
| `Billingaddress` | [`Models.GetAddressResponse`](../../doc/models/get-address-response.md) | Required | Dados do endereço de cobrança |
| `CreditCard` | [`Models.GetCheckoutCreditCardPaymentResponse`](../../doc/models/get-checkout-credit-card-payment-response.md) | Required | Configurações de cartão de crédito |
| `Boleto` | [`Models.GetCheckoutBoletoPaymentResponse`](../../doc/models/get-checkout-boleto-payment-response.md) | Required | Configurações de boleto |
| `BillingAddressEditable` | `bool` | Required | Indica se o billing address poderá ser editado |
| `Shipping` | [`Models.GetShippingResponse`](../../doc/models/get-shipping-response.md) | Required | Configurações  de entrega |
| `Shippable` | `bool` | Required | Indica se possui entrega |
| `ClosedAt` | `DateTime?` | Optional | Data de fechamento |
| `ExpiresAt` | `DateTime?` | Optional | Data de expiração |
| `Currency` | `string` | Required | Moeda |
| `DebitCard` | [`Models.GetCheckoutDebitCardPaymentResponse`](../../doc/models/get-checkout-debit-card-payment-response.md) | Optional | Configurações de cartão de débito |
| `BankTransfer` | [`Models.GetCheckoutBankTransferPaymentResponse`](../../doc/models/get-checkout-bank-transfer-payment-response.md) | Optional | Bank transfer payment response |
| `AcceptedBrands` | `List<string>` | Required | Accepted Brands |

## Example (as JSON)

```json
{
  "id": "id0",
  "amount": null,
  "default_payment_method": "default_payment_method0",
  "success_url": "success_url2",
  "payment_url": "payment_url6",
  "gateway_affiliation_id": "gateway_affiliation_id4",
  "accepted_payment_methods": [
    "accepted_payment_methods3",
    "accepted_payment_methods4",
    "accepted_payment_methods5"
  ],
  "status": "status8",
  "skip_checkout_success_page": false,
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "canceled_at": null,
  "customer_editable": false,
  "customer": null,
  "billingaddress": {
    "id": "id8",
    "street": "street8",
    "number": "number6",
    "complement": "complement4",
    "zip_code": "zip_code2",
    "neighborhood": "neighborhood4",
    "city": "city8",
    "state": "state4",
    "country": "country2",
    "status": "status0",
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
    "customer": null,
    "metadata": {
      "key0": "metadata5"
    },
    "line_1": "line_18",
    "line_2": "line_26",
    "deleted_at": null
  },
  "credit_card": {
    "statementDescriptor": "statementDescriptor4",
    "installments": [
      {
        "number": "number1",
        "total": 167
      }
    ],
    "authentication": {
      "type": "type0",
      "threed_secure": {
        "mpi": "mpi0",
        "eci": "eci2",
        "cavv": "cavv8",
        "transaction_Id": "transaction_Id2",
        "success_url": "success_url4"
      }
    }
  },
  "boleto": {
    "due_at": "2016-03-13T12:52:32.123Z",
    "instructions": "instructions2"
  },
  "billing_address_editable": false,
  "shipping": {
    "amount": 52,
    "description": "description6",
    "recipient_name": "recipient_name2",
    "recipient_phone": "recipient_phone6",
    "address": {
      "id": "id0",
      "street": "street0",
      "number": "number8",
      "complement": "complement6",
      "zip_code": "zip_code4",
      "neighborhood": "neighborhood6",
      "city": "city0",
      "state": "state6",
      "country": "country4",
      "status": "status2",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
      "customer": null,
      "metadata": {
        "key0": "metadata7"
      },
      "line_1": "line_14",
      "line_2": "line_28",
      "deleted_at": null
    },
    "max_delivery_date": null,
    "estimated_delivery_date": null,
    "type": "type6"
  },
  "shippable": false,
  "closed_at": null,
  "expires_at": null,
  "currency": "currency0",
  "debit_card": null,
  "bank_transfer": null,
  "accepted_brands": [
    "accepted_brands8",
    "accepted_brands9"
  ]
}
```

