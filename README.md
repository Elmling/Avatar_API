# Avatar_API
Avatar API for Blockland


Example usage:

%client = clientObject;

%client.lockAvatar(true);
%client.setBodyType("Female");
%client.setHatType("PointyHelmet");
%client.setHatColor("93.1 34.94 32.55 1");

echo(%client.isAvatarLocked()); ==> True
