using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{
    public Waypoint Target;
    public float moveSpeed = 5f;
    public void attributeTarget(Waypoint _target)
    {
        Target = _target;
    }
    // Start is called before the first frame update
    private void Update()
    {
        if (Target != null)
        {
            Vector3 _directionToMove = Target.transform.position - transform.position;
            _directionToMove = _directionToMove.normalized * Time.deltaTime * moveSpeed;
            float _maxDistance = Vector3.Distance(transform.position, Target.transform.position);
            transform.position = transform.position + Vector3.ClampMagnitude(_directionToMove, _maxDistance);
        }
    }
}
