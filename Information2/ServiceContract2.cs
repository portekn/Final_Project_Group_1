using Model2.Model;  
using System.Collections.Generic;  
using System.Linq;  

    namespace NameOfProject.Information1
    {  
        public class Location : ILocation 
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