param(
    [Parameter(Mandatory)]
    [ValidateNotNullOrEmpty()]
    [string] $DesiredVersion
)

$winPSVersion = "5.1"
$isWinPSDesired = $DesiredVersion -eq $winPSVersion

function InstallLiveTestDesiredPowerShell {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [string] $DesiredVersion
    )

    Write-Host "Validating desired PowerShell version."

    if ($isWinPSDesired) {
        powershell -NoLogo -NoProfile -NonInteractive -Command "(Get-Variable -Name PSVersionTable).Value"
        Write-Host "##[section]Desired Windows Powershell version $DesiredVersion has been installed."
    }
    else {
        Write-Host "##[section]Installing PowerShell version $DesiredVersion."

        dotnet --version
        dotnet new tool-manifest --force
        if ($DesiredVersion -eq "latest") {
            dotnet tool install powershell
        }
        else {
            dotnet tool install powershell --version $DesiredVersion
        }
        dotnet tool list

        dotnet tool run pwsh -Version

        Write-Host "##[section]Desired PowerShell version $DesiredVersion has been installed."
    }
}

& (Join-Path -Path ($PSScriptRoot | Split-Path) -ChildPath "Utilities" | Join-Path -ChildPath "CommonUtility.ps1")

Write-Host "Get-Module -Name Az"
Get-Module -Name Az

Write-Host "Get-Module -Name Az -ListAvailable"
Get-Module -Name Az -ListAvailable

Write-Host "Get-Module -Name AzureRM"
Get-Module -Name AzureRM

Write-Host "Get-Module -Name AzureRM -ListAvailable"
Get-Module -Name AzureRM -ListAvailable

InstallLiveTestDesiredPowerShell -DesiredVersion $DesiredVersion
