using UnityEngine;


namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {
        bool mov, rot = false;

        [Header("Output")]
        public StarterAssetsInputs starterAssetsInputs;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            starterAssetsInputs.MoveInput(virtualMoveDirection);

            if (Instructions.state == 0)
                FindObjectOfType<Instructions>().removeInstruction();

            if (Instructions.state == 2)
            {
                mov = true;
                if(mov & rot)
                    FindObjectOfType<Instructions>().removeInstruction();
            }
                
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            starterAssetsInputs.LookInput(virtualLookDirection);
            if (Instructions.state == 1)            
                FindObjectOfType<Instructions>().removeInstruction();

            if (Instructions.state == 2)
            {
                rot = true;
                if (mov & rot)
                    FindObjectOfType<Instructions>().removeInstruction();
            }
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            starterAssetsInputs.JumpInput(virtualJumpState);
        }

        public void VirtualSprintInput(bool virtualSprintState)
        {
            starterAssetsInputs.SprintInput(virtualSprintState);
        }
        
    }

}
