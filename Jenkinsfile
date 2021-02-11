pipeline {
    agent any
    triggers {
      cron("*/3 * * * *")
    }
    stages{
      stage("Build") {
        steps {
            sh "dotnet build CalculatorPipeline.sln"
              unstable    "Build phase not implemented"
        }
      }
      stage("Test") {
        steps {
              unstable    "Test phase not implemented"
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
    
