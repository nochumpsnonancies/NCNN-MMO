using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkPlayer : NetworkBehaviour {

	void Start ()
  {}

	void Update ()
  {
    if (!isLocalPlayer)
    {
      return;
    }
	}
}
