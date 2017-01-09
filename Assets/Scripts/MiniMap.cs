using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {

    [SerializeField]
    Transform target;
    [SerializeField]
    float distance;
    [SerializeField]
    float targetHeight;

    private float x = 90;
    private float y = 0;

    void Update() {
        if (!target) {
            return;
        }

        y = target.eulerAngles.y;

        Quaternion rotation = Quaternion.Euler(x, y, 0);
        transform.rotation = rotation;

        var position = target.position - (rotation * Vector3.forward * distance + new Vector3(0, -targetHeight, 0));
        transform.position = position;
    }
}
