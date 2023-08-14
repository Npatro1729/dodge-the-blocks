using UnityEngine;

public class block_spawner : MonoBehaviour
{
    public Transform[] spawn_points;
    public GameObject block_prefab;
    public GameObject triangle_prefab;
     

    private float Timetospwan = 2f;
    public float Timebetweenwaves = 1f;
    // Start is called before the first frame update
    void Update()
    {
        if(Time.time >= Timetospwan){
            spwan_blocks();
            Timetospwan = Time.time + Timebetweenwaves;
        }

        
    }

    void spwan_blocks(){
       
        int randomIndex = Random.Range(0 , spawn_points.Length);

        for(int  i =0 ; i< spawn_points.Length ;i++){

            if(randomIndex != i){
                if(i == 0 || i == 2 || i==4 ){
                Instantiate(block_prefab , spawn_points[i].position , Quaternion.identity);
                }
                if(i == 1 || i == 3 ){
                Instantiate(triangle_prefab , spawn_points[i].position , Quaternion.identity);
                }


            }
        }
    }


}
