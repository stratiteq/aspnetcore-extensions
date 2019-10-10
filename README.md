# Stratiteq.Extensions.AspNetCore

## Stratiteq.Extensions.AspNetCore 
Useful extension classes and methods for AspNetCore are found here.

### Stratiteq.Extensions.AspNetCore.ProblemDetailsExtensions.ProblemDetailsWithErrorCode
Extends the ProblemDetails class with an error code.

Properties:

| Property | Description |
|--|--|
| ErrorCode | Gets the unique code for identifying the specific error within this API. |

Methods:
| Method | Description |
|--|--|
| CreateException | Creates a ProblemDetailsWithErrorCodeException. |

### Stratiteq.Extensions.AspNetCore.ProblemDetailsExtensions.ProblemDetailsWithErrorCodeCollection
Collection of ProblemDetailsWithErrorCode objects. The error codes are guaranteed to be unique within this collection.

Methods:
| Method | Description |
|--|--|
| GetKeyForItem(ProblemDetailsWithErrorCode) ||

### ProblemDetailsWithErrorCodeException
Exception that contains a ProblemDetailsWithErrorCode object.
Properties:
| Property | Description |
|--|--|
| ProblemDetailsWithErrorCode | Gets the ProblemDetailsWithErrorCode instance. |

Methods:
| Method | Description |
|--|--|
| ClearSensitiveInfo | Clears data from the Title and Details fields in ProblemDetailsWithErrorCode |


## Stratiteq.Extensions.AspNetCore.Swagger
Extension methods making it easy to configure OAUTH2 for SwaggerUIOptions and SwaggerGenOptions on AspNetCore. 

### Published packages:

| Package | Status |
|--|--|
| Stratiteq.Extensions.AspNetCore | ![Stratiteq.Extensions.AspNetCore](https://stratiteq.vsrm.visualstudio.com/_apis/public/Release/badge/d18068de-fc0c-46b1-b3f2-f47df6b804d8/6/6) |
|Stratiteq.Extensions.AspNetCore.Swagger  | ![Stratiteq.Extensions.AspNetCore.Swagger](https://stratiteq.vsrm.visualstudio.com/_apis/public/Release/badge/d18068de-fc0c-46b1-b3f2-f47df6b804d8/7/7) |
