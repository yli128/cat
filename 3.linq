<Query Kind="Statements">
  <Connection>
    <ID>c2d1964e-d82d-4373-97eb-7be1ce2598c1</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
						orderby x.Name
						select new
						{
						ID = x.ArtistId,
						Name = x.Name
						};
	results.Dump();