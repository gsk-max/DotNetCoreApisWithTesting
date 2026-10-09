pipeline {
    agent any
    environment {
        DOTNET_CLI_HOME="C:\\Program Files\\dotnet"
    }
    stages {
        stage("Checkout") {
            steps {
                checkout scm
            }

        }
        stage("Restore") {
            steps {
                bat "dotnet restore CoreApiDemo.slnx"
            }
        }

        stage("Build") {
            steps {
                bat "dotnet build CoreApiDemo.slnx --configuration Release"
            }
        }
        stage("Test") {
            steps {
                bat "dotnet test --no-restore --configuration Release"
            }
        }
        stage("Publish") {
            steps {
                bat "dotnet publish --no-restore --configuration Release --output .\\publish"
            }
        }
        stage("Deployment") {
            steps {
                // bat 'del /q /s "C:\\inetpub\\wwwroot\\WebApp\\"'
                // bat '"xcopy /E /Y /I "publish\\*" "C:\\inetpub\\wwwroot\\WebApp\\"'
                bat '''
                        if exist "C:\\inetpub\\wwwroot\\apiswithtesting" rmdir /q /s "C:\\inetpub\\wwwroot\\apiswithtesting"
                        mkdir "C:\\inetpub\\wwwroot\\apiswithtesting"
                    '''
                bat "C:\\Windows\\System32\\xcopy.exe /E /Y /I publish\\* C:\\inetpub\\wwwroot\\apiswithtesting\\"
            }
        }
    }
    post {
        success {
            echo "Build, Test, Publish Stages Completed Successfully."
        }
    }
}
