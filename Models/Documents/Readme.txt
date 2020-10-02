قبل از اینکه اولین نسخه را به مشتری ارایه دهیم

تست می‌کنیم که
ConnectionString
هم در پروژه اصلی و هم در پروژه
Models
نوشته شده و یکسان باشند

ابتدا یک بار پروژه را اجرا کرده تا بانک اطلاعاتی (اگر وجود ندارد) ایجاد شود

از طریق
Tools --> Nuget Package Manager --> Package Manager Console
شده Nuget وارد محیط

از قسمت
Default Project
را انتخاب می‌کنیم Models پروژه

(1)

PM> Enable-Migrations

(2)

Edit Migrations\Configuration.cs File.

(3)

Note: The below codes should be in constructor of Migrations\Configuration.cs File

AutomaticMigrationsEnabled = false;
AutomaticMigrationDataLossAllowed = false;

(4)

In DatabaseContext.cs File

Comment the below code:

//System.Data.Entity.Database.SetInitializer
//	(new DatabaseContextInitializerBeforeTheFirstRelease());

(5)

Then write the below code:

System.Data.Entity.Database.SetInitializer
	(new System.Data.Entity.MigrateDatabaseToLatestVersion
		<DatabaseContext, Migrations.Configuration>());

(6)

حال یک بار پروژه را اجرا کرده تا ببینیم که هیچ مشکلی وجود ندارد

(7)

بانک اطلاعاتی را حذف کرده، و مجددا برنامه را اجرا می‌کنیم
تا ببینیم که هیچ مشکلی وجود ندارد
