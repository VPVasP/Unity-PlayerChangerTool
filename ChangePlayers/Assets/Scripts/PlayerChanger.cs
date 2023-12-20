using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerChanger : MonoBehaviour
{
    public CinemachineFreeLook freeLookCamera; //refrence to our cinemachine free look camera
    public Transform[] targets; //refrence to the target players
    public GameObject[] healthBars; //refrence to the health bars
    public GameObject[] staminaBars; //refrence to the stamina bars
    private int currentTargetIndex = 0; //current target index number
    private void Start()
    {
        //we activate and disable the health-stamina bars for the correct targets
        healthBars[currentTargetIndex].SetActive(true);
        staminaBars[currentTargetIndex].SetActive(true);
        healthBars[currentTargetIndex + 1].SetActive(false);
        staminaBars[currentTargetIndex + 1].SetActive(false);
        //we disable the normal movement,canvas and we enable the ai script for the second player
        targets[1].GetComponentInChildren<Canvas>().enabled = false;
        targets[1].GetComponent<PlayerController>().enabled = false;
     
        targets[1].GetComponent<AIPlayer>().enabled = true;
        
     
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
          
            SwitchToNextTarget();
        }
    }

   public  void SwitchToNextTarget()
    {
        //we disable the normal movement,health-stamina bars and we enable the ai script for the player that is about to change
        targets[currentTargetIndex].GetComponent<PlayerController>().enabled = false;
      
        targets[currentTargetIndex].GetComponent<AIPlayer>().enabled = true;
      
        targets[currentTargetIndex].GetComponentInChildren<Canvas>().enabled = false;

       
        healthBars[currentTargetIndex].SetActive(false);
        staminaBars[currentTargetIndex].SetActive(false);

       //we update the current target index to the next one in the array
        currentTargetIndex = (currentTargetIndex + 1) % targets.Length;
        Transform nextTarget = targets[currentTargetIndex];

        //we enable normal movement, disable AI script, and enable canvas for the next target
        nextTarget.GetComponent<PlayerController>().enabled = true;
     
        nextTarget.GetComponent<AIPlayer>().enabled = false;
    
        nextTarget.GetComponentInChildren<Canvas>().enabled = true;

        //we activate health-stamina bars for the next target

        healthBars[currentTargetIndex].SetActive(true);
        staminaBars[currentTargetIndex].SetActive(true);

        //we set the cinemachine camera to follow and look at the next target
        freeLookCamera.m_LookAt = nextTarget;
        freeLookCamera.GetRig(0).m_LookAt = nextTarget;
        freeLookCamera.GetRig(1).m_LookAt = nextTarget; 
        freeLookCamera.GetRig(2).m_LookAt = nextTarget; 

        freeLookCamera.m_Follow = nextTarget;
        freeLookCamera.GetRig(0).m_Follow = nextTarget;
        freeLookCamera.GetRig(1).m_Follow = nextTarget;
        freeLookCamera.GetRig(2).m_Follow = nextTarget; 

    }
}