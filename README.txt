Merhaba

Projede Kullanılan Teknolojiler: 
- EntityFrameworkCore
- swagger
- linq
- .netcore 2.2
- mssql
- katmanlı mimari

ekstra zamanım olsaydı ekleyeceklerim : 
- unitOfWork
- unit and acceptance test
- cachManager
- daha kapsamlı bir db
- daha kapsamlı bir mimari

db tablosunu oluşturmak için migration kullanabilirsiniz. Bunun için: 
- add-migration <migration name>	Add <migration name>	Creates a migration by adding a migration snapshot.
- Remove-migration	Remove	Removes the last migration snapshot.
- Update-database	Update	Updates the database schema based on the last migration snapshot.
- Script-migration	Script	Generates a SQL script using all the migration snapshots.
