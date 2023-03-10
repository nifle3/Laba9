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
            AllOperator.Add(new Operator((Operand op1, Operand op2, Operand op3, Operand op4, Operand op5) =>
            {
                Figure fig = new Figure((double)op1.value,(double)op2.value, (double)op3.value,(double)op4.value, op5.ToString());
                fig.Draw();

                Form1.figures.Add(fig);
            },'O'));

            AllOperator.Add(new Operator((Operand op1, Operand op2, Operand op3) =>
            {
                foreach (Figure fg in Form1.figures)
                {
                    if (fg.Name == op1.ToString())
                    {
                        fg.MoveTo((double)op2.value, (double)op3.values);
                    }
                }


            },'M'));

            AllOperator.Add(new Operator((Operand op1) =>
            {
                foreach (Figure fg in Form1.figures)
                {
                    if (fg.Name == op1.ToString())
                    {
                        Form1.figures.Remove(fg);
                    }
                }

            },'D'));

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
