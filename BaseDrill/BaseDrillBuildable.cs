using System.Collections.Generic;
using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;
using UnityEngine;
using System;



namespace BaseDrillMod
{

    public class BaseDrillModule : ModPrefab
    {
        // This name will be used as the new TechType of the buildable
        public const string NameID = "BaseDrillTech";

        // The text you'll see in-game when you mouseover over it
        public const string FriendlyName = "Resource Drill";
        public const string HandOverText = "Use Drill";

        // I don't know why but the IDE wants brackets at the end of the line
        internal BaseDrillModule() : base(NameID, $"{NameID}PreFab") {}

        public void Patch()
            {
                // Register this Prefab with SMLHelper
                PrefabHandler.RegisterPrefab(this);

                // Create a new TechType for new Buildablle
                this.TechType = TechTypeHandler.AddTechType
                (
                    NameID,
                    FriendlyName,
                    "This machine gathers resources from underground veins and pulls them to the surface.",
                    ImageUtils.LoadSpriteFromFile(@"./BaseDrillMod/BaseDrillIcon.png"),
                    true
                );

                // Add the new TechType to the buildables
                CraftDataHandler.AddBuildable(this.TechType);

                // Add the new TechType to the group of Interior Module buildables
                CraftDataHandler.AddToGroup(TechGroup.InteriorModules, TechCategory.InteriorModule, this.TechType);

                LanguageHandler.SetLanguageLine(HandOverText, "Resource Drill");

                // Create new instance of TechData and apply the recipie to it
                TechData techData = new TechData
                {
                    craftAmount = 1,
                    Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.TitaniumIngot, 2),
                    new Ingredient(TechType.Diamond, 2),
                    new Ingredient(TechType.Lithium, 4),
                    new Ingredient(TechType.AdvancedWiringKit, 1),
                    new Ingredient(TechType.Lubricant, 1),
                })
                CraftDataHandler.SetTechData(TechType, techData);
        }
            
            // Associate TechType and TechData
            CraftDataHandler.SetTechData(base.TechType, techData);

            // Set which blueprints unlock the Item
            string unlockMessage = $"{FriendlyName} blueprint discovered!";
            var unlockThis = new TechType[1] {this.TechType};
            KnownTechHandler.SetAnalysisTechEntry(TechType.BaseMapRoom, unlockThis, unlockMessage);

            BaseDrillModule instance = new BaseDrillModule();
            instance.GetGameObject();
        }

      
        public static void {
           
        }

        public override GameObject GetGameObject()
        {
            var BaseDrillModule = new GameObject();
            BaseDrillModule.name = NameID;
            Console.WriteLine("[BaseDrillModule] Working at line 83");

            // Add prefab ID
            PrefabIdentifier prefabId = BaseDrillModule.AddComponent<PrefabIdentifier>();
            Console.WriteLine("[BaseDrillModule] Working at line 90");
            prefabId.ClassId = NameID;
            Console.WriteLine("[BaseDrillModule] Working at line 92");
            prefabId.name = FriendlyName;
            Console.WriteLine("[BaseDrillModule] Working at line 94");

            // Add tech tag
            TechTag techTag = BaseDrillModule.AddComponent<TechTag>();
            Console.WriteLine("[BaseDrillModule] Working at line 98");
            techTag.type = this.TechType;
            Console.WriteLine("[BaseDrillModule] Working at line 100");
            OutputTimer instance2 = new OutputTimer();


             // Add constructable - This prefab normally isn't constructed.
            Constructable constructible = BaseDrillModule.AddComponent<Constructable>();
            TechType techType = this.TechType;
            Console.WriteLine("[BaseDrillModule] Working at line 112");
            constructible.allowedInBase = true;
            Console.WriteLine("[BaseDrillModule] Working at line 114");
            constructible.allowedInSub = false;
            Console.WriteLine("[BaseDrillModule] Working at line 116");
            constructible.allowedOutside = false;
            Console.WriteLine("[BaseDrillModule] Working at line 118");
            constructible.allowedOnCeiling = false;
            Console.WriteLine("[BaseDrillModule] Working at line 120");
            constructible.allowedOnGround = true;
            Console.WriteLine("[BaseDrillModule] Working at line 122");
            constructible.allowedOnWall = false;
            Console.WriteLine("[BaseDrillModule] Working at line 124");
            constructible.allowedOnConstructables = false;
            Console.WriteLine("[BaseDrillModule] Working at line 126");
            constructible.controlModelState = true;
            Console.WriteLine("[BaseDrillModule] Working at line 128");
            constructible.rotationEnabled = false;
            Console.WriteLine("[BaseDrillModule] Working at line 130");
            constructible.techType = this.TechType; // This was necessary to correctly associate the recipe at building time
            Console.WriteLine("[BaseDrillModule] Working at line 132");
            GameObject BaseDrillMesh= GameObject.CreatePrimitive(PrimitiveType.Cube);
            Console.WriteLine("[BaseDrillModule] Working at line 134");
            constructible.model = BaseDrillMesh;
            Console.WriteLine("[BaseDrillModule] Working at line 136");
            BaseDrillMesh.transform.SetParent(BaseDrillModule.transform);
            Console.WriteLine("[BaseDrillModule] Working at line 138");
            StorageContainer storageContainer = BaseDrillMesh.AddComponent<StorageContainer>();
            StorageContainer.GetComponent<ContainerSize>().resize(4,4);
            Console.WriteLine("[BaseDrillModule] Working at line 140");
            // Apparently this needs to go here to prevent crashing
            GetComponent<StorageContainer>().Resize(5, 5);
            Console.WriteLine("[BaseDrillModule] Working at line 142");

            return BaseDrillModule;
        }
    }