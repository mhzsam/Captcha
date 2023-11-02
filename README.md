### Features

- Cross Platform 
- Support Linux , Windows , Mac , Container
- easy use
- Automatic token expiration using MemoryCache
- Automatic download of the required font

# CrossPlatform.Captcha
![](https://github.com/mhzsam/Captcha/blob/main/image/mhz.jpg)

##### Links:
[github](https://github.com/mhzsam/Captcha)
[Contact me](mailto:mhzsam@gmail.com)
[Nuget](https://www.nuget.org/packages/CrossPlatform.Captcha)


### Installation by Nuget

`dotnet add package CrossPlatform.Captcha`

----
## generate captcha 

for the first time, if the required font is not available, it will find it and install it , then it will use the same font every time.

Also, the model that returns us is a **CaptchaToken** and **Base64Image**.

- CaptchaToken is unique  used for Validation.
- Base64Image is produced in 200*100 pixels.
- By default, the token is deleted from the memory or its expiration time is 60 seconds.

```csharp
Model.GetCaptchaModel getResult = CaptchaHelper.GetCaptcha()
```

----
## generate captcha by expire time 

for example 124 second

```csharp
Model.GetCaptchaModel getResult = CaptchaHelper.GetCaptcha(124)
```
----
## Validate Captcha
```csharp
Model.ValidateCaptchaModel validateModel = new Model.ValidateCaptchaModel();
validateModel.CaptchaToken = " The CaptchaToken you found while generate the captcha ";
validateModel.Key = " The value  you see in the image generated from Base64Image ";
bool ValidateResult = CaptchaHelper.ValidateCaptcha(validateModel);

```

If you enter the CaptchaToken and enter its Key **incorrectly**, the token will expire



----
## Sample photo created


![](https://github.com/mhzsam/Captcha/blob/main/image/i1.png?raw=true)
![](https://github.com/mhzsam/Captcha/blob/main/image/i2.png?raw=true)
![](https://github.com/mhzsam/Captcha/blob/main/image/i3.png?raw=true)


### End