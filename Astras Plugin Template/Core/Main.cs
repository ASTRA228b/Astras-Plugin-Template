using Astras_Plugin_Template.Libraries;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Astras_Plugin_Template.Core;

public class Main : MonoBehaviour
{
    // your mod code here heres a bit of a example
    private bool _Pressed = false;
    private void FixedUpdate()
    {
        Mod();
    }

    private void Start()
    {
        OnScreenNotify.SendIT("Hello Wellcome to the example mod.");
        OnScreenNotify.SendIT("Press The A Button or PrimaryButton on your Controller or A on your keyboard and watch the magic happen!");
    }

    private void Mod()
    {
        if (InputLib.RightControllerAButton || Keyboard.current.aKey.wasPressedThisFrame && !_Pressed)
        {
            OnScreenNotify.SendIT("Pressed the Button!");
            OnScreenNotify.SendIT("Joining FanCode");
            JoinRoom("ASTRA");
        }
        _Pressed = InputLib.RightControllerAButton;
    }

    private void JoinRoom(string roomName)
    {
        if (PhotonNetwork.InRoom)
        {
            PhotonNetwork.Disconnect();
        }
        PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(roomName, JoinType.Solo);
    }
}