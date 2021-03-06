package Avatar_API
{
	function gameConnection::spawnPlayer(%this,%a,%b,%c,%d,%e,%f,%g,%h,%i)
	{
		%p = parent::spawnPlayer(%this,%a,%b,%c,%d,%e,%f,%g,%h,%i);
		if(%this.customAvatar !$= "" && %this.isAvatarLocked() && isObject($Avatar::Object[%this.customAvatar]))
			%this.setCustomAvatar(%this.customAvatar);
		return %p;
	}
	function serverCmdUpdateBodyColors(%client,%arg1,%arg2,%arg3,%arg4,%arg5,%arg6,%arg7,%arg8,%arg9,%arg10,%arg11,%arg12,%arg13,%arg14,%arg15)
	{
			if(%this.customAvatar !$= "" && %this.isAvatarLocked() && isObject($Avatar::Object[%this.customAvatar])) return false;
			%parent = parent::serverCmdUpdateBodyColors(%client,%arg1,%arg2,%arg3,%arg4,%arg5,%arg6,%arg7,%arg8,%arg9,%arg10,%arg11,%arg12,%arg13,%arg14,%arg15);
			return %parent;
	}
	
	function gameConnection::applyBodyColors(%client)
	{
		if(%this.customAvatar !$= "" && %this.isAvatarLocked() && isObject($Avatar::Object[%this.customAvatar])) return false;
		%parent = parent::applyBodyColors(%client);
		return %parent;				

	}
	
	function gameConnection::applyBodyParts(%client)
	{
		if(%this.customAvatar !$= "" && %this.isAvatarLocked() && isObject($Avatar::Object[%this.customAvatar])) return false;
		%parent = parent::applyBodyParts(%client);
		return %parent;
	}
};
activatePackage(Avatar_API);

function gameConnection::lockAvatar(%this)
{
	%this.lockAvatar = true;
}

function gameConnection::unlockAvatar(%this)
{
	%this.lockAvatar = false;
}

function gameConnection::isAvatarLocked(%this)
{
	return %this.lockAvatar == true;
}

function gameConnection::setDefaultAvatar(%this)
{
	%this.applyBodyColors();
	%this.applyBodyParts();
}

function gameConnection::setHeadSmiley(%this,%smiley)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%smiley))
		%smiley = $AvatarAPI::smiley[%smiley];
	%player.setFaceName(%smiley);
}

function gameConnection::setHeadColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("headSkin",%color);
}

function gameConnection::setHatType(%this,%type)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	for(%i=0;%i<$AvatarAPI::hatCount;%i++)
	{
		%hat = $AvatarAPI::hat[%i];
		%player.hideNode(%hat);
	}
	if(isNumber(%type))
	{
		%type = $AvatarAPI::hat[%type];
		if(%type $= "")
			return true;
	}
	%player.unHideNode(%type);
}

function gameConnection::setHatColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::hat[%type];
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::hatCount;%i++)
	{
		%hatType = $AvatarAPI::hat[%i];
		%player.setNodeColor(%hatType,%color);
	}
}

function gameConnection::setHatAccentType(%this,%type)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	for(%i=0;%i<$AvatarAPI::accentCount;%i++)
	{
		%accent = $AvatarAPI::accent[%i];
		%player.hideNode(%accent);
	}
	if(isNumber(%type))
	{
		%type = $AvatarAPI::accent[%type];
		if(%type $= "")
			return true;
	}
	%player.unHideNode(%type);
}

function gameConnection::setHatAccentColor(%this,%type,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::accent[%type];
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor(%type,%color);
}

function gameConnection::setBodyColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("chest",%color);
	%player.setNodeColor("femChest",%color);
}

function gameConnection::setBodyDecal(%this,%decal)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%decal))
	{
		%decal = $AvatarAPI::decal[%decal];
		if(%decal $= "")
		{
			%player.setDecalName("");
			return true;
		}
	}
	%player.setDecalName(%decal);
}

function gameConnection::setBodyType(%this,%val)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(%val $= "0" || %val $= "male")
	{
		%player.hideNode("femChest");
		%player.unHideNode("chest");
	}
	else
	if(%val $= "1" || %val $= "female")
	{
		%player.unhideNode("femChest");
		%player.HideNode("chest");		
	}
}

function gameConnection::setPantsColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("pants",%color);
	%player.setNodeColor("skirtHip",%color);
}

function gameConnection::setPantsType(%this,%val)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(%val $= "0" || %val $= "male")
	{
		%player.hideNode("skirtHip");
		%player.hideNode("skirtTrimLeft");
		%player.hideNode("skirtTrimRight");
		%player.unHideNode("pants");
		%player.unHideNode("lshoe");
		%player.unHideNode("rshoe");
	}
	else
	if(%val $= "1" || %val $= "Female")
	{
		%player.unhideNode("skirtHip");
		%player.unHideNode("skirtTrimLeft");
		%player.unHideNode("skirtTrimRight");
		%player.hideNode("pants");	
		%player.hideNode("lshoe");
		%player.hideNode("rshoe");		
	}
}

function gameConnection::setRightArmColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("rarm",%color);
}

function gameConnection::setLeftArmColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("larm",%color);
}

function gameConnection::setRightHandType(%this,%type)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::handType[%type];
	if(%type $= "Hand")
	{
		%player.hideNode("rhook");
	}
	else
	if(%type $= "Hook")
	{
		%player.hideNode("rhand");
	}
	%player.unHideNode("r" @ %type);
}

function gameConnection::setLeftHandType(%this,%type)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::handType[%type];
	if(%type $= "Hand")
	{
		%player.hideNode("lhook");
	}
	else
	if(%type $= "Hook")
	{
		%player.hideNode("lhand");
	}
	%player.unHideNode("l" @ %type);
}

