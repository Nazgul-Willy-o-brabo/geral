using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchBank.Entities.Exceptions;

namespace TryCatchBank.Entities
{
    internal class Conta
    {
        private int _numCnt;
        private String _nomeCli;
        private Double _saldo;
        private Double _limite; //Limite p. saldo


        public int NumCnt { get => _numCnt; set => _numCnt = value; }
        public string NomeCli { get => _nomeCli; set => _nomeCli = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public double Limite { get => _limite; set => _limite = value; }



        public Conta() { }
        public Conta(int numCnt, string nomeCli, double saldo, double limite)
        {
            if(saldo <= 0)
            {
                throw new Exception("Valor de saldo invalido!\nSolução: Insira ao menos algum valor de saldo incial!");
            }
            NumCnt = numCnt;
            NomeCli = nomeCli;
            Saldo = saldo;
            Limite = limite;
        }


        public void Deposito(Double valor) {
        Saldo += valor;
        }
        public void Saque(Double valor) {
        if(Saldo <= 0)
            {
                throw new Exception("Saldo zerado ou negativado\nSolução: É necessario saldo em conta");
            }
        if(valor > Limite)
            {
                throw new Exception("Não é possivel sacar pois ultrapassa o limite!\nSolução: Tente um valor menor");
            }
        if((Saldo -= valor) < 0)
            {
                throw new Exception("Não há saldo suficiente!");
            }
        Saldo -= valor;
        }
    }
}
