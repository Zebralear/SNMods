using UnityEngine;

namespace BaseDrillMod
{
    [DefaultExecutionOrder(1)]
    public class BaseDrillMesh : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.AddComponent<StorageContainer>();
            StorageContainer storageContainer = GetComponent<StorageContainer>();

        }

        private void Start()
        {
            StorageContainer storageContainer = GetComponent<StorageContainer>();
            storageContainer.Resize(5, 5);
        }
    }

}