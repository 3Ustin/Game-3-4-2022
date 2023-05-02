using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpaceController : MonoBehaviour
{
                                                                            //
    //**********************************************************************||
    // This is an example of how we might go about organizing complex       ||
    //   systems in our grid structure. Currently is just a list, but more  ||
    //   complexity will be needed.                                         ||
    //                                                                      ||
    // It would be benificiual to come back to this when the Editor tools   ||
    //   for map making are completed.                                      ||
    //**********************************************************************||
                                                                            //
    public enum objectType{ Atom, Molecule, cell, tissue, Organ, OrganSystem, Organism};
    public enum objectCategory{ Water, Atmosphere, Earth, Life, Light, Fire };
    public enum objectType1{
        HasSelfMovingFunctions,
        DoesNotHaveSelfMovingFunctions,
        HasForceFunctions,
        DoesNotHaveForceFunctions,
        resistance,
        bouancyfunction,
        densityproperty,
        mass,
        flamability,
        inertiaFunction,
        albedoReflectivityOfLight,
        Radioactivity,
        Temp,
        Phase/*Solid,Liquid,Gas,Plasma*/,
        Volume,
        EMEmissionsQualityOfProducedLight,
        Vibration,
        punctureResistence,
        slashingResistence,
        bludgeoningResistence,
        AllowMixing/*Does it mix with the tiles around, Solid unlikely*/,
        stickiness/**/,
        elastisity,
        Absorption,
        Area,
        Brittleness,
        BoilingPoint,
        Capacitance,
        Color,
        Concentration,
        DF,
        Density,
        DielectricConstant,
        Ductility,
        Distribution,
        Efficacy,
        ElectricCharge,
        ElectricalConductivity,
        electricalImpedance,
        ElectricalResistivity,
        ElectricField,
        ElectricPotential,
        Emission,
        Flexibility,
        FlowRate,
        Fluidity,
        Frequency,
        IM,
        Inductance,
        IntrinsicImpedance,
        Intensity,
        Irradiance,
        Length,
        Location,
        Luminance,
        Luster,
        Malleability,
        MagneticField,
        MagneticFlux,
        Mass,
        MeltingPoint,
        Moment,
        Momentum,
        PW,
        Permeability,
        Permittivity,
        Pressure,
        Radiance,
        Resistivity,
        Reflectivity,
        Solubility,
        SpecificHeat,
        Spin,
        Strength,
        Temperature,
        Tension,
        ThermalConductivity,
        Velocity,
        Viscosity,
        WaveImpedance,

    };
    //EXAMPLE: Data as imbeded Dictionaries.
    public Dictionary<objectType, GameObject> objectsInGridForSlowerAccess = new Dictionary<objectType, GameObject>(); //This slower access can be used as a game mechanic ...||... When you level up there is a certain amount of experience you gain that can scale the access to this data ...||
    public Dictionary<objectCategory, Dictionary<objectType, GameObject>> objectsInGridByType = new Dictionary<objectCategory, Dictionary<objectType, GameObject>>();

    private List<GameObject> objectsInGridForFasterAccess = new List<GameObject>();
    private Dictionary<objectType1, List<GameObject>> objectsInGridByListedType = new Dictionary<objectType1, List<GameObject>>();

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject!=null){
            objectsInGridForFasterAccess.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject!=null){
            objectsInGridForFasterAccess.Remove(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(!objectsInGridForFasterAccess.Contains(other.gameObject)){
            GameObject.Destroy(other.gameObject); // ... || ... why, in trying to delete game objects we don't need, would we risk destroying the gameobjects we want to keep? ... ||
        }
    }
}
