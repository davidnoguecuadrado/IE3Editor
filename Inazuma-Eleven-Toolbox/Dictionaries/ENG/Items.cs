﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Dictionaries.ENG
{



    public static class ItemClass
    {

        public static IDictionary<int, string> ItemSaveFilePos = new Dictionary<int, string>()
        {

        };


        public static void getItemSaveFilePos(bool isIE3)
        {
            if (isIE3)
            {
                ItemSaveFilePos = ItemsIE3.ItemSaveFilePos;
            }
            else ItemSaveFilePos = ItemsIE2.ItemSaveFilePos;
        }
    }

    static class ItemsIE3
    {
        public static IDictionary<int, string> ItemSaveFilePos = new Dictionary<int, string>()
        {
//{0x0, "なし"},
{0x1, "Mineral water"},
{0x2, "Sports drink"},
{0x3, "Super water"},
{0x4, "Special drink"},
{0x9, "Milk"},
{0xb, "Cookie bar"},
{0xc, "Stamina bar"},
{0xd, "Hyper bar"},
{0xe, "Special bar"},
{0x10, "Rice ball"},
{0x14, "Noodles"},
{0x15, "Fine veggies"},
{0x1f, "Map of Osaka"},
{0x20, "Map of Naniwa Land"},
{0x21, "Map of Nara"},
{0x22, "Map of Okinawa"},
{0x23, "Map of Fukuoka"},
{0x24, "Warriors’ Pride"},
{0x25, "Memories of Asia"},
{0x26, "Royal Redux Ticket"},
{0x27, "Zeus Ticket"},
{0x28, "Fallen Zeus Ticket"},
{0x29, "Gemini Ticket"},
{0x2a, "Epsilon Ticket"},
{0x2b, "Advanced Epsilon Ticket"},
{0x2c, "Genesis Ticket"},
{0x2d, "Ticket from the Future/Fire and Ice Ticket"},
{0x2e, "Chaos Ticket"},
{0x2f, "Ticket of Darkness"},
{0x30, "Concert Ticket"},
{0x31, "Inazuma Ticket"},
{0x32, "Allstars Ticket"},
{0x33, "Card Ticket"},
{0x34, "Final Notebook Vol. 1"},
{0x35, "Final Notebook Vol. 2"},
{0x36, "Final Notebook Vol. 3"},
{0x37, "Final Notebook Vol. 4"},
{0x38, "Final Notebook Vol. 5"},
{0x39, "Final Notebook Vol. 6"},
{0x3a, "Final Notebook Vol. 7"},
{0x3b, "Final Notebook Vol. 8"},
{0x3c, "Final Notebook Vol. 9"},
{0x3d, "Final Notebook Vol. 10"},
{0x3e, "Final Notebook Vol. 11"},
{0x3f, "Canon’s communicator"},
{0x4d, "Club room key"},
{0x4e, "Gym key"},
{0x4f, "Sweet shop key"},
{0x50, "Laboratory key"},
{0x54, "Canon’s house key"},
{0x55, "Tunnel key"},
{0x56, "Key of Legends"},
{0x57, "Additional proof"},
{0x58, "Incriminating evidence"},
{0x59, "Quagmire’s move manuals"},
{0x5a, "Healing herb"},
{0x5b, "Shadow lizard"},
{0x60, "Old pin badge"},
{0x61, "Red token"},
{0x62, "Blue token"},
{0x63, "Yellow token"},
{0x65, "Raimon kit"},
{0x66, "Royal Academy kit"},
{0x67, "Occult kit"},
{0x68, "Wild kit"},
{0x69, "Brainwashing kit"},
{0x6a, "Otaku kit"},
{0x6b, "Shuriken kit"},
{0x6c, "Farm kit"},
{0x6d, "Kirkwood kit"},
{0x6e, "Zeus kit"},
{0x6f, "Kids kit"},
{0x70, "Umbrella kit"},
{0x71, "Street Sally’s kit"},
{0x72, "Classic kit"},
{0x73, "Chaos kit"},
{0x74, "Rain kit"},
{0x75, "Horizon kit"},
{0x76, "Ocean kit"},
{0x77, "Techno kit"},
{0x78, "Stripe kit v2"},
{0x79, "Tricolour kit"},
{0x7a, "Flattering kit"},
{0x7b, "Multi-purpose kit"},
{0x7d, "Fang kit"},
{0x7e, "Calm kit"},
{0x7f, "Wannabe kit"},
{0x80, "Sunset kit"},
{0x82, "Zebra kit"},
{0x84, "Gentleman’s kit"},
{0x85, "Three star kit"},
{0x86, "Princely kit"},
{0x87, "V sign kit"},
{0x88, "Kung fu kit"},
{0x89, "Symmetry kit"},
{0x8a, "Canny kit"},
{0x8b, "Refined kit"},
{0x8c, "Flame kit"},
{0x8e, "Apostles kit"},
{0x97, "Raimon boots"},
{0x98, "Royal boots"},
{0x99, "Black magic boots"},
{0x9a, "Wild boots"},
{0x9b, "Hypno boots"},
{0x9c, "Otaku boots"},
{0x9d, "Ninja boots"},
{0x9e, "Farm boots"},
{0x9f, "Kirkwood boots"},
{0xa0, "Divine boots"},
{0xa1, "Kids boots"},
{0xa2, "Umbrella boots"},
{0xa3, "Sally’s boots"},
{0xa4, "Classic boots"},
{0xa5, "Prestige boots"},
{0xa6, "Victory boots"},
{0xa7, "Falcon shoes"},
{0xa8, "Piranha boots"},
{0xa9, "Inazuma boots"},
{0xaa, "Fighter boots"},
{0xab, "Youth boots"},
{0xac, "Smart boots"},
{0xae, "Tiger Drive"},
{0xaf, "Winged boots"},
{0xb0, "Excalibur"},
{0xb1, "Graft boots"},
{0xb2, "Hellfire"},
{0xb3, "The Typhoon"},
{0xb4, "Whirlwind Drop"},
{0xb6, "Formal shoes"},
{0xb7, "Thunder Beast"},
{0xb8, "F-Alius"},
{0xb9, "Lightning boots"},
{0xba, "Brainy boots"},
{0xbb, "Soul boots"},
{0xbc, "Growth boots"},
{0xbd, "Pep boots"},
{0xbe, "Motivator boots"},
{0xbf, "Breeze boots"},
{0xc0, "Arrow boots"},
{0xc1, "Feather boots"},
{0xc2, "Bullet boots"},
{0xc3, "Tiger Storm"},
{0xc4, "Dragon Slayer"},
{0xc5, "Gladius Arch"},
{0xc6, "Emperor Penguin No. 3"},
{0xc7, "Grand Fenrir"},
{0xc8, "Odin Sword"},
{0xc9, "Raimon gloves"},
{0xca, "Royal gloves"},
{0xcb, "Black magic gloves"},
{0xcc, "Wild gloves"},
{0xcd, "Hypno gloves"},
{0xce, "Otaku gloves"},
{0xcf, "Ninja gloves"},
{0xd0, "Farm gloves"},
{0xd1, "Kirkwood gloves"},
{0xd2, "Divine gloves"},
{0xd3, "Kids gloves"},
{0xd4, "Umbrella gloves"},
{0xd5, "Sally’s gloves"},
{0xd6, "Heavenly Drive"},
{0xd7, "Youth gloves"},
{0xd8, "Memento gloves"},
{0xd9, "Samba Strike"},
{0xda, "The Dawn"},
{0xdb, "Inazuma gloves"},
{0xdc, "Victory gloves"},
{0xdd, "Prestige gloves"},
{0xde, "Big Bang"},
{0xdf, "The Hurricane"},
{0xe0, "Megalodon"},
{0xe1, "Paladin Strike"},
{0xe4, "Gunshot"},
{0xe5, "Fireball Screw"},
{0xe6, "Mirage Shot"},
{0xe8, "Pegasus Shot"},
{0xe9, "Unicorn Boost"},
{0xea, "Jet Stream"},
{0xeb, "Grand Fire"},
{0xec, "Brave Shot"},
{0xed, "Chaos Break"},
{0xee, "Astro Gate"},
{0xef, "Double Jaw"},
{0xf0, "Eiffel Tower"},
{0xf1, "Health bracelet"},
{0xf2, "Slingshot"},
{0xf3, "Sweet Deal"},
{0xf4, "Muscle bracelet"},
{0xf5, "Emperor Penguin X"},
{0xf6, "Dirty bracelet"},
{0xf7, "Flame bracelet"},
{0xf8, "Remote Combustion"},
{0xf9, "X-Blast"},
{0xfa, "Lucky bracelet"},
{0xfb, "Youth bracelet"},
{0xfc, "Almighty Cannon"},
{0xfd, "Victory bracelet"},
{0xfe, "Inazuma bracelet"},
{0xff, "Dark Matter"},
{0x100, "Shadow Ray"},
{0x101, "Wish bracelet"},
{0x102, "Fervour bracelet"},
{0x103, "Plain bracelet"},
{0x104, "Flashy bracelet"},
{0x105, "Gaudy bracelet"},
{0x106, "Maximum Fire"},
{0x107, "Prime Legend"},
{0x108, "Doom Rain"},
{0x109, "Promise pendant"},
{0x10a, "Dimensional Hand"},
{0x10b, "Hammer of Fury"},
{0x10c, "Soul Hand"},
{0x10d, "God Hand X"},
{0x10e, "Fiend Hand"},
{0x10f, "God Catch"},
{0x110, "Storm Rider"},
{0x111, "Flash Upper"},
{0x112, "Nitro Slap"},
{0x113, "Barrier Reef"},
{0x114, "Giant Spider"},
{0x115, "Galatyn"},
{0x116, "Colosseum Guard"},
{0x117, "Million Hands"},
{0x118, "Capoeira Grab"},
{0x119, "The Stinger"},
{0x11a, "Shot Trap"},
{0x11b, "Card Protector"},
{0x11c, "High Voltage"},
{0x11d, "Omega Hand"},
{0x11e, "Electrap"},
{0x11f, "Celestial Zone"},
{0x120, "The End"},
{0x123, "Dark Tornado"},
{0x124, "Clone Faker"},
{0x125, "Flurry Dash"},
{0x126, "Whirlwind Twister"},
{0x127, "Illusion Ball"},
{0x128, "Dash Accelerator"},
{0x129, "Rolling Hell"},
{0x12a, "Heat Tackle"},
{0x12b, "Zigzag Spark"},
{0x12c, "Rodeo Clown"},
{0x12d, "Black Magic"},
{0x12e, "Super Armadillo"},
{0x12f, "Poison Fog"},
{0x130, "Attack Scan"},
{0x131, "Bewildered"},
{0x132, "Boost Glider"},
{0x133, "Afterimage"},
{0x134, "Mole Fake"},
{0x135, "Whirlwind Cut"},
{0x136, "Monkey Turn"},
{0x137, "Heaven’s Time"},
{0x138, "Breakthrough"},
{0x139, "Dash Storm"},
{0x13a, "Moonsault"},
{0x13b, "Magic"},
/*{0x13c, "システム予約"},
{0x13d, "システム予約"},
{0x13e, "システム予約"},
{0x13f, "システム予約"},
{0x140, "システム予約"},*/
{0x141, "The Wall"},
{0x142, "Baby Dragon"},
{0x143, "Killer Slide"},
{0x144, "Coil Turn"},
{0x145, "Earthquake"},
{0x146, "Quick Draw"},
{0x147, "Spider Web"},
{0x148, "Cyclone"},
{0x149, "Fake Ball"},
{0x14a, "Shadow Stitch"},
{0x14b, "Sumo Stomp"},
{0x14c, "Horn Train"},
{0x14d, "Hurricane Arrows"},
{0x14e, "Spinning Cut"},
{0x14f, "Defence Scan"},
{0x150, "Ghost Pull"},
{0x151, "Doppelganger"},
{0x152, "Bamboo Pattern"},
{0x153, "Harvest"},
{0x154, "Divine Stamp"},
{0x155, "Mega Quake"},
{0x156, "Blade Attack"},
{0x157, "About Face"},
{0x158, "Blazing Knuckle"},
{0x159, "Majin The Hand"},
{0x15a, "Fire Rooster"},
{0x15b, "Inazuma Break"},
{0x15c, "The Galaxy"},
{0x15d, "Emperor Penguin No. 2"},
{0x15e, "The Phoenix"},
{0x15f, "Inazuma Drop"},
{0x160, "Dragon Crash"},
{0x161, "Twin Boost"},
{0x162, "Fire Tornado"},
{0x163, "Wrath Shot"},
{0x164, "Inazuma-1"},
{0x165, "Grenade Shot"},
{0x166, "Death Zone"},
{0x167, "Phantom Shot"},
{0x168, "Hawk Shot"},
{0x169, "Meteor Attack"},
{0x16a, "Snake Shot"},
{0x16b, "Spinning Shot"},
{0x16c, "Comet Shot"},
{0x16d, "Rolling Kick"},
{0x16e, "Clone Shot"},
{0x16f, "Dynamite Shot"},
{0x170, "Patriot Shot"},
{0x171, "Spiral Shot"},
{0x172, "Freeze Shot"},
{0x173, "Cross Drive"},
{0x174, "Teleport Shot"},
{0x175, "Psycho Shot"},
{0x176, "Condor Dive"},
{0x177, "Run Ball Run"},
{0x178, "Triangle Z"},
{0x179, "Utter Gutsiness Bat"},
{0x17a, "Reflect Buster"},
{0x17b, "Kung Fu Header"},
{0x17c, "Shine Drive"},
{0x17d, "Divine Arrows"},
{0x17e, "Back Tornado"},
{0x17f, "Tarzan Kick"},
{0x180, "God Knows"},
{0x181, "Dragon Tornado"},
{0x182, "Dirt Ball"},
{0x183, "Tsunami Wall"},
{0x184, "Tornado Catch"},
{0x185, "God Hand"},
{0x186, "Power Shield"},
{0x187, "Fireball Knuckle"},
{0x188, "Shot Pocket"},
{0x189, "Warp Space"},
{0x18a, "Counter Strike"},
{0x18b, "Sliding Goal"},
{0x18c, "Triple Defence"},
{0x18d, "Pressure Punch"},
{0x18e, "Toughness Block"},
{0x18f, "Full Power Shield"},
{0x190, "Wood Chopper"},
{0x191, "Whirlwind"},
{0x192, "Rocket Kobushi"},
{0x193, "Wild Claw"},
{0x194, "Gigant Wall"},
{0x195, "Mistral"},
{0x196, "Killer Blade"},
{0x197, "Infinite Wall"},
{0x198, "Field of Force"},
{0x199, "Kangaroo Kick"},
{0x19a, "Abaddon Drop"},
{0x19b, "Bewilder Blast"},
{0x19c, "The Ikaros"},
//{0x19d, "Nightmare Trap"},
{0x19e, "Wind God’s Dance"},
{0x19f, "Card Slap"},
{0x1a0, "Matador Feint"},
{0x1a1, "Super Elastico"},
{0x1a2, "Echo Ball"},
{0x1a3, "Liar Shot"},
{0x1a4, "Air Ride"},
{0x1a5, "Breakthrough 3"},
{0x1a6, "Dog Run"},
{0x1a7, "Sub-Terfuge"},
{0x1a8, "Ultra Moon"},
{0x1a9, "Angel Ball"},
{0x1aa, "Devil Ball"},
{0x1ab, "Clone Death Zone"},
{0x1ac, "Diabolical Cut"},
{0x1ad, "Snow Angel"},
{0x1ae, "Barbarian Shield"},
{0x1af, "Ground Quake"},
{0x1b0, "Desert Blast"},
{0x1b1, "Am-Bush"},
{0x1b2, "Gravestone"},
{0x1b3, "Racing Flame"},
{0x1b4, "Iron Wall"},
{0x1b5, "Power Charge"},
{0x1b6, "Vac Attack"},
{0x1b7, "Yo-Yo Ball"},
{0x1b8, "Rolling Slide"},
{0x1b9, "Clone Penguin"},
{0x1ba, "Stone Prison"},
{0x1bb, "The Mountain"},
{0x1bc, "Zigzag Flame"},
{0x1bd, "Heaven’s Ascent"},
{0x1be, "Hell’s Descent"},
{0x1c2, "F-Basic"},
{0x1c3, "F-Death Zone"},
{0x1c4, "F-Ghost Dance"},
{0x1c5, "F-Wild Park"},
{0x1c6, "F-442 Grid"},
{0x1c7, "F-Super Star 5"},
{0x1c8, "F-Crane Wings"},
{0x1c9, "F-Infinite Wall"},
{0x1ca, "F-Free March"},
{0x1cb, "F-Heaven’s Gate"},
{0x1cc, "F-Phalanx"},
{0x1cf, "F-Butterfly"},
{0x1d0, "F-Dot Prison"},
{0x1d2, "F-Bow & Arrow"},
{0x1d4, "F-Midfield Block"},
{0x1d5, "F-Phoenix"},
{0x1da, "B-Basic"},
{0x1db, "B-Flat Back"},
{0x1dc, "B-Attack"},
{0x1dd, "B-Breakthrough"},
{0x1de, "B-Pressure"},
{0x1df, "B-Slash"},
{0x1e0, "B-Right wing"},
{0x1e1, "B-Train"},
{0x1e2, "B-Triangle"},
{0x1e3, "B-Lance"},
{0x1e5, "F-Gemini"},
{0x1e6, "F-Epsilon"},
{0x1e7, "F-Genesis"},
{0x1e8, "F-Dark Emperors"},
{0x1e9, "F-Aegis"},
{0x1ea, "F-Double Dog"},
{0x1eb, "F-Three Top"},
{0x1ec, "F-Death Zone 2"},
{0x1ed, "F-Big Waves"},
{0x1ee, "F-Neo"},
{0x1ef, "F-Desert Lions"},
{0x1f0, "F-Fire Dragon"},
{0x1f1, "F-Queen’s Knights"},
{0x1f2, "F-Empire"},
{0x1f3, "F-Unicorn"},
{0x1f4, "F-Orpheus"},
{0x1f5, "F-Matador"},
{0x1f6, "F-Kingdom"},
{0x1f7, "F-Bullet"},
{0x1f8, "F-Tricolore"},
{0x1f9, "F-Brigade"},
{0x1fa, "F-Little Gigantes"},
{0x1fb, "F-Pantheon"},
{0x1fc, "F-Pandemonium"},
{0x1fd, "F-Shadow"},
{0x1fe, "F-Reaper"},
{0x1ff, "Test shoes"},
{0x200, "Friendship Points"},
{0x201, "Prestige Points"},
{0x202, "F-Dark Angels"},
{0x203, "F-Ogre"},
{0x204, "F-Chaos"},
{0x209, "Gemini kit"},
{0x20a, "Epsilon kit"},
{0x20b, "Genesis kit"},
{0x20d, "Secret Service kit"},
{0x20e, "Alpine kit"},
{0x20f, "Cloister kit"},
{0x210, "Redux kit"},
{0x211, "Fauxshore kit"},
{0x212, "Mary Times kit"},
{0x213, "Dark Emperors kit"},
{0x214, "Triple C kit"},
{0x215, "Robot Guards kit"},
{0x216, "Retro kit"},
{0x217, "Skull kit"},
{0x218, "Frog kit"},
{0x219, "First star kit"},
{0x21a, "Sailor kit"},
{0x21b, "Devotion kit"},
{0x21d, "Terror kit"},
{0x21e, "Martial kit"},
{0x21f, "Bikers kit"},
{0x220, "Space kit"},
{0x221, "Moonlight kit"},
{0x222, "Stripe kit"},
{0x225, "Thunder kit"},
{0x226, "Mettle kit"},
{0x227, "Soldier kit"},
{0x228, "Future kit"},
{0x229, "Prominence kit"},
{0x22a, "Diamond Dust kit"},
{0x22b, "Legendary kit"},
{0x22c, "Slimline kit"},
{0x22d, "Friendship kit"},
{0x22e, "Intense kit"},
{0x22f, "Slipstream kit"},
{0x230, "Sturdy kit"},
{0x231, "Fearsome kit"},
{0x232, "Carbon-fibre kit"},
{0x233, "Smart kit"},
{0x234, "Spotty kit"},
{0x235, "Devil Army Z kit"},
{0x236, "Card kit"},
{0x237, "Ogre kit"},
{0x238, "Dark Angels kit"},
{0x23a, "Stardust boots"},
{0x23b, "Stardust boots"},
{0x23c, "Planet boots"},
{0x23d, "Planet boots"},
{0x23e, "Space boots"},
{0x23f, "Space boots"},
{0x240, "Security boots"},
{0x241, "Security boots"},
{0x242, "Snow boots"},
{0x243, "Snow boots"},
{0x244, "Discipline boots"},
{0x245, "Discipline boots"},
{0x246, "Jet black boots"},
{0x247, "Jet black boots"},
{0x248, "Twilight boots"},
{0x249, "Twilight boots"},
{0x24a, "Marine boots"},
{0x24b, "Marine boots"},
{0x24c, "Shadow boots"},
{0x24d, "Shadow boots"},
{0x24e, "Naniwa boots"},
{0x24f, "Naniwa boots"},
//{0x250, "Guard boots （PK）"},
//{0x251, "Guard boots （GK）"},
{0x252, "Maize boots"},
{0x254, "Legendary boots"},
{0x255, "Luxury boots"},
{0x256, "Bikers boots"},
{0x257, "Bikers boots"},
{0x258, "Martial boots"},
{0x259, "Martial boots"},
{0x25a, "White boots"},
{0x25b, "Vacuum boots"},
{0x25c, "Wrath boots"},
{0x25d, "Chequered boots"},
{0x25e, "Fresh boots"},
{0x25f, "Thermo boots"},
{0x260, "Scorched boots"},
{0x261, "Scorched boots"},
{0x262, "Frozen boots"},
{0x263, "Frozen boots"},
{0x264, "New generation boots"},
{0x265, "Chaos boots"},
{0x266, "Chaos boots"},
{0x267, "New generation boots"},
{0x268, "Apostles boots"},
{0x269, "Devil Army Z boots"},
{0x26a, "Dark Angels boots"},
{0x26b, "Ogre boots"},
{0x26c, "Devil Army Z boots"},
{0x26d, "Dark Angels boots"},
{0x271, "Apostles gloves"},
{0x272, "Devil Army Z gloves"},
{0x273, "Dark Angels gloves"},
{0x274, "Ogre gloves"},
{0x275, "Card gloves"},
{0x276, "Micro gloves"},
{0x277, "Macro gloves"},
{0x278, "Big Bang gloves"},
{0x279, "Macro gloves plus"},
{0x27a, "Iron wall gloves"},
{0x27b, "Northern gloves"},
{0x27c, "Kung fu gloves"},
{0x27d, "Strong man gloves"},
{0x27e, "Sunset gloves"},
{0x27f, "Resort gloves"},
{0x280, "Betrayal gloves"},
{0x281, "Maiden gloves"},
{0x282, "Guard gloves"},
{0x283, "Forest gloves"},
{0x284, "Legendary gloves"},
{0x285, "Agent gloves"},
{0x286, "Corona gloves"},
{0x287, "Aurora gloves"},
{0x288, "New generation gloves"},
{0x289, "Practice gloves"},
{0x28a, "Air gloves"},
{0x28b, "Nature gloves"},
{0x28c, "Steel gloves"},
{0x28d, "Passion gloves"},
{0x28e, "Pretty gloves 2"},
{0x28f, "Surefire win gloves"},
{0x290, "Fresh gloves"},
{0x291, "Destruction gloves"},
{0x292, "Space-time gloves"},
{0x294, "Titanium bracelet"},
{0x295, "Friendship bracelet"},
{0x296, "Passion bracelet"},
{0x297, "Land bracelet"},
{0x298, "Peach bracelet"},
{0x299, "Stylish bracelet"},
{0x29a, "Strongest bracelet"},
{0x29b, "Exotic bracelet"},
{0x29c, "Cosmos bracelet"},
{0x2a4, "Faithful pendant"},
{0x2a5, "Pure pendant"},
{0x2a6, "Noble pendant"},
{0x2a7, "Bright pendant"},
{0x2a8, "Bronze power pendant"},
{0x2a9, "Silver power pendant"},
{0x2aa, "Gold power pendant"},
{0x2ab, "Bronze shield pendant"},
{0x2ac, "Silver shield pendant"},
{0x2ad, "Gold shield pendant"},
{0x2bc, "Eternal Blizzard"},
{0x2bd, "Fireball Storm"},
{0x2be, "Tsunami Boost"},
{0x2bf, "Death Zone 2"},
{0x2c0, "The Earth"},
{0x2c1, "Rainbow Arc"},
{0x2c2, "Astro Break"},
{0x2c3, "Acrobat Bomber"},
{0x2c4, "Kung Fu Fighting"},
{0x2c5, "Double Grenade"},
{0x2c6, "Gyro Head"},
{0x2c7, "Revolution V"},
{0x2c8, "Heel Kick"},
{0x2c9, "Dragon Cannon"},
{0x2ca, "Dual Strike"},
{0x2cb, "Legendary Wolf"},
{0x2cc, "Emperor Penguin No. 1"},
{0x2cd, "Bed Of Roses"},
{0x2ce, "Utter Gutsiness Club"},
{0x2cf, "Double Wrath Shot"},
{0x2d0, "Land Dragon"},
{0x2d1, "Tri-Pegasus"},
{0x2d2, "Inazuma-1 Drop"},
{0x2d3, "Ganymede Ray"},
{0x2d4, "Leaping Thunder"},
{0x2d5, "Eagle Buster"},
{0x2d6, "Butterfly Trance"},
{0x2d7, "Cosmic Blast"},
{0x2d8, "Gaia Break"},
{0x2d9, "Spectacle Crash"},
{0x2da, "Twin Boost F"},
{0x2db, "Double Tornado"},
{0x2dc, "Security Shot"},
{0x2dd, "Supernova"},
{0x2de, "Space Penguin"},
{0x2df, "Wyvern Crash"},
{0x2e0, "Wyvern Blizzard"},
{0x2e1, "Cross Fire"},
{0x2e2, "Dark Phoenix"},
{0x2e3, "Triple Boost"},
{0x2e4, "Neo Galaxy"},
{0x2e5, "Assault Shot"},
{0x2e6, "God Break"},
{0x2e7, "Megaton Head"},
{0x2e8, "Steeple Shot"},
{0x2e9, "Meteor Blade"},
{0x2ea, "Gungnir"},
{0x2eb, "Atomic Flare"},
{0x2ec, "Northern Impact"},
{0x2ed, "Fire Blizzard"},
{0x2ee, "Cross Fire"},
{0x2ef, "Fire Blizzard"},
{0x2f0, "Doom Spear"},
{0x2f1, "Doom Break"},
{0x2f2, "Shadow Ray"},
{0x2f3, "Celestial Smash"},
{0x2f8, "Deceptor Dribble"},
{0x2f9, "Invisible Fake"},
{0x2fa, "Gale Dash"},
{0x2fb, "Three-Legged Rush"},
{0x2fc, "Aurora Dribble"},
{0x2fd, "Double Touch"},
{0x2fe, "Dual Pass"},
{0x2ff, "Bubble Gum"},
{0x300, "Prima Donna"},
{0x301, "Armadillo Circus"},
{0x302, "Breakthrough 2"},
{0x303, "Triple Dash"},
{0x304, "Lightning Sprint"},
{0x305, "Aikido"},
{0x306, "Mole Shuffle"},
{0x307, "Dark Whirlwind"},
{0x308, "Warp Drive"},
{0x309, "Meteor Shower"},
{0x30a, "Southern Cross"},
{0x30b, "Ribbon Shower"},
{0x30c, "Big Fan"},
{0x30d, "Flame Veil"},
{0x30e, "Water Veil"},
{0x319, "Shooting Star"},
{0x31a, "Land Of Ice"},
{0x31b, "Clone Defence"},
{0x31c, "Circus Block"},
{0x31d, "Heavy Mettle"},
{0x31e, "The Tower"},
{0x31f, "Photon Crash"},
{0x320, "Gravitation"},
{0x321, "Dual Storm"},
{0x322, "Supreme Spin"},
{0x323, "Fake Bomber"},
{0x324, "Volcano Cut"},
{0x325, "Super Sumo Stomp"},
{0x326, "Planet Shield"},
{0x327, "Sigma Zone"},
{0x328, "Double Cyclone"},
{0x329, "No Escape"},
{0x32a, "Flame Dance"},
{0x32b, "Asteroid Belt"},
{0x32c, "Body Shield"},
{0x32d, "Perimeter Zone"},
{0x32e, "Mega Wall"},
{0x32f, "Road Roller"},
{0x330, "Sleeping Dust"},
{0x331, "Ignite Steal"},
{0x332, "Whale Guard"},
{0x333, "Whirlwind Force"},
{0x334, "Mad Express"},
{0x335, "Frozen Steal"},
{0x336, "Stone Wall"},
{0x337, "Perfect Tower"},
{0x340, "Mugen The Hand"},
{0x341, "Utter Gutsiness Catch"},
{0x342, "Fireball Head"},
{0x343, "Aurora Curtain"},
{0x344, "Table-Turner"},
{0x345, "Flame Breath"},
{0x346, "Beast Fang"},
{0x347, "Drill Smasher"},
{0x348, "Clone Block"},
{0x34a, "Claw Slash"},
{0x34b, "Dual Smash"},
{0x34c, "Double Rocket"},
{0x34d, "Flower Power"},
{0x34e, "Swan Dive"},
{0x34f, "Triple God Hand"},
{0x350, "Black Hole"},
{0x351, "Safety First"},
{0x352, "Wormhole"},
{0x353, "Temporal Wall"},
{0x354, "Procyon Net"},
{0x355, "Fist of Justice"},
{0x356, "Burnout"},
{0x357, "Ice Block"},
{0x358, "Needle Hammer"},
{0x36f, "Banana Shot"},
{0x370, "The Tube"},
{0x371, "Sky’s the Limit"},
{0x372, "Box Lock"},
{0x373, "Dual Typhoon"},
{0x374, "Absolute Knights"},
{0x375, "Perfect Zone Press"},
{0x376, "Invincible Lance"},
{0x377, "Andes Antlion"},
{0x378, "Ghost Lock"},
{0x379, "Crescent Moon"},
{0x37a, "Rolling Thunder"},
{0x37b, "Royal Road"},
{0x37c, "Catenaccio Counter"},
{0x37d, "Amazon Wave"},
{0x37e, "Circular Drive"},
{0x37f, "Godspeed"},
{0x380, "Dark Thunder"},
{0x381, "Slow-Mo"},
{0x382, "Fast Forward"},
{0x383, "Trapdance"},
//{0x384, "Big Ghost Lock （TEMP）"},
{0x385, "Keeper Plus"},
{0x386, "Speed Plus"},
{0x387, "Shoot Plus"},
{0x388, "Defence Plus"},
{0x389, "Offence Plus"},
{0x38a, "Recovery"},
{0x38b, "Trickery!"},
{0x38c, "Charm Up!"},
{0x38d, "Cool Up!"},
{0x38e, "Economy!"},
{0x38f, "Big Moves!"},
{0x390, "Power Element"},
{0x391, "Study"},
{0x392, "Slack Off"},
{0x393, "Critical!"},
{0x394, "No Element"},
{0x395, "Lucky!"},
{0x396, "Jinx"},
{0x397, "Speed Force"},
{0x398, "Shot Force"},
{0x399, "Defence Force"},
{0x39a, "Offence Force"},
{0x39b, "Never Give Up"},
{0x39c, "Move It!"},
{0x39d, "Everyone Move It!"},
{0x39e, "Comeback Kid"},
{0x39f, "Put Your Back Into It!"},
{0x3b7, "Inazuma National kit"},
{0x3b8, "Big Waves kit"},
{0x3b9, "Desert Lions kit"},
{0x3ba, "Fire Dragon kit"},
{0x3bb, "Queen’s Knights kit"},
{0x3bc, "Empire kit"},
{0x3bd, "Unicorn kit"},
{0x3be, "Orpheus kit"},
{0x3bf, "Kingdom kit"},
{0x3c0, "Little Gigantes kit"},
{0x3c1, "Neo National kit"},
{0x3c2, "Team D kit"},
{0x3c3, "Zoolan kit"},
{0x3c4, "Rose Griffons kit"},
{0x3c5, "Matador kit"},
{0x3c6, "Brocken kit"},
{0x3c7, "Crusaders kit"},
{0x3cb, "Inazuma National boots"},
{0x3cc, "Big Waves boots"},
{0x3cd, "Desert Lions boots"},
{0x3ce, "Fire Dragon boots"},
{0x3cf, "Knights boots"},
{0x3d0, "Empire boots"},
{0x3d1, "Unicorn boots"},
{0x3d2, "Orpheus boots"},
{0x3d3, "Kingdom boots"},
{0x3d4, "Victoirean boots"},
{0x3d5, "Neo National boots"},
{0x3d6, "Vengeance boots"},
{0x3d7, "Ambition boots"},
{0x3d8, "Champagne shoes"},
{0x3d9, "Flamenco boots"},
{0x3da, "Mighty boots"},
{0x3db, "Bafana boots"},
{0x3df, "Inazuma National gloves"},
{0x3e0, "Big Waves gloves"},
{0x3e1, "Desert Lions gloves"},
{0x3e2, "Fire Dragon gloves"},
{0x3e3, "Knights gloves"},
{0x3e4, "Empire gloves"},
{0x3e5, "Unicorn gloves"},
{0x3e6, "Orpheus gloves"},
{0x3e7, "Kingdom gloves"},
{0x3e8, "Victoirean gloves"},
{0x3e9, "Neo National gloves"},
{0x3ea, "Vengeance gloves"},
{0x3eb, "Ambition gloves"},
{0x3ec, "Champagne gloves"},
{0x3ed, "Flamenco gloves"},
{0x3ee, "Mighty gloves"},
{0x3ef, "Bafana gloves"}
        };
    }

    static class ItemsIE2
    {
        public static IDictionary<int, string> ItemSaveFilePos = new Dictionary<int, string>()
        {
//{0x0, "なし"},
{0x1, "Mineral water"},
{0x2, "Sports drink"},
{0x3, "Super water"},
{0x9, "Milk"},
{0xb, "Cookie bar"},
{0xc, "Stamina bar"},
{0xd, "Hyper bar"},
{0x10, "Rice ball"},
{0x15, "Fine veggies"},
{0x24, "Football magazine"},
{0x25, "Yosemite's notes"},
{0x26, "Gladstone's notes"},
{0x27, "Builder's notes"},
{0x29, "Stag beetle"},
{0x3e, "Level 1 card key"},
{0x3f, "Level 2 card key"},
{0x40, "Level 3 card key"},
{0x41, "Level 4 card key"},
{0x42, "Mysterious key"},
{0x43, "Computer room key"},
{0x44, "Baseball club key"},
{0x45, "Tennis club key"},
{0x46, "Athletics club key"},
{0x47, "Cycling club key"},
{0x48, "Dojo key"},
{0x49, "Swimming club key"},
{0x4a, "Gym key"},
{0x4b, "Tower hut key"},
{0x4c, "Gym storeroom key"},
{0x4d, "Secret warehouse key"},
{0x4e, "Lighthouse room key"},
{0x51, "Club notebook"},
{0x52, "Racy comic"},
{0x53, "Strange device"},
{0x54, "Scrap of manual"},
{0x55, "Hacking records"},
{0x56, "Sonny's note"},
{0x57, "Sonny's documents"},
{0x58, "Deer crackers"},
{0x59, "Ambrosia"},
{0x5a, "Big boots"},
{0x5b, "Shadow lizard"},
{0x5c, "Cloister Strip"},
{0x5d, "Memory boots"},
{0x5e, "Secret Scrapbook"},
{0x5f, "Mystery pendant"},
{0x60, "Old pin badge"},
{0x61, "Sunglasses"},
{0x65, "Raimon kit"},
{0x66, "Royal Academy kit"},
{0x67, "Occult kit"},
{0x68, "Wild kit"},
{0x69, "Brainwashing kit"},
{0x6a, "Otaku kit"},
{0x6b, "Shuriken kit"},
{0x6c, "Farm kit"},
{0x6d, "Kirkwood kit"},
{0x6e, "Zeus kit"},
{0x6f, "Kids kit"},
{0x70, "Umbrella kit"},
{0x71, "Street Sally's kit"},
{0x72, "Classic kit"},
{0x73, "Chaos kit"},
{0x74, "Rain kit"},
{0x75, "Battle kit"},
{0x76, "Tough kit"},
{0x77, "Techno kit"},
{0x78, "Intense kit"},
{0x79, "Flurry kit"},
{0x7a, "Abyss kit"},
{0x7b, "Fortified kit"},
{0x7c, "Ocean kit"},
{0x7d, "Prestige kit"},
{0x7e, "Clawed kit"},
{0x7f, "Graft kit"},
{0x80, "Sunset kit"},
{0x81, "Majestic kit"},
{0x82, "Victory kit"},
{0x83, "Youth kit"},
{0x84, "Gentleman's kit"},
{0x85, "Three star kit"},
{0x86, "Princely kit"},
{0x87, "V sign kit"},
{0x88, "Kung fu kit"},
{0x89, "Inazuma kit"},
{0x8a, "Quality kit"},
{0x8b, "Refined kit"},
{0x8c, "Flame kit"},
{0x8d, "Flash kit"},
{0x8e, "Veteran's kit"},
{0x8f, "Meadow kit"},
{0x97, "Raimon boots"},
{0x98, "Royal boots"},
{0x99, "Black magic boots"},
{0x9a, "Wild boots"},
{0x9b, "Hypno boots"},
{0x9c, "Otaku boots"},
{0x9d, "Ninja boots"},
{0x9e, "Farm boots"},
{0x9f, "Kirkwood boots"},
{0xa0, "Divine boots"},
{0xa1, "Kids boots"},
{0xa2, "Umbrella boots"},
{0xa3, "Sally's boots"},
{0xa4, "Classic boots"},
{0xa5, "Prestige boots"},
{0xa6, "Victory boots"},
{0xa7, "Falcon shoes"},
{0xa8, "Impact shoes"},
{0xa9, "Inazuma boots"},
{0xaa, "Blue sky boots"},
{0xab, "Youth boots"},
{0xac, "Smart boots"},
{0xad, "Regular shoes"},
{0xae, "Master shoes"},
{0xaf, "Winged boots"},
{0xb0, "Wonder boots"},
{0xb1, "Graft boots"},
{0xb2, "Spirit boots"},
{0xb3, "Flame boots"},
{0xb4, "Surge boots"},
{0xb5, "Flash boots"},
{0xb6, "Formal shoes"},
{0xb7, "Layton's shoes"},
{0xb8, "F-Alius"},
{0xc9, "Raimon gloves"},
{0xca, "Royal gloves"},
{0xcb, "Black magic gloves"},
{0xcc, "Wild gloves"},
{0xcd, "Hypno gloves"},
{0xce, "Otaku gloves"},
{0xcf, "Ninja gloves"},
{0xd0, "Farm gloves"},
{0xd1, "Kirkwood gloves"},
{0xd2, "Divine gloves"},
{0xd3, "Kids gloves"},
{0xd4, "Umbrella gloves"},
{0xd5, "Sally's gloves"},
{0xd6, "Classic gloves"},
{0xd7, "Youth gloves"},
{0xd8, "Memento gloves"},
{0xd9, "Flame gloves"},
{0xda, "Pretty gloves"},
{0xdb, "Inazuma gloves"},
{0xdc, "Victory gloves"},
{0xdd, "Prestige gloves"},
{0xe7, "Flash gloves"},
{0xf1, "Health bracelet"},
{0xf2, "Strength bracelet"},
{0xf3, "Guard bracelet"},
{0xf4, "Muscle bracelet"},
{0xf5, "Courage bracelet"},
{0xf6, "Dirty bracelet"},
{0xf7, "Flame bracelet"},
{0xf8, "Safety bracelet"},
{0xf9, "Sacred bracelet"},
{0xfa, "Lucky bracelet"},
{0xfb, "Youth bracelet"},
{0xfc, "Shield bracelet"},
{0xfd, "Victory bracelet"},
{0xfe, "Inazuma bracelet"},
{0xff, "Life bracelet"},
{0x100, "Popular bracelet"},
{0x101, "Wish bracelet"},
{0x102, "Fervour bracelet"},
{0x103, "Plain bracelet"},
{0x104, "Flashy bracelet"},
{0x105, "Gaudy bracelet"},
{0x109, "Promise pendant"},
{0x10a, "Bronze FP pendant"},
{0x10b, "Silver FP pendant"},
{0x10c, "Gold FP pendant"},
{0x10d, "Bronze TP pendant"},
{0x10e, "Silver TP pendant"},
{0x10f, "Gold TP pendant"},
{0x123, "Dark Tornado"},
{0x124, "Clone Faker"},
{0x125, "Flurry Dash"},
{0x126, "Whirlwind Twister"},
{0x127, "Illusion Ball"},
{0x128, "Dash Accelerator"},
{0x129, "Rolling Hell"},
{0x12a, "Heat Tackle"},
{0x12b, "Zigzag Spark"},
{0x12c, "Rodeo Clown"},
{0x12d, "Black Magic"},
{0x12e, "Super Armadillo"},
{0x12f, "Poison Fog"},
{0x130, "Attack Scan"},
{0x131, "Bewildered"},
{0x132, "Boost Glider"},
{0x133, "Afterimage"},
{0x134, "Mole Fake"},
{0x135, "Whirlwind Cut"},
{0x136, "Monkey Turn"},
{0x137, "Heaven's Time"},
{0x138, "Breakthrough"},
{0x139, "Dash Storm"},
{0x13a, "Moonsault"},
{0x13b, "Magic"},
/*{0x13c, "システム予約"},
{0x13d, "システム予約"},
{0x13e, "システム予約"},
{0x13f, "システム予約"},
{0x140, "システム予約"},*/
{0x141, "The Wall"},
{0x142, "Baby Dragon"},
{0x143, "Killer Slide"},
{0x144, "Coil Turn"},
{0x145, "Earthquake"},
{0x146, "Quick Draw"},
{0x147, "Spider Web"},
{0x148, "Cyclone"},
{0x149, "Fake Ball"},
{0x14a, "Shadow Stitch"},
{0x14b, "Sumo Stomp"},
{0x14c, "Horn Train"},
{0x14d, "Hurricane Arrows"},
{0x14e, "Spinning Cut"},
{0x14f, "Defence Scan"},
{0x150, "Ghost Pull"},
{0x151, "Doppelganger"},
{0x152, "Bamboo Pattern"},
{0x153, "Harvest"},
{0x154, "Divine Stamp"},
{0x155, "Mega Quake"},
{0x156, "Blade Attack"},
{0x157, "About Face"},
{0x158, "Blazing Knuckle"},
{0x159, "Majin The Hand"},
{0x15a, "Fire Rooster"},
{0x15b, "Inazuma Break"},
{0x15c, "The Galaxy"},
{0x15d, "Emperor Penguin No. 2"},
{0x15e, "The Phoenix"},
{0x15f, "Inazuma Drop"},
{0x160, "Dragon Crash"},
{0x161, "Twin Boost"},
{0x162, "Fire Tornado"},
{0x163, "Wrath Shot"},
{0x164, "Inazuma-1"},
{0x165, "Grenade Shot"},
{0x166, "Death Zone"},
{0x167, "Phantom Shot"},
{0x168, "Hawk Shot"},
{0x169, "Meteor Attack"},
{0x16a, "Snake Shot"},
{0x16b, "Spinning Shot"},
{0x16c, "Comet Shot"},
{0x16d, "Rolling Kick"},
{0x16e, "Clone Shot"},
{0x16f, "Dynamite Shot"},
{0x170, "Patriot Shot"},
{0x171, "Spiral Shot"},
{0x172, "Freeze Shot"},
{0x173, "Cross Drive"},
{0x174, "Teleport Shot"},
{0x175, "Psycho Shot"},
{0x176, "Condor Dive"},
{0x177, "Run Ball Run"},
{0x178, "Triangle Z"},
{0x179, "Utter Gutsiness Bat"},
{0x17a, "Reflect Buster"},
{0x17b, "Kung Fu Header"},
{0x17c, "Shine Drive"},
{0x17d, "Divine Arrows"},
{0x17e, "Back Tornado"},
{0x17f, "Tarzan Kick"},
{0x180, "God Knows"},
{0x181, "Dragon Tornado"},
{0x182, "Dirt Ball"},
{0x183, "Tsunami Wall"},
{0x184, "Tornado Catch"},
{0x185, "God Hand"},
{0x186, "Power Shield"},
{0x187, "Fireball Knuckle"},
{0x188, "Shot Pocket"},
{0x189, "Warp Space"},
{0x18a, "Counter Strike"},
{0x18b, "Sliding Goal"},
{0x18c, "Triple Defence"},
{0x18d, "Pressure Punch"},
{0x18e, "Toughness Block"},
{0x18f, "Full Power Shield"},
{0x190, "Wood Chopper"},
{0x191, "Whirlwind"},
{0x192, "Rocket Kobushi"},
{0x193, "Wild Claw"},
{0x194, "Gigant Wall"},
{0x195, "Mistral"},
{0x196, "Killer Blade"},
{0x197, "Infinite Wall"},
{0x198, "Inazuma Drop"},
{0x199, "Inazuma Break"},
{0x1c2, "F-Basic"},
{0x1c3, "F-Death Zone"},
{0x1c4, "F-Ghost Dance"},
{0x1c5, "F-Wild Park"},
{0x1c6, "F-442 Grid"},
{0x1c7, "F-Super Star 5"},
{0x1c8, "F-Crane Wings"},
{0x1c9, "F-Infinite Wall"},
{0x1ca, "F-Free March"},
{0x1cb, "F-Heaven's Gate"},
{0x1cc, "F-Phalanx"},
{0x1cf, "F-Butterfly"},
{0x1d0, "F-Dot Prison"},
{0x1d2, "F-Bow & Arrow"},
{0x1d4, "F-Midfield Block"},
{0x1d5, "F-Phoenix"},
{0x1da, "B-Basic"},
{0x1db, "B-Flat Back"},
{0x1dc, "B-Attack"},
{0x1dd, "B-Breakthrough"},
{0x1de, "B-Pressure"},
{0x1df, "B-Slash"},
{0x1e0, "B-Right wing"},
{0x1e1, "B-Train"},
{0x1e2, "B-Triangle"},
{0x1e3, "B-Lance"},
{0x1ea, "F-Gemini"},
{0x1eb, "F-Epsilon"},
{0x1ec, "F-Genesis"},
{0x1ed, "F-Dark Emperors"},
{0x1ee, "F-Basic 2"},
{0x1ef, "F-Aegis"},
{0x1f0, "F-Double Dog"},
/*{0x1ff, "Test shoes"},
{0x200, "友情ポイント"},
{0x201, "熱血ポイント"},*/
{0x209, "Gemini kit"},
{0x20a, "Epsilon kit"},
{0x20b, "Genesis kit"},
{0x20c, "Epsilon Plus kit"},
{0x20d, "Secret Service kit"},
{0x20e, "Alpine kit"},
{0x20f, "Cloister kit"},
{0x210, "Redux kit"},
{0x211, "Fauxshore kit"},
{0x212, "Mary Times kit"},
{0x213, "Dark Emperors kit"},
{0x214, "Triple C kit"},
{0x215, "Robot Guards kit"},
{0x216, "Retro kit"},
{0x217, "Skull kit"},
{0x218, "Frog kit"},
{0x219, "First star kit"},
{0x21a, "Sailor kit"},
{0x21b, "Devotion kit"},
{0x21c, "Military kit"},
{0x21d, "Terror kit"},
{0x21e, "Martial kit"},
{0x21f, "Bikers kit"},
{0x220, "Space kit"},
{0x221, "Moonlight kit"},
{0x222, "Stripe kit"},
{0x223, "Primary kit"},
{0x224, "Slash kit"},
{0x225, "Thunder kit"},
{0x226, "Mettle kit"},
{0x227, "Soldier kit"},
{0x228, "Future kit"},
{0x229, "Prominence kit"},
{0x22a, "Diamond Dust kit"},
{0x22b, "Legendary kit"},
{0x22c, "Agent kit"},
{0x23a, "Stardust boots"},
{0x23b, "Stardust boots"},
{0x23c, "Planet boots"},
{0x23d, "Planet boots"},
{0x23e, "Space boots"},
{0x23f, "Space boots"},
{0x240, "Security boots"},
{0x241, "Security boots"},
{0x242, "Snow boots"},
{0x243, "Snow boots"},
{0x244, "Discipline boots"},
{0x245, "Discipline boots"},
{0x246, "Jet black boots"},
{0x247, "Jet black boots"},
{0x248, "Twilight boots"},
{0x249, "Twilight boots"},
{0x24a, "Marine boots"},
{0x24b, "Marine boots"},
{0x24c, "Shadow boots"},
{0x24d, "Shadow boots"},
{0x24e, "Naniwa boots"},
{0x24f, "Naniwa boots"},
{0x250, "Guard boots （PK）"},
{0x251, "Guard boots （GK）"},
{0x252, "Maize boots"},
{0x253, "Maize boots"},
{0x254, "Legendary boots"},
{0x255, "Luxury boots"},
{0x256, "Bikers boots"},
{0x257, "Bikers boots"},
{0x258, "Martial boots"},
{0x259, "Martial boots"},
{0x25a, "White boots"},
{0x25b, "Vacuum boots"},
{0x25c, "Wrath boots"},
{0x25d, "Chequered boots"},
{0x25e, "Fresh boots"},
{0x25f, "Thermo boots"},
{0x260, "Scorched boots"},
{0x261, "Scorched boots"},
{0x262, "Frozen boots"},
{0x263, "Frozen boots"},
{0x264, "New generation boots"},
{0x265, "Chaos boots"},
{0x266, "Chaos boots"},
{0x267, "New generation boots"},
{0x276, "Micro gloves"},
{0x277, "Macro gloves"},
{0x278, "Big Bang gloves"},
{0x279, "Macro gloves plus"},
{0x27a, "Iron wall gloves"},
{0x27b, "Northern gloves"},
{0x27c, "Kung fu gloves"},
{0x27d, "Strong man gloves"},
{0x27e, "Sunset gloves"},
{0x27f, "Resort gloves"},
{0x280, "Betrayal gloves"},
{0x281, "Maiden gloves"},
{0x282, "Guard gloves"},
{0x283, "Forest gloves"},
{0x284, "Legendary gloves"},
{0x285, "Agent gloves"},
{0x286, "Corona gloves"},
{0x287, "Aurora gloves"},
{0x288, "New generation gloves"},
{0x289, "Practice gloves"},
{0x28a, "Air gloves"},
{0x28b, "Nature gloves"},
{0x28c, "Steel gloves"},
{0x28d, "Passion gloves"},
{0x28e, "Pretty gloves 2"},
{0x28f, "Surefire win gloves"},
{0x290, "Fresh gloves"},
{0x291, "Destruction gloves"},
{0x292, "Space-time gloves"},
{0x294, "Titanium bracelet"},
{0x295, "Friendship bracelet"},
{0x296, "Passion bracelet"},
{0x297, "Land bracelet"},
{0x298, "Peach bracelet"},
{0x299, "Stylish bracelet"},
{0x29a, "Strongest bracelet"},
{0x29b, "Exotic bracelet"},
{0x29c, "Cosmos bracelet"},
{0x2a8, "Bronze power pendant"},
{0x2a9, "Silver power pendant"},
{0x2aa, "Gold power pendant"},
{0x2ab, "Bronze shield pendant"},
{0x2ac, "Silver shield pendant"},
{0x2ad, "Gold shield pendant"},
{0x2bc, "Eternal Blizzard"},
{0x2bd, "Fireball Storm"},
{0x2be, "Tsunami Boost"},
{0x2bf, "Death Zone 2"},
{0x2c0, "The Earth"},
{0x2c1, "Rainbow Arc"},
{0x2c2, "Astro Break"},
{0x2c3, "Acrobat Bomber"},
{0x2c4, "Kung Fu Fighting"},
{0x2c5, "Double Grenade"},
{0x2c6, "Gyro Head"},
{0x2c7, "Revolution V"},
{0x2c8, "Heel Kick"},
{0x2c9, "Dragon Cannon"},
{0x2ca, "Dual Strike"},
{0x2cb, "Legendary Wolf"},
{0x2cc, "Emperor Penguin No. 1"},
{0x2cd, "Bed Of Roses"},
{0x2ce, "Utter Gutsiness Club"},
{0x2cf, "Double Wrath Shot"},
{0x2d0, "Land Dragon"},
{0x2d1, "Tri-Pegasus"},
{0x2d2, "Inazuma-1 Drop"},
{0x2d3, "Ganymede Ray"},
{0x2d4, "Leaping Thunder"},
{0x2d5, "Eagle Buster"},
{0x2d6, "Butterfly Trance"},
{0x2d7, "Cosmic Blast"},
{0x2d8, "Gaia Break"},
{0x2d9, "Spectacle Crash"},
{0x2da, "Twin Boost F"},
{0x2db, "Double Tornado"},
{0x2dc, "Security Shot"},
{0x2dd, "Supernova"},
{0x2de, "Space Penguin"},
{0x2df, "Wyvern Crash"},
{0x2e0, "Wyvern Blizzard"},
{0x2e1, "Cross Fire"},
{0x2e2, "Dark Phoenix"},
{0x2e3, "Triple Boost"},
{0x2e4, "Neo Galaxy"},
{0x2e5, "Assault Shot"},
{0x2e6, "God Break"},
{0x2e7, "Megaton Head"},
{0x2e8, "Steeple Shot"},
{0x2e9, "Meteor Blade"},
{0x2ea, "Gungnir"},
{0x2eb, "Atomic Flare"},
{0x2ec, "Northern Impact"},
{0x2ed, "Fire Blizzard"},
{0x2ee, "Cross Fire"},
{0x2ef, "Fire Blizzard"},
{0x2f8, "Deceptor Dribble"},
{0x2f9, "Invisible Fake"},
{0x2fa, "Gale Dash"},
{0x2fb, "Three-Legged Rush"},
{0x2fc, "Aurora Dribble"},
{0x2fd, "Double Touch"},
{0x2fe, "Dual Pass"},
{0x2ff, "Bubble Gum"},
{0x300, "Prima Donna"},
{0x301, "Armadillo Circus"},
{0x302, "Breakthrough 2"},
{0x303, "Triple Dash"},
{0x304, "Lightning Sprint"},
{0x305, "Aikido"},
{0x306, "Mole Shuffle"},
{0x307, "Dark Whirlwind"},
{0x308, "Warp Drive"},
{0x309, "Meteor Shower"},
{0x30a, "Southern Cross"},
{0x30b, "Ribbon Shower"},
{0x30c, "Big Fan"},
{0x30d, "Flame Veil"},
{0x30e, "Water Veil"},
{0x319, "Shooting Star"},
{0x31a, "Land Of Ice"},
{0x31b, "Clone Defence"},
{0x31c, "Circus Block"},
{0x31d, "Heavy Mettle"},
{0x31e, "The Tower"},
{0x31f, "Photon Crash"},
{0x320, "Gravitation"},
{0x321, "Dual Storm"},
{0x322, "Supreme Spin"},
{0x323, "Fake Bomber"},
{0x324, "Volcano Cut"},
{0x325, "Super Sumo Stomp"},
{0x326, "Planet Shield"},
{0x327, "Sigma Zone"},
{0x328, "Double Cyclone"},
{0x329, "No Escape"},
{0x32a, "Flame Dance"},
{0x32b, "Asteroid Belt"},
{0x32c, "Body Shield"},
{0x32d, "Perimeter Zone"},
{0x32e, "Mega Wall"},
{0x32f, "Road Roller"},
{0x330, "Sleeping Dust"},
{0x331, "Ignite Steal"},
{0x332, "Whale Guard"},
{0x333, "Whirlwind Force"},
{0x334, "Mad Express"},
{0x335, "Frozen Steal"},
{0x336, "Stone Wall"},
{0x337, "Perfect Tower"},
{0x340, "Mugen The Hand"},
{0x341, "Utter Gutsiness Catch"},
{0x342, "Fireball Head"},
{0x343, "Aurora Curtain"},
{0x344, "Table-Turner"},
{0x345, "Flame Breath"},
{0x346, "Beast Fang"},
{0x347, "Drill Smasher"},
{0x348, "Clone Block"},
{0x34a, "Claw Slash"},
{0x34b, "Dual Smash"},
{0x34c, "Double Rocket"},
{0x34d, "Flower Power"},
{0x34e, "Swan Dive"},
{0x34f, "Triple God Hand"},
{0x350, "Black Hole"},
{0x351, "Safety First"},
{0x352, "Wormhole"},
{0x353, "Temporal Wall"},
{0x354, "Procyon Net"},
{0x355, "Fist Of Justice"},
{0x356, "Burnout"},
{0x357, "Ice Block"},
{0x385, "Keeper Plus"},
{0x386, "Speed Plus"},
{0x387, "Shoot Plus"},
{0x388, "Defence Plus"},
{0x389, "Offence Plus"},
{0x38a, "Recovery"},
{0x38b, "Trickery!"},
{0x38c, "Charm Up!"},
{0x38d, "Cool Up!"},
{0x38e, "Economy!"},
{0x38f, "Big Moves!"},
{0x390, "Power Element"},
{0x391, "Study"},
{0x392, "Slack Off"},
{0x393, "Critical!"},
{0x394, "No Element"},
{0x395, "Lucky!"},
{0x396, "Jinx"},
{0x397, "Speed Force"},
{0x398, "Shot Force"},
{0x399, "Defence Force"},
{0x39a, "Offence Force"},
{0x39b, "Never Give Up"},
{0x39c, "Move It!"},
{0x39d, "Everyone Move It!"}

        };
    }
}