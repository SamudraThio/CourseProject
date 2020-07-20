# User Need Statement
This project is a project for the MSSA program.  The purpose of this project is the development of a system that will assist in player development by tracking and storing the stats and gears for players in a mobile massively multiplayer online role-playing game called Ragnarok Mobile.

This project accomplishes the following goals:

- Goal 1: Elicit and document project requirements
- Goal 2: Manage an interative design/implementation process
- Goal 3: Implement a web interface
- Goal 4: Integrate existing in-game equipment effects
- Goal 5: Mentor users on features

In the course of this project I will use ASP.NET and C# to build a user friendly web interface where individuals are able to submit their character data into a database and leaders in the guild are able query the collective data to track player development and growth over time.

The features of this project will include:

1) User interface for self-submission of data.

- Basic Information
	- Guild (Two Options)
	- In-Game Name
	- Class (Many Options)
	- Gold Contribution
	- Guild Contribution
	- Health Points

- Gear and card input and refine level (0-15)
	- Weapon
	- Weapon Card
	- Shield
	- Shield Card
	- Armor
	- Armor Card
	- Manteau
	- Manteau Card
	- Boots
	- Boots Card
	- Accessory 1
	- Accessory 1 Card
	- Accessory 2
	- Accessory 2 Card
	- Headgear
	- Headgear Card
	- Face
	- Mouth
	- Back
	- Tail
	
- 4th Line Enchantments Totals
	- Morale
	- Divine Blessing
	- Armor Breaking
	- Sharp Blade
	- Tenacity

- Tracker for status resistances 
	- Fear
	- Stun
	- Sleep
	- Petrify
	- Stun
	
- Class specific requirements (Examples below)
	- If the class is ArchBishop - Heal Amount
	- If the class is a Physical Damage Per Second (DPS) class 
		- Attack or Magic Attack Value
		- Defense Ignore %
		- Penetration %
	- If the class is a Magical Damage Per Second (DPS) class
		- Magic Attack Value
		- Magic Defense Ignore %
		- Magic Penetration %

- Rune Tracker
	- Input First Rune with Stats
	- Input Second Rune with Stats
	- Input Third Rune with Stats
	
- Prayer to Goddesss Tracker (Up to 200)
	- Max HP
	- Attack
	- Defense
	- Magic Defense
	
- Adventure Book Tracker
	- Max HP
	- Attack
	- Magic Attack
	- Defense
	- Magic Defense
	
2) User interface to pull their own data for modification.
	- Old data will not be written over.  Modifications will make a new copy. 

3) Instant query for priveleged roles (leaders) to be able to pull data.
	- Query data per guild
	- Query data per guild and per class
	
4) Interface for leaders to input notes for members.

Mimimum Viable Product (MVP): The MVP will allow users the ability to access the web interface and insert their basic information, gear and cards (without refines), and adventure book.  Priveleged roles are also able to query data per guild and per class.  

Full: The Full category have everything in the MVP in addition to the addition to refine levels for gear, 4th line enchantment options, specific class requirements, rune tracker and prayer to goddess tracker.

Stretch: The Stretch category will allow members to pull and modify their own data, which will retain their old data and create a new copy of their modifications.  Leaders will be able to also input notes for their members.  Equipment and cards that give status resistances will be automatically added to the status resistance section.

