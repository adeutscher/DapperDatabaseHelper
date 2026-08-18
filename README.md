# DapperDatabaseHelper

Some helpful classes and methods to provide basic MySQL CRUD in Dapper without having to manually type every column.

Useful for large flat tables with basic data types like `uint` or `Guid` for keys.

## DEPRECATED

This repository is now deprecated and will no longer be maintained. Its contents have been folded into
my [RedShirt.Example.Api](https://github.com/adeutscher/RedShirt.Example.Api) ASP.NET API template in order to present
more of an all-in-one package that can be more easily deployed.

Some Dapper-related features within the API template:

* Less tightly-coupled to AWS, making adaptation easier
* [Roslyn](https://github.com/dotnet/roslyn) source generation for MariaDB/Dapper data-access scaffolding (services,
  repositories, search requests, and related DI) from annotated DTO models.