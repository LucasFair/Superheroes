using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
	/// <summary>
	/// Class <c>Superhero</c> is a temple for a superhero.
	/// </summary>
	public class Superhero
	{
		private string _heroRealName;
		private string _heroIdentity;
		private string _heroAbility;
		private string _heroCostume;
		private string _heroAssociation;
		private string _heroPolicy;
		private string _heroFoe;
		private string _heroWeakness;

		public string HeroRealName
		{
			get { return _heroRealName; }
			set { _heroRealName = value; }
		}
		public string HeroIdentity
		{
			get { return _heroIdentity; }
			set { _heroIdentity = value; }
		}
		public string HeroAbility
		{
			get { return _heroAbility; }
			set { _heroAbility = value; }
		}
		public string HeroCostume
		{
			get { return _heroCostume; }
			set { _heroCostume = value; }
		}
		public string HeroAssociation
		{
			get { return _heroAssociation; }
			set { _heroAssociation = value; }
		}
		public string HeroPolicy
		{
			get { return _heroPolicy; }
			set { _heroPolicy = value; }
		}
		public string HeroFoe
		{
			get { return _heroFoe; }
			set { _heroFoe = value; }
		}
		public string HeroWeakness
		{
			get { return _heroWeakness; }
			set { _heroWeakness = value; }
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Superhero spiderman = new Superhero();
			spiderman.HeroRealName = "Peter Parker";
			spiderman.HeroIdentity = "Spider-Man";
			spiderman.HeroAbility = "Stick'em Powers";
			spiderman.HeroCostume = "Red and Blue";
			spiderman.HeroAssociation = "(Currently) Solo";
			spiderman.HeroPolicy = "\"With great powers, come great responsibilities.\"";
			spiderman.HeroFoe = "Green Goblin, Venom, Kraven, Hobgoblin, Kingpin, Carnage, " +
				"Hammerhead, Rhino, Black Cat, Vulture, Electro, Shocker.";
			spiderman.HeroWeakness = "Brine";

			Console.WriteLine("This hero's real name is: " + spiderman.HeroRealName + " " +
				"and their superhero name is: " + spiderman.HeroIdentity + ".\n" +
				"Their ablitiy is: " + spiderman.HeroAbility + " and their costume is: " + spiderman.HeroCostume + "\n" +
				"They method of operation is: " + spiderman.HeroAssociation + ".\n" +
				"Their policy is: " + spiderman.HeroPolicy + "\n" +
				"The weakness of this hero is: " + spiderman.HeroWeakness + ".");

		}
	}
}
