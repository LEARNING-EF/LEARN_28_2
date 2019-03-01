using System.Linq;
using System.Data.Entity;

namespace Models.Migrations
{
	internal sealed class Configuration :
		System.Data.Entity.Migrations.DbMigrationsConfiguration<DatabaseContext>
	{
		public Configuration() : base()
		{
			ContextKey = "Models.DatabaseContext";

			AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = false;
		}

		/// <summary>
		/// دقت داشته باشید که این تابع همیشه اجرا می شود
		/// حتی در صورتی که بانک اطلاعاتی وجود داشته باشد
		/// </summary>
		protected override void Seed(DatabaseContext databaseContext)
		{
			//base.Seed(databaseContext);

			//if (databaseContext.People.Count() != 0)
			//{
			//	return;
			//}

			// با تشکر از آقای فرشاد ربیعی
			if (databaseContext.People.Any())
			{
				return;
			}

			try
			{
				DatabaseContextInitializer.Seed(databaseContext);
			}
			catch
			{
			}
			//catch (System.Exception ex)
			//{
			//	Dtx.LogHandler.Report(GetType(), null, ex);
			//}
		}
	}
}
