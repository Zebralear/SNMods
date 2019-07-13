using UnityEngine;

namespace BaseDrillMod
{
    public class BaseDrillMesh : MonoBehaviour
    {
        private void Awake()
        {

            StorageContainer storageContainer = GetComponent<StorageContainer>();
            gameObject.GetComponent<StorageContainer>();
			storageContainer.Resize(5, 5);
        }
    }
}