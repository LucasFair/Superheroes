using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.Model
{
	public class Superhero
	{
		private string _heroIdentity;
		private string _heroAbility;
		private string _heroCostume;
		private string _heroAssociation;
		private string _heroPolicy;
		private string _heroFoe;
		private string _heroWeakness;
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
}

