namespace OneiricGigs.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES(1,'Folk') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES(2,'Metal') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES(3,'Vaporvawe') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES(4,'Jazz') ");
        }

       

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
