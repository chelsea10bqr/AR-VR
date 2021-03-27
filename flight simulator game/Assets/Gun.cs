using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float damage = 10f;
    public float range = 1000f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Shoot();
        }    
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name);
 
            Target target = hit.transform.GetComponent<Target>();
            if(target!=null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
