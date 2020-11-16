/// Homework No.__ Exercise No.__
/// File Name:     HW10.sln
/// @author:       Upendra Samaranayake
/// Date:          Nov. 16, 2020
///
/// Problem Statement: Create derived classes for Alien through inheritence and add a Get Damage method.
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create getDamage method in the Alien class deleting the type parameter.
/// 2. Create a series of derived classes through inheritence to represent the different types of aliens.
/// 3. Create a main driver that tests the methods.

///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework11
{

	class Alien
	{
		public const int SNAKE_ALIEN = 0;
		public const int OGRE_ALIEN = 1;
		public const int MARSHMALLOW_MAN_ALIEN = 2;
		private int health; // 0=dead, 100=full strength
		private string name;

		public Alien()
		{

		}

		public Alien(int health, string name)
		{
			this.health = health;
			this.name = name;
		}

		public virtual int Health
		{
			get
			{
				return health;
			}
			set
			{
				this.health = value;
			}
		}


		public virtual string Name
		{
			get
			{
				return name;
			}
			set
			{
				this.name = value;
			}
		}


		public virtual int Damage
		{
			get
			{
				return 0;
			}
		}
	}
	class SnakeAlien : Alien
	{

		public SnakeAlien() : base()
		{
		}

		public SnakeAlien(int health, string name) : base(health, name)
		{
		}

		public override int Damage
		{
			get
			{
				return 10;
			}
		}
	}
	class OgreAlien : Alien
	{

		public OgreAlien() : base()
		{
		}

		public OgreAlien(int health, string name) : base(health, name)
		{
		}

		public override int Damage
		{
			get
			{
				return 6;
			}
		}
	}
	class MarshmallowAlien : Alien
	{

		public MarshmallowAlien() : base()
		{
		}

		public MarshmallowAlien(int health, string name) : base(health, name)
		{
		}

		public override int Damage
		{
			get
			{
				return 1;
			}
		}
	}
	class AlienPack
	{

		private Alien[] aliens;

		public AlienPack(int numAliens)
		{
			aliens = new Alien[numAliens];
		}

		public virtual void addAlien(Alien newAlien, int index)
		{
			aliens[index] = newAlien;
		}

		public virtual Alien[] Aliens
		{
			get
			{
				return aliens;
			}
		}

		public virtual int calculateDamage()
		{
			int damage = 0;
			for (int i = 0; i < aliens.Length; i++)
			{
				damage += aliens[i].Damage;
			}

			return damage;
		}
	}
	class AlienDemo
	{
		public static void Main(string[] args)
		{
			OgreAlien brutus = new OgreAlien(); // please finish this
			SnakeAlien slimy = new SnakeAlien(); // please finish this
			MarshmallowAlien puffy = new MarshmallowAlien(); // please finish this
			AlienPack pack = new AlienPack(3); // 3 aliens in the pack
			pack.addAlien(brutus, 0);
			pack.addAlien(slimy, 1);
			pack.addAlien(puffy, 2);
			Console.WriteLine("Total pack damage = " + pack.calculateDamage());

		}
	}
}
