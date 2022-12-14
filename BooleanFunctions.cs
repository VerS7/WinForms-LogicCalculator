using System;
using System.Collections.Generic;
using System.Linq;

namespace BooleanAlgebra
{
    class BooleanFunctions
    {
        private Dictionary<char, int> variables = new Dictionary<char, int>();

        public Dictionary<char, int> Variables
        {
            get { return variables; }
        }

        /*Присваиваем переменным значения*/
        public void SetVariables(char[] keys, int[] values)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                variables.Add(keys[i], values[i]);
            }
        }

        /*Логичсекое ИЛИ*/
        public int Disjunction(int A, int B)
        {
            return Math.Max(A, B);
            /*return variables[A] | variables[B];*/
        }

        /*Логическое И*/
        public int Conjunction(int A, int B)
        {
            return Math.Min(A, B);
            /*return variables[A] & variables[B];*/
        }

        /*Отрицание*/
        public int Negation(int A)
        {
            return (A + 1) % 2;
        }

        /*Равенство*/
        public int Equivalence(int A, int B)
        {
            return A == B ? 1 : 0;
        }

        /*Стремится*/
        public int Implication(int A, int B)
        {
            return Disjunction(Negation(A), B);
        }
    }
}
