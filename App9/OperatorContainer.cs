using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    internal static class OperatorContainer
    {
        public static List<Operator> AllOperator = new List<Operator>();
        
        static OperatorContainer()
        {
            AllOperator.Add( new Operator('O'));
            AllOperator.Add(new Operator('M'));
            AllOperator.Add(new Operator('D'));
            AllOperator.Add(new Operator(','));
            AllOperator.Add(new Operator('('));
            AllOperator.Add(new Operator(')'));
        }

        public static Operator FindOperator(char s)
        {
            foreach( Operator op in AllOperator)
            {
                if (op.oper == s)
                    return op;
            }

            return null;
        }

    }
}
