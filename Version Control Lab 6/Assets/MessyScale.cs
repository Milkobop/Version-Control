using UnityEngine;

public class MessyScale : MonoBehaviour
{
    public Vector3 minScale = new Vector3(0.5f, 0.5f, 0.5f);    //Minimum scale amounts for the x, y and z axes respectively
    public Vector3 maxScale = new Vector3(3f, 3f, 3f);          //Maximum scale amounts for the x, y and z axes respectively

    private int timesClicked = 0;                               //Number that tracks the numbers of times I've clicked the mouse
    public bool scaleChangeAllowed = true;                      //Toggle that stops scale changes from being permitted

    void Update()
    {
        // Check to see if the mouse is clicked and scale change is allowed
        if (Input.GetMouseButtonDown(0) && scaleChangeAllowed)
            {
                // define a random scale to apply on each axis between their minimum and maximum
                float _scaleX = Random.Range(minScale.x, maxScale.x);
                float _scaleY = Random.Range(minScale.y, maxScale.y);
                float _scaleZ = Random.Range(minScale.z, maxScale.z);

                //apply the scale to the object
                transform.localScale = new Vector3(_scaleX, _scaleY, _scaleZ);
                //increase the number of times clicked
                timesClicked++;

                //check number of times clicked if over 10, stop changing
                if (timesClicked > 10)
                {
                    scaleChangeAllowed = false;
                }
            }
    }
}
