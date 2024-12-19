pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0'  // Specify the .NET version you're using
    }

    stages {
        stage('Checkout') {
            steps {
                // Checkout the code from GitHub
            git branch: 'main', url: 'https://github.com/Adhaammohammed/cicd-test.git'
            }
        }

        stage('Restore') {
            steps {
                // Restore dependencies for your .NET project
                script {
                    bat 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                // Build the project
                script {
                    bat 'dotnet build --configuration Release'
                }
            }
        }

        stage('Test') {
            steps {
                // Run unit tests using dotnet test
                script {
                    bat 'dotnet test --configuration Release'
                }
            }
        }

        stage('Publish') {
            steps {
                // Optional: Publish build artifacts if needed
                script {
                    bat 'dotnet publish --configuration Release --output ./publish'
                }
            }
        }
    }

    post {
        always {
            // Clean up after the build
            echo 'Cleaning up...'
        }
        success {
            // Actions on successful build
            echo 'Build and tests succeeded!'
        }
        failure {
            // Actions on build failure
            echo 'Build or tests failed!'
        }
    }
}
