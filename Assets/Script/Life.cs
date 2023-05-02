using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class, I think, is the foundations of one that could be extended for any creature of a specific type. Eventually
// creating a heirarcy of classes that denote different creatures. 
public class Life : MonoBehaviour
{
    //Variables that this object CAN have
    //Assign the varibles that this one DOES have.

    //Growth and Development |B| All organisms grow and develop following specific instructions coded for by their genes. These genes provide instructions that will direct cellular growth and development, ensuring that a species’ young will grow up to exhibit many of the same characteristics as its parents.
        //I'd like to think about this as a function that does things to change values to be in a specific range...
            //CharacterStats
                //Name	            Type	Domain	                        Experience
                /*Health	        Int	    [0,10e^1000]	                X per total level in This{...} | X = Y(This{...})
                Mana	            Int	    [0,10e^1000]	                X per total level in This{...} | X = Y(This{...})
                AtkSpd	            Int/s	[0,10e^1000] / [0,10e^1000]	    X per attack | X = Y(AtkSpd)
                MoveSpd	            int	    [0,10]	                        X per movement | X = Y(MoveSpd)
                Vision	            int	    [0,50]	                        X per total level in This{...} | X = Y(This{...})
                Visibility	        int	    [0,10e^1000]	                X per total level in This{...} | X = Y(This{...})
                AtkDamage	        int	    [0,10e^1000]	                X per attack | X = Y(AtkSpd)
                AbilityPower	    int	    [0,10e^1000]	                X per Ability Use | X = Y(AbilityPower)
                HealthRegeneration	int/s	[0,10e^1000] / [0,10e^1000]	    X per Health Regenerated | X = Y(HealthRegeneration)
                ManaRegeneration	int/s	[0,10e^1000] / [0,10e^1000]	    X per Mana Regenerated | X = Y(ManaRegeneration)
                Armor	            float	[-1,0,1]	                    X per Health or Mana Mitigated | X = Y(Armor)
                Resistance	        float	[0,1]	                        X per Health or Mana Mitigated | X = Y(Armor)
                Hearing	            int	    [0,50]	                        X per Noise Heard | X = Y(Hearing)
                Crit Chance	        float	[0,1]	                        X per Crit | X = Y(Crit Chance, AtkSpd, AtkDamage, Armor, HealthRegeneration, Health)
                Cooldown Reduction	s	    [0,10e^1000]	                X per Ability Use | X = Y(Cooldown Reduction, Resistance, ManaRegeneration, Mana)
                */
    //Energy Proccessing function |B| All organisms use a sorce of energy for their metabolic activities. 

    //Homeostasis function |B| In order to function properly, cells need to have appropriate conditions such as proper temperature, pH, and appropriate concentration of diverse chemicals. The ability of an organism to maintain constant internal conditions
        //This could be replicated down through the gameobject children of this, but I like this as status effect.
            //StatusEffects
                //  Name	            Effect	                    Duration
                /*  Dead	            Health = 0	                Special'
                    Stunned X	        AtkSpd = 0 & MoveSpd = 0	X seconds
                    Paralyzed X	        MoveSpd = 0	                X seconds
                    Regenerative X, x	Health += x/s	            X seconds
                    Silenced X	        AbilPwr = 0	                X seconds
                    Stunted X	        Healthgen = 0	            X seconds
                    Cursed X	        Managen = 0	                X seconds
                    Froze X	            MoveSpd = 0	                X seconds
                    Blinded X	        Vision = 0	                X seconds
                    Slowed X, x	        MoveSpd -= x	            X seconds
                    Poisoned X, x	    Healthgen -= x              X seconds
                    Burning X, x	    Healthgen -= x	            X seconds
                    Deafened X	        Hearing = 0	                X seconds
                    Invisible X	        Visibility = 0	            X seconds
                    Haste X, x      	MoveSpd += x	            X seconds
                    Bleeding X, x	    Healthgen -= x	            X seconds
                    etc.
                */
    //Evolution function |ADD| The base for infuencing future behavior?

    //Regulation function |B| In Biology, Even the smallest organisms are complex and require multiple regulatory mechanisms to coordinate internal functions, respond to stimuli, and cope with environmental stresses.

    //Death function |ADD| Manages deleting this.gameobject 

    //Birth function (Reproduction) |B| 
        //Reproduction might be several functions here.
            //Am I horny (in heat)?
            //Is there potential mates?
            //Am I already pregnant/enpregnanted someone?
                //for this matter, how do males and females behave?
            //

    //Order Gameobject Model |B| In Biology, all life has order. Organisms are highly organized, coordinated structures that consist of one or more cells.
        //organize all children intelectually.

    //Response to Stimuli function (Sensitivity) |B| In Biology, Organisms can respond to diverse stimuli. Movement toward a stimulus is considered a positive response, while movement away from a stimulus is considered a negative response.
        //Basic movement, attack, defend, etc. 
        //This would be a basic function for every creatures movements and actions like eating, killing, scaring, etc?
                                                                                                                                                    //
//Key Points
        //Order can include highly organized structures such as cells, tissues, organs, and organ systems.
        //Interaction with the environment is shown by response to stimuli.
        //The ability to reproduce, grow and develop are defining features of life.
        //The concepts of biological regulation and maintenance of homeostasis are key to survival and define major properties of life.
        //Organisms use energy to maintain their metabolic processes.
        //Populations of organisms evolve to produce individuals that are adapted to their specific environment.
                                                                                                                                                    //
//Key Terms
        //phototaxis: The movement of an organism either towards or away from a source of light
        //gene: a unit of heredity; the functional units of chromosomes that determine specific characteristics by coding for specific proteins
        //chemotaxis: the movement of a cell or an organism in response to a chemical stimulant
                                                                                                                                                    //
}


// |B| Biology references :
    //https://bio.libretexts.org/Bookshelves/Introductory_and_General_Biology/Book%3A_General_Biology_(Boundless)/01%3A_The_Study_of_Life/1.07%3A_Themes_and_Concepts_of_Biology_-_Properties_of_Life#:~:text=All%20living%20organisms%20share%20several,characteristics%20serve%20to%20define%20life.

// |ADD| Austin David Dupras references :
    //I think this a good EXAMPLE to explain some organizational issues and give good boneing principles. I think this is a phylogenetic tree.
    //https://www.shapeoflife.org/sites/default/files/global/tree-of-life-sm.png || https://www.shapeoflife.org/news/resource/2016/10/18/tree-life#:~:text=The%20branches%20represent%20all%20the,that%20branch%20above%20that%20point.