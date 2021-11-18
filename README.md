# Final Project Group 1

## Assignment Instructions 

### GOAL: Develop a ASP.NET WebAPI, using Git as a code repository. 
### REQUIREMENTS: Each member of your team should have at least one commit to the project. I would recommend splitting the project into equal parts (the best you can).

1. The WebAPI should conform to the following specifications:
   - Use dotnet core version 3.1 
   - Connect to a database using Entity Framework Core 
   - The API should consist of four controllers. Each attaching to its own table 
    
2. At least one of the tables should consist of the following information:
   - Team member full name 
   - Birthdate (datetime) 
   - College Program 
   - Year in program: Freshman, Sophomore, etc.

3. 3 other tables are your choice:
   - Hobby, favorite breakfast foods, etc. 
   - Foreign key relationships not needed. 
   - Each table must consist of at least 5 columns, including the primary key column.

4. Each Controller should consist of all CRUD operations to interact with the underlying table (Create, Read [single or multiple, see below], Update, Delete).
   - The Read operation for each method should take in a nullable id (int). If null or zero I provided for the id, return the first five results from the table.
   - Use NSwag package library as a means to view each controller and its actions.
     - Note: Follow Acceptance Criteria for each assignment. Incomplete Acceptance Criteria will not be graded and need to be re-submitted with a late penalty attached. 

### Acceptance Criteria 
1. Link to your Git repository. 
2. A 5 (maximum) minute team presentation of your web application (you can use Teams and simply record your session or use any screen capture of your choice.) 
   - Make sure each team member has a speaking portion. 
   - I recommend each member speaks on their contribution to the project.

### Project Layout
#### 1. Git Repository Link: https://github.com/portekn/Final_Project_Group_1.git 
#### 2. SQL Database file with the following tables:
   - File Name: “FILENAME.MFD”
   - Table 1 (REQUIRED)
      
      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  ID	   |  FullName  |  Birthdate |  Program   |  Year      |
   - Table 2

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  Blank     |  Blank     |  Blank     |  Blank     |  Blank     |
   - Table 3

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  Blank     |  Blank     |  Blank     |  Blank     |  Blank     |
   - Table 4

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  Blank     |  Blank     |  Blank     |  Blank     |  Blank     |

#### 3. Controllers – Located in the Controllers folder
   - Controller 1 (REQUIRED)
     - Notes:

   - Controller 2
     - Notes:

   - Controller 3
     - Notes:

   - Controller 4
     - Notes:

#### 4.	Models – Located in the Models folder
   - Model 1 (REQUIRED)
     - Notes:

   - Model 2
     - Notes:
     
   - Model 3
     - Notes:
     
   - Model 4
     - Notes:

#### 5.	Information Folders/Service Contracts – Each bullet below is a folder that contains two files:
   - Information 1 (REQUIRED)
     - ServiceContract 1
       - Notes:
     - IServiceContract 1
       - Notes:

   - Information 2
     - ServiceContract 2
       - Notes:
     - IServiceContract 2
       - Notes:

   - Information 3
     - ServiceContract 3
       - Notes:
     - IServiceContract 3
       - Notes:

   - Information 4
     - ServiceContract 4
       - Notes:
     - IServiceContract 4
       - Notes:
