using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    static class Algorithm
    {
        static Stack<Operator> oper = new Stack<Operator>();
        static Queue<Object> inject= new Queue<Object>();

        public static bool InToPoland(string inString)
        {
            Operator? mainOp = OperatorContainer.FindOperator(char.ToUpper(inString[0]));

            if (mainOp is null)
                return false;

            else if (!(mainOp.oper == 'O' || mainOp.oper == 'M' || mainOp.oper == 'D'))
                return false;

            oper.Push(mainOp);

            inString = inString.TrimStart(mainOp.oper);

            for (int i = 0; i < inString.Length; i++)
            {
                if (char.IsDigit(inString[i]))
                {
                    string number = inString[i].ToString();
                    int jt = i;

                    for (int j = i + 1; char.IsDigit(inString[j]) || inString[j] == '.'; j++)
                    {
                        number += inString[j].ToString();
                        jt = j;
                    }
                    i = jt;

                    double dnumber = double.Parse(number);

                    inject.Enqueue(new Operand(dnumber));
                }

                else if (!char.IsDigit(inString[i]) && inString[i] != ')' && inString[i] != '(' && inString[i] != ',' && inString[i] != ' ')
                {
                    string name = inString[i].ToString();

                    int jt = i;

                    for (int j = i + 1; inString[j] != ' ' && inString[j] != ')' && inString[j] != ','; j++)
                    {
                        if (j > 100)
                            break;

                        name += inString[j].ToString();
                        jt = j;
                    }
                    i = jt;
                    inject.Enqueue(new Operand(name));
                }

                else if (inString[i] == ' ')
                {
                    continue;
                }

                else if (OperatorContainer.FindOperator(inString[i]) == null)
                    return false;


                else if (inString[i] == '(')
                {
                    oper.Push(OperatorContainer.FindOperator(inString[i]));
                }

                else if (inString[i] == ',')
                {
                    oper.Push(OperatorContainer.FindOperator(inString[i]));
                }

                else if (inString[i] == ')')
                {
                    for (int k = oper.Count; k > 0; k++)
                    {
                        if (oper.Peek().oper == '(')
                        {
                            oper.Pop();
                            break;
                        }

                        inject.Enqueue(oper.Pop());
                    }
                    break;
                }

                else
                    return false;
            }


            for (int i = 0; i < oper.Count; i++)
            {
                inject.Enqueue(oper.Pop());
            }

            return true;
        }

        public static bool FromTo()
        {
            Stack<Operand> stc = new Stack<Operand>();

            if (inject.Count == 0)
                return false;

            int length = inject.Count;

            for (int i =0; i < length; i++)
            {
                if (inject.Peek() is Operand aOperand)
                {
                    stc.Push(aOperand);
                    inject.Dequeue();

                    continue;
                }

                Operator? op = inject.Dequeue() as Operator;

                if (op is null)
                    return false;

                if (op.oper == ',')
                {
                    
                }

                else if (op.oper == 'O' && stc.Count == 5)
                {
                    if (op.five is null)
                        return false;

                    if (!op.five(stc.Pop(), stc.Pop(), stc.Pop(), stc.Pop(), stc.Pop()))
                        return false;

                    break;
                }

                else if (op.oper == 'M' && stc.Count == 3) 
                {
                    if (op.trinary is null)
                        return false;

                    if (!op.trinary(stc.Pop(), stc.Pop(), stc.Pop()))
                        return false;

                    break;
                }

                else if (op.oper == 'D' && stc.Count == 1) 
                {
                    if (op.unary == null)
                        return false;

                    if (!op.unary(stc.Pop()))
                        return false;

                    break;
                }

                else
                    return false;
            }

            oper = new Stack<Operator>();
            inject = new Queue<Object>();

            return true;
        }
    }
}
