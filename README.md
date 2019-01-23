# GreateQuotes

Xamarin Forms Application which use Factory Pattern

This App has iOS, Android, Windows projects and shareable code in a Portable Class Library (PCL), using the Factory Pattern to isolate the platform-specific code to read and write the storage file used to display quotes.

We defined a service for performing text-to-speech and then create a Service Locator to find the implementation of that service which is platform-specific. This is intended to be done as part of the online class

<img src="/ScreenShots/1.PNG"/>
