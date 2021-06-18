
# Database installation instruction

1. Install SQL Server Developer Edition Installer (if you don't have one) with MIXED MODE AUTHENTICATION
    1. Go to [download link](https://www.microsoft.com/ru-ru/sql-server/sql-server-downloads)
    2. Choose Developer Edition
       ![img.png](./Images/SqlInstructions/img.png)
    2. Open the installer ()
    3. Click "Custom" ![img_1.png](./Images/SqlInstructions/img_1.png)
    4. Click "Install". Do not mind current path -- it is the path where only installation files are stored, not an actual SQL Server ![img_2.png](./Images/SqlInstructions/img_2.png)
    5. Wait for installer to download files
    6. Click "Installation" and then "New SQL ..." ![img_3.png](./Images/SqlInstructions/img_3.png)
    7. Click "Next" ![img_4.png](./Images/SqlInstructions/img_4.png)
    8. Accept license terms and click "Next"   ![img_5.png](./Images/SqlInstructions/img_5.png)
    9. Click "Next"   ![img_6.png](./Images/SqlInstructions/img_6.png)
    10. Wait for installation files to be installed
    11. Click "Next" ![img_7.png](./Images/SqlInstructions/img_7.png)
    12. Select "Database Engine Services", choose another root directory (if needed) and click "Next" ![img_8.png](./Images/SqlInstructions/img_8.png)
    13. Click "Next" ![img_9.png](./Images/SqlInstructions/img_9.png)
    14. Click "Next" ![img_10.png](./Images/SqlInstructions/img_10.png)
    15. ![img_12.png](./Images/SqlInstructions/img_12.png)
        1. Choose "Mixed Mode"
        2. Enter some secure password twice. You can generate password online or using your preferred password manager (e.g. Lastpass). Store this password in a notepad document or anywhere else.
        3. Click "Add Current User"
        4. Click "Next"
    16. Click "Install" ![img_13.png](./Images/SqlInstructions/img_13.png)
    17. Wait for the installation to be completed
    18. Close the installer window


2. Install SQL Server Management Studio (SSMS)
    1. Go to [Download link](https://docs.microsoft.com/ru-ru/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15) TODO: Install SQL Server Management Studio
    2. Click on the download link ![img.png](./Images/SqlInstructions/img_14.png)
    3. Run the installer, choose installation path and click "Install"


3. Restore database from backup
    1. Open SQL Server Management Studio
    2. Connect to your server instance by clicking "Connect" ![img_1.png](./Images/SqlInstructions/img_15.png)
    3. TODO: Download database
    4. Expand your local SQL Server, right click "Databases" item and choose "Import Data-tier Application" ![img_2.png](./Images/SqlInstructions/img_16.png)
    5. _Optionally_ Check the checkbox "Do not show this page again" ![img_3.png](./Images/SqlInstructions/img_17.png)
    6. Click "Next"
    7. Click "Browse", choose freshly downloaded .BACPAC file and click "Next" ![img_4.png](./Images/SqlInstructions/img_18.png)
    8. Check the settings and database name and click "Next", then "Finish" ![img_5.png](./Images/SqlInstructions/img_19.png)
    9. Wait for the operation to be completed


4. Change connection string
    1. Make a copy of the file connectionStrings.template.config and call it connectionStrings.config
    2. Substitute {INSERT YOUR SOURCE} with your server name ![img_6.png](./Images/SqlInstructions/img_20.png)
    3. Substitute {YOUR INITIAL CATALOG} database name with EPiServerLearningPlatform
    4. Substitute {YOUR PASSWORD} password with your SQL Server administrator Password you have entered in 1.15
    5. Build the solution and make sure that site is working
   
