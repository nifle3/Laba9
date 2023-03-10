using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    static class Algorithm
    {
        static Stack<Operator> oper = new Stack<Operator>();
        static Stack<Operand> operd = new Stack<Operand>(); 

        static bool Calcul(string inString)
        {
            Operator? mainOp = OperatorContainer.FindOperator(inString[0]);
            
            if (mainOp == null)
                return false;
            
            inString = inString.TrimStart();

            for (int i =0; i < inString.Length; i++)
            {
                if (char.IsDigit(inString[i]))
                {
                    string number = inString[i].ToString();

                    for (int j = i; char.IsDigit(inString[j]) || inString[j] == '.'; j++)
                        number += inString[j].ToString();

                    double dnumber = double.Parse(number);

                    operd.Push(new Operand(dnumber));
                }

                else if ()
                {

                }


                else
                    return false;
            }
             
            return true;
        }
    }
}
