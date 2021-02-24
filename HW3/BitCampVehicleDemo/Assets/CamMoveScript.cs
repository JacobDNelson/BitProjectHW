using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoveScript : MonoBehaviour
{
    
    public GameObject truck;


    // Start is called before the first frame update
    void Start()
    {
        truck = GameObject.Find("Veh_Ute_Red_Z");
    }

    // Update is called once per frame
    void Update()
    {
        float zPos = truck.transform.position.z;
        float xPos = truck.transform.position.x;
        float yPos = truck.transform.position.y;
        transform.SetPositionAndRotation(new Vector3(xPos, yPos + 4.6f, zPos - 10), new Quaternion());
    }
}
