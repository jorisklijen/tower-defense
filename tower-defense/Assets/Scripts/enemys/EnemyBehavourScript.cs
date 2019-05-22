﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavourScript : MonoBehaviour
{
    public int Health = 1;
    bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetShot(int damage)
    {
        Health -= damage;

        if(Health <= 0 && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        Destroy(gameObject);
    }
}

/*
 
        ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       
``````        ``````       ``````       ``````        ``````       ``````       ``````        ``````       ``````       ``````        `````` -yyyyysssssyyyyyyyyssssssyyyyyyyysssssyy+     ``````       ``````        ``````       ``````       ``````        ``````       ``````       ``````        ``````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy     ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````    :NNNNNNNNNy```````````````````````````````````````/NNNNNNNNNy`       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `````::::::+hhhhhhhhho                                       -hhhhhhhhhs::::::` ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````     NNNNNNy`````````                                         `````````/NNNNNN/`       ``````       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` .ooooooooo/                                                           .oooooooso/     ``````       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMM                                                                         yMMy     ``````       ```````      ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````     sdds---                                                                         .--+ddd``      ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````  ---sdds                                                                               :ddd---`    ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````  NNN/```                                                                  ````         `...NNN:    ```````       ``````       ```````      ```````       ``````       ```````      ```````
``````        ``````       ``````       ``````        ``````       ``````       ``````        ``````       ````-+++sss-                                                                      ``           ```ssso++:  ``````       ``````       ``````        ``````       ``````       ``````        ``````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMM                                                                                             yMMh`       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMM                                                                                             yMMh`       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` `../mmm                                                                                             yMMh`       ```````      ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `yNNy```                                                                                             yMMy ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `hMMy                                                                                                +yys///`````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `hMMy                                                                                                   /MMM`````       ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ``````        ``````       ``````       ``````        ``````       ``````       ``````  yMMy                +yyyyyyyyyyyyyyyyyyy-                          yyyyyyyyyyyyyyyyyyyy                /MMM     ``````        ``````       ``````       ``````        ``````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` yMMy          ``````hMMMMMMMMMMMMMMMMMMM/``                     ```MMMMMMMNNMMMMMMNMMMM```````         /MMM     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` yMMy         :mmmmmmNMMMMMMMMMMMMMMMMMMMNmms                   :mmmMMMMMMd+++++++++yMMMmmmmmms         /MMM     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` yMMy      .--oMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy                   /MMMMMMNmmy/////////ommmMMMMMMy         /MMM     ```````      ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `hMMy      yMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy                   /MMMMMMs////////////////MMMMMMy         /MMM`````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `hMMy      yMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy                   /MMMyyy+//////hhh+//////yyymMMmsss      /MMM`````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `hMMy      yMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy                   /MMM//////////MMMs/////////dMMMMMM      /MMM`````       ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` yMMy      yMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy                   /MMMNNNo//////+++///////NNNMMMMMMM      /MMM     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` sddy---   sddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy      .------      :dddMMMy+++//////////+++MMMMMMNddd   .--+mdd     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````  ``/NNN    ``/MMMMMMMMMMMMMMMMMMMMMMMMMMMMMy      yNNNNNN       ```MMMMMMd/////////sMMMMMMMMMy```   yNNy```     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````         ````        ``````       ``````         ````        ``````       ``````         ````     /MMM      -ssssssmMMMMMMMMMMMMMMMMMMMhss/      yMMMMMM          MMMMMMmyyyyyyyyydMMMssssss/      yMMy`         ````        ``````       ``````         ````        ``````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ````/MMM             yMMMMMMMMMMMMMMMMMMM/         yMMMMMM          MMMMMMMMMMMMMMMMMMMM             yMMy ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ````.:::hhh:         .::::::::::::::::MMM/      hhhNMMMMMMhhh:      :::hMMh:::::::::::::          hhh+::. ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````  MMM/                   `......mmm:      MMMMMMMMMMMMM/         smmy......`                MMM/    ```````       ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ``MMM/                   sNNNNNN```       MMMMMMMMMMMMM/         ```/NNNNNN:                MMM/````       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````    .//+yyy-         -//-      +yyyyyy          MMMMMMMMMMMMM/            -yyyyyy-  .///          yyyo++:`       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMM             yMMy                       MMMMMMMMMMMMM/                      /MMM             yMMh`       ```````      ```````       ``````       ```````      ```````       ``````       
``````        ``````       ``````       ``````        ``````       ``````       ``````        ``````       ````/MMM             yMMmyyy                    /////////////.                      /MMMyyy-         yMMy  ``````       ``````       ``````        ``````       ``````       ``````        ``````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ````/MMM      `.`````hMMNmmm.``````                                           ..``..+MMMMMM+..`      yMMy ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ````/MMM      :mmmmmmNMMh...mmmmmms                                           mmmmmmNMMMMMMNmms      yMMy ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ````/MMM      -hhhhhhNMMy   MMMmhhs:::::::::::::::::::::::::::::::::::::::::::hhhNMMMMMMhhhhhho      yMMy ```````       ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMM             yMMy   MMM/  /MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM   yMMMMMM             yMMh`       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````    .++osss-         :++osssMMM/  .++++++dMMd++++++dMMd+++++++++yMMM++++++yMMM   yMMd+++          sssooo/`       ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `````..``````..MMM/            :NNNMMM/```      yMMy      yMMy         /MMM      /MMM```yNNy             MMM+....```````.``````      ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````     ddddddddddMMM/            `---MMMmddo      yMMy      yMMy         /MMM      /MMMddd+--.             MMMmdddddddddddds     ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` `..-mmmmmmmmmmmmm+...             mmmmmmy......hMMy      yMMy         /MMM   ...+MMMmmm:            `...mmmmmmmmmmmmmNMMh...  ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMM-------------hMMy                   /MMMMMMMMMy      yMMy         /MMM   yMMMMMM                /MMM-------------hMMMMMM  ``````       ```````      ```````       ``````       ```````      ```````
                                                                                                  /oooyyy-------------oyysooo                .oooooomMMmoooooomMMmoooooooooyMMMoooooooooo             :oooyyy----------ssshddddddooo-                                                                       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````     yMMh-------------------+MMM                       yMMMMMMMMMMMMMMMMMMMMMMMMMMMMM/                   yMMh-------------MMMhyyyyyyMMM/    ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````     yMMNddddddddds---------:+++ddddddo                .----------------------------:`            :dddddho++/---------+dddhhhyyyhNNN::-`    ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````  ```yMMMMMMMMMMMMh::::::-------NNNNNNy``````````                                        `````````/NNNNNN+----------::oNMMyyyyyyhMMM..`     ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``MMMhyyyyyyyyymMMMMMMMMM+------------oMMMMMMMMMy                                       /MMMMMMMMMh----------------hMMmyyyyyyyyyyyyyMMM/````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````    ./++mmmhyyyyyyyyydmmmmmmmmmyoo+---------/hhhhhhhhhs///////////////////////////////////////ohhhhhhhhho-------------ooohmmdyyyyyyyyyyyyyMMM/````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMMyyyyyyyyyyyyyyyyyyyyyyymMMh-------------------oMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh-----------------------MMMhyyyyyyyyyyyyyyyyMMM/````       ```````      ```````       ``````       ```````      ```````
       ``````       ``````        ``````       ``````       ``````        ``````       `ohhhhhhyyyyyyyyyyyyyyyyyyyyyyyhhhhhhhhhh/------------:+++MMMs::sMMMMMMMMMMMMMMMMs::sMMM++++++/----------------shhhhhhhhhyyyyyyyyyyyyyyyyyhhhhhho  ``````       ``````       ``````        ``````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       `yNNmyyyyyyyyyyyyyyyyyyyyyyyyyyyyyhMMMMMMo::--------------MMM/  :NNNNNNNNNNNNNNNN:  /MMM-----------------::::::hMMMMMMyyyyyyyyyyyyyyyyyyyyyyymMMy``.`````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       `...+MMMyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyymNNh-------------MMM/   ````````````````   /MMM----------------+NNNNNNMMMmyyyyyyyyyyyyyMMMhyyyyyyyyyyyyhNNN`````       ``````       ```````      ```````       ``````       
       ``````       ``````        ``````       ``````       ``````        ``````       `://ommmyyyyyyyyyyyyyhhhhyyyyyyyyyyyyyyyydmmh+++++++++++++hhh-                      -hhh++++++++++++++++smmmmmmmmmdyyyyyyyyyyhhhmmmhyyyyyyyyyyyyhmmm///.`       ``````       ``````        ``````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ``````` yMMmyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyhMMMMMMMMMMMMM                              MMMMMMMMMMMMMMMMmyyyyyyyyyyyyyyyyyyyhMMMyyyyyyyyyyyyyyyyyyyyMMM/ ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       `````yyshddhyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyhMMMhhhhhhmMMM                              MMMMMMMMMMddddddhyyyyyyyyyyyyyyyyyyyhMMMyyyyyyyyyyyyyyyyyyyyMMM/ ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ``...MMMhyyyyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyhMMMsssssshMMM                              MMMMMMMMMMyyyyyyyyyyyyyyyyyyyyyyyyyyhMMMyyyyyyyyyyyyyyyyyyyyMMM/`.``````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ``````` :mmmyyyyyyyyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyhMMMsssssshMMM                              MMMdyydMMMyyyyyyyyyyyyyyyyyyyyyyyyyyhMMMyyyyyyyyyyyyyyyyyyyyyyydmms     ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ``````` /MMMyyyyyyyyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyhMMMsssssshMMM                              MMMhsshMMMyyyyyyyyyyyyyyyyyyyyyyyyhhdMMMyyyyyyyyyyyyyyyyyyyyyyydNNh---  ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ``````` /MMMyyyyyyyyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyhMMMsssssshMMM                              MMMhsshMMMyyyyyyyyyyyyyyyyyyyyyyymMMMMMMyyyyyyyyyyyyyyyyyyyyyyyyyyhNNN  ``````       ```````      ```````       ``````       
                                                                              /oosdddyyyyyyyyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyhMMMddddddmMMM                              MMMmddmMMMyyyyyyyyyyyyyyyyyyyydddNMMMMMMyyyyyyyyyyyyyyyyyyyyyyyyyyhMMM                                                       
```````      ```````       ``````       ```````      ```````       ``````     yMMmyyyyyyyyyyyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyydMMMMMMMMMMMMM                              MMMMMMMMMMyyyyyyyyyyyyyyyyyyyyMMMMMMMMMMyyyyyyyyyyyyyyyyyyyyyyyyyyhMMM``      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````     yMMmyyyyyyyyyyyyyyyyyyyyyyyyyymMMMNNNyyydNNNNNNNNNNNNNMMMyyyyyydMMM                              MMMdyydMMMyyyyyyyyyyyyydNNNNNNMMMdhhdMMMyyyyyyyyyyyyyyyyyyyyyyyyyyhMMM``      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````     yMMmyyyyyyyyyyyyyyyyyyyyyyyyyymMMMMMMyyymNNNNNNNNNNNNNNNNyyyssshNNN...`                          NNNhsshMMMyyyyyyyyyyyyymMMMNNNNNNhyyhMMMyyyyyyyyyyyyyyyyyyyyyyyyyyhNNN--.`    ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      `````hMMmyyyyyyyyyyyyyyyyyyyyyyyyyymMMMMMMMMMhyyyyyyyyyyyyyyyyMMMhssssssNNN:                          sssssshMMMyyyyyyhMMMMMMMMMmyyyyyyyyyhMMMyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyNNN/````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      `````hMMmyyyyyyyyyyyyyyyyyyyyyyyyyymMMNmmmmmmhyyyyyyyyyyyyyyyyMMMhssssssddds++:                       hhhhhhmMMMyyyhdddmmmmmmmmmdyyyyyyyyyhMMMdddyyyyyyyyyyyyyyyyyyyyyyyyyyyMMM/````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      `````hMMmyyyyyyyyyyyyyyyyyyyyyyyyyymMMmyyyyyyyyyyyyyyyyyyyyyyyMMMhsssssssssmMMy                       MMMMMMMMMMyyymMMmyyyyyyyyyyyyyyyyyyyhMMMMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMM/````       ```````      ```````       ``````       
``````        ``````       ``````       ``````        ``````       ``````     yMMmyyyyyyyyyyyyyyyyyyyyyyymmmdhhhyyyyyyyyyyyyyyyyyyyyyyyMMMNmmdsssmmmo::-                       hhhhhhdMMMyyymMMmyyyyyyyyyyyyyyyyyyyyhhhMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMM/     ``````       ``````       ``````        ``````
```````      ```````       ``````       ```````      ```````       ``````     yNNmyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMMMMMmsssMMM/                          sssssshMMMyyymMMmyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMM/    ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````     ``.+MMMyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMMhssssssMMM/                          sssssshMMMyyymMMmyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMM/    ```````       ``````       ```````      ```````
``````        ``````       ``````       ``````        ``````       ``````       `:hhhhhhyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMMhssyhhhMMM/                          hhhhhhdmmmhhhmmmdyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyhhhhhh-     ``````       ``````       ``````        ``````
       ``````       ```````      ```````       ``````       ```````      ```````     MMMhyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMMhsshMMMMMM/                          MMMMMMmyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyhMMM  ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````     /++hmmdyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyddddmmdhhhMMM/                          hhhNMMmyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyydmmh///  ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       `hMMmyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyyyymMMmsssMMM/                          sssmMMmyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyyyymMMy     ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ``````` ```/MMMMMMhyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyyyymMMmsssMMM/                          sssmMMMNMMyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyMMMhyyyyyyyyyyyyyyyyNMM/`..`````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````    :hddMMMhyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyyyymMMmsssMMM/                          sssmMMNNNNyyyyyyyyyyyyyyyyyyyyyyyyyyyhhhMMMhyyyyyyyyyyyyyhhhhdd: ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``MMMhyyyyyyMMMhyyyyyyyyyyyyyyyyyyyyyyyyyyyyymMMmsssMMM/                          sssmMMmyyyyyyyyyyyyyyyyyyyyyyyyyyyyyhMMMMMMhyyyyyyyyyyyyhMMM     ```````      ```````       ``````       ```````      ```````
                                                                                               MMMhyyyyyyMMMmddddddyyyyyyyyyyyyyyyyyyyyyyymMMNdddMMMhoooooooooooooooooooooooooodddNMMmyyyyyyyyyyyyyyyyyyyyyyyyyyhddmMMMMMMhyyhdddddddddhooo                                                                 
       ``````       ```````      ```````       ``````       ```````      ```````       ``````  MMMhyyyyyyMMMMMMMMMMyyyyyyyyyyyyyyyyyyyyyyymMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmyyyyyyyyyyyyyyyyyyyyyyyyyymMMMMMMMMMhyyhMMMMMMMMMy ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````  .--yNNNNNNMMMMMMMMMMNNNhyyyyyyyyyyyyyyyyyyymMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNNNNNNNNNNNNNNNNNNNNNNNNNNMMMMMMM.--yNNh-----..... ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````     sdddddddddNMMMMMMMMMdhhhhhhhhhhhhhhhhhhhNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM   sdds`````      ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````.```````.hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM````.``     ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM`````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       `hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM`````       ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` -::oMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmmmmmmNMMMMMMMMMMMMMMMMMMMMMMM     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` `..+MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMM     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ``````` smmmmmmMMMMMMNmmmmmmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMM     ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ``````        ``````       ``````       ``````        ``````       ``````       `````///hNNNmmmMMMMMMNddddddNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMNNN///. ``````        ``````       ``````       ``````        ``````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````     MMMmddmMMMMMMMMMNddddddNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMddddddmMMMMMMMMMMMMMMMMMMMNdddMMM/`       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````     MMMmddmMMMMMMNmmmdddNNNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNmmNMMMMMMMMMMMMMMMMMMMMMMMddddddmMMMMMMMMMMMMMMMMMMMNdddMMM/`       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````     MMMmddmMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmmmmMMMMMMMMMMMMMMMMMMMMMMMddddddmMMMMMMMMMMMMMMMMMMMNdddMMM/`       ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `````MMMmddmMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmmmNMMNmmmMMMMMMMMMMMMMMMMMMMMddddddmMMMMMMMMMMMMMMMMMMMNdddMMM/ ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `````MMMmddmMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMdddNMMNdddMMMMMMMMMMMMMMMMMMMMddddddmNNNMMMMMMMMMMMMMMMMNdddMMM/ ```````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `````MMMmddmMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMdddNMMNdddMMMMMMMMMMMMMMMMMMMMddddddddddMMMMMMMMMMMMMMMMNdddMMM/ ```````      ```````       ``````       ```````      ```````       ``````       
``````        ````         ``````       ``````        ````         ``````       ``````        ````       MMMmddmMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMdddNMMNdddMMMMMMMMMMMMMMMMMMMMddddddddddMMMMMMMMMMMMMMMMMNNNNNNyss+     ``````       ``````        ````         ``````       ``````        ``````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````  ```MMMmddmMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMdddNMMNdddMMMMMMMMMMMMMMMMMMMMddddddddddMMMMMMMMMMMMMMMMMMMMdddNMMy     ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` :dddmmmNMMMMMMmmmmddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMdddNMMMMMMmmmNMMMMMMMMMMMMMMMMddddddddddMMMMMMMMMMMMMMMMMMMMdddNMMy     ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMMdddNMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMdddNMMMMMMdddNMMMMMMMMMMMMMMMMddddddddddMMMMMMMMMMMMMMMMMMMMdddNMMy     ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `/MMMdddNMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNddddddNMMMMMMdddNMMMMMMMMMMMMMMMMddddddddddMMMMMMMMMMMMMMMMMMMMdddNMMh`````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `/MMMdddNMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdddNNNysshMMMdddNMMMMMMMMMMMMMMMMNNNmddddddMMMMMMMMMMMMMMMMMMMMdddNMMh`````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `/MMMdddNMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdddMMM/` /MMMdddNMMMMMMMMMMMMMMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMdddNMMh`````      ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMMdddNMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdddMMM/ `/MMMdddNMMMMMMMMMMMMMMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMdddNMMy     ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMMdddNMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdddMMM/ `/MMMdddNMMMMMMMMMMMMMMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMdddNMMy     ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMMdddNMMMMMMddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdddMMM/ `/MMMdddNMMMMMMMMMMMMMMMMMMMmddddddMMMMMMMMMMMMMMMMMMMMdddNMMy     ``````       ```````      ```````       ``````       ```````      ```````
``````        ``````       ``````       ``````        ``````       ``````       ``````        `````` /MMMdddmNNNNNNddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdddMMM/ `/MMMdddNMMMMMMMMMMMMMMMMMMMmddddddNNNMMMMMMMNNNNNNNNNNdddNMMy     ``````       ``````        ``````       ``````       ``````        ``````
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `/MMMddddddddddddddddmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdddMMM/` /MMMdddNMMMMMMMMMMMMMMMMMMMmdddddddddNMMMMMMdddddddddddddNMMh`````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `.///NNNNNNNNNNNNNNNNNmmmmmmmmmmmmmmmmmmmmmmmmmmmmmNNNN///.` .///NNNNmmmmmmmmmmmmmmmmmmmmdddddddddmmmmmmmNNNNNNNNNNNNNo//:`````      ```````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````       `````NNNNNNNNNNNNNNNNmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmNNN`````     NNNmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmNNNNNNNNNNNNN: ```````      ```````       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````     ..------.......-+MMMMMMMMMMMMMMMMMMMMMMMMMMMMMh-..     `````-..hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM-........----``       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` `::::://////::     `/MMMMMMMMMMMMMhhhhhhhhhhhhhhhho`       ``````` ohhhhhhhhhNMMNhhhMMMMMMMMMMMMMMMMMMMM``      ``/////:::::  ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ``````` /MMMMMMMMMMMMM     `/MMMMMMMMMMMMM`````       ``````       ```````      `````hMMy   MMMMMMMMMMMMMMMMMMMM``      ``MMMMMMMMMM  ``````       ```````      ```````       ``````       ```````      ```````
       ``````       ``````        ``````       ``````       ``````        ``````       ``````     +yssooooooooooooosssssys+++++++++++++yyy- ``````        ``````       ``````     yMMy   ++++++++++++++++++++yssssssssyoooooooooossyyyy+  ``````       ``````       ``````        ``````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````  ```yNNh.............NNNNNNy```          MMM/ ```````      ```````       ``````  ```yNNy                    ```MMMNNNNNNN..........NNNNNNy`..`````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````  dddo//:.............//////oddd          MMM/ ```````      ```````       ``````  ddd+--.                   :dddMMMs//////..........//////oddm`````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ````.---mmm+....................../mmm---`      MMM/ ```````      ```````       ``````  MMM/                   .--+mmmmmm/....................../mmm---.`       ``````       ```````      ```````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMM-...........................--MMM/      MMM/`       ``````       ```````      ``MMM/                   yMMh-................................MMM/ ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMM..............................MMMyooooooMMM/`       ``````       ```````      ``MMMyooooooooooooooooooosss+.................................MMM/ ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````    /MMM..............................MMMMMMMMMMMMM/``      ``````       ```````     ```MMMMMMMMMMMMMMMMMMMMMMM+................................----NNN/ ```````      ```````       ``````       ```````      ```````
       ``````       ```````      ```````       ``````       ```````      ```````       ````/MMM..............................///dMMd//////ydho`````      ```````       ````:hdd////////////////////MMM+................................/ddd:::.`       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ````/NNN:::::::::::::::::::::::::::::::::hNNh::::::hNNy`````      ```````       ````/NNN::::::::::::::::::::NNNo::::::::::::::::::::::::::::::::oNNN`````       ``````       ```````      ```````       ``````       
       ``````       ```````      ```````       ``````       ```````      ```````       ``````  MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM/``/MMMMMM/ ```````      ```````       ``````  MMMMMMMMMMMMMMMMMMMM```hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy ```````       ``````       ```````      ```````       ``````       
       ``````       ``````        ``````       ``````       ``````        ``````       ``````  yyyyyysssssyyyyyyyyssssssyyyyyyyy-``-syyyyy- ``````        ``````       ``````  yyyyyysssssyyyyyyyys```+syyyyyyyysssssyyyyyyyysssssyyyyy+  ``````       ``````       ``````        ``````       ``````       
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````
```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````       ``````       ```````      ```````



*/
