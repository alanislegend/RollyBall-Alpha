
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    //Gathers Player position and offsets camera to follow behind a certain amount
    public Transform player;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
		
	}
}
