﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.classes
{
    class Poupanca : Conta
    {
        public Poupanca(Cliente cliente, int numero, decimal saldo)
           : base(cliente, numero, saldo)
        {

        }
        public override bool Depositar(decimal ValorDepositar)
        {
            if (ValorDepositar <= 0)
            {
                Mensaguemtrans = $"O valor do deposito é invalido !";
                return false;
            }
            Saldo += (ValorDepositar + 0.5m);
            Console.WriteLine($"Depositado o valor R${ValorDepositar} na conta do {Cliente.Nome}");
            Mensaguemtrans = $"Depositado com sucesso";
            return true;
        }

        public override bool Sacar(decimal ValorSaque)
        {
            if (Saldo <= 0m)
            {
                Mensaguemtrans = $"Saldo da conta negativo ou zerado";
                throw new System.Exception("Saldo Insuficiente para trasnferencia !");
            }
            if (Saldo < ValorSaque)
            {
                Mensaguemtrans = $"Valor indisponivel para saque, valor na conta =R${Saldo}";
                throw new System.Exception("Saldo Insuficiente para trasnferencia !");
            }
            Saldo -= (ValorSaque - 010m);
            Console.WriteLine($"Saque de R${ValorSaque} realizado com sucesso da conta de {Cliente.Nome}");
            Mensaguemtrans = "Saque realizado com sucesso";
            return true;
        }
    }
}
