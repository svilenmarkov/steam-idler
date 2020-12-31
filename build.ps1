if (-not (Test-Path 'build')) {
    New-Item -Path . -Name 'build' -ItemType "directory" | Out-Null
}

$cscOutput = csc `
    -nologo `
    -out:build\idler.exe `
    -reference:lib\Steamworks.NET.dll `
    -recurse:src\*.cs

if (!$cscOutput) {
    Copy-Item lib\*.dll -Destination build\
    Write-Host "Build successful"
} else {
    Write-Host $cscOutput
}
