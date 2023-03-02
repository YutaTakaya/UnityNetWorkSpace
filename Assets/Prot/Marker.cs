using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    private float startTime;
    [SerializeField] float markInterval = 100.0f;
    [SerializeField] GameObject markerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime >= markInterval)
        {
            GameObject obj = Instantiate(markerPrefab);
            obj.transform.position = this.transform.position;

            //HumanPose pose = GetComponent<HumanPose>();
            //this.GetComponent<HumanPoseHandler>().GetHumanPose(ref pose);
            startTime += markInterval;
        }
    }
}
