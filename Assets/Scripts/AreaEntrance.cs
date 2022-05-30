using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{

    public string transitionName;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("AreaEntrance - Start ");
        Debug.Log("transitionName  : " + transitionName);
        Debug.Log("PlayerController.instance.areaTransitionName  : " + PlayerController.instance.areaTransitionName);
        if(transitionName == PlayerController.instance.areaTransitionName)
        {
            Debug.Log("AreaEntrance - Start " + transform.position);
            PlayerController.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
