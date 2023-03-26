using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Rendering;
using StarterAssets;

public class ThirdPersonShooterController : MonoBehaviour
{
    [SerializeField]private CinemachineVirtualCamera aimVirtualCamera;
    [SerializeField] private float normalSentivity;
    [SerializeField] private float aimSentivity;

    private ThirdPersonController thirdPersonController;
    private StarterAssetsInputs starterAssetsInputs;

    private void Awake()
    {
        starterAssetsInputs= GetComponent<StarterAssetsInputs>();
        thirdPersonController= GetComponent<ThirdPersonController>();
    }

    private void Update()
    {
        if(starterAssetsInputs.aim) 
        {
            aimVirtualCamera.gameObject.SetActive(true);
            thirdPersonController.SetSenstivity(aimSentivity);

        }
        else
        {
            aimVirtualCamera.gameObject.SetActive(false);
            thirdPersonController.SetSenstivity(normalSentivity);
        }
    }
}
