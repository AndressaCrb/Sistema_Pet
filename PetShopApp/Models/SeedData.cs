using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PetShopApp.Models
{
	public static class SeedData
	{
		public static void Inicializar(IServiceProvider serviceProvider)
		{
			using(var context = new PetShopAppContext(
				serviceProvider.GetRequiredService<
				DbContextOptions<PetShopAppContext>>()))
			{
				// verificar se há dados no banco
				if (context.Proprietario.Any()) 
				{

				} 
				else 
				{
					context.Proprietario.AddRange(
						new Proprietario
						{
							Nome = "Maria Aparecida Leão",  
							CPF = "1111111111",
							Endereco = "Rua américa,23",
							Telefone = "14 999030606",
							Email = "mar_aparecidal@outlook.com",
							DtNascimento = DateTime.Parse("29/09/1955")
						},
						new Proprietario
						{
							Nome = "João Fernando Oliveira",  
							CPF = "22222222222",
							Endereco = "Av Esmeraldas, 908",
							Telefone = "14 997625399",
							Email = "feroliveira_10@gmail.com",
							DtNascimento = DateTime.Parse("23/05/1980")
						},
						new Proprietario
						{
							Nome = "Marina Ferreira Gomes",  
							CPF = "33333333333",
							Endereco = "Rua pedro de toledo,34",
							Telefone = "14 997548765",
							Email = "ferreira.marina@hotmail.com",
							DtNascimento = DateTime.Parse("06/02/2003")
						},
						new Proprietario
						{
							Nome = "Bento Frederico Seiti",  
							CPF = "44444444444",
							Endereco = "Rua dos gados,69",
							Telefone = "14 988733644",
							Email = "fred_benseiti@univem.edu",
							DtNascimento = DateTime.Parse("23/08/1999")
						}
					);
				}

				if (context.Produto.Any()) 
				{

				} 
				else 
				{
					context.Produto.AddRange(
						new Produto
						{
							Nome = "Ração Premier 10kg",
							Descricao = "Ração para o seu pet, com a melhor qualidade e preço",
							QuantidadeEstoque = 30,
							PrecoCompra = 185.00f, 
							PrecoVenda = 249.00f
						},
						new Produto
						{
							Nome = "Cama redonda Pet",
							Descricao = "Cama redonda confortavél para o seu pet",
							QuantidadeEstoque = 10,
							PrecoCompra = 30.00f, 
							PrecoVenda = 64.00f
						},
						new Produto
						{
							Nome = "Shampoo Pet Clear 5L",
							Descricao = "Shampoo para pet",
							QuantidadeEstoque = 24,
							PrecoCompra = 30.20f, 
							PrecoVenda = 45.50f
						}
					);
				}
				context.SaveChanges();
			}
		}
	}
}