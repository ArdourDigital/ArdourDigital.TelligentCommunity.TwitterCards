# Twitter Cards for Telligent Community

![Build Status](https://ardourdigital.visualstudio.com/_apis/public/build/definitions/8b5ba8e6-4059-46da-8ac1-e2bcf922c889/6/badge)

Twitter Card plugin for Telligent Community.

Telligent Community 9 comes with improved SEO and Open Graph support, but does not add the tags required to show a preview of content when the content is tweeted. For this to happen you need an additional `twitter:card` and `twitter:site` meta tag, these will work with the title and description tags already output to give a preview of the content.

![Example tweet with picture](https://raw.githubusercontent.com/ArdourDigital/ArdourDigital.TelligentCommunity.TwitterCards/master/Assets/example.PNG)

## Supported Versions
This plugin should work with the following versions of Telligent Community
- Telligent Community 9.x

## Installation

You can install the plugin by [downloading the latest version](https://github.com/ArdourDigital/ArdourDigital.TelligentCommunity.TwitterCards/releases/latest) and adding it to your sites `bin` folder, or if you are using Visual Studio you can use nuget:

```
Install-Package ArdourDigital.TelligentCommunity.TwitterCards
```

The plugin can then be enabled by logging in as an administrator, and going to `Administration` > `Extensions` and finding `Ardour Digital - Twitter Cards`. 

Before enabling the plugin you must enter the twitter username that represents the site (including the `@` sign), check the `Enabled` check box, and `Save`.

![Example tweet with picture](https://raw.githubusercontent.com/ArdourDigital/ArdourDigital.TelligentCommunity.TwitterCards/master/Assets/plugin-configuration.png)

Once the plugin is enabled add the `Twitter Card Details` widget to the site wide header or footer (and ensure it is locked so it is used by all pages).

## Features

### Image Selection
For Media Gallery content and Blog Posts in Telligent 9 you can specify an image to use for Open Graph applications such as Twitter. Other content types don't currently allow this.

If no Open Graph image is selected the plugin will check if the content is featured, if so the Featured Image will be used if specified.

If no image is still found, and the content is a Blog Post, Forum Thread or Media item, and has an attached image, then that image will be used.

### Card Type
If an image is found, then the Twitter Card type is specified as being a [Summary Card with Large Image](https://dev.twitter.com/cards/types/summary-large-image), otherwise it will be a standard [Summary Card](https://dev.twitter.com/cards/types/summary).

### Author Username
Twitter cards allow an additional username to be supplied, which represents the author of the specific content. If the author of the content has a Twitter URL specified in there profile then this will be added to the Twitter Card.
