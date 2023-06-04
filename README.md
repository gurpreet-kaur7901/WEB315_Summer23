Create a github repository name ass WEB315_Summer23. Add a readme file to it. now collabing with the majid1292.
Created a new webapp named as Animal by using the command dotnet new webapp -o Animal and  code -r Animal. Then add the command to trust the HTTPS develpement certrificate as follow dotnet dev-certs https –trust.
Add the gitignore file and ignore the obj and bin folders from the project.
Update the index.cshtml file add the heading Animal.
After some rest i added the date and time to index.cshtml.
Create a model folder add the Animal.cs file in it. then add a class to model.I have also added the annotation to release date.
then install the nuget packages and EF tools by using the following commands.
It will take some time to install.
scaffold the Animal model by using the following command:-
dotnet aspnet-codegenerator razorpage -m Animal -dc Animal.Data.AnimalContext -udl -outDir Pages/Animals --referenceScriptLibraries --databaseProvider sqlite 
Righclick on Animal.csproj file then open the integrated terminal and put the following commands:- 
dotnet ef migrations add InitialCreate
dotnet ef database update
This is to create initial database schema.
 Add a link to new nav menu which lead to the CRUD folder.
 Add configuration to appsetting.json file. 
The data has been seeded. i create a new SeedData.cs file.

