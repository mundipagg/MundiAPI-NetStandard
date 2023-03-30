
# Create Emv Data Decrypt Request

## Structure

`CreateEmvDataDecryptRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cipher` | `string` | Required | Emv Decrypt cipher type |
| `Dukpt` | [`Models.CreateEmvDataDukptDecryptRequest`](../../doc/models/create-emv-data-dukpt-decrypt-request.md) | Optional | Dukpt data request |
| `Tags` | [`List<Models.CreateEmvDataTlvDecryptRequest>`](../../doc/models/create-emv-data-tlv-decrypt-request.md) | Required | Encrypted tags list |

## Example (as JSON)

```json
{
  "cipher": "cipher4",
  "dukpt": null,
  "tags": [
    {
      "tag": "tag9",
      "lenght": "lenght7",
      "value": "value7"
    },
    {
      "tag": "tag0",
      "lenght": "lenght8",
      "value": "value8"
    }
  ]
}
```

