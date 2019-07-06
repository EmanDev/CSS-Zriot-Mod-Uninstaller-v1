@shift /0
@echo off
color 0a
cls
echo.
echo ====================================================================================
echo This will remove ZOMBIE RIOT MOD on your Counter-Strike: Source Dedicated Server
echo Please put this file inside cstrike folder
echo ====================================================================================
echo.
echo ====================================================================================
echo Choose y to continue
echo Choose n to cancel and exit
echo ====================================================================================
echo. 
set /p m=Type y or n then press enter: 
if %m%==y goto continue
if %m%==n goto cancel
:continue
rmdir addons /s /q
rmdir "cfg/sourcemod" /s /q
rmdir materials /s /q
rmdir models /s /q
rmdir sound /s /q
cls
echo =============================
echo MOD Uninstalled Successfully
echo =============================
echo.
echo ==================================
echo Program Created by Emanzz Marcaida
echo ==================================
echo. 
echo.
set /p q=Type x to exit: 
if %q%==x goto exit
:exit
exit
:cancel
cls
echo.
echo ==================================
echo Program Created by Emanzz Marcaida
echo ==================================
echo.
echo You have canceled the operation
echo program will now exit
echo.
echo.
echo Press any key to exit
pause >nul
exit