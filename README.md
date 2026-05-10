<h1 align="center">
  <a>Gedaq</a>
</h1>
<h1 align="center">
  <a href="https://discord.gg/xsR5EYU4ZM"><img height="30px" src="https://img.shields.io/badge/Discord-7289DA?style=for-the-badge&logo=discord&logoColor=white"><img></a>
</h1>
<h3 align="center">

  [![Nuget](https://img.shields.io/nuget/v/Gedaq?logo=Gedaq)](https://www.nuget.org/packages/Gedaq/)
  [![Downloads](https://img.shields.io/nuget/dt/Gedaq.svg)](https://www.nuget.org/packages/Gedaq/)
  [![Stars](https://img.shields.io/github/stars/SoftStoneDevelop/Gedaq?color=brightgreen)](https://github.com/SoftStoneDevelop/Gedaq/stargazers)
  [![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

</h3>

Generator for obtaining and mapping data from the database.
Generates methods (synchronous and/or asynchronous):
- Creating a Command for a query
- Method of setting parameters in a Command
- Command execution, with data mapping

- Creating a QueryBatch Command
- Setting parameters in a QueryBatch Command
- Get data from a batch Command
- Receiving data from a batch of queries, with data mapping

- Getting data based on a query, with data mapping

There are versions for all of these methods (if possible):
- Query
- NonQuery
- ЕecuteScalar (return type is determined automatically at the generation stage)
<br>
Both static and dynamic queries are supported. Dynamic parameters are supported. Multi-mapping is supported.
It also generates methods specific to each provider, such as BinaryImport and BinaryExport in PostgreSQL.

Supported databases(see examples and documentation in the relevant DB package):<br>
- [Npgsql](https://github.com/SoftStoneDevelop/Gedaq.Npgsql)
- [DbConnection](https://github.com/SoftStoneDevelop/Gedaq.DbConnection)
- [SqlClient](https://github.com/SoftStoneDevelop/Gedaq.SqlClient)
- [MySqlConnector](https://github.com/SoftStoneDevelop/Gedaq.MySqlConnector)
- [Clickhouse.Driver]()
- [Oracle.ManagedDataAccess.Core](https://github.com/SoftStoneDevelop/Gedaq/issues/6)
<br>
