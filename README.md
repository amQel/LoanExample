# **LoanExample** - ASPNET Core 2.1 / Angular 6 

Created using template from Ebenzer Monney (https://github.com/emonney/QuickApp) provided with free licence

Every class that does not conntain Ebenzer header is my creation or was updated by me in at least 50%

# prerequisites
dotnet --version  
2.1.403  
npm --version  
5.5.1  

# usage

git clone https://github.com/amQel/LoanExample.git  
cd LoanExample  
dotnet restore  
cd src\QuickApp\ClientApp  
npm install --no-optional  
cd ..  
dotnet run environment=Development  

# about
Application shows simple solution to calculating installments.  
Database connection is implemented, but is disabled.  
To enable this funcionality uncomment seed async in Program.cs  
and provide correct dbconn in appsettings.Development.json  
  
"ConnectionStrings": {  
    "DefaultConnection": "here"  
  }  


## License
Oryginal QuickApp example license
Released under the [MIT License](https://github.com/emonney/QuickApp/blob/master/LICENSE).
