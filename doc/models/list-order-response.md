
# List Order Response

Response object for listing order objects

## Structure

`ListOrderResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.GetOrderResponse>`](../../doc/models/get-order-response.md) | Required | The order object |
| `Paging` | [`Models.PagingResponse`](../../doc/models/paging-response.md) | Required | Paging object |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id5",
      "code": "code3",
      "currency": "currency5",
      "items": [
        {
          "id": "id2",
          "amount": 180,
          "description": "description2",
          "quantity": 38,
          "category": "category0",
          "code": "code0"
        },
        {
          "id": "id3",
          "amount": 181,
          "description": "description3",
          "quantity": 39,
          "category": "category1",
          "code": "code1"
        }
      ],
      "customer": null,
      "status": "status7",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
      "charges": [
        {
          "id": "id1",
          "code": "code9",
          "gateway_id": "gateway_id1",
          "amount": 113,
          "status": "status3",
          "currency": "currency1",
          "payment_method": "payment_method1",
          "due_at": "2016-03-13T12:52:32.123Z",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "last_transaction": null,
          "invoice": null,
          "order": null,
          "customer": null,
          "metadata": {
            "key0": "metadata8",
            "key1": "metadata7"
          },
          "paid_at": null,
          "canceled_at": null,
          "canceled_amount": 223,
          "paid_amount": 205,
          "recurrency_cycle": null,
          "interest_and_fine_paid": null
        },
        {
          "id": "id2",
          "code": "code0",
          "gateway_id": "gateway_id2",
          "amount": 114,
          "status": "status4",
          "currency": "currency2",
          "payment_method": "payment_method2",
          "due_at": "2016-03-13T12:52:32.123Z",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "last_transaction": null,
          "invoice": null,
          "order": null,
          "customer": null,
          "metadata": {
            "key0": "metadata7",
            "key1": "metadata6",
            "key2": "metadata5"
          },
          "paid_at": null,
          "canceled_at": null,
          "canceled_amount": 224,
          "paid_amount": 206,
          "recurrency_cycle": null,
          "interest_and_fine_paid": null
        },
        {
          "id": "id3",
          "code": "code1",
          "gateway_id": "gateway_id3",
          "amount": 115,
          "status": "status5",
          "currency": "currency3",
          "payment_method": "payment_method3",
          "due_at": "2016-03-13T12:52:32.123Z",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "last_transaction": null,
          "invoice": null,
          "order": null,
          "customer": null,
          "metadata": {
            "key0": "metadata6"
          },
          "paid_at": null,
          "canceled_at": null,
          "canceled_amount": 225,
          "paid_amount": 207,
          "recurrency_cycle": null,
          "interest_and_fine_paid": null
        }
      ],
      "invoice_url": "invoice_url7",
      "shipping": null,
      "metadata": {
        "key0": "metadata4",
        "key1": "metadata3"
      },
      "checkouts": null,
      "ip": null,
      "session_id": null,
      "location": null,
      "device": null,
      "closed": true
    },
    {
      "id": "id6",
      "code": "code4",
      "currency": "currency6",
      "items": [
        {
          "id": "id3",
          "amount": 181,
          "description": "description3",
          "quantity": 39,
          "category": "category1",
          "code": "code1"
        },
        {
          "id": "id4",
          "amount": 182,
          "description": "description4",
          "quantity": 40,
          "category": "category2",
          "code": "code2"
        },
        {
          "id": "id5",
          "amount": 183,
          "description": "description5",
          "quantity": 41,
          "category": "category3",
          "code": "code3"
        }
      ],
      "customer": null,
      "status": "status8",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
      "charges": [
        {
          "id": "id2",
          "code": "code0",
          "gateway_id": "gateway_id2",
          "amount": 114,
          "status": "status4",
          "currency": "currency2",
          "payment_method": "payment_method2",
          "due_at": "2016-03-13T12:52:32.123Z",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "last_transaction": null,
          "invoice": null,
          "order": null,
          "customer": null,
          "metadata": {
            "key0": "metadata7",
            "key1": "metadata6",
            "key2": "metadata5"
          },
          "paid_at": null,
          "canceled_at": null,
          "canceled_amount": 224,
          "paid_amount": 206,
          "recurrency_cycle": null,
          "interest_and_fine_paid": null
        }
      ],
      "invoice_url": "invoice_url8",
      "shipping": null,
      "metadata": {
        "key0": "metadata3",
        "key1": "metadata2",
        "key2": "metadata1"
      },
      "checkouts": null,
      "ip": null,
      "session_id": null,
      "location": null,
      "device": null,
      "closed": false
    }
  ],
  "paging": {
    "total": 6,
    "previous": "previous2",
    "next": "next8"
  }
}
```

