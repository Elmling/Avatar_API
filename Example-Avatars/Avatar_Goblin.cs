//=======================================================
//		Author: Elm
//		BL_ID: 35295
//
//		Framework for an Avatar
//			You should leave this as a skeleton,
//			Copy and paste to make new Avatar files
//			Or download the batch file to Generate
//			New avatars. You can view the Batch 
//			Source Code and self-compile it
//				here: https://github.com/Elmling/Avatar_API/blob/Avatar-Generator-(BATCH)/GenerateAvatar.bat
//			Or download it
//				here: https://github.com/Elmling/Avatar_API/releases/tag/v1.0
//
//		Tools
//			Color Picker: http://www.w3schools.com/tags/ref_colorpicker.asp
//=========================================================

new scriptObject()
{
	//DO NOT MODIFY
	AttributeCount = 100;
	Class = Avatar;
	//==============
	
	//Name of Avatar
	//Needs to be the save as the File
	//If your file is named Avatar_Test.txt
	//Then the name field should be Test
	Name = "Goblin";
	
	//List Of Default Accents
	//	Plume
	//	Triplume
	//	Septplume
	//========================
	AccentType = "";
	
	//Takes an HSL plus Transparency Value
	//Example: 0.53 0.84 1.55 1
	AccentColor = "";

	//List of Defaults Hats
	//======================================
	//	Helmet		PointyHelmet	FlareHelmet
	//	Scouthat	Bicorn			Cophat
	//	Knithat
	//======================================
	HatType = "scouthat";
	
	//Takes an HSL plus Transparency Value
	//Example: 0.53 0.84 1.55 1
	HatColor = "0.6 0.33 0.25 1";
	
	//List Of Default Smileys
	//	BrownSmiley 	ChefSmiley 		KleinerSmiler
	//	Male07Smiley	Orc				AdamSavage
	//	Jamie			AsciiTerror		MemeBlockMongler
	//	MemeCats		MemeDesu		MemeGrinMan
	//	MemeHappy		MemePBear		MemeYaranika
	//	SmileyBlonde	SmileyCreepy	SmileyEvil1
	//	SmileyEvil2		SmileyOld		SmileyPirat1
	//	SmileyPirate2	SmileyPirate3	SmileyRedBeard
	//	SmileyRedBeard2
	//=================================================
	HeadSmiley = "Orc";
	
	//Takes an HSL plus Transparency Value
	//Example: 0.53 0.84 1.55 1
	HeadColor = "1.2 1 0.25 1";
	
	//Takes an HSL plus Transparency Value
	//Example: 0.53 0.84 1.55 1
	BodyColor = "1.2 1 0.25 1";
	
	//List Of Default Decals
	//	Alyx			Archer			Chef
	//	DKnight			DrKleiner		HCZombie
	//	Knight 			LinkTunic		Hoodie
	//	Medieval-Eagle	Medieval-Rider	Medieval-Tunic
	//	Medieval-YARLY	Meme-Mongler	Mod-Army
	//	Mod-DareDevil	Mod-Pilot		Mod-Prisoner
	//	Mod-Suit		Space-Nasa		Space-New
	//	Space-Old		Worm-Engineer	Worm-Sweater
	//===============================================
	BodyDecal = "";
	
	//String
	//"Male" 
	//	or
	//"Female"
	BodyType = "female";
	
	//Default list of hand types
	//===========================
	//	hand	hook
	//===========================
	leftHandType = "hook";
	rightHandType = "hook";
	
	//Takes an HSL plus Transparency Value
	//Example: 0.53 0.84 1.55 1
	//=====================================
	LeftArmColor = "1.2 1 0.25 1";
	RightArmColor = "1.2 1 0.25 1";
	
	rightHandColor = "1.2 1 0.25 1";
	leftHandColor = "1.2 1 0.25 1";

	LeftShoeColor = "1.2 1 0.25 1";
	RightShoeColor = "1.2 1 0.25 1";

	PantsColor = "0.6 0.32 0.15 1";
	//=====================================
	
	//String
	//"Male"
	//	or
	//"Female"
	PantsType = "male";
	
	//String
	//"Lpeg"
	//	or
	//"Lshoe"
	//	or
	//"Lski"
	LeftShoeType = "shoe";
	
	//String
	//"Rpeg"
	//	or
	//"Rshoe"
	//	or
	//"Rski"
	RightShoeType = "shoe";

	//List of Default Packs
	//===========================
	//	Armor	Bucket	Cape
	//	Pack	Quiver	Tank
	//===========================
	PackType = "armor";
	
	//Takes an HSL plus Transparency Value
	//Example: 0.53 0.84 1.55 1	
	PackColor = "0.6 0.33 0.25 1";
	
};