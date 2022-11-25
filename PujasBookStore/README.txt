started new Project 2022-10-21 12:44
Built the initial default application 
prepend name = 'PujaBookStore'
-Individual Accounnt Authentication
-Added Razir Runtime 

create and then reviewd the default app.
clone to git before that create repos.
done for the day 12:47

2022-10-24 1:33
created readme.md for public and outline about the project description.
comment in json file for the test in lab.

Done for the day.

2022-10-28 11:57
starting second step
rebuild the application for checking 
Run successfullyyy all good, all parts are working properly
doing in lab so comment ssl port.
done.

start 3rd step
bootstrap.css change that.
download bootstrap.css from bootswatch 
i choose minty theme and replace that with the new bootstrap.css.
then change the layout_cshtml change file name from bootstrap.min.css to bootstrap.css,
change the nav class to  navbar dark and bg-white to bg-primary,
Removed text dark in line23
Add text-white-50 bg-primary to footer class(properties)

making cganges in loginpartial.cshtml
removed alll with text-dark, run it 
changes visible successfully.
1:32
reviewd and apply it run it successssfulllllyyyy.(it is not big thing but still im happy)
done for the day

2022-10-31 12:39pm

starting working on dropdown.
Adding additional stylesheet from provided file in _Layout.cshtml file save chnages.
adding more additional script above the line 66 from provided file,
also add @await RenderSectionAsync in line66,
Add dropdown to nav bar
there is missing attribute such as toggle which is important for the dropdwon and it was missing,
adding those attributes and lets try to run.
donnnnnnneeeeee.
now change dorpdown to content management.
done with the dropdown.

01:06 pm
 starting next step 1.4
 Adding new 3 project in main solution,
 add-> new Project-> select project type c# and do not sleect any other, 
 name it PujaBooks.DataAccess, PujaBooks.Models, PujaBooks.Utility,
 copy data folder and paste in PujaBooks.DataAccess,
  install new package Microsoft.Entity.Core.Relational 3.1.16 version
  delete the migration folder, hopee
  modify the namespace in application.dbContext
  Installed new indentity framework package in PujaBooks.DataAccess project
  Delete all class file from all projects.
  we have to build it is remain

  2022-03-11 12:41am

  i clone repos from git and there was some problem like i created 3 new projects but,
  when i clone and open the sln file there is something like file is uloaded so i have to make new project,
  because i deleted the data folder and paste it in DataAccess project..


  2022-03-11 8:12pm
  i started to do new project because i made mistake while creating,
  i created new project in my laptop but i have got error which i cannot explain in words, i have to show you for that,
  now i created new project from my friend's laptop.
 i build the DAtaAccess project
 next step is moved models in to pujasbooks.models and delete the original,
next add new project refernce  and select dataaccess and models then ok,
rename the model folder to ViewModels
change the errorviewmodels.cs namespace to modelsviewmodels.
build the models project getting 1 successed and 0 error.

modify the startup.cs and add new suggetion addcontext with the statment.
run the application lets seeee......,


2022-03-11  5:15pm

i have got errors that i cannot solved some duplication error, 
my application was not running so i started new project but there was some other problem,
when i created new project there was problem with my repos path i 
tried with all ways still it is not solved i uninstall visual and deleted all repos
but not getting result.

today i started new project with different path from part1.
completed till bootswatch and Add additional link.

06:55 pm
added dropdown menu code and run it,
successfully run

10:35 pm
modify the startup.cs and add new suggetion addcontext with the statment.
i got error in startup.cshtml name space error, error viewmodel.cs
remove the using statment
i solved the namespace error refrence to ErrorViewModel to the new .Model.ViewModels.ErrorViewModels
save it and run it sucessfully. finallllllyyyyyyyyy after 
soooooo much effffforts blood, sweat, tears ihve solved this error hope this is last,hahahahahaha not trueeeee.
end of part 11:10pm

11:43
in the utility project create a static  deatils class called SD.cs
modify the properties of the class,then add project reference to the main project,
in the DataAccess project add  project refenence to  Models and Utility,
Add customer to Area to Mvc Areas,
change the routes in startup.cs like the one outline in the  scafoldingreadme.txt,
move homecontrollers.cs to area>customer>controller and delete models and data,
edit the homecontoller.cs to define the controller is in Customer Area,
modify the homecontroller namespace
modify the viewstart.cshtml to reflect the new path.

run the application and done.

copy the viewimport and viewstart to customer area
modify the viewstart.cshtml to reflect the path
run the application....
run it sucessfully.

12:07 am
 starting last part Adding admin in area.
added view files and delete data and model folder,
deleteed the controller folder also,
 run it and donnneeeeee,
  afterrrrrrr soo muchhhhh efffores, swaet, blood, tears it runssss.
  nooo i am not able to click on privacy register and login.
  take a break and do tommorow

  02:03 am
  took break and back
  i solved error with privacy page but still i am not getting register and login page,
 <a class="nav-link" asp-area="Customer" asp-controller="Home" asp-action="Index">Home</a>
 </li>
<li class="nav-item">
<a class="nav-link" asp-area="Customer" asp-controller="Home" asp-action="Privacy">Privacy</a>

i change in asp-area="" to asp-area="Customer" andthat works.

2022-11-11
completed part 1
4:00 pm

2022-11-11 4:28pm
starting Asisgnment2
clone the repos and biuld the solution,
successfully runn..without errors.
Review appSetting.json and change the database name 

Add migration with default projectname and getting Errors

Your target project 'PujasBookStore' doesn't match your migrations assembly 'PujasBooks.DataAccess'. Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("PujasBookStore")). By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.

change default project name PujasBookStore to PujasBooks.DataAccess.
 and add migration command, build sucessfuly and nre migration file 
 created with name of(20221111223431_AddDefaultIdentityMigration).

 Added Asp.net identity, upadte the database and ruun it,
 sucessfully run
 added new class named category in PujasBooks.Models

modify category.cs added namespace and new table to the DB
add new class file to .Models

Added namespace in Application.dbContext.cs using PujaBooks.Models;
Added Dataset in same file
run the migration command for the category table
build succeed.

upadate the database,
checked sqlserver object and i can see new table named category
donw with the part2.1
commit all Chnages to the github.
end of the part 6:35 pm


2022-11-12 8:00 pm
Started Part 2.2

Added Repository folder in DataAccess project,
Added one more IRepository folder inside Repository folder
added One class named IRepository.cs , Added new Namespaces
Added provided code in cs file.
Add one class in Repository folder named Repository.cs and modify the code 
to create the constructor and dependency injection(DI),

8:23 
created individual repos for category,
CategoryRepository.cs
ICategoryRepository.cs

modify CategoryRepository.cs using statement and message for formal parameters-Review in Repository.cs
the method pointing to be  ApplicationDbContext

modify IcategoryRepository interface and CategoryRepository.cs
build the appliction ,
no errors,
Added new interface  in the IRepository folder called ISP_Call.cs 
install nuget package for dapper
i did the same thing in for repository folder , added new interface SP_Call.cs
update the ISP_Call interface
Added the wrapper for unit of work

11:41 pm
Added new interface IunitOfWork to the IRepository folder.
Add public class
make the method public to access the class
the using statement
constructor to use DI and inject in to the repositories
all changes will be saved when the save method is called at the 'parent' level

build the application ......
no issue found 
ENd of 2.2
11:45 pm

2022-11-12  11:46 pm
Starting Part 2.3

Added new controller inside Areas > Admin > Controllers > CategoryController.cs
Added using statments 
using PujasBooks.DataAccess.Repository.IRepository;
using PujasBooks.DataAccess.Repository;
using PujasBookStore.DataAccess.Data;
Added provided code.

made a new folder in Areas >Admin > Views >Category
Added new index view from provided file from balckboard.
run the application 
successfully run .

change the privacy with the Category , added admin in asp-area, asp-controller="Category" asp-action="Index"
move this line in drop-down and added normal chnages
run the application and review it,
 sucessfully run it.
 then added javascript file provided on blackboard in wwwrot/js 
 make new js file name category.js and added  provided code


 added this code in index.cshtml

  <div class="text-center">
    <a href="/Admin/Category/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer">
