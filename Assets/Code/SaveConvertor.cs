using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveConvertor
{
    private static readonly string path = Path.Combine(Application.persistentDataPath, "AI.saver");

    public static void AISaver(countries countries)
    {
        Debug.Log("Save");

        FileStream stream = new FileStream(path, FileMode.Create);
        BinaryWriter writer = new BinaryWriter(stream);

        SaveSystem AIsaveto = SaveSystem.fromAI(countries);
        writer.Write(AIsaveto.playerCountry);
        writer.Write(AIsaveto.turnNumber);

        writer.Write(AIsaveto.FranceAIGold);
        writer.Write(AIsaveto.SpainAIGold);
        writer.Write(AIsaveto.PortugalAIGold);
        writer.Write(AIsaveto.UKAIGold);
        writer.Write(AIsaveto.CRAIGold);
        writer.Write(AIsaveto.MoroccoAIGold);
        writer.Write(AIsaveto.AlgeriaAIGold);
        writer.Write(AIsaveto.TunisAIGold);
        writer.Write(AIsaveto.SardiniaAIGold);
        writer.Write(AIsaveto.SicilyAIGold);
        writer.Write(AIsaveto.NaplesAIGold);
        writer.Write(AIsaveto.LuccaAIGold);
        writer.Write(AIsaveto.ItalyAIGold);
        writer.Write(AIsaveto.HelvetiaAIGold);
        writer.Write(AIsaveto.AustriaAIGold);
        writer.Write(AIsaveto.OttomanAIGold);
        writer.Write(AIsaveto.MontenegroAIGold);
        writer.Write(AIsaveto.PrussiaAIGold);
        writer.Write(AIsaveto.WarsawAIGold);
        writer.Write(AIsaveto.RussiaAIGold);
        writer.Write(AIsaveto.SwedenAIGold);
        writer.Write(AIsaveto.NorwayAIGold);
        writer.Write(AIsaveto.FranceAIPopulation);
        writer.Write(AIsaveto.SpainAIPopulation);
        writer.Write(AIsaveto.PortugalAIPopulation);
        writer.Write(AIsaveto.UKAIPopulation);
        writer.Write(AIsaveto.CRAIPopulation);
        writer.Write(AIsaveto.MoroccoAIPopulation);
        writer.Write(AIsaveto.AlgeriaAIPopulation);
        writer.Write(AIsaveto.TunisAIPopulation);
        writer.Write(AIsaveto.SardiniaAIPopulation);
        writer.Write(AIsaveto.SicilyAIPopulation);
        writer.Write(AIsaveto.NaplesAIPopulation);
        writer.Write(AIsaveto.LuccaAIPopulation);
        writer.Write(AIsaveto.ItalyAIPopulation);
        writer.Write(AIsaveto.HelvetiaAIPopulation);
        writer.Write(AIsaveto.AustriaAIPopulation);
        writer.Write(AIsaveto.OttomanAIPopulation);
        writer.Write(AIsaveto.MontenegroAIPopulation);
        writer.Write(AIsaveto.PrussiaAIPopulation);
        writer.Write(AIsaveto.WarsawAIPopulation);
        writer.Write(AIsaveto.RussiaAIPopulation);
        writer.Write(AIsaveto.SwedenAIPopulation);
        writer.Write(AIsaveto.NorwayAIPopulation);
        writer.Write(AIsaveto.FranceAIMaterial);
        writer.Write(AIsaveto.SpainAIMaterial);
        writer.Write(AIsaveto.PortugalAIMaterial);
        writer.Write(AIsaveto.UKAIMaterial);
        writer.Write(AIsaveto.CRAIMaterial);
        writer.Write(AIsaveto.MoroccoAIMaterial);
        writer.Write(AIsaveto.AlgeriaAIMaterial);
        writer.Write(AIsaveto.TunisAIMaterial);
        writer.Write(AIsaveto.SardiniaAIMaterial);
        writer.Write(AIsaveto.SicilyAIMaterial);
        writer.Write(AIsaveto.NaplesAIMaterial);
        writer.Write(AIsaveto.LuccaAIMaterial);
        writer.Write(AIsaveto.ItalyAIMaterial);
        writer.Write(AIsaveto.HelvetiaAIMaterial);
        writer.Write(AIsaveto.AustriaAIMaterial);
        writer.Write(AIsaveto.OttomanAIMaterial);
        writer.Write(AIsaveto.MontenegroAIMaterial);
        writer.Write(AIsaveto.PrussiaAIMaterial);
        writer.Write(AIsaveto.WarsawAIMaterial);
        writer.Write(AIsaveto.RussiaAIMaterial);
        writer.Write(AIsaveto.SwedenAIMaterial);
        writer.Write(AIsaveto.NorwayAIMaterial);

        writer.Write(AIsaveto.FNWcontroller);
        writer.Write(AIsaveto.FNWCavalry);
        writer.Write(AIsaveto.FNWInfantry);
        writer.Write(AIsaveto.FNWArtillery);
        writer.Write(AIsaveto.FSEcontroller);
        writer.Write(AIsaveto.FSECavalry);
        writer.Write(AIsaveto.FSEInfantry);
        writer.Write(AIsaveto.FSEArtillery);
        writer.Write(AIsaveto.FNEcontroller);
        writer.Write(AIsaveto.FNECavalry);
        writer.Write(AIsaveto.FNEInfantry);
        writer.Write(AIsaveto.FNEArtillery);
        writer.Write(AIsaveto.FSWcontroller);
        writer.Write(AIsaveto.FSWCavalry);
        writer.Write(AIsaveto.FSWInfantry);
        writer.Write(AIsaveto.FSWArtillery);
        writer.Write(AIsaveto.CORcontroller);
        writer.Write(AIsaveto.CORCavalry);
        writer.Write(AIsaveto.CORInfantry);
        writer.Write(AIsaveto.CORArtillery);
        writer.Write(AIsaveto.ROMEcontroller);
        writer.Write(AIsaveto.ROMECavalry);
        writer.Write(AIsaveto.ROMEInfantry);
        writer.Write(AIsaveto.ROMEArtillery);
        writer.Write(AIsaveto.C_Wcontroller);
        writer.Write(AIsaveto.C_WCavalry);
        writer.Write(AIsaveto.C_WInfantry);
        writer.Write(AIsaveto.C_WArtillery);
        writer.Write(AIsaveto.C_Econtroller);
        writer.Write(AIsaveto.C_ECavalry);
        writer.Write(AIsaveto.C_EInfantry);
        writer.Write(AIsaveto.C_EArtillery);
        writer.Write(AIsaveto.SNcontroller);
        writer.Write(AIsaveto.SNCavalry);
        writer.Write(AIsaveto.SNInfantry);
        writer.Write(AIsaveto.SNArtillery);
        writer.Write(AIsaveto.SScontroller);
        writer.Write(AIsaveto.SSCavalry);
        writer.Write(AIsaveto.SSInfantry);
        writer.Write(AIsaveto.SSArtillery);
        writer.Write(AIsaveto.PNcontroller);
        writer.Write(AIsaveto.PNCavalry);
        writer.Write(AIsaveto.PNInfantry);
        writer.Write(AIsaveto.PNArtillery);
        writer.Write(AIsaveto.PScontroller);
        writer.Write(AIsaveto.PSCavalry);
        writer.Write(AIsaveto.PSInfantry);
        writer.Write(AIsaveto.PSArtillery);
        writer.Write(AIsaveto.INcontroller);
        writer.Write(AIsaveto.INCavalry);
        writer.Write(AIsaveto.INInfantry);
        writer.Write(AIsaveto.INArtillery);
        writer.Write(AIsaveto.IScontroller);
        writer.Write(AIsaveto.ISCavalry);
        writer.Write(AIsaveto.ISInfantry);
        writer.Write(AIsaveto.ISArtillery);
        writer.Write(AIsaveto.EEcontroller);
        writer.Write(AIsaveto.EECavalry);
        writer.Write(AIsaveto.EEInfantry);
        writer.Write(AIsaveto.EEArtillery);
        writer.Write(AIsaveto.EWcontroller);
        writer.Write(AIsaveto.EWCavalry);
        writer.Write(AIsaveto.EWInfantry);
        writer.Write(AIsaveto.EWArtillery);
        writer.Write(AIsaveto.Scontroller);
        writer.Write(AIsaveto.SCavalry);
        writer.Write(AIsaveto.SInfantry);
        writer.Write(AIsaveto.SArtillery);
        writer.Write(AIsaveto.CNcontroller);
        writer.Write(AIsaveto.CNCavalry);
        writer.Write(AIsaveto.CNInfantry);
        writer.Write(AIsaveto.CNArtillery);
        writer.Write(AIsaveto.CScontroller);
        writer.Write(AIsaveto.CSCavalry);
        writer.Write(AIsaveto.CSInfantry);
        writer.Write(AIsaveto.CSArtillery);
        writer.Write(AIsaveto.MEcontroller);
        writer.Write(AIsaveto.MECavalry);
        writer.Write(AIsaveto.MEInfantry);
        writer.Write(AIsaveto.MEArtillery);
        writer.Write(AIsaveto.MWcontroller);
        writer.Write(AIsaveto.MWCavalry);
        writer.Write(AIsaveto.MWInfantry);
        writer.Write(AIsaveto.MWArtillery);
        writer.Write(AIsaveto.AEcontroller);
        writer.Write(AIsaveto.AECavalry);
        writer.Write(AIsaveto.AEInfantry);
        writer.Write(AIsaveto.AEArtillery);
        writer.Write(AIsaveto.ACcontroller);
        writer.Write(AIsaveto.ACCavalry);
        writer.Write(AIsaveto.ACInfantry);
        writer.Write(AIsaveto.ACArtillery);
        writer.Write(AIsaveto.AWcontroller);
        writer.Write(AIsaveto.AWCavalry);
        writer.Write(AIsaveto.AWInfantry);
        writer.Write(AIsaveto.AWArtillery);
        writer.Write(AIsaveto.TNcontroller);
        writer.Write(AIsaveto.TNCavalry);
        writer.Write(AIsaveto.TNInfantry);
        writer.Write(AIsaveto.TNArtillery);
        writer.Write(AIsaveto.TScontroller);
        writer.Write(AIsaveto.TSCavalry);
        writer.Write(AIsaveto.TSInfantry);
        writer.Write(AIsaveto.TSArtillery);
        writer.Write(AIsaveto.SACcontroller);
        writer.Write(AIsaveto.SACCavalry);
        writer.Write(AIsaveto.SACInfantry);
        writer.Write(AIsaveto.SACArtillery);
        writer.Write(AIsaveto.SICcontroller);
        writer.Write(AIsaveto.SICCavalry);
        writer.Write(AIsaveto.SICInfantry);
        writer.Write(AIsaveto.SICArtillery);
        writer.Write(AIsaveto.NEcontroller);
        writer.Write(AIsaveto.NECavalry);
        writer.Write(AIsaveto.NEInfantry);
        writer.Write(AIsaveto.NEArtillery);
        writer.Write(AIsaveto.NWcontroller);
        writer.Write(AIsaveto.NWCavalry);
        writer.Write(AIsaveto.NWInfantry);
        writer.Write(AIsaveto.NWArtillery);
        writer.Write(AIsaveto.NNcontroller);
        writer.Write(AIsaveto.NNCavalry);
        writer.Write(AIsaveto.NNInfantry);
        writer.Write(AIsaveto.NNArtillery);
        writer.Write(AIsaveto.Lcontroller);
        writer.Write(AIsaveto.LCavalry);
        writer.Write(AIsaveto.LInfantry);
        writer.Write(AIsaveto.LArtillery);
        writer.Write(AIsaveto.ITNcontroller);
        writer.Write(AIsaveto.ITNCavalry);
        writer.Write(AIsaveto.ITNInfantry);
        writer.Write(AIsaveto.ITNArtillery);
        writer.Write(AIsaveto.ITScontroller);
        writer.Write(AIsaveto.ITSCavalry);
        writer.Write(AIsaveto.ITSInfantry);
        writer.Write(AIsaveto.ITSArtillery);
        writer.Write(AIsaveto.HCcontroller);
        writer.Write(AIsaveto.HCCavalry);
        writer.Write(AIsaveto.HCInfantry);
        writer.Write(AIsaveto.HCArtillery);
        writer.Write(AIsaveto.ANEcontroller);
        writer.Write(AIsaveto.ANECavalry);
        writer.Write(AIsaveto.ANEInfantry);
        writer.Write(AIsaveto.ANEArtillery);
        writer.Write(AIsaveto.ANWcontroller);
        writer.Write(AIsaveto.ANWCavalry);
        writer.Write(AIsaveto.ANWInfantry);
        writer.Write(AIsaveto.ANWArtillery);
        writer.Write(AIsaveto.ASEcontroller);
        writer.Write(AIsaveto.ASECavalry);
        writer.Write(AIsaveto.ASEInfantry);
        writer.Write(AIsaveto.ASEArtillery);
        writer.Write(AIsaveto.ASWcontroller);
        writer.Write(AIsaveto.ASWCavalry);
        writer.Write(AIsaveto.ASWInfantry);
        writer.Write(AIsaveto.ASWArtillery);
        writer.Write(AIsaveto.GNcontroller);
        writer.Write(AIsaveto.GNCavalry);
        writer.Write(AIsaveto.GNInfantry);
        writer.Write(AIsaveto.GNArtillery);
        writer.Write(AIsaveto.GScontroller);
        writer.Write(AIsaveto.GSCavalry);
        writer.Write(AIsaveto.GSInfantry);
        writer.Write(AIsaveto.GSArtillery);
        writer.Write(AIsaveto.OEcontroller);
        writer.Write(AIsaveto.OECavalry);
        writer.Write(AIsaveto.OEInfantry);
        writer.Write(AIsaveto.OEArtillery);
        writer.Write(AIsaveto.OScontroller);
        writer.Write(AIsaveto.OSCavalry);
        writer.Write(AIsaveto.OSInfantry);
        writer.Write(AIsaveto.OSArtillery);
        writer.Write(AIsaveto.OWcontroller);
        writer.Write(AIsaveto.OWCavalry);
        writer.Write(AIsaveto.OWInfantry);
        writer.Write(AIsaveto.OWArtillery);
        writer.Write(AIsaveto.MOcontroller);
        writer.Write(AIsaveto.MOCavalry);
        writer.Write(AIsaveto.MOInfantry);
        writer.Write(AIsaveto.MOArtillery);
        writer.Write(AIsaveto.PRCcontroller);
        writer.Write(AIsaveto.PRCCavalry);
        writer.Write(AIsaveto.PRCInfantry);
        writer.Write(AIsaveto.PRCArtillery);
        writer.Write(AIsaveto.PREcontroller);
        writer.Write(AIsaveto.PRECavalry);
        writer.Write(AIsaveto.PREInfantry);
        writer.Write(AIsaveto.PREArtillery);
        writer.Write(AIsaveto.PRWcontroller);
        writer.Write(AIsaveto.PRWCavalry);
        writer.Write(AIsaveto.PRWInfantry);
        writer.Write(AIsaveto.PRWArtillery);
        writer.Write(AIsaveto.WWNcontroller);
        writer.Write(AIsaveto.WWNCavalry);
        writer.Write(AIsaveto.WWNInfantry);
        writer.Write(AIsaveto.WWNArtillery);
        writer.Write(AIsaveto.WWScontroller);
        writer.Write(AIsaveto.WWSCavalry);
        writer.Write(AIsaveto.WWSInfantry);
        writer.Write(AIsaveto.WWSArtillery);
        writer.Write(AIsaveto.WWWcontroller);
        writer.Write(AIsaveto.WWWCavalry);
        writer.Write(AIsaveto.WWWInfantry);
        writer.Write(AIsaveto.WWWArtillery);
        writer.Write(AIsaveto.RUNcontroller);
        writer.Write(AIsaveto.RUNCavalry);
        writer.Write(AIsaveto.RUNInfantry);
        writer.Write(AIsaveto.RUNArtillery);
        writer.Write(AIsaveto.RUCcontroller);
        writer.Write(AIsaveto.RUCCavalry);
        writer.Write(AIsaveto.RUCInfantry);
        writer.Write(AIsaveto.RUCArtillery);
        writer.Write(AIsaveto.RUScontroller);
        writer.Write(AIsaveto.RUSCavalry);
        writer.Write(AIsaveto.RUSInfantry);
        writer.Write(AIsaveto.RUSArtillery);
        writer.Write(AIsaveto.SWNcontroller);
        writer.Write(AIsaveto.SWNCavalry);
        writer.Write(AIsaveto.SWNInfantry);
        writer.Write(AIsaveto.SWNArtillery);
        writer.Write(AIsaveto.SWCcontroller);
        writer.Write(AIsaveto.SWCCavalry);
        writer.Write(AIsaveto.SWCInfantry);
        writer.Write(AIsaveto.SWCArtillery);
        writer.Write(AIsaveto.SWScontroller);
        writer.Write(AIsaveto.SWSCavalry);
        writer.Write(AIsaveto.SWSInfantry);
        writer.Write(AIsaveto.SWSArtillery);
        writer.Write(AIsaveto.DKNcontroller);
        writer.Write(AIsaveto.DKNCavalry);
        writer.Write(AIsaveto.DKNInfantry);
        writer.Write(AIsaveto.DKNArtillery);
        writer.Write(AIsaveto.DKScontroller);
        writer.Write(AIsaveto.DKSCavalry);
        writer.Write(AIsaveto.DKSInfantry);
        writer.Write(AIsaveto.DKSArtillery);
        writer.Write(AIsaveto.NYEcontroller);
        writer.Write(AIsaveto.NYECavalry);
        writer.Write(AIsaveto.NYEInfantry);
        writer.Write(AIsaveto.NYEArtillery);
        writer.Write(AIsaveto.NYWcontroller);
        writer.Write(AIsaveto.NYWCavalry);
        writer.Write(AIsaveto.NYWInfantry);
        writer.Write(AIsaveto.NYWArtillery);

        stream.Close();
    }

    public static SaveSystem LoadAI()
    {
        if (!File.Exists(path))
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }

        Debug.Log("exists");
        FileStream stream = new FileStream(path, FileMode.Open);
        BinaryReader reader = new BinaryReader(stream);

        SaveSystem AIsaveto = new SaveSystem();
        AIsaveto.playerCountry = reader.ReadInt32();
        AIsaveto.turnNumber = reader.ReadInt32();

        AIsaveto.FranceAIGold = reader.ReadInt32();
        AIsaveto.SpainAIGold = reader.ReadInt32();
        AIsaveto.PortugalAIGold = reader.ReadInt32();
        AIsaveto.UKAIGold = reader.ReadInt32();
        AIsaveto.CRAIGold = reader.ReadInt32();
        AIsaveto.MoroccoAIGold = reader.ReadInt32();
        AIsaveto.AlgeriaAIGold = reader.ReadInt32();
        AIsaveto.TunisAIGold = reader.ReadInt32();
        AIsaveto.SardiniaAIGold = reader.ReadInt32();
        AIsaveto.SicilyAIGold = reader.ReadInt32();
        AIsaveto.NaplesAIGold = reader.ReadInt32();
        AIsaveto.LuccaAIGold = reader.ReadInt32();
        AIsaveto.ItalyAIGold = reader.ReadInt32();
        AIsaveto.HelvetiaAIGold = reader.ReadInt32();
        AIsaveto.AustriaAIGold = reader.ReadInt32();
        AIsaveto.OttomanAIGold = reader.ReadInt32();
        AIsaveto.MontenegroAIGold = reader.ReadInt32();
        AIsaveto.PrussiaAIGold = reader.ReadInt32();
        AIsaveto.WarsawAIGold = reader.ReadInt32();
        AIsaveto.RussiaAIGold = reader.ReadInt32();
        AIsaveto.SwedenAIGold = reader.ReadInt32();
        AIsaveto.NorwayAIGold = reader.ReadInt32();
        AIsaveto.FranceAIPopulation = reader.ReadInt32();
        AIsaveto.SpainAIPopulation = reader.ReadInt32();
        AIsaveto.PortugalAIPopulation = reader.ReadInt32();
        AIsaveto.UKAIPopulation = reader.ReadInt32();
        AIsaveto.CRAIPopulation = reader.ReadInt32();
        AIsaveto.MoroccoAIPopulation = reader.ReadInt32();
        AIsaveto.AlgeriaAIPopulation = reader.ReadInt32();
        AIsaveto.TunisAIPopulation = reader.ReadInt32();
        AIsaveto.SardiniaAIPopulation = reader.ReadInt32();
        AIsaveto.SicilyAIPopulation = reader.ReadInt32();
        AIsaveto.NaplesAIPopulation = reader.ReadInt32();
        AIsaveto.LuccaAIPopulation = reader.ReadInt32();
        AIsaveto.ItalyAIPopulation = reader.ReadInt32();
        AIsaveto.HelvetiaAIPopulation = reader.ReadInt32();
        AIsaveto.AustriaAIPopulation = reader.ReadInt32();
        AIsaveto.OttomanAIPopulation = reader.ReadInt32();
        AIsaveto.MontenegroAIPopulation = reader.ReadInt32();
        AIsaveto.PrussiaAIPopulation = reader.ReadInt32();
        AIsaveto.WarsawAIPopulation = reader.ReadInt32();
        AIsaveto.RussiaAIPopulation = reader.ReadInt32();
        AIsaveto.SwedenAIPopulation = reader.ReadInt32();
        AIsaveto.NorwayAIPopulation = reader.ReadInt32();
        AIsaveto.FranceAIMaterial = reader.ReadInt32();
        AIsaveto.SpainAIMaterial = reader.ReadInt32();
        AIsaveto.PortugalAIMaterial = reader.ReadInt32();
        AIsaveto.UKAIMaterial = reader.ReadInt32();
        AIsaveto.CRAIMaterial = reader.ReadInt32();
        AIsaveto.MoroccoAIMaterial = reader.ReadInt32();
        AIsaveto.AlgeriaAIMaterial = reader.ReadInt32();
        AIsaveto.TunisAIMaterial = reader.ReadInt32();
        AIsaveto.SardiniaAIMaterial = reader.ReadInt32();
        AIsaveto.SicilyAIMaterial = reader.ReadInt32();
        AIsaveto.NaplesAIMaterial = reader.ReadInt32();
        AIsaveto.LuccaAIMaterial = reader.ReadInt32();
        AIsaveto.ItalyAIMaterial = reader.ReadInt32();
        AIsaveto.HelvetiaAIMaterial = reader.ReadInt32();
        AIsaveto.AustriaAIMaterial = reader.ReadInt32();
        AIsaveto.OttomanAIMaterial = reader.ReadInt32();
        AIsaveto.MontenegroAIMaterial = reader.ReadInt32();
        AIsaveto.PrussiaAIMaterial = reader.ReadInt32();
        AIsaveto.WarsawAIMaterial = reader.ReadInt32();
        AIsaveto.RussiaAIMaterial = reader.ReadInt32();
        AIsaveto.SwedenAIMaterial = reader.ReadInt32();
        AIsaveto.NorwayAIMaterial = reader.ReadInt32();

        AIsaveto.FNWcontroller = reader.ReadInt32();
        AIsaveto.FNWCavalry = reader.ReadInt32();
        AIsaveto.FNWInfantry = reader.ReadInt32();
        AIsaveto.FNWArtillery = reader.ReadInt32();
        AIsaveto.FSEcontroller = reader.ReadInt32();
        AIsaveto.FSECavalry = reader.ReadInt32();
        AIsaveto.FSEInfantry = reader.ReadInt32();
        AIsaveto.FSEArtillery = reader.ReadInt32();
        AIsaveto.FNEcontroller = reader.ReadInt32();
        AIsaveto.FNECavalry = reader.ReadInt32();
        AIsaveto.FNEInfantry = reader.ReadInt32();
        AIsaveto.FNEArtillery = reader.ReadInt32();
        AIsaveto.FSWcontroller = reader.ReadInt32();
        AIsaveto.FSWCavalry = reader.ReadInt32();
        AIsaveto.FSWInfantry = reader.ReadInt32();
        AIsaveto.FSWArtillery = reader.ReadInt32();
        AIsaveto.CORcontroller = reader.ReadInt32();
        AIsaveto.CORCavalry = reader.ReadInt32();
        AIsaveto.CORInfantry = reader.ReadInt32();
        AIsaveto.CORArtillery = reader.ReadInt32();
        AIsaveto.ROMEcontroller = reader.ReadInt32();
        AIsaveto.ROMECavalry = reader.ReadInt32();
        AIsaveto.ROMEInfantry = reader.ReadInt32();
        AIsaveto.ROMEArtillery = reader.ReadInt32();
        AIsaveto.C_Wcontroller = reader.ReadInt32();
        AIsaveto.C_WCavalry = reader.ReadInt32();
        AIsaveto.C_WInfantry = reader.ReadInt32();
        AIsaveto.C_WArtillery = reader.ReadInt32();
        AIsaveto.C_Econtroller = reader.ReadInt32();
        AIsaveto.C_ECavalry = reader.ReadInt32();
        AIsaveto.C_EInfantry = reader.ReadInt32();
        AIsaveto.C_EArtillery = reader.ReadInt32();
        AIsaveto.SNcontroller = reader.ReadInt32();
        AIsaveto.SNCavalry = reader.ReadInt32();
        AIsaveto.SNInfantry = reader.ReadInt32();
        AIsaveto.SNArtillery = reader.ReadInt32();
        AIsaveto.SScontroller = reader.ReadInt32();
        AIsaveto.SSCavalry = reader.ReadInt32();
        AIsaveto.SSInfantry = reader.ReadInt32();
        AIsaveto.SSArtillery = reader.ReadInt32();
        AIsaveto.PNcontroller = reader.ReadInt32();
        AIsaveto.PNCavalry = reader.ReadInt32();
        AIsaveto.PNInfantry = reader.ReadInt32();
        AIsaveto.PNArtillery = reader.ReadInt32();
        AIsaveto.PScontroller = reader.ReadInt32();
        AIsaveto.PSCavalry = reader.ReadInt32();
        AIsaveto.PSInfantry = reader.ReadInt32();
        AIsaveto.PSArtillery = reader.ReadInt32();
        AIsaveto.INcontroller = reader.ReadInt32();
        AIsaveto.INCavalry = reader.ReadInt32();
        AIsaveto.INInfantry = reader.ReadInt32();
        AIsaveto.INArtillery = reader.ReadInt32();
        AIsaveto.IScontroller = reader.ReadInt32();
        AIsaveto.ISCavalry = reader.ReadInt32();
        AIsaveto.ISInfantry = reader.ReadInt32();
        AIsaveto.ISArtillery = reader.ReadInt32();
        AIsaveto.EEcontroller = reader.ReadInt32();
        AIsaveto.EECavalry = reader.ReadInt32();
        AIsaveto.EEInfantry = reader.ReadInt32();
        AIsaveto.EEArtillery = reader.ReadInt32();
        AIsaveto.EWcontroller = reader.ReadInt32();
        AIsaveto.EWCavalry = reader.ReadInt32();
        AIsaveto.EWInfantry = reader.ReadInt32();
        AIsaveto.EWArtillery = reader.ReadInt32();
        AIsaveto.Scontroller = reader.ReadInt32();
        AIsaveto.SCavalry = reader.ReadInt32();
        AIsaveto.SInfantry = reader.ReadInt32();
        AIsaveto.SArtillery = reader.ReadInt32();
        AIsaveto.CNcontroller = reader.ReadInt32();
        AIsaveto.CNCavalry = reader.ReadInt32();
        AIsaveto.CNInfantry = reader.ReadInt32();
        AIsaveto.CNArtillery = reader.ReadInt32();
        AIsaveto.CScontroller = reader.ReadInt32();
        AIsaveto.CSCavalry = reader.ReadInt32();
        AIsaveto.CSInfantry = reader.ReadInt32();
        AIsaveto.CSArtillery = reader.ReadInt32();
        AIsaveto.MEcontroller = reader.ReadInt32();
        AIsaveto.MECavalry = reader.ReadInt32();
        AIsaveto.MEInfantry = reader.ReadInt32();
        AIsaveto.MEArtillery = reader.ReadInt32();
        AIsaveto.MWcontroller = reader.ReadInt32();
        AIsaveto.MWCavalry = reader.ReadInt32();
        AIsaveto.MWInfantry = reader.ReadInt32();
        AIsaveto.MWArtillery = reader.ReadInt32();
        AIsaveto.AEcontroller = reader.ReadInt32();
        AIsaveto.AECavalry = reader.ReadInt32();
        AIsaveto.AEInfantry = reader.ReadInt32();
        AIsaveto.AEArtillery = reader.ReadInt32();
        AIsaveto.ACcontroller = reader.ReadInt32();
        AIsaveto.ACCavalry = reader.ReadInt32();
        AIsaveto.ACInfantry = reader.ReadInt32();
        AIsaveto.ACArtillery = reader.ReadInt32();
        AIsaveto.AWcontroller = reader.ReadInt32();
        AIsaveto.AWCavalry = reader.ReadInt32();
        AIsaveto.AWInfantry = reader.ReadInt32();
        AIsaveto.AWArtillery = reader.ReadInt32();
        AIsaveto.TNcontroller = reader.ReadInt32();
        AIsaveto.TNCavalry = reader.ReadInt32();
        AIsaveto.TNInfantry = reader.ReadInt32();
        AIsaveto.TNArtillery = reader.ReadInt32();
        AIsaveto.TScontroller = reader.ReadInt32();
        AIsaveto.TSCavalry = reader.ReadInt32();
        AIsaveto.TSInfantry = reader.ReadInt32();
        AIsaveto.TSArtillery = reader.ReadInt32();
        AIsaveto.SACcontroller = reader.ReadInt32();
        AIsaveto.SACCavalry = reader.ReadInt32();
        AIsaveto.SACInfantry = reader.ReadInt32();
        AIsaveto.SACArtillery = reader.ReadInt32();
        AIsaveto.SICcontroller = reader.ReadInt32();
        AIsaveto.SICCavalry = reader.ReadInt32();
        AIsaveto.SICInfantry = reader.ReadInt32();
        AIsaveto.SICArtillery = reader.ReadInt32();
        AIsaveto.NEcontroller = reader.ReadInt32();
        AIsaveto.NECavalry = reader.ReadInt32();
        AIsaveto.NEInfantry = reader.ReadInt32();
        AIsaveto.NEArtillery = reader.ReadInt32();
        AIsaveto.NWcontroller = reader.ReadInt32();
        AIsaveto.NWCavalry = reader.ReadInt32();
        AIsaveto.NWInfantry = reader.ReadInt32();
        AIsaveto.NWArtillery = reader.ReadInt32();
        AIsaveto.NNcontroller = reader.ReadInt32();
        AIsaveto.NNCavalry = reader.ReadInt32();
        AIsaveto.NNInfantry = reader.ReadInt32();
        AIsaveto.NNArtillery = reader.ReadInt32();
        AIsaveto.Lcontroller = reader.ReadInt32();
        AIsaveto.LCavalry = reader.ReadInt32();
        AIsaveto.LInfantry = reader.ReadInt32();
        AIsaveto.LArtillery = reader.ReadInt32();
        AIsaveto.ITNcontroller = reader.ReadInt32();
        AIsaveto.ITNCavalry = reader.ReadInt32();
        AIsaveto.ITNInfantry = reader.ReadInt32();
        AIsaveto.ITNArtillery = reader.ReadInt32();
        AIsaveto.ITScontroller = reader.ReadInt32();
        AIsaveto.ITSCavalry = reader.ReadInt32();
        AIsaveto.ITSInfantry = reader.ReadInt32();
        AIsaveto.ITSArtillery = reader.ReadInt32();
        AIsaveto.HCcontroller = reader.ReadInt32();
        AIsaveto.HCCavalry = reader.ReadInt32();
        AIsaveto.HCInfantry = reader.ReadInt32();
        AIsaveto.HCArtillery = reader.ReadInt32();
        AIsaveto.ANEcontroller = reader.ReadInt32();
        AIsaveto.ANECavalry = reader.ReadInt32();
        AIsaveto.ANEInfantry = reader.ReadInt32();
        AIsaveto.ANEArtillery = reader.ReadInt32();
        AIsaveto.ANWcontroller = reader.ReadInt32();
        AIsaveto.ANWCavalry = reader.ReadInt32();
        AIsaveto.ANWInfantry = reader.ReadInt32();
        AIsaveto.ANWArtillery = reader.ReadInt32();
        AIsaveto.ASEcontroller = reader.ReadInt32();
        AIsaveto.ASECavalry = reader.ReadInt32();
        AIsaveto.ASEInfantry = reader.ReadInt32();
        AIsaveto.ASEArtillery = reader.ReadInt32();
        AIsaveto.ASWcontroller = reader.ReadInt32();
        AIsaveto.ASWCavalry = reader.ReadInt32();
        AIsaveto.ASWInfantry = reader.ReadInt32();
        AIsaveto.ASWArtillery = reader.ReadInt32();
        AIsaveto.GNcontroller = reader.ReadInt32();
        AIsaveto.GNCavalry = reader.ReadInt32();
        AIsaveto.GNInfantry = reader.ReadInt32();
        AIsaveto.GNArtillery = reader.ReadInt32();
        AIsaveto.GScontroller = reader.ReadInt32();
        AIsaveto.GSCavalry = reader.ReadInt32();
        AIsaveto.GSInfantry = reader.ReadInt32();
        AIsaveto.GSArtillery = reader.ReadInt32();
        AIsaveto.OEcontroller = reader.ReadInt32();
        AIsaveto.OECavalry = reader.ReadInt32();
        AIsaveto.OEInfantry = reader.ReadInt32();
        AIsaveto.OEArtillery = reader.ReadInt32();
        AIsaveto.OScontroller = reader.ReadInt32();
        AIsaveto.OSCavalry = reader.ReadInt32();
        AIsaveto.OSInfantry = reader.ReadInt32();
        AIsaveto.OSArtillery = reader.ReadInt32();
        AIsaveto.OWcontroller = reader.ReadInt32();
        AIsaveto.OWCavalry = reader.ReadInt32();
        AIsaveto.OWInfantry = reader.ReadInt32();
        AIsaveto.OWArtillery = reader.ReadInt32();
        AIsaveto.MOcontroller = reader.ReadInt32();
        AIsaveto.MOCavalry = reader.ReadInt32();
        AIsaveto.MOInfantry = reader.ReadInt32();
        AIsaveto.MOArtillery = reader.ReadInt32();
        AIsaveto.PRCcontroller = reader.ReadInt32();
        AIsaveto.PRCCavalry = reader.ReadInt32();
        AIsaveto.PRCInfantry = reader.ReadInt32();
        AIsaveto.PRCArtillery = reader.ReadInt32();
        AIsaveto.PREcontroller = reader.ReadInt32();
        AIsaveto.PRECavalry = reader.ReadInt32();
        AIsaveto.PREInfantry = reader.ReadInt32();
        AIsaveto.PREArtillery = reader.ReadInt32();
        AIsaveto.PRWcontroller = reader.ReadInt32();
        AIsaveto.PRWCavalry = reader.ReadInt32();
        AIsaveto.PRWInfantry = reader.ReadInt32();
        AIsaveto.PRWArtillery = reader.ReadInt32();
        AIsaveto.WWNcontroller = reader.ReadInt32();
        AIsaveto.WWNCavalry = reader.ReadInt32();
        AIsaveto.WWNInfantry = reader.ReadInt32();
        AIsaveto.WWNArtillery = reader.ReadInt32();
        AIsaveto.WWScontroller = reader.ReadInt32();
        AIsaveto.WWSCavalry = reader.ReadInt32();
        AIsaveto.WWSInfantry = reader.ReadInt32();
        AIsaveto.WWSArtillery = reader.ReadInt32();
        AIsaveto.WWWcontroller = reader.ReadInt32();
        AIsaveto.WWWCavalry = reader.ReadInt32();
        AIsaveto.WWWInfantry = reader.ReadInt32();
        AIsaveto.WWWArtillery = reader.ReadInt32();
        AIsaveto.RUNcontroller = reader.ReadInt32();
        AIsaveto.RUNCavalry = reader.ReadInt32();
        AIsaveto.RUNInfantry = reader.ReadInt32();
        AIsaveto.RUNArtillery = reader.ReadInt32();
        AIsaveto.RUCcontroller = reader.ReadInt32();
        AIsaveto.RUCCavalry = reader.ReadInt32();
        AIsaveto.RUCInfantry = reader.ReadInt32();
        AIsaveto.RUCArtillery = reader.ReadInt32();
        AIsaveto.RUScontroller = reader.ReadInt32();
        AIsaveto.RUSCavalry = reader.ReadInt32();
        AIsaveto.RUSInfantry = reader.ReadInt32();
        AIsaveto.RUSArtillery = reader.ReadInt32();
        AIsaveto.SWNcontroller = reader.ReadInt32();
        AIsaveto.SWNCavalry = reader.ReadInt32();
        AIsaveto.SWNInfantry = reader.ReadInt32();
        AIsaveto.SWNArtillery = reader.ReadInt32();
        AIsaveto.SWCcontroller = reader.ReadInt32();
        AIsaveto.SWCCavalry = reader.ReadInt32();
        AIsaveto.SWCInfantry = reader.ReadInt32();
        AIsaveto.SWCArtillery = reader.ReadInt32();
        AIsaveto.SWScontroller = reader.ReadInt32();
        AIsaveto.SWSCavalry = reader.ReadInt32();
        AIsaveto.SWSInfantry = reader.ReadInt32();
        AIsaveto.SWSArtillery = reader.ReadInt32();
        AIsaveto.DKNcontroller = reader.ReadInt32();
        AIsaveto.DKNCavalry = reader.ReadInt32();
        AIsaveto.DKNInfantry = reader.ReadInt32();
        AIsaveto.DKNArtillery = reader.ReadInt32();
        AIsaveto.DKScontroller = reader.ReadInt32();
        AIsaveto.DKSCavalry = reader.ReadInt32();
        AIsaveto.DKSInfantry = reader.ReadInt32();
        AIsaveto.DKSArtillery = reader.ReadInt32();
        AIsaveto.NYEcontroller = reader.ReadInt32();
        AIsaveto.NYECavalry = reader.ReadInt32();
        AIsaveto.NYEInfantry = reader.ReadInt32();
        AIsaveto.NYEArtillery = reader.ReadInt32();
        AIsaveto.NYWcontroller = reader.ReadInt32();
        AIsaveto.NYWCavalry = reader.ReadInt32();
        AIsaveto.NYWInfantry = reader.ReadInt32();
        AIsaveto.NYWArtillery = reader.ReadInt32();

        stream.Close();

        return AIsaveto;
    }
}