node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat 'msbuild.exe "C#/CheckConverter.sln"'

	stage 'Test'
		bat 'vstest.console.exe "C#/CheckConverter.Tests/bin/Debug/CheckConverter.Tests.dll" /Logger:trx'
}