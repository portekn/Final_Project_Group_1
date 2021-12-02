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
#### 1.	Project Timeline - Due December 6, 2021
   - Evan Kelley, Kelli Porter – Set 1 and Set 2:
      - Controller 1, Controller 2
      - Model 1, Model 2
      - Service Contract 1, Service Contract 2
      - IService Contract 1, IService Contract 2
      - Service Context 1, Service Context 2
      
   - Felix Odogwu, José Chacón Ascue – Set3:
      - Controller 3
      - Service Contract 3
      - IService Contract 3
      - Service Context 3
      
   - Yifei Yang, Mari Brenner – Set 4:
      - Controller 4
      - Service Contract 4
      - IService Contract 4
      - Service Context 4
 
#### 2.Git Repository Link: https://github.com/portekn/Final_Project_Group_1.git 
#### 3. SQL Database file with the following tables:
   - File Name: “FILENAME.MFD”
   - Table 1 (REQUIRED) - Basic Information
      
      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  ID	   |  FullName  |  Birthdate |  Program   |  Year      |
   - Table 2 - Location

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  ID     |  State    |  City    |  ZipCode    |  Street Name     |
   - Table 3 - Interests

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  |
      | ---------- | ---------- | ---------- | ---------- | ---------- |
      |  Category    |  Specific Interest    |  Years in interest    |  Expensive (T/F)    |  Time consumption (hours/week)     |
   - Table 4 - Movies

      |  Column 1  |  Column 2  |  Column 3  |  Column 4  |  Column 5  | Column 6 |
      | ---------- | ---------- | ---------- | ---------- | ---------- |----------
      | ID         | MovieName  |  Year      |  Director   |  Score    |   type   |

#### 4. Controllers – Located in the Controllers folder
   - Controller 1 (REQUIRED)
     - Pseudo Code Layout Example:
     
````
using System.Collections.Generic;  
using Microsoft.AspNetCore.Mvc;  
using NameOfProject.Model;
using NameOfProject.Information 1;
namespace NameOfProject.Controllers  
{  
    [Route("api/[controller]")]  
    [ApiController]  
    public class VariableController : ControllerBase  
    {  
        private readonly INameOFServiceContract _variableService;  
        public VariableController(INameOFServiceContract variableService)  
        {  
            _variableService = variableService;  
        }  
        [HttpGet]  
        [Route("[action]")]  
        [Route("api/ModelFile/GetVariables")]  
        public IEnumerable<Variable> GetVariables()  
        {  
            return _variableService.GetVariables();  
        }  
        [HttpPost]  
        [Route("[action]")]  
        [Route("api/ModelFile/AddVariable")]  
        public IActionResult AddVariable(Variable variable)  
        {  
            _variableService.AddVariable(variable);  
            return Ok();  
        }  
        [HttpPost]  
        [Route("[action]")]  
        [Route("api/ModelFile/UpdateVariable")]  
        public IActionResult UpdateVariable(Variable variable)  
        {  
            _variableService.UpdateVariable(variable);  
            return Ok();  
        }  
        [HttpDelete]  
        [Route("[action]")]  
        [Route("api/ModelFile/DeleteVariable")]  
        public IActionResult DeleteVariable(VariableType variable1)  
        {  
            var variable2 = _variableService.GetVariable(variable1);  
            if (variable2 != null)  
            {  
                _variableService.DeleteVariable(variable2.variable1);  
                return Ok();  
            }  
            return NotFound($"Thing Not Found with ID : {variable2.variable1}");  
        }  
        [HttpGet]  
        [Route("GetVariable")]  
        public Employee GetVariable(VariableType variable1)  
        {  
            return _variableService.GetVariable(variable1);  
        }  
    }  
}
````
   - Controller 2
   - Controller 3
   - Controller 4

#### 5.	Models – Located in the Models folder
   - Model 1 (REQUIRED)
     - Pseudo Code Layout Example:
````
using System.ComponentModel.DataAnnotations
namespace NameOfProject.Model
{
	public class NameOfClass 
	{
		[Key]
		public variableType variableName {get; set;}
		//Continue to add variables according to the corresponding table 
   }
}
````
   - Model 2
   - Model 3
   - Model 4

#### 6.	Information Folders/Service Contracts – Each bullet below is a folder that contains two files:
   - Information 1 (REQUIRED)
     - ServiceContract 1
       - Pseudo Code Layout Example:
````
using NameOfProject.Model;  
using System.Collections.Generic;  
using System.Linq;  
    namespace NameOfProject.Information 1
    {  
        public class NameOfClass : INameOfClass 
        {   
            public NameOfClassContext _VariableDbContext;  
            public VariableService (VariableContext variableDbContext)  
            {  
                _variableDbContext = variableDbContext;  
            }  

            //Methods below reference variables from IServiceContract 1
            public Variable AddVariable(VariableType variable)  
            {  
                _variableDbContext.Variable.Add(variable);  
                _variableDbContext.SaveChanges();  
                return variable;  
            }  
            public List<Variable> GetVariables()  
            {  
                return _variableDbContext.Variable.ToList();  
            }  
      
            public void UpdateVariable(VariableType variable)  
            {  
                _variableDbContext.Variable.Update(variable);  
                _variableDbContext.SaveChanges();  
            }  
      
            public void DeleteVariable(VariableType variable1)  
            {  
                var variable2 = _variableDbContext.Variable.FirstOrDefault(x => 
x.variable1 == variable1);
                if (employee != null)  
                {  
                    _variableDbContext.Remove(variable2);  
                    _variableDbContext.SaveChanges();  
                }  
            }  
      
            public Variable GetVariable(VariableType variable1)  
            {  
                return _variableDbContext.Variable.FirstOrDefault(x => x. variable1 == variable1);  
            }  
        }  
 }  
````
   - IServiceContract 1
      - Pseudo Code Layout Example:
````
using NameOfProject.Model;  
using System.Collections.Generic;  
    namespace NameOfProject.Information 1  
    {  
        //Interface name needs to include “I” at the beginning 
        public interface INameOFServiceContract 
        {  
            Variable AddVariable(VariableType variable);  
            List<Variable> GetVariable();  
            void UpdateVariable(VariableType variable);  
            void DeleteVariable(VariableType variable);  
            Variable GetVariable(VariableType variable1);
        }  
 }  
````
   - Information 2
     - ServiceContract 2
     - IServiceContract 2

   - Information 3
     - ServiceContract 3
     - IServiceContract 3

   - Information 4
     - ServiceContract 4
     - IServiceContract 4

#### 7.	Context Files – Located in the main project
- ServiceContext 1
  - Pseudo Code Layout Example:
````
using Microsoft.EntityFrameworkCore;    
using NameOfProject.Model;      
    namespace NameOfProject    
    {    
        public class VariableContext : DbContext    
        {    
            public EmployeeContext(DbContextOptions<VariableContext> options): base(options)    
            {}    
    	
            public DbSet<Variable> Variables {get; set;}    
        }    
    }
````
- ServiceContext 2
- ServiceContext 3
- ServiceContext 4

