$whatSheSaid = Read-Host 'Please enter "yes" or "no"'

# input is actually not important, just wasting time!!!
Remove-Variable whatSheSaid

$rnd = Get-Random -Maximum 2

if($rnd -eq 1){
    Write-Host "50% sure real answer is "No""
}
else{
    Write-Host "50% sure real answer is "Yes""
}