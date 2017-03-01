using System;

// Written by Alex B
using System.Collections.Generic;


namespace AssemblyCSharp
{
	public class Player
	{
		// private username and password
		string username { get; private set;}
		string password { get; private set;}
		// status, vps, gold, and longestRoad are simple c# attributes
		PlayerStatus status { get; set; }
		int defenderOfCatanVPs { get; set; }
		int gold { get; set; }
		bool longestRoad { get; set; }
		// using dictionary for holding resources and commodities
		Dictionary<StealableType, int> ownedResources= new Dictionary<StealableType, int>();
		// using list for holding owned progress cards
		List<ProgressCardType> ownedProgressCards = new List<ProgressCardType>();

		// using list for holding all owned units
		// waiting on ownable units to be created before removing comment

		//List<OwnableUnit> ownedUnits = new ListPriorityQueue<OwnableUnits>();

		// NOTE: we can use the built-in methods for the list and dictionary to edit the values

		// constructor
		public Player (string u, string p)
		{
			this.username = u;
			this.password = p;
			this.status = "Available";
			this.defenderOfCatanVPs = 0;
			this.defenderOfCatanVPs = 0;
			this.gold = 0;
			this.longestRoad = false;
		}

	}
}

