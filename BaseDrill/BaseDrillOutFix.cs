//Don't add a semicolon after a namespace
//Namespaces should also not be in their own scope

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDrillMod
{
    public class OutputTimer
    {
        System.Timers.Timer Output;
        System.Random rand = new System.Random();
        readonly List<ResourceRange> resourceList = new List<ResourceRange>();

        public System.Random Rand { get => rand; set => rand = value; }


        //These methods should not be static. Static means the method or member is shared between the class, rather than a particular instance.
        public void InitializeResourceRange()
        {
                        //Add a semicolon at the end of each statement
            resourceList.Add(new ResourceRange(1, 10, TechType.Quartz));
            resourceList.Add(new ResourceRange(11, 19, TechType.Copper));
            resourceList.Add(new ResourceRange(20, 29, TechType.Lead));
            resourceList.Add(new ResourceRange(30, 60, TechType.Titanium));
            resourceList.Add(new ResourceRange(61, 71, TechType.Salt));
            resourceList.Add(new ResourceRange(72, 75, TechType.Gold));
            resourceList.Add(new ResourceRange(75, 84, TechType.Salt));
            resourceList.Add(new ResourceRange(85, 89, TechType.Silver));
            resourceList.Add(new ResourceRange(90, 93, TechType.Sulphur));
            resourceList.Add(new ResourceRange(94, 98, TechType.Lithium));
            resourceList.Add(new ResourceRange(99, 100, TechType.Diamond));
        }

        public void Main()
        {
            Output = new System.Timers.Timer
            {
                Interval = 10000
            };

            Output.Elapsed += OnTimedEvent;

            Output.AutoReset = true;

            Output.Enabled = true;
        }
        //Don't add a semi colon at the end of a function declaration.
        public void OnTimedEvent(System.Object source, System.Timers.ElapsedEventArgs e)
        {       
            int Random = Rand.Next(0, 101);
            foreach(ResourceRange resourceRange in resourceList)
            {
                if(resourceRange.Contains(Random))
                {
                    // Get the tech type from resource range and add it to an inventory.
                    try
                    {
                        GameObject BaseDrillMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        StorageContainer storageContainer = BaseDrillMesh.AddComponent<StorageContainer>();
                        GameObject prefab = CraftData.GetPrefabForTechType(TechType.Titanium, true);
                        InventoryItem inventoryItem = new InventoryItem(prefab.GetComponent<Pickupable>());
                        storageContainer.container.AddItem(inventoryItem.item);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[BaseDrillMod Code #798235] Error: " + ex.Message);
                        Console.WriteLine("[BaseDrillMod Code #798235] Stacktrace: " + ex.StackTrace);
                        Console.WriteLine("[BaseDrillMod Code #798235] Source: " + ex.Source);
                    }
                }
            }
        }

        public struct ResourceRange
        {
            public int Min;
            public int Max;
            public TechType TechType;

            public ResourceRange(int min, int max, TechType techType)
            {
                //Initialise the struct here.
                Min = min;
                Max = max;
                TechType = techType;
                
            }
            public bool Contains(int rand)
            {
                return Min <= rand && rand <= Max;
            }
        }
    }
}