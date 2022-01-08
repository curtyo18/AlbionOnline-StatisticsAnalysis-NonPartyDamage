﻿using System.Text.Json.Serialization;

namespace StatisticsAnalysisTool.Models.ItemWindowModel;

public class CrystalLeagueItem
{
    [JsonPropertyName("@uniquename")]
    public string UniqueName { get; set; }

    [JsonPropertyName("@uisprite")]
    public string UiSprite { get; set; }

    [JsonPropertyName("@ShopCategory")]
    public string ShopCategory { get; set; }

    [JsonPropertyName("@shopsubcategory1")]
    public string ShopSubCategory1 { get; set; }

    [JsonPropertyName("@tier")]
    public string Tier { get; set; }

    [JsonPropertyName("@enchantmentlevel")]
    public string EnchantmentLevel { get; set; }

    [JsonPropertyName("@resourcetype")]
    public string ResourceType { get; set; }

    [JsonPropertyName("@weight")]
    public string Weight { get; set; }

    [JsonPropertyName("@maxstacksize")]
    public string MaxStackSize { get; set; }

    [JsonPropertyName("@namelocatag")]
    public string NameLocaTag { get; set; }

    [JsonPropertyName("@descriptionlocatag")]
    public string DescriptionLocaTag { get; set; }

    [JsonPropertyName("@descvariable0")]
    public string DescVariable0 { get; set; }

    [JsonPropertyName("@salvageable")]
    public string Salvageable { get; set; }

    [JsonPropertyName("@itemvalue")]
    public string ItemValue { get; set; }

    [JsonPropertyName("@tradable")]
    public string Tradable { get; set; }

    [JsonPropertyName("@unlockedtocraft")]
    public string UnlockedToCraft { get; set; }

    [JsonPropertyName("@canbestoredinbattlevault")]
    public string CanBeStoredInBattleVault { get; set; }
    [JsonPropertyName("craftingrequirements")]
    public CraftingRequirements CraftingRequirements { get; set; }

    //[JsonPropertyName("@uispriteoverlay1")]
    //public string Uispriteoverlay1 { get; set; }
}