<i class="fas fa-edit"></i>&nbsp;
    </a>
 <a class="btn btn-danger text-white" style="cursor:pointer">
  <i class="fas fa-trash-alt"></i>&nbsp;
  </a>
 </div>

 in index.cshtml add @section call to category.js file and run the application
 Added new razor view named upsert in category folder and write a code provided by you.
 create a partial view of edit and back in views> shared folder _CreateAndBackToListButton.cshtml
 and _EditAndBackToListButton.cshtml
 in Edit.cshtml add @model razor statment
 modify the upsert.cshtml,
 added asp-action to index.cshtml page and run the application.
 Added section validatation for the required field.

 created upsert post method in controllers.cs 
 added save method in controller.cs
 run the application and sav it successfully. because of the save method
 remove the _db.Savechanges() method in CategoryRepository.cs and move the _unitOfWork.Save()
 with the return redirecttoaction method
 now letsss runnn successfully done
 donneee
 end of this morning
 3:37 Am
 

 2022-11-13 10:09 pm 
 Started Adding Delete
 added the api call for HTTP delete in the category.controller.cs

 then addded httpdelete method in category.js to add functionality to application and call the API.
 added onclick event in category.js file and save it,
 added delete url function code and letsss seee ,
 run the application .....

 donnneeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee, finallllllllllllllllyyyy
 going to sleeep now
 End of Part 2.3
 10:59 pm

 completed Part 2 of the assignment
 11:00 pm


 2022-11-23 2:23
 started Part3(3.1) at 10:38pm
 i created all crud pages and all things going okay, 
 but when i tried to push to github there was error 
 i was not able to push to github,
 i am tried with all ways i do not understand anything that is 
 why i am starting my project again from Assignment2(part2.1)

 2022-11-24 12:46am
 i completed Part2, now i will start Part3
 12:47 am
 created crud pages and added migration
 update the  migration
 made CoverTypeController.cs same as category
 added code in layout.cshtml to display covertype on navbar
 make a new folder in views called CoverType same as Category,
 add razor page Index and make changes
 everything going smoothly for now
 
 added covertype.js in wwwroot made changes in that same as category.js
 now add upsert view and added code
 trying to add new Covertype there is error while adding
 exception user handled
 invalid object name CoverTypes.
 done for this night,, i am so tired after making whole new assignment.
 tomorow i will do.
 good night
 03:03 am

 2022-11-24 7:14 pm
 - Update the CoverType files and again update the database....
 - database created successfull
 - error solved - changed the migration files CoverType and altered it
 - updated the code and update the git repo...
 7:17 pm

 2022-11-24 10:25
 starting 3.2
 Adding Crud product
  same as covertype
  made ProductController.cs same as category
 Add a new class in .Models Project
Adde the given code into it and saved the Product.cs file
Added the Migration which created the file in migration folder named 20221125032826_AddProductToDb
Update Databse
Checked the product in table of SQL server object Explorer
Added the required filed in the product.cs file
Added the migration which created the file in migration folder with name 20221125035422_AddValidationToProduct
Update the database
Created the ProductRepository.cs file in Repository folder
Created the IProductRepository.cs file in IRepository folder
Updated the ProductRepository.cs file withe the given code in ppt
Added the product in the UnitOfWork and IUnitOfWork
Build the project
Push to Github
Part 2.3.2 Completd Successfully
First PPT Completd

Starting Part 3.2 Build the project
Added the ProductController to the controller folder
Modified that file and saved
Added the package named Microsoft.AspNetCore.Mvc.Rendering in all projects
Created the new file and named it ProductVM in the Models project
Updated the file as said and added the using statement
Comment the upsert code for now after modifying it
Modifying the API
created new folder in the view folder and named it Product
Added new razor page in the view model
Copied the category view razor page and changed the content
created new Product.js file and save the changes in it
Changed the index.cshtml chnages by adding new columns of other product
Changing the _Layout.cshtml to add a new link of Product
Run the project. Got an exception, Continue the run
Commit to github.

2022-11-24 11:10pm
starting Part3.3
Created Upsert in the Product folder
copied the CoverType Upsert and Saved the file with some initial changes
wrote the code in the Upsert file and saved it
Added the script tag and those code
Created the account on given link
Copied the ID and pasted at appropriate place
Changed the Model.ID into Model.Product.Id in Upsert
Run the project 
done for the day 
goooooooodddddd nighttttt.
end time 11:28pm