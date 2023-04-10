using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conta_Corrente
{
    public class ContaCorrente
    {
        public int saldo;
        public int numero;
        public int limite;
        public bool ehespecial;
        public ArrayList movimentacoes;

        public ContaCorrente()
        {
            this.movimentacoes = new ArrayList();
        }
        public void TransferirPara(ContaCorrente contaDestino, int valor)
        {
            if (this.saldo + this.limite >= valor)
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
                contaDestino.movimentacoes.Add($" Debito: {valor}");
                if (valor >= this.saldo)
                {
                    movimentacoes.Add($"Credito: {valor * -1}");
                    this.limite -= valor - (this.limite - valor);
                }
                else
                {
                    movimentacoes.Add($"Debito: {valor * -1}");
                }
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou limite excedido.");
            }
        }
        public void Sacar(int valor)
        {
            if (this.saldo + this.limite >= valor)
            {
                this.saldo -= valor;
                if (valor >= this.saldo)
                {
                    movimentacoes.Add($"Credito: {valor * -1}");
                    this.limite -= valor - (this.limite - valor);
                }
                else
                {
                    movimentacoes.Add($" Debito: {valor * -1}");
                }
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou limite excedido.");
            }
        }
        public void Depositar(int valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                movimentacoes.Add($"Debito: {valor}");
            }
            else
            {
                Console.WriteLine("O valor não pode ser negativo.");
            }
        }
        public void ExibirExtrato()
        {
            Console.WriteLine("Numero da conta: " + this.numero);
            Console.WriteLine("Saldo: " + this.saldo);
            Console.WriteLine("Movimentações: ");
            foreach (var movimentacao in movimentacoes)
            {
                Console.WriteLine(movimentacao);
            }
        }

    }
}