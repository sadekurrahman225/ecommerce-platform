# Ecommerce Platform

A full-stack ecommerce application built with:
- **Backend:** ASP.NET Core 8 Web API
- **Frontend:** Angular 20
- **Database:** Microsoft SQL Server 2022
- **Cache:** Redis
- **Containerized:** Docker & Docker Compose
- **CI/CD:** GitHub Actions

## Repository Structure
- `backend/` — ASP.NET Core solution
- `frontend/` — Angular workspace
- `docs/` — ER diagrams, architecture docs
- `tests/` — Integration tests, Postman collections

## Getting Started
### Backend
```bash
cd backend/Ecom.Api
dotnet run

## Run with Docker
```bash
docker-compose -f docker-compose.dev.yml up --build

#If you’re editing backend C# code → rebuild container:
docker-compose -f docker-compose.dev.yml up --build api

#If you’re editing Angular code → rebuild frontend container:
docker-compose -f docker-compose.dev.yml up --build frontend

#If you just want to start everything:
docker-compose -f docker-compose.dev.yml up -d

#Dev 2 for hot-reload
docker-compose -f docker-compose.dev_hot_reload.yml up

#Prod for optimized start
docker-compose -f docker-compose.prod.yml up --build -d



