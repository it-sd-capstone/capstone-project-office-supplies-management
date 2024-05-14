# Capstone Project: Office Supplies Management

### Before cloning/forking...
1.  Download [MySQL](https://dev.mysql.com/downloads/mysql/)

2.  Download [Visual Studio 2022](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030) (this link downloads automatically).

3. Download [Git](https://git-scm.com/downloads) 

4.  Clone/fork the project to a directory of your choosing using Git. When Git is open type or copy git clone git@github.com:it-sd-capstone/capstone-project-office-supplies-management.git in Git.

5. Open the folder that the files are in, and open the file called OfficeSuppliesManagement.sln

6.  Run the project once by pressing the green button that says OfficeSuppliesManagement

7. Then press Show Products to show the file when the exe opens. You should then see the database open when it is finished loading.

### Initializing the Database
1. Navigate to the project directory where you cloned/forked the repository.
2. Find the database_dump.sql file included in the project files.
3. Open a command prompt or terminal.
4. Connect to your MySQL server:
			mysql -u root -p
			Enter your MySQL root password when prompted
5. Create the database in mysql by running:
			CREATE DATABASE OfficeSupplies;
6. In a command prompt or terminal import the database schema and data:
			mysql -u root -p OfficeSupplies < database_dump.sql
   
### Additionally...
The database's records can be updated/added within Visual Studio, but any changes to the database's design (such as altering relationships, changing primary/foreign keys, changing column names, or adding tables) are more easily done in MYSQL.
