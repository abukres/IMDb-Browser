This is a Blazor server app that showcases the use of DevExpress Blazor grid. The grid displays a list of movies or actors from the IMDb dataset. It highlights some features of the grid like master-detail rows, filter row with editable dropdown preassigned values. Showing how to use the same grid as a master list or as a detail row.
  
The dataset can be loaded from kaggle.com or from download links provided by IMDb. The repo includes a SQL Server backup file which can be restored to a database. The input files from the dataset were ETL'd into corresponding table in the database. Some tranformations and massaging of the data were done. The included database is a tiny subset of the dataset to limit the size for the repo.  
  
DevExpress Blazor is a commercial UI component suite. You can download a free 30 day trial version from devexpress.com.  
  
##### Instructions to use and run:
* Install DevExpress Blazor

* Clone the repo and load the the solution Visual Studio. 

* Create a SQL Server database called imdb or another name of your choice. Restore the included imdb.bak (after unzipping imdb.zip) file into the database.

* Update the connection string as necessary.
* Make DxBlazorServer_Berry the startup project and run the solution. The web page will display a populated grid in a web page.



