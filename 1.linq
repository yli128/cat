<Query Kind="Statements">
  <Connection>
    <ID>c2d1964e-d82d-4373-97eb-7be1ce2598c1</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
						where a.ArtistId == 1
						orderby a.Name
						select new
						{
						 Artist = a.Name,
						 Albums = from t in a.Albums
						 		  orderby t.Title
								  select new
							{
								Title = t.Title,
								Tracks = from tr in t.Tracks
								select new
								{
									TrackName = tr.Name,
									GenreId = tr.GenreId,
									Composer = tr.Composer,
									Milliseconds = tr.Milliseconds
								}
							}
						 };
			results.Dump();