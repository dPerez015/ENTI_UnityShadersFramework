using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Light : MonoBehaviour
{
    public Vector3 direction;
    public Color color;
    public float intensity;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        direction = transform.forward;
        //mat = ;
    }
    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position, transform.position + direction, Color.black);
    }

    // Update is called once per frame
    void Update()
    {
        direction = transform.forward;
        GetComponent<Renderer>().sharedMaterial.SetColor("_EmissionColor", color*20* intensity);
    }
}
