using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //We cannot instantiate an abstract class. Shape s  = new Shape(). This is because a 
            //shape is too abstract - it does not take any form. Enables us to enforce the developer to
            //follow a particular pattern by mandatorily implementing some specific behavior in the derived
            //class.

            //Abstract modifier states that a class or a member misses implementation.We use
            //abstract members when it doesn’t make sense to implement them in a base class. For
            //example, the concept of drawing a shape is too abstract. We don’t know how to draw
            //a shape.This needs to be implemented in the derived classes.
            //- When a class member is declared as abstract, that class needs to be declared as
            //abstract as well.That means that class is not complete.
            //- In derived classes, we need to override the abstract members in the base class.

            OracleConnection sq = new OracleConnection("./OracleDb");
            DbCommand dbc = new DbCommand(sq, "select * from emp;");
            dbc.Execute();

            Console.ReadLine();
        }
    }
}
