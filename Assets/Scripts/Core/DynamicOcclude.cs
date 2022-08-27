using UnityEngine;

namespace Jozi.GameLibrary.MeshRendering
{
    public class DynamicOcclude : MonoBehaviour
    {
        public MeshRenderer model;

        private void OnBecameInvisible()
        {
            if (model)
                model.enabled = false;
        }

        private void OnBecameVisible()
        {
            if (model)
                model.enabled = true;
        }
    }
}