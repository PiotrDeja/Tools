using UnityEngine;

// Put this component on an empty gameObject
// on yotu scene. Then follow steps 1 and 2.

public class EditingManager : MonoBehaviour
{
    public float delayToRename = 0.35f;
    public float cameraYOffset = 1f;
    public GameObject currentActiveCamera;

    // TODO
    public Transform camerasParent; // 1) create empty gameObject at 0,0,0 and put it here
    public GameObject cameraPrefab; // 2) create a empty prefab with camera and put it here 

}
