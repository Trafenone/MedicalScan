# MedicalScan Application

This repository contains the source code and configuration for the MedicalScan application. Below are instructions on how to run the application using Docker or by modifying the `appsettings.json` file.

## Getting Started

### Prerequisites

Before you begin, ensure that you have Docker installed on your machine. You can download Docker [here](https://www.docker.com/get-started).

### Clone the Repository

```bash
git clone https://github.com/Trafenone/MedicalScan.git
cd MedicalScan
```

You can also download the repository as a [zip](https://codeload.github.com/Trafenone/MedicalScan/zip/refs/heads/master).

### Docker

#### 1. Build Docker Images

```bash
docker-compose build
```

#### 2. Run Docker Containers

```bash
docker-compose up -d
```

This will start two containers: one for the SQL Server database (medical-scan-db) and another for the MedicalScan application (medical-scan).

#### 3. Access the Application

Open your web browser and go to http://localhost:8001 to access the MedicalScan application.

#### 4. Stopping the Containers

To stop the containers, run:

```bash
docker-compose down
```

### Manual Setup

If you prefer to run the application without Docker:

#### 1. Update Connection String

Open the MedicalScan/appsettings.json file and update the ConnectionStrings__DataConnection property with your SQL Server connection string.

Example:
```bash
"ConnectionStrings": {
    "DataConnection": "[your-connection-string]"
}
```

#### 2. Run the Application

```bash
dotnet run --project MedicalScan
```

Open your web browser and go to http://localhost:5252 to access the MedicalScan application.
