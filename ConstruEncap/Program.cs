using System;
using System.Globalization;

namespace ConstruEncap {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);
            
            p.Nome = "tvzinha";

        }
    }
}
