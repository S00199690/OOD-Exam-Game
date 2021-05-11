using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanMcDonald_S00199690
{
    public class Game
    {
        //properties
        
        public int GameID { get; set; }
        public string Name { get; set; }

        public int CriticScore { get; set; }

        public string Description { get; set; }

        public string Platform { get; set; }

        public decimal Price { get; set; }

        public string GameImage { get; set; }

        //constuctors

        public Game(string name, string platform, int criticScore, decimal price, string gameImage, string description)
        {
            Name = name;
            Platform = platform;
            CriticScore = criticScore;
            Price = price;
            GameImage = gameImage;
            Description = description;
        }
        public Game()
        {

        }

        //methods

        public override string ToString()
        {
            return Name;
        }

        //unit test method
        public decimal DecreasePrice(decimal number)
        {
            Price = Price - number;
            return Price;
        }

        public class GameData : DbContext
        {
            //name of database
            public GameData() : base("MyGameData") //db name
            {

            }

            //creates Game Table
            public DbSet<Game> Games { get; set; }

        }


    }
}
