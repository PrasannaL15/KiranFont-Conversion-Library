# Kiran Font Library

![Kiran Font Logo](http://kiranfont.somee.com/img/kiranfont.gif)

## Introduction

The Kiran Font Library is a C# DLL that enables developers to convert text between the KiranFont Marathi script and Unicode. KiranFont is a widely used script for Marathi language, and this library makes it easier to work with KiranFont text in your C# applications. This library provides functions for both converting KiranFont to Unicode and Unicode to KiranFont, making it a versatile tool for handling Marathi text in different formats.

## Features

- **KiranFont to Unicode Conversion:** Easily convert text written in the KiranFont Marathi script to Unicode, making it compatible with modern systems and applications.

- **Unicode to KiranFont Conversion:** Convert Unicode text to the KiranFont Marathi script, allowing you to work with KiranFont text in your applications.

- **Simple API:** The library provides a simple and easy-to-use API for converting text, making it straightforward for developers to integrate into their applications.


## Installation

To use the Kiran Font Library in your C# project, follow these steps:

1. Import the necessary namespace at the top of your C# file:

   ```csharp
   using KF2Uni; // Import the Kiran Font Library namespace

Create an instance of the KiranFont class:

  ```csharp
  KiranFont obj = new KiranFont();
  ```

Use the convertKFkiran2Uni method to convert KiranFont text to Unicode:

  ```csharp
  
  string input = textBox1.Text; // Get KiranFont text from your input source
  string output = obj.convertKFkiran2Uni(input); // Convert KiranFont to Unicode
  textBox2.Text = output; // Display the Unicode text in your output element
  
  ```
Here, textBox1 is the input TextBox where you enter KiranFont text, and textBox2 is the output TextBox where the converted Unicode text is displayed.

Optionally, you can save the converted text to a file:

  ```csharp
  string OutputFilePath = textBox3.Text; // Get the file path from your input source
  File.WriteAllText(OutputFilePath, textBox2.Text); // Save the Unicode text to a file
  ```
In this case, textBox3 is a TextBox where the user can specify the output file path.

Example
Here's a basic example of how to use the Kiran Font Library in your Windows Forms application:

  ```csharp
  using KF2Uni;
  
  // Create an instance of KiranFont
  KiranFont obj = a KiranFont();
  
  // Get KiranFont text from a TextBox or another input source
  string input = textBox1.Text;
  
  // Convert KiranFont to Unicode
  string output = obj.convertKFkiran2Uni(input);
  
  // Display the Unicode text in a TextBox or another output element
  textBox2.Text = output;
  
  // Optionally, save the Unicode text to a file
  string OutputFilePath = textBox3.Text;
  File.WriteAllText(OutputFilePath, textBox2.Text);
  ```
