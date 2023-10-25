using UnityEngine;

namespace Shinjingi
{
    [CreateAssetMenu(fileName = "DogController", menuName = "InputController/DogController")]
    public class DogController : InputController
    {
        public override bool RetrieveJumpInput()
        {
            return false;
        }

        public override float RetrieveMoveInput()
        {
            return 1f;
        }

        public override bool RetrieveJumpHoldInput()
        {
            return false;
        }
    }
}
