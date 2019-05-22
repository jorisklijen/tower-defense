using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//--------------------------------------------------- nodig voor navmesh scripting

/// <summary>
/// Geschreven door Joris de Kleijn [2-5-2019 12:00] 
/// </summary>

public class movetomuse : MonoBehaviour
{
    // public Camera cam;
    
    public NavMeshAgent agent;
    [Space]  //----------------------------------------------------------- in editor zo dat er een space tussen zit :)
    public Transform target;
    
    void Update()
    {
        agent.SetDestination(target.position);
        
        //----------------------------------[ Bewoog de enemy naar de muis klik ]-----------------------------------
        //                                                                                                         |
        //   if (Input.GetMouseButtonDown(0))                                                                      |
        //   {                                                                                                     |
        //       Ray ray = cam.ScreenPointToRay(Input.mousePosition);                                              |
        //       RaycastHit hit;                                                                                   |
        //       if (Physics.Raycast(ray, out hit))                                                                |
        //           agent.SetDestination(hit.point);                                                              |
        //   }                                                                                                     |
        //                                                                                                         |
        //----------------------------------------------------------------------------------------------------------
    }
}




/*

NNNNNNNNmmmmmmmmmmmmmmmmmNNmmmmmmmmmmmmNNmmmmmmmNNNNNNNmNNNNNNmmNNNNNNNNmmNNNmmNNNNNmNNNNNNNNNNNNNNN
NNNNNNNNmmNNmmmmmmmmmmmmmmmmmNmmmmmNmmmNNNmmNNNNNNNNNNmNNNmmmNNNNNNNNNNNNNNNmmNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNNmmmmmmmmmmmmmmmmmmmmmmmmmmNNNmmmmmNNNNNNNNNNmNNNNNmmNNNmmNNNNNNmmNNNNNNNNNNNNNNNNNNNNNNNNN
NNmmNNmmNmmmddmmNmmmmmmmmmmmmmmmmmmmmmNmmmmmmmmmmNNNNmmNNNmNNNNNmmmmmNNmmmNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNmNNmmmmmmmddmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmNNNNNNmmNmNNNNNNNNNNNNNNNNNNNNN
mmmNmmmmmmmmddddmmmmmmmmddddmmmmmmdddmmmmmddmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmNNNNNNNNNNNNNNNNNNN
mmmmmmmmmmmddddddmmmmmmmdddddmmmmmmmmmmmmmdddmmmmmmmNNmmmmdddmmmmmmmmmmmmmmmmmmmNNNmmmmmNmmmNNNMMMNN
mmmmNNmmmmmmmddddddddmmmmdddddddmmmmdddddmddddmmmmNNMNNNNmhyydmmmdmmmmmmmmdmmmmNmmmmmmdhsooosyhmNNMN
NNNNNNNmmmmmmNmmmddddddmmdddddddmmmmdddmmmmmmddmmNNMNNmmdhysshdmmmmmmmmmmmdmdmmmmmddyo+:--:::/+oyNNN
NNNNmmdyshdmmNNNNmmdddddddddddddmddddddddmmddddmmNNds+////++oydNNNNNmmmmmdmdmmmmmds/--.....--::/+hmN
NmmhysoooosooyhmNNNmddddddddddddddddddddddddddhyhhs/-........-/smNNNNmdmddddmmmmms:-...```..--:/+ohN
dhys+:+o+/::/+ydmmmmNdddddddddddddddddddddddddhsss:....````...-:ohNNNmdddddddddmd+--...``.-/++++++sm
yys/-.--....:/+oosydNmdddddddddddddddddddddddNNdhs:...`````..---/ohmNmddddddddddh+:-....:oyo++o++++y
ys+-.....```..--:/odNNddddddddddddddddddddddmNNdh/.............-:+shNmddddddddddho+o+:--/ooosso:-:+o
hs-.....--:/:----:ohmmdddhddddddhhhhhhhdddddddhh/...-:+osyo/--:/+oydNmdhhhhhdddddhyyhy+-------...:++
ys-..`.:+soso:.:+oshmmddhhhhddhhhdhhhhhhhhhs+/oo.....:/oos+:-+hmmmmmNdhhhhhhhdddhysos+:---.````.-:/+
+o:..``.-:::-../hddmmmdddhhhdhhhdhhhyyyyhhy/-:/:...```.--....ohhhmNNNdhhhhhhhhddhhs+/:--//:-`...-:/+
ss--..```......:shhmmmhhhhhhhhhhhhhhhyhhyhy/.......````..`...+so+shmmhhhhhhyhhhhhhy+::+yyo/-.---:://
y+-....```...:::+yhmmdhhhhhhhhyyyyhhhhhhhhy+-........``...://sy+:/smdyhhhhhyhhhhhhyo/:+o+////+////+s
/:-...```...-:+yddhddyyyyyhhyyyyyyyyyyyyyyyyo+/-..........:/hNmyoshdhyyyyhhhhyyyyyyyo++oo++//::/+oyd
-:-......---::+hNmmmhyyyhyyhyyyyyyyyyyyyyyyyyyy:......-:::/+ymNmmmmhyyyyyhhhyyyyhhhhyoo+++/:--:+ydmN
`/:--.....-:/osdmdddyyyyyyyyyyyyyyyyysssyyyyyyo--....---:/oshmNNNNdyyyyyyyyyyyyyhhhhhys++/:/+oymMMNN
`./+/::--..-/shmmhhhyyyysssssyyssssyyyysssssyyo.//--::-.-/shhdmNNdyyyyyyyyyyyyyyhyyyyyyyssshdmNMMMMM
``.:oyhy+//++shdyyyyyyyysyyssyyssssssssssossso+../ssso+::://+ymNdyyyyyyyyyyysyyyyyyyyyyyyyyyyhNNMMMM
o...-/ymmmddhdhyyyysssssssssssssooooosoooooooyy...-+hNNmmmdddNmysssyyyyyyyyyyyyyyyyyysyyyyyhyshNMMNN
dh+---/ohdhysyyyssssssssysssooooosoooooso+oosdy.````.:yNMMMMMNyoossyyyyyyysssyyyyyyyyyyyyyyyyhdNNNNN
mddy//+oyhyssosssssssssosooossoo++ooo+ooo+/+omy.````..-odNMMMmyosoooossssoosssssyyyyyyyyyyyyhmNNNNNN
mmdddhhdyyysssssssooooo+ooo+++++++ooooo++/.-yNmh.````.-:+shmNNhoo+++ossooosyssssyyyyyyyyyyyhdNNNNNNN
mmddddmmmhysssssssosssso+osssoo++ooosyyy+.`:mmmh+:```..--:/smNdssyysoossssysosooossyssyyyyhdNNNNNNNN
Nmmdddmmhoosoooooooooooo+ooossysyyyyyyyys//ohysyys.``....-/hNNs.-odddhhyssossooososyysyyyydNNNNNNNNN
NmmddmmNmhhso+oooooooo++ssyyyyyyyyyyyyyyyssyysssys:.`````.omNNdssyhhhhhdhyyyysssssssssysyydNNmNNNNNN
NNmmmNNMMMmdhhysoo+ooo+oyyhyssssyyssssssssssysssoso:.````-hNmmmdhyhhhhhhhhhhhhhyysooossssydNNNNNNNNN
NNmdNMMMMNNdyhdhsooo+++yyshyssssssyssssssssyysoooosh+...:odmmmmhyyyyhyhhhhhyhhdhhysoossssydNNNNNNNNN
NNNdmNNNNNNNmmNmmmdo/+ohyshyssoosssssssssosssooo++sNNhydmdmddmmhyyyyhhyhhhhyyhhhmhsssssssydNNNmNNNNN
MNNNdNNNNNNNNmNNNmd+//sysshyssoooooooooooossoooo++omNNNNmddhhmmhyyyyyyyyhhhhhhhhmmssssssshmNNNNNNNNN
NNNNdmNNmmNNmmmNNmy//+yysshysoooooosoooooosooo++++odNNNNmdhhdmdyyyyyyyyyyhdhddhdNNs+oooosdNNNNNNNNNN
NMNNmdNNNmNNNmmMNmy/:oyyoohysssooooooooooooooo+++osmMNNNmdhhhddhyyyhyhyyhhddddhdNNyoooooymNNNNNNNNNN
NMNmmdmNNmmNNmNMMNs-/ssyosyhssooooooooooosooooo++oomNNNmmhyhhddhyyyyyyyydddmdmydNNhsooosdNNNNNNNNNNN
MMmmmmdNNNNNNNNMMms:+sosssydyssssooo++ooooosooo+++omMNNmddhyhhdhyyyyhyhhdmmmmdhdNNds++oohNNNNNNNNNNN
MNmdmNdmNNNNNmNMMm+/soossydmyysssoooooooo+ooo+o++o+NMNmmddhyhhhhyyyhhhhhdmNNNhhmNNmo//++ymNNNNNNNNNN
NNmdNNdmNNNNNmNMMd++soooyhdmyysssoooo++oo+oooo+ooooNMNmmddhyhddhyyyhhhhdmNNMNhhmmNNs+///smNmNNNNNNNN
NNNmNNdmNNNNNmNMNh/oooosssymhyyssoooo++oooooo+oo+ooNMNmmddhyhhdyyhhhhdddNNMMNhddmNNs///+yNNNNNNNNNNN
NNNmNNdmNNNNNmNMNs/oosssssymhhyssoooo++ooooooooooosMNNmmdddhhhhyhdhhdddmNMMMmhmmdNNs/://sNNNNNNNNNNN
NNNNNNdmNNNNNmNMms+oosossyhmhyyyssssoo++ooooosoooshMNNmmmdddddhyhhhddddNNMMMmdddmmNo:::/sNNNNNNNNNNN
NNNNNNdmNNNNNNNMmsoosssssshNdhyyysssoo+oooooooooosdMNNmmmddddhyyyhddddmNMMMNmdddddd+:://sNNNNNNNNNNN
NNNmNNdmNNNNMNNMmysosyyssydNhhyyyssoooooo+ooooooosNMNNmmmdmmdhyhhhdhdmNMMMMNmmdddddo/++/yNNNNNNNNNmN
NNmmNmddNMNNNNNMmssoosysyhhmhyysyysso++oo+ooossoshMMNmmNNmmmdhyhhdddmNNMMMMmmdddhdms++/+hNmmNNNNNNNN
NNddmNmdNNNNNNNNhssoossyyyhNhyyssyssoo+oo+++osssydMNNmmNNmmNdyyhhdddmNNMMMMNdddhhdmho//+hmhdNNNNNNNN
NNmdNNmmNNNNNNNmysooossyhdmdhhhyyysssoooooooooosyNMNmmmmNNmmdhhhhhddmNMMMMMNddhydmNmo/:+hmhmNNNNNNNN
NNmdNNmmNNNNNNNdyssso+syhmNyyyhhyyssso++ooo+ooosyMMNmmmmNNmmdhhddddmNMMMMMMNmhydNMNNs/:+hdymNmNNNNNN
NMmdmNmmNNNNNNmhsosssosyymNoyhyyssssssoooooooooshMNNmmmmNNmmdhhddddmNMMMMMMNmddmNNNNh+:+hhomNNNNNNNN


*/
