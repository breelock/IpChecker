@echo off
title Compile
cls
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /win32icon:Resources\Icon.ico /t:exe /out:IpChecker.Console.exe *.cs
pause