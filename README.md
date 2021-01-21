## Usage 1
1. Clone/Download a repo.
   ```sh
   git clone https://github.com/fahmiyonda007/PerpustakaanAPI
   ```
2. change the ConnetctionStrings in the `appsettings.json` file and adjust it to your SQL Server database
   ```json
   "PerpustakaanConnection": "Server= 'ENTER YOUR SERVER';Initial Catalog= 'ENTER YOUR DB';User Id= 'ENTER YOUR USERID';Password= 'ENTER YOUR PASSWORD';"
   ```  
3. Open folder `bin/Debug/netcoreapp3.1`
3. Running app `Perpustakaan.exe`

## Usage 2

1. Clone/Download a repo.
   ```sh
   git clone https://github.com/fahmiyonda007/PerpustakaanAPI
   ```
2. open project using VS Code
3. change the ConnetctionStrings in the `appsettings.json` file and adjust it to your SQL Server database
   ```json
   "PerpustakaanConnection": "Server= 'ENTER YOUR SERVER';Initial Catalog= 'ENTER YOUR DB';User Id= 'ENTER YOUR USERID';Password= 'ENTER YOUR PASSWORD';"
   ```
4. running app via command line / ps
   ```sh
   dotnet run
   ```
