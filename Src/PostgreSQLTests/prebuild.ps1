function RunGenerator
{
  param ([string]$exeDir, [string]$dbType, [string]$destination)
  "exeDir=" + $exeDir
  "dbType=" + $dbType
  "destination=" + $destination
  Start-Process -FilePath "TestsGenerator.exe" -WorkingDirectory $exeDir -Wait -ArgumentList $dbType, `"$($destination)`"
}

RunGenerator $args[0] $args[1] $args[2]