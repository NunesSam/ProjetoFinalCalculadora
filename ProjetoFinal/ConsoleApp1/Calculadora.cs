using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;
        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }


        public int Somar(int v1, int v2)
        {
            int res = v1 + v2;
            //listaHistorico.Insert(0, "Resultado: " + res);
            listaHistorico.Insert(0, "Soma de " + v1 + " + " + v2 + " = " + res + " - Data: " + this.data);
            return res;
        }

        public int Subtrair(int v1, int v2)
        {
            int res = v1 - v2;
            //listaHistorico.Insert(0, "Resultado: " + res);
            listaHistorico.Insert(0, "Subtração de " + v1 + " + " + v2 + " = " + res + " - Data: " + this.data);
            return res;
        }
        public int Multiplicar(int v1, int v2)
        {
            int res = v1 * v2;
            //listaHistorico.Insert(0, "Resultado: " + res);
            listaHistorico.Insert(0, "Multiplicação de " + v1 + " + " + v2 + " = " + res + " - Data: " + this.data);
            return res;
        }
        public int Dividir(int v1, int v2)
        {
            int res = v1 / v2;
            //listaHistorico.Insert(0, "Resultado: " + res);
            listaHistorico.Insert(0, "Divisão de " + v1 + " + " + v2 + " = " + res + " - Data: " + this.data);
            return res;
        }
        public List<string> historico()
        {
            if (listaHistorico.Count > 3)
            {
                listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            }
            return listaHistorico;
        }

    }
}
