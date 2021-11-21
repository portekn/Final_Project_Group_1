using Models.Model2;
using System.Collections.Generic;

namespace IServiceContract1.Information1
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