namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (ID, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (4, 'HardCore')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (5, 'Punk')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (6, 'Celt')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (7, 'Metal')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (8, 'Country')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2 ,3 ,4 ,5 ,6 ,7 ,8)");
        }
    }
}
