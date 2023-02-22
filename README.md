# WEB315_Trekking_Locations_Asg_01

Student Name: Karamjit Sohal
Student ID: 0811863
Project Name: Assignment 01
Theme: Trekking

1. Private GitHub repository by name WEB315_Trekking_Locations_Asg_01 created

2. Proff Majid invited for collaboration @Majid1292

3. Razor webapp created in .net5 by name WEB315_Trekking_Locations_Asg_01

4. .gitignore & Readme.md files created respectively

5. Files comitted... 

6. Edited the default "Welcome" page to include:
    a. The name of my theme
    b. My name
    c. Date & Time

7. Committing Date & Time changes

8. Data Model.cs created in Model folder by the name ThemeTrekking.cs

9. In Model, class defined and 6 properties included. 

10. 1 minimum DataType entry coded & committed!

11. .NET CLS Commands installed & Comitted!
    dotnet tool install --global dotnet-ef --version 5
    dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

12. Scaffold comman ran -  dotnet-aspnet-codegenerator razorpage -m ThemeTrekking -dc ThemeTrekkingContext -udl -outDir Pages/ThemeTrekking --referenceScriptLibraries -sqlite

13. Entity Framework Migration feature, created the initial database schema. Committing

14. A link added to my webapp's top navigation bar that leads to the Index file of my new CRUD pages. Committing

15. Added a new cs file with a file name(SeedData.cs) and class name of SeedData_WEB315_Trekking_Locations_Asg_01.

16. Initialized SeedData so that it will add a minimum of 5 entries to my database if the database is empty when anyone runs the webapp. Committing

17. Submitting the Asg on BB.

18. Minor changes in lebels revised.

////////////////////////////////////////////////////////////////////////

Assignment 02 _ adding

////////////////////////////////////////////////////////////////////////

1. New branch by the name of the Assignment_2 branch created.
2. Comitting new branch changes.
3. Added 2 new property, by the name of the Height as Int and Popularity as String. Committing
4. ALl CRUD pages changes made and added 2 newly introduced properties Height and Popularity. Committing
5. 3 new property, all the information added to the model page and seedData. Committing
6. Run essential commands to update the newly added database schema.
                dotnet ef migrations add rating
                dotnet ef database update

                Committing changes
7. Changes to seedData updated. Committing
8. Add validation rules to your model properties as follows:
           Done -  All string properties must have a value and cannot be saved without a value. (i.e.
            no null values, strings are required to have a value)
           Done -   All strings properties must have either a minimum length, maximum length, or
            both. (ex. a chess player name could have a minimum length of 4 and a maximum
            length of 32)
           Done - The newly added string property (from step 2) must only accept letters, and the
                first letter is required to be uppercase. (i.e. white spaces are also allowed, while
                numbers and special characters are not allowed)
                The newly added integer property (from step 2) must restrict the value to be within
                an range of your choosing.
Committing...

9. Search bar added and Select list added... working all good... committing... Asg 2 completed