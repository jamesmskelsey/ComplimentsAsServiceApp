# Compliments As A Service
A simple API for retrieving compliments.

This project is built in C# using ASP.net Core 2.2. It mixes in a bit of MVC to an API controller. It's not meant to be fancy.
Just shows that this setup can be achieved.

It can return a JSON object or a simple HTML page that displays the compliment/message. Once run, the server serves up a few end points:

## /hello
Hello, world -Everyone

## /hello/{name}.{format?}
If .json is specified, returns an object. Otherwise shows a page.

## /cute/{name}/{from}.{format?}
If .json is specified, returns an object {"message": "Heeey, {name}, you're cute!", "subtitle": "{from}"}. Otherwise shows a simple page.


