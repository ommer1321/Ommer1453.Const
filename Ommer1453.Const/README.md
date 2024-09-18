# My Localizer Const NuGet Package

Açýk kaynak bir pakettir Ommer1453 ve HMZDRSN tarafýndan geliþtirilmiþtir.


# Messages Class Documentation

The `Messages` class provides a convenient way to manage application messages in multiple languages. It supports English and Turkish, allowing dynamic message retrieval based on the specified language.

## Features

- **Multi-language support**: English (`en`) and Turkish (`tr`).
- **Language-based message return**: The class automatically returns messages in the appropriate language based on the user's input.
- **Default language fallback**: If an unsupported or missing language is provided, the class defaults to Turkish.

## Usage

### 1. Class Initialization

You can create a new instance of the `Messages` class by passing the desired language code (`en` for English, `tr` for Turkish):

```csharp
var messages = new Messages("en"); // For English
var messages = new Messages("tr"); // For Turkish
```