namespace _04__Atividade
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Velocidade { get; set; }




        public Carro(string marca, string modelo, int velocidade)
            {
                Marca = marca;
                Modelo = modelo;
                Velocidade = velocidade;


            }


            public void Acelerar()
            {
                Console.WriteLine($"O carro acelera até a velocidade {Velocidade}");
            }

            public void Desacelera()
            {
                Console.WriteLine($"O carro desacelera com a velocidade {Velocidade}");
            }

        }

    }
