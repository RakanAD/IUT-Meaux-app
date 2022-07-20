using UnityEngine;
public class Navigation : MonoBehaviour
{
    [Header("Cam�ra principale")]
    [Tooltip("On r�f�rence la cam�ra")]
    public Camera cam;
    [Header("V�rification")]
    [Tooltip("On v�rifie si il y a maintient du clique de la souris")]
    public bool isDragging = false;

    float startMouseX;
    float startMouseY;

    void Start()
    {
        cam = this.gameObject.GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDragging)
        {
            isDragging = true;
            startMouseX = Input.mousePosition.x;
            startMouseY = Input.mousePosition.y;
        }
        else if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
        }
    }

    void LateUpdate()
    {
        if (isDragging)
        {
            float endMouseX = Input.mousePosition.x;
            float endMouseY = Input.mousePosition.y;

            float diffX = endMouseX - startMouseX;
            float diffY = endMouseY - startMouseY;

            float newCenterX = Screen.width / 2 - diffX;
            float newCenterY = Screen.height / 2 - diffY;

            Vector3 LookHerePoint = cam.ScreenToWorldPoint(new Vector3(newCenterX, newCenterY, cam.nearClipPlane));

            transform.LookAt(LookHerePoint);

            startMouseX = endMouseX;
            startMouseY = endMouseY;
        }
    }
}