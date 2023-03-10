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
            AllOperator.Add(new Operator( (Operand op1, Operand op2, Operand op3, Operand op4, Operand op5) =>
            {
                double hei, wid, y, x;

                if (!double.TryParse(op1.ToString(), out hei))
                    return false;

                if (!double.TryParse(op2.ToString(), out wid))
                    return false;

                if (!double.TryParse(op3.ToString(), out y))
                    return false;

                if (!double.TryParse(op4.ToString(), out x))
                    return false;

                double width = Init.bitmap.Width;
                double height = Init.bitmap.Height;

                if (!(x + wid <= width && x >= 0))
                    return false;

                if (!(y + hei <= height && x >= 0))
                    return false;

                Figure fig = new Figure(hei, wid, y,x, op5.ToString());
                fig.Draw();

                Form1.figures.Add(fig);

                return true;
            },'O'));

            AllOperator.Add(new Operator((Operand op1, Operand op2, Operand op3) =>
            {
                double dy, dz;

                if (!double.TryParse(op1.ToString(), out dy))
                    return false;

                if (!double.TryParse(op2.ToString(), out dz))
                    return false;

                Graphics g = Graphics.FromImage(Init.bitmap);
                g.Clear(Color.White);

                bool outWindow = true;

                foreach (Figure fg in Form1.figures)
                {
                    if (fg.Name == op3.ToString())
                    {
                        outWindow = fg.MoveTo(dy, dz);
                    }

                    fg.Draw();  
                }

                return outWindow;
            },'M'));

            AllOperator.Add(new Operator((Operand op1) =>
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                g.Clear(Color.White);

                Figure? ForDelete = null;

                for(int i =0; i < Form1.figures.Count; i++)
                {
                    if (Form1.figures[i].Name == op1.ToString())
                        ForDelete = Form1.figures[i];
                }

                if (ForDelete == null)
                    return false;

                Form1.figures.Remove(ForDelete);

                foreach (Figure fg in Form1.figures)
                {
                    fg.Draw();
                }

                return true;
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
