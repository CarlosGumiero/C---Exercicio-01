using System;

namespace POOExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro1 = new Veiculo ("Toyota", "Etios", "RGB1100", "Vermelho", 1000, false, 50, 0, 50000);

            carro1.status();

            carro1.abastecer(200);
            carro1.pintar("verde");
            carro1.desligar();
            carro1.ligar();
            carro1.acelerar();
            carro1.frear();

            carro1.status();
        }
    }
}
