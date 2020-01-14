using System;
using System.Collections.Generic;
using System.Text;

namespace POOExercicio01
{
    class Veiculo
    {
		private String Marca;
		private String Modelo;
		private String Placa;
		private String Cor;
		private float Km;
		private bool isLigado;
		private int litrosCombustivel;
		private int Velocidade;
		private double Preco;

		public Veiculo(String mar, String mod, String pla, String cor, float km, bool ligado, int comb, int vel, double prec)
		{
			this.setMarca(mar);
			this.setModelo(mod);
			this.setPlaca(pla);
			this.setCor(cor);
			this.setKm(km);
			this.boolSetLigado(ligado);
			this.setLitrosCombustivel(comb);
			this.setVelocidade(0);
			this.setPreco(prec);
		}

		public void status()
		{
			Console.WriteLine("");
			Console.WriteLine("Marca: " + this.getMarca());
			Console.WriteLine("Modelo: " + this.getModelo());
			Console.WriteLine("Placa: " + this.getPlaca());
			Console.WriteLine("Cor: " + this.getCor());
			Console.WriteLine("Km: " + this.getKm());
			if(this.isLigado)
				Console.WriteLine("O carro está ligado");
			else
				Console.WriteLine("O carro está desligado");
			Console.WriteLine("Combustivel (litros): " + this.getLitrosCombustivel());
			Console.WriteLine("Velocidade: " + this.getVelocidade());
			Console.WriteLine("Preço: " + this.getPreco());

			Console.WriteLine("");
		}

		public void ligar()
		{
			if (isLigado)
			{
				Console.WriteLine("O carro já está ligado!");
			}
			else
			{
				Console.WriteLine("O carro ligou.");
				this.isLigado = true;
			}
		}

		public void desligar()
		{
			if (!isLigado)
			{
				Console.WriteLine("O carro já está desligado!");
			}
			else
			{
				Console.WriteLine("O carro desligou.");
				isLigado = false;
			}
		}

		public void acelerar()
		{
			if (!isLigado)
				Console.WriteLine("O carro está desligado.");
			else if (this.litrosCombustivel > 0)
			{
				this.Velocidade += 20;
				this.litrosCombustivel -= 1;
				Console.WriteLine("O carro está em " + this.Velocidade + " KM por hora.");
				Console.WriteLine("O carro tem " + this.litrosCombustivel + " litros de combustível");
			}
			else
			{
				Console.WriteLine("O carro etá sem combustível!");
				this.isLigado = false;
				this.Velocidade = 0;
			}
		}

		public void frear()
		{
			if (this.isLigado && this.Velocidade > 0)
			{
				if (this.Velocidade < 10)
				{
					this.Velocidade = 0;
					Console.WriteLine("O carro está parado.");
				}
				else
				{
					this.Velocidade -= 10;
					Console.WriteLine("A velocidade do carro é de " + this.Velocidade + " KM por hora.");
				}
			}
			else
			{
				Console.WriteLine("O carro está parado.");
			}
		}

		public void abastecer(int qtdLitros)
		{
			int dif = 0;
			if (this.litrosCombustivel + qtdLitros > 100)
			{
				dif = 100 - this.litrosCombustivel;
				this.litrosCombustivel = 100;
				Console.WriteLine("Você tentou abastecer " + qtdLitros + " litros, porém você abasteceu apenas " + dif + " litros, pois seu tanque encheu, agora você tem " + this.litrosCombustivel + " litros.");
			}
			else
			{
				litrosCombustivel += qtdLitros;
				Console.WriteLine("Você abasteceu " + qtdLitros + " litros, seu tanque agora tem " + litrosCombustivel + " litros.");
			}
		}

		public void pintar(String corNova)
		{
			this.Cor = corNova;
			Console.WriteLine("Você pintou seu carro com a cor " + this.Cor + ".");
		}

		public String getMarca()
		{
			return Marca;
		}

		public void setMarca(String marca)
		{
			Marca = marca;
		}

		public String getModelo()
		{
			return Modelo;
		}

		public void setModelo(String modelo)
		{
			Modelo = modelo;
		}

		public String getPlaca()
		{
			return Placa;
		}

		public void setPlaca(String placa)
		{
			Placa = placa;
		}

		public String getCor()
		{
			return Cor;
		}

		public void setCor(String cor)
		{
			Cor = cor;
		}

		public float getKm()
		{
			return Km;
		}

		public void setKm(float km)
		{
			Km = km;
		}

		public bool boolIsLigado()
		{
			return isLigado;
		}

		public void boolSetLigado(bool isLigado)
		{
			this.isLigado = isLigado;
		}

		public int getLitrosCombustivel()
		{
			return litrosCombustivel;
		}

		public void setLitrosCombustivel(int litrosCombustivel)
		{
			this.litrosCombustivel = litrosCombustivel;
		}

		public int getVelocidade()
		{
			return Velocidade;
		}

		public void setVelocidade(int velocidade)
		{
			Velocidade = velocidade;
		}

		public double getPreco()
		{
			return Preco;
		}

		public void setPreco(double preco)
		{
			Preco = preco;
		}

	}
}
