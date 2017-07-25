pipeline {
  agent any
  stages {
    stage('Checkout') {
      steps {
        sh 'checkout scm'
      }
    }
    stage('Build') {
      steps {
        sh 'bat \'msbuild.exe "C#/CheckConverter.sln"\''
      }
    }
    stage('Test') {
      steps {
        sh 'bat \'vstest.console.exe "C#/CheckConverter.Tests/bin/Debug/CheckConverter.Tests.dll" /Logger:trx\''
      }
    }
  }
}