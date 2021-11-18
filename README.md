Final Project 
Assignment Instructions 

GOAL: Develop a ASP.NET WebAPI, using Git as a code repository. 
REQUIREMENTS: Each member of your team should have at least one commit to the project. I would recommend splitting the project into equal parts (the best you can). 
1.	The WebAPI should conform to the following specifications:

      o	Use dotnet core version 3.1 

      o	Connect to a database using Entity Framework Core 

      o	The API should consist of four controllers. Each attaching to its own table 
    

2.	At least one of the tables should consist of the following information:

      o	Team member full name 

      o	Birthdate (datetime) 

      o	College Program 

      o	Year in program: Freshman, Sophomore, etc.
      

3.	3 other tables are your choice:

      o	Hobby, favorite breakfast foods, etc. 

      o	Foreign key relationships not needed. 

      o	Each table must consist of at least 5 columns, including the primary key column.
      

4.	Each Controller should consist of all CRUD operations to interact with the underlying table (Create, Read [single or multiple, see below], Update, Delete).

      o	The Read operation for each method should take in a nullable id (int). If null or zero I provided for the id, return the first five results from the table.
      
      o	Use NSwag package library as a means to view each controller and its actions 
      
      Note: Follow Acceptance Criteria for each assignment. Incomplete Acceptance Criteria will not be graded and need to be re-submitted with a late penalty attached. 

Acceptance Criteria 
1.	Link to your Git repository. 
2.	A 5 (maximum) minute team presentation of your web application (you can use Teams and simply record your session or use any screen capture of your choice.) 

      a. Make sure each team member has a speaking portion. 
  
      b. I recommend each member speaks on their contribution to the project.

Project Layout
1.	Git Repository Link: https://github.com/portekn/Final_Project_Group_1.git 

2.	SQL Database file with the following tables:

      a.	File Name: “FILENAME.MFD”

      b.	Table 1 (REQUIRED)
      
      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  ID	       |  FullName  |  Birthdate |  Program   |	 Year      |

      c.	Table 2

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  Blank     |  Blank     |  Blank     |  Blank     |	 Blank     |
				

      d.	Table 3

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  Blank     |  Blank     |  Blank     |  Blank     |	 Blank     |
				

      e.	Table 4

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  Blank     |  Blank     |  Blank     |  Blank     |	 Blank     |
				


3.	Controllers – Located in the Controllers folder
      a.	Controller 1 (REQUIRED)
      i.	Notes:

      b.	Controller 2
      i.	Notes:

      c.	Controller 3
      i.	Notes:

      d.	Controller 4
      i.	Notes:

4.	Models – Located in the Models folder
      a.	Model 1 (REQUIRED)
      i.	Notes:

      b.	Model 2
      i.	Notes:

      c.	Model 3
      i.	Notes:

      d.	Model 4
      i.	Notes:

5.	Information Folders/Service Contracts – Each bullet below is a folder that contains two files:
      a.	Information 1
      i.	ServiceContract 1
      1.	Notes:

      ii.	IServiceContract 1
      1.	Notes:

      b.	Information 2
      i.	ServiceContract 2
      1.	Notes:

      ii.	IServiceContract 2
     1.	Notes:

      c.	Information 3
      i.	ServiceContract 3
      1.	Notes:

      ii.	IServiceContract 3
      1.	Notes:

      d.	Information 4
      i.	ServiceContract 4
      1.	Notes:

      ii.	IServiceContract 4
      1.	Notes:
