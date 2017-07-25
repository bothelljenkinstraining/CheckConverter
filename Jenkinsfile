pipeline {
	agent { 
		label 'swarm' 
	}
	stages {
		stage ('Checkout') {
			steps {
				checkout scm
			}
		}
		stage ('Build') {
			steps {
				bat 'msbuild.exe "C#/CheckConverter.sln"'
			}
		}
		stage ('Test') {
			steps {
				bat 'vstest.console.exe "C#/CheckConverter.Tests/bin/Debug/CheckConverter.Tests.dll" /Logger:trx'
			}
		}
	}
}