function gameConnection::setRightHandColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::handTypeCount;%i++)
	{
		%handType = $AvatarAPI::handType[%i];
		%player.setNodeColor("r" @ %handType,%color);
	}
}

function gameConnection::setLeftHandColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::handTypeCount;%i++)
	{
		%handType = $AvatarAPI::handType[%i];
		%player.setNodeColor("l" @ %handType,%color);
	}
}

function gameConnection::setRightShoeColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	
	for(%i=0;%i<$AvatarAPI::shoeCount;%i++)
	{
		%shoeType = $AvatarAPI::shoe[%i];
		%player.setNodeColor("r" @ %shoeType,%color);
	}
	%player.setNodeColor("skirtTrimRight",%color);
}

function gameConnection::setLeftShoeColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::shoeCount;%i++)
	{
		%shoeType = $AvatarAPI::shoe[%i];
		%player.setNodeColor("l" @ %shoeType,%color);
	}
	%player.setNodeColor("skirtTrimLeft",%color);
}

function gameConnection::setLeftShoeType(%this,%type)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::shoe[%type];
	if(%type $= "ski")
	{
		%player.hideNode("lshoe");
		%player.hideNode("lpeg");
		%player.unHideNode("lski");
	}
	else
	if(%type $= "shoe")
	{
		%player.hideNode("lpeg");
		%player.hideNode("lski");	
		%player.unHideNode("lshoe");		
	}
	else
	if(%type $= "peg")
	{
		%player.hideNode("lshoe");
		%player.hideNode("lski");
		%player.unHideNode("lpeg");
	}
}

function gameConnection::setRightShoeType(%this,%type)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::shoe[%type];
	if(%type $= "ski")
	{
		%player.hideNode("rshoe");
		%player.hideNode("rpeg");
		%player.unHideNode("rski");
	}
	else
	if(%type $= "shoe")
	{
		%player.hideNode("rpeg");
		%player.hideNode("rski");	
		%player.unHideNode("rshoe");		
	}
	else
	if(%type $= "peg")
	{
		%player.hideNode("rshoe");
		%player.hideNode("rski");
		%player.unHideNode("rpeg");
	}
}

function gameConnection::setPackType(%this,%type)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::packType[%type];
	for(%i=0;%i<$AvatarAPI::packTypeCount;%i++)
	{
		%packType = $AvatarAPI::packType[%i];
		%player.hideNode(%packType);
	}
	if(%type $= "")
	{
		return false;
	}
	%player.unHideNode(%type);
}

function gameConnection::setPackColor(%this,%color)
{
	%player = %this.player;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::packTypeCount;%i++)
	{
		%packType = $AvatarAPI::packType[%i];
		%player.setNodeColor(%packType,%color);
	}
}

function gameConnection::setCustomAvatar(%this,%name)
{
	%avname = "Avatar_" @ %name @ ".cs";
	if(isFile("./Avatars/" @ %avName))
	{
		exec("./Avatars/" @ %avName);
		%avatar = $Avatar::Object[%name];
		if(!$Avatar::Exists[%name])
		{
			error("Avatar " @ %avatar @ " is not a valid object.");
			return false;
		}
		%this.customAvatar = %name;
		%attrCount = %avatar.attributeCount;
		for(%i=0;%i<%attrCount;%i++)
		{
			%data = %avatar.getTaggedField(%i);
			if(%data $= "")
				continue;
			%attribute = getField(%data,0);
			%value = getField(%data,1);
			%functionCheck = "set" @ %attribute;
			%function = ".set" @ %attribute @ "(\"" @ %value @ "\");";
			if(isFunction("gameConnection",%functionCheck))
			{
				eval(%this @ "" @ %function);
			}
		}
	}
}

function gameConnection::setAvatarName(%this,%string)
{
	if(%string $= "") return false;
	
	%this.customAvatar = %name;
	return true;
}

function Avatar::onAdd(%this)
{
	%name = %this.name;
	if($Avatar::Exists[%name])
	{
		$Avatar::Object[%name].delete();
	}
	$Avatar::Exists[%name] = true;
	$Avatar::Object[%name] = %this;
}

//isNumber function by Clockturn..
function isNumber(%string)
{
	if(%string <= 999999 && (%string >= -999999))
	{
		// Fast solution
		return %string $= %string * 1;
	}

	else
	{
		// Slow solution
		%dot = 0; // Track if period present
		%sci = 0; // Track if scientific notation present

		for(%j = 0; %j < strLen(%string); %j++)
		{
			%c = getSubStr(%string, %j, 1);

			if(%c $= "-")
			{
				if(%sci == -1)
				{
					%sci = 1; // Negative powers
				}

				else if(%j != 0)
				{
					return false; // Negative not the first character
				}

				continue;
			}

			if(%c $= ".")
			{
				if(%dot || %j == 0)
				{
					return false; // Multiple periods or nothing before the period
				}

				else
				{
					%dot = 1;
				}

				continue;
			}

			if(%c $= "e")
			{
				if(%sci != 0)
				{
					return false; // Multiple Es present
				}

				else
				{
					%sci = -1;
				}

				continue;
			}

			if(%c $= "+")
			{
				if(%sci != -1)
				{
					return false; // + is not part of e+ scientific notation
				}

				else
				{
					%sci = 1;
				}

				continue;
			}

			if(%sci == -1 || strPos("0123456789", %c) == -1)
			{
				return false; // An E was present without a + or the current character is not a number
			}
		}

		if(%sci == -1)
		{
			return false; // Last character was an E.
		}

		return true; // Gamut has been run, nothing returned, ergo it is fine
	}
}