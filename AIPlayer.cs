//Avatar API Variables initialized in GameConnection.cs

function AIPlayer::setHeadSmiley(%this,%smiley)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(isNumber(%smiley))
		%smiley = $AvatarAPI::smiley[%smiley];
	%player.setFaceName(%smiley);
}

function AIPlayer::setHeadColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("headSkin",%color);
}

function AIPlayer::setHatType(%this,%type)
{
	%player = %this;
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

function AIPlayer::setHatColor(%this,%color)
{
	%player = %this;
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

function AIPlayer::setHatAccentType(%this,%type)
{
	%player = %this;
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

function AIPlayer::setHatAccentColor(%this,%type,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(isNumber(%type))
		%type = $AvatarAPI::accent[%type];
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor(%type,%color);
}

function AIPlayer::setBodyColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("chest",%color);
	%player.setNodeColor("femChest",%color);
}

function AIPlayer::setBodyDecal(%this,%decal)
{
	%player = %this;
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

function AIPlayer::setBodyType(%this,%val)
{
	%player = %this;
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

function AIPlayer::setPantsColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordCount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("pants",%color);
	%player.setNodeColor("skirtHip",%color);
}

function AIPlayer::setPantsType(%this,%val)
{
	%player = %this;
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

function AIPlayer::setRightArmColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("rarm",%color);
}

function AIPlayer::setLeftArmColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	%player.setNodeColor("larm",%color);
}

function AIPlayer::setRightHandType(%this,%type)
{
	%player = %this;
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

function AIPlayer::setLeftHandType(%this,%type)
{
	%player = %this;
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

function AIPlayer::setRightHandColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::handTypeCount;%i++)
	{
		%handType = $AvatarAPI::handType[%i];
		%player.setNodeColor("r" @ %handType,%color);
	}
}

function AIPlayer::setLeftHandColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::handTypeCount;%i++)
	{
		%handType = $AvatarAPI::handType[%i];
		%player.setNodeColor("l" @ %handType,%color);
	}
}

function AIPlayer::setRightShoeColor(%this,%color)
{
	%player = %this;
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

function AIPlayer::setLeftShoeColor(%this,%color)
{
	%player = %this;
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

function AIPlayer::setLeftShoeType(%this,%type)
{
	%player = %this;
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

function AIPlayer::setRightShoeType(%this,%type)
{
	%player = %this;
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

function AIPlayer::setPackType(%this,%type)
{
	%player = %this;
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

function AIPlayer::setPackColor(%this,%color)
{
	%player = %this;
	if(!isObject(%player)) return false;
	if(getWordcount(%color) == 1)
		%color = getColorIdTable(%color);
	for(%i=0;%i<$AvatarAPI::packTypeCount;%i++)
	{
		%packType = $AvatarAPI::packType[%i];
		%player.setNodeColor(%packType,%color);
	}
}

function AIPlayer::setCustomAvatar(%this,%name)
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
			if(isFunction("AIPlayer",%functionCheck))
			{
				eval(%this @ "" @ %function);
			}
		}
	}
}