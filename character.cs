using UnityEngine;

public class character : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Horizontal"));

        transform.Translate(Input.GetAxis("horizontal") * Time.deltaTime, 0f, 0f);
    }
private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "pickup")
            Destroy(collider.gameObject);
    }
}
