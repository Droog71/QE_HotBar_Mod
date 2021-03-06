using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

//! This class provides loading of textures by name from Resources or Application.persistentDataPath.
public class TextDict : MonoBehaviour
{
    public Dictionary<string, Texture2D> dictionary;
    private Coroutine modTextureCoroutine;

    //! Loads textures from files for mods.
    public static IEnumerator AddModTextures(Dictionary<string, Texture2D> dictionary)
    {
        StateManager stateManager = GameObject.Find("GameManager").GetComponent<StateManager>();
        string modPath = Path.Combine(Application.persistentDataPath, "Mods");
        Directory.CreateDirectory(modPath);
        string[] modDirs = Directory.GetDirectories(modPath);
        foreach (string path in modDirs)
        {
            string texturePath = path + "/Textures/";
            Directory.CreateDirectory(texturePath);
            DirectoryInfo d = new DirectoryInfo(texturePath);
            foreach (FileInfo file in d.GetFiles("*.png"))
            {
                string filePath = texturePath + file.Name;
                UriBuilder texUriBuildier = new UriBuilder(filePath) { Scheme = "file" };
                using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(texUriBuildier.ToString()))
                {
                    yield return uwr.SendWebRequest();
                    if (!uwr.isNetworkError && !uwr.isHttpError)
                    {
                        Texture2D texture = DownloadHandlerTexture.GetContent(uwr);
                        string textureName = file.Name.Remove(file.Name.Length - 4);
                        dictionary.Add(textureName, texture);
                        string modName = new DirectoryInfo(path).Name;
                        if (!stateManager.modTextureList.Contains(textureName))
                        {
                            stateManager.modTextureList.Add(textureName);
                            Debug.Log("Mod "+"["+modName+"]"+" loaded texture [" + textureName + ".png]");
                        }
                    }
                }
            }
        }
        GameObject.Find("GameManager").GetComponent<TextureDictionary>().addedModTextures = true;
    }

    //! Called by unity engine to initialize variables on startup.
    public void Start()
    {
        dictionary = new Dictionary<string, Texture2D>
        {
            { "Tablet", Resources.Load("Tablet") as Texture2D },
            { "Menu Background", Resources.Load("MenuBackground") as Texture2D },
            { "Interface Background", Resources.Load("InterfaceBackground") as Texture2D },
            { "Container Background", Resources.Load("ContainerBackground") as Texture2D },
            { "Crafting Background", Resources.Load("CraftingBackground") as Texture2D },
            { "Selection Box", Resources.Load("SelectionBox") as Texture2D },
            { "Bronze Schematic", Resources.Load("BronzeSchematic") as Texture2D },
            { "Dark Matter Schematic", Resources.Load("DarkMatterSchematic") as Texture2D },
            { "Gear Schematic", Resources.Load("GearSchematic") as Texture2D },
            { "Heat Exchanger Schematic", Resources.Load("HeatExchangerSchematic") as Texture2D },
            { "Plate Schematic", Resources.Load("PlateSchematic") as Texture2D },
            { "Steel Schematic", Resources.Load("SteelSchematic") as Texture2D },
            { "Wire Schematic", Resources.Load("WireSchematic") as Texture2D },
            { "Crosshair", Resources.Load("Crosshair") as Texture2D },
            { "Dark Matter", Resources.Load("DarkMatter") as Texture2D },
            { "Iron Ingot", Resources.Load("IronIngot") as Texture2D },
            { "Tin Ingot", Resources.Load("TinIngot") as Texture2D },
            { "Aluminum Ingot", Resources.Load("AluminumIngot") as Texture2D },
            { "Copper Ingot", Resources.Load("CopperIngot") as Texture2D },
            { "Bronze Ingot", Resources.Load("BronzeIngot") as Texture2D },
            { "Steel Ingot", Resources.Load("SteelIngot") as Texture2D },
            { "Iron Block", Resources.Load("IronBlock") as Texture2D },
            { "Iron Ramp", Resources.Load("IronRamp") as Texture2D },
            { "Steel Block", Resources.Load("SteelBlock") as Texture2D },
            { "Steel Ramp", Resources.Load("SteelRamp") as Texture2D },
            { "Glass Block", Resources.Load("Glass") as Texture2D },
            { "Glass Block_Icon", Resources.Load("Glass_Icon") as Texture2D },
            { "Brick", Resources.Load("Brick") as Texture2D },
            { "Electric Light", Resources.Load("Light") as Texture2D },
            { "Dark Matter Collector", Resources.Load("DarkMatterCollector") as Texture2D },
            { "Dark Matter Conduit", Resources.Load("DarkMatterConduit") as Texture2D },
            { "Universal Conduit", Resources.Load("UniversalConduit") as Texture2D },
            { "Universal Extractor", Resources.Load("UniversalExtractor") as Texture2D },
            { "Auger", Resources.Load("Auger") as Texture2D },
            { "Door", Resources.Load("Door") as Texture2D },
            { "Quantum Hatchway", Resources.Load("Hatch") as Texture2D },
            { "Storage Container", Resources.Load("StorageContainer") as Texture2D },
            { "Copper Ore", Resources.Load("CopperOre") as Texture2D },
            { "Iron Ore", Resources.Load("IronOre") as Texture2D },
            { "Tin Ore", Resources.Load("TinOre") as Texture2D },
            { "Aluminum Ore", Resources.Load("AluminumOre") as Texture2D },
            { "Copper Plate", Resources.Load("CopperPlate") as Texture2D },
            { "Iron Plate", Resources.Load("IronPlate") as Texture2D },
            { "Tin Plate", Resources.Load("TinPlate") as Texture2D },
            { "Bronze Plate", Resources.Load("BronzePlate") as Texture2D },
            { "Steel Plate", Resources.Load("SteelPlate") as Texture2D },
            { "Aluminum Plate", Resources.Load("AluminumPlate") as Texture2D },
            { "Copper Gear", Resources.Load("CopperGear") as Texture2D },
            { "Iron Gear", Resources.Load("IronGear") as Texture2D },
            { "Tin Gear", Resources.Load("TinGear") as Texture2D },
            { "Bronze Gear", Resources.Load("BronzeGear") as Texture2D },
            { "Steel Gear", Resources.Load("SteelGear") as Texture2D },
            { "Aluminum Gear", Resources.Load("AluminumGear") as Texture2D },
            { "Smelter", Resources.Load("Smelter") as Texture2D },
            { "Turret", Resources.Load("Turret") as Texture2D },
            { "Missile", Resources.Load("Missile") as Texture2D },
            { "Missile Turret", Resources.Load("MissileTurret") as Texture2D },
            { "Solar Panel", Resources.Load("SolarPanel") as Texture2D },
            { "Generator", Resources.Load("Generator") as Texture2D },
            { "Power Conduit", Resources.Load("PowerConduit") as Texture2D },
            { "Nuclear Reactor", Resources.Load("NuclearReactor") as Texture2D },
            { "Reactor Turbine", Resources.Load("ReactorTurbine") as Texture2D },
            { "Alloy Smelter", Resources.Load("AlloySmelter") as Texture2D },
            { "Press", Resources.Load("Press") as Texture2D },
            { "Extruder", Resources.Load("Extruder") as Texture2D },
            { "Retriever", Resources.Load("Retriever") as Texture2D },
            { "Heat Exchanger", Resources.Load("HeatExchanger") as Texture2D },
            { "Gear Cutter", Resources.Load("GearCutter") as Texture2D },
            { "Copper Wire", Resources.Load("CopperWire") as Texture2D },
            { "Aluminum Wire", Resources.Load("AluminumWire") as Texture2D },
            { "Iron Pipe", Resources.Load("IronPipe") as Texture2D },
            { "Steel Pipe", Resources.Load("SteelPipe") as Texture2D },
            { "Coal", Resources.Load("CoalOre") as Texture2D },
            { "Ice", Resources.Load("Ice") as Texture2D },
            { "Regolith", Resources.Load("Regolith") as Texture2D },
            { "Auto Crafter", Resources.Load("AutoCrafter") as Texture2D },
            { "Rail Cart", Resources.Load("RailCart") as Texture2D },
            { "Rail Cart Hub", Resources.Load("RailCartHub") as Texture2D },
            { "Storage Computer", Resources.Load("StorageComputer") as Texture2D },
            { "Circuit Board", Resources.Load("CircuitBoard") as Texture2D },
            { "Electric Motor", Resources.Load("Motor") as Texture2D }
        };

        modTextureCoroutine = StartCoroutine(AddModTextures(dictionary));
    }
}

