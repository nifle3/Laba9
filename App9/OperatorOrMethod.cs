using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    internal class OperatorMethod
    {
        public delegate void EmptyOp();
        public delegate void Unary(Operand oper);
        public delegate void Four(Operand oper, Operand oper1, Operand op2, Operand op3, Operand op4);
        public delegate void Trinary(Operand op1, Operand op2, Operand op3);
    }

    internal class Operator : OperatorMethod
    {
        public char oper;

        public EmptyOp? ep = null;
        public Unary? unary = null;
        public Four? five = null;
        public Trinary? trinary = null;


        public Operator(char operand) =>
          oper = operand;

        public Operator(Unary unar, char ch) : this(ch) =>
            unary += unar;

        public Operator(Four fiv, char ch) : this(ch) =>
            five = fiv;

        public Operator(Trinary tri, char ch) : this(ch) =>
            trinary = tri;

        public Operator(): base() { }
    }
}
