using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveSystem
{
    public int playerCountry { get; set; }
    public int turnNumber { get; set; }

    public int FranceAIGold { get; set; }
    public int SpainAIGold { get; set; }
    public int PortugalAIGold { get; set; }
    public int UKAIGold { get; set; }
    public int CRAIGold { get; set; }
    public int MoroccoAIGold { get; set; }
    public int AlgeriaAIGold { get; set; }
    public int TunisAIGold { get; set; }
    public int SardiniaAIGold { get; set; }
    public int SicilyAIGold { get; set; }
    public int NaplesAIGold { get; set; }
    public int LuccaAIGold { get; set; }
    public int ItalyAIGold { get; set; }
    public int HelvetiaAIGold { get; set; }
    public int AustriaAIGold { get; set; }
    public int OttomanAIGold { get; set; }
    public int MontenegroAIGold { get; set; }
    public int PrussiaAIGold { get; set; }
    public int WarsawAIGold { get; set; }
    public int RussiaAIGold { get; set; }
    public int SwedenAIGold { get; set; }
    public int NorwayAIGold { get; set; }
    public int FranceAIPopulation { get; set; }
    public int SpainAIPopulation { get; set; }
    public int PortugalAIPopulation { get; set; }
    public int UKAIPopulation { get; set; }
    public int CRAIPopulation { get; set; }
    public int MoroccoAIPopulation { get; set; }
    public int AlgeriaAIPopulation { get; set; }
    public int TunisAIPopulation { get; set; }
    public int SardiniaAIPopulation { get; set; }
    public int SicilyAIPopulation { get; set; }
    public int NaplesAIPopulation { get; set; }
    public int LuccaAIPopulation { get; set; }
    public int ItalyAIPopulation { get; set; }
    public int HelvetiaAIPopulation { get; set; }
    public int AustriaAIPopulation { get; set; }
    public int OttomanAIPopulation { get; set; }
    public int MontenegroAIPopulation { get; set; }
    public int PrussiaAIPopulation { get; set; }
    public int WarsawAIPopulation { get; set; }
    public int RussiaAIPopulation { get; set; }
    public int SwedenAIPopulation { get; set; }
    public int NorwayAIPopulation { get; set; }
    public int FranceAIMaterial { get; set; }
    public int SpainAIMaterial { get; set; }
    public int PortugalAIMaterial { get; set; }
    public int UKAIMaterial { get; set; }
    public int CRAIMaterial { get; set; }
    public int MoroccoAIMaterial { get; set; }
    public int AlgeriaAIMaterial { get; set; }
    public int TunisAIMaterial { get; set; }
    public int SardiniaAIMaterial { get; set; }
    public int SicilyAIMaterial { get; set; }
    public int NaplesAIMaterial { get; set; }
    public int LuccaAIMaterial { get; set; }
    public int ItalyAIMaterial { get; set; }
    public int HelvetiaAIMaterial { get; set; }
    public int AustriaAIMaterial { get; set; }
    public int OttomanAIMaterial { get; set; }
    public int MontenegroAIMaterial { get; set; }
    public int PrussiaAIMaterial { get; set; }
    public int WarsawAIMaterial { get; set; }
    public int RussiaAIMaterial { get; set; }
    public int SwedenAIMaterial { get; set; }
    public int NorwayAIMaterial { get; set; }

    public int FNWcontroller { get; set; }
    public int FNWCavalry { get; set; }
    public int FNWInfantry { get; set; }
    public int FNWArtillery { get; set; }
    public int FSEcontroller { get; set; }
    public int FSECavalry { get; set; }
    public int FSEInfantry { get; set; }
    public int FSEArtillery { get; set; }
    public int FNEcontroller { get; set; }
    public int FNECavalry { get; set; }
    public int FNEInfantry { get; set; }
    public int FNEArtillery { get; set; }
    public int FSWcontroller { get; set; }
    public int FSWCavalry { get; set; }
    public int FSWInfantry { get; set; }
    public int FSWArtillery { get; set; }
    public int CORcontroller { get; set; }
    public int CORCavalry { get; set; }
    public int CORInfantry { get; set; }
    public int CORArtillery { get; set; }
    public int ROMEcontroller { get; set; }
    public int ROMECavalry { get; set; }
    public int ROMEInfantry { get; set; }
    public int ROMEArtillery { get; set; }
    public int C_Wcontroller { get; set; }
    public int C_WCavalry { get; set; }
    public int C_WInfantry { get; set; }
    public int C_WArtillery { get; set; }
    public int C_Econtroller { get; set; }
    public int C_ECavalry { get; set; }
    public int C_EInfantry { get; set; }
    public int C_EArtillery { get; set; }

    public int SNcontroller { get; set; }
    public int SNCavalry { get; set; }
    public int SNInfantry { get; set; }
    public int SNArtillery { get; set; }
    public int SScontroller { get; set; }
    public int SSCavalry { get; set; }
    public int SSInfantry { get; set; }
    public int SSArtillery { get; set; }

    public int PNcontroller { get; set; }
    public int PNCavalry { get; set; }
    public int PNInfantry { get; set; }
    public int PNArtillery { get; set; }
    public int PScontroller { get; set; }
    public int PSCavalry { get; set; }
    public int PSInfantry { get; set; }
    public int PSArtillery { get; set; }

    public int INcontroller { get; set; }
    public int INCavalry { get; set; }
    public int INInfantry { get; set; }
    public int INArtillery { get; set; }
    public int IScontroller { get; set; }
    public int ISCavalry { get; set; }
    public int ISInfantry { get; set; }
    public int ISArtillery { get; set; }
    public int EEcontroller { get; set; }
    public int EECavalry { get; set; }
    public int EEInfantry { get; set; }
    public int EEArtillery { get; set; }
    public int EWcontroller { get; set; }
    public int EWCavalry { get; set; }
    public int EWInfantry { get; set; }
    public int EWArtillery { get; set; }
    public int Scontroller { get; set; }
    public int SCavalry { get; set; }
    public int SInfantry { get; set; }
    public int SArtillery { get; set; }

    public int CNcontroller { get; set; }
    public int CNCavalry { get; set; }
    public int CNInfantry { get; set; }
    public int CNArtillery { get; set; }
    public int CScontroller { get; set; }
    public int CSCavalry { get; set; }
    public int CSInfantry { get; set; }
    public int CSArtillery { get; set; }

    public int MEcontroller { get; set; }
    public int MECavalry { get; set; }
    public int MEInfantry { get; set; }
    public int MEArtillery { get; set; }
    public int MWcontroller { get; set; }
    public int MWCavalry { get; set; }
    public int MWInfantry { get; set; }
    public int MWArtillery { get; set; }
    public int AEcontroller { get; set; }
    public int AECavalry { get; set; }
    public int AEInfantry { get; set; }
    public int AEArtillery { get; set; }
    public int ACcontroller { get; set; }
    public int ACCavalry { get; set; }
    public int ACInfantry { get; set; }
    public int ACArtillery { get; set; }
    public int AWcontroller { get; set; }
    public int AWCavalry { get; set; }
    public int AWInfantry { get; set; }
    public int AWArtillery { get; set; }
    public int TNcontroller { get; set; }
    public int TNCavalry { get; set; }
    public int TNInfantry { get; set; }
    public int TNArtillery { get; set; }
    public int TScontroller { get; set; }
    public int TSCavalry { get; set; }
    public int TSInfantry { get; set; }
    public int TSArtillery { get; set; }

    public int SACcontroller { get; set; }
    public int SACCavalry { get; set; }
    public int SACInfantry { get; set; }
    public int SACArtillery { get; set; }

    public int SICcontroller { get; set; }
    public int SICCavalry { get; set; }
    public int SICInfantry { get; set; }
    public int SICArtillery { get; set; }

    public int NEcontroller { get; set; }
    public int NECavalry { get; set; }
    public int NEInfantry { get; set; }
    public int NEArtillery { get; set; }
    public int NWcontroller { get; set; }
    public int NWCavalry { get; set; }
    public int NWInfantry { get; set; }
    public int NWArtillery { get; set; }
    public int NNcontroller { get; set; }
    public int NNCavalry { get; set; }
    public int NNInfantry { get; set; }
    public int NNArtillery { get; set; }

    public int Lcontroller { get; set; }
    public int LCavalry { get; set; }
    public int LInfantry { get; set; }
    public int LArtillery { get; set; }

    public int ITNcontroller { get; set; }
    public int ITNCavalry { get; set; }
    public int ITNInfantry { get; set; }
    public int ITNArtillery { get; set; }
    public int ITScontroller { get; set; }
    public int ITSCavalry { get; set; }
    public int ITSInfantry { get; set; }
    public int ITSArtillery { get; set; }

    public int HCcontroller { get; set; }
    public int HCCavalry { get; set; }
    public int HCInfantry { get; set; }
    public int HCArtillery { get; set; }

    public int ANEcontroller { get; set; }
    public int ANECavalry { get; set; }
    public int ANEInfantry { get; set; }
    public int ANEArtillery { get; set; }
    public int ANWcontroller { get; set; }
    public int ANWCavalry { get; set; }
    public int ANWInfantry { get; set; }
    public int ANWArtillery { get; set; }
    public int ASEcontroller { get; set; }
    public int ASECavalry { get; set; }
    public int ASEInfantry { get; set; }
    public int ASEArtillery { get; set; }
    public int ASWcontroller { get; set; }
    public int ASWCavalry { get; set; }
    public int ASWInfantry { get; set; }
    public int ASWArtillery { get; set; }

    public int GNcontroller { get; set; }
    public int GNCavalry { get; set; }
    public int GNInfantry { get; set; }
    public int GNArtillery { get; set; }
    public int GScontroller { get; set; }
    public int GSCavalry { get; set; }
    public int GSInfantry { get; set; }
    public int GSArtillery { get; set; }
    public int OEcontroller { get; set; }
    public int OECavalry { get; set; }
    public int OEInfantry { get; set; }
    public int OEArtillery { get; set; }
    public int OScontroller { get; set; }
    public int OSCavalry { get; set; }
    public int OSInfantry { get; set; }
    public int OSArtillery { get; set; }
    public int OWcontroller { get; set; }
    public int OWCavalry { get; set; }
    public int OWInfantry { get; set; }
    public int OWArtillery { get; set; }

    public int MOcontroller { get; set; }
    public int MOCavalry { get; set; }
    public int MOInfantry { get; set; }
    public int MOArtillery { get; set; }

    public int PRCcontroller { get; set; }
    public int PRCCavalry { get; set; }
    public int PRCInfantry { get; set; }
    public int PRCArtillery { get; set; }
    public int PREcontroller { get; set; }
    public int PRECavalry { get; set; }
    public int PREInfantry { get; set; }
    public int PREArtillery { get; set; }
    public int PRWcontroller { get; set; }
    public int PRWCavalry { get; set; }
    public int PRWInfantry { get; set; }
    public int PRWArtillery { get; set; }

    public int WWNcontroller { get; set; }
    public int WWNCavalry { get; set; }
    public int WWNInfantry { get; set; }
    public int WWNArtillery { get; set; }
    public int WWScontroller { get; set; }
    public int WWSCavalry { get; set; }
    public int WWSInfantry { get; set; }
    public int WWSArtillery { get; set; }
    public int WWWcontroller { get; set; }
    public int WWWCavalry { get; set; }
    public int WWWInfantry { get; set; }
    public int WWWArtillery { get; set; }

    public int RUNcontroller { get; set; }
    public int RUNCavalry { get; set; }
    public int RUNInfantry { get; set; }
    public int RUNArtillery { get; set; }
    public int RUCcontroller { get; set; }
    public int RUCCavalry { get; set; }
    public int RUCInfantry { get; set; }
    public int RUCArtillery { get; set; }
    public int RUScontroller { get; set; }
    public int RUSCavalry { get; set; }
    public int RUSInfantry { get; set; }
    public int RUSArtillery { get; set; }

    public int SWNcontroller { get; set; }
    public int SWNCavalry { get; set; }
    public int SWNInfantry { get; set; }
    public int SWNArtillery { get; set; }
    public int SWCcontroller { get; set; }
    public int SWCCavalry { get; set; }
    public int SWCInfantry { get; set; }
    public int SWCArtillery { get; set; }
    public int SWScontroller { get; set; }
    public int SWSCavalry { get; set; }
    public int SWSInfantry { get; set; }
    public int SWSArtillery { get; set; }

    public int DKNcontroller { get; set; }
    public int DKNCavalry { get; set; }
    public int DKNInfantry { get; set; }
    public int DKNArtillery { get; set; }
    public int DKScontroller { get; set; }
    public int DKSCavalry { get; set; }
    public int DKSInfantry { get; set; }
    public int DKSArtillery { get; set; }
    public int NYEcontroller { get; set; }
    public int NYECavalry { get; set; }
    public int NYEInfantry { get; set; }
    public int NYEArtillery { get; set; }
    public int NYWcontroller { get; set; }
    public int NYWCavalry { get; set; }
    public int NYWInfantry { get; set; }
    public int NYWArtillery { get; set; }

    public static SaveSystem fromAI(countries countries)
    {
        return new SaveSystem
        {
            playerCountry = (int)GameObject.Find("information").GetComponent<countries>().playerCountry,
            turnNumber = (int)GameObject.Find("information").GetComponent<countries>().turnNumber,

            FranceAIGold = (int)GameObject.Find("information").GetComponent<countries>().franceGold,
            SpainAIGold = (int)GameObject.Find("information").GetComponent<countries>().spainGold,
            PortugalAIGold = (int)GameObject.Find("information").GetComponent<countries>().portugalGold,
            UKAIGold = (int)GameObject.Find("information").GetComponent<countries>().UKGold,
            CRAIGold = (int)GameObject.Find("information").GetComponent<countries>().CRGold,
            MoroccoAIGold = (int)GameObject.Find("information").GetComponent<countries>().moroccoGold,
            AlgeriaAIGold = (int)GameObject.Find("information").GetComponent<countries>().algeriaGold,
            TunisAIGold = (int)GameObject.Find("information").GetComponent<countries>().tunisGold,
            SardiniaAIGold = (int)GameObject.Find("information").GetComponent<countries>().sardGold,
            SicilyAIGold = (int)GameObject.Find("information").GetComponent<countries>().sicilyGold,
            NaplesAIGold = (int)GameObject.Find("information").GetComponent<countries>().naplesGold,
            LuccaAIGold = (int)GameObject.Find("information").GetComponent<countries>().luccaGold,
            ItalyAIGold = (int)GameObject.Find("information").GetComponent<countries>().italyGold,
            HelvetiaAIGold = (int)GameObject.Find("information").GetComponent<countries>().helvetiaGold,
            AustriaAIGold = (int)GameObject.Find("information").GetComponent<countries>().austrianGold,
            OttomanAIGold = (int)GameObject.Find("information").GetComponent<countries>().ottomanGold,
            MontenegroAIGold = (int)GameObject.Find("information").GetComponent<countries>().monteGold,
            PrussiaAIGold = (int)GameObject.Find("information").GetComponent<countries>().prussiaGold,
            WarsawAIGold = (int)GameObject.Find("information").GetComponent<countries>().warsawGold,
            RussiaAIGold = (int)GameObject.Find("information").GetComponent<countries>().russianGold,
            SwedenAIGold = (int)GameObject.Find("information").GetComponent<countries>().swedenGold,
            NorwayAIGold = (int)GameObject.Find("information").GetComponent<countries>().norwayGold,
            FranceAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().francePopulation,
            SpainAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().spainPopulation,
            PortugalAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().portugalPopulation,
            UKAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().UKPopulation,
            CRAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().CRPopulation,
            MoroccoAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().moroccoPopulation,
            AlgeriaAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().algeriaPopulation,
            TunisAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().tunisPopulation,
            SardiniaAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().sardPopulation,
            SicilyAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().sicilyPopulation,
            NaplesAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().naplesPopulation,
            LuccaAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().luccaPopulation,
            ItalyAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().italyPopulation,
            HelvetiaAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().helvetiaPopulation,
            AustriaAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().austrianPopulation,
            OttomanAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().ottomanPopulation,
            MontenegroAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().montePopulation,
            PrussiaAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().prussiaPopulation,
            WarsawAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().warsawPopulation,
            RussiaAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().russianPopulation,
            SwedenAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().swedenPopulation,
            NorwayAIPopulation = (int)GameObject.Find("information").GetComponent<countries>().norwayPopulation,
            FranceAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().franceMaterial,
            SpainAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().spainMaterial,
            PortugalAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().portugalMaterial,
            UKAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().UKMaterial,
            CRAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().CRMaterial,
            MoroccoAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().moroccoMaterial,
            AlgeriaAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().algeriaMaterial,
            TunisAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().tunisMaterial,
            SardiniaAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().sardMaterial,
            SicilyAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().sicilyMaterial,
            NaplesAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().naplesMaterial,
            LuccaAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().luccaMaterial,
            ItalyAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().italyMaterial,
            HelvetiaAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().helvetiaMaterial,
            AustriaAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().austrianMaterial,
            OttomanAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().ottomanMaterial,
            MontenegroAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().monteMaterial,
            PrussiaAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().prussiaMaterial,
            WarsawAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().warsawMaterial,
            RussiaAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().russianMaterial,
            SwedenAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().swedenMaterial,
            NorwayAIMaterial = (int)GameObject.Find("information").GetComponent<countries>().norwayMaterial,

            FNWcontroller = (int)GameObject.Find("france_nw").GetComponent<Control>().controller,
            FNWCavalry = (int)GameObject.Find("france_nw").GetComponent<Control>().cavalry,
            FNWInfantry = (int)GameObject.Find("france_nw").GetComponent<Control>().infantry,
            FNWArtillery = (int)GameObject.Find("france_nw").GetComponent<Control>().artillery,
            FSEcontroller = (int)GameObject.Find("france_se").GetComponent<Control>().controller,
            FSECavalry = (int)GameObject.Find("france_se").GetComponent<Control>().cavalry,
            FSEInfantry = (int)GameObject.Find("france_se").GetComponent<Control>().infantry,
            FSEArtillery = (int)GameObject.Find("france_se").GetComponent<Control>().artillery,
            FNEcontroller = (int)GameObject.Find("france_ne").GetComponent<Control>().controller,
            FNECavalry = (int)GameObject.Find("france_ne").GetComponent<Control>().cavalry,
            FNEInfantry = (int)GameObject.Find("france_ne").GetComponent<Control>().infantry,
            FNEArtillery = (int)GameObject.Find("france_ne").GetComponent<Control>().artillery,
            FSWcontroller = (int)GameObject.Find("france_sw").GetComponent<Control>().controller,
            FSWCavalry = (int)GameObject.Find("france_sw").GetComponent<Control>().cavalry,
            FSWInfantry = (int)GameObject.Find("france_sw").GetComponent<Control>().infantry,
            FSWArtillery = (int)GameObject.Find("france_sw").GetComponent<Control>().artillery,
            CORcontroller = (int)GameObject.Find("corsica").GetComponent<Control>().controller,
            CORCavalry = (int)GameObject.Find("corsica").GetComponent<Control>().cavalry,
            CORInfantry = (int)GameObject.Find("corsica").GetComponent<Control>().infantry,
            CORArtillery = (int)GameObject.Find("corsica").GetComponent<Control>().artillery,
            ROMEcontroller = (int)GameObject.Find("rome").GetComponent<Control>().controller,
            ROMECavalry = (int)GameObject.Find("rome").GetComponent<Control>().cavalry,
            ROMEInfantry = (int)GameObject.Find("rome").GetComponent<Control>().infantry,
            ROMEArtillery = (int)GameObject.Find("rome").GetComponent<Control>().artillery,
            C_Wcontroller = (int)GameObject.Find("croatia_w").GetComponent<Control>().controller,
            C_WCavalry = (int)GameObject.Find("croatia_w").GetComponent<Control>().cavalry,
            C_WInfantry = (int)GameObject.Find("croatia_w").GetComponent<Control>().infantry,
            C_WArtillery = (int)GameObject.Find("croatia_w").GetComponent<Control>().artillery,
            C_Econtroller = (int)GameObject.Find("croatia_e").GetComponent<Control>().controller,
            C_ECavalry = (int)GameObject.Find("croatia_e").GetComponent<Control>().cavalry,
            C_EInfantry = (int)GameObject.Find("croatia_e").GetComponent<Control>().infantry,
            C_EArtillery = (int)GameObject.Find("croatia_e").GetComponent<Control>().artillery,

            SNcontroller = (int)GameObject.Find("spain_n").GetComponent<Control>().controller,
            SNCavalry = (int)GameObject.Find("spain_n").GetComponent<Control>().cavalry,
            SNInfantry = (int)GameObject.Find("spain_n").GetComponent<Control>().infantry,
            SNArtillery = (int)GameObject.Find("spain_n").GetComponent<Control>().artillery,
            SScontroller = (int)GameObject.Find("spain_s").GetComponent<Control>().controller,
            SSCavalry = (int)GameObject.Find("spain_s").GetComponent<Control>().cavalry,
            SSInfantry = (int)GameObject.Find("spain_s").GetComponent<Control>().infantry,
            SSArtillery = (int)GameObject.Find("spain_s").GetComponent<Control>().artillery,

            PNcontroller = (int)GameObject.Find("portugal_n").GetComponent<Control>().controller,
            PNCavalry = (int)GameObject.Find("portugal_n").GetComponent<Control>().cavalry,
            PNInfantry = (int)GameObject.Find("portugal_n").GetComponent<Control>().infantry,
            PNArtillery = (int)GameObject.Find("portugal_n").GetComponent<Control>().artillery,
            PScontroller = (int)GameObject.Find("portugal_s").GetComponent<Control>().controller,
            PSCavalry = (int)GameObject.Find("portugal_s").GetComponent<Control>().cavalry,
            PSInfantry = (int)GameObject.Find("portugal_s").GetComponent<Control>().infantry,
            PSArtillery = (int)GameObject.Find("portugal_s").GetComponent<Control>().artillery,

            INcontroller = (int)GameObject.Find("ireland_n").GetComponent<Control>().controller,
            INCavalry = (int)GameObject.Find("ireland_n").GetComponent<Control>().cavalry,
            INInfantry = (int)GameObject.Find("ireland_n").GetComponent<Control>().infantry,
            INArtillery = (int)GameObject.Find("ireland_n").GetComponent<Control>().artillery,
            IScontroller = (int)GameObject.Find("ireland_s").GetComponent<Control>().controller,
            ISCavalry = (int)GameObject.Find("ireland_s").GetComponent<Control>().cavalry,
            ISInfantry = (int)GameObject.Find("ireland_s").GetComponent<Control>().infantry,
            ISArtillery = (int)GameObject.Find("ireland_s").GetComponent<Control>().artillery,
            EEcontroller = (int)GameObject.Find("england_e").GetComponent<Control>().controller,
            EECavalry = (int)GameObject.Find("england_e").GetComponent<Control>().cavalry,
            EEInfantry = (int)GameObject.Find("england_e").GetComponent<Control>().infantry,
            EEArtillery = (int)GameObject.Find("england_e").GetComponent<Control>().artillery,
            EWcontroller = (int)GameObject.Find("england_w").GetComponent<Control>().controller,
            EWCavalry = (int)GameObject.Find("england_w").GetComponent<Control>().cavalry,
            EWInfantry = (int)GameObject.Find("england_w").GetComponent<Control>().infantry,
            EWArtillery = (int)GameObject.Find("england_w").GetComponent<Control>().artillery,
            Scontroller = (int)GameObject.Find("scotland").GetComponent<Control>().controller,
            SCavalry = (int)GameObject.Find("scotland").GetComponent<Control>().cavalry,
            SInfantry = (int)GameObject.Find("scotland").GetComponent<Control>().infantry,
            SArtillery = (int)GameObject.Find("scotland").GetComponent<Control>().artillery,
            CNcontroller = (int)GameObject.Find("cr_n").GetComponent<Control>().controller,
            CNCavalry = (int)GameObject.Find("cr_n").GetComponent<Control>().cavalry,
            CNInfantry = (int)GameObject.Find("cr_n").GetComponent<Control>().infantry,
            CNArtillery = (int)GameObject.Find("cr_n").GetComponent<Control>().artillery,
            CScontroller = (int)GameObject.Find("cr_s").GetComponent<Control>().controller,
            CSCavalry = (int)GameObject.Find("cr_s").GetComponent<Control>().cavalry,
            CSInfantry = (int)GameObject.Find("cr_s").GetComponent<Control>().infantry,
            CSArtillery = (int)GameObject.Find("cr_s").GetComponent<Control>().artillery,
            MEcontroller = (int)GameObject.Find("morocco_e").GetComponent<Control>().controller,
            MECavalry = (int)GameObject.Find("morocco_e").GetComponent<Control>().cavalry,
            MEInfantry = (int)GameObject.Find("morocco_e").GetComponent<Control>().infantry,
            MEArtillery = (int)GameObject.Find("morocco_e").GetComponent<Control>().artillery,
            MWcontroller = (int)GameObject.Find("morocco_w").GetComponent<Control>().controller,
            MWCavalry = (int)GameObject.Find("morocco_w").GetComponent<Control>().cavalry,
            MWInfantry = (int)GameObject.Find("morocco_w").GetComponent<Control>().infantry,
            MWArtillery = (int)GameObject.Find("morocco_w").GetComponent<Control>().artillery,
            AEcontroller = (int)GameObject.Find("algeria_e").GetComponent<Control>().controller,
            AECavalry = (int)GameObject.Find("algeria_e").GetComponent<Control>().cavalry,
            AEInfantry = (int)GameObject.Find("algeria_e").GetComponent<Control>().infantry,
            AEArtillery = (int)GameObject.Find("algeria_e").GetComponent<Control>().artillery,
            ACcontroller = (int)GameObject.Find("algeria_m").GetComponent<Control>().controller,
            ACCavalry = (int)GameObject.Find("algeria_m").GetComponent<Control>().cavalry,
            ACInfantry = (int)GameObject.Find("algeria_m").GetComponent<Control>().infantry,
            ACArtillery = (int)GameObject.Find("algeria_m").GetComponent<Control>().artillery,
            AWcontroller = (int)GameObject.Find("algeria_w").GetComponent<Control>().controller,
            AWCavalry = (int)GameObject.Find("algeria_w").GetComponent<Control>().cavalry,
            AWInfantry = (int)GameObject.Find("algeria_w").GetComponent<Control>().infantry,
            AWArtillery = (int)GameObject.Find("algeria_w").GetComponent<Control>().artillery,
            TNcontroller = (int)GameObject.Find("tunis_n").GetComponent<Control>().controller,
            TNCavalry = (int)GameObject.Find("tunis_n").GetComponent<Control>().cavalry,
            TNInfantry = (int)GameObject.Find("tunis_n").GetComponent<Control>().infantry,
            TNArtillery = (int)GameObject.Find("tunis_n").GetComponent<Control>().artillery,
            TScontroller = (int)GameObject.Find("tunis_s").GetComponent<Control>().controller,
            TSCavalry = (int)GameObject.Find("tunis_s").GetComponent<Control>().cavalry,
            TSInfantry = (int)GameObject.Find("tunis_s").GetComponent<Control>().infantry,
            TSArtillery = (int)GameObject.Find("tunis_s").GetComponent<Control>().artillery,
            SACcontroller = (int)GameObject.Find("sardinia_c").GetComponent<Control>().controller,
            SACCavalry = (int)GameObject.Find("sardinia_c").GetComponent<Control>().cavalry,
            SACInfantry = (int)GameObject.Find("sardinia_c").GetComponent<Control>().infantry,
            SACArtillery = (int)GameObject.Find("sardinia_c").GetComponent<Control>().artillery,
            SICcontroller = (int)GameObject.Find("sicily_c").GetComponent<Control>().controller,
            SICCavalry = (int)GameObject.Find("sicily_c").GetComponent<Control>().cavalry,
            SICInfantry = (int)GameObject.Find("sicily_c").GetComponent<Control>().infantry,
            SICArtillery = (int)GameObject.Find("sicily_c").GetComponent<Control>().artillery,
            NEcontroller = (int)GameObject.Find("naples_e").GetComponent<Control>().controller,
            NECavalry = (int)GameObject.Find("naples_e").GetComponent<Control>().cavalry,
            NEInfantry = (int)GameObject.Find("naples_e").GetComponent<Control>().infantry,
            NEArtillery = (int)GameObject.Find("naples_e").GetComponent<Control>().artillery,
            NWcontroller = (int)GameObject.Find("naples_w").GetComponent<Control>().controller,
            NWCavalry = (int)GameObject.Find("naples_w").GetComponent<Control>().cavalry,
            NWInfantry = (int)GameObject.Find("naples_w").GetComponent<Control>().infantry,
            NWArtillery = (int)GameObject.Find("naples_w").GetComponent<Control>().artillery,
            NNcontroller = (int)GameObject.Find("naples_n").GetComponent<Control>().controller,
            NNCavalry = (int)GameObject.Find("naples_n").GetComponent<Control>().cavalry,
            NNInfantry = (int)GameObject.Find("naples_n").GetComponent<Control>().infantry,
            NNArtillery = (int)GameObject.Find("naples_n").GetComponent<Control>().artillery,
            Lcontroller = (int)GameObject.Find("lucca").GetComponent<Control>().controller,
            LCavalry = (int)GameObject.Find("lucca").GetComponent<Control>().cavalry,
            LInfantry = (int)GameObject.Find("lucca").GetComponent<Control>().infantry,
            LArtillery = (int)GameObject.Find("lucca").GetComponent<Control>().artillery,
            ITNcontroller = (int)GameObject.Find("italy_n").GetComponent<Control>().controller,
            ITNCavalry = (int)GameObject.Find("italy_n").GetComponent<Control>().cavalry,
            ITNInfantry = (int)GameObject.Find("italy_n").GetComponent<Control>().infantry,
            ITNArtillery = (int)GameObject.Find("italy_n").GetComponent<Control>().artillery,
            ITScontroller = (int)GameObject.Find("italy_s").GetComponent<Control>().controller,
            ITSCavalry = (int)GameObject.Find("italy_s").GetComponent<Control>().cavalry,
            ITSInfantry = (int)GameObject.Find("italy_s").GetComponent<Control>().infantry,
            ITSArtillery = (int)GameObject.Find("italy_s").GetComponent<Control>().artillery,
            HCcontroller = (int)GameObject.Find("helvetia_c").GetComponent<Control>().controller,
            HCCavalry = (int)GameObject.Find("helvetia_c").GetComponent<Control>().cavalry,
            HCInfantry = (int)GameObject.Find("helvetia_c").GetComponent<Control>().infantry,
            HCArtillery = (int)GameObject.Find("helvetia_c").GetComponent<Control>().artillery,
            ANEcontroller = (int)GameObject.Find("austria_ne").GetComponent<Control>().controller,
            ANECavalry = (int)GameObject.Find("austria_ne").GetComponent<Control>().cavalry,
            ANEInfantry = (int)GameObject.Find("austria_ne").GetComponent<Control>().infantry,
            ANEArtillery = (int)GameObject.Find("austria_ne").GetComponent<Control>().artillery,
            ANWcontroller = (int)GameObject.Find("austria_nw").GetComponent<Control>().controller,
            ANWCavalry = (int)GameObject.Find("austria_nw").GetComponent<Control>().cavalry,
            ANWInfantry = (int)GameObject.Find("austria_nw").GetComponent<Control>().infantry,
            ANWArtillery = (int)GameObject.Find("austria_nw").GetComponent<Control>().artillery,
            ASEcontroller = (int)GameObject.Find("austria_se").GetComponent<Control>().controller,
            ASECavalry = (int)GameObject.Find("austria_se").GetComponent<Control>().cavalry,
            ASEInfantry = (int)GameObject.Find("austria_se").GetComponent<Control>().infantry,
            ASEArtillery = (int)GameObject.Find("austria_se").GetComponent<Control>().artillery,
            ASWcontroller = (int)GameObject.Find("austria_sw").GetComponent<Control>().controller,
            ASWCavalry = (int)GameObject.Find("austria_sw").GetComponent<Control>().cavalry,
            ASWInfantry = (int)GameObject.Find("austria_sw").GetComponent<Control>().infantry,
            ASWArtillery = (int)GameObject.Find("austria_sw").GetComponent<Control>().artillery,
            GNcontroller = (int)GameObject.Find("greece_n").GetComponent<Control>().controller,
            GNCavalry = (int)GameObject.Find("greece_n").GetComponent<Control>().cavalry,
            GNInfantry = (int)GameObject.Find("greece_n").GetComponent<Control>().infantry,
            GNArtillery = (int)GameObject.Find("greece_n").GetComponent<Control>().artillery,
            GScontroller = (int)GameObject.Find("greece_s").GetComponent<Control>().controller,
            GSCavalry = (int)GameObject.Find("greece_s").GetComponent<Control>().cavalry,
            GSInfantry = (int)GameObject.Find("greece_s").GetComponent<Control>().infantry,
            GSArtillery = (int)GameObject.Find("greece_s").GetComponent<Control>().artillery,
            OEcontroller = (int)GameObject.Find("ottoman_e").GetComponent<Control>().controller,
            OECavalry = (int)GameObject.Find("ottoman_e").GetComponent<Control>().cavalry,
            OEInfantry = (int)GameObject.Find("ottoman_e").GetComponent<Control>().infantry,
            OEArtillery = (int)GameObject.Find("ottoman_e").GetComponent<Control>().artillery,
            OScontroller = (int)GameObject.Find("ottoman_s").GetComponent<Control>().controller,
            OSCavalry = (int)GameObject.Find("ottoman_s").GetComponent<Control>().cavalry,
            OSInfantry = (int)GameObject.Find("ottoman_s").GetComponent<Control>().infantry,
            OSArtillery = (int)GameObject.Find("ottoman_s").GetComponent<Control>().artillery,
            OWcontroller = (int)GameObject.Find("ottoman_w").GetComponent<Control>().controller,
            OWCavalry = (int)GameObject.Find("ottoman_w").GetComponent<Control>().cavalry,
            OWInfantry = (int)GameObject.Find("ottoman_w").GetComponent<Control>().infantry,
            OWArtillery = (int)GameObject.Find("ottoman_w").GetComponent<Control>().artillery,
            MOcontroller = (int)GameObject.Find("monte").GetComponent<Control>().controller,
            MOCavalry = (int)GameObject.Find("monte").GetComponent<Control>().cavalry,
            MOInfantry = (int)GameObject.Find("monte").GetComponent<Control>().infantry,
            MOArtillery = (int)GameObject.Find("monte").GetComponent<Control>().artillery,
            PRCcontroller = (int)GameObject.Find("prussia_c").GetComponent<Control>().controller,
            PRCCavalry = (int)GameObject.Find("prussia_c").GetComponent<Control>().cavalry,
            PRCInfantry = (int)GameObject.Find("prussia_c").GetComponent<Control>().infantry,
            PRCArtillery = (int)GameObject.Find("prussia_c").GetComponent<Control>().artillery,
            PREcontroller = (int)GameObject.Find("prussia_e").GetComponent<Control>().controller,
            PRECavalry = (int)GameObject.Find("prussia_e").GetComponent<Control>().cavalry,
            PREInfantry = (int)GameObject.Find("prussia_e").GetComponent<Control>().infantry,
            PREArtillery = (int)GameObject.Find("prussia_e").GetComponent<Control>().artillery,
            PRWcontroller = (int)GameObject.Find("prussia_w").GetComponent<Control>().controller,
            PRWCavalry = (int)GameObject.Find("prussia_w").GetComponent<Control>().cavalry,
            PRWInfantry = (int)GameObject.Find("prussia_w").GetComponent<Control>().infantry,
            PRWArtillery = (int)GameObject.Find("prussia_w").GetComponent<Control>().artillery,
            WWNcontroller = (int)GameObject.Find("warsaw_n").GetComponent<Control>().controller,
            WWNCavalry = (int)GameObject.Find("warsaw_n").GetComponent<Control>().cavalry,
            WWNInfantry = (int)GameObject.Find("warsaw_n").GetComponent<Control>().infantry,
            WWNArtillery = (int)GameObject.Find("warsaw_n").GetComponent<Control>().artillery,
            WWScontroller = (int)GameObject.Find("warsaw_s").GetComponent<Control>().controller,
            WWSCavalry = (int)GameObject.Find("warsaw_s").GetComponent<Control>().cavalry,
            WWSInfantry = (int)GameObject.Find("warsaw_s").GetComponent<Control>().infantry,
            WWSArtillery = (int)GameObject.Find("warsaw_s").GetComponent<Control>().artillery,
            WWWcontroller = (int)GameObject.Find("warsaw_w").GetComponent<Control>().controller,
            WWWCavalry = (int)GameObject.Find("warsaw_w").GetComponent<Control>().cavalry,
            WWWInfantry = (int)GameObject.Find("warsaw_w").GetComponent<Control>().infantry,
            WWWArtillery = (int)GameObject.Find("warsaw_w").GetComponent<Control>().artillery,
            RUNcontroller = (int)GameObject.Find("russia_n").GetComponent<Control>().controller,
            RUNCavalry = (int)GameObject.Find("russia_n").GetComponent<Control>().cavalry,
            RUNInfantry = (int)GameObject.Find("russia_n").GetComponent<Control>().infantry,
            RUNArtillery = (int)GameObject.Find("russia_n").GetComponent<Control>().artillery,
            RUCcontroller = (int)GameObject.Find("russia_c").GetComponent<Control>().controller,
            RUCCavalry = (int)GameObject.Find("russia_c").GetComponent<Control>().cavalry,
            RUCInfantry = (int)GameObject.Find("russia_c").GetComponent<Control>().infantry,
            RUCArtillery = (int)GameObject.Find("russia_c").GetComponent<Control>().artillery,
            RUScontroller = (int)GameObject.Find("russia_s").GetComponent<Control>().controller,
            RUSCavalry = (int)GameObject.Find("russia_s").GetComponent<Control>().cavalry,
            RUSInfantry = (int)GameObject.Find("russia_s").GetComponent<Control>().infantry,
            RUSArtillery = (int)GameObject.Find("russia_s").GetComponent<Control>().artillery,
            SWNcontroller = (int)GameObject.Find("sweden_n").GetComponent<Control>().controller,
            SWNCavalry = (int)GameObject.Find("sweden_n").GetComponent<Control>().cavalry,
            SWNInfantry = (int)GameObject.Find("sweden_n").GetComponent<Control>().infantry,
            SWNArtillery = (int)GameObject.Find("sweden_n").GetComponent<Control>().artillery,
            SWCcontroller = (int)GameObject.Find("sweden_c").GetComponent<Control>().controller,
            SWCCavalry = (int)GameObject.Find("sweden_c").GetComponent<Control>().cavalry,
            SWCInfantry = (int)GameObject.Find("sweden_c").GetComponent<Control>().infantry,
            SWCArtillery = (int)GameObject.Find("sweden_c").GetComponent<Control>().artillery,
            SWScontroller = (int)GameObject.Find("sweden_s").GetComponent<Control>().controller,
            SWSCavalry = (int)GameObject.Find("sweden_s").GetComponent<Control>().cavalry,
            SWSInfantry = (int)GameObject.Find("sweden_s").GetComponent<Control>().infantry,
            SWSArtillery = (int)GameObject.Find("sweden_s").GetComponent<Control>().artillery,
            DKNcontroller = (int)GameObject.Find("denmark_n").GetComponent<Control>().controller,
            DKNCavalry = (int)GameObject.Find("denmark_n").GetComponent<Control>().cavalry,
            DKNInfantry = (int)GameObject.Find("denmark_n").GetComponent<Control>().infantry,
            DKNArtillery = (int)GameObject.Find("denmark_n").GetComponent<Control>().artillery,
            DKScontroller = (int)GameObject.Find("denmark_s").GetComponent<Control>().controller,
            DKSCavalry = (int)GameObject.Find("denmark_s").GetComponent<Control>().cavalry,
            DKSInfantry = (int)GameObject.Find("denmark_s").GetComponent<Control>().infantry,
            DKSArtillery = (int)GameObject.Find("denmark_s").GetComponent<Control>().artillery,
            NYEcontroller = (int)GameObject.Find("norway_e").GetComponent<Control>().controller,
            NYECavalry = (int)GameObject.Find("norway_e").GetComponent<Control>().cavalry,
            NYEInfantry = (int)GameObject.Find("norway_e").GetComponent<Control>().infantry,
            NYEArtillery = (int)GameObject.Find("norway_e").GetComponent<Control>().artillery,
            NYWcontroller = (int)GameObject.Find("norway_w").GetComponent<Control>().controller,
            NYWCavalry = (int)GameObject.Find("norway_w").GetComponent<Control>().cavalry,
            NYWInfantry = (int)GameObject.Find("norway_w").GetComponent<Control>().infantry,
            NYWArtillery = (int)GameObject.Find("norway_w").GetComponent<Control>().artillery,
        };
    }
}