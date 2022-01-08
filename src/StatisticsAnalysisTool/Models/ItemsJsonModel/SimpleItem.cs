﻿using System.Text.Json.Serialization;
using StatisticsAnalysisTool.Annotations;

namespace StatisticsAnalysisTool.Models.ItemWindowModel;

public class SimpleItem
{
    [JsonPropertyName("@uniquename")]
    public string UniqueName { get; set; }

    [JsonPropertyName("@tier")]
    public string Tier { get; set; }

    [JsonPropertyName("@weight")]
    public string Weight { get; set; }

    [JsonPropertyName("@maxstacksize")]
    public string MaxStackSize { get; set; }

    [JsonPropertyName("@uisprite")]
    public string UiSprite { get; set; }

    [JsonPropertyName("@ShopCategory")]
    public string ShopCategory { get; set; }

    [JsonPropertyName("@shopsubcategory1")]
    public string ShopSubCategory1 { get; set; }

    [JsonPropertyName("@unlockedtocraft")]
    public string UnlockedToCraft { get; set; }

    [JsonPropertyName("@itemvalue")]
    public string ItemValue { get; set; }

    [JsonPropertyName("@nutrition")]
    public string Nutrition { get; set; }

    [JsonPropertyName("@foodcategory")]
    public string FoodCategory { get; set; }

    [JsonPropertyName("@resourcetype")]
    public string ResourceType { get; set; }

    [JsonPropertyName("@famevalue")]
    public string FameValue { get; set; }

    [JsonPropertyName("@enchantmentlevel")]
    public string EnchantmentLevel { get; set; }

    [JsonPropertyName("@fishingfame")]
    public string FishingFame { get; set; }

    [JsonPropertyName("@fishingminigamesetting")]
    public string FishingMiniGameSetting { get; set; }
    [JsonPropertyName("craftingrequirements")]

    public object CraftingRequirements { get; set; }

    [JsonPropertyName("@descriptionlocatag")]
    public string DescriptionLocaTag { get; set; }

    [JsonPropertyName("@fasttravelfactor")]
    public string FastTravelFactor { get; set; }
}