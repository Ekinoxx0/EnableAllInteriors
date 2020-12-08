// Decompiled with JetBrains decompiler
// Type: EnableAllinteriors.Class1
// Assembly: EnableAllinteriors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A85B110-A17E-4CA7-AD92-5E75D0146EEA
// Assembly location: C:\Users\Ekinoxx\Desktop\EnableAllinteriors.dll

using GTA;
using GTA.Math;
using GTA.Native;
using iFruitAddon2;
using Microsoft.CSharp.RuntimeBinder;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace EnableAllinteriors
{
  public class Class1 : Script
  {
    public EAIBLip E;
    public bool RandomColorBlips;
    public bool UseDefaultWhiteColor;
    public bool UseSpecifcBlips;
    public BlipColor BlipColor;
    public bool UseSpecificColor;
    public CustomiFruit ifruit;
    public ScriptSettings Config;
    public ScriptSettings ConfigMyNewGarage;
    public MenuPool Woredrobepool;
    public UIMenu WoredrobeMainMenu;
    public UIMenu WoredrobeMenu;
    public UIMenu Int;
    public UIMenu Gar;
    public UIMenu Hanger;
    public UIMenu Hanger1;
    public UIMenu Hanger2;
    public UIMenu OrderVehicle;
    public UIMenu GarageReset;
    public string WStyle;
    private string FacilityGraphic;
    private string FacilityOrbitalCannon;
    private string FacilitySecurityRoom;
    private string FacilityLounge;
    private string FacilitySleepingQuarters;
    private int FacilityShellColor;
    private int FacilityGraphicColor;
    private int FacilityOrbitalCannonColor;
    private int FacilitySecurityRoomColor;
    private int FacilityLoungeColor;
    private int FacilitySleepingQuartersColor;
    public string GStyle;
    public string Upgrade1;
    public string Upgrade2;
    public string Upgrade3;
    public string HangarLighting;
    public string HangarFloor;
    public string HangarFloorDecal;
    public string HangarBedroom;
    public string HangarOffice;
    public string HangarBedroomBlinds;
    public string HangarLightingWallTint;
    public string HangarNeutralLighting;
    public int HangarFloorDecalColor;
    public int HangarShellColor;
    public int HangarBedroomColor;
    public int HangarCraneColor;
    public int HangarWorkshopColor;
    public int HangarLightingTintPropsColor;
    public int MaxColors;
    private static string MazeBank = "imp_dt1_11_cargarage_a";
    private static string MazeBankWest = "imp_sm_15_cargarage_a";
    private static string Arcadius = "imp_dt1_02_cargarage_a";
    private static string Lombank = "imp_sm_13_cargarage_a";
    public string ADecor;
    public string ALighting;
    public string ANumbering;
    public string MDecor;
    public string MLighting;
    public string MNumbering;
    public string MWDecor;
    public string MWLighting;
    public string MWNumbering;
    public string LDecor;
    public string LLighting;
    public string LNumbering;
    public string LombokCEOGarage;
    public string MazeBankCEOGarage;
    public string MazeBankWestCEOGarage;
    public string ArcadiusCEOGarage;
    private bool LoadBunkerHatches;
    private bool LoadFacilityHatches;
    private static Vector3 MenuMarkerL;
    private static Vector3 MenuMarkerMB;
    private static Vector3 MenuMarkerA;
    private static Vector3 MenuMarkerMBW;
    private static string Garage;
    public string WorkGraphic;
    public string WorkOff;
    public string WorkMechanic;
    public int WColor;
    public int WColor1;
    public UIMenu InteriorOptions;
    public UIMenu MiscDLC;
    public UIMenu BikerDLC;
    public UIMenu ExecutiveDLC;
    public UIMenu SmugglersRunDLC;
    public UIMenu GunrunningDLC;
    public UIMenu DoomsdayHeistDLC;
    public UIMenu AfterHoursDLC;
    public UIMenu ArenaWarDLC;
    public UIMenu DCRDLC;
    public UIMenu DCHDLC;
    public UIMenu MiscO;
    public List<Prop> OnlineProp;
    public Prop PlaneCrash;
    private Vector3 PlayerYachtPos1;
    private Vector3 PlayerYachtPos2;
    private Vector3 PlayerYachtPos3;
    private Vector3 PlayerYachtPos4;
    private Vector3 PlayerYachtPos5;
    private Vector3 PlayerYachtPos6;
    private Vector3 PlayerYachtPos7;
    private Vector3 PlayerYachtPos8;
    private Vector3 PlayerYachtPos9;
    private Vector3 PlayerYachtPos10;
    private Vector3 PlayerYachtPos11;
    private Vector3 PlayerYachtPos12;
    private Vector3 PlayerYachtPos13;
    private Vector3 PlayerYachtPos14;
    private Vector3 PlayerYachtPos15;
    private Vector3 PlayerYachtPos16;
    private Vector3 PlayerYachtPos17;
    private Vector3 PlayerYachtPos18;
    private Vector3 PlayerYachtPos19;
    private Vector3 PlayerYachtPos20;
    private Vector3 PlayerYachtPos21;
    private Vector3 PlayerYachtPos22;
    private Vector3 PlayerYachtPos23;
    private Vector3 PlayerYachtPos24;
    private Vector3 PlayerYachtPos25;
    private Vector3 PlayerYachtPos26;
    private Vector3 PlayerYachtPos27;
    private Vector3 PlayerYachtPos28;
    private Vector3 PlayerYachtPos29;
    private Vector3 PlayerYachtPos30;
    private Vector3 PlayerYachtPos31;
    private Vector3 PlayerYachtPos32;
    private Vector3 PlayerYachtPos33;
    private Vector3 PlayerYachtPos34;
    private Vector3 PlayerYachtPos35;
    private Vector3 PlayerYachtPos36;
    public List<Vector3> YachtPos;
    public List<string> YachtHashs;
    public List<string> YachtHashs2;
    public List<Blip> Blips;
    public List<string> YachtLocSring;
    public List<Prop> Props;
    private string Rail;
    private string YachtTop;
    private string YachtLauncher;
    public bool GoldRails;
    public int ShipColor;
    public int RailsColor;
    public Vector3 ChangeLocMarker;
    public int Purchased;
    public int YachtType;
    public int Location;
    public int Lighting;
    public int LightingColor;
    public bool Created;
    public int DoorType;
    public Prop DoorA;
    public Prop DoorB;
    public Prop DoorC;
    public int H1;
    public int H2;
    public List<string> FlagList;
    public int CurrentFlag;
    public Prop FlagA;
    public Prop FlagB;
    public Prop FlagC;
    public Vector3 FlagPosA;
    public Vector3 FlagPosB;
    public Vector3 FlagPosC;
    public List<object> TF;
    public string CurrentArenaPreset;
    public bool SunkenCargoShipOn;
    public bool TrainCrashOn;
    public bool FortZancudoGates;
    public bool CluckenBellOn;
    public bool PlaneCrashOn;
    public bool TrailerTidy;
    public bool SimeonsShowroom;
    public bool UnionDepositoryActive;
    public bool HumaineLabsGrate;
    public bool HospitalDestroyed;
    public bool VangelicoOpen;
    public bool GasStationOnFire;
    public bool TriathalonProps;
    public bool MeltdownPremire;
    public bool fixedPaletoHotel;
    public bool fixedCypressFlatsBrickWall;
    public bool BurntJoshsMansion;
    public bool RepairedStabCity;
    public bool DestroyedSilthouse;
    public bool MaxRendaBuilding;
    public int interior1;
    public int AvI1;
    public int AvI2;
    public int AvI3;
    public int AvI4;
    public int AvI5;
    public int AvI6;
    public int av7;
    public bool Av1;
    public bool Av2;
    public bool Av3;
    public bool Av4;
    public bool Av5;
    public bool Av6;
    public int interior3;
    public int bl31;
    public int bl32;
    public int bl33;
    public bool tweapons;
    public int tcolor;
    public int tdesign;
    public int tlights;
    public bool tbike;
    public bool tdrone;
    public List<string> TLights;
    public List<string> design;
    public List<string> color;
    public Entity moc1;
    public Entity moc2;
    public Entity moc3;
    public Entity moc4;
    public Entity moc5;
    public Entity moc6;
    public Entity moc7;
    public Entity moc8;
    public Entity moc9;
    public Entity moc10;
    public Entity moc11;
    public Entity moc12;
    public Entity moc13;
    public Entity moc14;
    public Entity moc15;
    public Entity moc16;
    public Entity moc17;
    public Entity moc18;
    public Entity moc19;
    public Entity moc20;
    public Entity moc21;
    public Entity moc22;
    public Entity moc23;
    public Entity moc24;
    public Entity moc25;
    public int MocBay;
    public int MocBay2;
    public int MocBay3;
    public List<int> MocColor1;
    public int CurrentMocColor1;
    public List<int> MocColor2;
    public int CurrentMocColor2;
    public List<string> MocBays1;
    public int CurrentMocBays1;
    public List<string> MocLightsLiving;
    public int CurrentMocLightsLiving;
    public List<string> MocLightsCommand;
    public int CurrentMocLightsCommand;
    public List<string> MocLightsGunMod;
    public int CurrentMocLightsGunMod;
    public List<string> MocLightsVehicle;
    public int CurrentMocLightsVehicle;
    public List<string> MocLightsVehicleAweapon;
    public int CurrentMocLightsVehicleAweapon;
    public bool IsinInterior;
    public bool SetupLights;
    public bool YachtActive;
    public bool CreateYacht;
    public bool GunrunningYacht;
    public bool Firsttime;
    public Vector3 CurrentYacht;
    public int Penthouse_Style;
    public int Penthouse_Media;
    public int Penthouse_Spa;
    public int Penthouse_Bar;
    public int Penthouse_Colour;
    public int Penthouse_Arcade;
    public int Penthouse_BarLight;
    public int Penthouse_PokerDealer;
    public int Penthouse_ExtraBedroom;
    public int ArcadeFloodID;
    public int MuralID;
    public int PushieID;
    public int NeonArtID;
    public int ArcadeStyle;
    public int UnlockedDilllEquipment;
    public int UnlockedBreachingEquipment;
    public int UnlockedOutfitsEquipment;
    public int UnlockedPlansEquipment;
    public int UnlockedGarage;
    public int UnlockedGunlocker;
    public List<string> Workshop;
    public List<string> B1Garage;
    public bool WLiving;
    public bool nopeds;
    public int N_Style;
    public int N_PodiumStyle;
    public int N_Booze;
    public int N_DJ;
    public int N_DJLights;
    public int N_Lights;
    public int N_LightsRig;
    public int N_Upgrade;
    public int N_ClubName;
    public int N_trophies;
    public int N_WorkLights;
    public int N_Clutter;
    public int N_DryIce;
    public int N_DelivTruck;
    public int N_DancerAGender;
    public int N_DancerAStyle;
    public int N_DancerBGender;
    public int N_DancerBStyle;
    public int N_PrivacyGlass;
    public Color N_CeilingColour;
    public string N_CeilingColourstring;
    public string N_SpotLightColourstring;
    public Color N_SpotLightColour;
    public bool RandomSpotlightColour;
    public bool LoadCEOgarage;
    public bool LoadWarehouseInt;
    public bool LoadFacility;
    public bool LoadBunker;
    public bool LoadHanger;
    public bool load_DCARgarages;
    public bool LoadBikerClubhouseA;
    public bool LoadBikerClubhouseB;
    public bool LoadArenaGarage;
    public bool LoadNightClubGarage;
    public bool EnableSub;
    public bool EnableMissileSilo;
    public bool EnableAircraftCarrier;
    public bool RogersScrapYard;
    public bool FibBuilding;
    public bool EnableArcadiusTower;
    public bool EnableAracdiusTowerExProps;
    public bool EnableAracdiusTowerCashProps;
    public string AracdiusTowerStyle;
    public bool EnableMazeBankTower;
    public bool EnableMazeBankTowerExProps;
    public bool EnableMazeBankTowerCashProps;
    public string MazeBankTowerStyle;
    public bool EnableMazeBankWestTower;
    public bool EnableMazeBankWestTowerExProps;
    public bool EnableMazeBankWestTowerCashProps;
    public string MazeBankWestTowerStyle;
    public bool EnableLombokTower;
    public bool EnableLombokTowerExProps;
    public bool EnableLombokTowerCashProps;
    public string MazeLombokTowerStyle;
    public bool EnableCasino;
    public bool EnableCasinoPenthouse;
    public bool EnableMoc;
    public bool EnableTerrobyte;
    public bool EnableAvenger;
    public bool EnableNightclub;
    public bool EnableNightclubGarage;
    public bool EnableArena;
    public string ArenaType;
    public bool EnableArenaWorkshop;
    public bool EnableArenaVip;
    public bool EnableIAAServerFarm;
    public bool EnableIAAFacility;
    public bool EnableCEOCargoWarehouse_Small;
    public bool EnableCEOCargoWareWarehouse_Medium;
    public bool EnableCEOCargoWareWarehouse_Large;
    public bool EnableDCH_Arcade;
    public bool EnableDCH_Casino;
    public bool EnableDCH_LoadingBay;
    public bool EnableDCH_Vault;
    public bool EnableDCH_Office;
    public bool EnableDCH_Hotel;
    public bool EnableDCH_Tunnel;
    public bool EnableDCH_Shaft;
    public bool EnableBikerMoneyPrinter;
    public bool EnableBikerCocaineLab;
    public bool EnableBikerMethLab;
    public bool EnableBikerWeedFarm;
    public bool EnableBikerForgeryOffice;
    public bool EnableNorthYankton;
    public bool EnableCEOModShop;
    public string Decal;
    public int Design;
    public bool EnableMarkers_Teleport;
    public bool EnableBlips;
    public bool EnableDistanceBlips;
    public bool ShowBlip_IgnorePlayerHeight;
    public bool Enable_EAI_InBlipName;
    public int ShowBlipDist;
    public bool LoadMPMapsOnRefresh;
    public List<string> TrinketsAndTrophies;
    public bool TrinketsAndTrophiesEnabled;
    public List<string> ExProp;
    private List<string> CashProp;
    public List<Vector3> MarkerPos;
    public List<Vector3> EnterPos;
    public List<Vector3> ExitPos;
    public List<Blip> InteriorBlips;
    public int ModBoothType;
    public int WallsType;
    public int FurnishingType;
    public int decorativeType;
    public int GunlockerType;
    public int Muraltype;
    public List<string> NStadium;
    public List<EAIBLip> EAIBLIPS;
    public UIMenu ClubhouseCustomizationMenu;
    public UIResRectangle RectangleGUI;
    public List<UIMenu> GUIMenus;
    public Prop Base;
    public Prop YachtBase;
    private string YachtHash;
    public int SpawnDist;
    public bool ShowDistWhenClose;
    public int LoadTime;
    public Prop Lift1;
    public Prop Lift2;
    public bool LiftOn1;
    public bool LiftOn2;
    public int LiftDic1;
    public int LiftDic2;
    public int blipid;
    public bool CreateDoor1;
    public bool CreateDoor2;
    public bool CreateDoor3;
    public bool CreateDoor4;
    public bool CreateDoor5;
    public bool CreateDoor6;
    public bool CreateDoor7;
    public bool CreateDoor8;
    public bool CreateDoor9;
    private int markerat;
    private int dooror;
    public List<Prop> ArcadeProps;
    public List<Vector3> ArcadePos;
    private static Vector3 ArcadePos1 = new Vector3(2730.1f, -376.4f, -50f);
    public float ArcadeRot1;
    public int Arcade1Ver;
    private static Vector3 ArcadePos2 = new Vector3((float) Class1.ArcadePos1.X, (float) (Class1.ArcadePos1.Y - 1.0), (float) Class1.ArcadePos1.Z);
    public float ArcadeRot2;
    public int Arcade2Ver;
    private static Vector3 ArcadePos3 = new Vector3((float) Class1.ArcadePos2.X, (float) (Class1.ArcadePos2.Y - 1.0), (float) Class1.ArcadePos2.Z);
    public float ArcadeRot3;
    public int Arcade3Ver;
    private static Vector3 ArcadePos4 = new Vector3((float) Class1.ArcadePos2.X, (float) (Class1.ArcadePos2.Y + 2.0), (float) Class1.ArcadePos2.Z);
    public float ArcadeRot4;
    public int Arcade4Ver;
    private static Vector3 ArcadePos5 = new Vector3((float) Class1.ArcadePos4.X, (float) (Class1.ArcadePos4.Y + 1.0), (float) Class1.ArcadePos4.Z);
    public float ArcadeRot5;
    public int Arcade5Ver;
    private static Vector3 ArcadePos6 = new Vector3(2730.1f, -371.2f, -50f);
    public float ArcadeRot6;
    public int Arcade6Ver;
    private static Vector3 ArcadePos7 = new Vector3((float) (Class1.ArcadePos6.X + 1.0), (float) Class1.ArcadePos6.Y, (float) Class1.ArcadePos6.Z);
    public float ArcadeRot7;
    public int Arcade7Ver;
    private static Vector3 ArcadePos8 = new Vector3((float) (Class1.ArcadePos7.X + 1.0), (float) Class1.ArcadePos7.Y, (float) Class1.ArcadePos7.Z);
    public float ArcadeRot8;
    public int Arcade8Ver;
    private static Vector3 ArcadePos9 = new Vector3((float) (Class1.ArcadePos8.X + 1.0), (float) Class1.ArcadePos8.Y, (float) Class1.ArcadePos8.Z);
    public float ArcadeRot9;
    public int Arcade9Ver;
    private static Vector3 ArcadePos10 = new Vector3((float) (Class1.ArcadePos9.X + 1.0), (float) Class1.ArcadePos9.Y, (float) Class1.ArcadePos9.Z);
    public float ArcadeRot10;
    public int Arcade10Ver;
    private static Vector3 ArcadePos11 = new Vector3((float) (Class1.ArcadePos10.X + 1.0), (float) Class1.ArcadePos10.Y, (float) Class1.ArcadePos10.Z);
    public float ArcadeRot11;
    public int Arcade11Ver;
    private static Vector3 ArcadePos12 = new Vector3(2734.2f, -385.5f, -50f);
    public float ArcadeRot12;
    public int Arcade12Ver;
    private static Vector3 ArcadePos13 = new Vector3((float) Class1.ArcadePos12.X, (float) (Class1.ArcadePos12.Y + 1.0), (float) Class1.ArcadePos12.Z);
    public float ArcadeRot13;
    public int Arcade13Ver;
    private static Vector3 ArcadePos14 = new Vector3((float) Class1.ArcadePos13.X, (float) (Class1.ArcadePos13.Y + 1.0), (float) Class1.ArcadePos13.Z);
    public float ArcadeRot14;
    public int Arcade14Ver;
    private static Vector3 ArcadePos15 = new Vector3((float) Class1.ArcadePos14.X, (float) (Class1.ArcadePos14.Y + 1.0), (float) Class1.ArcadePos14.Z);
    public float ArcadeRot15;
    public int Arcade15Ver;
    private static Vector3 ArcadePos16 = new Vector3((float) Class1.ArcadePos15.X, (float) (Class1.ArcadePos15.Y + 1.0), (float) Class1.ArcadePos15.Z);
    public float ArcadeRot16;
    public int Arcade16Ver;
    private static Vector3 ArcadePos17 = new Vector3(2733f, -391.9f, -49.5f);
    public float ArcadeRot17;
    public int Arcade17Ver;
    private static Vector3 ArcadePos18 = new Vector3((float) (Class1.ArcadePos17.X - 1.0), (float) Class1.ArcadePos17.Y, (float) Class1.ArcadePos17.Z);
    public float ArcadeRot18;
    public int Arcade18Ver;
    private static Vector3 ArcadePos19 = new Vector3((float) (Class1.ArcadePos18.X - 1.0), (float) Class1.ArcadePos18.Y, (float) Class1.ArcadePos18.Z);
    public float ArcadeRot19;
    public int Arcade19Ver;
    private static Vector3 ArcadePos20 = new Vector3((float) (Class1.ArcadePos19.X - 1.0), (float) Class1.ArcadePos19.Y, (float) Class1.ArcadePos19.Z);
    public float ArcadeRot20;
    public int Arcade20Ver;

    public Model RequestModel(string Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(10000);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(VehicleHash Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(10000);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(PedHash Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(10000);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    private void SetupTerrobyteContents()
    {
      this.TLights = new List<string>();
      this.design = new List<string>();
      this.color = new List<string>();
      this.TLights.Add("int_03_ba_light_rig1");
      this.TLights.Add("int_03_ba_light_rig2");
      this.TLights.Add("int_03_ba_light_rig3");
      this.TLights.Add("int_03_ba_light_rig4");
      this.TLights.Add("int_03_ba_light_rig5");
      this.TLights.Add("int_03_ba_light_rig6");
      this.TLights.Add("int_03_ba_light_rig7");
      this.TLights.Add("int_03_ba_light_rig8");
      this.TLights.Add("int_03_ba_light_rig9");
      this.design.Add("int_03_ba_design_01");
      this.design.Add("int_03_ba_design_02");
      this.design.Add("int_03_ba_design_03");
      this.design.Add("int_03_ba_design_04");
      this.design.Add("int_03_ba_design_05");
      this.design.Add("int_03_ba_design_06");
      this.design.Add("int_03_ba_design_07");
      this.design.Add("int_03_ba_design_08");
      this.design.Add("int_03_ba_design_09");
      this.design.Add("int_03_ba_design_10");
      this.design.Add("int_03_ba_design_11");
      this.design.Add("int_03_ba_design_12");
      this.design.Add("int_03_ba_design_13");
      this.design.Add("int_03_ba_design_14");
      this.design.Add("int_03_ba_design_15");
      this.design.Add("int_03_ba_design_16");
      this.design.Add("int_03_ba_design_17");
      this.design.Add("int_03_ba_design_18");
      this.design.Add("int_03_ba_design_19");
      this.design.Add("int_03_ba_design_20");
      this.design.Add("int_03_ba_design_21");
      this.design.Add("int_03_ba_design_22");
      this.design.Add("int_03_ba_design_23");
      this.design.Add("int_03_ba_design_24");
      this.design.Add("int_03_ba_design_25");
      this.color.Add("Color1");
      this.color.Add("Color2");
      this.color.Add("Color3");
      this.color.Add("Color4");
      this.color.Add("Color5");
      this.color.Add("Color6");
      this.color.Add("Color7");
      this.color.Add("Color8");
      this.color.Add("Color9");
      this.color.Add("Color10");
    }

    private void SetupMOCContents()
    {
      this.MocColor1 = new List<int>();
      this.MocColor2 = new List<int>();
      this.MocBays1 = new List<string>();
      this.MocLightsLiving = new List<string>();
      this.MocLightsCommand = new List<string>();
      this.MocLightsGunMod = new List<string>();
      this.MocLightsVehicle = new List<string>();
      this.MocLightsVehicleAweapon = new List<string>();
      this.MocColor1.Add(1);
      this.MocColor1.Add(4);
      this.MocColor1.Add(7);
      this.MocColor2.Add(1);
      this.MocColor2.Add(2);
      this.MocColor2.Add(3);
      this.MocColor2.Add(4);
      this.MocColor2.Add(5);
      this.MocColor2.Add(6);
      this.MocColor2.Add(7);
      this.MocColor2.Add(8);
      this.MocColor2.Add(9);
      this.MocColor2.Add(10);
      this.MocColor2.Add(11);
      this.MocColor2.Add(12);
      this.MocColor2.Add(13);
      this.MocColor2.Add(14);
      this.MocBays1.Add("Living Quarters");
      this.MocBays1.Add("Command Center");
      this.MocBays1.Add("Living Quarters");
      this.MocBays1.Add("Empty Bay");
      this.MocBays1.Add("Weapons Workshop");
      this.MocBays1.Add("Weapons and Vehicle Workshop");
      this.MocBays1.Add("Living Quarters");
      this.MocBays1.Add("Empty Bay");
      this.MocBays1.Add("Personal Vehicle Storage");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_w_ol");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_w_mu");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_w_lg");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_w_br");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_g_ol");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_g_bl");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_g_re");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_g_mu");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_g_dg");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_g_aq");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_b_ol");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_b_re");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_b_bk");
      this.MocLightsLiving.Add("gr_prop_inttruck_light_li_b_bl");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_w_ol");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_w_mu");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_w_lg");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_w_br");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_g_ol");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_g_bl");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_g_re");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_g_mu");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_g_dg");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_g_aq");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_b_ol");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_b_re");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_b_bk");
      this.MocLightsCommand.Add("gr_prop_inttruck_light_co_b_bl");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_w_ol");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_w_mu");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_w_lg");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_w_br");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_g_ol");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_g_bl");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_g_re");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_g_mu");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_g_dg");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_g_aq");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_b_ol");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_b_re");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_b_bk");
      this.MocLightsGunMod.Add("gr_prop_inttruck_light_gu_b_bl");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_w_ol");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_w_mu");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_w_lg");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_w_br");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_g_ol");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_g_bl");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_g_re");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_g_mu");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_g_dg");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_g_aq");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_b_ol");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_b_re");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_b_bk");
      this.MocLightsVehicle.Add("gr_prop_inttruck_light_ve_b_bl");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_w_ol");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_w_mu");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_w_lg");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_w_br");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_g_ol");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_g_bl");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_g_re");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_g_mu");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_g_dg");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_g_aq");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_b_ol");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_b_re");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_b_bk");
      this.MocLightsVehicleAweapon.Add("gr_prop_inttruck_light_ca_b_bl");
    }

    public float GetRoationalAxis()
    {
      float z = (float) ((Entity) this.Base).get_Rotation().Z;
      return 0.0f;
    }

    public void SpawnProp(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          World.CreateProp(model, Pos, true, false);
          Prop[] propArray = i == 4 || i == 5 || i == 6 ? World.GetNearbyProps(Pos, 2f, model) : World.GetNearbyProps(Pos, 100f, model);
          if (i != 4 && i != 5)
          {
            foreach (Prop prop in propArray)
            {
              if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
              {
                if (i == 1)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, 0.0f, 14.5f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                  Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(prop),
                    InputArgument.op_Implicit(this.ShipColor)
                  });
                }
                if (i == 2)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, 0.0f, 14.5f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                  if (!this.GoldRails)
                    Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(prop),
                      InputArgument.op_Implicit(this.RailsColor)
                    });
                  else if (this.GoldRails)
                    Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(prop),
                      InputArgument.op_Implicit(0)
                    });
                }
                if (i == 3)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, 0.0f, 14.5f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                }
                if (i == 6)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(-36.8f, -2.7f, 0.6f), new Vector3(0.0f, 0.0f, 90f));
                  ((Entity) prop).set_HasCollision(true);
                  if (Entity.op_Equality((Entity) this.DoorA, (Entity) null))
                    this.DoorA = prop;
                  this.Props.Add(prop);
                  Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(prop),
                    InputArgument.op_Implicit(this.ShipColor)
                  });
                }
                if (i == 7)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(-51f, -2f, 0.3f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                }
              }
            }
          }
          else if (i == 4 || i == 5)
          {
            foreach (Prop prop in propArray)
            {
              if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
              {
                switch (i)
                {
                  case 4:
                    if (Entity.op_Equality((Entity) this.DoorB, (Entity) null))
                    {
                      this.DoorB = prop;
                      goto label_36;
                    }
                    else
                      goto label_36;
                  case 5:
                    if (Entity.op_Equality((Entity) this.DoorC, (Entity) null))
                    {
                      this.DoorC = prop;
                      goto label_36;
                    }
                    else
                      goto label_36;
                  default:
                    continue;
                }
              }
            }
label_36:;
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnDoor(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.DoorB, (Entity) null))
            this.DoorB = World.CreateProp(model, Pos, false, false);
          if (Entity.op_Equality((Entity) this.DoorC, (Entity) null))
            this.DoorC = World.CreateProp(model, Pos, false, false);
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnFlagA(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.FlagA, (Entity) null))
          {
            this.FlagA = World.CreateProp(model, Pos, Rot, false, false);
          }
          else
          {
            ((Entity) this.FlagA).Delete();
            this.FlagA = World.CreateProp(model, Pos, Rot, false, false);
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnFlagB(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.FlagB, (Entity) null))
          {
            this.FlagB = World.CreateProp(model, Pos, Rot, false, false);
          }
          else
          {
            ((Entity) this.FlagB).Delete();
            this.FlagB = World.CreateProp(model, Pos, Rot, false, false);
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnFlagC(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.FlagC, (Entity) null))
          {
            this.FlagC = World.CreateProp(model, Pos, Rot, false, false);
          }
          else
          {
            ((Entity) this.FlagC).Delete();
            this.FlagC = World.CreateProp(model, Pos, Rot, false, false);
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public Class1()
    {
      base.\u002Ector();
      this.LoadIniFile("scripts//EnableAllInteriors.ini");
      this.DeleteMOCBays();
      this.SetupMOCContents();
      this.SetupTerrobyteContents();
      this.SetupAvenger();
      this.SetupTerrpbyte();
      this.set_Interval(1);
      this.add_Tick(new EventHandler(this.OnTick));
      this.add_KeyDown(new KeyEventHandler(this.OnKeyDown));
      this.add_Aborted(new EventHandler(this.OnShutdown));
      this.LoadIniFile("scripts//EnableAllInteriors.ini");
      this.Setup(true);
    }

    public void DeleteMOCBays()
    {
      if (Entity.op_Inequality(this.moc1, (Entity) null))
        this.moc1.Delete();
      if (Entity.op_Inequality(this.moc2, (Entity) null))
        this.moc2.Delete();
      if (Entity.op_Inequality(this.moc3, (Entity) null))
        this.moc3.Delete();
      if (Entity.op_Inequality(this.moc4, (Entity) null))
        this.moc4.Delete();
      if (Entity.op_Inequality(this.moc5, (Entity) null))
        this.moc5.Delete();
      if (Entity.op_Inequality(this.moc6, (Entity) null))
        this.moc6.Delete();
      if (Entity.op_Inequality(this.moc7, (Entity) null))
        this.moc7.Delete();
      if (Entity.op_Inequality(this.moc8, (Entity) null))
        this.moc8.Delete();
      if (Entity.op_Inequality(this.moc9, (Entity) null))
        this.moc9.Delete();
      if (Entity.op_Inequality(this.moc10, (Entity) null))
        this.moc10.Delete();
      if (Entity.op_Inequality(this.moc11, (Entity) null))
        this.moc11.Delete();
      if (Entity.op_Inequality(this.moc12, (Entity) null))
        this.moc11.Delete();
      if (Entity.op_Inequality(this.moc13, (Entity) null))
        this.moc13.Delete();
      if (Entity.op_Inequality(this.moc14, (Entity) null))
        this.moc14.Delete();
      if (Entity.op_Inequality(this.moc15, (Entity) null))
        this.moc15.Delete();
      if (Entity.op_Inequality(this.moc16, (Entity) null))
        this.moc16.Delete();
      if (Entity.op_Inequality(this.moc17, (Entity) null))
        this.moc17.Delete();
      if (Entity.op_Inequality(this.moc18, (Entity) null))
        this.moc18.Delete();
      if (Entity.op_Inequality(this.moc19, (Entity) null))
        this.moc19.Delete();
      if (Entity.op_Inequality(this.moc20, (Entity) null))
        this.moc20.Delete();
      if (Entity.op_Inequality(this.moc21, (Entity) null))
        this.moc21.Delete();
      if (Entity.op_Inequality(this.moc22, (Entity) null))
        this.moc22.Delete();
      if (Entity.op_Inequality(this.moc23, (Entity) null))
        this.moc23.Delete();
      if (Entity.op_Inequality(this.moc24, (Entity) null))
        this.moc24.Delete();
      if (!Entity.op_Inequality(this.moc25, (Entity) null))
        return;
      this.moc25.Delete();
    }

    private void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.LoadWarehouseInt = (bool) this.Config.GetValue<bool>("Interiors", "LoadWarehouseInt", (M0) (this.LoadWarehouseInt ? 1 : 0));
        this.LoadFacility = (bool) this.Config.GetValue<bool>("Interiors", "LoadFacility", (M0) (this.LoadFacility ? 1 : 0));
        this.LoadHanger = (bool) this.Config.GetValue<bool>("Interiors", "LoadHanger", (M0) (this.LoadHanger ? 1 : 0));
        this.LoadBunker = (bool) this.Config.GetValue<bool>("Interiors", "LoadBunker", (M0) (this.LoadBunker ? 1 : 0));
        this.load_DCARgarages = (bool) this.Config.GetValue<bool>("Interiors", "load_DCARgarages", (M0) (this.load_DCARgarages ? 1 : 0));
        this.LoadBikerClubhouseA = (bool) this.Config.GetValue<bool>("Interiors", "LoadBikerClubhouseA", (M0) (this.LoadBikerClubhouseA ? 1 : 0));
        this.LoadBikerClubhouseB = (bool) this.Config.GetValue<bool>("Interiors", "LoadBikerClubhouseB", (M0) (this.LoadBikerClubhouseB ? 1 : 0));
        this.LoadArenaGarage = (bool) this.Config.GetValue<bool>("Interiors", "LoadArenaGarage", (M0) (this.LoadArenaGarage ? 1 : 0));
        this.LoadBunkerHatches = (bool) this.Config.GetValue<bool>("Interiors", "LoadBunkerHatches", (M0) (this.LoadBunkerHatches ? 1 : 0));
        this.LoadFacilityHatches = (bool) this.Config.GetValue<bool>("Interiors", "LoadFacilityHatches", (M0) (this.LoadFacilityHatches ? 1 : 0));
        this.LoadNightClubGarage = (bool) this.Config.GetValue<bool>("Interiors", "LoadNightClubGarage", (M0) (this.LoadNightClubGarage ? 1 : 0));
        this.LombokCEOGarage = (string) this.Config.GetValue<string>("Interiors", "LombokCEOGarage", (M0) this.LombokCEOGarage);
        this.MazeBankCEOGarage = (string) this.Config.GetValue<string>("Interiors", "MazeBankCEOGarage", (M0) this.MazeBankCEOGarage);
        this.MazeBankWestCEOGarage = (string) this.Config.GetValue<string>("Interiors", "MazeBankWestCEOGarage", (M0) this.MazeBankWestCEOGarage);
        this.ArcadiusCEOGarage = (string) this.Config.GetValue<string>("Interiors", "ArcadiusCEOGarage", (M0) this.ArcadiusCEOGarage);
        this.LoadCEOgarage = (bool) this.Config.GetValue<bool>("Interiors", "LoadCEOgarage", (M0) (this.LoadCEOgarage ? 1 : 0));
        this.EnableSub = (bool) this.Config.GetValue<bool>("Interiors", "EnableSub", (M0) (this.EnableSub ? 1 : 0));
        this.EnableMissileSilo = (bool) this.Config.GetValue<bool>("Interiors", "EnableMissileSilo", (M0) (this.EnableMissileSilo ? 1 : 0));
        this.EnableAircraftCarrier = (bool) this.Config.GetValue<bool>("Interiors", "EnableAircraftCarrier", (M0) (this.EnableAircraftCarrier ? 1 : 0));
        this.EnableArcadiusTower = (bool) this.Config.GetValue<bool>("Interiors", "EnableArcadiusTower", (M0) (this.EnableArcadiusTower ? 1 : 0));
        this.EnableAracdiusTowerExProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableAracdiusTowerExProps", (M0) (this.EnableAracdiusTowerExProps ? 1 : 0));
        this.EnableAracdiusTowerCashProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableAracdiusTowerCashProps", (M0) (this.EnableAracdiusTowerCashProps ? 1 : 0));
        this.AracdiusTowerStyle = (string) this.Config.GetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
        this.EnableMazeBankTower = (bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankTower", (M0) (this.EnableMazeBankTower ? 1 : 0));
        this.EnableMazeBankTowerExProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankTowerExProps", (M0) (this.EnableMazeBankTowerExProps ? 1 : 0));
        this.EnableMazeBankTowerCashProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankTowerCashProps", (M0) (this.EnableMazeBankTowerCashProps ? 1 : 0));
        this.MazeBankTowerStyle = (string) this.Config.GetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
        this.EnableMazeBankWestTower = (bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankWestTower", (M0) (this.EnableMazeBankWestTower ? 1 : 0));
        this.EnableMazeBankWestTowerExProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankWestTowerExProps", (M0) (this.EnableMazeBankWestTowerExProps ? 1 : 0));
        this.EnableMazeBankWestTowerCashProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankWestTowerCashProps", (M0) (this.EnableMazeBankWestTowerCashProps ? 1 : 0));
        this.MazeBankWestTowerStyle = (string) this.Config.GetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
        this.EnableLombokTower = (bool) this.Config.GetValue<bool>("Interiors", "EnableLombokTower", (M0) (this.EnableLombokTower ? 1 : 0));
        this.EnableLombokTowerExProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableLombokTowerExProps", (M0) (this.EnableLombokTowerExProps ? 1 : 0));
        this.EnableLombokTowerCashProps = (bool) this.Config.GetValue<bool>("Interiors", "EnableLombokTowerCashProps", (M0) (this.EnableLombokTowerCashProps ? 1 : 0));
        this.MazeLombokTowerStyle = (string) this.Config.GetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
        this.EnableCasino = (bool) this.Config.GetValue<bool>("Interiors", "EnableCasino", (M0) (this.EnableCasino ? 1 : 0));
        this.EnableCasinoPenthouse = (bool) this.Config.GetValue<bool>("Interiors", "EnableCasinoPenthouse", (M0) (this.EnableCasinoPenthouse ? 1 : 0));
        this.EnableMoc = (bool) this.Config.GetValue<bool>("Interiors", "EnableMoc", (M0) (this.EnableMoc ? 1 : 0));
        this.EnableTerrobyte = (bool) this.Config.GetValue<bool>("Interiors", "EnableTerrobyte", (M0) (this.EnableTerrobyte ? 1 : 0));
        this.EnableAvenger = (bool) this.Config.GetValue<bool>("Interiors", "EnableAvenger", (M0) (this.EnableAvenger ? 1 : 0));
        this.EnableNightclub = (bool) this.Config.GetValue<bool>("Interiors", "EnableNightclub", (M0) (this.EnableNightclub ? 1 : 0));
        this.EnableNightclubGarage = (bool) this.Config.GetValue<bool>("Interiors", "EnableNightclubGarage", (M0) (this.EnableNightclubGarage ? 1 : 0));
        this.EnableArena = (bool) this.Config.GetValue<bool>("Interiors", "EnableArena", (M0) (this.EnableArena ? 1 : 0));
        this.ArenaType = (string) this.Config.GetValue<string>("Interiors", "ArenaType", (M0) this.ArenaType);
        this.EnableArenaWorkshop = (bool) this.Config.GetValue<bool>("Interiors", "EnableArenaWorkshop", (M0) (this.EnableArenaWorkshop ? 1 : 0));
        this.EnableArenaVip = (bool) this.Config.GetValue<bool>("Interiors", "EnableArenaVip", (M0) (this.EnableArenaVip ? 1 : 0));
        this.EnableIAAServerFarm = (bool) this.Config.GetValue<bool>("Interiors", "LoadCEOgarage", (M0) (this.EnableIAAServerFarm ? 1 : 0));
        this.EnableIAAFacility = (bool) this.Config.GetValue<bool>("Interiors", "LoadCEOgarage", (M0) (this.EnableIAAServerFarm ? 1 : 0));
        this.EnableCEOCargoWarehouse_Small = (bool) this.Config.GetValue<bool>("Interiors", "EnableCEOCargoWarehouse_Small", (M0) (this.EnableCEOCargoWarehouse_Small ? 1 : 0));
        this.EnableCEOCargoWareWarehouse_Medium = (bool) this.Config.GetValue<bool>("Interiors", "EnableCEOCargoWareWarehouse_Medium", (M0) (this.EnableCEOCargoWareWarehouse_Medium ? 1 : 0));
        this.EnableCEOCargoWareWarehouse_Large = (bool) this.Config.GetValue<bool>("Interiors", "EnableCEOCargoWareWarehouse_Large", (M0) (this.EnableCEOCargoWareWarehouse_Large ? 1 : 0));
        this.EnableDCH_Arcade = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Arcade", (M0) (this.EnableDCH_Arcade ? 1 : 0));
        this.EnableDCH_Casino = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Casino", (M0) (this.EnableDCH_Casino ? 1 : 0));
        this.EnableDCH_LoadingBay = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_LoadingBay", (M0) (this.EnableDCH_LoadingBay ? 1 : 0));
        this.EnableDCH_Vault = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Vault", (M0) (this.EnableDCH_Vault ? 1 : 0));
        this.EnableDCH_Office = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Office", (M0) (this.EnableDCH_Office ? 1 : 0));
        this.EnableDCH_Hotel = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Hotel", (M0) (this.EnableDCH_Hotel ? 1 : 0));
        this.EnableDCH_Tunnel = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Tunnel", (M0) (this.EnableDCH_Tunnel ? 1 : 0));
        this.EnableDCH_Shaft = (bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Shaft", (M0) (this.EnableDCH_Shaft ? 1 : 0));
        this.EnableBikerMoneyPrinter = (bool) this.Config.GetValue<bool>("Interiors", "EnableBikerMoneyPrinter", (M0) (this.EnableBikerMoneyPrinter ? 1 : 0));
        this.EnableBikerCocaineLab = (bool) this.Config.GetValue<bool>("Interiors", "EnableBikerCocaineLab", (M0) (this.EnableBikerCocaineLab ? 1 : 0));
        this.EnableBikerMethLab = (bool) this.Config.GetValue<bool>("Interiors", "EnableBikerMethLab", (M0) (this.EnableBikerMethLab ? 1 : 0));
        this.EnableBikerWeedFarm = (bool) this.Config.GetValue<bool>("Interiors", "EnableBikerWeedFarm", (M0) (this.EnableBikerWeedFarm ? 1 : 0));
        this.EnableBikerForgeryOffice = (bool) this.Config.GetValue<bool>("Interiors", "EnableBikerForgeryOffice", (M0) (this.EnableBikerForgeryOffice ? 1 : 0));
        this.EnableNorthYankton = (bool) this.Config.GetValue<bool>("Interiors", "EnableNorthYankton", (M0) (this.EnableNorthYankton ? 1 : 0));
        this.EnableCEOModShop = (bool) this.Config.GetValue<bool>("Interiors", "EnableCEOModShop", (M0) (this.EnableCEOModShop ? 1 : 0));
        this.SunkenCargoShipOn = (bool) this.Config.GetValue<bool>("Interiors", "SunkenCargoShipOn", (M0) (this.SunkenCargoShipOn ? 1 : 0));
        this.TrainCrashOn = (bool) this.Config.GetValue<bool>("Interiors", "TrainCrashOn", (M0) (this.TrainCrashOn ? 1 : 0));
        this.FortZancudoGates = (bool) this.Config.GetValue<bool>("Interiors", "FortZancudoGates", (M0) (this.FortZancudoGates ? 1 : 0));
        this.CluckenBellOn = (bool) this.Config.GetValue<bool>("Interiors", "CluckenBellOn", (M0) (this.CluckenBellOn ? 1 : 0));
        this.PlaneCrashOn = (bool) this.Config.GetValue<bool>("Interiors", "PlaneCrashOn", (M0) (this.PlaneCrashOn ? 1 : 0));
        this.TrailerTidy = (bool) this.Config.GetValue<bool>("Interiors", "TrailerTidy", (M0) (this.TrailerTidy ? 1 : 0));
        this.SimeonsShowroom = (bool) this.Config.GetValue<bool>("Interiors", "SimeonsShowroom", (M0) (this.SimeonsShowroom ? 1 : 0));
        this.UnionDepositoryActive = (bool) this.Config.GetValue<bool>("Interiors", "UnionDepositoryActive", (M0) (this.UnionDepositoryActive ? 1 : 0));
        this.HumaineLabsGrate = (bool) this.Config.GetValue<bool>("Interiors", "HumaineLabsGrate", (M0) (this.HumaineLabsGrate ? 1 : 0));
        this.HospitalDestroyed = (bool) this.Config.GetValue<bool>("Interiors", "HospitalDestroyed", (M0) (this.HospitalDestroyed ? 1 : 0));
        this.VangelicoOpen = (bool) this.Config.GetValue<bool>("Interiors", "VangelicoOpen", (M0) (this.VangelicoOpen ? 1 : 0));
        this.GasStationOnFire = (bool) this.Config.GetValue<bool>("Interiors", "GasStationOnFire", (M0) (this.GasStationOnFire ? 1 : 0));
        this.TriathalonProps = (bool) this.Config.GetValue<bool>("Interiors", "TriathalonProps", (M0) (this.TriathalonProps ? 1 : 0));
        this.MeltdownPremire = (bool) this.Config.GetValue<bool>("Interiors", "MeltdownPremire", (M0) (this.MeltdownPremire ? 1 : 0));
        this.fixedPaletoHotel = (bool) this.Config.GetValue<bool>("Interiors", "fixedPaletoHotel", (M0) (this.fixedPaletoHotel ? 1 : 0));
        this.fixedCypressFlatsBrickWall = (bool) this.Config.GetValue<bool>("Interiors", "fixedCypressFlatsBrickWall", (M0) (this.fixedCypressFlatsBrickWall ? 1 : 0));
        this.BurntJoshsMansion = (bool) this.Config.GetValue<bool>("Interiors", "BurntJoshsMansion", (M0) (this.BurntJoshsMansion ? 1 : 0));
        this.RepairedStabCity = (bool) this.Config.GetValue<bool>("Interiors", "RepairedStabCity", (M0) (this.RepairedStabCity ? 1 : 0));
        this.DestroyedSilthouse = (bool) this.Config.GetValue<bool>("Interiors", "VangelicoOpen", (M0) (this.DestroyedSilthouse ? 1 : 0));
        this.MaxRendaBuilding = (bool) this.Config.GetValue<bool>("Interiors", "MaxRendaBuilding", (M0) (this.MaxRendaBuilding ? 1 : 0));
        this.RogersScrapYard = (bool) this.Config.GetValue<bool>("Interiors", "RogersScrapYard", (M0) (this.RogersScrapYard ? 1 : 0));
        this.FibBuilding = (bool) this.Config.GetValue<bool>("Interiors", "FibBuilding", (M0) (this.FibBuilding ? 1 : 0));
        this.EnableMarkers_Teleport = (bool) this.Config.GetValue<bool>("Misc", "EnableMarkers_Teleport", (M0) (this.EnableMarkers_Teleport ? 1 : 0));
        this.EnableBlips = (bool) this.Config.GetValue<bool>("Misc", "EnableBlips", (M0) (this.EnableBlips ? 1 : 0));
        this.EnableDistanceBlips = (bool) this.Config.GetValue<bool>("Misc", "EnableDistanceBlips", (M0) (this.EnableDistanceBlips ? 1 : 0));
        this.ShowBlip_IgnorePlayerHeight = (bool) this.Config.GetValue<bool>("Misc", "ShowBlip_IgnorePlayerHeight", (M0) (this.ShowBlip_IgnorePlayerHeight ? 1 : 0));
        this.Enable_EAI_InBlipName = (bool) this.Config.GetValue<bool>("Misc", "Enable_EAI_InBlipName", (M0) (this.Enable_EAI_InBlipName ? 1 : 0));
        this.ShowBlipDist = (int) this.Config.GetValue<int>("Misc", "ShowBlipDist", (M0) this.ShowBlipDist);
        this.LoadMPMapsOnRefresh = (bool) this.Config.GetValue<bool>("Misc", "LoadMPMapsOnRefresh", (M0) (this.LoadMPMapsOnRefresh ? 1 : 0));
        this.RandomColorBlips = (bool) this.Config.GetValue<bool>("Misc", "RandomColorBlips", (M0) (this.RandomColorBlips ? 1 : 0));
        this.UseDefaultWhiteColor = (bool) this.Config.GetValue<bool>("Misc", "UseDefaultWhiteColor", (M0) (this.UseDefaultWhiteColor ? 1 : 0));
        this.UseSpecifcBlips = (bool) this.Config.GetValue<bool>("Misc", "UseSpecifcBlips", (M0) (this.UseSpecifcBlips ? 1 : 0));
        this.BlipColor = (BlipColor) this.Config.GetValue<BlipColor>("Misc", "BlipColor", (M0) this.BlipColor);
        this.UseSpecificColor = (bool) this.Config.GetValue<bool>("Misc", "UseSpecificColor", (M0) (this.UseSpecificColor ? 1 : 0));
        this.WStyle = (string) this.Config.GetValue<string>("Warehouse", "Style", (M0) this.WStyle);
        this.FacilityGraphic = (string) this.Config.GetValue<string>("Facility", "FacilityGraphic", (M0) this.FacilityGraphic);
        this.FacilityOrbitalCannon = (string) this.Config.GetValue<string>("Facility", "FacilityOrbitalCannon", (M0) this.FacilityOrbitalCannon);
        this.FacilitySecurityRoom = (string) this.Config.GetValue<string>("Facility", "FacilitySecurityRoom", (M0) this.FacilitySecurityRoom);
        this.FacilityLounge = (string) this.Config.GetValue<string>("Facility", "FacilityLounge", (M0) this.FacilityLounge);
        this.FacilitySleepingQuarters = (string) this.Config.GetValue<string>("Facility", "FacilitySleepingQuarters", (M0) this.FacilitySleepingQuarters);
        this.FacilityShellColor = (int) this.Config.GetValue<int>("Facility", "FacilityShellColor", (M0) this.FacilityShellColor);
        this.FacilityGraphicColor = (int) this.Config.GetValue<int>("Facility", "FacilityGraphicColor", (M0) this.FacilityGraphicColor);
        this.FacilityOrbitalCannonColor = (int) this.Config.GetValue<int>("Facility", "FacilityOrbitalCannonColor", (M0) this.FacilityOrbitalCannonColor);
        this.FacilitySecurityRoomColor = (int) this.Config.GetValue<int>("Facility", "FacilitySecurityRoomColor", (M0) this.FacilitySecurityRoomColor);
        this.FacilityLoungeColor = (int) this.Config.GetValue<int>("Facility", "FacilityLoungeColor", (M0) this.FacilityLoungeColor);
        this.FacilitySleepingQuartersColor = (int) this.Config.GetValue<int>("Facility", "FacilitySleepingQuartersColor", (M0) this.FacilitySleepingQuartersColor);
        this.GStyle = (string) this.Config.GetValue<string>("Bunker", "Style", (M0) this.GStyle);
        this.Upgrade1 = (string) this.Config.GetValue<string>("Bunker", "PROPS SET", (M0) this.Upgrade1);
        this.Upgrade2 = (string) this.Config.GetValue<string>("Bunker", "SECONDARY PROPS SET", (M0) this.Upgrade2);
        this.Upgrade3 = (string) this.Config.GetValue<string>("Bunker", "SECURITY SET", (M0) this.Upgrade3);
        this.HangarLighting = (string) this.Config.GetValue<string>("Hanger", "HangarLighting", (M0) this.HangarLighting);
        this.HangarFloor = (string) this.Config.GetValue<string>("Hanger", "HangarFloor", (M0) this.HangarFloor);
        this.HangarFloorDecal = (string) this.Config.GetValue<string>("Hanger", "HangarFloorDecal", (M0) this.HangarFloorDecal);
        this.HangarBedroom = (string) this.Config.GetValue<string>("Hanger", "HangarBedroom", (M0) this.HangarBedroom);
        this.HangarOffice = (string) this.Config.GetValue<string>("Hanger", "HangarOffice", (M0) this.HangarOffice);
        this.HangarBedroomBlinds = (string) this.Config.GetValue<string>("Hanger", "HangarBedroomBlinds", (M0) this.HangarBedroomBlinds);
        this.HangarLightingWallTint = (string) this.Config.GetValue<string>("Hanger", "HangarLightingWallTint", (M0) this.HangarLightingWallTint);
        this.HangarFloorDecalColor = (int) this.Config.GetValue<int>("Hanger", "HangarFloorDecalColor", (M0) this.HangarFloorDecalColor);
        this.HangarShellColor = (int) this.Config.GetValue<int>("Hanger", "HangarShellColor", (M0) this.HangarShellColor);
        this.HangarBedroomColor = (int) this.Config.GetValue<int>("Hanger", "HangarBedroomColor", (M0) this.HangarBedroomColor);
        this.HangarCraneColor = (int) this.Config.GetValue<int>("Hanger", "HangarCraneColor", (M0) this.HangarCraneColor);
        this.HangarWorkshopColor = (int) this.Config.GetValue<int>("Hanger", "HangarWorkshopColor", (M0) this.HangarWorkshopColor);
        this.HangarLightingTintPropsColor = (int) this.Config.GetValue<int>("Hanger", "HangarLightingTintPropsColor", (M0) this.HangarLightingTintPropsColor);
        this.WorkGraphic = (string) this.Config.GetValue<string>("Arena - Workshop", "WorkGraphic", (M0) this.WorkGraphic);
        this.WorkOff = (string) this.Config.GetValue<string>("Arena - Workshop", "WorkOff", (M0) this.WorkOff);
        this.WorkMechanic = (string) this.Config.GetValue<string>("Arena - Workshop", "WorkMechanic", (M0) this.WorkMechanic);
        this.WColor = (int) this.Config.GetValue<int>("Arena - Workshop", "WColor", (M0) this.WColor);
        this.WColor1 = (int) this.Config.GetValue<int>("Arena - Workshop", "WColor1", (M0) this.WColor1);
        if (this.ArcadiusCEOGarage.Equals("A"))
        {
          this.ADecor = (string) this.Config.GetValue<string>("CEO - Arcadius A", "Decor", (M0) this.ADecor);
          this.ALighting = (string) this.Config.GetValue<string>("CEO - Arcadius A", "Lighting", (M0) this.ALighting);
          this.ANumbering = (string) this.Config.GetValue<string>("CEO - Arcadius A", "Numbering", (M0) this.ANumbering);
        }
        if (this.ArcadiusCEOGarage.Equals("B"))
        {
          this.ADecor = (string) this.Config.GetValue<string>("CEO - Arcadius B", "Decor", (M0) this.ADecor);
          this.ALighting = (string) this.Config.GetValue<string>("CEO - Arcadius B", "Lighting", (M0) this.ALighting);
          this.ANumbering = (string) this.Config.GetValue<string>("CEO - Arcadius B", "Numbering", (M0) this.ANumbering);
        }
        if (this.ArcadiusCEOGarage.Equals("C"))
        {
          this.ADecor = (string) this.Config.GetValue<string>("CEO - Arcadius C", "Decor", (M0) this.ADecor);
          this.ALighting = (string) this.Config.GetValue<string>("CEO - Arcadius C", "Lighting", (M0) this.ALighting);
          this.ANumbering = (string) this.Config.GetValue<string>("CEO - Arcadius C", "Numbering", (M0) this.ANumbering);
        }
        if (this.MazeBankCEOGarage.Equals("A"))
        {
          this.MDecor = (string) this.Config.GetValue<string>("CEO - MazeBank A", "Decor", (M0) this.MDecor);
          this.MLighting = (string) this.Config.GetValue<string>("CEO - MazeBank A", "Lighting", (M0) this.MLighting);
          this.MNumbering = (string) this.Config.GetValue<string>("CEO - MazeBank A", "Numbering", (M0) this.MNumbering);
        }
        if (this.MazeBankCEOGarage.Equals("B"))
        {
          this.MDecor = (string) this.Config.GetValue<string>("CEO - MazeBank B", "Decor", (M0) this.MDecor);
          this.MLighting = (string) this.Config.GetValue<string>("CEO - MazeBank B", "Lighting", (M0) this.MLighting);
          this.MNumbering = (string) this.Config.GetValue<string>("CEO - MazeBank B", "Numbering", (M0) this.MNumbering);
        }
        if (this.MazeBankCEOGarage.Equals("C"))
        {
          this.MDecor = (string) this.Config.GetValue<string>("CEO - MazeBank C", "Decor", (M0) this.MDecor);
          this.MLighting = (string) this.Config.GetValue<string>("CEO - MazeBank C", "Lighting", (M0) this.MLighting);
          this.MNumbering = (string) this.Config.GetValue<string>("CEO - MazeBank C", "Numbering", (M0) this.MNumbering);
        }
        if (this.MazeBankWestCEOGarage.Equals("A"))
        {
          this.MWDecor = (string) this.Config.GetValue<string>("CEO -MBWest A", "Decor", (M0) this.MWDecor);
          this.MWLighting = (string) this.Config.GetValue<string>("CEO -MBWest A", "Lighting", (M0) this.MWLighting);
          this.MWNumbering = (string) this.Config.GetValue<string>("CEO -MBWest A", "Numbering", (M0) this.MWNumbering);
        }
        if (this.MazeBankWestCEOGarage.Equals("B"))
        {
          this.MWDecor = (string) this.Config.GetValue<string>("CEO - MBWest B", "Decor", (M0) this.MWDecor);
          this.MWLighting = (string) this.Config.GetValue<string>("CEO - MBWest B", "Lighting", (M0) this.MWLighting);
          this.MWNumbering = (string) this.Config.GetValue<string>("CEO - MBWest B", "Numbering", (M0) this.MWNumbering);
        }
        if (this.MazeBankWestCEOGarage.Equals("C"))
        {
          this.MWDecor = (string) this.Config.GetValue<string>("CEO - MBWest C", "Decor", (M0) this.MWDecor);
          this.MWLighting = (string) this.Config.GetValue<string>("CEO - MBWest C", "Lighting", (M0) this.MWLighting);
          this.MWNumbering = (string) this.Config.GetValue<string>("CEO -MBWest C", "Numbering", (M0) this.MWNumbering);
        }
        if (this.LombokCEOGarage.Equals("A"))
        {
          this.LDecor = (string) this.Config.GetValue<string>("CEO - Lombok A", "Decor", (M0) this.LDecor);
          this.LLighting = (string) this.Config.GetValue<string>("CEO - Lombok A", "Lighting", (M0) this.LLighting);
          this.LNumbering = (string) this.Config.GetValue<string>("CEO - Lombok A", "Numbering", (M0) this.LNumbering);
        }
        if (this.LombokCEOGarage.Equals("B"))
        {
          this.LDecor = (string) this.Config.GetValue<string>("CEO - Lombok B", "Decor", (M0) this.LDecor);
          this.LLighting = (string) this.Config.GetValue<string>("CEO - Lombok B", "Lighting", (M0) this.LLighting);
          this.LNumbering = (string) this.Config.GetValue<string>("CEO - Lombok B", "Numbering", (M0) this.LNumbering);
        }
        if (this.LombokCEOGarage.Equals("C"))
        {
          this.LDecor = (string) this.Config.GetValue<string>("CEO - Lombok C", "Decor", (M0) this.LDecor);
          this.LLighting = (string) this.Config.GetValue<string>("CEO - Lombok C", "Lighting", (M0) this.LLighting);
          this.LNumbering = (string) this.Config.GetValue<string>("CEO - Lombok C", "Numbering", (M0) this.LNumbering);
        }
        this.tdesign = (int) this.Config.GetValue<int>("Terrobyte", "tdesign", (M0) this.tdesign);
        this.tbike = (bool) this.Config.GetValue<bool>("Terrobyte", "tbike", (M0) (this.tbike ? 1 : 0));
        this.tdrone = (bool) this.Config.GetValue<bool>("Terrobyte", "tdrone", (M0) (this.tdrone ? 1 : 0));
        this.tweapons = (bool) this.Config.GetValue<bool>("Terrobyte", "tweapons", (M0) (this.tweapons ? 1 : 0));
        this.tlights = (int) this.Config.GetValue<int>("Terrobyte", "tlights", (M0) this.tlights);
        this.tcolor = (int) this.Config.GetValue<int>("Terrobyte", "tcolor", (M0) this.tcolor);
        this.Av1 = (bool) this.Config.GetValue<bool>("Avenger", "Av1Active", (M0) (this.Av1 ? 1 : 0));
        this.Av2 = (bool) this.Config.GetValue<bool>("Avenger", "Av2Active", (M0) (this.Av2 ? 1 : 0));
        this.Av3 = (bool) this.Config.GetValue<bool>("Avenger", "Av3Active", (M0) (this.Av3 ? 1 : 0));
        this.Av4 = (bool) this.Config.GetValue<bool>("Avenger", "Av4Active", (M0) (this.Av4 ? 1 : 0));
        this.Av5 = (bool) this.Config.GetValue<bool>("Avenger", "Av5Active", (M0) (this.Av5 ? 1 : 0));
        this.Av6 = (bool) this.Config.GetValue<bool>("Avenger", "Av6Active", (M0) (this.Av6 ? 1 : 0));
        this.av7 = (int) this.Config.GetValue<int>("Avenger", "avcolor", (M0) this.av7);
        this.MocBay = (int) this.Config.GetValue<int>("MOC", "ModBay1", (M0) this.MocBay);
        this.MocBay2 = (int) this.Config.GetValue<int>("MOC", "ModBay2", (M0) this.MocBay2);
        this.MocBay3 = (int) this.Config.GetValue<int>("MOC", "ModBay3", (M0) this.MocBay3);
        this.CurrentMocColor1 = (int) this.Config.GetValue<int>("MOC", "CURRENTMOCCOLOR1", (M0) this.CurrentMocColor1);
        this.CurrentMocColor2 = (int) this.Config.GetValue<int>("MOC", "CURRENTMOCCOLOR2", (M0) this.CurrentMocColor2);
        this.CurrentMocLightsLiving = (int) this.Config.GetValue<int>("MOC", "CurrentMocLightsLiving", (M0) this.CurrentMocLightsLiving);
        this.CurrentMocLightsCommand = (int) this.Config.GetValue<int>("MOC", "CurrentMocLightsCommand", (M0) this.CurrentMocLightsCommand);
        this.CurrentMocLightsGunMod = (int) this.Config.GetValue<int>("MOC", "CurrentMocLightsGunMod", (M0) this.CurrentMocLightsGunMod);
        this.CurrentMocLightsVehicle = (int) this.Config.GetValue<int>("MOC", "CurrentMocLightsVehicle", (M0) this.CurrentMocLightsVehicle);
        this.CurrentMocLightsVehicleAweapon = (int) this.Config.GetValue<int>("MOC", "CurrentMocLightsVehicleAweapon", (M0) this.CurrentMocLightsVehicleAweapon);
        this.Config = ScriptSettings.Load(iniName);
        this.Purchased = (int) this.Config.GetValue<int>("Yacht", "Purchased", (M0) this.Purchased);
        this.GoldRails = (bool) this.Config.GetValue<bool>("Yacht", "GoldRails", (M0) (this.GoldRails ? 1 : 0));
        this.ShipColor = (int) this.Config.GetValue<int>("Yacht", "ShipColor", (M0) this.ShipColor);
        this.RailsColor = (int) this.Config.GetValue<int>("Yacht", "RailsColor", (M0) this.RailsColor);
        this.YachtType = (int) this.Config.GetValue<int>("Yacht", "YachtType", (M0) this.YachtType);
        this.Location = (int) this.Config.GetValue<int>("Yacht", "Location", (M0) this.Location);
        this.Lighting = (int) this.Config.GetValue<int>("Yacht", "Lighting", (M0) this.Lighting);
        this.LightingColor = (int) this.Config.GetValue<int>("Yacht", "LightingColor", (M0) this.LightingColor);
        this.H1 = (int) this.Config.GetValue<int>("Yacht", "HeliA", (M0) this.H1);
        this.H2 = (int) this.Config.GetValue<int>("Yacht", "HeliB", (M0) this.H2);
        this.CurrentFlag = (int) this.Config.GetValue<int>("Yacht", "CurrentFlag", (M0) this.CurrentFlag);
        this.SpawnDist = (int) this.Config.GetValue<int>("Yacht", "SpawnDist", (M0) this.SpawnDist);
        this.ShowDistWhenClose = (bool) this.Config.GetValue<bool>("Yacht", "ShowDistWhenClose", (M0) (this.ShowDistWhenClose ? 1 : 0));
        this.Penthouse_Style = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Style", (M0) this.Penthouse_Style);
        this.Penthouse_Media = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Media", (M0) this.Penthouse_Media);
        this.Penthouse_Spa = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Spa", (M0) this.Penthouse_Spa);
        this.Penthouse_Bar = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Bar", (M0) this.Penthouse_Bar);
        this.Penthouse_Colour = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Colour", (M0) this.Penthouse_Colour);
        this.Penthouse_Arcade = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Arcade", (M0) this.Penthouse_Arcade);
        this.Penthouse_BarLight = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_BarLight", (M0) this.Penthouse_BarLight);
        this.Penthouse_PokerDealer = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_PokerDealer", (M0) this.Penthouse_PokerDealer);
        this.Penthouse_ExtraBedroom = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_ExtraBedroom", (M0) this.Penthouse_ExtraBedroom);
        this.ArcadeFloodID = (int) this.Config.GetValue<int>("Arcade", "ArcadeFloodID", (M0) this.ArcadeFloodID);
        this.ArcadeStyle = (int) this.Config.GetValue<int>("Arcade", "ArcadeStyle", (M0) this.ArcadeStyle);
        this.MuralID = (int) this.Config.GetValue<int>("Arcade", "MuralID", (M0) this.MuralID);
        this.PushieID = (int) this.Config.GetValue<int>("Arcade", "PushieID", (M0) this.PushieID);
        this.NeonArtID = (int) this.Config.GetValue<int>("Arcade", "NeonArtID", (M0) this.NeonArtID);
        this.UnlockedDilllEquipment = (int) this.Config.GetValue<int>("Arcade", "UnlockedDilllEquipment", (M0) this.UnlockedDilllEquipment);
        this.UnlockedBreachingEquipment = (int) this.Config.GetValue<int>("Arcade", "UnlockedBreachingEquipment", (M0) this.UnlockedBreachingEquipment);
        this.UnlockedOutfitsEquipment = (int) this.Config.GetValue<int>("Arcade", "UnlockedOutfitsEquipment", (M0) this.UnlockedOutfitsEquipment);
        this.UnlockedPlansEquipment = (int) this.Config.GetValue<int>("Arcade", "UnlockedPlansEquipment", (M0) this.UnlockedPlansEquipment);
        this.UnlockedGarage = (int) this.Config.GetValue<int>("Arcade", "UnlockedGarage", (M0) this.UnlockedGarage);
        this.UnlockedGunlocker = (int) this.Config.GetValue<int>("Arcade", "UnlockedGunlocker", (M0) this.UnlockedGunlocker);
        this.Arcade1Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade1Ver", (M0) this.Arcade1Ver);
        this.Arcade2Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade2Ver", (M0) this.Arcade2Ver);
        this.Arcade3Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade3Ver", (M0) this.Arcade3Ver);
        this.Arcade4Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade4Ver", (M0) this.Arcade4Ver);
        this.Arcade5Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade5Ver", (M0) this.Arcade5Ver);
        this.Arcade6Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade6Ver", (M0) this.Arcade6Ver);
        this.Arcade7Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade7Ver", (M0) this.Arcade7Ver);
        this.Arcade8Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade8Ver", (M0) this.Arcade8Ver);
        this.Arcade9Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade9Ver", (M0) this.Arcade9Ver);
        this.Arcade10Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade10Ver", (M0) this.Arcade10Ver);
        this.Arcade11Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade11Ver", (M0) this.Arcade11Ver);
        this.Arcade12Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade12Ver", (M0) this.Arcade12Ver);
        this.Arcade13Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade13Ver", (M0) this.Arcade13Ver);
        this.Arcade14Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade14Ver", (M0) this.Arcade14Ver);
        this.Arcade15Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade15Ver", (M0) this.Arcade15Ver);
        this.Arcade16Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade16Ver", (M0) this.Arcade16Ver);
        this.Arcade17Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade17Ver", (M0) this.Arcade17Ver);
        this.Arcade18Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade18Ver", (M0) this.Arcade18Ver);
        this.Arcade19Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade19Ver", (M0) this.Arcade19Ver);
        this.Arcade20Ver = (int) this.Config.GetValue<int>("Arcade", "Arcade20Ver", (M0) this.Arcade20Ver);
        this.WorkGraphic = (string) this.Config.GetValue<string>("ArenaWorkshop", "WorkGraphic", (M0) this.WorkGraphic);
        this.WorkOff = (string) this.Config.GetValue<string>("ArenaWorkshop", "WorkOff", (M0) this.WorkOff);
        this.WorkMechanic = (string) this.Config.GetValue<string>("ArenaWorkshop", "WorkMechanic", (M0) this.WorkMechanic);
        this.WColor = (int) this.Config.GetValue<int>("ArenaWorkshop", "WColor", (M0) this.WColor);
        this.WColor1 = (int) this.Config.GetValue<int>("ArenaWorkshop", "WColor1", (M0) this.WColor1);
        this.WLiving = (bool) this.Config.GetValue<bool>("ArenaWorkshop", "WLiving", (M0) (this.WLiving ? 1 : 0));
        this.nopeds = (bool) this.Config.GetValue<bool>("ArenaWorkshop", "nopeds", (M0) (this.nopeds ? 1 : 0));
        this.TrinketsAndTrophiesEnabled = (bool) this.Config.GetValue<bool>("ArenaWorkshop", "TrinketsAndTrophiesEnabled", (M0) (this.TrinketsAndTrophiesEnabled ? 1 : 0));
        this.CurrentArenaPreset = (string) this.Config.GetValue<string>("ArenaPreset", "CurrentArenaPreset", (M0) this.CurrentArenaPreset);
        this.N_Style = (int) this.Config.GetValue<int>("Nightclub", "N_Style", (M0) this.N_Style);
        this.N_PodiumStyle = (int) this.Config.GetValue<int>("Nightclub", "N_PodiumStyle", (M0) this.N_PodiumStyle);
        this.N_Booze = (int) this.Config.GetValue<int>("Nightclub", "N_Booze", (M0) this.N_Booze);
        this.N_DJLights = (int) this.Config.GetValue<int>("Nightclub", "N_DJLights", (M0) this.N_DJLights);
        this.N_Lights = (int) this.Config.GetValue<int>("Nightclub", "N_Lights", (M0) this.N_Lights);
        this.N_LightsRig = (int) this.Config.GetValue<int>("Nightclub", "N_LightsRig", (M0) this.N_LightsRig);
        this.N_Upgrade = (int) this.Config.GetValue<int>("Nightclub", "N_Upgrade", (M0) this.N_Upgrade);
        this.N_ClubName = (int) this.Config.GetValue<int>("Nightclub", "N_ClubName", (M0) this.N_ClubName);
        this.N_trophies = (int) this.Config.GetValue<int>("Nightclub", "N_trophies", (M0) this.N_trophies);
        this.N_WorkLights = (int) this.Config.GetValue<int>("Nightclub", "N_WorkLights", (M0) this.N_WorkLights);
        this.N_DJ = (int) this.Config.GetValue<int>("Nightclub", "N_DJ", (M0) this.N_DJ);
        this.N_Clutter = (int) this.Config.GetValue<int>("Nightclub", "N_Clutter", (M0) this.N_Clutter);
        this.N_DryIce = (int) this.Config.GetValue<int>("Nightclub", "N_DryIce", (M0) this.N_DryIce);
        this.N_DelivTruck = (int) this.Config.GetValue<int>("Nightclub", "N_DelivTruck", (M0) this.N_DelivTruck);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: LoadInterior.ini Failed To Load.");
      }
    }

    public void PenthouseOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass412_0 displayClass4120 = new Class1.\u003C\u003Ec__DisplayClass412_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4120.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      displayClass4120.Cost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass4120.StyleCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass4120.BarCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass4120.SpaCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass4120.MediaCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass4120.ExtraB_Cost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass4120.PDcost = 0.0f;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) false);
      objectList1.Add((object) true);
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) "Blank");
      objectList2.Add((object) "Art Deco");
      objectList2.Add((object) "Art Nouveau");
      objectList2.Add((object) "Classical");
      objectList2.Add((object) "Traditional");
      objectList2.Add((object) "Imperial");
      objectList2.Add((object) "Pop");
      objectList2.Add((object) "Latin");
      objectList2.Add((object) "Natural");
      objectList2.Add((object) "Intricate");
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) "No Bar");
      objectList3.Add((object) "Bar Included");
      List<object> objectList4 = new List<object>();
      objectList4.Add((object) "No Spa");
      objectList4.Add((object) "Spa Included");
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) "No Media Room");
      objectList5.Add((object) "Media Room Included");
      List<object> objectList6 = new List<object>();
      objectList6.Add((object) "No Extra Room");
      objectList6.Add((object) "Extra Room Included");
      List<object> objectList7 = new List<object>();
      objectList7.Add((object) "Bar Light 1");
      objectList7.Add((object) "Bar Light 2");
      objectList7.Add((object) "Bar Light 3");
      List<object> objectList8 = new List<object>();
      objectList8.Add((object) "No Poker/Blackjack Dealer");
      objectList8.Add((object) "Poker/Blackjack Dealer Included");
      List<object> objectList9 = new List<object>();
      objectList9.Add((object) "Retro Arcade");
      objectList9.Add((object) "Modern Arcade");
      List<object> objectList10 = new List<object>();
      objectList10.Add((object) "Multicolor");
      objectList10.Add((object) "Timeless");
      objectList10.Add((object) "Vibrent");
      objectList10.Add((object) "Sharp");
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.DCRDLC, "Penthouse");
      this.GUIMenus.Add(uiMenu);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.S = new UIMenuListItem("Style : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.S);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.B = new UIMenuListItem("Bar : ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.B);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.Sp = new UIMenuListItem("Spa : ", objectList4, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.Sp);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.M = new UIMenuListItem("Media Room  : ", objectList5, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.M);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.EB = new UIMenuListItem("Extra Bedroom : ", objectList6, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.EB);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.BL = new UIMenuListItem("Bar Light : ", objectList7, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.BL);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.PD = new UIMenuListItem("Poker Dealer: ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.PD);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.A = new UIMenuListItem("Arcade : ", objectList9, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.A);
      // ISSUE: reference to a compiler-generated field
      displayClass4120.C = new UIMenuListItem("Colour : ", objectList10, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4120.C);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4120.Buy = new UIMenuItem("Buy " + displayClass4120.Cost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4120.Buy);
      UIMenuItem uiMenuItem = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem);
      UIMenuListItem uiMenuListItem = new UIMenuListItem("Preview Design : ", objectList1, 0);
      uiMenu.AddItem((UIMenuItem) uiMenuListItem);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass4120, __methodptr(\u003CPenthouseOptions\u003Eb__0)));
    }

    public void RefreshInteriorNightclub()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ba_int_placement_ba_interior_0_dlc_int_01_ba_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ba_int_placement_ba_interior_0_dlc_int_01_ba_milo_")
      });
      int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(-1604.664),
        InputArgument.op_Implicit(-3012.583),
        InputArgument.op_Implicit(-80.0)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_security_upgrade\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba\xFEFF_equipment_setup")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_Style02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_Style03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("int01_ba_style02_podium")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_style03_podium")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("int01_ba_lights_screen\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_Screen\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("I\xFEFFnt01_ba_bar_cont\xFEFFent\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_booze_0\xFEFF1\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_booze_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_booze_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_dj01\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int0\xFEFF1_ba_dj02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_dj03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_dj04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_01_Lights_01\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_01_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_01_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_01_Lights_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_02_Lights_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_02_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_02_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_02_Lights_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_03_Lights_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_03_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_03_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_03_Lights_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_04_Lights_01\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_04_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_04_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("DJ_04_Lights_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("light_rigs_off")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_lightgrid_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_Clutter")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_equipment_upgrade")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_01\xFEFF\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_05")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_06")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_07")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_08")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_clubname_09")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_dry_ice")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_deliverytruck")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy05")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy07")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy09")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy08")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy11")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy10\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trophy02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_trad_lights\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Int01_ba_Worklamps\xFEFF")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
      Script.Wait(500);
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
      int num2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(-1604.664),
        InputArgument.op_Implicit(-3012.583),
        InputArgument.op_Implicit(-80.0)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit("int01_ba_style01_podium\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit("int01_ba_style01_podium")
      });
      int num3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(-1604.664),
        InputArgument.op_Implicit(-3012.583),
        InputArgument.op_Implicit(-80.0)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("int01_ba_lights_screen\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("Int01_ba_Screen\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("I\xFEFFnt01_ba_bar_cont\xFEFFent\xFEFF")
      });
      if (this.N_ClubName >= 0 && this.N_ClubName <= 8)
      {
        if (this.N_ClubName == 9)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_01\xFEFF")
          });
        if (this.N_ClubName == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_02")
          });
        if (this.N_ClubName == 2)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_03")
          });
        if (this.N_ClubName == 3)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_04")
          });
        if (this.N_ClubName == 4)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_05")
          });
        if (this.N_ClubName == 5)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_06")
          });
        if (this.N_ClubName == 6)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_07")
          });
        if (this.N_ClubName == 7)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_08")
          });
        if (this.N_ClubName == 8)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num3),
            InputArgument.op_Implicit("Int01_ba_clubname_09")
          });
      }
      if (this.N_Upgrade == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_security_upgrade\xFEFF")
        });
      if (this.N_Upgrade == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba\xFEFF_equipment_setup")
        });
      if (this.N_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("int01_ba_style02")
        });
      if (this.N_Style == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("int01_ba_style03")
        });
      if (this.N_Style == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("int01_ba_style01")
        });
      if (this.N_PodiumStyle == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("int01_ba_style02_podium")
        });
      if (this.N_PodiumStyle == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_style03_podium")
        });
      if (this.N_PodiumStyle == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_style01_podium")
        });
      if (this.N_Booze == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_booze_0\xFEFF1\xFEFF")
        });
      if (this.N_Booze == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_booze_02")
        });
      if (this.N_Booze == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_booze_03")
        });
      if (this.N_DJ == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_dj01\xFEFF")
        });
      if (this.N_DJ == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int0\xFEFF1_ba_dj02")
        });
      if (this.N_DJ == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_dj03")
        });
      if (this.N_DJ == 3)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_dj04")
        });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_01_Lights_01\xFEFF\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_01_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_01_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_01_Lights_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_02_Lights_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_02_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_02_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_02_Lights_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_03_Lights_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_03_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_03_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_03_Lights_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_04_Lights_01\xFEFF")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_04_Lights_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_04_Lights_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("DJ_04_Lights_04")
      });
      if (this.N_DJ == 0 && this.N_DJLights == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_01_Lights_01\xFEFF\xFEFF")
        });
      if (this.N_DJ == 0 && this.N_DJLights == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_01_Lights_02")
        });
      if (this.N_DJ == 0 && this.N_DJLights == 3)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_01_Lights_03")
        });
      if (this.N_DJ == 0 && this.N_DJLights == 4)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_01_Lights_04")
        });
      if (this.N_DJ == 1 && this.N_DJLights == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_02_Lights_01")
        });
      if (this.N_DJ == 1 && this.N_DJLights == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_02_Lights_02")
        });
      if (this.N_DJ == 1 && this.N_DJLights == 3)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_02_Lights_03")
        });
      if (this.N_DJ == 1 && this.N_DJLights == 4)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_02_Lights_04")
        });
      if (this.N_DJ == 2 && this.N_DJLights == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_03_Lights_01")
        });
      if (this.N_DJ == 2 && this.N_DJLights == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_03_Lights_02")
        });
      if (this.N_DJ == 2 && this.N_DJLights == 3)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_03_Lights_03")
        });
      if (this.N_DJ == 2 && this.N_DJLights == 4)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_03_Lights_04")
        });
      if (this.N_DJ == 3 && this.N_DJLights == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_04_Lights_01\xFEFF")
        });
      if (this.N_DJ == 3 && this.N_DJLights == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_04_Lights_02")
        });
      if (this.N_DJ == 3 && this.N_DJLights == 3)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_04_Lights_03")
        });
      if (this.N_DJ == 3 && this.N_DJLights == 4)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("DJ_04_Lights_04")
        });
      if (this.N_LightsRig == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("light_rigs_off")
        });
      if (this.N_LightsRig == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_lightgrid_01")
        });
      if (this.N_Clutter == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_Clutter")
        });
      if (this.N_Upgrade == 3)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_equipment_upgrade")
        });
      if (this.N_DryIce == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_dry_ice")
        });
      if (this.N_DelivTruck == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_deliverytruck")
        });
      if (this.N_trophies >= 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy04")
        });
      if (this.N_trophies >= 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy05")
        });
      if (this.N_trophies >= 3)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy07")
        });
      if (this.N_trophies >= 4)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy09")
        });
      if (this.N_trophies >= 5)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy08")
        });
      if (this.N_trophies >= 6)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy11")
        });
      if (this.N_trophies >= 7)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy10\xFEFF")
        });
      if (this.N_trophies >= 8)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy03")
        });
      if (this.N_trophies >= 9)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy01")
        });
      if (this.N_trophies >= 9)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trophy02")
        });
      if (this.N_WorkLights == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_trad_lights\xFEFF")
        });
      if (this.N_WorkLights == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("Int01_ba_Worklamps\xFEFF")
        });
      if ((uint) this.N_Style > 0U)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit("int01_ba_style01")
        });
      if ((uint) this.N_PodiumStyle <= 0U)
        return;
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        InputArgument.op_Implicit("Int01_ba_style01_podium")
      });
    }

    private void SetupWorkshop()
    {
      this.Workshop = new List<string>();
      this.Workshop.Add("Set_Int_MOD_BOOTH_DEF");
      this.Workshop.Add("Set_Int_MOD_BOOTH_BEN");
      this.Workshop.Add("Set_Int_MOD_BOOTH_WP");
      this.Workshop.Add("Set_Int_MOD_BOOTH_COMBO");
      this.Workshop.Add("Set_Int_MOD_BEDROOM_BLOCKER");
      this.Workshop.Add("Set_Int_MOD_CONSTRUCTION_01");
      this.Workshop.Add("Set_Int_MOD_CONSTRUCTION_02");
      this.Workshop.Add("Set_Int_MOD_CONSTRUCTION_03");
      this.Workshop.Add("SET_OFFICE_STANDARD");
      this.Workshop.Add("SET_OFFICE_INDUSTRIAL");
      this.Workshop.Add("SET_OFFICE_HITECH");
      this.Workshop.Add("Set_Mod1_Style_01");
      this.Workshop.Add("Set_Mod1_Style_02");
      this.Workshop.Add("Set_Mod1_Style_03");
      this.Workshop.Add("Set_Mod1_Style_04");
      this.Workshop.Add("Set_Mod1_Style_05");
      this.Workshop.Add("Set_Mod1_Style_06");
      this.Workshop.Add("Set_Mod1_Style_07");
      this.Workshop.Add("Set_Mod1_Style_08");
      this.Workshop.Add("Set_Mod1_Style_09");
      this.Workshop.Add("set_arena_peds");
      this.Workshop.Add("set_arena_no peds");
    }

    public void Enableinterior()
    {
      int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(205f),
        InputArgument.op_Implicit(5180f),
        InputArgument.op_Implicit(-90f)
      });
      for (int index = 0; index < this.Workshop.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit(this.Workshop[index])
        });
      for (int index = 0; index < this.TrinketsAndTrophies.Count; ++index)
      {
        if (this.TrinketsAndTrophiesEnabled)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit(this.TrinketsAndTrophies[index])
          });
        else if (!this.TrinketsAndTrophiesEnabled)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit(this.TrinketsAndTrophies[index])
          });
      }
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Int_MOD_SHELL_DEF")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(this.WorkGraphic)
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(this.WorkOff)
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(this.WorkMechanic)
      });
      if (!this.WLiving)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Int_MOD_BEDROOM_BLOCKER")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Int_MOD_SHELL_DEF"),
        InputArgument.op_Implicit(this.WColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(this.WorkOff),
        InputArgument.op_Implicit(this.WColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(this.WorkMechanic),
        InputArgument.op_Implicit(this.WColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(this.WorkGraphic),
        InputArgument.op_Implicit(this.WColor)
      });
      if (!this.nopeds)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("set_arena_no peds")
        });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_mod_2")
      });
      int num2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(170f),
        InputArgument.op_Implicit(5190f),
        InputArgument.op_Implicit(10f)
      });
      for (int index = 0; index < 9; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(this.WorkGraphic)
        });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit("Set_Int_MOD2_B2")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit("Set_Int_MOD2_B_TINT")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit("Set_Int_MOD2_B1")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit(this.WorkGraphic)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit("Set_Int_MOD2_B_Tint"),
        InputArgument.op_Implicit(this.WColor1)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit("Set_Int_MOD2_B1"),
        InputArgument.op_Implicit(this.WColor1)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit(this.WorkGraphic),
        InputArgument.op_Implicit(this.WColor1)
      });
    }

    public void ReloadInterior()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_mod")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_Mod_2")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_mod")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_Mod_2")
      });
      this.Enableinterior();
    }

    public void SaveInterior()
    {
      this.Config.SetValue<string>("Facility", "FacilityGraphic", (M0) this.FacilityGraphic);
      this.Config.SetValue<string>("Facility", "FacilityOrbitalCannon", (M0) this.FacilityOrbitalCannon);
      this.Config.SetValue<string>("Facility", "FacilitySecurityRoom", (M0) this.FacilitySecurityRoom);
      this.Config.SetValue<string>("Facility", "FacilityLounge", (M0) this.FacilityLounge);
      this.Config.SetValue<string>("Facility", "FacilitySleepingQuarters", (M0) this.FacilitySleepingQuarters);
      this.Config.SetValue<int>("Facility", "FacilityShellColor", (M0) this.FacilityShellColor);
      this.Config.SetValue<int>("Facility", "FacilityGraphicColor", (M0) this.FacilityGraphicColor);
      this.Config.SetValue<int>("Facility", "FacilityOrbitalCannonColor", (M0) this.FacilityOrbitalCannonColor);
      this.Config.SetValue<int>("Facility", "FacilitySecurityRoomColor", (M0) this.FacilitySecurityRoomColor);
      this.Config.SetValue<int>("Facility", "FacilityLoungeColor", (M0) this.FacilityLoungeColor);
      this.Config.SetValue<int>("Facility", "FacilitySleepingQuartersColor", (M0) this.FacilitySleepingQuartersColor);
      this.Config.Save();
      this.LoadIniFile("scripts//EnableAllInteriors.ini");
    }

    public void RefreshInterior()
    {
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(462.09f),
        InputArgument.op_Implicit(4820.42f),
        InputArgument.op_Implicit(-59f)
      });
      foreach (object obj in new List<object>()
      {
        (object) "set_int_02_decal_01",
        (object) "set_int_02_decal_02",
        (object) "set_int_02_decal_03",
        (object) "set_int_02_decal_04",
        (object) "set_int_02_decal_05",
        (object) "set_int_02_decal_06",
        (object) "set_int_02_decal_07",
        (object) "set_int_02_decal_08",
        (object) "set_int_02_decal_09",
        (object) "set_int_02_no_cannon",
        (object) "set_int_02_cannon",
        (object) "set_int_02_no_security",
        (object) "set_int_02_no_security",
        (object) "set_int_02_lounge1",
        (object) "set_int_02_lounge2",
        (object) "set_int_02_lounge3",
        (object) "set_int_02_no_sleep",
        (object) "set_int_02_sleep",
        (object) "set_int_02_sleep2",
        (object) "set_int_02_sleep3"
      })
      {
        // ISSUE: reference to a compiler-generated field
        if (Class1.\u003C\u003Eo__418.\u003C\u003Ep__0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Class1.\u003C\u003Eo__418.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (string), typeof (Class1)));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str = Class1.\u003C\u003Eo__418.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__418.\u003C\u003Ep__0, obj);
        if (str != null)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit(str)
          });
      }
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      Script.Wait(1);
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_33_x17dlc_int_02_milo_")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_int_02_shell")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilityGraphic)
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilityOrbitalCannon)
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilitySecurityRoom)
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilityLounge)
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilitySleepingQuarters)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_int_02_shell"),
        InputArgument.op_Implicit(this.FacilityShellColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilityGraphic),
        InputArgument.op_Implicit(this.FacilityGraphicColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilityOrbitalCannon),
        InputArgument.op_Implicit(this.FacilityOrbitalCannonColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilitySecurityRoom),
        InputArgument.op_Implicit(this.FacilitySecurityRoomColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilityLounge),
        InputArgument.op_Implicit(this.FacilityLoungeColor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit(this.FacilitySleepingQuarters),
        InputArgument.op_Implicit(this.FacilitySleepingQuartersColor)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
    }

    public void UpdateInterior() => Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
    {
      InputArgument.op_Implicit(260353)
    });

    private void ChangeColor()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass420_0 displayClass4200 = new Class1.\u003C\u003Ec__DisplayClass420_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4200.\u003C\u003E4__this = this;
      List<object> objectList = new List<object>();
      for (int index = 0; index < this.MaxColors; ++index)
        objectList.Add((object) index);
      UIMenu uiMenu1 = this.Woredrobepool.AddSubMenu(this.Hanger1, "Floor Decal Color");
      this.GUIMenus.Add(uiMenu1);
      UIMenuItem uiMenuItem1 = new UIMenuItem("Color");
      // ISSUE: reference to a compiler-generated field
      displayClass4200.list2 = new UIMenuListItem("Color", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass4200.list2);
      // ISSUE: reference to a compiler-generated field
      displayClass4200.getWeapon = new UIMenuItem("Change Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4200.getWeapon);
      UIMenu uiMenu2 = this.Woredrobepool.AddSubMenu(this.Hanger1, "Shell Color");
      this.GUIMenus.Add(uiMenu2);
      UIMenuItem uiMenuItem2 = new UIMenuItem("Color");
      // ISSUE: reference to a compiler-generated field
      displayClass4200.list3 = new UIMenuListItem("Color", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4200.list3);
      // ISSUE: reference to a compiler-generated field
      displayClass4200.getWeapon2 = new UIMenuItem("Change Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass4200.getWeapon2);
      UIMenu uiMenu3 = this.Woredrobepool.AddSubMenu(this.Hanger1, "Bedroom Color");
      this.GUIMenus.Add(uiMenu3);
      UIMenuItem uiMenuItem3 = new UIMenuItem("Color");
      // ISSUE: reference to a compiler-generated field
      displayClass4200.list4 = new UIMenuListItem("Color", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4200.list4);
      // ISSUE: reference to a compiler-generated field
      displayClass4200.getWeapon3 = new UIMenuItem("Change Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4200.getWeapon3);
      UIMenu uiMenu4 = this.Woredrobepool.AddSubMenu(this.Hanger1, "Crane Color");
      this.GUIMenus.Add(uiMenu4);
      UIMenuItem uiMenuItem4 = new UIMenuItem("Color");
      // ISSUE: reference to a compiler-generated field
      displayClass4200.list5 = new UIMenuListItem("Color", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem((UIMenuItem) displayClass4200.list5);
      // ISSUE: reference to a compiler-generated field
      displayClass4200.getWeapon4 = new UIMenuItem("Change Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass4200.getWeapon4);
      UIMenu uiMenu5 = this.Woredrobepool.AddSubMenu(this.Hanger1, "Workshop Color");
      this.GUIMenus.Add(uiMenu5);
      UIMenuItem uiMenuItem5 = new UIMenuItem("Color");
      // ISSUE: reference to a compiler-generated field
      displayClass4200.list6 = new UIMenuListItem("Color", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem((UIMenuItem) displayClass4200.list6);
      // ISSUE: reference to a compiler-generated field
      displayClass4200.getWeapon5 = new UIMenuItem("Change Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass4200.getWeapon5);
      UIMenu uiMenu6 = this.Woredrobepool.AddSubMenu(this.Hanger1, "Light Tint Color");
      this.GUIMenus.Add(uiMenu6);
      UIMenuItem uiMenuItem6 = new UIMenuItem("Color");
      // ISSUE: reference to a compiler-generated field
      displayClass4200.list7 = new UIMenuListItem("Color", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu6.AddItem((UIMenuItem) displayClass4200.list7);
      // ISSUE: reference to a compiler-generated field
      displayClass4200.getWeapon6 = new UIMenuItem("Change Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu6.AddItem(displayClass4200.getWeapon6);
      // ISSUE: method pointer
      uiMenu6.add_OnItemSelect(new ItemSelectEvent((object) displayClass4200, __methodptr(\u003CChangeColor\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu5.add_OnItemSelect(new ItemSelectEvent((object) displayClass4200, __methodptr(\u003CChangeColor\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu4.add_OnItemSelect(new ItemSelectEvent((object) displayClass4200, __methodptr(\u003CChangeColor\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass4200, __methodptr(\u003CChangeColor\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass4200, __methodptr(\u003CChangeColor\u003Eb__4)));
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass4200, __methodptr(\u003CChangeColor\u003Eb__5)));
    }

    private void SetupCustomizations()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass421_0 displayClass4210 = new Class1.\u003C\u003Ec__DisplayClass421_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4210.\u003C\u003E4__this = this;
      UIMenu uiMenu1 = this.Woredrobepool.AddSubMenu(this.Hanger2, "Hanger Lighting");
      this.GUIMenus.Add(uiMenu1);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.LightingA = new UIMenuItem("Lighting A");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4210.LightingA);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.LightingB = new UIMenuItem("Lighting B");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4210.LightingB);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.LightingC = new UIMenuItem("Lighting C");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4210.LightingC);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.LightingD = new UIMenuItem("Lighting D");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4210.LightingD);
      UIMenu uiMenu2 = this.Woredrobepool.AddSubMenu(this.Hanger2, "Floor");
      this.GUIMenus.Add(uiMenu2);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.FloorA = new UIMenuItem("Floor A");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass4210.FloorA);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.FloorB = new UIMenuItem("Floor B");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass4210.FloorB);
      UIMenu uiMenu3 = this.Woredrobepool.AddSubMenu(this.Hanger2, "Floor Decal");
      this.GUIMenus.Add(uiMenu3);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalA = new UIMenuItem("Decal A");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalA);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalB = new UIMenuItem("Decal B");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalB);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalC = new UIMenuItem("Decal C");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalC);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalD = new UIMenuItem("Decal D");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalD);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalE = new UIMenuItem("Decal E");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalE);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalF = new UIMenuItem("Decal F");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalF);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalG = new UIMenuItem("Decal G");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalG);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalH = new UIMenuItem("Decal H");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalH);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.DecalI = new UIMenuItem("Decal I");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4210.DecalI);
      UIMenu uiMenu4 = this.Woredrobepool.AddSubMenu(this.Hanger2, "Office Style");
      this.GUIMenus.Add(uiMenu4);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.basicO = new UIMenuItem("Basic");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass4210.basicO);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.TraditionalO = new UIMenuItem("Traditional");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass4210.TraditionalO);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.ModernO = new UIMenuItem("Modern");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass4210.ModernO);
      UIMenu uiMenu5 = this.Woredrobepool.AddSubMenu(this.Hanger2, "Living Quarters Style");
      this.GUIMenus.Add(uiMenu5);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.basicL = new UIMenuItem("Clutter");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass4210.basicL);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.TraditionalL = new UIMenuItem("Traditional");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass4210.TraditionalL);
      // ISSUE: reference to a compiler-generated field
      displayClass4210.ModernL = new UIMenuItem("Modern");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass4210.ModernL);
      // ISSUE: method pointer
      uiMenu5.add_OnItemSelect(new ItemSelectEvent((object) displayClass4210, __methodptr(\u003CSetupCustomizations\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu4.add_OnItemSelect(new ItemSelectEvent((object) displayClass4210, __methodptr(\u003CSetupCustomizations\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass4210, __methodptr(\u003CSetupCustomizations\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass4210, __methodptr(\u003CSetupCustomizations\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass4210, __methodptr(\u003CSetupCustomizations\u003Eb__4)));
    }

    public void SetupInterior()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass422_0 displayClass4220 = new Class1.\u003C\u003Ec__DisplayClass422_0()
      {
        \u003C\u003E4__this = this,
        GaragesL = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass4220.GaragesL.Add((object) "GarageA");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.GaragesL.Add((object) "GarageB");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.GaragesL.Add((object) "GarageC");
      Class1.Garage = "GarageA";
      // ISSUE: reference to a compiler-generated field
      displayClass4220.MazeBank1 = 0;
      // ISSUE: reference to a compiler-generated field
      displayClass4220.MazeBank2 = 0;
      // ISSUE: reference to a compiler-generated field
      displayClass4220.MazeBank3 = 0;
      // ISSUE: reference to a compiler-generated field
      displayClass4220.MazeBank4 = 0;
      if (Class1.Garage.Equals("GarageA"))
      {
        Class1.MazeBank = "imp_dt1_11_cargarage_a";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBank)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-84.2193),
          InputArgument.op_Implicit(-823.0851),
          InputArgument.op_Implicit(221.0)
        });
      }
      if (Class1.Garage.Equals("GarageB"))
      {
        Class1.MazeBank = "imp_dt1_11_cargarage_b";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBank)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-69.8627),
          InputArgument.op_Implicit(-824.7498),
          InputArgument.op_Implicit(221.0)
        });
      }
      if (Class1.Garage.Equals("GarageC"))
      {
        Class1.MazeBank = "imp_dt1_11_cargarage_c";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBank)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-80.4318),
          InputArgument.op_Implicit(-813.2536),
          InputArgument.op_Implicit(221.0)
        });
      }
      if (Class1.Garage.Equals("GarageA"))
      {
        Class1.MazeBankWest = "imp_sm_15_cargarage_a";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBankWest)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1388.84),
          InputArgument.op_Implicit(-478.7402),
          InputArgument.op_Implicit(56.1)
        });
      }
      if (Class1.Garage.Equals("GarageB"))
      {
        Class1.MazeBankWest = "imp_sm_15_cargarage_b";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBankWest)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1388.86),
          InputArgument.op_Implicit(-478.7574),
          InputArgument.op_Implicit(48.1)
        });
      }
      if (Class1.Garage.Equals("GarageC"))
      {
        Class1.MazeBankWest = "imp_sm_15_cargarage_c";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBankWest)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1374.682),
          InputArgument.op_Implicit(-474.3586),
          InputArgument.op_Implicit(56.1)
        });
      }
      if (Class1.Garage.Equals("GarageA"))
      {
        Class1.Lombank = "imp_sm_13_cargarage_a";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Lombank)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1581.112),
          InputArgument.op_Implicit(-567.245),
          InputArgument.op_Implicit(85.5)
        });
      }
      if (Class1.Garage.Equals("GarageB"))
      {
        Class1.Lombank = "imp_sm_13_cargarage_b";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Lombank)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1568.739),
          InputArgument.op_Implicit(-562.0455),
          InputArgument.op_Implicit(85.5)
        });
      }
      if (Class1.Garage.Equals("GarageC"))
      {
        Class1.Lombank = "imp_sm_13_cargarage_c";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Lombank)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1563.557),
          InputArgument.op_Implicit(-574.4314),
          InputArgument.op_Implicit(85.5)
        });
      }
      if (Class1.Garage.Equals("GarageA"))
      {
        Class1.Arcadius = "imp_dt1_02_cargarage_a";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Arcadius)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-191.0133),
          InputArgument.op_Implicit(-579.1428),
          InputArgument.op_Implicit(135.0)
        });
      }
      if (Class1.Garage.Equals("GarageB"))
      {
        Class1.Arcadius = "imp_dt1_02_cargarage_b";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Arcadius)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-117.4989),
          InputArgument.op_Implicit(-568.1132),
          InputArgument.op_Implicit(135.0)
        });
      }
      if (Class1.Garage.Equals("GarageC"))
      {
        Class1.Arcadius = "imp_dt1_02_cargarage_c";
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Arcadius)
        });
        // ISSUE: reference to a compiler-generated field
        displayClass4220.MazeBank4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-136.078),
          InputArgument.op_Implicit(-630.1852),
          InputArgument.op_Implicit(135.0)
        });
      }
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.ExecutiveDLC, "CEO - Garage");
      this.GUIMenus.Add(uiMenu);
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Decor = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Decor.Add((object) "garage_decor_01");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Decor.Add((object) "garage_decor_02");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Decor.Add((object) "garage_decor_03");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Decor.Add((object) "garage_decor_04");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option01");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option02");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option03");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option04");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option05");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option06");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option07");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option08");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.LIGHTING.Add((object) "lighting_option09");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style01_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style02_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style03_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style04_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style05_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style06_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style07_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style08_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style09_n1");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style01_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style02_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style03_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style04_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style05_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style06_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style07_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style08_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style09_n2");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style01_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style02_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style03_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style04_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style05_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style06_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style07_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style08_n3");
      // ISSUE: reference to a compiler-generated field
      displayClass4220.Numbering.Add((object) "numbering_style09_n3");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4220.G = new UIMenuListItem("Garage : ", displayClass4220.GaragesL, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4220.G);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4220.D = new UIMenuListItem("Decor : ", displayClass4220.Decor, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4220.D);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4220.L = new UIMenuListItem("Lighting : ", displayClass4220.LIGHTING, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4220.L);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4220.N = new UIMenuListItem("Numbering : ", displayClass4220.Numbering, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4220.N);
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass4220, __methodptr(\u003CSetupInterior\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass4220, __methodptr(\u003CSetupInterior\u003Eb__1)));
    }

    public void CustomizeBikerClubhouses()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass423_0 displayClass4230 = new Class1.\u003C\u003Ec__DisplayClass423_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4230.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) true);
      objectList1.Add((object) false);
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) "Option 1 ");
      objectList2.Add((object) "Option 2 ");
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) "Option 1 ");
      objectList3.Add((object) "Option 2 ");
      objectList3.Add((object) "Option 3 ");
      objectList3.Add((object) "Option 4 ");
      objectList3.Add((object) "Option 5 ");
      objectList3.Add((object) "Option 6 ");
      objectList3.Add((object) "Option 7 ");
      objectList3.Add((object) "Option 8 ");
      objectList3.Add((object) "Option 9 ");
      UIMenu uiMenu1 = this.Woredrobepool.AddSubMenu(this.BikerDLC, "Clubhouse Customization");
      this.GUIMenus.Add(uiMenu1);
      UIMenu uiMenu2 = this.Woredrobepool.AddSubMenu(uiMenu1, "1 Floor Clubhouse");
      this.GUIMenus.Add(uiMenu2);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.ModBooth1 = new UIMenuListItem("Mod Booth Active : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4230.ModBooth1);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.decorativeType1 = new UIMenuListItem("Decorative Type: ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4230.decorativeType1);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.furnishingsType1 = new UIMenuListItem("Furnishings Type: ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4230.furnishingsType1);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.wallsType1 = new UIMenuListItem("Walls Type: ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4230.wallsType1);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.muralType1 = new UIMenuListItem("Mural Type: ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4230.muralType1);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.GunlockerType1 = new UIMenuListItem("Gunlocker Active: ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4230.GunlockerType1);
      // ISSUE: method pointer
      uiMenu2.add_OnListChange(new ListChangedEvent((object) displayClass4230, __methodptr(\u003CCustomizeBikerClubhouses\u003Eb__0)));
      UIMenu uiMenu3 = this.Woredrobepool.AddSubMenu(uiMenu1, "2 Floor Clubhouse");
      this.GUIMenus.Add(uiMenu3);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.ModBooth2 = new UIMenuListItem("Mod Booth Active : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4230.ModBooth2);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.decorativeType2 = new UIMenuListItem("Decorative Type: ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4230.decorativeType2);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.furnishingsType2 = new UIMenuListItem("Furnishings Type: ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4230.furnishingsType2);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.wallsType2 = new UIMenuListItem("Walls Type: ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4230.wallsType2);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.muralType2 = new UIMenuListItem("Mural Type: ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4230.muralType2);
      // ISSUE: reference to a compiler-generated field
      displayClass4230.GunlockerType2 = new UIMenuListItem("Gunlocker Active: ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4230.GunlockerType2);
      // ISSUE: method pointer
      uiMenu3.add_OnListChange(new ListChangedEvent((object) displayClass4230, __methodptr(\u003CCustomizeBikerClubhouses\u003Eb__1)));
    }

    public void SetupInterior2()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass424_0 displayClass4240 = new Class1.\u003C\u003Ec__DisplayClass424_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4240.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.ExecutiveDLC, "CEO - Warehouse");
      this.GUIMenus.Add(uiMenu);
      // ISSUE: reference to a compiler-generated field
      displayClass4240.A = new UIMenuItem("Basic");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4240.A);
      // ISSUE: reference to a compiler-generated field
      displayClass4240.B = new UIMenuItem("Urban");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4240.B);
      // ISSUE: reference to a compiler-generated field
      displayClass4240.C = new UIMenuItem("Branded");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4240.C);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass4240, __methodptr(\u003CSetupInterior2\u003Eb__0)));
    }

    private void SetupT_T()
    {
      this.TrinketsAndTrophies = new List<string>();
      this.TrinketsAndTrophies.Add("SET_XMAS_DECORATIONS");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_CAREER");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_SCORE");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_WAGEWORKER");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_TIME_SERVED");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_GOT_ONE");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_OUTTA_HERE");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_SHUNT");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_BOBBY");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_KILLED");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_CROWD");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_DUCK");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_BANDITO");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_SPINNER");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_LENS");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_WAR");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_UNSTOPPABLE");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_CONTACT");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_TOWER");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_STEP");
      this.TrinketsAndTrophies.Add("Set_Int_MOD_TROPHY_PEGASUS");
      this.TrinketsAndTrophies.Add("SET_BANDITO_RC");
      this.TrinketsAndTrophies.Add("SET_OFFICE_TRINKET_07");
      this.TrinketsAndTrophies.Add("SET_OFFICE_TRINKET_06");
      this.TrinketsAndTrophies.Add("SET_OFFICE_TRINKET_03");
      this.TrinketsAndTrophies.Add("SET_OFFICE_TRINKET_04");
      this.TrinketsAndTrophies.Add("SET_OFFICE_TRINKET_02");
    }

    private void SetupB1Garage()
    {
    }

    public void AddInteriorBlips()
    {
      this.EAIBLIPS.Clear();
      using (List<Blip>.Enumerator enumerator = this.InteriorBlips.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Blip current = enumerator.Current;
          if (Blip.op_Inequality(current, (Blip) null))
            current.Remove();
        }
      }
      this.MarkerPos.Clear();
      this.EnterPos.Clear();
      this.ExitPos.Clear();
      this.MarkerPos.Add(new Vector3(-1394.4f, -3267.2f, 13f));
      this.EnterPos.Add(new Vector3(-1394.4f, -3267.2f, 13f));
      this.ExitPos.Add(new Vector3(-1266.64f, -2961.4f, -48f));
      this.MarkerPos.Add(new Vector3(-166.5f, -2369.035f, 20f));
      this.MarkerPos.Add(new Vector3(-254.19f, -2027.2f, 29f));
      this.MarkerPos.Add(new Vector3(-14.09f, -1442.26f, 31f));
      this.MarkerPos.Add(new Vector3(-60.5f, -1093.6f, 26f));
      this.MarkerPos.Add(new Vector3(-632.6f, -238.6f, 38f));
      this.MarkerPos.Add(new Vector3(-1045.3f, -230.3f, 39f));
      this.MarkerPos.Add(new Vector3(718.1f, -975.7f, 24f));
      this.MarkerPos.Add(new Vector3(1274.6f, -1720.9f, 54f));
      this.MarkerPos.Add(new Vector3(1083.07f, -1975.1f, 31f));
      this.MarkerPos.Add(new Vector3(2087.15f, 1761.8f, 102f));
      this.EnterPos.Add(new Vector3(2087.15f, 1761.8f, 102.8f));
      this.ExitPos.Add(new Vector3(483.8f, 4809.7f, -59.5f));
      this.MarkerPos.Add(new Vector3(2488.6f, 3162.6f, 48f));
      this.EnterPos.Add(new Vector3(2488.6f, 3162.6f, 48f));
      this.ExitPos.Add(new Vector3(891.3f, -3245.7f, -99.5f));
      this.MarkerPos.Add(new Vector3(-243.1f, 6208.8f, 31f));
      this.EnterPos.Add(new Vector3(-243.1f, 6208.8f, 31f));
      this.ExitPos.Add(new Vector3(2737.9f, -374.1f, -49f));
      this.MarkerPos.Add(new Vector3(925.9f, 47.5f, 80f));
      this.EnterPos.Add(new Vector3(925.9f, 47.5f, 80f));
      this.ExitPos.Add(new Vector3(2468.8f, -287.4f, -59f));
      this.EnterPos.Add(new Vector3(924.6f, 45.4f, 80f));
      this.ExitPos.Add(new Vector3(1089.7f, 205.9f, -50f));
      this.MarkerPos.Add(new Vector3(-121.4f, -1290.5f, 28.5f));
      this.EnterPos.Add(new Vector3(-121.4f, -1290.5f, 28.5f));
      this.ExitPos.Add(new Vector3(-1569.2f, -3017.3f, -75f));
      this.MarkerPos.Add(new Vector3(-70.8f, -800.4f, 43.6f));
      this.EnterPos.Add(new Vector3(-70.8f, -800.4f, 43.6f));
      this.ExitPos.Add(new Vector3(-75.3f, -823.6f, 242f));
      this.MarkerPos.Add(new Vector3(-118.3f, -608.4f, 35.6f));
      this.EnterPos.Add(new Vector3(-118.3f, -608.4f, 35.6f));
      this.ExitPos.Add(new Vector3(-140.15f, -624.4f, 167.8f));
      this.MarkerPos.Add(new Vector3(-1370.8f, -503.6f, 32.5f));
      this.EnterPos.Add(new Vector3(-1370.8f, -503.6f, 32.5f));
      this.ExitPos.Add(new Vector3(-1388.9f, -478.9f, 71.5f));
      this.MarkerPos.Add(new Vector3(-1582.4f, -556.6f, 33.9f));
      this.EnterPos.Add(new Vector3(-1582.4f, -556.6f, 33.9f));
      this.ExitPos.Add(new Vector3(-1576.7f, -567.08f, 107.5f));
      this.MarkerPos.Add(new Vector3(2049.9f, 2949.5f, 46.7f));
      this.EnterPos.Add(new Vector3(2049.9f, 2949.5f, 46.7f));
      this.ExitPos.Add(new Vector3(2155.11f, 2920.9f, -63f));
      this.MarkerPos.Add(new Vector3(2331.7f, 2576.1f, 45.6f));
      this.MarkerPos.Add(new Vector3(-564.2f, 275.5f, 82f));
      this.MarkerPos.Add(new Vector3(2477.26f, -402.02f, 93.5f));
      this.EnterPos.Add(new Vector3(2477.26f, -402.02f, 93.5f));
      this.ExitPos.Add(new Vector3(2154.7f, 2921.04f, -82f));
      this.MarkerPos.Add(new Vector3(-361.36f, 4827.09f, 142.5f));
      this.EnterPos.Add(new Vector3(-361.36f, 4827.09f, 142.5f));
      this.ExitPos.Add(new Vector3(1256.1f, 4799.07f, -40.5f));
      this.MarkerPos.Add(new Vector3(-1898.1f, -572.5f, 11f));
      this.EnterPos.Add(new Vector3(-1898.1f, -572.5f, 11f));
      this.ExitPos.Add(new Vector3(-1902.3f, -572.6f, 18.5f));
      this.MarkerPos.Add(new Vector3(240.9f, -1379.4f, 32.8f));
      this.EnterPos.Add(new Vector3(240.9f, -1379.4f, 32.8f));
      this.ExitPos.Add(new Vector3(253.9f, -1372.3f, 29f));
      this.MarkerPos.Add(new Vector3(961.6f, -2185.2f, 29f));
      this.MarkerPos.Add(new Vector3(-70.8f, 6266.3f, 30f));
      this.MarkerPos.Add(new Vector3(1395.06f, 1141.7f, 113.4f));
      this.EnterPos.Add(new Vector3(1395.06f, 1141.7f, 113.4f));
      this.ExitPos.Add(new Vector3(1396.4f, 1141.7f, 113.4f));
      this.MarkerPos.Add(new Vector3(-1388.9f, -586.11f, 29.5f));
      this.EnterPos.Add(new Vector3(-1388.9f, -586.11f, 29.5f));
      this.ExitPos.Add(new Vector3(-1387.5f, -588.2f, 29.5f));
      this.MarkerPos.Add(new Vector3(-1007.9f, -487.3f, 39.1f));
      this.EnterPos.Add(new Vector3(-1007.9f, -487.3f, 39.1f));
      this.ExitPos.Add(new Vector3(-1003.066f, -477.88f, 49.1f));
      this.MarkerPos.Add(new Vector3(-1291.8f, 6859.5f, -90f));
      this.EnterPos.Add(new Vector3(-1291.8f, 6859.5f, -90f));
      this.ExitPos.Add(new Vector3(514.35f, 4887.685f, -63.5f));
      this.MarkerPos.Add(new Vector3(-1414.3f, 6750.7f, 11.9f));
      this.MarkerPos.Add(new Vector3(-377.1033f, -1876.6f, 19.5f));
      this.EnterPos.Add(new Vector3(-377.1033f, -1876.6f, 19.5f));
      this.ExitPos.Add(new Vector3(216f, 5205f, -89f));
      this.EnterPos.Add(new Vector3(200.8f, 5180f, -89f));
      this.ExitPos.Add(new Vector3(2834.6f, -3908.4f, 139f));
      this.MarkerPos.Add(new Vector3(-286.54f, -1919.5f, 28.5f));
      this.EnterPos.Add(new Vector3(-286.54f, -1919.5f, 28.5f));
      this.ExitPos.Add(new Vector3(2836.9f, -3701f, 139f));
      this.MarkerPos.Add(new Vector3(967.8f, 63.5f, 111.5f));
      this.EnterPos.Add(new Vector3(967.8f, 63.5f, 111.5f));
      this.ExitPos.Add(new Vector3(970.3f, 63.3f, 111.5f));
      this.MarkerPos.Add(new Vector3(299.03f, -584.45f, 43f));
      this.MarkerPos.Add(new Vector3(2452.8f, 4969.933f, 46f));
      this.MarkerPos.Add(new Vector3(241.8f, 360.68f, 105f));
      this.MarkerPos.Add(new Vector3(134.4f, -2203.4f, 7f));
      this.MarkerPos.Add(new Vector3(483.5f, -1312.5f, 29f));
      this.MarkerPos.Add(new Vector3(-1150.3f, -1521.05f, 10f));
      this.MarkerPos.Add(new Vector3(-106.9f, -8.67f, 70f));
      this.MarkerPos.Add(new Vector3(104.178f, -744.49f, 45f));
      this.MarkerPos.Add(new Vector3(-609f, -1609f, 26f));
      this.MarkerPos.Add(new Vector3(3034.114f, -4668.572f, 15.2f));
      this.MarkerPos.Add(new Vector3(3623.21f, 3753.35f, 28.5f));
      this.EnterPos.Add(new Vector3(10.32f, -671.24f, 32.5f));
      this.ExitPos.Add(new Vector3(-0.15f, -706.09f, 15.5f));
      this.EnterPos.Add(new Vector3(3540.7f, 3675.65f, 27.6f));
      this.ExitPos.Add(new Vector3(3540.79f, 3675.82f, 20.4f));
      if (!this.UseSpecifcBlips && this.EnableBlips)
      {
        for (int index = 0; index < this.MarkerPos.Count; ++index)
        {
          Blip blip1 = World.CreateBlip(this.MarkerPos[index]);
          blip1.set_Sprite((BlipSprite) 50);
          Blip blip2 = blip1;
          if (this.RandomColorBlips)
          {
            int num = new Random().Next(0, 1300);
            if (num < 100)
              blip2.set_Color((BlipColor) 0);
            if (num >= 100 && num < 200)
              blip2.set_Color((BlipColor) 3);
            if (num >= 200 && num < 300)
              blip2.set_Color((BlipColor) 1);
            if (num >= 300 && num < 400)
              blip2.set_Color((BlipColor) 66);
            if (num >= 400 && num < 500)
              blip2.set_Color((BlipColor) 2);
            if (num >= 500 && num < 600)
              blip2.set_Color((BlipColor) 76);
            if (num >= 600 && num < 700)
              blip2.set_Color((BlipColor) 54);
            if (num >= 700 && num < 800)
              blip2.set_Color((BlipColor) 56);
            if (num >= 800 && num < 900)
              blip2.set_Color((BlipColor) 52);
            if (num >= 900 && num < 1000)
              blip2.set_Color((BlipColor) 53);
            if (num >= 1000 && num < 1100)
              blip2.set_Color((BlipColor) 41);
            if (num >= 1100 && num < 1200)
              blip2.set_Color((BlipColor) 69);
            if (num >= 1200 && num < 1300)
              blip2.set_Color((BlipColor) 80);
          }
          if (this.UseDefaultWhiteColor)
            blip2.set_Color((BlipColor) 0);
          if (this.UseSpecificColor)
            blip2.set_Color(this.BlipColor);
          if (this.Enable_EAI_InBlipName)
            blip1.set_Name("EAI : Interior");
          if (!this.Enable_EAI_InBlipName)
            blip1.set_Name("Interior");
          blip1.set_IsShortRange(true);
          blip1.set_Scale(0.75f);
          this.InteriorBlips.Add(blip1);
          Script.Wait(1);
        }
      }
      if (!this.UseSpecifcBlips || !this.EnableBlips)
        return;
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[1], 410, "Cargo Ship", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[2], 458, "Maze Bank Arena", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[3], 417, "Denise's House", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[4], 523, "Simeon's Dealership", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[5], 617, "Vangelico", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[6], 525, "Life Invader", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[7], 417, "Lester's Factory", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[8], 417, "Lester's House", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[9], 417, "Foundry", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[10], 590, "Facility", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[11], 557, "Bunker", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[12], 647, "Arcade", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[13], 679, "Casino", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[14], 614, "Nightclub", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[15], 475, "Maze Bank Tower", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[16], 475, "Arcadius Tower", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[17], 475, "Maze Bank West Tower", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[18], 475, "Lombok Tower", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[19], 564, "IAA Facility", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[20], 561, "Omega's Garage", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[21], 93, "Tequilala", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[22], 459, "Server Farm", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[23], 548, "Doomsday Silo Base", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[24], 205, "Dr Friedlander Office", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[25], 440, "Morgue", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[26], 417, "Meat Packing Factory", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[27], 417, "Cluck N Bell", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[28], 417, "Martin Madrazo's House", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[29], 93, "Bahama Mamas West", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[30], 93, "Solomon Richard's Office", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[31], 308, "Submarine", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[32], 455, "Gunrunning Yacht", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[33], 643, "Arena War Workshop", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[34], 643, "Arena War Vip Area", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[35], 417, "DC&R Penthouse", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[36], 107, "Wrecked Hospital", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[37], 417, "O'Neals Farm", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[38], 417, "Kiflom Storage Room", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[39], 417, "Torture Room", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[40], 523, "Haines Autos", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[41], 417, "Jannitor's Appartment", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[42], 106, "FIB Office", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[43], 417, "Roger's Scrap yard", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[44], 455, "Aircraft Carrier", true));
      this.EAIBLIPS.Add(new EAIBLip(this.MarkerPos[45], 417, "Humaine Labs", true));
      foreach (EAIBLip eaibLip in this.EAIBLIPS)
      {
        Blip blip = World.CreateBlip(eaibLip.Pos);
        blip.set_Sprite((BlipSprite) eaibLip.BlipID);
        blip.set_Name("EAI : " + eaibLip.name);
        blip.set_IsShortRange(true);
        if (this.RandomColorBlips)
        {
          int num = new Random().Next(0, 1300);
          if (num < 100)
            blip.set_Color((BlipColor) 0);
          if (num >= 100 && num < 200)
            blip.set_Color((BlipColor) 3);
          if (num >= 200 && num < 300)
            blip.set_Color((BlipColor) 1);
          if (num >= 300 && num < 400)
            blip.set_Color((BlipColor) 66);
          if (num >= 400 && num < 500)
            blip.set_Color((BlipColor) 2);
          if (num >= 500 && num < 600)
            blip.set_Color((BlipColor) 76);
          if (num >= 600 && num < 700)
            blip.set_Color((BlipColor) 54);
          if (num >= 700 && num < 800)
            blip.set_Color((BlipColor) 56);
          if (num >= 800 && num < 900)
            blip.set_Color((BlipColor) 52);
          if (num >= 900 && num < 1000)
            blip.set_Color((BlipColor) 53);
          if (num >= 1000 && num < 1100)
            blip.set_Color((BlipColor) 41);
          if (num >= 1100 && num < 1200)
            blip.set_Color((BlipColor) 69);
          if (num >= 1200 && num < 1300)
            blip.set_Color((BlipColor) 80);
        }
        if (this.UseDefaultWhiteColor)
          blip.set_Color((BlipColor) 0);
        if (this.UseSpecificColor)
          blip.set_Color(this.BlipColor);
        blip.set_Scale(1f);
        this.InteriorBlips.Add(blip);
        Script.Wait(1);
      }
    }

    public void SetExProps()
    {
      this.ExProp.Add("swag_silver");
      this.ExProp.Add("swag_silver2");
      this.ExProp.Add("swag_silver3");
      this.ExProp.Add("swag_drugbags");
      this.ExProp.Add("swag_drugbags2");
      this.ExProp.Add("swag_drugbags3");
      this.ExProp.Add("swag_booze_cigs");
      this.ExProp.Add("swag_booze_cigs2");
      this.ExProp.Add("swag_booze_cigs3");
      this.ExProp.Add("swag_electronic");
      this.ExProp.Add("swag_electronic2");
      this.ExProp.Add("swag_electronic3");
      this.ExProp.Add("swag_drugstatue");
      this.ExProp.Add("swag_drugstatue2");
      this.ExProp.Add("swag_drugstatue3");
      this.ExProp.Add("swag_ivory");
      this.ExProp.Add("swag_ivory2");
      this.ExProp.Add("swag_ivory3");
      this.ExProp.Add("swag_pills");
      this.ExProp.Add("swag_pills2");
      this.ExProp.Add("swag_pills3");
      this.ExProp.Add("swag_jewelwatch");
      this.ExProp.Add("swag_jewelwatch2");
      this.ExProp.Add("swag_jewelwatch3");
      this.ExProp.Add("swag_furcoats");
      this.ExProp.Add("swag_furcoats2");
      this.ExProp.Add("swag_furcoats3");
      this.ExProp.Add("swag_art");
      this.ExProp.Add("swag_art2");
      this.ExProp.Add("swag_art3");
      this.ExProp.Add("swag_guns");
      this.ExProp.Add("swag_guns2");
      this.ExProp.Add("swag_guns3");
      this.ExProp.Add("swag_med");
      this.ExProp.Add("swag_med2");
      this.ExProp.Add("swag_med3");
      this.ExProp.Add("swag_gems");
      this.ExProp.Add("swag_gems2");
      this.ExProp.Add("swag_gems3");
      this.ExProp.Add("swag_counterfeit");
      this.ExProp.Add("swag_counterfeit2");
      this.ExProp.Add("swag_counterfeit3");
    }

    public bool InttoBool(int i)
    {
      bool flag = false;
      if (i == 0)
        flag = false;
      if (i == 1)
        flag = true;
      return flag;
    }

    public int BoolToInt(bool i)
    {
      int num = 0;
      if (!i)
        num = 0;
      if (i)
        num = 1;
      return num;
    }

    public void SetBanner(UIMenu menu) => menu.SetBannerType(this.RectangleGUI);

    public void CreateBanner()
    {
      this.RectangleGUI = new UIResRectangle();
      ((UIRectangle) this.RectangleGUI).set_Color(Color.FromArgb((int) byte.MaxValue, 0, 0, 0));
    }

    public void Setup(bool Phone)
    {
      this.CreateBanner();
      this.LoadIniFile("scripts//EnableAllInteriors.ini");
      this.FlagList.Add("apa_prop_flag_wales");
      this.FlagList.Add("apa_prop_flag_us_yt");
      this.FlagList.Add("apa_prop_flag_uk_yt");
      this.FlagList.Add("apa_prop_flag_turkey");
      this.FlagList.Add("apa_prop_flag_switzerland");
      this.FlagList.Add("apa_prop_flag_sweden");
      this.FlagList.Add("apa_prop_flag_spain");
      this.FlagList.Add("apa_prop_flag_southkorea");
      this.FlagList.Add("apa_prop_flag_southafrica");
      this.FlagList.Add("apa_prop_flag_slovenia");
      this.FlagList.Add("apa_prop_flag_slovakia");
      this.FlagList.Add("apa_prop_flag_script");
      this.FlagList.Add("apa_prop_flag_scotland_yt");
      this.FlagList.Add("apa_prop_flag_russia_yt");
      this.FlagList.Add("apa_prop_flag_puertorico");
      this.FlagList.Add("apa_prop_flag_portugal");
      this.FlagList.Add("apa_prop_flag_poland");
      this.FlagList.Add("apa_prop_flag_palestine");
      this.FlagList.Add("apa_prop_flag_norway");
      this.FlagList.Add("apa_prop_flag_nigeria");
      this.FlagList.Add("apa_prop_flag_newzealand");
      this.FlagList.Add("apa_prop_flag_netherlands");
      this.FlagList.Add("apa_prop_flag_mexico_yt");
      this.FlagList.Add("apa_prop_flag_malta");
      this.FlagList.Add("apa_prop_flag_lstein");
      this.FlagList.Add("apa_prop_flag_japan_yt");
      this.FlagList.Add("apa_prop_flag_jamaica");
      this.FlagList.Add("apa_prop_flag_italy");
      this.FlagList.Add("apa_prop_flag_israel");
      this.FlagList.Add("apa_prop_flag_ireland");
      this.FlagList.Add("apa_prop_flag_hungary");
      this.FlagList.Add("apa_prop_flag_german_yt");
      this.FlagList.Add("apa_prop_flag_france");
      this.FlagList.Add("apa_prop_flag_finland");
      this.FlagList.Add("apa_prop_flag_eu_yt");
      this.FlagList.Add("apa_prop_flag_england");
      this.FlagList.Add("apa_prop_flag_denmark");
      this.FlagList.Add("apa_prop_flag_czechrep");
      this.FlagList.Add("apa_prop_flag_croatia");
      this.FlagList.Add("apa_prop_flag_colombia");
      this.FlagList.Add("apa_prop_flag_china");
      this.FlagList.Add("apa_prop_flag_canada_yt");
      this.FlagList.Add("apa_prop_flag_brazil");
      this.FlagList.Add("apa_prop_flag_belgium");
      this.FlagList.Add("apa_prop_flag_austria");
      this.FlagList.Add("apa_prop_flag_australia");
      this.FlagList.Add("apa_prop_flag_argentina");
      this.YachtLocSring.Add("");
      this.YachtLocSring.Add(" Zancudo River 1 ");
      this.YachtLocSring.Add("Zancudo River 2 ");
      this.YachtLocSring.Add("Zancudo River 3 ");
      this.YachtLocSring.Add("Zancudo Base 1 ");
      this.YachtLocSring.Add("Zancudo Base 2 ");
      this.YachtLocSring.Add("Zancudo Base 3 ");
      this.YachtLocSring.Add("North Chumash 1 ");
      this.YachtLocSring.Add("North Chumash 2 ");
      this.YachtLocSring.Add("North Chumash 3 ");
      this.YachtLocSring.Add("Vespucci Beach 1 ");
      this.YachtLocSring.Add("Vespucci Beach 2 ");
      this.YachtLocSring.Add("Vespucci Beach 3 ");
      this.YachtLocSring.Add("LSIA 1 ");
      this.YachtLocSring.Add("LSIA 2 ");
      this.YachtLocSring.Add("LSIA 3 ");
      this.YachtLocSring.Add("Docks 1 ");
      this.YachtLocSring.Add("Docks 2 ");
      this.YachtLocSring.Add("Docks 3 ");
      this.YachtLocSring.Add("Palomino Highlands 1 ");
      this.YachtLocSring.Add("Palomino Highlands 2 ");
      this.YachtLocSring.Add("Palomino Highlands 3 ");
      this.YachtLocSring.Add("Tavarium Mountains 1 ");
      this.YachtLocSring.Add("Tavarium Mountains 2 ");
      this.YachtLocSring.Add("Tavarium Mountains 3 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 1 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 2 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 3 ");
      this.YachtLocSring.Add("Mount Gordo 1 ");
      this.YachtLocSring.Add("Mount Gordo 2 ");
      this.YachtLocSring.Add("Mount Gordo 3 ");
      this.YachtLocSring.Add("Propocio Beach 1 ");
      this.YachtLocSring.Add("Propocio Beach 2 ");
      this.YachtLocSring.Add("Propocio Beach 3 ");
      this.YachtLocSring.Add("Paleto Bay 1 ");
      this.YachtLocSring.Add("Paleto Bay 2 ");
      this.YachtLocSring.Add("Paleto Bay 3 ");
      this.YachtPos.Add(new Vector3(0.0f, 0.0f, 0.0f));
      this.YachtPos.Add(this.PlayerYachtPos1);
      this.YachtPos.Add(this.PlayerYachtPos2);
      this.YachtPos.Add(this.PlayerYachtPos3);
      this.YachtPos.Add(this.PlayerYachtPos4);
      this.YachtPos.Add(this.PlayerYachtPos5);
      this.YachtPos.Add(this.PlayerYachtPos6);
      this.YachtPos.Add(this.PlayerYachtPos7);
      this.YachtPos.Add(this.PlayerYachtPos8);
      this.YachtPos.Add(this.PlayerYachtPos9);
      this.YachtPos.Add(this.PlayerYachtPos10);
      this.YachtPos.Add(this.PlayerYachtPos11);
      this.YachtPos.Add(this.PlayerYachtPos12);
      this.YachtPos.Add(this.PlayerYachtPos13);
      this.YachtPos.Add(this.PlayerYachtPos14);
      this.YachtPos.Add(this.PlayerYachtPos15);
      this.YachtPos.Add(this.PlayerYachtPos16);
      this.YachtPos.Add(this.PlayerYachtPos17);
      this.YachtPos.Add(this.PlayerYachtPos18);
      this.YachtPos.Add(this.PlayerYachtPos19);
      this.YachtPos.Add(this.PlayerYachtPos20);
      this.YachtPos.Add(this.PlayerYachtPos21);
      this.YachtPos.Add(this.PlayerYachtPos22);
      this.YachtPos.Add(this.PlayerYachtPos23);
      this.YachtPos.Add(this.PlayerYachtPos24);
      this.YachtPos.Add(this.PlayerYachtPos25);
      this.YachtPos.Add(this.PlayerYachtPos26);
      this.YachtPos.Add(this.PlayerYachtPos27);
      this.YachtPos.Add(this.PlayerYachtPos28);
      this.YachtPos.Add(this.PlayerYachtPos29);
      this.YachtPos.Add(this.PlayerYachtPos30);
      this.YachtPos.Add(this.PlayerYachtPos31);
      this.YachtPos.Add(this.PlayerYachtPos32);
      this.YachtPos.Add(this.PlayerYachtPos33);
      this.YachtPos.Add(this.PlayerYachtPos34);
      this.YachtPos.Add(this.PlayerYachtPos35);
      this.YachtPos.Add(this.PlayerYachtPos36);
      this.YachtHashs.Add("");
      this.YachtHashs2.Add("");
      this.YachtHashs.Add("apa_yacht_grp01_1");
      this.YachtHashs2.Add("apa_yacht_grp01_1_int");
      this.YachtHashs.Add("apa_yacht_grp01_2");
      this.YachtHashs2.Add("apa_yacht_grp01_2_int");
      this.YachtHashs.Add("apa_yacht_grp01_3");
      this.YachtHashs2.Add("apa_yacht_grp01_3_int");
      this.YachtHashs.Add("apa_yacht_grp02_1");
      this.YachtHashs2.Add("apa_yacht_grp02_1_int");
      this.YachtHashs.Add("apa_yacht_grp02_2");
      this.YachtHashs2.Add("apa_yacht_grp02_2_int");
      this.YachtHashs.Add("apa_yacht_grp02_3");
      this.YachtHashs2.Add("apa_yacht_grp02_3_int");
      this.YachtHashs.Add("apa_yacht_grp03_1");
      this.YachtHashs2.Add("apa_yacht_grp03_1_int");
      this.YachtHashs.Add("apa_yacht_grp03_2");
      this.YachtHashs2.Add("apa_yacht_grp03_2_int");
      this.YachtHashs.Add("apa_yacht_grp03_3");
      this.YachtHashs2.Add("apa_yacht_grp03_3_int");
      this.YachtHashs.Add("apa_yacht_grp04_1");
      this.YachtHashs2.Add("apa_yacht_grp04_1_int");
      this.YachtHashs.Add("apa_yacht_grp04_2");
      this.YachtHashs2.Add("apa_yacht_grp04_2_int");
      this.YachtHashs.Add("apa_yacht_grp04_3");
      this.YachtHashs2.Add("apa_yacht_grp04_3_int");
      this.YachtHashs.Add("apa_yacht_grp05_1");
      this.YachtHashs2.Add("apa_yacht_grp05_1_int");
      this.YachtHashs.Add("apa_yacht_grp05_2");
      this.YachtHashs2.Add("apa_yacht_grp05_2_int");
      this.YachtHashs.Add("apa_yacht_grp05_3");
      this.YachtHashs2.Add("apa_yacht_grp05_3_int");
      this.YachtHashs.Add("apa_yacht_grp06_1");
      this.YachtHashs2.Add("apa_yacht_grp06_1_int");
      this.YachtHashs.Add("apa_yacht_grp06_2");
      this.YachtHashs2.Add("apa_yacht_grp06_2_int");
      this.YachtHashs.Add("apa_yacht_grp06_3");
      this.YachtHashs2.Add("apa_yacht_grp06_3_int");
      this.YachtHashs.Add("apa_yacht_grp07_1");
      this.YachtHashs2.Add("apa_yacht_grp07_1_int");
      this.YachtHashs.Add("apa_yacht_grp07_2");
      this.YachtHashs2.Add("apa_yacht_grp07_2_int");
      this.YachtHashs.Add("apa_yacht_grp07_3");
      this.YachtHashs2.Add("apa_yacht_grp07_3_int");
      this.YachtHashs.Add("apa_yacht_grp08_1");
      this.YachtHashs2.Add("apa_yacht_grp08_1_int");
      this.YachtHashs.Add("apa_yacht_grp08_2");
      this.YachtHashs2.Add("apa_yacht_grp08_2_int");
      this.YachtHashs.Add("apa_yacht_grp08_3");
      this.YachtHashs2.Add("apa_yacht_grp08_3_int");
      this.YachtHashs.Add("apa_yacht_grp09_1");
      this.YachtHashs2.Add("apa_yacht_grp09_1_int");
      this.YachtHashs.Add("apa_yacht_grp09_2");
      this.YachtHashs2.Add("apa_yacht_grp09_2_int");
      this.YachtHashs.Add("apa_yacht_grp09_3");
      this.YachtHashs2.Add("apa_yacht_grp09_3_int");
      this.YachtHashs.Add("apa_yacht_grp10_1");
      this.YachtHashs2.Add("apa_yacht_grp10_1_int");
      this.YachtHashs.Add("apa_yacht_grp10_2");
      this.YachtHashs2.Add("apa_yacht_grp10_2_int");
      this.YachtHashs.Add("apa_yacht_grp10_3");
      this.YachtHashs2.Add("apa_yacht_grp10_3_int");
      this.YachtHashs.Add("apa_yacht_grp11_1");
      this.YachtHashs2.Add("apa_yacht_grp11_1_int");
      this.YachtHashs.Add("apa_yacht_grp11_2");
      this.YachtHashs2.Add("apa_yacht_grp11_2_int");
      this.YachtHashs.Add("apa_yacht_grp11_3");
      this.YachtHashs2.Add("apa_yacht_grp11_3_int");
      this.YachtHashs.Add("apa_yacht_grp12_1");
      this.YachtHashs2.Add("apa_yacht_grp12_1_int");
      this.YachtHashs.Add("apa_yacht_grp12_2");
      this.YachtHashs2.Add("apa_yacht_grp12_2_int");
      this.YachtHashs.Add("apa_yacht_grp12_3");
      this.YachtHashs2.Add("apa_yacht_grp12_3_int");
      if (!Phone)
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass438_0 displayClass4380 = new Class1.\u003C\u003Ec__DisplayClass438_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4380.\u003C\u003E4__this = this;
      CustomiFruit customiFruit = new CustomiFruit();
      customiFruit.set_CenterButtonColor(Color.Orange);
      customiFruit.set_LeftButtonColor(Color.LimeGreen);
      customiFruit.set_RightButtonColor(Color.Purple);
      customiFruit.set_CenterButtonIcon((SoftKeyIcon) 19);
      customiFruit.set_LeftButtonIcon((SoftKeyIcon) 17);
      customiFruit.set_RightButtonIcon((SoftKeyIcon) 16);
      this.ifruit = customiFruit;
      this.TF.Add((object) false);
      this.TF.Add((object) true);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 10);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 20);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 30);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 40);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 100);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 200);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 300);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 400);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ShowDIST.Add((object) 500);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.BlipColors = new List<object>();
      foreach (uint num in (WeaponComponent[]) Enum.GetValues(typeof (BlipColor)))
      {
        BlipColor blipColor = (BlipColor) (int) num;
        // ISSUE: reference to a compiler-generated field
        displayClass4380.BlipColors.Add((object) blipColor);
      }
      this.ifruit.SetWallpaper(Wallpaper.get_BadgerDefault());
      iFruitContact iFruitContact = new iFruitContact("EAI");
      // ISSUE: method pointer
      iFruitContact.add_Answered(new ContactAnsweredEvent((object) this, __methodptr(loadMenu)));
      iFruitContact.set_DialTimeout(3000);
      iFruitContact.set_Active(true);
      iFruitContact.set_Icon(ContactIcon.get_Property_CarModShop());
      iFruitContact.set_Name("Enable Interiors");
      this.Woredrobepool = new MenuPool();
      this.WoredrobeMainMenu = new UIMenu("Enable All Interiors", "Select an Option");
      this.GUIMenus.Add(this.WoredrobeMainMenu);
      this.Woredrobepool.Add(this.WoredrobeMainMenu);
      ((List<iFruitContact>) this.ifruit.get_Contacts()).Add(iFruitContact);
      this.Int = this.Woredrobepool.AddSubMenu(this.WoredrobeMainMenu, "Change An Interior");
      this.GUIMenus.Add(this.Int);
      this.MiscDLC = this.Woredrobepool.AddSubMenu(this.Int, "Misc Interiors");
      this.GUIMenus.Add(this.MiscDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.NorthYankton = new UIMenuListItem("North Yankton : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.NorthYankton);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.AircraftCarrier = new UIMenuListItem("Aircraft Carrier: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.AircraftCarrier);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.SimeonsDealerShip = new UIMenuListItem("Simeons DealerShip : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.SimeonsDealerShip);
      this.MiscDLC.AddItem((UIMenuItem) new UIMenuListItem("Fame or Shame Studio : ", this.TF, 0));
      this.MiscDLC.AddItem((UIMenuItem) new UIMenuListItem("Lesters Factory : ", this.TF, 0));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.TrainCrash = new UIMenuListItem("Train Crash Bridge: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.TrainCrash);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.FortZancudo = new UIMenuListItem("Locked Fort Zancudo Gates: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.FortZancudo);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.CluckenBell = new UIMenuListItem("CluckenBell Enabled: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.CluckenBell);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.PlaneCrash = new UIMenuListItem("Plane Crash : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.PlaneCrash);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.TTrailerTidy = new UIMenuListItem("Trevor's Trailer Tidy : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.TTrailerTidy);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.UnionDepository = new UIMenuListItem("Union Depository Active: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.UnionDepository);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.HumaineLabsG = new UIMenuListItem("Humaine Labs Grate Active: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.HumaineLabsG);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.HospitalDestroyedO = new UIMenuListItem("Hospital Destoroyed  : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.HospitalDestroyedO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.SunkenCargoShip = new UIMenuListItem("Non Sunken Cargo Ship : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.SunkenCargoShip);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.VangelicOpenInt = new UIMenuListItem("Vangelic Open : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.VangelicOpenInt);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.GasStationOnFireO = new UIMenuListItem("Paleto Gas Station On Fire : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.GasStationOnFireO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.TriathalonPropsO = new UIMenuListItem("Sandy Shores Triathalon Props : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.TriathalonPropsO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MeltdownPremireO = new UIMenuListItem("Meltdown Premire: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.MeltdownPremireO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.fixedPaletoHotelO = new UIMenuListItem("fixed Paleto Hotel : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.fixedPaletoHotelO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.fixedCypressFlatsBrickWallO = new UIMenuListItem("fixed Cypress Flats Brick Wall: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.fixedCypressFlatsBrickWallO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.BurntJoshsMansionO = new UIMenuListItem("Burnt Josh's Mansion : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.BurntJoshsMansionO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.RepairedStabCityO = new UIMenuListItem("Repaired Stab City : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.RepairedStabCityO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.DestroyedSilthouseO = new UIMenuListItem("Destroyed Silt house: ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.DestroyedSilthouseO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MaxRendaBuildingO = new UIMenuListItem("Max Renda Building : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.MaxRendaBuildingO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.RogersScrapYardO = new UIMenuListItem("Rogers Scrap Yard : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.RogersScrapYardO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.FibBuildingO = new UIMenuListItem("FIB Building : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscDLC.AddItem((UIMenuItem) displayClass4380.FibBuildingO);
      this.BikerDLC = this.Woredrobepool.AddSubMenu(this.Int, "Biker Interiors");
      this.GUIMenus.Add(this.BikerDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ClubHouse1 = new UIMenuListItem("Clubhouse 1 : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.BikerDLC.AddItem((UIMenuItem) displayClass4380.ClubHouse1);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ClubHouse2 = new UIMenuListItem("Clubhouse 2 : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.BikerDLC.AddItem((UIMenuItem) displayClass4380.ClubHouse2);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Cocaine = new UIMenuListItem("Cocaine Lockup : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.BikerDLC.AddItem((UIMenuItem) displayClass4380.Cocaine);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Meth = new UIMenuListItem("Meth Lab : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.BikerDLC.AddItem((UIMenuItem) displayClass4380.Meth);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Weed = new UIMenuListItem("Weed Farm : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.BikerDLC.AddItem((UIMenuItem) displayClass4380.Weed);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Moneyforgery = new UIMenuListItem("Money Printing : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.BikerDLC.AddItem((UIMenuItem) displayClass4380.Moneyforgery);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.DocumentForgery = new UIMenuListItem("Document Forgery : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.BikerDLC.AddItem((UIMenuItem) displayClass4380.DocumentForgery);
      this.BikerDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.EnableAircraftCarrier = (bool) this.Config.GetValue<bool>("Interiors", "EnableAircraftCarrier", (M0) (this.EnableAircraftCarrier ? 1 : 0));
      this.ExecutiveDLC = this.Woredrobepool.AddSubMenu(this.Int, "Executive Interiors");
      this.GUIMenus.Add(this.ExecutiveDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.SWarehouse = new UIMenuListItem("Small Warehouse : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.SWarehouse);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MWarehouse = new UIMenuListItem("Medium Warehouse : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.MWarehouse);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.LWarehouse = new UIMenuListItem("Large Warehouse : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.LWarehouse);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.VWarehouse = new UIMenuListItem("Vehicle Warehouse : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.VWarehouse);
      // ISSUE: reference to a compiler-generated field
      displayClass4380._60CarGarage = new UIMenuListItem("Executive Garage : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380._60CarGarage);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Arcadius = new UIMenuListItem("Arcadius Tower : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.Arcadius);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MazeBank = new UIMenuListItem("Maze Bank Tower : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.MazeBank);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MazeBankW = new UIMenuListItem("Maze Bank West Tower : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.MazeBankW);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Lombok = new UIMenuListItem("Lombok Tower : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.Lombok);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ModShop = new UIMenuListItem("Mod Shop : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ExecutiveDLC.AddItem((UIMenuItem) displayClass4380.ModShop);
      this.ExecutiveDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.SmugglersRunDLC = this.Woredrobepool.AddSubMenu(this.Int, "Smuggler's Run Interiors");
      this.GUIMenus.Add(this.SmugglersRunDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.HangerI = new UIMenuListItem("Hanger : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.SmugglersRunDLC.AddItem((UIMenuItem) displayClass4380.HangerI);
      this.SmugglersRunDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.GunrunningDLC = this.Woredrobepool.AddSubMenu(this.Int, "Gunrunning Interiors");
      this.GUIMenus.Add(this.GunrunningDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Bunker = new UIMenuListItem("Bunker : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.GunrunningDLC.AddItem((UIMenuItem) displayClass4380.Bunker);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.BunkerH = new UIMenuListItem("Bunker Hatches : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.GunrunningDLC.AddItem((UIMenuItem) displayClass4380.BunkerH);
      this.GunrunningDLC.AddItem((UIMenuItem) new UIMenuListItem("Gunrunning Yacht : ", this.TF, 0));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MOC = new UIMenuListItem("MOC : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.GunrunningDLC.AddItem((UIMenuItem) displayClass4380.MOC);
      this.GunrunningDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.DoomsdayHeistDLC = this.Woredrobepool.AddSubMenu(this.Int, "Doomsday Heist Interiors");
      this.GUIMenus.Add(this.DoomsdayHeistDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Silo = new UIMenuListItem("Missile Silo : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DoomsdayHeistDLC.AddItem((UIMenuItem) displayClass4380.Silo);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Sub = new UIMenuListItem("Submarine : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DoomsdayHeistDLC.AddItem((UIMenuItem) displayClass4380.Sub);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.IAAFacility = new UIMenuListItem("IAA Facility : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DoomsdayHeistDLC.AddItem((UIMenuItem) displayClass4380.IAAFacility);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ServerFarm = new UIMenuListItem("IAA Server Farm : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DoomsdayHeistDLC.AddItem((UIMenuItem) displayClass4380.ServerFarm);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Avenger = new UIMenuListItem("Avenger : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DoomsdayHeistDLC.AddItem((UIMenuItem) displayClass4380.Avenger);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Facility = new UIMenuListItem("Facility : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DoomsdayHeistDLC.AddItem((UIMenuItem) displayClass4380.Facility);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.FacilityH = new UIMenuListItem("Facility Hatches : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DoomsdayHeistDLC.AddItem((UIMenuItem) displayClass4380.FacilityH);
      this.DoomsdayHeistDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.AfterHoursDLC = this.Woredrobepool.AddSubMenu(this.Int, "After Hours Interiors");
      this.GUIMenus.Add(this.AfterHoursDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Nightclub = new UIMenuListItem("Nightclub : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.AfterHoursDLC.AddItem((UIMenuItem) displayClass4380.Nightclub);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.NightclubGarage = new UIMenuListItem("Nightclub Garage : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.AfterHoursDLC.AddItem((UIMenuItem) displayClass4380.NightclubGarage);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Terrobyte = new UIMenuListItem("Terrobyte : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.AfterHoursDLC.AddItem((UIMenuItem) displayClass4380.Terrobyte);
      this.AfterHoursDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.ArenaWarDLC = this.Woredrobepool.AddSubMenu(this.Int, "Arena War Interiors");
      this.GUIMenus.Add(this.ArenaWarDLC);
      this.ArenaWarDLC = this.Woredrobepool.AddSubMenu(this.Int, "Arena War Interiors");
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Arena = new UIMenuListItem("Arena : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ArenaWarDLC.AddItem((UIMenuItem) displayClass4380.Arena);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ArenaW = new UIMenuListItem("Arena Workshop : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ArenaWarDLC.AddItem((UIMenuItem) displayClass4380.ArenaW);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ArenaGarage = new UIMenuListItem("ArenaGarage : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ArenaWarDLC.AddItem((UIMenuItem) displayClass4380.ArenaGarage);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ArenaVip = new UIMenuListItem("ArenaVip : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.ArenaWarDLC.AddItem((UIMenuItem) displayClass4380.ArenaVip);
      this.ArenaWarDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.DCRDLC = this.Woredrobepool.AddSubMenu(this.Int, "DC&R Interiors");
      this.GUIMenus.Add(this.DCRDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Casino = new UIMenuListItem("Casino : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCRDLC.AddItem((UIMenuItem) displayClass4380.Casino);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Penthouse = new UIMenuListItem("Penthouse : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCRDLC.AddItem((UIMenuItem) displayClass4380.Penthouse);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.GarageParking = new UIMenuListItem("Garage : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCRDLC.AddItem((UIMenuItem) displayClass4380.GarageParking);
      this.DCRDLC.AddItem(new UIMenuItem("---------------------Customization--------------------"));
      this.DCHDLC = this.Woredrobepool.AddSubMenu(this.Int, "Dimond Casino Heist Interiors");
      this.GUIMenus.Add(this.DCHDLC);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Arcade = new UIMenuListItem("Arcade : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.Arcade);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.CasinoH = new UIMenuListItem("Casino : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.CasinoH);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.LoadingBay = new UIMenuListItem("Loading Bay : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.LoadingBay);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Office = new UIMenuListItem("Offices : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.Office);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Hotel = new UIMenuListItem("Hotel : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.Hotel);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Vault = new UIMenuListItem("Vault : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.Vault);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Tunnel = new UIMenuListItem("Tunnel : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.Tunnel);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Shaft = new UIMenuListItem("Shaft : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.DCHDLC.AddItem((UIMenuItem) displayClass4380.Shaft);
      this.DCHDLC.AddItem(new UIMenuItem("---------------------Customization------------------"));
      this.Int.AddItem(new UIMenuItem("---------------------------------------------------------"));
      this.MiscO = this.Woredrobepool.AddSubMenu(this.Int, "Misc Options");
      this.GUIMenus.Add(this.MiscO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Markers = new UIMenuListItem("Enable Markers : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.Markers);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MPLoad = new UIMenuListItem("Load MP Maps on Mod Refresh : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.MPLoad);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Blips = new UIMenuListItem("Enable Blips : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.Blips);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.DISTBLIPs = new UIMenuListItem("Distance Blips : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.DISTBLIPs);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass4380.DISTBLIPs).set_Description("Will Show Blips only when close");
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ENABLE_EAINAME = new UIMenuListItem("EAI Name in Blips : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.ENABLE_EAINAME);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass4380.ENABLE_EAINAME).set_Description("will enable/disable EAI in the blips name");
      // ISSUE: reference to a compiler-generated field
      displayClass4380.BlipShowIgnorePlayerHeight = new UIMenuListItem("Show Blip/Height : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.BlipShowIgnorePlayerHeight);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass4380.BlipShowIgnorePlayerHeight).set_Description("will show the blip when Distance Blips are on, will ignore the height, above ground, showing a blip if the player is above the coord instead of close  ");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4380.SHOWDIST = new UIMenuListItem("Blip Show Dist : ", displayClass4380.ShowDIST, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.SHOWDIST);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.RandomColorBlipsO = new UIMenuListItem("Random Color Blips : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.RandomColorBlipsO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.UseDefaultWhiteColorO = new UIMenuListItem("Use Default White Color : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.UseDefaultWhiteColorO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.UseSpecifcBlipsO = new UIMenuListItem("Use Specifc Blips : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.UseSpecifcBlipsO);
      // ISSUE: reference to a compiler-generated field
      displayClass4380.UseSpecificColorO = new UIMenuListItem("Use Specific Color : ", this.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.UseSpecificColorO);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4380.BlipColorO = new UIMenuListItem("Blip Color : ", displayClass4380.BlipColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.MiscO.AddItem((UIMenuItem) displayClass4380.BlipColorO);
      // ISSUE: method pointer
      this.MiscO.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__0)));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Refresh = new UIMenuItem("~g~ Refresh Interiors ~w~");
      // ISSUE: reference to a compiler-generated field
      this.Int.AddItem(displayClass4380.Refresh);
      // ISSUE: method pointer
      this.Int.add_OnItemSelect(new ItemSelectEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__1)));
      // ISSUE: method pointer
      this.Int.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__2)));
      // ISSUE: method pointer
      this.MiscDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__3)));
      // ISSUE: method pointer
      this.BikerDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__4)));
      // ISSUE: method pointer
      this.ExecutiveDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__5)));
      // ISSUE: method pointer
      this.DoomsdayHeistDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__6)));
      // ISSUE: method pointer
      this.GunrunningDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__7)));
      // ISSUE: method pointer
      this.SmugglersRunDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__8)));
      // ISSUE: method pointer
      this.ArenaWarDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__9)));
      // ISSUE: method pointer
      this.AfterHoursDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__10)));
      // ISSUE: method pointer
      this.DCHDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__11)));
      // ISSUE: method pointer
      this.DCRDLC.add_OnListChange(new ListChangedEvent((object) displayClass4380, __methodptr(\u003CSetup\u003Eb__12)));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Arcade.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Arcade", (M0) (this.EnableDCH_Arcade ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.CasinoH.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Casino", (M0) (this.EnableDCH_Casino ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.LoadingBay.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_LoadingBay", (M0) (this.EnableDCH_LoadingBay ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Vault.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Vault", (M0) (this.EnableDCH_Vault ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Office.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Office", (M0) (this.EnableDCH_Office ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Hotel.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Hotel", (M0) (this.EnableDCH_Hotel ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Tunnel.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Tunnel", (M0) (this.EnableDCH_Tunnel ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Shaft.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableDCH_Shaft", (M0) (this.EnableDCH_Shaft ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Casino.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableCasino", (M0) (this.EnableCasino ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Penthouse.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableCasinoPenthouse", (M0) (this.EnableCasinoPenthouse ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.GarageParking.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "load_DCARgarages", (M0) (this.load_DCARgarages ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Arena.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableArena", (M0) (this.EnableArena ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ArenaW.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableArenaWorkshop", (M0) (this.EnableArenaWorkshop ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ArenaVip.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableArenaVip", (M0) (this.EnableArenaVip ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ArenaGarage.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadArenaGarage", (M0) (this.LoadArenaGarage ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Terrobyte.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableTerrobyte", (M0) (this.EnableTerrobyte ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Nightclub.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableNightclub", (M0) (this.EnableNightclub ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.NightclubGarage.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableNightclubGarage", (M0) (this.EnableNightclubGarage ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.HangerI.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadHanger", (M0) (this.LoadHanger ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.BunkerH.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadBunkerHatches", (M0) (this.LoadBunkerHatches ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Bunker.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadBunker", (M0) (this.LoadBunker ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MOC.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableMoc", (M0) (this.EnableMoc ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Arcadius.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableArcadiusTower", (M0) (this.EnableArcadiusTower ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MazeBank.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankTower", (M0) (this.EnableMazeBankTower ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MazeBankW.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableMazeBankWestTower", (M0) (this.EnableMazeBankWestTower ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Lombok.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableLombokTower", (M0) (this.EnableLombokTower ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.FacilityH.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadFacilityHatches", (M0) (this.LoadFacilityHatches ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Facility.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadFacility", (M0) (this.LoadFacility ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Sub.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableSub", (M0) (this.EnableSub ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Silo.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableMissileSilo", (M0) (this.EnableMissileSilo ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Avenger.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableAvenger", (M0) (this.EnableAvenger ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ServerFarm.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadCEOgarage", (M0) (this.EnableIAAServerFarm ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.IAAFacility.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadCEOgarage", (M0) (this.EnableIAAServerFarm ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.NorthYankton.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableNorthYankton", (M0) (this.EnableNorthYankton ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.SunkenCargoShip.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "SunkenCargoShipOn", (M0) (this.SunkenCargoShipOn ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.TrainCrash.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "TrainCrashOn", (M0) (this.TrainCrashOn ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.FortZancudo.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "FortZancudoGates", (M0) (this.FortZancudoGates ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.CluckenBell.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "CluckenBellOn", (M0) (this.CluckenBellOn ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.PlaneCrash.set_Index(this.BoolToInt(this.PlaneCrashOn = (bool) this.Config.GetValue<bool>("Interiors", "PlaneCrashOn", (M0) (this.PlaneCrashOn ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.TTrailerTidy.set_Index(this.BoolToInt(this.TrailerTidy = (bool) this.Config.GetValue<bool>("Interiors", "TrailerTidy", (M0) (this.TrailerTidy ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.SimeonsDealerShip.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "SimeonsShowroom", (M0) (this.SimeonsShowroom ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.UnionDepository.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "UnionDepositoryActive", (M0) (this.UnionDepositoryActive ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.HumaineLabsG.set_Index(this.BoolToInt(this.HumaineLabsGrate = (bool) this.Config.GetValue<bool>("Interiors", "HumaineLabsGrate", (M0) (this.HumaineLabsGrate ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.HospitalDestroyedO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "HospitalDestroyed", (M0) (this.HospitalDestroyed ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.VangelicOpenInt.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "VangelicoOpen", (M0) (this.VangelicoOpen ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.GasStationOnFireO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "GasStationOnFire", (M0) (this.GasStationOnFire ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.TriathalonPropsO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "TriathalonProps", (M0) (this.TriathalonProps ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MeltdownPremireO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "MeltdownPremire", (M0) (this.MeltdownPremire ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.fixedPaletoHotelO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "fixedPaletoHotel", (M0) (this.fixedPaletoHotel ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.fixedCypressFlatsBrickWallO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "fixedCypressFlatsBrickWall", (M0) (this.fixedCypressFlatsBrickWall ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.BurntJoshsMansionO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "BurntJoshsMansion", (M0) (this.BurntJoshsMansion ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.RepairedStabCityO.set_Index(this.BoolToInt(this.RepairedStabCity = (bool) this.Config.GetValue<bool>("Interiors", "RepairedStabCity", (M0) (this.RepairedStabCity ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.DestroyedSilthouseO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "VangelicoOpen", (M0) (this.DestroyedSilthouse ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MaxRendaBuildingO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "MaxRendaBuilding", (M0) (this.MaxRendaBuilding ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.RogersScrapYardO.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "RogersScrapYard", (M0) (this.RogersScrapYard ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.FibBuildingO.set_Index(this.BoolToInt(this.FibBuilding = (bool) this.Config.GetValue<bool>("Interiors", "FibBuilding", (M0) (this.FibBuilding ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ClubHouse1.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadBikerClubhouseA", (M0) (this.LoadBikerClubhouseA ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ClubHouse2.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadBikerClubhouseB", (M0) (this.LoadBikerClubhouseB ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Moneyforgery.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableBikerMoneyPrinter", (M0) (this.EnableBikerMoneyPrinter ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Cocaine.set_Index(this.BoolToInt(this.EnableBikerCocaineLab = (bool) this.Config.GetValue<bool>("Interiors", "EnableBikerCocaineLab", (M0) (this.EnableBikerCocaineLab ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Meth.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableBikerMethLab", (M0) (this.EnableBikerMethLab ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.Weed.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableBikerWeedFarm", (M0) (this.EnableBikerWeedFarm ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.DocumentForgery.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableBikerForgeryOffice", (M0) (this.EnableBikerForgeryOffice ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.ModShop.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableCEOModShop", (M0) (this.EnableCEOModShop ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.LWarehouse.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadWarehouseInt", (M0) (this.LoadWarehouseInt ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380._60CarGarage.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "LoadCEOgarage", (M0) (this.LoadCEOgarage ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.SWarehouse.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableCEOCargoWarehouse_Small", (M0) (this.EnableCEOCargoWarehouse_Small ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.MWarehouse.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableCEOCargoWareWarehouse_Medium", (M0) (this.EnableCEOCargoWareWarehouse_Medium ? 1 : 0))));
      // ISSUE: reference to a compiler-generated field
      displayClass4380.LWarehouse.set_Index(this.BoolToInt((bool) this.Config.GetValue<bool>("Interiors", "EnableCEOCargoWareWarehouse_Large", (M0) (this.EnableCEOCargoWareWarehouse_Large ? 1 : 0))));
      this.Hanger = this.Woredrobepool.AddSubMenu(this.SmugglersRunDLC, "Hanger");
      this.GUIMenus.Add(this.Hanger);
      this.Hanger1 = this.Woredrobepool.AddSubMenu(this.Hanger, "Color");
      this.GUIMenus.Add(this.Hanger1);
      this.Hanger2 = this.Woredrobepool.AddSubMenu(this.Hanger, "Design");
      this.GUIMenus.Add(this.Hanger2);
      this.InteriorOptions = this.Woredrobepool.AddSubMenu(this.ArenaWarDLC, "Arena War Garage");
      this.GUIMenus.Add(this.InteriorOptions);
      this.SetupWorkshop();
      this.SetupB1Garage();
      this.SetupT_T();
      this.AddArcades();
      this.ArcadeInteriorOptions();
      this.PenthouseOptions();
      this.ChangeColor();
      this.SetupCustomizations();
      this.SetupInterior();
      this.SetupInterior2();
      this.SetupInteriorMenu();
      this.Setupmenu();
      this.SetupInteriorDesignsMenu2();
      this.SetupNightclubOptions();
      this.NStadium.Add("Set_Pit_Fence_Closed");
      this.NStadium.Add("Set_Pit_Fence_Demolition");
      this.NStadium.Add("Set_Pit_Fence_Oval");
      this.NStadium.Add("set_pit_fence_ovala");
      this.NStadium.Add("set_pit_fence_ovalb");
      this.NStadium.Add("Set_Pit_Fence_Wall");
      this.NStadium.Add("set_wall_no_pit");
      this.NStadium.Add("set_centreline_dystopian_05");
      this.NStadium.Add("set_centreline_scifi_05");
      this.NStadium.Add("Set_CentreLine_Wasteland_05");
      this.NStadium.Add("Set_Turrets");
      this.NStadium.Add("set_turrets_scifi");
      this.NStadium.Add("set_turrets_wasteland");
      this.NStadium.Add("Set_Team_Band_A");
      this.NStadium.Add("Set_Team_Band_B");
      this.NStadium.Add("Set_Team_Band_C");
      this.NStadium.Add("Set_Team_Band_D");
      this.NStadium.Add("Set_Lights_atlantis");
      this.NStadium.Add("Set_Lights_evening");
      this.NStadium.Add("Set_Lights_hell");
      this.NStadium.Add("Set_Lights_midday");
      this.NStadium.Add("Set_Lights_morning");
      this.NStadium.Add("Set_Lights_night");
      this.NStadium.Add("set_lights_sfnight");
      this.NStadium.Add("Set_Lights_saccharine");
      this.NStadium.Add("Set_Lights_sandstorm");
      this.NStadium.Add("Set_Lights_storm");
      this.NStadium.Add("Set_Lights_toxic");
      this.NStadium.Add("Set_Dystopian_01");
      this.NStadium.Add("Set_Dystopian_02");
      this.NStadium.Add("Set_Dystopian_03");
      this.NStadium.Add("Set_Dystopian_04");
      this.NStadium.Add("Set_Dystopian_05");
      this.NStadium.Add("Set_Dystopian_06");
      this.NStadium.Add("Set_Dystopian_07");
      this.NStadium.Add("Set_Dystopian_08");
      this.NStadium.Add("Set_Dystopian_09");
      this.NStadium.Add("Set_Dystopian_10");
      this.NStadium.Add("Set_Dystopian_11");
      this.NStadium.Add("Set_Dystopian_12");
      this.NStadium.Add("Set_Dystopian_13");
      this.NStadium.Add("Set_Dystopian_14");
      this.NStadium.Add("Set_Dystopian_15");
      this.NStadium.Add("Set_Dystopian_16");
      this.NStadium.Add("Set_Dystopian_17");
      this.NStadium.Add("Set_Scifi_01");
      this.NStadium.Add("Set_Scifi_02");
      this.NStadium.Add("Set_Scifi_03");
      this.NStadium.Add("Set_Scifi_04");
      this.NStadium.Add("Set_Scifi_05");
      this.NStadium.Add("Set_Scifi_06");
      this.NStadium.Add("Set_Scifi_07");
      this.NStadium.Add("Set_Scifi_08");
      this.NStadium.Add("Set_Scifi_09");
      this.NStadium.Add("Set_Scifi_10");
      this.NStadium.Add("Set_Wasteland_01");
      this.NStadium.Add("Set_Wasteland_02");
      this.NStadium.Add("Set_Wasteland_03");
      this.NStadium.Add("Set_Wasteland_04");
      this.NStadium.Add("Set_Wasteland_05");
      this.NStadium.Add("Set_Wasteland_06");
      this.NStadium.Add("Set_Wasteland_07");
      this.NStadium.Add("Set_Wasteland_08");
      this.NStadium.Add("Set_Wasteland_09");
      this.NStadium.Add("Set_Wasteland_10");
      this.NStadium.Add("Set_Dystopian_Scene");
      this.NStadium.Add("Set_Scifi_Scene");
      this.NStadium.Add("Set_Wasteland_Scene");
      this.NStadium.Add("Set_Crowd_A");
      this.NStadium.Add("Set_Crowd_B");
      this.NStadium.Add("Set_Crowd_C");
      this.NStadium.Add("Set_Crowd_D");
      this.SetupDecalOptions();
      this.SetExProps();
      this.SetupOrganization();
      this.SetCashProps();
      this.CustomizeBikerClubhouses();
      for (int index = 0; index < this.GUIMenus.Count; ++index)
        this.SetBanner(this.GUIMenus[index]);
    }

    public void SetupInteriorMenu()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass439_0 displayClass4390 = new Class1.\u003C\u003Ec__DisplayClass439_0()
      {
        \u003C\u003E4__this = this,
        Graphic = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_01");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_02");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_03");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_04");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_05");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_06");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_07");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_08");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Graphic.Add((object) "set_int_02_decal_09");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Item = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Item.Add((object) "None");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Item.Add((object) "Utility");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Item.Add((object) "Prestige");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Item.Add((object) "Premier");
      // ISSUE: reference to a compiler-generated field
      displayClass4390.TF = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4390.TF.Add((object) true);
      // ISSUE: reference to a compiler-generated field
      displayClass4390.TF.Add((object) false);
      List<object> objectList = new List<object>();
      objectList.Add((object) "Color 1");
      objectList.Add((object) "Utility");
      objectList.Add((object) "Expertise");
      objectList.Add((object) "Altitude");
      objectList.Add((object) "Power");
      objectList.Add((object) "Authority");
      objectList.Add((object) "Influence");
      objectList.Add((object) "Order");
      objectList.Add((object) "Empire");
      objectList.Add((object) "Supremacy");
      objectList.Add((object) "Color 1");
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.DoomsdayHeistDLC, "Facility Customisation");
      this.GUIMenus.Add(uiMenu);
      // ISSUE: reference to a compiler-generated field
      displayClass4390.SColour = new UIMenuListItem("Shell Color : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.SColour);
      // ISSUE: reference to a compiler-generated field
      displayClass4390.GColour = new UIMenuListItem("Graphic Color : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.GColour);
      // ISSUE: reference to a compiler-generated field
      displayClass4390.OColour = new UIMenuListItem("Orbital Cannon Color : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.OColour);
      // ISSUE: reference to a compiler-generated field
      displayClass4390.SRColour = new UIMenuListItem("Security Room Color : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.SRColour);
      // ISSUE: reference to a compiler-generated field
      displayClass4390.LColour = new UIMenuListItem("Lounge Color : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.LColour);
      // ISSUE: reference to a compiler-generated field
      displayClass4390.SLColour = new UIMenuListItem("Sleeping Quarters Color : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.SLColour);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4390.G = new UIMenuListItem("Graphic : ", displayClass4390.Graphic, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.G);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4390.ORBITAL = new UIMenuListItem("Orbital Cannon : ", displayClass4390.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.ORBITAL);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4390.SecurityRoom = new UIMenuListItem("Security Room : ", displayClass4390.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.SecurityRoom);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4390.Lounge = new UIMenuListItem("Lounge : ", displayClass4390.Item, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.Lounge);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4390.SleepingQuarters = new UIMenuListItem("Sleeping Quarters : ", displayClass4390.Item, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4390.SleepingQuarters);
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass4390, __methodptr(\u003CSetupInteriorMenu\u003Eb__0)));
    }

    public void RefreshInteriors(int D, int Tower)
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03c")
      });
      if (this.Design == 0)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_02b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_02b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_02b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_02b")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_02b";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_02b";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_02b";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_02b";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design == 1)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_02c")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_02c")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_02c")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_02c")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_02c";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_02c";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_02c";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_02c";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design == 2)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_02a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_02a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_02a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_02a")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_02a";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_02a";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_02a";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_02a";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design == 3)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_01a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_01a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_01a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_01a")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_01a";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_01a";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_01a";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_01a";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design == 4)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_01b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_01b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_01b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_01b")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_01b";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_01b";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_01b";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_01b";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design == 5)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_01c")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_01c")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_01c")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_01c")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_01c";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_01c";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_01c";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_01c";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design == 6)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_03a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_03a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_03a")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_03a")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_03a";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_03a";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_03a";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_03a";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design == 7)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_02_office_03b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_dt1_11_office_03b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_13_office_03b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_sm_15_office_03b")
        });
        if (Tower == 0)
        {
          this.AracdiusTowerStyle = "ex_dt1_02_office_03b";
          this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
          this.Config.Save();
        }
        if (Tower == 1)
        {
          this.MazeBankTowerStyle = "ex_dt1_11_office_03b";
          this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
          this.Config.Save();
        }
        if (Tower == 2)
        {
          this.MazeBankWestTowerStyle = "ex_sm_15_office_03b";
          this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
          this.Config.Save();
        }
        if (Tower == 3)
        {
          this.MazeLombokTowerStyle = "ex_sm_13_office_01c";
          this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
          this.Config.Save();
        }
      }
      if (this.Design != 8)
        return;
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03c")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03c")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03c")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03c")
      });
      if (Tower == 0)
      {
        this.AracdiusTowerStyle = "ex_dt1_02_office_03c";
        this.Config.SetValue<string>("Interiors", "AracdiusTowerStyle", (M0) this.AracdiusTowerStyle);
        this.Config.Save();
      }
      if (Tower == 1)
      {
        this.MazeBankTowerStyle = "ex_dt1_11_office_03c";
        this.Config.SetValue<string>("Interiors", "MazeBankTowerStyle", (M0) this.MazeBankTowerStyle);
        this.Config.Save();
      }
      if (Tower == 2)
      {
        this.MazeBankWestTowerStyle = "ex_sm_15_office_03c";
        this.Config.SetValue<string>("Interiors", "MazeBankWestTowerStyle", (M0) this.MazeBankWestTowerStyle);
        this.Config.Save();
      }
      if (Tower == 3)
      {
        this.MazeLombokTowerStyle = "ex_sm_13_office_03c";
        this.Config.SetValue<string>("Interiors", "LombokTowerStyle", (M0) this.MazeLombokTowerStyle);
        this.Config.Save();
      }
    }

    private void SetupOrganization()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass441_0 displayClass4410 = new Class1.\u003C\u003Ec__DisplayClass441_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4410.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Arcadius");
      objectList1.Add((object) "Maze Bank");
      objectList1.Add((object) "Maze Bank West");
      objectList1.Add((object) "Lombok");
      List<object> objectList2 = new List<object>()
      {
        (object) "None",
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8",
        (object) "9",
        (object) "10",
        (object) "11",
        (object) "12",
        (object) "13",
        (object) "14",
        (object) "15",
        (object) "16",
        (object) "17",
        (object) "18",
        (object) "19",
        (object) "20",
        (object) "21",
        (object) "22",
        (object) "23",
        (object) "All"
      };
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.ExecutiveDLC, "Executive Tower Options");
      this.GUIMenus.Add(uiMenu);
      List<object> objectList3 = new List<object>();
      for (int index = 0; index < this.ExProp.Count - 1; ++index)
        objectList3.Add((object) this.ExProp[index]);
      List<object> objectList4 = new List<object>()
      {
        (object) "Disabled",
        (object) "Enabled"
      };
      // ISSUE: reference to a compiler-generated field
      displayClass4410.Towerver = new UIMenuListItem("Tower To Apply : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4410.Towerver);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D1 = new UIMenuItem("Executive Rich");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D1);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D2 = new UIMenuItem("Executive Cool");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D2);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D3 = new UIMenuItem("Executive Contrast");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D3);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D4 = new UIMenuItem("Old Spice Warms");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D4);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D5 = new UIMenuItem("Old Spice Classical");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D5);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D6 = new UIMenuItem("Old Spice Vintage");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D6);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D7 = new UIMenuItem("Power Broker Ice");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D7);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D8 = new UIMenuItem("Power Broker Conservative");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D8);
      // ISSUE: reference to a compiler-generated field
      displayClass4410.D9 = new UIMenuItem("Power Broker Polished");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4410.D9);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass4410, __methodptr(\u003CSetupOrganization\u003Eb__0)));
    }

    public void Setupmenu()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass442_0 displayClass4420 = new Class1.\u003C\u003Ec__DisplayClass442_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4420.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) 0);
      objectList1.Add((object) 1);
      objectList1.Add((object) 2);
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) 1);
      objectList2.Add((object) 2);
      objectList2.Add((object) 3);
      objectList2.Add((object) 4);
      objectList2.Add((object) 5);
      objectList2.Add((object) 6);
      objectList2.Add((object) 7);
      objectList2.Add((object) 8);
      objectList2.Add((object) 9);
      objectList2.Add((object) 10);
      objectList2.Add((object) 11);
      objectList2.Add((object) 12);
      objectList2.Add((object) 13);
      objectList2.Add((object) 14);
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) 1);
      objectList3.Add((object) 2);
      objectList3.Add((object) 3);
      objectList3.Add((object) 4);
      objectList3.Add((object) 5);
      objectList3.Add((object) 6);
      objectList3.Add((object) 7);
      objectList3.Add((object) 8);
      objectList3.Add((object) 9);
      objectList3.Add((object) 10);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.TF = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4420.TF.Add((object) true);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.TF.Add((object) false);
      List<object> objectList4 = new List<object>();
      objectList4.Add((object) 1);
      objectList4.Add((object) 2);
      objectList4.Add((object) 3);
      objectList4.Add((object) 4);
      objectList4.Add((object) 5);
      objectList4.Add((object) 6);
      objectList4.Add((object) 7);
      objectList4.Add((object) 8);
      objectList4.Add((object) 9);
      objectList4.Add((object) 10);
      objectList4.Add((object) 11);
      objectList4.Add((object) 12);
      objectList4.Add((object) 13);
      objectList4.Add((object) 14);
      UIMenu uiMenu1 = this.Woredrobepool.AddSubMenu(this.DoomsdayHeistDLC, "Avenger");
      this.GUIMenus.Add(uiMenu1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4420.list6 = new UIMenuListItem("Prop Activated : ", displayClass4420.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass4420.list6);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.AV1On = new UIMenuItem("Change Avenger Prop 1");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4420.AV1On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.AV2On = new UIMenuItem("Change Avenger Prop 2");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4420.AV2On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.AV3On = new UIMenuItem("Change Avenger Prop 3");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4420.AV3On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.AV4On = new UIMenuItem("Change Avenger Prop 4");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4420.AV4On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.AV5On = new UIMenuItem("Change Avenger Prop 5");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4420.AV5On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.AV6On = new UIMenuItem("Change Avenger Prop 6");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4420.AV6On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.list4 = new UIMenuListItem("Color : ", objectList3, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass4420.list4);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.PrimaryAvenger = new UIMenuItem("Set Avenger Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass4420.PrimaryAvenger);
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass4420, __methodptr(\u003CSetupmenu\u003Eb__0)));
      UIMenu uiMenu2 = this.Woredrobepool.AddSubMenu(this.AfterHoursDLC, "Terbyte");
      this.GUIMenus.Add(uiMenu2);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4420.list7 = new UIMenuListItem("Prop Activated : ", displayClass4420.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4420.list7);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.T1On = new UIMenuItem("Change Terbyte Prop 1");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass4420.T1On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.T2On = new UIMenuItem("Change Terbyte Prop 2");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass4420.T2On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.T3On = new UIMenuItem("Change Terbyte Prop 3");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass4420.T3On);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.list3 = new UIMenuListItem("Color : ", objectList3, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass4420.list3);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.PrimaryTerbyte = new UIMenuItem("Set Terrobyte Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass4420.PrimaryTerbyte);
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass4420, __methodptr(\u003CSetupmenu\u003Eb__1)));
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) "Command Center");
      objectList5.Add((object) "Living Quarters");
      List<object> objectList6 = new List<object>();
      objectList6.Add((object) "Empty Bay");
      objectList6.Add((object) "Living Quarters");
      objectList6.Add((object) "Weapons Workshop");
      objectList6.Add((object) "Weapons & Vehicle Workshop");
      List<object> objectList7 = new List<object>();
      objectList7.Add((object) "Empty Bay");
      objectList6.Add((object) "Living Quarters");
      objectList7.Add((object) "Personal Vehicle Storage");
      UIMenu uiMenu3 = this.Woredrobepool.AddSubMenu(this.GunrunningDLC, "MOC");
      this.GUIMenus.Add(uiMenu3);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.Moclist5 = new UIMenuListItem("Bay 1 : ", objectList5, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4420.Moclist5);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.Moclist6 = new UIMenuListItem("Bay 2 : ", objectList6, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4420.Moclist6);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.Moclist7 = new UIMenuListItem("Bay 3 : ", objectList7, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4420.Moclist7);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.GetColor2 = new UIMenuItem("Change Bay Combo");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4420.GetColor2);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.list1 = new UIMenuListItem("Primary : ", objectList1, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4420.list1);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.PrimaryMoc = new UIMenuItem("Get Primary Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4420.PrimaryMoc);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.list2 = new UIMenuListItem("Secondary : ", objectList2, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass4420.list2);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.SecondaryMoc = new UIMenuItem("Get Secondary Color ");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4420.SecondaryMoc);
      UIMenu uiMenu4 = this.Woredrobepool.AddSubMenu(uiMenu3, "Lighting");
      this.GUIMenus.Add(uiMenu4);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.listL = new UIMenuListItem("Lighting Color: ", objectList4, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem((UIMenuItem) displayClass4420.listL);
      // ISSUE: reference to a compiler-generated field
      displayClass4420.MocLight = new UIMenuItem("Set Moc Lighting to  ");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass4420.MocLight);
      // ISSUE: method pointer
      uiMenu4.add_OnItemSelect(new ItemSelectEvent((object) displayClass4420, __methodptr(\u003CSetupmenu\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass4420, __methodptr(\u003CSetupmenu\u003Eb__3)));
    }

    public Model RequestModel(int Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(250);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public bool int_to_bool(int i)
    {
      bool flag = false;
      if (i == 1)
        flag = true;
      if (i == 0)
        flag = true;
      return flag;
    }

    public void UnlockpenthouseDoors()
    {
      Function.Call((Hash) -563637040166458307L, new InputArgument[7]
      {
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_prop_vw_door_lounge_01a")
        })),
        InputArgument.op_Implicit(958.5333f),
        InputArgument.op_Implicit(24.8082f),
        InputArgument.op_Implicit(116.81f),
        InputArgument.op_Implicit(true),
        InputArgument.op_Implicit(90f),
        InputArgument.op_Implicit(false)
      });
      Function.Call((Hash) -563637040166458307L, new InputArgument[7]
      {
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_prop_vw_door_lounge_01a")
        })),
        InputArgument.op_Implicit(956.444f),
        InputArgument.op_Implicit(26.1138f),
        InputArgument.op_Implicit(116.81f),
        InputArgument.op_Implicit(true),
        InputArgument.op_Implicit(-90f),
        InputArgument.op_Implicit(false)
      });
      Function.Call((Hash) -563637040166458307L, new InputArgument[7]
      {
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_prop_vw_door_lounge_01a")
        })),
        InputArgument.op_Implicit(973.8256f),
        InputArgument.op_Implicit(54.3764f),
        InputArgument.op_Implicit(116.81f),
        InputArgument.op_Implicit(true),
        InputArgument.op_Implicit(90f),
        InputArgument.op_Implicit(false)
      });
      Function.Call((Hash) -563637040166458307L, new InputArgument[7]
      {
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_prop_vw_door_lounge_01a")
        })),
        InputArgument.op_Implicit(975.9149f),
        InputArgument.op_Implicit(53.0709f),
        InputArgument.op_Implicit(116.81f),
        InputArgument.op_Implicit(true),
        InputArgument.op_Implicit(-90f),
        InputArgument.op_Implicit(false)
      });
      Function.Call((Hash) -563637040166458307L, new InputArgument[7]
      {
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_prop_vw_panel_off_door_01")
        })),
        InputArgument.op_Implicit(969.5818f),
        InputArgument.op_Implicit(47.0427f),
        InputArgument.op_Implicit(116.2636f),
        InputArgument.op_Implicit(true),
        InputArgument.op_Implicit(-90f),
        InputArgument.op_Implicit(false)
      });
    }

    private void OnTick(object sender, EventArgs e)
    {
      this.UnlockpenthouseDoors();
      if (this.EnableBlips && this.InteriorBlips.Count > 0)
      {
        using (List<Blip>.Enumerator enumerator = this.InteriorBlips.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            Blip current = enumerator.Current;
            if (this.EnableDistanceBlips)
            {
              if (!this.ShowBlip_IgnorePlayerHeight)
              {
                if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current.get_Position()) < (double) this.ShowBlipDist && this.EnableDistanceBlips && Blip.op_Inequality(current, (Blip) null))
                  current.set_Alpha((int) byte.MaxValue);
                if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current.get_Position()) > (double) this.ShowBlipDist && this.EnableDistanceBlips && Blip.op_Inequality(current, (Blip) null))
                  current.set_Alpha(0);
              }
              if (this.ShowBlip_IgnorePlayerHeight)
              {
                Vector3 position = current.get_Position();
                ((Vector3) ref position).\u002Ector((float) position.X, (float) position.Y, (float) ((Entity) Game.get_Player().get_Character()).get_Position().Z);
                if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), position) < (double) this.ShowBlipDist && this.EnableDistanceBlips && Blip.op_Inequality(current, (Blip) null))
                  current.set_Alpha((int) byte.MaxValue);
                if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), position) > (double) this.ShowBlipDist && this.EnableDistanceBlips && Blip.op_Inequality(current, (Blip) null))
                  current.set_Alpha(0);
              }
            }
          }
        }
      }
      if (this.RogersScrapYard)
      {
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-609.32f),
          InputArgument.op_Implicit(-1611.93f),
          InputArgument.op_Implicit(26.9f)
        });
        Function.Call((Hash) 3216741939161133639L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num)
        });
        Function.Call((Hash) -2054918222796412691L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(1)
        });
        if ((bool) Function.Call<bool>((Hash) -7873760353273975770L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num)
        }))
          Function.Call((Hash) -2803667153384842412L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit(0)
          });
      }
      Ped character1 = Game.get_Player().get_Character();
      this.ifruit.Update();
      if (this.Woredrobepool != null && this.Woredrobepool.IsAnyMenuOpen())
        this.Woredrobepool.ProcessMenus();
      if (!this.Firsttime)
      {
        this.AddInteriorBlips();
        this.Firsttime = true;
        this.Interior();
      }
      Vector3 vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(105f, -744f, 45f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(105f, -744f, 45f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-593.22f, -1630f, 27f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-593.22f, -1630f, 27f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-590f, -1621f, 33f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-590f, -1621f, 33f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-609.9f, -1609.81f, 26f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-609.9f, -1609.81f, 26f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-106.9f, -8.67f, 70f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-106.9f, -8.67f, 70f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(961.6f, -2185.2f, 30.4f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(961.6f, -2185.2f, 30.4f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(1274.2f, -1720.9f, 54f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(1274.2f, -1720.9f, 54f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(1083.07f, -1974.7f, 30f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(1083.07f, -1974.7f, 30f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-14.2f, -1441.9f, 30f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-14.2f, -1441.9f, 30f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-1045.2f, -230.49f, 40f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-1045.2f, -230.49f, 40f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(717.9f, -975.7f, 24.9f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(717.9f, -975.7f, 24.9f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-60.6f, -1093.7f, 26.6f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-60.6f, -1093.7f, 26.6f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-38.46f, -1108.8f, 26.4f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-38.46f, -1108.8f, 26.4f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-631.5f, -237.7f, 38f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-631.5f, -237.7f, 38f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-258.1f, -2030f, 30f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-258.1f, -2030f, 30f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-258.1f, -2030.9f, 30f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-258.1f, -2030.9f, 30f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-254.7f, -2026.9f, 30f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-254.7f, -2026.9f, 30f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-251.3f, -2022.8f, 30f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-251.3f, -2022.8f, 30f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-564.2f, 275.5f, 82f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-564.2f, 275.5f, 82f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2500.455f, -272.03f, -58f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2500.455f, -272.03f, -58f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2506.33f, -269.4711f, -58f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2506.33f, -269.4711f, -58f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2514.7f, -281.2f, -64f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2514.7f, -281.2f, -64f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2464.5f, -279.1f, -70f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2464.5f, -279.1f, -70f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2491.8f, -238.5f, -70f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2491.8f, -238.5f, -70f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2525.9f, -253.11f, -60f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2525.9f, -253.11f, -60f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2509.2f, -260.7f, -40f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2509.2f, -260.7f, -40f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(134.3f, -2203.25f, 7f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(134.3f, -2203.25f, 7f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2501.32f, -279.128f, -59f)) < 10.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2501.32f, -279.128f, -59f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(3621.4f, 3752.2f, 28f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(3621.4f, 3752.2f, 28f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(3627.9f, 3747.059f, 28f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(3627.9f, 3747.059f, 28f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2452.3f, 4969.633f, 46f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2452.3f, 4969.633f, 46f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2440.6f, 4982.4f, 46f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2440.6f, 4982.4f, 46f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2436.2f, 4975.3f, 46f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2436.2f, 4975.3f, 46f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2453.1f, 4970.3f, 46f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2453.1f, 4970.3f, 46f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2440.8f, 4982.33f, 46f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2440.8f, 4982.33f, 46f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2449.373f, 4989f, 46f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2449.373f, 4989f, 46f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-110.9154f, 6462.701f, 31.6f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-110.9154f, 6462.701f, 31.6f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(491.95f, -3116.307f, 6f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(491.95f, -3116.307f, 6f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(476.3725f, -3115.5f, 6f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(476.3725f, -3115.5f, 6f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-1082.6f, -259.35f, 37f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-1082.6f, -259.35f, 37f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(241.8f, 360.68f, 105f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(241.8f, 360.68f, 105f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(134.4f, -2203.4f, 7f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(134.4f, -2203.4f, 7f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(2331.2f, 2575.4f, 46f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(2231.2f, 2575.4f, 46f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(242.3f, 361.09f, 105f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(242.3f, 361.09f, 105f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(483.5f, -1312.5f, 29f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(483.5f, -1312.5f, 29f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(-1150.3f, -1521.05f, 10f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(-1150.3f, -1521.05f, 10f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(1845.3f, 2605.3f, 45.5f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(1845.3f, 2605.3f, 45.5f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      vector3 = ((Entity) character1).get_Position();
      if ((double) ((Vector3) ref vector3).DistanceTo(new Vector3(1818.8f, 2605.4f, 45.5f)) < 100.0)
      {
        Prop[] nearbyProps = World.GetNearbyProps(new Vector3(1818.8f, 2605.4f, 45.5f), 5f);
        if ((uint) nearbyProps.Length > 0U)
        {
          foreach (Prop prop in nearbyProps)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).set_FreezePosition(false);
          }
        }
      }
      if (!this.VangelicoOpen)
        ;
      Prop[] nearbyProps1 = World.GetNearbyProps(new Vector3(-180.4f, -1017.16f, 114f), 5f, Model.op_Implicit(1925435073));
      if ((uint) nearbyProps1.Length > 0U)
      {
        foreach (Prop prop in nearbyProps1)
        {
          if (Entity.op_Inequality((Entity) prop, (Entity) null))
            this.Lift2 = prop;
        }
      }
      Prop[] nearbyProps2 = World.GetNearbyProps(new Vector3(-183.7f, -1015.6f, 30f), 5f, Model.op_Implicit(1925435073));
      if ((uint) nearbyProps2.Length > 0U)
      {
        foreach (Prop prop in nearbyProps2)
        {
          if (Entity.op_Inequality((Entity) prop, (Entity) null))
            this.Lift1 = prop;
        }
      }
      if (Entity.op_Inequality((Entity) this.Lift1, (Entity) null))
      {
        Ped character2 = Game.get_Player().get_Character();
        vector3 = ((Entity) character2).get_Position();
        if ((double) ((Vector3) ref vector3).DistanceTo(((Entity) this.Lift1).GetOffsetInWorldCoords(new Vector3(0.0f, -2f, -2.2f))) < 300.0)
          World.DrawMarker((MarkerType) 1, ((Entity) this.Lift1).GetOffsetInWorldCoords(new Vector3(0.0f, -2f, -2.2f)), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.75f, 0.75f, 0.65f), Color.FromArgb(0, 147, (int) byte.MaxValue));
        vector3 = ((Entity) character2).get_Position();
        if ((double) ((Vector3) ref vector3).DistanceTo(((Entity) this.Lift1).GetOffsetInWorldCoords(new Vector3(0.0f, -2f, -2.2f))) < 5.0)
        {
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Start/Stop Elevator");
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            this.LiftOn1 = !this.LiftOn1;
            if (((Entity) this.Lift1).get_Position().Z < 35.0)
              this.LiftDic1 = 1;
            if (((Entity) this.Lift1).get_Position().Z > 114.0)
              this.LiftDic1 = -1;
            UI.ShowSubtitle("Lift On " + this.LiftOn1.ToString() + "__" + this.LiftDic1.ToString());
          }
        }
      }
      if (Entity.op_Inequality((Entity) this.Lift2, (Entity) null))
      {
        Ped character2 = Game.get_Player().get_Character();
        vector3 = ((Entity) character2).get_Position();
        if ((double) ((Vector3) ref vector3).DistanceTo(((Entity) this.Lift2).GetOffsetInWorldCoords(new Vector3(0.0f, -2f, -2.2f))) < 300.0)
          World.DrawMarker((MarkerType) 1, ((Entity) this.Lift2).GetOffsetInWorldCoords(new Vector3(0.0f, -2f, -2.2f)), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.75f, 0.75f, 0.65f), Color.FromArgb(0, 147, (int) byte.MaxValue));
        vector3 = ((Entity) character2).get_Position();
        if ((double) ((Vector3) ref vector3).DistanceTo(((Entity) this.Lift2).GetOffsetInWorldCoords(new Vector3(0.0f, -2f, -2.2f))) < 5.0)
        {
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Start/Stop Elevator");
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            this.LiftOn2 = !this.LiftOn2;
            if (((Entity) this.Lift2).get_Position().Z < 35.0)
              this.LiftDic2 = 1;
            if (((Entity) this.Lift2).get_Position().Z > 114.0)
              this.LiftDic2 = -1;
            UI.ShowSubtitle("Lift On " + this.LiftOn2.ToString() + "__" + this.LiftDic2.ToString());
          }
        }
      }
      if (this.LiftOn2 && Entity.op_Inequality((Entity) this.Lift2, (Entity) null))
      {
        Prop lift2 = this.Lift2;
        if (this.LiftDic2 == 1 && (((Entity) lift2).get_Position().Z > 30.0 && ((Entity) lift2).get_Position().Z < 115.400001525879))
          ((Entity) lift2).set_Position(new Vector3((float) ((Entity) lift2).get_Position().X, (float) ((Entity) lift2).get_Position().Y, (float) (((Entity) lift2).get_Position().Z + 0.100000001490116)));
        if (this.LiftDic2 == -1 && (((Entity) lift2).get_Position().Z > 31.2999992370605 && ((Entity) lift2).get_Position().Z < 116.0))
          ((Entity) lift2).set_Position(new Vector3((float) ((Entity) lift2).get_Position().X, (float) ((Entity) lift2).get_Position().Y, (float) (((Entity) lift2).get_Position().Z - 0.100000001490116)));
      }
      if (this.LiftOn1 && Entity.op_Inequality((Entity) this.Lift1, (Entity) null))
      {
        Prop lift1 = this.Lift1;
        if (this.LiftDic1 == 1 && (((Entity) lift1).get_Position().Z > 30.0 && ((Entity) lift1).get_Position().Z < 115.400001525879))
          ((Entity) lift1).set_Position(new Vector3((float) ((Entity) lift1).get_Position().X, (float) ((Entity) lift1).get_Position().Y, (float) (((Entity) lift1).get_Position().Z + 0.100000001490116)));
        if (this.LiftDic1 == -1 && (((Entity) lift1).get_Position().Z > 31.2999992370605 && ((Entity) lift1).get_Position().Z < 116.0))
          ((Entity) lift1).set_Position(new Vector3((float) ((Entity) lift1).get_Position().X, (float) ((Entity) lift1).get_Position().Y, (float) (((Entity) lift1).get_Position().Z - 0.100000001490116)));
      }
      if (!this.EnableMarkers_Teleport)
        return;
      for (int index = 0; index < this.EnterPos.Count; ++index)
      {
        Ped character2 = Game.get_Player().get_Character();
        vector3 = ((Entity) character2).get_Position();
        if ((double) ((Vector3) ref vector3).DistanceTo(this.EnterPos[index]) < 300.0)
        {
          vector3 = (Vector3) null;
          World.DrawMarker((MarkerType) 1, vector3, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.75f, 0.75f, 0.65f), Color.Blue);
          World.DrawMarker((MarkerType) 1, this.EnterPos[index], Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.75f, 0.75f, 0.65f), Color.FromArgb(0, 147, (int) byte.MaxValue));
        }
        vector3 = ((Entity) character2).get_Position();
        if ((double) ((Vector3) ref vector3).DistanceTo(this.ExitPos[index]) < 300.0)
          World.DrawMarker((MarkerType) 1, this.ExitPos[index], Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.75f, 0.75f, 0.65f), Color.FromArgb(0, 147, (int) byte.MaxValue));
        vector3 = ((Entity) character2).get_Position();
        if ((double) ((Vector3) ref vector3).DistanceTo(this.EnterPos[index]) < 1.5)
        {
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Enter Interior");
          if (Game.IsControlJustPressed(2, (Control) 51))
            ((Entity) Game.get_Player().get_Character()).set_Position(this.ExitPos[index]);
        }
        else
        {
          vector3 = ((Entity) character2).get_Position();
          if ((double) ((Vector3) ref vector3).DistanceTo(this.ExitPos[index]) < 1.5)
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Exit Interior");
            if (Game.IsControlJustPressed(2, (Control) 51))
              ((Entity) Game.get_Player().get_Character()).set_Position(this.EnterPos[index]);
          }
        }
      }
    }

    private void SetupNightclubOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass471_0 displayClass4710 = new Class1.\u003C\u003Ec__DisplayClass471_0();
      // ISSUE: reference to a compiler-generated field
      displayClass4710.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>()
      {
        (object) "Los Santos Rock Radio",
        (object) "Non-Stop-Pop FM",
        (object) "Radio Los Santos",
        (object) "Channel X",
        (object) "West Coast Talk Radio",
        (object) "Rebel Radio",
        (object) "Soulwax FM",
        (object) "East Los FM",
        (object) "West Coast Classics",
        (object) "Blue Ark",
        (object) "World Wide FM",
        (object) "FlyLo FM",
        (object) "The Lowdown 91.1",
        (object) "The Lab",
        (object) "Radio Mirror Park",
        (object) "Space 103.2",
        (object) "Vinewood Boulevard Radio",
        (object) "Blonded Los Santos 97.8 FM",
        (object) "Los Santos Underground Radio",
        (object) "IFruit Radio",
        (object) "Self Radio"
      };
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) false);
      objectList2.Add((object) true);
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) "Traditional");
      objectList3.Add((object) "Edgy");
      objectList3.Add((object) "Glamorous");
      List<object> objectList4 = new List<object>()
      {
        (object) "Style 1 ",
        (object) "Style 2",
        (object) "Style 3"
      };
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) "Traditional");
      objectList5.Add((object) "Edgy");
      objectList5.Add((object) "Glamorous");
      List<object> objectList6 = new List<object>();
      objectList6.Add((object) "Booze 1");
      objectList6.Add((object) "Booze 2");
      objectList6.Add((object) "Booze 3");
      List<object> objectList7 = new List<object>()
      {
        (object) "Tale of Us",
        (object) "Dixon",
        (object) "Solomun ",
        (object) "Black Madonna"
      };
      List<object> objectList8 = new List<object>()
      {
        (object) "None",
        (object) "GEO",
        (object) "LED",
        (object) "LSER",
        (object) "NR"
      };
      List<object> objectList9 = new List<object>();
      objectList9.Add((object) "Upgrade Option 1");
      objectList9.Add((object) "Upgrade Option 2");
      objectList9.Add((object) "Upgrade Option 3");
      objectList9.Add((object) "Upgrade Option 4");
      List<object> objectList10 = new List<object>();
      objectList10.Add((object) "None");
      objectList10.Add((object) "Studio Los Santos");
      objectList10.Add((object) "Omega");
      objectList10.Add((object) "Technologie");
      objectList10.Add((object) "Gefangnis");
      objectList10.Add((object) "Maisonette");
      objectList10.Add((object) "Tony's Fun House");
      objectList10.Add((object) "The Palace");
      objectList10.Add((object) "Paradise");
      objectList10.Add((object) "Galaxy");
      List<object> objectList11 = new List<object>();
      objectList11.Add((object) "Trophies x1");
      objectList11.Add((object) "Trophies x2");
      objectList11.Add((object) "Trophies x3");
      objectList11.Add((object) "Trophies x4");
      objectList11.Add((object) "Trophies x5");
      objectList11.Add((object) "Trophies x6");
      objectList11.Add((object) "Trophies x7");
      objectList11.Add((object) "Trophies x8");
      objectList11.Add((object) "Trophies x9");
      List<object> objectList12 = new List<object>()
      {
        (object) "Type A",
        (object) "Type B",
        (object) "Type C",
        (object) "Type D",
        (object) "Type E",
        (object) "Type F",
        (object) "Type G",
        (object) "Type H"
      };
      List<object> objectList13 = new List<object>()
      {
        (object) "Female",
        (object) "Male"
      };
      List<object> objectList14 = new List<object>()
      {
        (object) "0x (No Dry Ice)",
        (object) "1x",
        (object) "2x",
        (object) "3x",
        (object) "4x",
        (object) "5x",
        (object) "6x",
        (object) "7x",
        (object) "8x",
        (object) "9x",
        (object) "10x",
        (object) "11x",
        (object) "12x",
        (object) "13x",
        (object) "14x",
        (object) "15x"
      };
      List<object> objectList15 = new List<object>()
      {
        (object) "White",
        (object) "Yellow",
        (object) "Green",
        (object) "GreenYellow",
        (object) "Lime",
        (object) "Red",
        (object) "PowderBlue",
        (object) "Violet",
        (object) "Turquoise",
        (object) "Orange",
        (object) "Pink",
        (object) "AliceBlue",
        (object) "BlueViolet",
        (object) "Blue",
        (object) "Cyan",
        (object) "Magenta",
        (object) "Gray",
        (object) "LightBlue",
        (object) "LightCyan",
        (object) "Gold",
        (object) "Lavender",
        (object) "Silver",
        (object) "Snow",
        (object) "YellowGreen",
        (object) "Goldenrod",
        (object) "GhostWhite"
      };
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.AfterHoursDLC, "NightClub");
      this.GUIMenus.Add(uiMenu);
      UIMenuItem uiMenuItem = new UIMenuItem("----------------Night Club Options-----------------");
      uiMenu.AddItem(uiMenuItem);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.S = new UIMenuListItem("Style  : ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.S);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.p = new UIMenuListItem("Podium : ", objectList5, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.p);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.b = new UIMenuListItem("Booze : ", objectList6, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.b);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.secu = new UIMenuListItem("Security Upgrade : ", objectList9, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.secu);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.cn = new UIMenuListItem("Club Name : ", objectList10, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.cn);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.tr = new UIMenuListItem("Amt of Trophies : ", objectList11, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.tr);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.LR = new UIMenuListItem("Light Rig On : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.LR);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.CL = new UIMenuListItem("Clutter On : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.CL);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.DT = new UIMenuListItem("Delivery Truck On : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.DT);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.WK = new UIMenuListItem("Work Lights On : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass4710.WK);
      // ISSUE: reference to a compiler-generated field
      displayClass4710.SaveInt = new UIMenuItem("Refresh");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass4710.SaveInt);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass4710, __methodptr(\u003CSetupNightclubOptions\u003Eb__0)));
    }

    private void DisplayHelpTextThisFrame(string text)
    {
      Function.Call((Hash) -8860350453193909743L, new InputArgument[1]
      {
        InputArgument.op_Implicit("STRING")
      });
      Function.Call((Hash) 7789129354908300458L, new InputArgument[1]
      {
        InputArgument.op_Implicit(text)
      });
      Function.Call((Hash) 2562546386151446694L, new InputArgument[4]
      {
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(-1)
      });
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
    }

    public void RefreshInterior(int Interior, int Propid)
    {
      if (Propid == 1)
      {
        for (int index = 1; index < 5; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("garage_decor_0" + index.ToString())
          });
      }
      if (Propid == 2)
      {
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("lighting_option0" + index.ToString())
          });
      }
      if (Propid == 3)
      {
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("numbering_style0" + index.ToString() + "_n1")
          });
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("numbering_style0" + index.ToString() + "_n2")
          });
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("numbering_style0" + index.ToString() + "_n3")
          });
      }
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Interior)
      });
    }

    public void RefreshInterior(int Interior, string prop, int Propid)
    {
      if (Propid == 1)
      {
        for (int index = 1; index < 5; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("garage_decor_0" + index.ToString())
          });
      }
      if (Propid == 2)
      {
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("lighting_option0" + index.ToString())
          });
      }
      if (Propid == 3)
      {
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("numbering_style0" + index.ToString() + "_n1")
          });
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("numbering_style0" + index.ToString() + "_n2")
          });
        for (int index = 1; index < 10; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Interior),
            InputArgument.op_Implicit("numbering_style0" + index.ToString() + "_n3")
          });
      }
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(Interior),
        InputArgument.op_Implicit(prop)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Interior)
      });
    }

    public void Interior()
    {
      using (List<Prop>.Enumerator enumerator = this.OnlineProp.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(1171954070), new Vector3(954.7f, -3018.3f, -37.88f), new Vector3(0.0f, 0.0f, -89.99969f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-239044249), new Vector3(954.7f, -3023.6f, -37.88f), new Vector3(-5.97114E-13f, -5.008956E-06f, -89.99999f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-2063295939), new Vector3(954.7f, -3028.65f, -37.88f), new Vector3(1.001791E-05f, -5.008956E-06f, -89.99999f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(726001049), new Vector3(959.35f, -3035.9f, -37.88f), new Vector3(1.001791E-05f, -5.008956E-06f, 0.2500072f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-556906753), new Vector3(963.5f, -3036f, -37.88152f), new Vector3(1.001791E-05f, 2.231179E-05f, 1.000003f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-758434067), new Vector3(967.7f, -3035.9f, -37.88f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-812602640), new Vector3(971.85f, -3035.8f, -37.88f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(1171954070), new Vector3(975.95f, -3036.2f, -37.88152f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-239044249), new Vector3(980.15f, -3036f, -37.88152f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-2063295939), new Vector3(993.15f, -3027.098f, -37.88f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(726001049), new Vector3(998.5f, -3026.85f, -37.88152f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-556906753), new Vector3(1004f, -3026.995f, -37.88152f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-758434067), new Vector3(1009.25f, -3026.95f, -37.88152f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-812602640), new Vector3(978.15f, -3009.6f, -40.65f), new Vector3(0.0f, 0.0f, 0.0f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(1171954070), new Vector3(978.05f, -2994.05f, -40.65f), new Vector3(0.0f, 0.0f, 179.001f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(1840382115), new Vector3(908.6f, -3207.25f, -98.2f), new Vector3(1.001791E-05f, -5.008955E-06f, 23.24998f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(1210660950), new Vector3(-1294.5f, -3004.25f, -49.5f), new Vector3(1.001791E-05f, 5.008956E-06f, -89.99969f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(630616933), new Vector3(-362.3418f, 4829.795f, 142.776f), new Vector3(0.0f, 0.0f, -39.506f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(1723871309), new Vector3(-1291.835f, 6907.326f, -105.2364f), new Vector3(0.0f, 0.0f, 90f), false, false));
      this.OnlineProp.Add(World.CreateProp(Model.op_Implicit(-1676285810), new Vector3(-1291.835f, 6907.326f, -105.2364f), new Vector3(0.0f, 0.0f, 90f), false, false));
      using (List<Prop>.Enumerator enumerator = this.OnlineProp.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).set_FreezePosition(true);
        }
      }
      UI.Notify("~b~EAI~w~ Loading Interior");
      this.LoadIniFile("scripts//EnableAllInteriors.ini");
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_biker_interior_placement_interior_0_biker_dlc_int_01_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_biker_interior_placement_interior_1_biker_dlc_int_02_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_biker_interior_placement_interior_2_biker_dlc_int_ware01_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_biker_interior_placement_interior_3_biker_dlc_int_ware02_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_biker_interior_placement_interior_4_biker_dlc_int_ware03_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_biker_interior_placement_interior_6_biker_dlc_int_ware05_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_biker_interior_placement_interior_5_biker_dlc_int_ware04_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_exec_warehouse_placement_interior_1_int_warehouse_s_dlc_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_exec_warehouse_placement_interior_2_int_warehouse_l_dlc_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_exec_warehouse_placement_interior_0_int_warehouse_m_dlc_milo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gr_Heist_Yacht2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gr_Heist_Yacht2_enginrm")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gr_Heist_Yacht2_Lounge")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gr_Heist_Yacht2_Bridge")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gr_Heist_Yacht2_Bar")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gr_Heist_Yacht2_Bedrm")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gunrunning_yacht_jacuzzi")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_4_x17dlc_int_facility_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_5_x17dlc_int_facility2_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_8_x17dlc_int_sub_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_0_x17dlc_int_base_ent_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_1_x17dlc_int_base_loop_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_2_x17dlc_int_bse_tun_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_3_x17dlc_int_base_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_6_x17dlc_int_silo_01_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_7_x17dlc_int_silo_02_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_10_x17dlc_int_tun_straight_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_11_x17dlc_int_tun_slope_flat_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_12_x17dlc_int_tun_flat_slope_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_13_x17dlc_int_tun_30d_r_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_14_x17dlc_int_tun_30d_l_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_15_x17dlc_int_tun_straight_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_16_x17dlc_int_tun_straight_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_17_x17dlc_int_tun_slope_flat_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_18_x17dlc_int_tun_slope_flat_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_19_x17dlc_int_tun_flat_slope_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_20_x17dlc_int_tun_flat_slope_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_21_x17dlc_int_tun_30d_r_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_22_x17dlc_int_tun_30d_r_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_23_x17dlc_int_tun_30d_r_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_24_x17dlc_int_tun_30d_r_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_25_x17dlc_int_tun_30d_l_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_26_x17dlc_int_tun_30d_l_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_27_x17dlc_int_tun_30d_l_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_28_x17dlc_int_tun_30d_l_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_29_x17dlc_int_tun_30d_l_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_34_x17dlc_int_lab_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_35_x17dlc_int_tun_entry_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_strm_0")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_main\xFEFF")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_carrier")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_carrier_DistantLights")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_Carrier_int1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_Carrier_int2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_Carrier_int3")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_Carrier_int4")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_Carrier_int5")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_Carrier_int6")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("hei_carrier_LODLights")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01d")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01e")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01f")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01g")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01h")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01i")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01j")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01k")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue01z")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue02")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue03")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue03_grv_dug")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue_grv_torch")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue04")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue04b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue04_cover")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_protree_end")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_protree_start")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue05")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue05b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue06")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue06b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue06_int")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue06_pannel")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("plg_occl_00")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologue_occl")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologuerd")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prologuerdb")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_11_modgarage")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_15_cargarage_a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_15_cargarage_b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_15_cargarage_c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_15_modgarage")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_13_cargarage_a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_13_cargarage_b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_13_cargarage_c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_sm_13_modgarage")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_11_cargarage_a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_11_cargarage_b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_11_cargarage_c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_02_cargarage_a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_02_cargarage_b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_02_cargarage_c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("imp_dt1_02_modgarage")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("airfield")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("AP1_04_TriAf01")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bh1_16_refurb")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("BH1_47_JoshHse_Burnt")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bh1_47_joshhse_firevfx")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("BH1_47_JoshHse_UnBurnt")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("BH1_48_Killed_Michael")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bnkheist_apt_dest")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bnkheist_apt_norm")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("burgershot_yoga")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("burnt_switch_off")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("cargoship")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("canyonriver01")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("railing_start")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("canyonriver01_traincrash")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("railing_end")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("chemgrill_grp1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CH1_07_TriAf03")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CH3_RD2_BishopsChickenGraffiti")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("chop_props")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("chophillskennel")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CJ_IOABoat")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("coronertrash")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Coroner_Int_off")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Coroner_Int_on")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("crashed_cargoplane")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_offmission")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission1 ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission3")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission4")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS2_06_TriAf02")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS3_05_water_grp1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS3_05_water_grp2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("cs3_07_mpgates")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS4_08_TriAf02")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS4_04_TriAf03")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS5_04_MazeBillboardGraffiti")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("cs5_4_trains")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS5_Roads_RonOilGraffiti")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhouse")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_endimap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_end_occl")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_startimap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_start_occl ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_ProTree_start")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_ProTree_start_lod")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_Smash2_endimap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_Smash2_startimap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_StiltHouse_imapend")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_StiltHouse_imapstart")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_stilthouse_rebuild")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_HC_REMOVE")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_HC_REQ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_REQUEST")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_rubble")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_17_OldBill")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_17_NewBill")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_21_prop_lift_on")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fakeint")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm_burnt")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm_burnt_props")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farmint_cap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farmint")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm_props")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FBI_colPLUG ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FIBlobby ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FIBlobbyfake")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FBI_repair")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ferris_finale_Anim")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FruitBB")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gasparticle_grp2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gasstation_ipl_group1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gasstation_ipl_group2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_during_door")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_during1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_during2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_on_fire")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_post_no_int")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_pre_no_int")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ID2_21_G_Night")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Jetsteal_ipl_grp1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Jetsteal_ipl_grp2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("jetstealtunnel")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("jewel2fake")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Jewel_Gasmasks")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("layer_sextoys_a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("layer_torture")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ld_rail_02_track")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("MG")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Michael_premier")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("occl_meth_grp1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Plane_crash_trench")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("post_hiest_unload")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("facelobby")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_cheetah_covered")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_entityXF_covered")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_jb700_covered")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_ztype_covered")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("RC12B_Default")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("RC12B_Destroyed ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("RC12B_Fixed")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("RC12B_HospitalInterior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("refit_unload")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SC1_01_NewBill")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SC1_01_OldBill ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SC1_30_Keep_Closed")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ship_occ_grp1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ship_occ_grp2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("shr_int")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("smboat")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SM_15_BldGRAF1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("sunkcargoship")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp0")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp3")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TrevorsMP")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TrevorsTrailer")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TrevorsTrailerTidy")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TrevorsTrailerTrash")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("triathlon2_VBprops")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TRV1_Trail_end")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TRV1_Trail_Finish")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TRV1_Trail_start")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("UFO")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_35_Fireman ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("VB_08_TriAf01")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("v_carshowroom")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("shutter_open")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("shutter_closed")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("shr_int")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("csr_inMission")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fakeint")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_Garage")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_FameShame")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_JewelHeist")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_plane_ticket")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_Scuba")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("v_tunnel_hole")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("v_tunnel_hole_swap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("yogagame")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FINBANK")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_03_Shutter")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_03_Gr_Closed")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_tankercrash")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("airfield")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("AP1_04_TriAf01")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bh1_16_refurb")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("BH1_47_JoshHse_Burnt")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bh1_47_joshhse_firevfx")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("BH1_47_JoshHse_UnBurnt")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("BH1_48_Killed_Michael")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bnkheist_apt_dest")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bnkheist_apt_norm")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("burgershot_yoga")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("burnt_switch_off")
      });
      if (!this.SunkenCargoShipOn)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("sunkcargoship")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("cargoship")
        });
      }
      if (!this.SunkenCargoShipOn)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("cargoship")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("sunkcargoship")
        });
      }
      if (!this.TrainCrashOn)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("canyonriver01")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("railing_start")
        });
      }
      if (this.TrainCrashOn)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("canyonriver01")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("canyonriver01_traincrash")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("railing_end")
        });
      }
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("chemgrill_grp1")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CH1_07_TriAf03")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CH3_RD2_BishopsChickenGraffiti")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("chop_props")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("chophillskennel")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CJ_IOABoat")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("coronertrash")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Coroner_Int_off")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Coroner_Int_on")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("crashed_cargoplane")
      });
      if (!this.CluckenBellOn)
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("CS1_02_cf_offmission")
        });
      if (this.CluckenBellOn)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("CS1_02_cf_onmission1 ")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("CS1_02_cf_onmission2")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("CS1_02_cf_onmission3")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("CS1_02_cf_onmission4")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("CS2_06_TriAf02")
        });
      }
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS3_05_water_grp1")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS3_05_water_grp2")
      });
      if (!this.FortZancudoGates)
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("cs3_07_mpgates")
        });
      if (this.FortZancudoGates)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("cs3_07_mpgates")
        });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS4_08_TriAf02")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS4_04_TriAf03")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS5_04_MazeBillboardGraffiti")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("cs5_4_trains")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS5_Roads_RonOilGraffiti")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhouse")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_endimap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_end_occl")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_startimap")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("des_farmhs_start_occl ")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_ProTree_start")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_ProTree_start_lod")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_HC_REMOVE")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_HC_REQ")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_REQUEST")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_05_rubble")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_17_OldBill")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_17_NewBill")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_21_prop_lift_on")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fakeint")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm_burnt")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm_burnt_props")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farmint_cap")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farmint")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("farm_props")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FBI_colPLUG ")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FIBlobby ")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FIBlobbyfake")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FBI_repair")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ferris_finale_Anim")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("FruitBB")
      });
      if (this.GasStationOnFire)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gasparticle_grp2")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gasstation_ipl_group1")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gasstation_ipl_group2")
        });
      }
      if (!this.GasStationOnFire)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gasparticle_grp2")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gasstation_ipl_group1")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gasstation_ipl_group2")
        });
      }
      if (this.MeltdownPremire)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("redCarpet")
        });
      if (!this.MeltdownPremire)
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("redCarpet")
        });
      if (this.fixedPaletoHotel)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bnkheist_apt_norm")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bnkheist_apt_dest")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("mic3_chopper_debris")
        });
      }
      if (!this.fixedPaletoHotel)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("mic3_chopper_debris")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bnkheist_apt_dest")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bnkheist_apt_norm")
        });
      }
      if (this.DestroyedSilthouse)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_StiltHouse_imapend")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("des_stilthouse_rebuild")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_StiltHouse_imapstart")
        });
      }
      if (!this.DestroyedSilthouse)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_StiltHouse_imapend")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("des_stilthouse_rebuild")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_StiltHouse_imapstart")
        });
      }
      if (this.fixedCypressFlatsBrickWall)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_Smash2_endimap")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_Smash2_startimap")
        });
      }
      if (!this.fixedCypressFlatsBrickWall)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_Smash2_endimap")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DES_Smash2_startimap")
        });
      }
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bkr_bi_hw1_13_int")
      });
      if (this.BurntJoshsMansion)
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("BH1_47_JoshHse_UnBurnt")
        });
      if (!this.BurntJoshsMansion)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("BH1_47_JoshHse_UnBurnt")
        });
      if (this.RepairedStabCity)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparka_grp1")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparkb_grp1")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparkc_grp1")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparkd_grp1")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparke_grp1")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("methtrailer_grp1")
        });
      }
      if (!this.RepairedStabCity)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparka_grp1")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparkb_grp1")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparkc_grp1")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparkd_grp1")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("trailerparke_grp1")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("methtrailer_grp1")
        });
      }
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ufo")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ufo_eye")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ufo_lod")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_during_door")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_during1")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_during2")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_on_fire")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_post_no_int")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("id2_14_pre_no_int")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ID2_21_G_Night")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Jetsteal_ipl_grp1")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Jetsteal_ipl_grp2")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("jetstealtunnel")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Jewel_Gasmasks")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("layer_sextoys_a")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("layer_torture")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ld_rail_02_track")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("MG")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("Michael_premier")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("occl_meth_grp1")
      });
      if (this.PlaneCrashOn)
      {
        if (Entity.op_Inequality((Entity) this.PlaneCrash, (Entity) null))
          ((Entity) this.PlaneCrash).Delete();
        this.PlaneCrash = World.CreateProp(this.RequestModel("xm_prop_x17_shamal_crash"), new Vector3(2817f, 4790f, 47f), new Vector3(0.0f, -10f, -14f), false, false);
        ((Entity) this.PlaneCrash).set_FreezePosition(true);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("Plane_crash_trench")
        });
      }
      if (!this.PlaneCrashOn)
      {
        if (Entity.op_Inequality((Entity) this.PlaneCrash, (Entity) null))
          ((Entity) this.PlaneCrash).Delete();
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("Plane_crash_trench")
        });
      }
      if (!this.VangelicoOpen)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("jewel2fake")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("refit_unload")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("post_hiest_unload")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bh1_16_doors_shut")
        });
      }
      if (!this.MaxRendaBuilding)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bh1_16_doors_shut")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bh1_16_doors_shut")
        });
      }
      if (this.MaxRendaBuilding)
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bh1_16_doors_shut")
        });
      if (this.VangelicoOpen)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("v_refit")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("jewel2fake")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("refit_unload")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("post_hiest_unload")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("post_hiest_unload")
        });
      }
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("facelobbyfake")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("facelobby")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_cheetah_covered")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_entityXF_covered")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_jb700_covered")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("prop_ztype_covered")
      });
      if (this.HospitalDestroyed)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_Fixed")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_HospitalInterior")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_Default")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_Destroyed ")
        });
      }
      if (!this.HospitalDestroyed)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_Default")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_Destroyed ")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_Fixed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("RC12B_HospitalInterior")
        });
      }
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SC1_01_NewBill")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SC1_01_OldBill ")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SC1_30_Keep_Closed")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ship_occ_grp1")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ship_occ_grp2")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("shr_int")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("smboat")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("SM_15_BldGRAF1")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp0")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp1")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp2")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("tankerexp_grp3")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TrevorsMP")
      });
      if (this.TrailerTidy)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("TrevorsTrailerTidy")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("TrevorsTrailerTrash")
        });
      }
      if (!this.TrailerTidy)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("TrevorsTrailerTidy")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("TrevorsTrailerTrash")
        });
      }
      if (this.TriathalonProps)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("triathlon2_VBprops")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("VB_08_TriAf01")
        });
      }
      if (!this.TriathalonProps)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("triathlon2_VBprops")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("VB_08_TriAf01")
        });
      }
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TRV1_Trail_end")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TRV1_Trail_Finish")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("TRV1_Trail_start")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("UFO")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_35_Fireman ")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("v_carshowroom")
      });
      if (this.SimeonsShowroom)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("shr_int")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("csr_inMission")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("shutter_closed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("shutter_open")
        });
      }
      if (!this.SimeonsShowroom)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("fakeint")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("shutter_closed")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("shutter_open")
        });
      }
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_Garage")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_FameShame")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_JewelHeist")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_plane_ticket")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_Michael_Scuba")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("v_tunnel_hole")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("v_tunnel_hole_swap")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("yogagame")
      });
      if (this.UnionDepositoryActive)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("FINBANK")
        });
      if (this.HumaineLabsGrate)
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DT1_03_Gr_Closed")
        });
      if (!this.HumaineLabsGrate)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("DT1_03_Gr_Closed")
        });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DES_tankercrash")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("sp1_10_fake_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("sp1_10_real_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_03_Gr_Closed")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("sp1_10_real_interior")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("DT1_03_Gr_Closed")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission1")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission2")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission3")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission4")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("CS1_02_cf_onmission3")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("V_STADIUM")
      });
      if (this.LoadMPMapsOnRefresh)
        Function.Call((Hash) 614956098268163829L, (InputArgument[]) Array.Empty<InputArgument>());
      this.AddInteriorBlips();
      if (this.LoadWarehouseInt)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_impexp_interior_placement_interior_1_impexp_intwaremed_milo_")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("basic_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("urban_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("branded_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("basic_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("car_floor_hatch")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(252673)
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_impexp_interior_placement_interior_1_impexp_intwaremed_milo_")
        });
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(994.5925),
          InputArgument.op_Implicit(-3002.594),
          InputArgument.op_Implicit(-39.64699)
        });
        this.WStyle = (string) this.Config.GetValue<string>("Warehouse", "WStyle", (M0) this.WStyle);
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.WStyle)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num)
        });
      }
      if (this.LoadFacility)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_33_x17dlc_int_02_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_33_x17dlc_int_02_milo_")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_9_x17dlc_int_01_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_9_x17dlc_int_01_milo_")
        });
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(462.09f),
          InputArgument.op_Implicit(4820.42f),
          InputArgument.op_Implicit(-59f)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_int_02_shell")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilityGraphic)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilityOrbitalCannon)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilitySecurityRoom)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilityLounge)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilitySleepingQuarters)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_int_02_shell"),
          InputArgument.op_Implicit(this.FacilityShellColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilityGraphic),
          InputArgument.op_Implicit(this.FacilityGraphicColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilityOrbitalCannon),
          InputArgument.op_Implicit(this.FacilityOrbitalCannonColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilitySecurityRoom),
          InputArgument.op_Implicit(this.FacilitySecurityRoomColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilityLounge),
          InputArgument.op_Implicit(this.FacilityLoungeColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.FacilitySleepingQuarters),
          InputArgument.op_Implicit(this.FacilitySleepingQuartersColor)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num)
        });
      }
      if (this.LoadHanger)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("sm_smugdlc_interior_placement_interior_0_smugdlc_int_01_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("sm_smugdlc_interior_placement_interior_0_smugdlc_int_01_milo_")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarLighting)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarFloor)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarFloorDecal)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarBedroom)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarOffice)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarBedroomBlinds)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarLightingWallTint)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarNeutralLighting)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_tint_shell")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_bedroom_tint")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_crane_tint")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_modarea")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit(this.HangarFloorDecal),
          InputArgument.op_Implicit(this.HangarFloorDecalColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_tint_shell"),
          InputArgument.op_Implicit(this.HangarShellColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_bedroom_tint"),
          InputArgument.op_Implicit(this.HangarBedroomColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_crane_tint"),
          InputArgument.op_Implicit(this.HangarCraneColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_modarea"),
          InputArgument.op_Implicit(this.HangarWorkshopColor)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(260353),
          InputArgument.op_Implicit("set_lighting_tint_props"),
          InputArgument.op_Implicit(this.HangarLightingTintPropsColor)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(260353)
        });
      }
      if (this.LoadCEOgarage)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBank)
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.MazeBankWest)
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Lombank)
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Class1.Arcadius)
        });
        int Interior1 = 0;
        int Interior2 = 0;
        int Interior3 = 0;
        int Interior4 = 0;
        if (this.MazeBankCEOGarage.Equals("A"))
        {
          Class1.MazeBank = "imp_dt1_11_cargarage_a";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.MazeBank)
          });
          Interior1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-84.2193),
            InputArgument.op_Implicit(-823.0851),
            InputArgument.op_Implicit(221.0)
          });
        }
        if (this.MazeBankCEOGarage.Equals("B"))
        {
          Class1.MazeBank = "imp_dt1_11_cargarage_b";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.MazeBank)
          });
          Interior1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-69.8627),
            InputArgument.op_Implicit(-824.7498),
            InputArgument.op_Implicit(221.0)
          });
        }
        if (this.MazeBankCEOGarage.Equals("C"))
        {
          Class1.MazeBank = "imp_dt1_11_cargarage_c";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.MazeBank)
          });
          Interior1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-80.4318),
            InputArgument.op_Implicit(-813.2536),
            InputArgument.op_Implicit(221.0)
          });
        }
        if (this.MazeBankWestCEOGarage.Equals("A"))
        {
          Class1.MazeBankWest = "imp_sm_15_cargarage_a";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.MazeBankWest)
          });
          Interior2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-1388.84),
            InputArgument.op_Implicit(-478.7402),
            InputArgument.op_Implicit(56.1)
          });
        }
        if (this.MazeBankWestCEOGarage.Equals("B"))
        {
          Class1.MazeBankWest = "imp_sm_15_cargarage_b";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.MazeBankWest)
          });
          Interior2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-1388.86),
            InputArgument.op_Implicit(-478.7574),
            InputArgument.op_Implicit(48.1)
          });
        }
        if (this.MazeBankWestCEOGarage.Equals("C"))
        {
          Class1.MazeBankWest = "imp_sm_15_cargarage_c";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.MazeBankWest)
          });
          Interior2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-1374.682),
            InputArgument.op_Implicit(-474.3586),
            InputArgument.op_Implicit(56.1)
          });
        }
        if (this.LombokCEOGarage.Equals("A"))
        {
          Class1.Lombank = "imp_sm_13_cargarage_a";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.Lombank)
          });
          Interior3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-1581.112),
            InputArgument.op_Implicit(-567.245),
            InputArgument.op_Implicit(85.5)
          });
        }
        if (this.LombokCEOGarage.Equals("B"))
        {
          Class1.Lombank = "imp_sm_13_cargarage_b";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.Lombank)
          });
          Interior3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-1568.739),
            InputArgument.op_Implicit(-562.0455),
            InputArgument.op_Implicit(85.5)
          });
        }
        if (this.LombokCEOGarage.Equals("C"))
        {
          Class1.Lombank = "imp_sm_13_cargarage_c";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.Lombank)
          });
          Interior3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-1563.557),
            InputArgument.op_Implicit(-574.4314),
            InputArgument.op_Implicit(85.5)
          });
        }
        if (this.ArcadiusCEOGarage.Equals("A"))
        {
          Class1.Arcadius = "imp_dt1_02_cargarage_a";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.Arcadius)
          });
          Interior4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-191.0133),
            InputArgument.op_Implicit(-579.1428),
            InputArgument.op_Implicit(135.0)
          });
        }
        if (this.ArcadiusCEOGarage.Equals("B"))
        {
          Class1.Arcadius = "imp_dt1_02_cargarage_b";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.Arcadius)
          });
          Interior4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-117.4989),
            InputArgument.op_Implicit(-568.1132),
            InputArgument.op_Implicit(135.0)
          });
        }
        if (this.ArcadiusCEOGarage.Equals("C"))
        {
          Class1.Arcadius = "imp_dt1_02_cargarage_c";
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Class1.Arcadius)
          });
          Interior4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(-136.078),
            InputArgument.op_Implicit(-630.1852),
            InputArgument.op_Implicit(135.0)
          });
        }
        this.RefreshInterior(Interior1, 1);
        this.RefreshInterior(Interior1, 2);
        this.RefreshInterior(Interior1, 3);
        this.RefreshInterior(Interior2, 1);
        this.RefreshInterior(Interior2, 2);
        this.RefreshInterior(Interior2, 3);
        this.RefreshInterior(Interior3, 1);
        this.RefreshInterior(Interior3, 2);
        this.RefreshInterior(Interior3, 3);
        this.RefreshInterior(Interior4, 1);
        this.RefreshInterior(Interior4, 2);
        this.RefreshInterior(Interior4, 3);
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior1),
          InputArgument.op_Implicit(this.MDecor)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior1),
          InputArgument.op_Implicit(this.MLighting)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior1),
          InputArgument.op_Implicit(this.MNumbering)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Interior1)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior2),
          InputArgument.op_Implicit(this.MWDecor)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior2),
          InputArgument.op_Implicit(this.MWLighting)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior2),
          InputArgument.op_Implicit(this.MWNumbering)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Interior2)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior3),
          InputArgument.op_Implicit(this.LDecor)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior3),
          InputArgument.op_Implicit(this.LLighting)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior3),
          InputArgument.op_Implicit(this.LNumbering)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Interior3)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior4),
          InputArgument.op_Implicit(this.ADecor)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior4),
          InputArgument.op_Implicit(this.ALighting)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Interior4),
          InputArgument.op_Implicit(this.ANumbering)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Interior4)
        });
      }
      if (this.LoadBunkerHatches)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case0_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case2_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case3_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case4_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case5_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case6_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case7_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case9_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case10_bunkerclosed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_case11_bunkerclosed")
        });
      }
      if (this.LoadFacilityHatches)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_bunkerentrance_door")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_hatches_terrain")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_hatches_terrain_lod")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_hatch_closed")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_mpchristmasadditions")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_siloentranceclosed_x17")
        });
      }
      if (this.LoadBunker)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_1_grdlc_int_02_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_1_grdlc_int_01_milo_")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit(this.GStyle)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit(this.Upgrade1)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit(this.Upgrade2)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit(this.Upgrade3)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit("Office_Upgrade_set")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit("gun_range_lights")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit("gun_schematic_set")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(258561),
          InputArgument.op_Implicit("gun_locker_upgrade")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(258561)
        });
      }
      if (this.load_DCARgarages)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_int_placement_vw_interior_2_dlc_casino_garage_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_int_placement_vw_interior_4_dlc_casino_carpark_milo_")
        });
      }
      if (this.LoadBikerClubhouseA)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_0_biker_dlc_int_01_milo")
        });
      if (this.LoadBikerClubhouseB)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_1_biker_dlc_int_02_milo")
        });
      if (this.LoadArenaGarage)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_mod")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_vip")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_Mod_2")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_mod")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_vip")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_Mod_2")
        });
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(170f),
          InputArgument.op_Implicit(5190f),
          InputArgument.op_Implicit(10f)
        });
        for (int index = 0; index < 9; ++index)
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit(this.WorkGraphic)
          });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Int_MOD2_B2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Int_MOD2_B_TINT")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Int_MOD2_B1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.WorkGraphic)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Int_MOD2_B_Tint"),
          InputArgument.op_Implicit(this.WColor1)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Int_MOD2_B1"),
          InputArgument.op_Implicit(this.WColor1)
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.WorkGraphic),
          InputArgument.op_Implicit(this.WColor1)
        });
      }
      if (this.LoadNightClubGarage)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_1_dlc_int_01_ba_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_1_dlc_int_01_ba_milo_")
        });
      }
      this.DeleteMOCBays();
      this.SetupMOCContents();
      this.SetupTerrobyteContents();
      if (this.EnableMoc)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_1_grdlc_int_02_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_1_grdlc_int_01_milo_")
        });
        this.SetupMoc();
      }
      if (this.EnableAvenger)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_33_x17dlc_int_02_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_9_x17dlc_int_01_milo_")
        });
        this.SetupAvenger();
      }
      if (this.EnableTerrobyte)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_2_dlc_int_03_ba_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_1_dlc_int_02_ba_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_0_dlc_int_01_ba_milo_")
        });
        this.SetupTerrpbyte();
      }
      int num1;
      if (this.LoadBikerClubhouseA)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_0_biker_dlc_int_01_milo")
        });
        this.ModBoothType = (int) this.Config.GetValue<int>("2floorClubhouse", "ModBoothType", (M0) this.ModBoothType);
        this.WallsType = (int) this.Config.GetValue<int>("2floorClubhouse", "WallsType", (M0) this.WallsType);
        this.FurnishingType = (int) this.Config.GetValue<int>("2floorClubhouse", "FurnishingType", (M0) this.FurnishingType);
        this.decorativeType = (int) this.Config.GetValue<int>("2floorClubhouse", "decorativeType", (M0) this.decorativeType);
        this.GunlockerType = (int) this.Config.GetValue<int>("2floorClubhouse", "GunlockerType", (M0) this.GunlockerType);
        this.Muraltype = (int) this.Config.GetValue<int>("2floorClubhouse", "Muraltype", (M0) this.Muraltype);
        int num2 = 246273;
        if (this.ModBoothType == 0)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(247041),
            InputArgument.op_Implicit("mod_booth")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(247041),
            InputArgument.op_Implicit("no_mod_booth")
          });
        }
        if (this.ModBoothType == 1)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("mod_booth")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("no_mod_booth")
          });
        }
        if (this.WallsType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("walls_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("walls_02")
          });
        }
        if (this.WallsType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("walls_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("walls_02")
          });
        }
        if (this.FurnishingType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("furnishings_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("furnishings_02")
          });
        }
        if (this.FurnishingType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("furnishings_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("furnishings_02")
          });
        }
        if (this.decorativeType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("decorative_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("decorative_02")
          });
        }
        if (this.decorativeType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("decorative_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("decorative_02")
          });
        }
        for (int index = 0; index < 10; num1 = index++)
        {
          if (index + 1 == this.Muraltype)
          {
            InputArgument[] inputArgumentArray = new InputArgument[2]
            {
              InputArgument.op_Implicit(num2),
              null
            };
            num1 = index + 1;
            inputArgumentArray[1] = InputArgument.op_Implicit("mural_0" + num1.ToString());
            Function.Call((Hash) 6190315277334034081L, inputArgumentArray);
          }
          if (index + 1 != this.Muraltype)
          {
            InputArgument[] inputArgumentArray = new InputArgument[2]
            {
              InputArgument.op_Implicit(num2),
              null
            };
            num1 = index + 1;
            inputArgumentArray[1] = InputArgument.op_Implicit("mural_0" + num1.ToString());
            Function.Call((Hash) 4759129920140927330L, inputArgumentArray);
          }
        }
        if (this.GunlockerType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("no_gun_locker")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("gun_locker")
          });
        }
        if (this.GunlockerType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("no_gun_locker")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("gun_locker")
          });
        }
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("meth_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("meth_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("meth_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("coke_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("coke_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("coke_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("weed_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("weed_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("weed_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("cash_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("cash_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("cash_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("id_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("id_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("id_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("counterfeit_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("counterfeit_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("counterfeit_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("lower_walls_default")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num2)
        });
      }
      if (this.LoadBikerClubhouseB)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_1_biker_dlc_int_02_milo")
        });
        this.ModBoothType = (int) this.Config.GetValue<int>("1floorClubhouse", "ModBoothType", (M0) this.ModBoothType);
        this.WallsType = (int) this.Config.GetValue<int>("1floorClubhouse", "WallsType", (M0) this.WallsType);
        this.FurnishingType = (int) this.Config.GetValue<int>("1floorClubhouse", "FurnishingType", (M0) this.FurnishingType);
        this.decorativeType = (int) this.Config.GetValue<int>("1floorClubhouse", "decorativeType", (M0) this.decorativeType);
        this.GunlockerType = (int) this.Config.GetValue<int>("1floorClubhouse", "GunlockerType", (M0) this.GunlockerType);
        this.Muraltype = (int) this.Config.GetValue<int>("1floorClubhouse", "Muraltype", (M0) this.Muraltype);
        if (this.ModBoothType == 0)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("mod_booth")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("no_mod_booth")
          });
        }
        if (this.ModBoothType == 1)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("mod_booth")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("no_mod_booth")
          });
        }
        if (this.WallsType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("walls_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("walls_02")
          });
        }
        if (this.WallsType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("walls_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("walls_02")
          });
        }
        if (this.FurnishingType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("furnishings_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("furnishings_02")
          });
        }
        if (this.FurnishingType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("furnishings_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("furnishings_02")
          });
        }
        if (this.decorativeType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("decorative_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("decorative_02")
          });
        }
        if (this.decorativeType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("decorative_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("decorative_02")
          });
        }
        for (int index = 0; index < 10; num1 = index++)
        {
          if (index + 1 == this.Muraltype)
          {
            InputArgument[] inputArgumentArray = new InputArgument[2]
            {
              InputArgument.op_Implicit(246529),
              null
            };
            num1 = index + 1;
            inputArgumentArray[1] = InputArgument.op_Implicit("mural_0" + num1.ToString());
            Function.Call((Hash) 6190315277334034081L, inputArgumentArray);
          }
          if (index + 1 != this.Muraltype)
          {
            InputArgument[] inputArgumentArray = new InputArgument[2]
            {
              InputArgument.op_Implicit(246529),
              null
            };
            num1 = index + 1;
            inputArgumentArray[1] = InputArgument.op_Implicit("mural_0" + num1.ToString());
            Function.Call((Hash) 4759129920140927330L, inputArgumentArray);
          }
        }
        if (this.GunlockerType == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("no_gun_locker")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("gun_locker")
          });
        }
        if (this.GunlockerType == 1)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("no_gun_locker")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(246529),
            InputArgument.op_Implicit("gun_locker")
          });
        }
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("meth_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("meth_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("meth_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("coke_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("coke_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("coke_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("weed_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("weed_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("weed_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("cash_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("cash_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("cash_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("id_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("id_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("id_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("counterfeit_stash1")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("counterfeit_stash2")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("counterfeit_stash3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246529),
          InputArgument.op_Implicit("lower_walls_default")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(246529)
        });
      }
      if (this.EnableBikerMethLab)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_2_biker_dlc_int_ware01_milo")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247041),
          InputArgument.op_Implicit("meth_lab_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247041),
          InputArgument.op_Implicit("meth_lab_production")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247041),
          InputArgument.op_Implicit("meth_lab_security_high")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247041),
          InputArgument.op_Implicit("meth_lab_setup")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(247041)
        });
      }
      if (this.EnableBikerWeedFarm)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_3_biker_dlc_int_ware02_milo")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_upgrade_equip")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_drying")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_security_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_production")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_set_up")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_chairs")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growtha_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthb_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthc_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthd_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthe_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthf_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthg_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthh_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_growthi_stage3")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hosea")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hoseb")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hosec")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hosed")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hosee")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hosef")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hoseg")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hoseh")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("weed_hosei")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growtha_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthb_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthc_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthd_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthe_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthf_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthg_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthh_stage23_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247297),
          InputArgument.op_Implicit("light_growthi_stage23_upgrade")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(247297)
        });
      }
      if (this.EnableBikerCocaineLab)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_4_biker_dlc_int_ware03_milo")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("coke_cut_01")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("coke_cut_02")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("coke_cut_03")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("security_high")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("production_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("equipment_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("coke_cut_04")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("coke_cut_05")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("set_up")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("table_equipment_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247553),
          InputArgument.op_Implicit("coke_press_upgrade")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(247553)
        });
      }
      if (this.EnableBikerForgeryOffice)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_6_biker_dlc_int_ware05_milo")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("equipment_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("production")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("security_high")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("set_up")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("clutter")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("interior_upgrade")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("chair01")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("chair02")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("chair03")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("chair04")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("chair05")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("chair06")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(246785),
          InputArgument.op_Implicit("chair07")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(246785)
        });
      }
      if (this.EnableBikerMoneyPrinter)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("bkr_biker_interior_placement_interior_5_biker_dlc_int_ware04_milo")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_security")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile100a")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile20a")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile10a")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile100b")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile100c")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile100d")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile20b")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile20c")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile20d")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile10b")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile10c")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_cashpile10d")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_setup")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("counterfeit_upgrade_equip")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("dryera_on")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("dryerb_on")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("dryerc_on")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("dryerd_on")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("money_cutter")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(247809),
          InputArgument.op_Implicit("special_chairs")
        });
      }
      if (this.EnableCEOCargoWarehouse_Small)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_exec_warehouse_placement_interior_1_int_warehouse_s_dlc_milo")
        });
      if (this.EnableCEOCargoWareWarehouse_Large)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_exec_warehouse_placement_interior_2_int_warehouse_l_dlc_milo")
        });
      if (this.EnableCEOCargoWareWarehouse_Medium)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ex_exec_warehouse_placement_interior_0_int_warehouse_m_dlc_milo")
        });
      if (this.GunrunningYacht)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_Heist_Yacht2")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_Heist_Yacht2_enginrm")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_Heist_Yacht2_Lounge")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_Heist_Yacht2_Bridge")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_Heist_Yacht2_Bar")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_Heist_Yacht2_Bedrm")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gunrunning_yacht_jacuzzi")
        });
      }
      if (this.EnableIAAServerFarm)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_4_x17dlc_int_facility_milo_")
        });
      if (this.EnableIAAFacility)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_5_x17dlc_int_facility2_milo_")
        });
      if (this.EnableSub)
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_8_x17dlc_int_sub_milo_")
        });
      if (this.EnableMissileSilo)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_0_x17dlc_int_base_ent_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_1_x17dlc_int_base_loop_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_2_x17dlc_int_bse_tun_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_3_x17dlc_int_base_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_6_x17dlc_int_silo_01_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_7_x17dlc_int_silo_02_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_10_x17dlc_int_tun_straight_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_11_x17dlc_int_tun_slope_flat_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_12_x17dlc_int_tun_flat_slope_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_13_x17dlc_int_tun_30d_r_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_14_x17dlc_int_tun_30d_l_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_15_x17dlc_int_tun_straight_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_16_x17dlc_int_tun_straight_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_17_x17dlc_int_tun_slope_flat_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_18_x17dlc_int_tun_slope_flat_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_19_x17dlc_int_tun_flat_slope_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_20_x17dlc_int_tun_flat_slope_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_21_x17dlc_int_tun_30d_r_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_22_x17dlc_int_tun_30d_r_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_23_x17dlc_int_tun_30d_r_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_24_x17dlc_int_tun_30d_r_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_25_x17dlc_int_tun_30d_l_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_26_x17dlc_int_tun_30d_l_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_27_x17dlc_int_tun_30d_l_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_28_x17dlc_int_tun_30d_l_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_29_x17dlc_int_tun_30d_l_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_34_x17dlc_int_lab_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_35_x17dlc_int_tun_entry_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xm_x17dlc_int_placement_strm_0")
        });
      }
      if (this.EnableDCH_Arcade)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_1_dlc_arcade_milo_")
        });
        this.RefreshArcadeInterior();
      }
      if (this.EnableCasinoPenthouse)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_casino_penthouse")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_casino_penthouse")
        });
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit((int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(976.6364),
            InputArgument.op_Implicit(70.29476),
            InputArgument.op_Implicit(115.1641)
          }))
        });
        this.RefreshPenthouse();
      }
      if (this.EnableArenaWorkshop)
        this.Enableinterior();
      if (this.EnableArena)
      {
        if (this.ArenaType.Equals("Dystopian_4"))
          this.LoadDystopian_4();
        if (this.ArenaType.Equals("Dystopian_5"))
          this.LoadDystopian_5();
        if (this.ArenaType.Equals("Dystopian_3"))
          this.LoadDystopian_3();
        if (this.ArenaType.Equals("Dystopian_2"))
          this.LoadDystopian_2();
        if (this.ArenaType.Equals("Dystopian_10"))
          this.LoadDystopian_10();
        if (this.ArenaType.Equals("Dystopian_7"))
          this.LoadDystopian_7();
        if (this.ArenaType.Equals("Dystopian_8"))
          this.LoadDystopian_8();
        if (this.ArenaType.Equals("Dystopian_12"))
          this.LoadDystopian_12();
        if (this.ArenaType.Equals("Scifi_2"))
          this.LoadScifi_2();
        if (this.ArenaType.Equals("Scifi_4"))
          this.LoadScifi_4();
        if (this.ArenaType.Equals("Scifi_5"))
          this.LoadScifi_5();
        if (this.ArenaType.Equals("Scifi_10"))
          this.LoadScifi_10();
        if (this.ArenaType.Equals("Wasteland_2"))
          this.LoadWasteland_2();
        if (this.ArenaType.Equals("Scifi_9"))
          this.LoadScifi_9();
        if (this.ArenaType.Equals("Wasteland_9"))
          this.LoadWasteland_9();
        if (this.ArenaType.Equals("Wasteland_4"))
          this.LoadWasteland_4();
        if (this.ArenaType.Equals("Wasteland_5"))
          this.LoadWasteland_5();
        if (this.ArenaType.Equals("Wasteland_7"))
          this.LoadWasteland_7();
      }
      if (this.EnableCasino)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_int_placement_vw_interior_0_dlc_casino_main_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_int_placement_vw_interior_0_dlc_casino_main_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_casino_penthouse")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_casino_carpark")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_casino_main")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("vw_casino_garage")
        });
      }
      if (this.EnableArenaVip)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_vip")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("xs_arena_interior_vip")
        });
      }
      if (this.EnableAircraftCarrier)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_carrier")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_carrier_DistantLights")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_Carrier_int1")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_Carrier_int2")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_Carrier_int3")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_Carrier_int4")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_Carrier_int5")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_Carrier_int6")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("hei_carrier_LODLights")
        });
      }
      if (this.EnableNorthYankton)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01c")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01d")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01e")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01f")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01g")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01h")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01i")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01j")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01k")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue01z")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue02")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue03")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue03b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue03_grv_dug")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue_grv_torch")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue04")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue04b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue04_cover")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("des_protree_end")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("des_protree_start")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue05")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue05b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue06")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue06b")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue06_int")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue06_pannel")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("plg_occl_00")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologue_occl")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologuerd")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("prologuerdb")
        });
      }
      if (this.EnableNightclub)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_2_dlc_int_03_ba_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_1_dlc_int_02_ba_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ba_int_placement_ba_interior_0_dlc_int_01_ba_milo_")
        });
        this.RefreshInteriorNightclub();
      }
      this.RefreshExecutiveOffice();
      if (this.EnableCEOModShop)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_sm_15_modgarage")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_sm_13_modgarage")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_dt1_02_modgarage")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_dt1_11_modgarage")
        });
        int num2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1391.245f),
          InputArgument.op_Implicit(-473.9638f),
          InputArgument.op_Implicit(77.2f)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(this.Decal)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num2)
        });
        int num3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-146.6166f),
          InputArgument.op_Implicit(-596.6301f),
          InputArgument.op_Implicit(166f)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(this.Decal)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num3)
        });
        int num4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1578.023f),
          InputArgument.op_Implicit(-576.4251f),
          InputArgument.op_Implicit(104.2f)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(this.Decal)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num4)
        });
        int num5 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(73.9039f),
          InputArgument.op_Implicit(-821.6204f),
          InputArgument.op_Implicit(284f)
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num5),
          InputArgument.op_Implicit(this.Decal)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num5)
        });
      }
      if (this.EnableDCH_Casino)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_0_dlc_casino_heist_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_0_dlc_casino_heist_milo_")
        });
      }
      if (this.EnableDCH_Hotel)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_4_dlc_casino_hotel_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_4_dlc_casino_hotel_milo_")
        });
      }
      if (this.EnableDCH_LoadingBay)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_5_dlc_casino_loading_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_5_dlc_casino_loading_milo_")
        });
      }
      if (this.EnableDCH_Office)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_3_dlc_casino_back_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_3_dlc_casino_back_milo_")
        });
      }
      if (this.EnableDCH_Shaft)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_9_dlc_casino_shaft_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_9_dlc_casino_shaft_milo_")
        });
      }
      if (this.EnableDCH_Tunnel)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_8_dlc_tunnel_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_8_dlc_tunnel_milo_")
        });
      }
      if (this.EnableDCH_Vault)
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_6_dlc_casino_vault_milo_")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("ch_int_placement_ch_interior_6_dlc_casino_vault_milo_")
        });
      }
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_mod")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_Mod_2")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_mod")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_Mod_2")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("bahama_mamas_west_doors_inside")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("heist_yacht_jacuzzi")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("michael_house_wc_window")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("dt1_05_fib2_mission")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("dt1_05_fib2_normal")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("dt1_05_fib_reflection")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fib_heist_dmg")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fib_heist_lights")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fiblobby")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fiblobbyfake")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fib_heist_dmg")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("dt1_05_rubble")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fbi_repair")
      });
      if (this.FibBuilding)
      {
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("dt1_05_fib_reflection")
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("fiblobby")
        });
      }
      if (this.FibBuilding)
        return;
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("dt1_05_fib_reflection")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("fiblobbyfake")
      });
    }

    public void loadMenu(iFruitContact contact)
    {
      this.ifruit.Close(0);
      this.WoredrobeMainMenu.set_Visible(!this.WoredrobeMainMenu.get_Visible());
    }

    public void SetupAvenger()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xm_x17dlc_int_placement_interior_9_x17dlc_int_01_milo_")
      });
      this.interior1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(520f),
        InputArgument.op_Implicit(4750f),
        InputArgument.op_Implicit(-70f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("shell_Tint")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("CONTROL_1")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("CONTROL_2")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("CONTROL_3")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("WEAPONS_MOD")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("VEHICLE_MOD")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("GOLD_BLING")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("shell_Tint")
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("SHELL_TINT"),
        InputArgument.op_Implicit(this.av7)
      });
      if (this.Av1)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("CONTROL_1")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("CONTROL_1"),
          InputArgument.op_Implicit(this.av7)
        });
      }
      if (this.Av2)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("CONTROL_2")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("CONTROL_2"),
          InputArgument.op_Implicit(this.av7)
        });
      }
      if (this.Av3)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("CONTROL_3")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("CONTROL_3"),
          InputArgument.op_Implicit(this.av7)
        });
      }
      if (this.Av4)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("WEAPONS_MOD")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("WEAPONS_MOD"),
          InputArgument.op_Implicit(this.av7)
        });
      }
      if (this.Av5)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("VEHICLE_MOD")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior1),
          InputArgument.op_Implicit("VEHICLE_MOD"),
          InputArgument.op_Implicit(this.av7)
        });
      }
      if (!this.Av6)
        return;
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("GOLD_BLING")
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.interior1),
        InputArgument.op_Implicit("GOLD_BLING"),
        InputArgument.op_Implicit(this.av7)
      });
    }

    public void SetupTerrpbyte()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ba_int_placement_ba_interior_2_dlc_int_03_ba_milo_")
      });
      this.interior3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(-1419.99f),
        InputArgument.op_Implicit(-3013.55f),
        InputArgument.op_Implicit(-79.05f)
      });
      for (int index = 0; index < this.design.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit(this.design[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit("int_03_ba_tint")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit(this.design[this.tdesign])
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit("int_03_ba_tint"),
        InputArgument.op_Implicit(this.tcolor)
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit(this.design[this.tdesign]),
        InputArgument.op_Implicit(this.tcolor)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit("int_03_ba_drone")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit("int_03_ba_weapons_mod")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit("int_03_ba_bikemod")
      });
      if (this.tdrone)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_drone")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_drone"),
          InputArgument.op_Implicit(this.tcolor)
        });
      }
      else
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_drone")
        });
      if (this.tweapons)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_weapons_mod")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_weapons_mod"),
          InputArgument.op_Implicit(this.tcolor)
        });
      }
      else
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_weapons_mod")
        });
      if (this.tbike)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_bikemod")
        });
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_bikemod"),
          InputArgument.op_Implicit(this.tcolor)
        });
      }
      else
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit("int_03_ba_bikemod")
        });
      for (int index = 0; index < this.TLights.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.interior3),
          InputArgument.op_Implicit(this.TLights[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit(this.TLights[this.tlights])
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.interior3),
        InputArgument.op_Implicit(this.TLights[this.tlights]),
        InputArgument.op_Implicit(this.tcolor)
      });
    }

    public void SetupInteriorDesignsMenu2()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass480_0 displayClass4800 = new Class1.\u003C\u003Ec__DisplayClass480_0()
      {
        \u003C\u003E4__this = this,
        listofDesigns = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_01");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_02");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_03");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_04");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_05");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_06");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_07");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_08");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofDesigns.Add((object) "Set_Mod1_Style_09");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofOfficeDesigns = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofOfficeDesigns.Add((object) "SET_OFFICE_STANDARD");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofOfficeDesigns.Add((object) "SET_OFFICE_HITECH");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofOfficeDesigns.Add((object) "SET_OFFICE_INDUSTRIAL");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofMechanics = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofMechanics.Add((object) "Set_Int_MOD_BOOTH_DEF");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofMechanics.Add((object) "Set_Int_MOD_BOOTH_BEN");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofMechanics.Add((object) "Set_Int_MOD_BOOTH_WP");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofMechanics.Add((object) "Set_Int_MOD_BOOTH_COMBO");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "0");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "1");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "1");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "2");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "3");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "4");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "6");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "7");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "8");
      // ISSUE: reference to a compiler-generated field
      displayClass4800.listofColors.Add((object) "9");
      List<object> objectList = new List<object>();
      objectList.Add((object) "Dystopian_4");
      objectList.Add((object) "Dystopian_5");
      objectList.Add((object) "Dystopian_3");
      objectList.Add((object) "Dystopian_2");
      objectList.Add((object) "Dystopian_10");
      objectList.Add((object) "Dystopian_7");
      objectList.Add((object) "Dystopian_8");
      objectList.Add((object) "Dystopian_12");
      objectList.Add((object) "Scifi_2");
      objectList.Add((object) "Scifi_4");
      objectList.Add((object) "Scifi_5");
      objectList.Add((object) "Scifi_10");
      objectList.Add((object) "Wasteland_2");
      objectList.Add((object) "Scifi_9");
      objectList.Add((object) "Wasteland_9");
      objectList.Add((object) "Wasteland_4");
      objectList.Add((object) "Wasteland_5");
      objectList.Add((object) "Wasteland_7");
      UIMenu uiMenu1 = this.Woredrobepool.AddSubMenu(this.ArenaWarDLC, "Arena Presets");
      this.GUIMenus.Add(uiMenu1);
      UIMenuListItem uiMenuListItem = new UIMenuListItem("Arena Preset : ", objectList, 0);
      uiMenu1.AddItem((UIMenuItem) uiMenuListItem);
      UIMenuItem uiMenuItem = new UIMenuItem("Set Arena Preset");
      uiMenu1.AddItem(uiMenuItem);
      UIMenu uiMenu2 = this.Woredrobepool.AddSubMenu(this.ArenaWarDLC, "Workshop");
      this.GUIMenus.Add(uiMenu2);
      UIMenu uiMenu3 = this.Woredrobepool.AddSubMenu(uiMenu2, "Trinkets And Trophies");
      this.GUIMenus.Add(uiMenu3);
      UIMenu uiMenu4 = this.Woredrobepool.AddSubMenu(uiMenu2, "Design");
      this.GUIMenus.Add(uiMenu4);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4800.list1 = new UIMenuListItem("Design: ", displayClass4800.listofDesigns, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem((UIMenuItem) displayClass4800.list1);
      // ISSUE: reference to a compiler-generated field
      displayClass4800.GetDesign = new UIMenuItem("Get Design");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass4800.GetDesign);
      UIMenu uiMenu5 = this.Woredrobepool.AddSubMenu(uiMenu2, "Office Design");
      this.GUIMenus.Add(uiMenu5);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4800.list2 = new UIMenuListItem("Office Design: ", displayClass4800.listofOfficeDesigns, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem((UIMenuItem) displayClass4800.list2);
      // ISSUE: reference to a compiler-generated field
      displayClass4800.GetOfficeDesign = new UIMenuItem("Get Office Design");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass4800.GetOfficeDesign);
      UIMenu uiMenu6 = this.Woredrobepool.AddSubMenu(uiMenu2, "Mechanic");
      this.GUIMenus.Add(uiMenu6);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4800.list3 = new UIMenuListItem("Mechanic: ", displayClass4800.listofMechanics, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu6.AddItem((UIMenuItem) displayClass4800.list3);
      // ISSUE: reference to a compiler-generated field
      displayClass4800.GetMechanic = new UIMenuItem("Mechanic");
      // ISSUE: reference to a compiler-generated field
      uiMenu6.AddItem(displayClass4800.GetMechanic);
      UIMenu uiMenu7 = this.Woredrobepool.AddSubMenu(uiMenu2, "Main Color");
      this.GUIMenus.Add(uiMenu7);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4800.list4 = new UIMenuListItem("Color: ", displayClass4800.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu7.AddItem((UIMenuItem) displayClass4800.list4);
      // ISSUE: reference to a compiler-generated field
      displayClass4800.GetColor1 = new UIMenuItem("Get Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu7.AddItem(displayClass4800.GetColor1);
      UIMenu uiMenu8 = this.Woredrobepool.AddSubMenu(this.InteriorOptions, "Workshop B1");
      this.GUIMenus.Add(uiMenu8);
      UIMenu uiMenu9 = this.Woredrobepool.AddSubMenu(uiMenu8, "Main Color");
      this.GUIMenus.Add(uiMenu9);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass4800.list5 = new UIMenuListItem("Color: ", displayClass4800.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu9.AddItem((UIMenuItem) displayClass4800.list4);
      // ISSUE: reference to a compiler-generated field
      displayClass4800.GetColor2 = new UIMenuItem("Get Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu9.AddItem(displayClass4800.GetColor2);
      // ISSUE: reference to a compiler-generated field
      displayClass4800.EnableAll = new UIMenuItem("Enable All Trinkets And Trophies ");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4800.EnableAll);
      // ISSUE: reference to a compiler-generated field
      displayClass4800.DisableAll = new UIMenuItem("Disable All Trinkets And Trophies ");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass4800.DisableAll);
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass4800, __methodptr(\u003CSetupInteriorDesignsMenu2\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu4.add_OnItemSelect(new ItemSelectEvent((object) displayClass4800, __methodptr(\u003CSetupInteriorDesignsMenu2\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu5.add_OnItemSelect(new ItemSelectEvent((object) displayClass4800, __methodptr(\u003CSetupInteriorDesignsMenu2\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu6.add_OnItemSelect(new ItemSelectEvent((object) displayClass4800, __methodptr(\u003CSetupInteriorDesignsMenu2\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu7.add_OnItemSelect(new ItemSelectEvent((object) displayClass4800, __methodptr(\u003CSetupInteriorDesignsMenu2\u003Eb__4)));
      // ISSUE: method pointer
      uiMenu9.add_OnItemSelect(new ItemSelectEvent((object) displayClass4800, __methodptr(\u003CSetupInteriorDesignsMenu2\u003Eb__5)));
    }

    public void SetupMoc()
    {
      this.MocBay = (int) this.Config.GetValue<int>("MOC", "ModBay1", (M0) this.MocBay);
      this.MocBay2 = (int) this.Config.GetValue<int>("MOC", "ModBay2", (M0) this.MocBay2);
      this.MocBay3 = (int) this.Config.GetValue<int>("MOC", "ModBay3", (M0) this.MocBay3);
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
      });
      this.CurrentMocColor1 = this.CurrentMocColor2;
      if (this.MocBay == 0 && this.MocBay2 == 4 && this.MocBay3 == 8)
      {
        UI.Notify("Test6/2");
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_gunmod_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_vehicle_01", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -3008.138f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -3009.627f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3009.627f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        UI.Notify("Test8");
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.63916f),
          InputArgument.op_Implicit(2765f / 512f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.598999f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(-1.401001f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Script.Wait(1000);
        UI.Notify("Test9");
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Script.Wait(1000);
        UI.Notify("Test10");
        this.spawnmoc(this.MocLightsGunMod[this.CurrentMocLightsGunMod], 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsVehicle[this.CurrentMocLightsVehicle], 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 0 && this.MocBay2 == 5 && this.MocBay3 == 0)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3009.538f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_carmod_01", 1103.512f, -3005.538f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3013.538f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3013.538f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -3008.138f, -39.19909f, 5, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -3009.627f, -39.19909f, 6, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3009.627f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3013.538f, -39.92914f, 8, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.041f, -3005.534f, -39.93266f, 11, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(4.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.3f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-4.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.63916f),
          InputArgument.op_Implicit(2765f / 512f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.598999f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(-1.401001f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Script.Wait(1000);
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -3013.538f, -39.92914f, 9, true);
        this.spawnmoc(this.MocLightsVehicleAweapon[this.CurrentMocLightsVehicleAweapon], 1103.512f, -3005.538f, -39.92914f, 10, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 2 && this.MocBay3 == 8)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_vehicle_01", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -2996.837f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -2998.236f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -2998.438f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3008.938f, -39.19909f, 15, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3005.438f, -39.19909f, 16, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.811f, -3005.638f, -39.19909f, 17, false);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3010.188f, -39.92914f, 18, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3010.188f, -39.92914f, 19, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3010.188f, -39.92914f, 20, true);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3010.188f, -39.92914f, 21, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.788f, -3008.17f, -39.139f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.897f, -3006.265f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.054f, -3005.122f, -39.139f, 24, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-128.9994f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-40.99873f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.8997f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsVehicle[this.CurrentMocLightsVehicle], 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 4 && this.MocBay3 == 6)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_gunmod_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3008.938f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3005.438f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.811f, -3005.638f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3010.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3010.188f, -39.92914f, 15, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3010.188f, -39.92914f, 16, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3010.188f, -39.92914f, 17, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -3008.138f, -39.19909f, 18, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -3009.627f, -39.19909f, 19, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3009.627f, -39.19909f, 20, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 21, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.578f, -2986.185f, -39.92914f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.788f, -3008.17f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.897f, -3006.265f, -39.139f, 24, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.054f, -3005.122f, -39.139f, 25, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-128.9994f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-40.99873f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.8997f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.63916f),
          InputArgument.op_Implicit(2765f / 512f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.598999f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(-1.401001f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc25),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc25),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsGunMod[this.CurrentMocLightsGunMod], 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 4 && this.MocBay3 == 8)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_gunmod_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_vehicle_01", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3008.938f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3005.438f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.811f, -3005.638f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3010.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3010.188f, -39.92914f, 15, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3010.188f, -39.92914f, 16, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3010.188f, -39.92914f, 17, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.788f, -3008.17f, -39.139f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.897f, -3006.265f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.054f, -3005.122f, -39.139f, 24, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-128.9994f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-40.99873f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.8997f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsGunMod[this.CurrentMocLightsGunMod], 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsVehicle[this.CurrentMocLightsVehicle], 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 5)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3009.538f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3013.538f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_carmod_01", 1103.512f, -3005.538f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3013.538f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3013.538f, -39.92914f, 7, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3013.538f, -39.92914f, 8, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.528f, -3013.528f, -39.92914f, 9, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.151f, -3009.138f, -39.19909f, 10, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.651f, -3008.938f, -39.19909f, 11, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.451f, -3011.84f, -39.19909f, 12, false);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3013.538f, -39.92914f, 13, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.041f, -3005.534f, -39.93266f, 14, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.978f, -3011.249f, -39.139f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.857f, -3009.587f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.033f, -3008.45f, -39.139f, 24, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-4.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(4.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-48.99979f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(133f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-132f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3013.538f, -39.92914f, 4, true);
        this.spawnmoc(this.MocLightsVehicleAweapon[this.CurrentMocLightsVehicleAweapon], 1103.512f, -3005.538f, -39.92914f, 5, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
      }
      else if (this.MocBay == 0 && this.MocBay2 == 4 && this.MocBay3 == 7)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_gunmod_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_empty_02", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -3008.138f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -3009.627f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3009.627f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.63916f),
          InputArgument.op_Implicit(2765f / 512f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.598999f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(-1.401001f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsGunMod[this.CurrentMocLightsGunMod], 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc("gr_prop_inttruck_light_e2", 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 4 && this.MocBay3 == 7)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_gunmod_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_empty_02", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3008.938f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3005.438f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.811f, -3005.638f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3010.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3010.188f, -39.92914f, 15, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3010.188f, -39.92914f, 16, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3010.188f, -39.92914f, 17, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.788f, -3008.17f, -39.139f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.897f, -3006.265f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.054f, -3005.122f, -39.139f, 24, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-128.9994f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-40.99873f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.8997f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsGunMod[this.CurrentMocLightsGunMod], 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc("gr_prop_inttruck_light_e2", 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 2 && this.MocBay3 == 7)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_empty_02", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -2996.837f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -2998.236f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -2998.438f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3008.938f, -39.19909f, 15, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3005.438f, -39.19909f, 16, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.811f, -3005.638f, -39.19909f, 17, false);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3010.188f, -39.92914f, 18, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3010.188f, -39.92914f, 19, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3010.188f, -39.92914f, 20, true);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3010.188f, -39.92914f, 21, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.788f, -3008.17f, -39.139f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.897f, -3006.265f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.054f, -3005.122f, -39.139f, 24, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-128.9994f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-40.99873f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.8997f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc("gr_prop_inttruck_light_e2", 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 0 && this.MocBay2 == 3 && this.MocBay3 == 8)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_empty_03", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_vehicle_01", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -3008.138f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -3009.627f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3009.627f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.63916f),
          InputArgument.op_Implicit(2765f / 512f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.598999f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(-1.401001f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc("gr_prop_inttruck_light_e2", 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsVehicle[this.CurrentMocLightsVehicle], 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 0 && this.MocBay2 == 3 && this.MocBay3 == 7)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_empty_01", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -3008.138f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -3009.627f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3009.627f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 10, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.63916f),
          InputArgument.op_Implicit(2765f / 512f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.598999f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(-1.401001f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc("gr_prop_inttruck_light_e1", 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 3 && this.MocBay3 == 7)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3009.538f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3013.538f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_empty_01", 1103.512f, -3005.538f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3013.538f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3013.538f, -39.92914f, 7, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3013.538f, -39.92914f, 8, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.528f, -3013.528f, -39.92914f, 9, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.151f, -3009.138f, -39.19909f, 10, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.651f, -3008.938f, -39.19909f, 11, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.451f, -3011.84f, -39.19909f, 12, false);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3013.538f, -39.92914f, 13, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.041f, -3005.534f, -39.93266f, 14, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.978f, -3011.249f, -39.139f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.857f, -3009.587f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.033f, -3008.45f, -39.139f, 24, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-4.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(4.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-48.99979f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(133f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-132f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3013.538f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_light_e1", 1103.512f, -3005.538f, -39.92914f, 5, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 3 && this.MocBay3 == 6)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_empty_03", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_living_01", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3008.938f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3005.438f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.811f, -3005.638f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3010.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3010.188f, -39.92914f, 15, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3010.188f, -39.92914f, 16, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3010.188f, -39.92914f, 17, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.151f, -3008.138f, -39.19909f, 18, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1105.111f, -3009.627f, -39.19909f, 19, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3009.627f, -39.19909f, 20, false);
        this.spawnmoc("gr_prop_gr_trailer_tv", 1103.512f, -3002.188f, -39.92914f, 21, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.578f, -2986.185f, -39.92914f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.788f, -3008.17f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.897f, -3006.265f, -39.139f, 24, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.054f, -3005.122f, -39.139f, 25, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-128.9994f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-40.99873f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.8997f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.63916f),
          InputArgument.op_Implicit(2765f / 512f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1.598999f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(-1.401001f),
          InputArgument.op_Implicit(3.910889f),
          InputArgument.op_Implicit(0.7300453f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(-179.9999f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc25),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc18),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc19),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc20),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc21),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc25),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc("gr_prop_inttruck_light_e2", 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsLiving[this.CurrentMocLightsLiving], 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else if (this.MocBay == 1 && this.MocBay2 == 3 && this.MocBay3 == 8)
      {
        if (Entity.op_Inequality(this.moc1, (Entity) null))
          this.moc1.Delete();
        if (Entity.op_Inequality(this.moc2, (Entity) null))
          this.moc2.Delete();
        if (Entity.op_Inequality(this.moc3, (Entity) null))
          this.moc3.Delete();
        if (Entity.op_Inequality(this.moc4, (Entity) null))
          this.moc4.Delete();
        if (Entity.op_Inequality(this.moc5, (Entity) null))
          this.moc5.Delete();
        if (Entity.op_Inequality(this.moc6, (Entity) null))
          this.moc6.Delete();
        if (Entity.op_Inequality(this.moc7, (Entity) null))
          this.moc7.Delete();
        if (Entity.op_Inequality(this.moc8, (Entity) null))
          this.moc8.Delete();
        if (Entity.op_Inequality(this.moc9, (Entity) null))
          this.moc9.Delete();
        if (Entity.op_Inequality(this.moc10, (Entity) null))
          this.moc10.Delete();
        if (Entity.op_Inequality(this.moc11, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc12, (Entity) null))
          this.moc11.Delete();
        if (Entity.op_Inequality(this.moc13, (Entity) null))
          this.moc13.Delete();
        if (Entity.op_Inequality(this.moc14, (Entity) null))
          this.moc14.Delete();
        if (Entity.op_Inequality(this.moc15, (Entity) null))
          this.moc15.Delete();
        if (Entity.op_Inequality(this.moc16, (Entity) null))
          this.moc16.Delete();
        if (Entity.op_Inequality(this.moc17, (Entity) null))
          this.moc17.Delete();
        if (Entity.op_Inequality(this.moc18, (Entity) null))
          this.moc18.Delete();
        if (Entity.op_Inequality(this.moc19, (Entity) null))
          this.moc19.Delete();
        if (Entity.op_Inequality(this.moc20, (Entity) null))
          this.moc20.Delete();
        if (Entity.op_Inequality(this.moc21, (Entity) null))
          this.moc21.Delete();
        if (Entity.op_Inequality(this.moc22, (Entity) null))
          this.moc22.Delete();
        if (Entity.op_Inequality(this.moc23, (Entity) null))
          this.moc23.Delete();
        if (Entity.op_Inequality(this.moc24, (Entity) null))
          this.moc24.Delete();
        if (Entity.op_Inequality(this.moc25, (Entity) null))
          this.moc25.Delete();
        Script.Wait(1000);
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_")
        });
        this.spawnmoc("gr_prop_inttruck_anchor", 1103.512f, -3000.188f, -39.92914f, 1, true);
        this.spawnmoc("gr_prop_inttruck_command_01", 1103.512f, -3000.188f, -39.92914f, 2, true);
        this.spawnmoc("gr_prop_inttruck_empty_03", 1103.512f, -3000.188f, -39.92914f, 3, true);
        this.spawnmoc("gr_prop_inttruck_vehicle_01", 1103.512f, -3000.188f, -39.92914f, 4, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -3002.19f, -39.9353f, 5, true);
        this.spawnmoc("gr_prop_inttruck_doorblocker", 1103.508f, -3010.185f, -39.92914f, 6, true);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3008.938f, -39.19909f, 7, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1102.111f, -3005.438f, -39.19909f, 8, false);
        this.spawnmoc("gr_prop_highendchair_gr_01a", 1104.811f, -3005.638f, -39.19909f, 9, false);
        this.spawnmoc("gr_prop_gr_trailer_tv_02", 1103.512f, -3010.188f, -39.92914f, 10, true);
        this.spawnmoc("gr_prop_inttruck_door_01", 1104.037f, -2994.19f, -39.9355f, 11, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_01", 1103.512f, -3010.188f, -39.92914f, 15, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_02", 1103.512f, -3010.188f, -39.92914f, 16, true);
        this.spawnmoc("gr_prop_gr_trailer_monitor_03", 1103.512f, -3010.188f, -39.92914f, 17, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.788f, -3008.17f, -39.139f, 22, true);
        this.spawnmoc("gr_prop_gr_console_01", 1101.897f, -3006.265f, -39.139f, 23, true);
        this.spawnmoc("gr_prop_gr_console_01", 1105.054f, -3005.122f, -39.139f, 24, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-2f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-10f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(6.000001f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-128.9994f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-40.99873f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.8997f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(-0.002756382f),
          InputArgument.op_Implicit(-0.0004692419f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(49.083f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(129.896f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) -8852765493248041465L, new InputArgument[6]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(-44.33f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc1),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc5),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc6),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc7),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc8),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc9),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc10),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc11),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc15),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc16),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc17),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc22),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc23),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc24),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor2])
        });
        this.spawnmoc("gr_prop_inttruck_light_e2", 1103.512f, -3002.188f, -39.92914f, 12, true);
        this.spawnmoc(this.MocLightsVehicle[this.CurrentMocLightsVehicle], 1103.512f, -2994.188f, -39.92914f, 13, true);
        this.spawnmoc(this.MocLightsCommand[this.CurrentMocLightsCommand], 1103.512f, -3010.188f, -39.92914f, 14, true);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.moc3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.moc4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.moc2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc12),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc13),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.moc14),
          InputArgument.op_Implicit(this.MocColor2[this.CurrentMocColor1])
        });
      }
      else
        this.DisplayHelpTextThisFrame("EAI : Invalid Combination, Adjust your bays");
    }

    public int GetTickCount() => 7500;

    public void AddArcades()
    {
      this.ArcadePos.Clear();
      this.ArcadePos.Add(new Vector3(2729.6f, -382.4f, -50f));
      this.ArcadePos.Add(new Vector3(2728.7f, -382.4f, -50f));
      this.ArcadePos.Add(new Vector3(2729.6f, -385.6f, -50f));
      this.ArcadePos.Add(new Vector3(2731.2f, -383.8f, -50f));
      using (List<Prop>.Enumerator enumerator = this.ArcadeProps.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            this.ArcadePos.Add(((Entity) current).GetOffsetInWorldCoords(new Vector3(0.0f, -1f, 0.0f)));
        }
      }
    }

    public void RefreshArcadeInterior()
    {
      try
      {
        int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2730.0),
          InputArgument.op_Implicit(-380.0),
          InputArgument.op_Implicit(-50.0)
        });
        int num2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2697.615),
          InputArgument.op_Implicit(-376.3891),
          InputArgument.op_Implicit(-56.46193)
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_01")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_02")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_03")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_04")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_05")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_06")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_07")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_08")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Entity_Set_Plushie_09")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Cockroaches")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Drone_Parts")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Electric_Drill")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Fireman_Helmetv")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Gruppe_Sechs_Outfits")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Hacking_Device")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Plastic_Explosives")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Stealth_Outfits")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Swipe_Card_01a")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Swipe_Card_01b")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Vault_Drill_Alt")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Vault_KeyCard_01a")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Vault_Laser")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Vault_Laser_Alt")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_ceiling_beams")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_ceiling_flat")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_ceiling_mirror")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_derelict")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_derelict_carpet")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_derelict_clean_up")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_streetx4")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_brawler")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_cabs")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_gunner")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_king")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_love")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_monkey")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_patriot")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_racer")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_retro")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_strife")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_teller")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_big_screen")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_constant_geometry")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_01")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_02")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_03")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_04")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_05")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_06")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_07")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_floor_option_08")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_hip_light_no_neon")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_01")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_02")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_03")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_04")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_05")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_06")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_07")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_neon_option_08")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_01")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_02")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_03")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_04")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_05")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_06")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_07")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_mural_option_08")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_ret_light_no_neon")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_screens")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("set_plan_arcade_x4")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_bed")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_casino")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_computer")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_garage")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_hacker")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_keypad")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_mechanic")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_no_bed")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_plans")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_pre_setup")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_scribbles")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_setup")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_vault")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_wall")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_weapons")
        });
        if (this.PushieID == 0)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_04")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_05")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_06")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_07")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_08")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_09")
          });
        }
        if (this.PushieID == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
        if (this.PushieID == 2)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
        }
        if (this.PushieID == 3)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
        }
        if (this.PushieID == 4)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_04")
          });
        }
        if (this.PushieID == 5)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_04")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_05")
          });
        }
        if (this.PushieID == 6)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_04")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_05")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_06")
          });
        }
        if (this.PushieID == 7)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_04")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_05")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_06")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_07")
          });
        }
        if (this.PushieID == 8)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_04")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_05")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_06")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_07")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_08")
          });
        }
        if (this.PushieID == 9)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_01")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_02")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_03")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_04")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_05")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_06")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_07")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_08")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("Entity_Set_Plushie_09")
          });
        }
        if (this.PushieID == 10)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Cockroaches")
          });
        if (this.UnlockedBreachingEquipment == 1)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Hacking_Device")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Plastic_Explosives")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Swipe_Card_01a")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Swipe_Card_01bv")
          });
        }
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("Set_Plan_Drone_Parts")
        });
        if (this.UnlockedOutfitsEquipment == 1)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Stealth_Outfits")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Fireman_Helmet")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Gruppe_Sechs_Outfits")
          });
        }
        if (this.UnlockedDilllEquipment == 1)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Electric_Drill")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Vault_Drill")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Vault_Drill_Alt")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Vault_KeyCard_01a")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Vault_Laser")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_vault")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("Set_Plan_Vault_Laser_Alt")
          });
        }
        if (this.ArcadeStyle == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_arcade_set_derelict_clean_up")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_arcade_set_derelict")
          });
        }
        if (this.ArcadeStyle == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_arcade_set_ceiling_beams")
          });
        if (this.ArcadeStyle == 2)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_arcade_set_ceiling_flat")
          });
        if (this.ArcadeStyle == 3)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_arcade_set_ceiling_mirror")
          });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_streetx4")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_brawler")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_cabs")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_claw")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_gunner")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_king")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_love")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_monkey")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_patriot")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_racer")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_retro")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_strife")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_arcade_set_trophy_teller")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_big_screen")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_constant_geometry")
        });
        if (this.ArcadeFloodID == 0)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_arcade_set_derelict_carpet")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_02")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_03")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_04")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_05")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_06")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_07")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_08")
          });
        }
        if (this.ArcadeFloodID == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_01")
          });
        if (this.ArcadeFloodID == 2)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_02")
          });
        if (this.ArcadeFloodID == 3)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_03")
          });
        if (this.ArcadeFloodID == 4)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_04")
          });
        if (this.ArcadeFloodID == 5)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_05")
          });
        if (this.ArcadeFloodID == 6)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_06")
          });
        if (this.ArcadeFloodID == 7)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_07")
          });
        if (this.ArcadeFloodID == 8)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_floor_option_08")
          });
        if (this.NeonArtID == 0)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_hip_light_no_neon")
          });
        if (this.NeonArtID == 0)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_02")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_03")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_04")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_05")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_06")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_07")
          });
        }
        if (this.NeonArtID == 8)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_01")
          });
        if (this.NeonArtID == 7)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_02")
          });
        if (this.NeonArtID == 6)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_03")
          });
        if (this.NeonArtID == 5)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_04")
          });
        if (this.NeonArtID == 4)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_05")
          });
        if (this.NeonArtID == 3)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_06")
          });
        if (this.NeonArtID == 2)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_07")
          });
        if (this.NeonArtID == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_neon_option_08")
          });
        if (this.MuralID == 0)
        {
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_01")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_02")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_03")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_04")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_05")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_06")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_07")
          });
          Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_08")
          });
        }
        if (this.MuralID == 8)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_01")
          });
        if (this.MuralID == 7)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_02")
          });
        if (this.MuralID == 6)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_03")
          });
        if (this.MuralID == 5)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_04")
          });
        if (this.MuralID == 4)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_05")
          });
        if (this.MuralID == 3)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_06")
          });
        if (this.MuralID == 2)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_07")
          });
        if (this.MuralID == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num1),
            InputArgument.op_Implicit("entity_set_mural_option_08")
          });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("entity_set_ret_light_no_neon")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("entity_set_screens")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_arcade_x4")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_bed")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_computer")
        });
        if (this.UnlockedGarage == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_garage")
          });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_keypad")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_mechanic")
        });
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit("set_plan_no_bed")
        });
        if (this.UnlockedPlansEquipment == 1)
        {
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_casino")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_hacker")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_plans")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_pre_setup")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_scribbles")
          });
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_setup")
          });
        }
        if (this.UnlockedGarage == 0)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_wall")
          });
        if (this.UnlockedGunlocker == 1)
          Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit("set_plan_weapons")
          });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num1)
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num2)
        });
        if (this.ArcadeProps.Count > 0)
        {
          using (List<Prop>.Enumerator enumerator = this.ArcadeProps.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Prop current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
        }
        this.ArcadeProps.Clear();
        this.ArcadePos.Clear();
        this.SetupINDArcade(this.Arcade1Ver, 1);
        this.SetupINDArcade(this.Arcade2Ver, 2);
        this.SetupINDArcade(this.Arcade3Ver, 3);
        this.SetupINDArcade(this.Arcade4Ver, 4);
        this.SetupINDArcade(this.Arcade5Ver, 5);
        this.SetupINDArcade(this.Arcade6Ver, 6);
        this.SetupINDArcade(this.Arcade7Ver, 7);
        this.SetupINDArcade(this.Arcade8Ver, 8);
        this.SetupINDArcade(this.Arcade9Ver, 9);
        this.SetupINDArcade(this.Arcade10Ver, 10);
        this.SetupINDArcade(this.Arcade11Ver, 11);
        this.SetupINDArcade(this.Arcade12Ver, 12);
        this.SetupINDArcade(this.Arcade13Ver, 13);
        this.SetupINDArcade(this.Arcade14Ver, 14);
        this.SetupINDArcade(this.Arcade15Ver, 15);
        this.SetupINDArcade(this.Arcade16Ver, 16);
        this.SetupINDArcade(this.Arcade17Ver, 17);
        this.SetupINDArcade(this.Arcade18Ver, 18);
        this.SetupINDArcade(this.Arcade19Ver, 19);
        this.SetupINDArcade(this.Arcade2Ver, 20);
        this.AddArcades();
      }
      catch
      {
      }
    }

    public void SetupINDArcade(int Ver, int ArcNo)
    {
      Vector3 vector3;
      ((Vector3) ref vector3).\u002Ector(0.0f, 0.0f, 0.0f);
      float num = 0.0f;
      if (ArcNo == 1)
      {
        vector3 = Class1.ArcadePos1;
        num = this.ArcadeRot1;
      }
      if (ArcNo == 2)
      {
        vector3 = Class1.ArcadePos2;
        num = this.ArcadeRot2;
      }
      if (ArcNo == 3)
      {
        vector3 = Class1.ArcadePos3;
        num = this.ArcadeRot3;
      }
      if (ArcNo == 4)
      {
        vector3 = Class1.ArcadePos4;
        num = this.ArcadeRot4;
      }
      if (ArcNo == 5)
      {
        vector3 = Class1.ArcadePos5;
        num = this.ArcadeRot5;
      }
      if (ArcNo == 6)
      {
        vector3 = Class1.ArcadePos6;
        num = this.ArcadeRot6;
      }
      if (ArcNo == 7)
      {
        vector3 = Class1.ArcadePos7;
        num = this.ArcadeRot7;
      }
      if (ArcNo == 8)
      {
        vector3 = Class1.ArcadePos8;
        num = this.ArcadeRot8;
      }
      if (ArcNo == 9)
      {
        vector3 = Class1.ArcadePos9;
        num = this.ArcadeRot9;
      }
      if (ArcNo == 10)
      {
        vector3 = Class1.ArcadePos10;
        num = this.ArcadeRot10;
      }
      if (ArcNo == 11)
      {
        vector3 = Class1.ArcadePos11;
        num = this.ArcadeRot11;
      }
      if (ArcNo == 12)
      {
        vector3 = Class1.ArcadePos12;
        num = this.ArcadeRot12;
      }
      if (ArcNo == 13)
      {
        vector3 = Class1.ArcadePos13;
        num = this.ArcadeRot13;
      }
      if (ArcNo == 14)
      {
        vector3 = Class1.ArcadePos14;
        num = this.ArcadeRot14;
      }
      if (ArcNo == 15)
      {
        vector3 = Class1.ArcadePos15;
        num = this.ArcadeRot15;
      }
      if (ArcNo == 16)
      {
        vector3 = Class1.ArcadePos16;
        num = this.ArcadeRot16;
      }
      if (ArcNo == 17)
      {
        vector3 = Class1.ArcadePos17;
        num = this.ArcadeRot17;
      }
      if (ArcNo == 18)
      {
        vector3 = Class1.ArcadePos18;
        num = this.ArcadeRot18;
      }
      if (ArcNo == 19)
      {
        vector3 = Class1.ArcadePos19;
        num = this.ArcadeRot19;
      }
      if (ArcNo == 20)
      {
        vector3 = Class1.ArcadePos20;
        num = this.ArcadeRot20;
      }
      if ((uint) Ver <= 0U)
        return;
      if (Ver == 1)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_street_01a"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
      if (Ver == 2)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_street_01b"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
      if (Ver == 3)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_street_01c"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
      if (Ver == 4)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_street_01d"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
      if (Ver == 5)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_invade_01a"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
      if (Ver == 6)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_wizard_01a"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
      if (Ver == 7)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_space_01a"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
      if (Ver == 8)
        this.ArcadeProps.Add(World.CreateProp(this.RequestModel("ch_prop_arcade_space_01a"), vector3, new Vector3(0.0f, 0.0f, num), true, false));
    }

    public void RefreshPenthouse()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(976.6364),
        InputArgument.op_Implicit(70.29476),
        InputArgument.op_Implicit(115.1641)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_05")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_06")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_07")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_08")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_09")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Dealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_NoDealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Bar_Clutter")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_1")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_2")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_after")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_LOUNGE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_OFFICE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      if (this.Penthouse_Style == 0)
        Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
          InputArgument.op_Implicit(this.Penthouse_Colour)
        });
      if (this.Penthouse_Style == 1)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_01")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_01"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 2)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_02")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_02"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 3)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_03")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_03"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 4)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_04")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_04"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 5)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_05")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_05"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 6)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_06")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_06"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 7)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_07")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_07"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 8)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_08")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_08"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Style == 9)
      {
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_09")
        });
        if ((uint) this.Penthouse_Style > 0U)
        {
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Pattern_09"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
          Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
            InputArgument.op_Implicit(this.Penthouse_Colour)
          });
        }
      }
      if (this.Penthouse_Spa == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
        });
      if (this.Penthouse_Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
        });
      if (this.Penthouse_Media == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_PokerDealer == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Dealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Dealer"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_PokerDealer == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_NoDealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_NoDealer"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Arcade == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
        });
      if (this.Penthouse_Arcade == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
        });
      if (this.Penthouse_BarLight == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_pent_bar_light_0")
        });
      if (this.Penthouse_BarLight == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_pent_bar_light_01")
        });
      if (this.Penthouse_BarLight == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_pent_bar_light_02")
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      if (this.Penthouse_ExtraBedroom == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
        });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_LOUNGE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_OFFICE_BLOCKER")
      });
      if (this.Penthouse_Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
        });
      if (this.Penthouse_Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
        });
      if (this.Penthouse_Bar != 0)
        return;
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
      });
    }

    public void ArcadeInteriorOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass549_0 displayClass5490 = new Class1.\u003C\u003Ec__DisplayClass549_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5490.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      displayClass5490.StyleCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5490.MuralCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5490.NeonArtCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5490.FloorCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5490.PushieCost = 0.0f;
      List<object> objectList1 = new List<object>()
      {
        (object) "Los Santos Rock Radio",
        (object) "Non-Stop-Pop FM",
        (object) "Radio Los Santos",
        (object) "Channel X",
        (object) "West Coast Talk Radio",
        (object) "Rebel Radio",
        (object) "Soulwax FM",
        (object) "East Los FM",
        (object) "West Coast Classics",
        (object) "Blue Ark",
        (object) "World Wide FM",
        (object) "FlyLo FM",
        (object) "The Lowdown 91.1",
        (object) "The Lab",
        (object) "Radio Mirror Park",
        (object) "Space 103.2",
        (object) "Vinewood Boulevard Radio",
        (object) "Blonded Los Santos 97.8 FM",
        (object) "Los Santos Underground Radio",
        (object) "Self Radio"
      };
      List<object> objectList2 = new List<object>()
      {
        (object) false,
        (object) true
      };
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) "Derelict");
      objectList3.Add((object) "Exposed Hipster");
      objectList3.Add((object) "Total Focus");
      objectList3.Add((object) "Take A Shine");
      List<object> objectList4 = new List<object>();
      objectList4.Add((object) "Naked");
      objectList4.Add((object) "Another Realm");
      objectList4.Add((object) "All The Colors");
      objectList4.Add((object) "Wireframed");
      objectList4.Add((object) "Spray Forever");
      objectList4.Add((object) "Racing Stripes");
      objectList4.Add((object) "Pixelated Thought");
      objectList4.Add((object) "So Kawaii");
      objectList4.Add((object) "O Edgy");
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) "Naked");
      objectList5.Add((object) "Mighty Sword");
      objectList5.Add((object) "Penatrator");
      objectList5.Add((object) "LS Nights");
      objectList5.Add((object) "Game Over");
      objectList5.Add((object) "Emulator");
      objectList5.Add((object) "BFFL");
      objectList5.Add((object) "Crotch Rocket");
      objectList5.Add((object) "Adult Content");
      List<object> objectList6 = new List<object>();
      objectList6.Add((object) "Naked");
      objectList6.Add((object) "Prim and Proper");
      objectList6.Add((object) "Scale Up");
      objectList6.Add((object) "Yay Rainbow");
      objectList6.Add((object) "The Lab");
      objectList6.Add((object) "Intergalactic");
      objectList6.Add((object) "Understated Stars");
      objectList6.Add((object) "Super Fun Playthings");
      objectList6.Add((object) "Thunderclap");
      List<object> objectList7 = new List<object>();
      objectList7.Add((object) "Naked");
      objectList7.Add((object) "Plushie 1");
      objectList7.Add((object) "Plushie 2");
      objectList7.Add((object) "Plushie 3");
      objectList7.Add((object) "Plushie 4");
      objectList7.Add((object) "Plushie 5");
      objectList7.Add((object) "Plushie 6");
      objectList7.Add((object) "Plushie 7");
      objectList7.Add((object) "Plushie 8");
      objectList7.Add((object) "Plushie 9");
      List<object> objectList8 = new List<object>();
      objectList8.Add((object) "None");
      objectList8.Add((object) "RC King (F)");
      objectList8.Add((object) "Lightfield (F)");
      objectList8.Add((object) "Demoiltion (NF)");
      objectList8.Add((object) "Dogfight (NF)");
      objectList8.Add((object) "Captain's Edge (NF)");
      objectList8.Add((object) "Hot Pursuit (NF)");
      objectList8.Add((object) "Drive (F)");
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Cost = 0.0f;
      UIMenu uiMenu1 = this.Woredrobepool.AddSubMenu(this.DCHDLC, "Arcade Customization");
      this.GUIMenus.Add(uiMenu1);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.ST = new UIMenuListItem("Style : ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass5490.ST);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.F = new UIMenuListItem("Floor : ", objectList6, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass5490.F);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.M = new UIMenuListItem("Mural : ", objectList4, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass5490.M);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.P = new UIMenuListItem("Pushie : ", objectList7, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass5490.P);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.NA = new UIMenuListItem("Neon Art : ", objectList5, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass5490.NA);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Buy = new UIMenuItem("Buy " + displayClass5490.Cost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5490.Buy);
      UIMenuItem uiMenuItem1 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu1.AddItem(uiMenuItem1);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.UGarage = new UIMenuItem("Garage Space : $600,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5490.UGarage);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.UGunlocker = new UIMenuItem("Gunlocker : $1,000,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5490.UGunlocker);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.UDrill = new UIMenuItem("Drilling Equipment : $1,250,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5490.UDrill);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.UBreaching = new UIMenuItem("Breaching Equipment : $1,450,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5490.UBreaching);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.UOutfits = new UIMenuItem("Heist Outfits : $450,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5490.UOutfits);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.UPlans = new UIMenuItem("Heist Plans : $850,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5490.UPlans);
      UIMenuItem uiMenuItem2 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu1.AddItem(uiMenuItem2);
      UIMenu uiMenu2 = this.Woredrobepool.AddSubMenu(uiMenu1, "Buy More Arcade Machines");
      this.GUIMenus.Add(uiMenu2);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc1 = new UIMenuListItem("Arcade 1 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc1);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc2 = new UIMenuListItem("Arcade 2 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc2);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc3 = new UIMenuListItem("Arcade 3 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc3);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc4 = new UIMenuListItem("Arcade 4 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc4);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc5 = new UIMenuListItem("Arcade 5 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc5);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc6 = new UIMenuListItem("Arcade 6 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc6);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc7 = new UIMenuListItem("Arcade 7 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc7);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc8 = new UIMenuListItem("Arcade 8 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc8);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc9 = new UIMenuListItem("Arcade 9 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc9);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc10 = new UIMenuListItem("Arcade 10 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc10);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc11 = new UIMenuListItem("Arcade 11 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc11);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc12 = new UIMenuListItem("Arcade 12 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc12);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc13 = new UIMenuListItem("Arcade 13 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc13);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc14 = new UIMenuListItem("Arcade 14 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc14);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc15 = new UIMenuListItem("Arcade 15 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc15);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc16 = new UIMenuListItem("Arcade 16 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc16);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc17 = new UIMenuListItem("Arcade 17 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc17);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc18 = new UIMenuListItem("Arcade 18 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc18);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc19 = new UIMenuListItem("Arcade 19 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc19);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.Arc20 = new UIMenuListItem("Arcade 20 Game : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5490.Arc20);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.SetARC = new UIMenuItem("Set Arcade Machines ");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5490.SetARC);
      // ISSUE: reference to a compiler-generated field
      displayClass5490.SetARC.set_Description("(F) = Functional Game, (NF) = Non Functional Game");
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass5490, __methodptr(\u003CArcadeInteriorOptions\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass5490, __methodptr(\u003CArcadeInteriorOptions\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) displayClass5490, __methodptr(\u003CArcadeInteriorOptions\u003Eb__2)));
    }

    private void SetupDecalOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass550_0 displayClass5500 = new Class1.\u003C\u003Ec__DisplayClass550_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5500.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.ExecutiveDLC, "Mod Shop Decals");
      this.GUIMenus.Add(uiMenu);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal1 = new UIMenuItem("Decal 1");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal1);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal2 = new UIMenuItem("Decal 2");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal2);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal3 = new UIMenuItem("Decal 3");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal3);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal4 = new UIMenuItem("Decal 4");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal4);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal5 = new UIMenuItem("Decal 5");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal5);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal6 = new UIMenuItem("Decal 6");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal6);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal7 = new UIMenuItem("Decal 7");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal7);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal8 = new UIMenuItem("Decal 8");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal8);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal9 = new UIMenuItem("Decal 9");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal9);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal10 = new UIMenuItem("Decal 10");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal10);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal11 = new UIMenuItem("Decal 11");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal11);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal12 = new UIMenuItem("Decal 12");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal12);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal13 = new UIMenuItem("Decal 13");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal13);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal14 = new UIMenuItem("Decal 14");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal14);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal15 = new UIMenuItem("Decal 15");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal15);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal16 = new UIMenuItem("Decal 16");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal16);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal17 = new UIMenuItem("Decal 17");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal17);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal18 = new UIMenuItem("Decal 18");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal18);
      // ISSUE: reference to a compiler-generated field
      displayClass5500.Decal19 = new UIMenuItem("Decal 19");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5500.Decal19);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5500, __methodptr(\u003CSetupDecalOptions\u003Eb__0)));
    }

    public void SetCashProps()
    {
      this.CashProp.Add("cash_set_01");
      this.CashProp.Add("cash_set_02");
      this.CashProp.Add("cash_set_03");
      this.CashProp.Add("cash_set_04");
      this.CashProp.Add("cash_set_05");
      this.CashProp.Add("cash_set_06");
      this.CashProp.Add("cash_set_07");
      this.CashProp.Add("cash_set_08");
      this.CashProp.Add("cash_set_09");
      this.CashProp.Add("cash_set_10");
      this.CashProp.Add("cash_set_11");
      this.CashProp.Add("cash_set_12");
      this.CashProp.Add("cash_set_13");
      this.CashProp.Add("cash_set_14");
      this.CashProp.Add("cash_set_15");
      this.CashProp.Add("cash_set_16");
      this.CashProp.Add("cash_set_17");
      this.CashProp.Add("cash_set_18");
      this.CashProp.Add("cash_set_19");
      this.CashProp.Add("cash_set_20");
      this.CashProp.Add("cash_set_21");
      this.CashProp.Add("cash_set_22");
      this.CashProp.Add("cash_set_23");
      this.CashProp.Add("cash_set_24");
    }

    public void RefreshExecutiveOffice()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_02_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_dt1_11_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_13_office_03c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_02a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_01c")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03a")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03b")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("ex_sm_15_office_03c")
      });
      if (this.EnableArcadiusTower)
      {
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-141.1987),
          InputArgument.op_Implicit(-620.913),
          InputArgument.op_Implicit(168.8205)
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.AracdiusTowerStyle)
        });
        if (this.EnableAracdiusTowerCashProps)
        {
          foreach (string str in this.CashProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        else
        {
          foreach (string str in this.CashProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        if (this.EnableAracdiusTowerExProps)
        {
          foreach (string str in this.ExProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        else
        {
          foreach (string str in this.ExProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num)
        });
      }
      if (this.EnableMazeBankTower)
      {
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-75.8466),
          InputArgument.op_Implicit(-826.9893),
          InputArgument.op_Implicit(243.3859)
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MazeBankTowerStyle)
        });
        if (this.EnableMazeBankTowerCashProps)
        {
          foreach (string str in this.CashProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        else
        {
          foreach (string str in this.CashProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        if (this.EnableMazeBankTowerExProps)
        {
          foreach (string str in this.ExProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        else
        {
          foreach (string str in this.ExProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num)
        });
      }
      if (this.EnableLombokTower)
      {
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-1579.756),
          InputArgument.op_Implicit(-565.0661),
          InputArgument.op_Implicit(108.523)
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.MazeLombokTowerStyle)
        });
        if (this.EnableLombokTowerCashProps)
        {
          foreach (string str in this.CashProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        else
        {
          foreach (string str in this.CashProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        if (this.EnableLombokTowerExProps)
        {
          foreach (string str in this.ExProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        else
        {
          foreach (string str in this.ExProp)
          {
            if (!str.Equals(""))
              Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(str)
              });
          }
        }
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num)
        });
      }
      if (!this.EnableMazeBankWestTower)
        return;
      int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(-1392.542),
        InputArgument.op_Implicit(-480.4011),
        InputArgument.op_Implicit(72.04211)
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit(this.MazeBankWestTowerStyle)
      });
      if (this.EnableMazeBankWestTowerCashProps)
      {
        foreach (string str in this.CashProp)
        {
          if (!str.Equals(""))
            Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
            {
              InputArgument.op_Implicit(num1),
              InputArgument.op_Implicit(str)
            });
        }
      }
      else
      {
        foreach (string str in this.CashProp)
        {
          if (!str.Equals(""))
            Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
            {
              InputArgument.op_Implicit(num1),
              InputArgument.op_Implicit(str)
            });
        }
      }
      if (this.EnableMazeBankWestTowerExProps)
      {
        foreach (string str in this.ExProp)
        {
          if (!str.Equals(""))
            Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
            {
              InputArgument.op_Implicit(num1),
              InputArgument.op_Implicit(str)
            });
        }
      }
      else
      {
        foreach (string str in this.ExProp)
        {
          if (!str.Equals(""))
            Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
            {
              InputArgument.op_Implicit(num1),
              InputArgument.op_Implicit(str)
            });
        }
      }
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
    }

    public void DeletePentInterior()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(976.6364f),
        InputArgument.op_Implicit(70.29476f),
        InputArgument.op_Implicit(115.1641)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_05")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_06")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_07")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_08")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_09")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Dealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_NoDealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Bar_Clutter")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_1")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_2")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_after")
      });
    }

    public void SpawnYacht(Vector3 V)
    {
      try
      {
        Prop[] nearbyProps1 = World.GetNearbyProps(V, 200f);
        if ((uint) nearbyProps1.Length > 0U)
        {
          foreach (Prop prop in nearbyProps1)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
              ((Entity) prop).Delete();
          }
        }
        if (this.YachtType == 0)
        {
          if (!this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o1_rail_a";
          else if (this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o1_rail_b";
          this.Rail = "apa_MP_Apa_Yacht_O1_Rail_B";
          this.YachtTop = "apa_mp_apa_yacht_option1";
          this.YachtLauncher = "apa_mp_apa_yacht_launcher_01a";
        }
        if (this.YachtType == 1)
        {
          if (!this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o2_rail_a";
          else if (this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o2_rail_b";
          this.YachtTop = "apa_mp_apa_yacht_option2";
          this.YachtLauncher = "apa_mp_apa_yacht_launcher_02a";
        }
        if (this.YachtType == 2)
        {
          if (!this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o3_rail_a";
          else if (this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o3_rail_b";
          this.YachtTop = "apa_mp_apa_yacht_option3";
          this.YachtLauncher = "apa_mp_apa_yacht_launcher_02a";
        }
        Prop[] nearbyProps2 = World.GetNearbyProps(V, (float) this.SpawnDist, this.RequestModel("apa_mp_apa_yacht "));
        if ((uint) nearbyProps2.Length > 0U)
        {
          foreach (Prop prop in nearbyProps2)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
            {
              this.Base = prop;
              if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Base),
                  InputArgument.op_Implicit(this.ShipColor)
                });
            }
          }
        }
        Prop[] nearbyProps3 = World.GetNearbyProps(V, (float) this.SpawnDist, this.RequestModel("apa_mp_apa_yacht"));
        if ((uint) nearbyProps3.Length > 0U)
        {
          foreach (Prop prop in nearbyProps3)
          {
            if (Entity.op_Inequality((Entity) prop, (Entity) null))
            {
              this.Base = prop;
              if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Base),
                  InputArgument.op_Implicit(this.ShipColor)
                });
            }
          }
        }
        if (Entity.op_Equality((Entity) this.Base, (Entity) null))
        {
          try
          {
            if ((uint) nearbyProps2.Length > 0U)
            {
              foreach (Prop prop in nearbyProps2)
              {
                if (Entity.op_Inequality((Entity) prop, (Entity) null))
                {
                  this.Base = prop;
                  if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                    Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(this.Base),
                      InputArgument.op_Implicit(this.ShipColor)
                    });
                }
              }
            }
          }
          catch (Exception ex)
          {
            UI.Notify("~r~ Major Error : Yacht Failed to get Prop base!, contact : ~g~HKH191~w~");
          }
        }
        if (!Entity.op_Inequality((Entity) this.Base, (Entity) null))
          return;
        UI.Notify("~b~ Starting Yacht Spawning, please be patient");
        this.SpawnProp(this.YachtTop, V, new Vector3(0.0f, 0.0f, 0.0f), 1);
        this.SpawnProp(this.Rail, V, new Vector3(0.0f, 0.0f, 0.0f), 2);
        if (this.YachtType == 0)
        {
          if (this.Lighting == 1)
          {
            if (this.LightingColor == 1)
              this.SpawnProp("apa_mp_apa_y1_l1a", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 2)
              this.SpawnProp("apa_mp_apa_y1_l1b", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 3)
              this.SpawnProp("apa_mp_apa_y1_l1c", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 4)
              this.SpawnProp("apa_mp_apa_y1_l1d", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
          }
          if (this.Lighting == 2)
          {
            if (this.LightingColor == 1)
              this.SpawnProp("apa_mp_apa_y1_l2a", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 2)
              this.SpawnProp("apa_mp_apa_y1_l2b", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 3)
              this.SpawnProp("apa_mp_apa_y1_l2c", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 4)
              this.SpawnProp("apa_mp_apa_y1_l2d", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
          }
          if (this.DoorType == 0)
            this.SpawnProp("apa_mp_apa_yacht_door", V, new Vector3(0.0f, 0.0f, 0.0f), 6);
          if (this.DoorType == 1)
            this.SpawnProp("apa_mp_apa_yacht_door2", V, new Vector3(0.0f, 0.0f, 0.0f), 6);
          this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", V, new Vector3(0.0f, 0.0f, 0.0f), 7);
          this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", V, new Vector3(0.0f, 0.0f, 0.0f), 7);
        }
        if (this.YachtType == 1)
        {
          this.SpawnProp("apa_mp_apa_yacht_option2_cola", V, new Vector3(0.0f, 0.0f, 0.0f), 1);
          this.SpawnProp("apa_mp_apa_yacht_option2_colb", V, new Vector3(0.0f, 0.0f, 0.0f), 2);
          if (this.Lighting == 1)
          {
            if (this.LightingColor == 1)
              this.SpawnProp("apa_mp_apa_y2_l1a", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 2)
              this.SpawnProp("apa_mp_apa_y2_l1b", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 3)
              this.SpawnProp("apa_mp_apa_y2_l1c", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 4)
              this.SpawnProp("apa_mp_apa_y2_l1d", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
          }
          if (this.Lighting == 2)
          {
            if (this.LightingColor == 1)
              this.SpawnProp("apa_mp_apa_y2_l2a", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 2)
              this.SpawnProp("apa_mp_apa_y2_l2b", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 3)
              this.SpawnProp("apa_mp_apa_y2_l2c", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 4)
              this.SpawnProp("apa_mp_apa_y2_l2d", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
          }
          if (this.DoorType == 0)
            this.SpawnProp("apa_mp_apa_yacht_door", V, new Vector3(0.0f, 0.0f, 0.0f), 6);
          if (this.DoorType == 1)
            this.SpawnProp("apa_mp_apa_yacht_door2", V, new Vector3(0.0f, 0.0f, 0.0f), 6);
          this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", V, new Vector3(0.0f, 0.0f, 0.0f), 7);
          this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", V, new Vector3(0.0f, 0.0f, 0.0f), 7);
        }
        if (this.YachtType == 2)
        {
          this.SpawnProp("apa_mp_apa_yacht_option3_cola", V, new Vector3(0.0f, 0.0f, 0.0f), 1);
          this.SpawnProp("apa_mp_apa_yacht_option3_colb", V, new Vector3(0.0f, 0.0f, 0.0f), 2);
          this.SpawnProp("apa_mp_apa_yacht_option3_colc", V, new Vector3(0.0f, 0.0f, 0.0f), 1);
          this.SpawnProp("apa_mp_apa_yacht_option3_cold", V, new Vector3(0.0f, 0.0f, 0.0f), 2);
          this.SpawnProp("apa_mp_apa_yacht_option3_cole", V, new Vector3(0.0f, 0.0f, 0.0f), 1);
          if (this.Lighting == 1)
          {
            if (this.LightingColor == 1)
              this.SpawnProp("apa_mp_apa_y3_l1a", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 2)
              this.SpawnProp("apa_mp_apa_y3_l1b", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 3)
              this.SpawnProp("apa_mp_apa_y3_l1c", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 4)
              this.SpawnProp("apa_mp_apa_y3_l1d", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
          }
          if (this.Lighting == 2)
          {
            if (this.LightingColor == 1)
              this.SpawnProp("apa_mp_apa_y3_l2a", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 2)
              this.SpawnProp("apa_mp_apa_y3_l2b", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 3)
              this.SpawnProp("apa_mp_apa_y3_l2c", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
            if (this.LightingColor == 4)
              this.SpawnProp("apa_mp_apa_y3_l2d", V, new Vector3(0.0f, 0.0f, 0.0f), 3);
          }
          if (this.DoorType == 0)
            this.SpawnProp("apa_mp_apa_yacht_door", V, new Vector3(0.0f, 0.0f, 0.0f), 6);
          if (this.DoorType == 1)
            this.SpawnProp("apa_mp_apa_yacht_door2", V, new Vector3(0.0f, 0.0f, 0.0f), 6);
          this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", V, new Vector3(0.0f, 0.0f, 0.0f), 7);
          this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", V, new Vector3(0.0f, 0.0f, 0.0f), 7);
        }
      }
      catch
      {
        UI.Notify("~r~ Failed to Spawn Yacht~w~, Attempting again!");
      }
    }

    private void OnShutdown(object sender, EventArgs e)
    {
      if (false)
        return;
      if (Entity.op_Inequality((Entity) this.PlaneCrash, (Entity) null))
        ((Entity) this.PlaneCrash).Delete();
      using (List<Prop>.Enumerator enumerator = this.OnlineProp.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Blip>.Enumerator enumerator = this.InteriorBlips.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Blip current = enumerator.Current;
          if (Blip.op_Inequality(current, (Blip) null))
            current.Remove();
        }
      }
      using (List<Prop>.Enumerator enumerator = this.ArcadeProps.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
        ((Entity) this.Base).Delete();
      using (List<Prop>.Enumerator enumerator = this.Props.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality(this.moc1, (Entity) null))
        this.moc1.Delete();
      if (Entity.op_Inequality(this.moc2, (Entity) null))
        this.moc2.Delete();
      if (Entity.op_Inequality(this.moc3, (Entity) null))
        this.moc3.Delete();
      if (Entity.op_Inequality(this.moc4, (Entity) null))
        this.moc4.Delete();
      if (Entity.op_Inequality(this.moc5, (Entity) null))
        this.moc5.Delete();
      if (Entity.op_Inequality(this.moc6, (Entity) null))
        this.moc6.Delete();
      if (Entity.op_Inequality(this.moc7, (Entity) null))
        this.moc7.Delete();
      if (Entity.op_Inequality(this.moc8, (Entity) null))
        this.moc8.Delete();
      if (Entity.op_Inequality(this.moc9, (Entity) null))
        this.moc9.Delete();
      if (Entity.op_Inequality(this.moc10, (Entity) null))
        this.moc10.Delete();
      if (Entity.op_Inequality(this.moc11, (Entity) null))
        this.moc11.Delete();
      if (Entity.op_Inequality(this.moc12, (Entity) null))
        this.moc11.Delete();
      if (Entity.op_Inequality(this.moc13, (Entity) null))
        this.moc13.Delete();
      if (Entity.op_Inequality(this.moc14, (Entity) null))
        this.moc14.Delete();
      if (Entity.op_Inequality(this.moc15, (Entity) null))
        this.moc15.Delete();
      if (Entity.op_Inequality(this.moc16, (Entity) null))
        this.moc16.Delete();
      if (Entity.op_Inequality(this.moc17, (Entity) null))
        this.moc17.Delete();
      if (Entity.op_Inequality(this.moc18, (Entity) null))
        this.moc18.Delete();
      if (Entity.op_Inequality(this.moc19, (Entity) null))
        this.moc19.Delete();
      if (Entity.op_Inequality(this.moc20, (Entity) null))
        this.moc20.Delete();
      if (Entity.op_Inequality(this.moc21, (Entity) null))
        this.moc21.Delete();
      if (Entity.op_Inequality(this.moc22, (Entity) null))
        this.moc22.Delete();
      if (Entity.op_Inequality(this.moc23, (Entity) null))
        this.moc23.Delete();
      if (Entity.op_Inequality(this.moc24, (Entity) null))
        this.moc24.Delete();
      if (Entity.op_Inequality(this.moc25, (Entity) null))
        this.moc25.Delete();
    }

    private void spawnmoc(string model, float x, float y, float z, int moc, bool coll)
    {
      int num1 = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
      {
        InputArgument.op_Implicit(model)
      });
      if (!(bool) Function.Call<bool>((Hash) 3871372195910563393L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      }))
        return;
      int num2 = 3500;
      float num3 = (float) (this.GetTickCount() + num2);
      Function.Call((Hash) -7620891402436058964L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
      while (true)
      {
        if (Function.Call<bool>((Hash) -7447569096790455982L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num1)
        }) == 0 && (double) this.GetTickCount() <= (double) num3)
          Script.Wait(0);
        else
          break;
      }
      Entity entity = (Entity) Function.Call<Entity>((Hash) 5808896370743568450L, new InputArgument[7]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(x),
        InputArgument.op_Implicit(y),
        InputArgument.op_Implicit(z),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0)
      });
      Function.Call((Hash) -1577279073827460165L, new InputArgument[2]
      {
        InputArgument.op_Implicit(entity),
        InputArgument.op_Implicit(true)
      });
      Function.Call((Hash) 2565419363613909893L, new InputArgument[7]
      {
        InputArgument.op_Implicit(entity),
        InputArgument.op_Implicit(x),
        InputArgument.op_Implicit(y),
        InputArgument.op_Implicit(z),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) -7909249851600711733L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
      int num4 = 1500;
      float num5 = (float) (this.GetTickCount() + num4);
      if (coll)
      {
        while (true)
        {
          if (Function.Call<bool>((Hash) 2507559639599083578L, new InputArgument[1]
          {
            InputArgument.op_Implicit(num1)
          }) == 0)
          {
            if ((double) this.GetTickCount() <= (double) num5)
              Script.Wait(0);
            else
              break;
          }
          else
            goto label_10;
        }
        Function.Call((Hash) -1931210984146806101L, new InputArgument[1]
        {
          InputArgument.op_Implicit(num1)
        });
label_10:
        Function.Call((Hash) 1914599121192125055L, new InputArgument[3]
        {
          InputArgument.op_Implicit(entity),
          InputArgument.op_Implicit(true),
          InputArgument.op_Implicit(true)
        });
      }
      if ((bool) Function.Call<bool>((Hash) 8230805619690780346L, new InputArgument[1]
      {
        InputArgument.op_Implicit(entity)
      }))
        Function.Call((Hash) 4795391166277829702L, new InputArgument[2]
        {
          InputArgument.op_Implicit(entity),
          InputArgument.op_Implicit(1)
        });
      Function.Call((Hash) -1931210984146806101L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
      if (moc == 1)
        this.moc1 = entity;
      if (moc == 2)
        this.moc2 = entity;
      if (moc == 3)
        this.moc3 = entity;
      if (moc == 4)
        this.moc4 = entity;
      if (moc == 5)
        this.moc5 = entity;
      if (moc == 6)
        this.moc6 = entity;
      if (moc == 7)
        this.moc7 = entity;
      if (moc == 8)
        this.moc8 = entity;
      if (moc == 9)
        this.moc9 = entity;
      if (moc == 10)
        this.moc10 = entity;
      if (moc == 11)
        this.moc11 = entity;
      if (moc == 12)
        this.moc12 = entity;
      if (moc == 13)
        this.moc13 = entity;
      if (moc == 14)
        this.moc14 = entity;
      if (moc == 15)
        this.moc15 = entity;
      if (moc == 16)
        this.moc16 = entity;
      if (moc == 17)
        this.moc17 = entity;
      if (moc == 18)
        this.moc18 = entity;
      if (moc == 19)
        this.moc19 = entity;
      if (moc == 20)
        this.moc20 = entity;
      if (moc == 21)
        this.moc21 = entity;
      if (moc == 22)
        this.moc22 = entity;
      if (moc == 23)
        this.moc23 = entity;
      if (moc == 24)
        this.moc24 = entity;
      if (moc == 25)
        this.moc25 = entity;
    }

    public void LoadDystopian_4()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_02")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_04")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadDystopian_5()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_02")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadDystopian_3()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_04")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_03")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadDystopian_2()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_04")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_02")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadDystopian_10()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_04")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_10")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadDystopian_7()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_04")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_07")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadDystopian_8()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_04")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_08")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadDystopian_12()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_04")
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_12")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Dystopian_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_dystopian_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets")
      });
    }

    public void LoadScifi_2()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_02")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_scifi_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_scifi")
      });
    }

    public void LoadScifi_4()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_04")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_scifi_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_scifi")
      });
    }

    public void LoadScifi_5()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_scifi_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_scifi")
      });
    }

    public void LoadScifi_10()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_10")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_scifi_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_scifi")
      });
    }

    public void LoadWasteland_2()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_02")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_CentreLine_Wasteland_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_wasteland")
      });
    }

    public void LoadScifi_9()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_09")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Scifi_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_centreline_scifi_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_scifi")
      });
    }

    public void LoadWasteland_9()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_09")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_CentreLine_Wasteland_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_wasteland")
      });
    }

    public void LoadWasteland_4()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_04")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_CentreLine_Wasteland_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_wasteland")
      });
    }

    public void LoadWasteland_5()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_CentreLine_Wasteland_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_wasteland")
      });
    }

    public void LoadWasteland_7()
    {
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("xs_arena_interior_vip")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(2782.99f),
        InputArgument.op_Implicit(-3898.15f),
        InputArgument.op_Implicit(140f)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      for (int index = 0; index < this.NStadium.Count; ++index)
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit(this.NStadium[index])
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Crowd_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_a")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_b")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_c")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Team_band_d")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_07")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pit_Fence_Oval")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Wasteland_Scene")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_CentreLine_Wasteland_05")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Turrets_wasteland")
      });
    }
  }
}
