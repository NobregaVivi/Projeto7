using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> listahistorico = new List<string>();
        private string data;    
        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
        private int somar(int val1, int val2)
        {
          int resultado = val1 + val2;
          listahistorico.Insert(0,"Res:" + resultado + "- data:" + data);
          return resultado;
        }
         public int subtrair(int val1, int val2)
        {
           int resultado = val1 - val2;
           listahistorico.Insert(0,"Res:" + resultado+ "- data:" + data);
          return resultado;
        }
         public int multiplicar(int val1, int val2)
        {
           int resultado = val1 * val2;
           listahistorico.Insert(0,"Res:" + resultado+ "- data:" + data);
          return resultado;
        }
         public int dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            listahistorico.Insert(0,"Res:" + resultado+ "- data:" + data);
          return resultado;
        }

        public List<string> historico()
        {
            
            listahistorico.RemoveRange(3,listahistorico.Count - 3);
            return listahistorico;
        }

    }
}