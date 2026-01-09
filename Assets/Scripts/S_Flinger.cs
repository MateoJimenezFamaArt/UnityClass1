using UnityEngine;

public class S_Flinger : MonoBehaviour
{
    [Header("Setup")]
    [SerializeField] GameObject projectile; //Every object in Unity is a GameObject
    [SerializeField] Transform launchPoint; //Transform is a component that represents position, rotation, scale
    [SerializeField] Animator CatpultAnimator;
    [SerializeField] GameObject launchEffect;

    [Header("Settings")]
    [SerializeField] private float launchForce = 10f;
    [SerializeField] private float projectileLifetime = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //types of debugs
        Debug.Log("Regular version of debug");
        Debug.LogWarning("Warning Version of debug: Plops a yellow sign");
        Debug.LogAssertion("Alert version of debug: Plops a red sign");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Debug.Log("Fire1 button was pressed");
            Fire();
        }
        
    }

    private void Fire()
    {
        

        GameObject ball = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
        Rigidbody rb = ball.GetComponent<Rigidbody>();

        rb.AddForce(launchPoint.forward * launchForce, ForceMode.VelocityChange);

        CatpultAnimator.SetTrigger("Fire");

        launchEffect.SetActive(true);


    }
}
