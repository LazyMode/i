@echo off
pushd Release
powershell -ExecutionPolicy Bypass -File "..\package.ps1" "..\interfaces.nuspec" i
popd
echo.
echo Done.