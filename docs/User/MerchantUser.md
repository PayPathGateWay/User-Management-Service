# Merchant Authentication API

This API manages merchant registration, login, logout, token management, and token-related helper functions.


----------------------------------------------------------------
## Merchant Management
### Get Merchant Info Request
```json
{
    "MerchantId": "2313-dasdasd-2313asdd", 
}
```

### Response
``` json
{
    "MerchantName": "Slman Ahmed", 
    "EmailAddress": "slman@jirar.com",
    "Password": "slam@#dad@#123a", 
    "PlatformName": "jirar", 
    "PlatformLogo": "file://logo.svg",
    "PhoneNumber": 966555288598
}
```

### Delet Merchant Request
```json
{
    "MerchantId": "2313-dasdasd-2313asdd", 
}
```

### Response
``` json

{
    "message": "Successfully Merchant Deleted",
    "status": 200
}
```

### Update Merchant Request
```json
{
    "MerchantName": "New Name", 
    "Password": "new Password", 
    "PlatformName": "new Platform Name", 
    "PlatformLogo": "new Logo",
}
```

### Response
``` json
{
    "message": "Successfully Merchant Updated",
    "status": 200
}
```
----------------------------------------------------------------

## Merchant Register

###  Request
```json
{
    "MerchantName": "Slman Ahmed", 
    "EmailAddress": "slman@jirar.com",
    "Password": "slam@#dad@#123a", 
    "PlatformName": "jirar", 
    "PlatformLogo": "file://logo.svg",
    "PhoneNumber": 966555288598
}
```
### Response
``` json

{
    "id": "2313-dasdasd-2313asdd",
    "SecretToken": "adajsdkajsdaoisdhjio1u3123ioiasdkjaskdhajs",
    "RefreshToken": "adasdadadad2324j3iok#U()#$UUDJS)(U#(_@U#",
    "expiresIn": 3600
}
```
----------------------------------------------------------------

## Merchant Login
### Request

``` json

{
    "EmailAddress": "slman@jirar.com",
    "Password": "slam@#dad@#123a"
    // Or
    "SecretToken": "adajsdkajsdaoisdhjio1u3123ioiasdkjaskdhajs"
}
````
### Response

```` json

{
    "id": "2313-dasdasd-2313asdd",
    "SecretToken": "adajsdkajsdaoisdhjio1u3123ioiasdkjaskdhajs",
    "RefreshToken": "adasdadadad2324j3iok#U()#$UUDJS)(U#(_@U#",
    "expiresIn": 3600
}
````
----------------------------------------------------------------

## Merchant Logout
### Request

``` json

{
    "EmailAddress": "slman@jirar.com",
    "SecretToken": "adajsdkajsdaoisdhjio1u3123ioiasdkjaskdhajs"
}
```
## Response

``` json

{
    "message": "Successfully logged out",
    "status": 200
}
``` 
----------------------------------------------------------------

## Token Management

### Refresh Token Request

``` json

{
    "RefreshToken": "adasdadadad2324j3iok#U()#$UUDJS)(U#(_@U#"
}
```
Response

``` json

{
    "NewSecretToken": "asdjalskdajskldaj123",
    "NewRefreshToken": "newRefreshToken324jo32",
    "expiresIn": 3600
}
``` 

## Helper Endpoint
### Check Token Validity Request

``` json

{
    "SecretToken": "adajsdkajsdaoisdhjio1u3123ioiasdkjaskdhajs"
}
```
## Response

``` json

{
    "isValid": true,
    "expiresIn": 1800
}
```