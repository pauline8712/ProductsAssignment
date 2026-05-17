# ProductsAssignment — Clean Architecture Web API

Ett ASP.NET Core Web API byggt med Clean Architecture, CQRS, MediatR, Repository Pattern och Entity Framework Core med SQL Server.

## Tekniker

- **ASP.NET Core 8** — Web API
- **Entity Framework Core** — ORM för databashantering
- **MediatR** — CQRS-mönster med Commands och Queries
- **AutoMapper** — Mapping mellan entiteter och DTOs
- **FluentValidation** — Validering av inkommande data
- **Swagger UI** — API-dokumentation
- **SQL Server (LocalDB)** — Databas

## Projektstruktur

```
ProductsAssignment/
  Assignment.API/           ← Controllers, Program.cs, appsettings.json
  Assignment.Application/   ← Commands, Queries, Handlers, DTOs, Mappings
  Assignment.Domain/        ← Entiteter, Interfaces
  Assignment.Infrastructure/ ← DbContext, Repository, Migrations
```

## Modeller

- **Product** — Id, Name, Price, CategoryId
- **Category** — Id, Name
- En kategori kan ha många produkter (1-till-många)

## API Endpoints

| Method | Endpoint | Beskrivning |
|--------|----------|-------------|
| GET | `/api/products` | Hämtar alla produkter |
| GET | `/api/products/{id}` | Hämtar en produkt via Id |
| POST | `/api/products` | Skapar en ny produkt |
| PUT | `/api/products/{id}` | Uppdaterar en befintlig produkt |
| DELETE | `/api/products/{id}` | Tar bort en produkt |

## Kom igång

### Krav
- Visual Studio 2022
- .NET 8 SDK
- SQL Server LocalDB (ingår i Visual Studio)

### Installation

1. Klona repot:
```bash
git clone https://github.com/pauline8712/ProductsAssignment.git
```

2. Öppna `Inlämningsuppgift.sln` i Visual Studio

3. Lägg till connection string via User Secrets i `Assignment.API`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AssignmentDb;Trusted_Connection=True;"
  }
}
```

4. Kör migrations i Package Manager Console:
```
Update-Database -Project Assignment.Infrastructure -StartupProject Assignment.API
```

5. Sätt `Assignment.API` som startup-projekt och kör applikationen

6. Swagger UI öppnas på `https://localhost:7241/swagger`
