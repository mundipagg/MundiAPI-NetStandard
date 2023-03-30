
# Create Automatic Anticipation Settings Request

## Structure

`CreateAutomaticAnticipationSettingsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool` | Required | - |
| `Type` | `string` | Required | - |
| `VolumePercentage` | `int` | Required | - |
| `Delay` | `int` | Required | - |
| `Days` | `List<int>` | Required | - |

## Example (as JSON)

```json
{
  "enabled": false,
  "type": "type0",
  "volume_percentage": 62,
  "delay": 228,
  "days": [
    188,
    189,
    190
  ]
}
```

