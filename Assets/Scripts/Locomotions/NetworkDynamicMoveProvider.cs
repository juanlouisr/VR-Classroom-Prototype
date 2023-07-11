using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class NetworkDynamicMoveProvider : DynamicMoveProvider
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
