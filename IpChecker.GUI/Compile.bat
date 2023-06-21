@echo off
title Compile
cls
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /target:winexe /win32icon:Resources\Icon.ico /out:IpChecker.GUI.exe *.cs
pause