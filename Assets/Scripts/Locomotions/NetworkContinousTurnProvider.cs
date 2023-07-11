using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NetworkContinousTurnProvider : ActionBasedContinuousTurnProvider
{
    [SerializeField]
    private bool enableInputAction;


    protected override Vector2 ReadInput()
    {
        if (!enableInputAction)
        {
            return Vector2.zero;
        }
        return base.ReadInput();
    }
}
