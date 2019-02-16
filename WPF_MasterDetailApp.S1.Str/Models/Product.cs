using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
	public class Product
	{
		#region ENUMS

		public enum Element
		{
			WATER,
			FIRE,
			ICE,
			THUNDER,
			BLAST,
			POISON,
			DRAGON
		}

		#endregion

		#region FIELDS

		private string _name;
		private string _monsterType;
		private Element _weakness;
		private double _size;
		private int _generation;
		private Element _monsterElement;
		private string _description;
		private string _imageFileName;

		#endregion

		#region PROPERTIES

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string MonsterType
		{
			get { return _monsterType; }
			set { _monsterType = value; }
		}

		public Element Weakness
		{
			get { return _weakness; }
			set{ _weakness = value; }
		}

		public double Size
		{
			get { return _size; }
			set { _size = value; }
		}

		public int Generation
		{
			get { return _generation; }
			set { _generation = value; }
		}

		public Element MonsterElement
		{
			get { return _monsterElement; }
			set { _monsterElement = value; }
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public string ImageFileName
		{
			get { return _imageFileName; }
			set { _imageFileName = value; }
		}


		public string ImageFilePath
		{
			get { return @"../Images/" + _imageFileName; }
		}

		#endregion

		#region CONSTRUCTORS

		public Product()
		{

		}

		#endregion

		#region METHODS


		#endregion

		#region EVENTS



		#endregion
	}
}
