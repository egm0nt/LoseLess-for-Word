# LoseLess

Smart and easy-to-use Add-In for Microsoft Office Word for text recovering if keyboard layout was wrong

## Overview
 
The algorithm is pretty simple and it is based on character replacement according the chosen keyboard layout. LoseLess is an enclosure to the algorithm – beautiful Microsoft Office Word plugin with some features and settings.

You can:
- rely on our automatic language detector, or
- manually switch the languange necessary
- normalize Letter Case in text
- undo the recovery

> **Features**.
> 
> Text is in wrong keyboard layout? Don't lose it again! Just select it and press "Recovery text". LoseLess will do the dirty work for you.
>
> **Performance**.
> 
> LoseLess recovers 10,000 words 100x faster that Usain Bolt runs 200 meters*.
>
> **Intellect**.
> 
> LoseLess knows that "ghbdtn" is "привет" and "рщц фку нщг," is "how are you?".

This project also contains the ready project for Visual Studio (Lossless.csproj).

## Language support

Currently, LoseLess supports english and russian only. The main difficulty is connected with the support of keyboard layout – special letters. At current state we are limited with the VSTO API, and it is imposible to track when system keys are pressed. Therefore it is impossible to track when the special letters like ā or š are used.

Nevertheless, LoseLess is localized to english, russian and latvian. The plugin detects the language automatically, according the system language of the Word app. Feel free to add other localizations.

## How to use

There are two ways to add LoseLess to your Word app:

- Find *publish* folder and run setup.exe. Setup will set up everything automatically.
- Find *publish* folder and manually add LoseLess.vsto to the office app by opening the Add-In settings in Insert section.

**IMPORTANT:** this version of LoseLess supports Microsoft Office Word for Microsoft Windows only.



\* *Based on 2009 Usain Bolt 200m World Record (19.19 seconds) and LoseLess algorithm speed (~3700000 symbols per second, 7.4 symbols per word). Tested on machine with Intel Pentium P6100 processor, 2Gb RAM, Microsoft Windows 10 Enterprise LTSB 64-bit. LoseLess IgnoreCase switched on.*
