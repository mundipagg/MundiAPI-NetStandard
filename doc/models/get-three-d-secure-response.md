
# Get Three D Secure Response

3D-S payment authentication response

## Structure

`GetThreeDSecureResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mpi` | `string` | Required | MPI Vendor |
| `Eci` | `string` | Required | Electronic Commerce Indicator (ECI) (Opcional) |
| `Cavv` | `string` | Required | Online payment cryptogram, definido pelo 3-D Secure. |
| `TransactionId` | `string` | Required | Identificador da transação (XID) |
| `SuccessUrl` | `string` | Required | Url de redirecionamento de sucessso |

## Example (as JSON)

```json
{
  "mpi": "mpi2",
  "eci": "eci0",
  "cavv": "cavv4",
  "transaction_Id": "transaction_Id4",
  "success_url": "success_url2"
}
```

