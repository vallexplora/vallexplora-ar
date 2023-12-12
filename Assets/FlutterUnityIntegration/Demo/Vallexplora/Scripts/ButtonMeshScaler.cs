using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMeshScaler : MonoBehaviour
{

    Vector3 initialScale = Vector3.zero;
    [SerializeField] private Vector3 scaleMultiplier = new Vector3(1, 1, 0.5f);

    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;    
    }

    public void ButtonPressDown()
    {
        transform.localScale = Vector3.Scale(initialScale, scaleMultiplier);
    }

    public void ButtonPressUp()
    {
        transform.localScale = initialScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
