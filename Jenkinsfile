pipeline {
    agent any
    triggers {
      cron("*/3 * * * *")
    }
    stages{
      stage("Build") {
        steps {
            sh "dotnet build CalculatorPipeline.sln"
        }
      }
      stage("Test") {
        steps {
              sh "dotnet test Tests/Tests.csproj"
        }
      }
   } 
}

