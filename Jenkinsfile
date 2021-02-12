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


    //  stage('Initialize') {
        //    steps {
                //enable remote triggers
         //       script {
         //           properties([pipelineTriggers([pollSCM('*/3 * * * ')])])
          //      }
                //define scm connection for polling
      //          git branch: master, credentialsId: 'my-credentials', url: 'ssh://git@stash.server.fqdn/stash/my-project.git'
         //   }
     //   }
    
