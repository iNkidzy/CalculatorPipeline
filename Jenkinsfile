pipeline {
    stages {
        stage('Initialize') {
            steps {
                //enable remote triggers
                script {
                    properties([pipelineTriggers([pollSCM('*/3 * * * '')])])
                }
                //define scm connection for polling
                git branch: BRANCH_NAME, credentialsId: 'my-credentials', url: 'ssh://git@stash.server.fqdn/stash/my-project.git'
            }
        }
    }
}
