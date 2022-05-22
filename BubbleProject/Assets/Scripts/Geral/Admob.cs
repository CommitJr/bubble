using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Admob : MonoBehaviour
{
    #region AWAKE
    private void Awake()
    {
        MobileAds.Initialize((initStatus) =>
        {
            // SDK initialization is complete
        });
    }
    #endregion
}
