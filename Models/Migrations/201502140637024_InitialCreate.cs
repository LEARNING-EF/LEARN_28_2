namespace Models.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class InitialCreate : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.People",
				c => new
					{
						Id = c.Guid(nullable: false),
						Age = c.Int(nullable: false),
						FullName = c.String(),
					})
				.PrimaryKey(t => t.Id);
		}

		public override void Down()
		{
			DropTable("dbo.People");
		}
	}
}
