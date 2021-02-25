using myBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace myBank.Sistemas
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
        
    }
}
