# Pierre's Bakery - Vendor Order Tracker

#### A C# web application for a bakery owner, Pierre, to keep track the vendors that purchase baked goods from him and the orders belonging to those vendors.

#### By Jonathan Cheng

## Technologies Used

- _C#_
- _HTML_
- _.NET 6_
- _MSTest_
- _ASP.NET Core MVC_
- _Razor View Engine_

## Description

- _Upon landing on the splash page, the user is welcomed with a message "Welcome, Pierre!"._
- _To start, click `See vendors`. This will bring the user to a page displaying a list of vendors. There is an option to `Add a new vendor`. Here the user can fill out a form to add this vendor to the list._
- _Clicking a vendor on the list allows the user to add an order associated with this vendor -- after completion of a form._
- _This will display any and all existing orders associated with the vendor clicked previously. The user may choose to add more orders._
- _Clicking on any orders on this list of orders allows the user to see details of the order._
- _Data remains saved in the Models business logic files until the browser is closed or the terminal is no longer running the app._
- _This web application was written using C#, run using .NET framework, its business logic tested using MSTest, and its ability to run in a browser enabled using the ASP.NET Core MVC framework._
- _Key objectives include: C# basics, the Model-View-Controller (MVC) coding pattern, HTTP method GET and POST request/responses, and coverage of model logic using test-driven development (TDD)._

## Setup/Installation Requirements

_1. Open your terminal (e.g., Terminal or GitBash)._

_2. Navigate to where you want to place the cloned directory._

_3. Clone the repository from the GitHub link by entering in this command:_

> ```bash
> $ git clone https://github.com/joncheng-dev/order-tracker-C-
> ```

_4a. Navigate to the project's production directory `OrderTracker`. In the command line, run this command to compile and execute the web application. A new browser window should open, allowing you to interact with it._

> ```bash
> $ dotnet watch run
> ```

_4b. Optionally, to compile this web app without running it, enter:_

> ```bash
> $ dotnet build
> ```

_4c. To run tests, navigate to the project's test directory `OrderTracker.Tests` and execute the command:_

> ```bash
> $ dotnet test
> ```

## Known Bugs

- _Currently the `$ dotnet run` command does not open a browser window. Must use `$ dotnet watch run`, as specified in Setup/Installation Requirements step 4a. However, you can run `$dotnet run` and navigate to `https://localhost:5001` manually, which seems to work._
- _Please report any bugs you find with a message to joncheng.dev@gmail.com_

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) _2023_ _Jonathan Cheng_
