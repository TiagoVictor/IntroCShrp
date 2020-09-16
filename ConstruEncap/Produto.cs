using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConstruEncap {
    class Produto {
        //Em c# quando colocamos os atributos como private devem ser feitos com esse nome
        //Auto Propertie é usada na declaraçao do atributo ja realizando assim o Get e o Set da classe
        //Auto Propertie é recomendada caso o atributo nao possua uma logica a ser realizada no seu get/set.

        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtores
        public Produto() {
            Quantidade = 10;
        }
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Construtor com referencia a outro construtor
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }
        /* Propertie Manual
         * public string Nome{
         * get{ return _nome; }
         * set{ _nome = value }
         * 
         */


        //Métodos
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


//Ordem sugerida
// 1- Atributos privados
// 2- Propriedades autoimplementadas
// 3- Contrutores
// 4- Propriedades manuais
// 5- Metodos 
