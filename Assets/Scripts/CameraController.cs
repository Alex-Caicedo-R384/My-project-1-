using UnityEngine;

public class PlayerRotationController : MonoBehaviour
{
    private GameObject playerObject; 
    public float rotationSpeed = 100f; 

    private bool isRotating = false;

    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject == null)
        {
            Debug.LogError("No se encontró ningún objeto con la etiqueta 'Player'.");
        }
    }

    void Update()
    {
        if (playerObject == null)
            return;

        if (Input.GetMouseButtonDown(1))
        {
            isRotating = true;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            playerObject.transform.Rotate(Vector3.up, mouseX);
            playerObject.transform.Rotate(Vector3.left, mouseY);
        }
    }
}
