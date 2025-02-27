//
// Copyright (C) 2013-2023 getMaNGOS <https://getmangos.eu>
//
// This program is free software. You can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation. either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY. Without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//

namespace Mangos.Common.Enums.Global;

public enum EmoteStates
{
    ANIM_STAND = 0x0,
    ANIM_DEATH = 0x1,
    ANIM_SPELL = 0x2,
    ANIM_STOP = 0x3,
    ANIM_WALK = 0x4,
    ANIM_RUN = 0x5,
    ANIM_DEAD = 0x6,
    ANIM_RISE = 0x7,
    ANIM_STANDWOUND = 0x8,
    ANIM_COMBATWOUND = 0x9,
    ANIM_COMBATCRITICAL = 0xA,
    ANIM_SHUFFLE_LEFT = 0xB,
    ANIM_SHUFFLE_RIGHT = 0xC,
    ANIM_WALK_BACKWARDS = 0xD,
    ANIM_STUN = 0xE,
    ANIM_HANDS_CLOSED = 0xF,
    ANIM_ATTACKUNARMED = 0x10,
    ANIM_ATTACK1H = 0x11,
    ANIM_ATTACK2HTIGHT = 0x12,
    ANIM_ATTACK2HLOOSE = 0x13,
    ANIM_PARRYUNARMED = 0x14,
    ANIM_PARRY1H = 0x15,
    ANIM_PARRY2HTIGHT = 0x16,
    ANIM_PARRY2HLOOSE = 0x17,
    ANIM_PARRYSHIELD = 0x18,
    ANIM_READYUNARMED = 0x19,
    ANIM_READY1H = 0x1A,
    ANIM_READY2HTIGHT = 0x1B,
    ANIM_READY2HLOOSE = 0x1C,
    ANIM_READYBOW = 0x1D,
    ANIM_DODGE = 0x1E,
    ANIM_SPELLPRECAST = 0x1F,
    ANIM_SPELLCAST = 0x20,
    ANIM_SPELLCASTAREA = 0x21,
    ANIM_NPCWELCOME = 0x22,
    ANIM_NPCGOODBYE = 0x23,
    ANIM_BLOCK = 0x24,
    ANIM_JUMPSTART = 0x25,
    ANIM_JUMP = 0x26,
    ANIM_JUMPEND = 0x27,
    ANIM_FALL = 0x28,
    ANIM_SWIMIDLE = 0x29,
    ANIM_SWIM = 0x2A,
    ANIM_SWIM_LEFT = 0x2B,
    ANIM_SWIM_RIGHT = 0x2C,
    ANIM_SWIM_BACKWARDS = 0x2D,
    ANIM_ATTACKBOW = 0x2E,
    ANIM_FIREBOW = 0x2F,
    ANIM_READYRIFLE = 0x30,
    ANIM_ATTACKRIFLE = 0x31,
    ANIM_LOOT = 0x32,
    ANIM_SPELL_PRECAST_DIRECTED = 0x33,
    ANIM_SPELL_PRECAST_OMNI = 0x34,
    ANIM_SPELL_CAST_DIRECTED = 0x35,
    ANIM_SPELL_CAST_OMNI = 0x36,
    ANIM_SPELL_BATTLEROAR = 0x37,
    ANIM_SPELL_READYABILITY = 0x38,
    ANIM_SPELL_SPECIAL1H = 0x39,
    ANIM_SPELL_SPECIAL2H = 0x3A,
    ANIM_SPELL_SHIELDBASH = 0x3B,
    ANIM_EMOTE_TALK = 0x3C,
    ANIM_EMOTE_EAT = 0x3D,
    ANIM_EMOTE_WORK = 0x3E,
    ANIM_EMOTE_USE_STANDING = 0x3F,
    ANIM_EMOTE_EXCLAMATION = 0x40,
    ANIM_EMOTE_QUESTION = 0x41,
    ANIM_EMOTE_BOW = 0x42,
    ANIM_EMOTE_WAVE = 0x43,
    ANIM_EMOTE_CHEER = 0x44,
    ANIM_EMOTE_DANCE = 0x45,
    ANIM_EMOTE_LAUGH = 0x46,
    ANIM_EMOTE_SLEEP = 0x47,
    ANIM_EMOTE_SIT_GROUND = 0x48,
    ANIM_EMOTE_RUDE = 0x49,
    ANIM_EMOTE_ROAR = 0x4A,
    ANIM_EMOTE_KNEEL = 0x4B,
    ANIM_EMOTE_KISS = 0x4C,
    ANIM_EMOTE_CRY = 0x4D,
    ANIM_EMOTE_CHICKEN = 0x4E,
    ANIM_EMOTE_BEG = 0x4F,
    ANIM_EMOTE_APPLAUD = 0x50,
    ANIM_EMOTE_SHOUT = 0x51,
    ANIM_EMOTE_FLEX = 0x52,
    ANIM_EMOTE_SHY = 0x53,
    ANIM_EMOTE_POINT = 0x54,
    ANIM_ATTACK1HPIERCE = 0x55,
    ANIM_ATTACK2HLOOSEPIERCE = 0x56,
    ANIM_ATTACKOFF = 0x57,
    ANIM_ATTACKOFFPIERCE = 0x58,
    ANIM_SHEATHE = 0x59,
    ANIM_HIPSHEATHE = 0x5A,
    ANIM_MOUNT = 0x5B,
    ANIM_RUN_LEANRIGHT = 0x5C,
    ANIM_RUN_LEANLEFT = 0x5D,
    ANIM_MOUNT_SPECIAL = 0x5E,
    ANIM_KICK = 0x5F,
    ANIM_SITDOWN = 0x60,
    ANIM_SITTING = 0x61,
    ANIM_SITUP = 0x62,
    ANIM_SLEEPDOWN = 0x63,
    ANIM_SLEEPING = 0x64,
    ANIM_SLEEPUP = 0x65,
    ANIM_SITCHAIRLOW = 0x66,
    ANIM_SITCHAIRMEDIUM = 0x67,
    ANIM_SITCHAIRHIGH = 0x68,
    ANIM_LOADBOW = 0x69,
    ANIM_LOADRIFLE = 0x6A,
    ANIM_ATTACKTHROWN = 0x6B,
    ANIM_READYTHROWN = 0x6C,
    ANIM_HOLDBOW = 0x6D,
    ANIM_HOLDRIFLE = 0x6E,
    ANIM_HOLDTHROWN = 0x6F,
    ANIM_LOADTHROWN = 0x70,
    ANIM_EMOTE_SALUTE = 0x71,
    ANIM_KNEELDOWN = 0x72,
    ANIM_KNEELING = 0x73,
    ANIM_KNEELUP = 0x74,
    ANIM_ATTACKUNARMEDOFF = 0x75,
    ANIM_SPECIALUNARMED = 0x76,
    ANIM_STEALTHWALK = 0x77,
    ANIM_STEALTHSTAND = 0x78,
    ANIM_KNOCKDOWN = 0x79,
    ANIM_EATING = 0x7A,
    ANIM_USESTANDINGLOOP = 0x7B,
    ANIM_CHANNELCASTDIRECTED = 0x7C,
    ANIM_CHANNELCASTOMNI = 0x7D,
    ANIM_WHIRLWIND = 0x7E,
    ANIM_BIRTH = 0x7F,
    ANIM_USESTANDINGSTART = 0x80,
    ANIM_USESTANDINGEND = 0x81,
    ANIM_HOWL = 0x82,
    ANIM_DROWN = 0x83,
    ANIM_DROWNED = 0x84,
    ANIM_FISHINGCAST = 0x85,
    ANIM_FISHINGLOOP = 0x86
}
