
# Create Three D Secure Request

Creates a 3D-S authentication payment

## Structure

`CreateThreeDSecureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mpi` | `string` | Required | The MPI Vendor (MerchantPlugin) |
| `Cavv` | `string` | Optional | The Cardholder Authentication Verification value |
| `Eci` | `string` | Optional | The Electronic Commerce Indicator value |
| `TransactionId` | `string` | Optional | The TransactionId value (XID) |
| `SuccessUrl` | `string` | Optional | The success URL after the authentication |
| `DsTransactionId` | `string` | Optional | Directory Service Transaction Identifier |
| `Version` | `string` | Optional | ThreeDSecure Version |

## Example (as JSON)

```json
{
  "mpi": "mpi2",
  "cavv": null,
  "eci": null,
  "transaction_id": null,
  "success_url": null,
  "ds_transaction_id": null,
  "version": null
}
```

