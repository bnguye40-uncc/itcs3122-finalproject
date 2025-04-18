# ITCS-3112-051 Final Project

Created by Benjamin Nguyen, 4/17/2025

This project built with C# within the web framework, Blazor. It uses a template for browser extensions made by **mingyaulee**. To learn more: https://mingyaulee.github.io/Blazor.BrowserExtension/

## Building the app

## Running the app on browser

The build for this project can be found within the following directory:
```\itcs3122-finalproject\FinalProject\bin\Debug\net9.0\browserextension```

To run the app, you can use any browser to load this project as a temporary add-on. Instructions can be found in the documentation for this template: https://mingyaulee.github.io/Blazor.BrowserExtension/running-and-debugging

> ### Google Chrome
> 1. Launch the Extensions page ( ⋮ → More tools → Extensions).
> 2. Switch on Developer mode.
> 3. Click on the Load unpacked button, then navigate to ```bin/Debug/net9.0``` and select the ```browserextension``` directory.

> ### Microsoft Edge
> 1. Launch the Extensions page ( ⋮ → Extensions).
> 2. Click on the ☰ and switch on Developer mode.
> 3. Click on the button with the title Load unpacked, then navigate to ```bin/Debug/net9.0``` and select the ```browserextension``` directory.

> ### Mozilla Firefox
> 1. Navigate to the URL ```about:debugging#/runtime/this-firefox```. You need to copy this link and paste it in the address bar.
> 2. Click on Load Temporary Add-on..., then navigate to ```bin/Debug/net9.0/browserextension``` and select any file in the directory. 
>    - For Mozilla Firefox, the extension manifest needs to be modified before you can load it. See Background Worker page: https://mingyaulee.github.io/Blazor.BrowserExtension/background-worker#mozilla-firefox
