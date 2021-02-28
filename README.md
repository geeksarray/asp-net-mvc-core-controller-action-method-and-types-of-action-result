# ASP.NET MVC Core Controller Action Method and Types of Action Result
 This blog explains what is MVC Controller, Action Method, and different types of ActionResult like HTML returning, Content,  
 Redirect, File, Status Code, Security related.
 
## What is ASP.NET MVC Core Controller
The controller is an MVC component responsible to handle user actions, work with required models for business rule processing and render a specific view. 
Controller classes are by default added to the project's Controllers folder. If you are having MVC Area, then you will have a Controller under Area to provide a logical grouping of similar actions. Controller classes are inherited from Microsoft.AspNetCore.MVC.Controller.

## Important Files
1. [HomeController](https://github.com/geeksarray/asp-net-mvc-core-controller-action-method-and-types-of-action-result/blob/main/ActionResultTypes/Controllers/HomeController.cs) - All action result that returns ViewResult, ContentResult, RedirectResult, FileResult, StatusCodeResult implemented in this controller.


The Result of RedirectResult Action Result

![asp-net-core-mvc-redirectresult](https://geeksarray.com/images/blog/asp-net-core-mvc-redirectresult.png)

Fore more detailed description please visit - https://geeksarray.com/blog/asp-net-mvc-core-controller-action-method-and-types-of-action-result
