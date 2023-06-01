using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    [SerializeField] Transform[] points;

    void Update()
    {
        Vector3 selfPoint = transform.position;
        Ray ray = new(selfPoint, transform.up);

        bool isHit = Physics.Raycast(ray, out RaycastHit hit);

        for (int i = 0; i < points.Length; i++)
        {
            points[i].gameObject.SetActive(isHit);
            if (isHit) 
            {
                float t = (float)i / (points.Length - 1);
                Vector3 p = Vector3.Lerp(selfPoint, hit.point, t);

                points[i].position = p;
            }
        }

    }

}
