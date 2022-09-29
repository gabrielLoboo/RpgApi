using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
       {

       } 

       public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Arma> Arma { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
        modelBuilder.Entity<Personagem> ().HasData
        (
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        );

        modelBuilder.Entity<Arma> ().HasData
        (
            new Arma() {Id =  1, Nome = "facaak47" , Dano = 47},
            new Arma() {Id = 2, Nome = "bazuca", Dano = 30},
            new Arma() {Id = 3, Nome = "m4", Dano = 2},
            new Arma() {Id = 4, Nome = "espadadedima", Dano = 100},
            new Arma() {Id = 5, Nome = "bananinha", Dano = 500},
            new Arma() {Id = 6, Nome = "bolacha", Dano = 250},
            new Arma() {Id = 7, Nome = "zeus", Dano = 2000}
        );
       }
        

        

    }
}