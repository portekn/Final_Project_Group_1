using Models.Model2;
using System.Collections.Generic;

namespace Final_Project_Group_1.Information2
{
    //Interface name needs to include “I” at the beginning 
    public interface IServiceContract2
    {
        Variable AddVariable(VariableType variable);
        List<Variable> GetVariable();
        void UpdateVariable(VariableType variable);
        void DeleteVariable(VariableType variable);
        Variable GetVariable(VariableType variable1);
    }
}