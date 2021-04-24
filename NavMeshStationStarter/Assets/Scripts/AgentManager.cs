using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;

    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;   //define uma rota até o ponto criado, calcula todas as rotas possiveis e o caminho mais proximo que ele possa fazer.
            
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) //dispara a açao para o objeto.
            {

                foreach (GameObject a in agents)
                    a.GetComponent<AlControl>().agent.SetDestination(hit.point);

            }


        }
        
    }
}
