@echo off
	setlocal enabledelayedexpansion
	SET /P avatarName=AvatarName (Without Extensions) : 
	echo.
	if "%avatarName%"=="" (
		goto :eof
	) else (
		if exist "%CD%\Framework.txt" (
			echo %CD%\Framework.txt
			echo to %CD%\%avatarName%.txt
			copy "%CD%\Framework.txt" "%CD%\%avatarName%.txt"
		) else (
			echo doesnt exist
		)
	)
