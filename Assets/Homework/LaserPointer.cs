using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] GameObject pointPrototype;

    List<Transform> points = new List<Transform>();

    void Update()
    {
        Vector3 selfPoint = transform.position;
        Ray ray = new(selfPoint, transform.up);

        bool isHit = Physics.Raycast(ray, out RaycastHit hit);

        if (!isHit)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i].gameObject.SetActive(false);
            }
            return;
        }

        int pointCount = Mathf.CeilToInt((hit.point - selfPoint).magnitude / distance);
        while (points.Count < pointCount) 
        {
            GameObject newPoint = Instantiate(pointPrototype, transform);
            // newPoint.transform.parent = transform;

            points.Add(newPoint.transform);
        }

        Vector3 distanceVector = ray.direction.normalized * distance;
        Vector3 currentPoint = selfPoint;
        for (int i = 0; i < pointCount; i++)
        {
            points[i].gameObject.SetActive(isHit);
            if (isHit) 
            { 
                points[i].position = currentPoint;
                currentPoint += distanceVector;
            }
        }

        for (int i = pointCount; i < points.Count; i++)
        {
            points[i].gameObject.SetActive(false);
        }
    }

}
