
#region EXERCISE 1
/*  
 Create a class Song with:

Title
Length
Genre(enum: Rock, Hip_Hop, Techno, Classical)
Create a class Person with:

Id
FirstName
LastName
Age
FavoriteMusicType (Genre enum)
FavoriteSongs(List of Songs)
Create a method called GetFavSongs() that:

Prints all titles of favorite songs
Or prints a message that the person hates music if the list is empty

*/




using Class08.Song_List.NewFolder;

Song s1 = new Song("Thunderstruck", 292, Genre.Rock);
Song s2 = new Song("Back in Black", 255, Genre.Rock);
Song s3 = new Song("Lose Yourself", 326, Genre.Hip_hop);


Person alice = new Person(1, "Alice", "Smith", 28, Genre.Rock, new List<Song> { s1, s2 });
Person igor = new Person(1, "Igor", "Petkov", 34, Genre.Rock, new List<Song>());


alice.GetFavSongs();
Console.WriteLine("---------------------------------");
igor.GetFavSongs();










#endregion