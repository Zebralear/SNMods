using UnityEngine;

namespace BaseDrillMod {
    public class ContainerSize : MonoBehaviour {
        public void SetSize(int v) {
            GetComponent<StorageContainer>().Resize(5,5);
        }
    }
}