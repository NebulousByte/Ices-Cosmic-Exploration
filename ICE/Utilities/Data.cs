﻿using Dalamud.Game.ClientState.Statuses;
using Dalamud.Interface.Textures;
using Dalamud.Interface.Textures.TextureWraps;
using ECommons;
using ECommons.ExcelServices;
using FFXIVClientStructs.FFXIV.Client.UI.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Utilities;

public static unsafe class Data
{
    public static HashSet<string> CRPMissions = new HashSet<string>();
    public static HashSet<string> BSMMissions = new HashSet<string>();
    public static HashSet<string> ARMMissions = new HashSet<string>();
    public static HashSet<string> GSMMissions = new HashSet<string>();
    public static HashSet<string> LTWMissions = new HashSet<string>();
    public static HashSet<string> WVRMissions = new HashSet<string>();
    public static HashSet<string> ALCMissions = new HashSet<string>();
    public static HashSet<string> CULMissions = new HashSet<string>();

    public static HashSet<uint> ARankIds = new HashSet<uint>() { 4, 5, 6 };

    #region Dictionaries

    /// <summary>
    /// Some things to note that I didn't realize until after I really dug into the sheet a bit more/cleaned this up. <br></br>
    /// Sheet is: WKSMissionUnit <br></br>
    /// <b>- Row 0: Mission Name </b><br></br>
    /// <b>- Row 2: JobId attached to the quest (so 9 is crp, 10 is Bsm... ect)</b><br></br>
    /// <b>- Row 3: 2nd Required job???</b><br></br>
    /// <b>- Row 4: 3rd Required job???</b><br></br>
    /// <b>- Row 5: Bool -> Is it a critical mission?</b><br></br>
    /// <b>- Row 6: Rank -> D = 1 | C = 2 | B = 3 | 4 = A-1 | 5 = A-2 | 6 = A-3</b>
    /// <b>- Row 18: Recipe # -> Corresponds to the recipeID that is in </b>
    /// </summary>
    public class MissionListInfo
    {
        public string Name { get; set; }
        public uint JobId { get; set; }
        public uint JobId2 { get; set; } = 0;
        public uint JobId3 { get; set; } = 0;
        public uint Rank { get; set; }
        public uint RecipeId { get; set; } = 0;
        public uint SilverRequirement { get; set; }
        public uint GoldRequirement { get; set; }
    }

    public static Dictionary<uint, MissionListInfo> MissionInfoDict = new Dictionary<uint, MissionListInfo>();

    public class MoonRecipieInfo
    {
        public uint MainItem { get; set; }
        /// <summary>
        /// uint - itemId <br></br>
        /// int - amount necessary for craft
        /// </summary>
        public Dictionary<uint, int> RecipieItems = new Dictionary<uint, int>();

    }

    public static Dictionary<uint, MoonRecipieInfo> MoonRecipies = new();

    #endregion
}